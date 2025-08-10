using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CubicStore.Controls
{
    public partial class UC_SalesManagementcs : UserControl
    {
        private string connectionString = "Server=MSI\\SQLEXPRESS;Database=CubicStore;Integrated Security=true;";
        private DataTable cartTable = new DataTable();

        public UC_SalesManagementcs(int employeeId)
        {
            InitializeComponent();
            InitializeCart();
            txtEmployeeID.Text = employeeId.ToString();
            txtEmployeeID.ReadOnly = true;
            LoadCustomers();
            LoadProducts();
        }
        private void InitializeCart()
        {
            cartTable.Columns.Add("ProductID", typeof(int));
            cartTable.Columns.Add("ProductName", typeof(string));
            cartTable.Columns.Add("Quantity", typeof(int));
            cartTable.Columns.Add("SellingPrice", typeof(decimal));
            cartTable.Columns.Add("TotalPrice", typeof(decimal), "Quantity * SellingPrice");

            dgvCart.DataSource = cartTable;
        }

        private void LoadCustomers()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT CustomerID, CustomerName FROM Customers";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbCustomer.DataSource = dt;
                cbCustomer.DisplayMember = "CustomerName";
                cbCustomer.ValueMember = "CustomerID";
            }
        }

        private void LoadProducts()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT ProductID, ProductName FROM Products";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbProduct.DataSource = dt;
                cbProduct.DisplayMember = "ProductName";
                cbProduct.ValueMember = "ProductID";
            }
        }

        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            if (cbProduct.SelectedValue == null || string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                MessageBox.Show("Please select a product and enter quantity!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int productId = Convert.ToInt32(cbProduct.SelectedValue);
            int quantity;
            if (!int.TryParse(txtQuantity.Text, out quantity) || quantity <= 0)
            {
                MessageBox.Show("Invalid quantity!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string productName = cbProduct.Text;
            decimal price;
            int availableStock;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "SELECT SellingPrice, InventoryQuantity FROM Products WHERE ProductID = @id", conn);
                cmd.Parameters.AddWithValue("@id", productId);
                SqlDataReader reader = cmd.ExecuteReader();
                if (!reader.Read())
                {
                    MessageBox.Show("Product not found!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                price = (decimal)reader["SellingPrice"];
                availableStock = (int)reader["InventoryQuantity"];
                reader.Close();
            }

            if (quantity > availableStock)
            {
                MessageBox.Show($"Not enough stock. Only {availableStock} left!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            cartTable.Rows.Add(productId, productName, quantity, price);
            txtQuantity.Clear();
            UpdateTotalPrice();
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (dgvCart.CurrentRow != null)
            {
                dgvCart.Rows.RemoveAt(dgvCart.CurrentRow.Index);
                UpdateTotalPrice();
            }
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            cartTable.Clear();
            UpdateTotalPrice();
        }

        private void btnConfirmSale_Click(object sender, EventArgs e)
        {
            if (cartTable.Rows.Count == 0)
            {
                MessageBox.Show("Please add products to the cart before confirming the sale!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int employeeId = int.Parse(txtEmployeeID.Text);
            int customerId = Convert.ToInt32(cbCustomer.SelectedValue);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    int saleId = InsertSale(conn, transaction, employeeId, customerId);

                    foreach (DataRow row in cartTable.Rows)
                    {
                        int productId = (int)row["ProductID"];
                        int quantity = (int)row["Quantity"];
                        decimal price = (decimal)row["SellingPrice"];

                        InsertSaleDetail(conn, transaction, saleId, productId, quantity, price);
                        UpdateInventory(conn, transaction, productId, quantity);
                        InsertPurchaseHistory(conn, transaction, customerId, productId, quantity, price);
                    }

                    transaction.Commit();
                    MessageBox.Show("Sale completed.");
                    cartTable.Clear();
                    UpdateTotalPrice();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void UpdateTotalPrice()
        {
            decimal total = 0;
            foreach (DataRow row in cartTable.Rows)
            {
                total += Convert.ToDecimal(row["TotalPrice"]);
            }
            lblTotalAmount.Text = total.ToString("N0") + " VND";
        }
    

    private int InsertSale(SqlConnection conn, SqlTransaction tran, int employeeId, int customerId)
        {
            SqlCommand cmd = new SqlCommand(
                "INSERT INTO Sales (EmployeeID, CustomerID) OUTPUT INSERTED.SaleID VALUES (@empId, @custId)",
                conn, tran);
            cmd.Parameters.AddWithValue("@empId", employeeId);
            cmd.Parameters.AddWithValue("@custId", customerId);
            return (int)cmd.ExecuteScalar();
        }

        private void InsertSaleDetail(SqlConnection conn, SqlTransaction tran, int saleId, int productId, int quantity, decimal price)
        {
            SqlCommand cmd = new SqlCommand(
                "INSERT INTO SaleDetails (SaleID, ProductID, Quantity, SellingPrice) " +
                "VALUES (@saleId, @productId, @qty, @price)", conn, tran);
            cmd.Parameters.AddWithValue("@saleId", saleId);
            cmd.Parameters.AddWithValue("@productId", productId);
            cmd.Parameters.AddWithValue("@qty", quantity);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.ExecuteNonQuery();
        }

        private void UpdateInventory(SqlConnection conn, SqlTransaction tran, int productId, int quantity)
        {
            SqlCommand cmd = new SqlCommand(
                "UPDATE Products SET InventoryQuantity = InventoryQuantity - @qty " +
                "WHERE ProductID = @id AND InventoryQuantity >= @qty", conn, tran);
            cmd.Parameters.AddWithValue("@qty", quantity);
            cmd.Parameters.AddWithValue("@id", productId);
            int affected = cmd.ExecuteNonQuery();
            if (affected == 0)
                throw new Exception($"Not enough stock for ProductID {productId}");
        }

        private void InsertPurchaseHistory(SqlConnection conn, SqlTransaction tran, int customerId, int productId, int quantity, decimal price)
        {
            SqlCommand cmd = new SqlCommand(
                "INSERT INTO PurchaseHistory (CustomerID, ProductID, Quantity, SellingPrice, PurchaseDate) " +
                "VALUES (@custId, @prodId, @qty, @price, GETDATE())", conn, tran);
            cmd.Parameters.AddWithValue("@custId", customerId);
            cmd.Parameters.AddWithValue("@prodId", productId);
            cmd.Parameters.AddWithValue("@qty", quantity);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.ExecuteNonQuery();
        }


    } 
}
