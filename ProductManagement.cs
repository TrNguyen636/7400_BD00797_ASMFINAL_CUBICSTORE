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
    public partial class ProductManagement : UserControl
    {
        string connectionString = "Server=MSI\\SQLEXPRESS;Database=CubicStore;Integrated Security=true;";
        public ProductManagement()
        {
            InitializeComponent();
            LoadProducts();

        }
        private void LoadProducts()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Products";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvProducts.DataSource = dt;
            }
        }
        private void ProductManagement_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            // Validate required fields
            if (string.IsNullOrWhiteSpace(txtProductCode.Text) ||
                string.IsNullOrWhiteSpace(txtProductName.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text) ||
                string.IsNullOrWhiteSpace(txtQuantity.Text) ||
                string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("All fields (Product Code, Name, Price, Quantity, Description) are required.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate numeric input
            if (!decimal.TryParse(txtPrice.Text, out decimal price) ||
                !int.TryParse(txtQuantity.Text, out int quantity))
            {
                MessageBox.Show("Price must be a valid number and Quantity must be a valid integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (price < 0 || quantity < 0)
            {
                MessageBox.Show("Price and Quantity cannot be negative.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Check for duplicate ProductCode or ProductName
                string checkQuery = @"SELECT COUNT(*) FROM Products 
                              WHERE ProductCode = @Code OR ProductName = @Name";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@Code", txtProductCode.Text.Trim());
                checkCmd.Parameters.AddWithValue("@Name", txtProductName.Text.Trim());

                int exists = (int)checkCmd.ExecuteScalar();
                if (exists > 0)
                {
                    MessageBox.Show("Product Code or Product Name already exists.",
                                    "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Insert into database
                string insertQuery = @"INSERT INTO Products 
                 (ProductCode, ProductName, SellingPrice, InventoryQuantity, Description)
                 VALUES (@Code, @Name, @Price, @Qty, @Desc)";

                SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                insertCmd.Parameters.AddWithValue("@Code", txtProductCode.Text.Trim());
                insertCmd.Parameters.AddWithValue("@Name", txtProductName.Text.Trim());
                insertCmd.Parameters.AddWithValue("@Price", price);
                insertCmd.Parameters.AddWithValue("@Qty", quantity);
                insertCmd.Parameters.AddWithValue("@Desc", txtDescription.Text.Trim());

                insertCmd.ExecuteNonQuery();
            }

            LoadProducts();
            MessageBox.Show("Product inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearFormInputs();
        }

        private void ClearFormInputs()
        {
            txtProductCode.Clear();
            txtProductName.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            txtDescription.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null)
            {
                MessageBox.Show("Please select a product to update.");
                return;
            }

            // Validate input
            if (string.IsNullOrWhiteSpace(txtProductCode.Text) ||
                string.IsNullOrWhiteSpace(txtProductName.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text) ||
                string.IsNullOrWhiteSpace(txtQuantity.Text) ||
                string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("All fields (Product Code, Name, Price, Quantity, Description) are required.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price) ||
                !int.TryParse(txtQuantity.Text, out int quantity))
            {
                MessageBox.Show("Price must be a valid number and Quantity must be a valid integer.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (price < 0 || quantity < 0)
            {
                MessageBox.Show("Price and Quantity cannot be negative.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int productId = Convert.ToInt32(dgvProducts.CurrentRow.Cells["ProductID"].Value);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Check for duplicate code or name (excluding the current product)
                string checkQuery = @"SELECT COUNT(*) FROM Products 
                              WHERE (ProductCode = @Code OR ProductName = @Name)
                              AND ProductID != @Id";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@Code", txtProductCode.Text.Trim());
                checkCmd.Parameters.AddWithValue("@Name", txtProductName.Text.Trim());
                checkCmd.Parameters.AddWithValue("@Id", productId);

                int exists = (int)checkCmd.ExecuteScalar();
                if (exists > 0)
                {
                    MessageBox.Show("Another product with the same code or name already exists.",
                                    "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Proceed with update
                string updateQuery = @"UPDATE Products 
                               SET ProductCode=@Code, ProductName=@Name, SellingPrice=@Price, 
                                   InventoryQuantity=@Qty, Description=@Desc 
                               WHERE ProductID=@Id";

                SqlCommand cmd = new SqlCommand(updateQuery, conn);
                cmd.Parameters.AddWithValue("@Id", productId);
                cmd.Parameters.AddWithValue("@Code", txtProductCode.Text.Trim());
                cmd.Parameters.AddWithValue("@Name", txtProductName.Text.Trim());
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@Qty", quantity);
                cmd.Parameters.AddWithValue("@Desc", txtDescription.Text.Trim());

                cmd.ExecuteNonQuery();
              
            }
            LoadProducts(); 
            MessageBox.Show("Product updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearFormInputs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null) return;
            int productId = Convert.ToInt32(dgvProducts.CurrentRow.Cells["ProductID"].Value);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Products WHERE ProductID = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", productId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadProducts();
            MessageBox.Show("Deleted successfully.");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtProductCode.Clear();
            txtProductName.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            txtDescription.Clear();
        }

        private void btnViewImage_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow != null)
            {
                int productId = Convert.ToInt32(dgvProducts.CurrentRow.Cells["ProductID"].Value);
                ViewProductImageForm imageForm = new ViewProductImageForm(productId);
                imageForm.ShowDialog();
            }
        }

        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow != null)
            {
                txtProductCode.Text = dgvProducts.CurrentRow.Cells["ProductCode"].Value.ToString();
                txtProductName.Text = dgvProducts.CurrentRow.Cells["ProductName"].Value.ToString();
                txtPrice.Text = dgvProducts.CurrentRow.Cells["SellingPrice"].Value.ToString();
                txtQuantity.Text = dgvProducts.CurrentRow.Cells["InventoryQuantity"].Value.ToString();
                txtDescription.Text = dgvProducts.CurrentRow.Cells["Description"].Value.ToString();
            }
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT * FROM Products 
                                 WHERE ProductName LIKE @kw OR ProductCode LIKE @kw";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@kw", "%" + keyword + "%");

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvProducts.DataSource = dt;
            }
        }
    }
}
