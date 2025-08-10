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
    public partial class UC_CustomerManagement : UserControl
    {
        string connectionString = "Server=MSI\\SQLEXPRESS;Database=CubicStore;Integrated Security=true;";

        public UC_CustomerManagement()
        {
            InitializeComponent();
            LoadCustomers();
        }
        private void LoadCustomers()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Customers";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvCustomer.DataSource = dt;
            }
        }

        private void ClearInputs()
        {
            txtCustomerID.Clear();
            txtCustomerCode.Clear();
            txtCustomerName.Clear();
            txtPhoneNumber.Clear();
            txtAddress.Clear();
            txtSearch.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomerCode.Text) ||
                string.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                MessageBox.Show("Customer Code and Name are required!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string checkQuery = "SELECT COUNT(*) FROM Customers WHERE CustomerCode = @code";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@code", txtCustomerCode.Text.Trim());

                conn.Open();
                int exists = (int)checkCmd.ExecuteScalar();
                if (exists > 0)
                {
                    MessageBox.Show("Customer code already exists!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = @"INSERT INTO Customers (CustomerCode, CustomerName, PhoneNumber, Address)
                                 VALUES (@code, @name, @phone, @address)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@code", txtCustomerCode.Text.Trim());
                cmd.Parameters.AddWithValue("@name", txtCustomerName.Text.Trim());
                cmd.Parameters.AddWithValue("@phone", txtPhoneNumber.Text.Trim());
                cmd.Parameters.AddWithValue("@address", txtAddress.Text.Trim());

                cmd.ExecuteNonQuery();
            }

            LoadCustomers();
            ClearInputs();
            MessageBox.Show("Customer added successfully!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomerID.Text)) return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Customers 
                                 SET CustomerCode = @code, CustomerName = @name, PhoneNumber = @phone, Address = @address
                                 WHERE CustomerID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@code", txtCustomerCode.Text.Trim());
                cmd.Parameters.AddWithValue("@name", txtCustomerName.Text.Trim());
                cmd.Parameters.AddWithValue("@phone", txtPhoneNumber.Text.Trim());
                cmd.Parameters.AddWithValue("@address", txtAddress.Text.Trim());
                cmd.Parameters.AddWithValue("@id", txtCustomerID.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadCustomers();
            ClearInputs();
            MessageBox.Show("Customer updated.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCustomer.CurrentRow == null) return;

            int id = Convert.ToInt32(dgvCustomer.CurrentRow.Cells["CustomerID"].Value);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Customers WHERE CustomerID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadCustomers();
            ClearInputs();
            MessageBox.Show("Customer deleted.");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT * FROM Customers 
                                 WHERE CustomerName LIKE @kw OR CustomerCode LIKE @kw";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@kw", "%" + keyword + "%");

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvCustomer.DataSource = dt;
            }
        }

        private void btnPurchaseHistory_Click(object sender, EventArgs e)
        {
            if (dgvCustomer.CurrentRow == null)
            {
                MessageBox.Show("Select a customer first.");
                return;
            }

            int customerId = Convert.ToInt32(dgvCustomer.CurrentRow.Cells["CustomerID"].Value);
            PurchaseHistoryForm form = new PurchaseHistoryForm(customerId);
            form.ShowDialog();
        }

        private void UC_CustomerManagement_Load(object sender, EventArgs e)
        {

        }

        private void dgvCustomer_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCustomer.CurrentRow != null)
            {
                txtCustomerID.Text = dgvCustomer.CurrentRow.Cells["CustomerID"].Value.ToString();
                txtCustomerCode.Text = dgvCustomer.CurrentRow.Cells["CustomerCode"].Value.ToString();
                txtCustomerName.Text = dgvCustomer.CurrentRow.Cells["CustomerName"].Value.ToString();
                txtPhoneNumber.Text = dgvCustomer.CurrentRow.Cells["PhoneNumber"].Value.ToString();
                txtAddress.Text = dgvCustomer.CurrentRow.Cells["Address"].Value.ToString();
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomerCode.Text) ||
                string.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                MessageBox.Show("Customer Code and Name are required!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string checkQuery = "SELECT COUNT(*) FROM Customers WHERE CustomerCode = @code";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@code", txtCustomerCode.Text.Trim());

                conn.Open();
                int exists = (int)checkCmd.ExecuteScalar();
                if (exists > 0)
                {
                    MessageBox.Show("Customer code already exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = @"INSERT INTO Customers (CustomerCode, CustomerName, PhoneNumber, Address)
                                 VALUES (@code, @name, @phone, @address)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@code", txtCustomerCode.Text.Trim());
                cmd.Parameters.AddWithValue("@name", txtCustomerName.Text.Trim());
                cmd.Parameters.AddWithValue("@phone", txtPhoneNumber.Text.Trim());
                cmd.Parameters.AddWithValue("@address", txtAddress.Text.Trim());

                cmd.ExecuteNonQuery();
            }

            LoadCustomers();
            ClearInputs();
            MessageBox.Show("Customer added.");
        }
    }
}
