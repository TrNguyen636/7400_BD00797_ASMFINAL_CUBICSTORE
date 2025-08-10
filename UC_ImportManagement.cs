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
    public partial class UC_ImportManagement : UserControl
    {
        string connectionString = "Server=MSI\\SQLEXPRESS;Database=CubicStore;Integrated Security=true;";
        public UC_ImportManagement()
        {
            InitializeComponent();
            LoadProducts();
            LoadImports();
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

        private void LoadImports()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT pi.ImportID, p.ProductName, pi.Quantity, pi.ImportPrice, pi.ImportDate
                                 FROM ProductImports pi
                                 JOIN Products p ON pi.ProductID = p.ProductID";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvImport.DataSource = dt;
            }
        }
        private void ClearInputs()
        {
            cbProduct.SelectedIndex = 0;
            txtQuantity.Clear();
            txtPrice.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbProduct.SelectedValue == null ||
               string.IsNullOrWhiteSpace(txtQuantity.Text) ||
               string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Please select a product and enter quantity and price!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Quantity must be a positive number!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal importPrice) || importPrice <= 0)
            {
                MessageBox.Show("Import price must be a positive number!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int productId = Convert.ToInt32(cbProduct.SelectedValue);
            DateTime importDate = dateTimePicker1.Value;

            // Get current selling price to compare
            decimal sellingPrice;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string priceQuery = "SELECT SellingPrice FROM Products WHERE ProductID = @id";
                SqlCommand cmd = new SqlCommand(priceQuery, conn);
                cmd.Parameters.AddWithValue("@id", productId);
                conn.Open();
                object result = cmd.ExecuteScalar();
                sellingPrice = result != null ? Convert.ToDecimal(result) : 0;
            }

            if (importPrice == sellingPrice)
            {
                MessageBox.Show("Import price cannot be equal to selling price!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Insert Import + Update inventory
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO ProductImports (ProductID, Quantity, ImportPrice, ImportDate)
                                 VALUES (@ProductID, @Quantity, @Price, @Date);
                                 UPDATE Products SET InventoryQuantity += @Quantity WHERE ProductID = @ProductID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ProductID", productId);
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                cmd.Parameters.AddWithValue("@Price", importPrice);
                cmd.Parameters.AddWithValue("@Date", importDate);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadImports();
            ClearInputs();
            MessageBox.Show("Import added successfully.");

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvImport.CurrentRow == null)
            {
                MessageBox.Show("Please select a record to update.");
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0 ||
                !decimal.TryParse(txtPrice.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Invalid quantity or price!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int importId = Convert.ToInt32(dgvImport.CurrentRow.Cells["ImportID"].Value);
            int productId = Convert.ToInt32(cbProduct.SelectedValue);
            DateTime importDate = dateTimePicker1.Value;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"UPDATE ProductImports
                                 SET ProductID = @ProductID, Quantity = @Quantity,
                                     ImportPrice = @Price, ImportDate = @Date
                                 WHERE ImportID = @ImportID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ImportID", importId);
                cmd.Parameters.AddWithValue("@ProductID", productId);
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@Date", importDate);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadImports();
            ClearInputs();
            MessageBox.Show("Import updated successfully.");
        }
        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (dgvImport.CurrentRow == null)
            {
                MessageBox.Show("Please select a record to delete!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int importId = Convert.ToInt32(dgvImport.CurrentRow.Cells["ImportID"].Value);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM ProductImports WHERE ImportID = @id", conn);
                cmd.Parameters.AddWithValue("@id", importId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadImports();
            ClearInputs();
            MessageBox.Show("Import deleted.");
        }

        private void dgvImport_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvImport.CurrentRow != null)
            {
                cbProduct.Text = dgvImport.CurrentRow.Cells["ProductName"].Value.ToString();
                txtQuantity.Text = dgvImport.CurrentRow.Cells["Quantity"].Value.ToString();
                txtPrice.Text = dgvImport.CurrentRow.Cells["ImportPrice"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(dgvImport.CurrentRow.Cells["ImportDate"].Value);
            }
        }

        private void cbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (int.TryParse(cbProduct.SelectedValue?.ToString(), out int productId))
            //{
            //    using (SqlConnection conn = new SqlConnection(connectionString))
            //    {
            //        string query = "SELECT SellingPrice FROM Products WHERE ProductID = @id";
            //        SqlCommand cmd = new SqlCommand(query, conn);
            //        cmd.Parameters.AddWithValue("@id", productId);

            //        conn.Open();
            //        object result = cmd.ExecuteScalar();
            //        txtPrice.Text = result != null ? Convert.ToDecimal(result).ToString("N0") : "";
            //    }
            //}
            //else
            //{
            //    txtPrice.Text = "";
            //}
        }
    }
}
