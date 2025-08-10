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
    public partial class PurchaseHistoryForm : Form
    {
        private int customerId;
        string connectionString = "Server=MSI\\SQLEXPRESS;Database=CubicStore;Integrated Security=true;";
        public PurchaseHistoryForm(int customerId)
        {
            InitializeComponent();
            this.customerId = customerId;
            LoadPurchaseHistory();
            LoadCustomerName();
        }

        private void LoadCustomerName()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT CustomerName FROM Customers WHERE CustomerID = @CustomerID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CustomerID", customerId);
                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    this.Text = $"Purchase History - {result.ToString()} (Customer ID: {customerId})";
                }
            }
        }
        private void LoadPurchaseHistory()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT 
                        ph.HistoryID,
                        ph.CustomerID,
                        ph.ProductID,
                        p.ProductName,
                        ph.Quantity,
                        ph.SellingPrice,
                        ph.PurchaseDate
                    FROM PurchaseHistory ph
                    JOIN Products p ON ph.ProductID = p.ProductID
                    WHERE ph.CustomerID = @CustomerID
                    ORDER BY ph.PurchaseDate DESC";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@CustomerID", customerId);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvPurchaseHistory.DataSource = dt;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPurchaseHistory_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPurchaseHistory.CurrentRow != null)
            {
                txtHistoryID.Text = dgvPurchaseHistory.CurrentRow.Cells["HistoryID"].Value.ToString();
                txtCustomerID.Text = dgvPurchaseHistory.CurrentRow.Cells["CustomerID"].Value.ToString();
                txtProductID.Text = dgvPurchaseHistory.CurrentRow.Cells["ProductID"].Value.ToString();
                txtQuantity.Text = dgvPurchaseHistory.CurrentRow.Cells["Quantity"].Value.ToString();
                txtSellingPrice.Text = dgvPurchaseHistory.CurrentRow.Cells["SellingPrice"].Value.ToString();
                txtPurchaseDate.Text = dgvPurchaseHistory.CurrentRow.Cells["PurchaseDate"].Value.ToString();
            }
        }
    }
}
