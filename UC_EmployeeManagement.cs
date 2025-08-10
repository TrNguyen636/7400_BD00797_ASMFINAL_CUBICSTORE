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
    public partial class UC_EmployeeManagement : UserControl
    {
        string connectionString = "Server=MSI\\SQLEXPRESS;Database=CubicStore;Integrated Security=true;";

        public UC_EmployeeManagement()
        {
            InitializeComponent();
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT EmployeeID, EmployeeCode, EmployeeName, Position, GroupID FROM Employees";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvEmployees.AutoGenerateColumns = true;
                dgvEmployees.DataSource = dt;
            }
        }
        private void ClearInputs()
        {
            txtEmployeeID.Clear();
            txtEmployeeCode.Clear();
            txtEmployeeName.Clear();
            txtEmployeePosition.Clear();
            txtEmployeeGroupID.Clear();
            txtSearch.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string code = txtEmployeeCode.Text.Trim();
            string name = txtEmployeeName.Text.Trim();
            string position = txtEmployeePosition.Text.Trim();
            string groupId = txtEmployeeGroupID.Text.Trim();

            if (string.IsNullOrWhiteSpace(code) || string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(position) || string.IsNullOrWhiteSpace(groupId))
            {
                MessageBox.Show("All field are required!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string username = code.ToLower();
            string defaultPassword = ComputeSha256Hash("123456");

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Check for duplicate EmployeeCode
                    SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Employees WHERE EmployeeCode = @Code", conn);
                    checkCmd.Parameters.AddWithValue("@Code", code);
                    int exists = (int)checkCmd.ExecuteScalar();

                    if (exists > 0)
                    {
                        MessageBox.Show("Employee code already exists!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Insert new employee
                    string query = @"INSERT INTO Employees (EmployeeCode, EmployeeName, Position, GroupID, Username, PasswordHash, MustChangePassword)
                                     VALUES (@Code, @Name, @Position, @GroupID, @Username, @PasswordHash, 1)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Code", code);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Position", position);
                    cmd.Parameters.AddWithValue("@GroupID", groupId);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@PasswordHash", defaultPassword);

                    cmd.ExecuteNonQuery();

                    LoadEmployees();
                    ClearInputs();
                    MessageBox.Show("Employee added successfully with default password: 123456");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            //if (string.IsNullOrWhiteSpace(txtEmployeeCode.Text) ||
            //    string.IsNullOrWhiteSpace(txtEmployeeName.Text) ||
            //    string.IsNullOrWhiteSpace(txtEmployeePosition.Text) ||
            //    string.IsNullOrWhiteSpace(txtEmployeeGroupID.Text))
            //{
            //    MessageBox.Show("All fields are required.");
            //    return;
            //}

            //string username = txtEmployeeCode.Text.Trim().ToLower(); // Example
            //string defaultPassword = ComputeSha256Hash("123456");

            //using (SqlConnection conn = new SqlConnection(connectionString))
            //{
            //    string query = @"INSERT INTO Employees (EmployeeCode, EmployeeName, Position, GroupID, Username, PasswordHash)
            //                     VALUES (@Code, @Name, @Position, @GroupID, @Username, @PasswordHash)";
            //    SqlCommand cmd = new SqlCommand(query, conn);
            //    cmd.Parameters.AddWithValue("@Code", txtEmployeeCode.Text);
            //    cmd.Parameters.AddWithValue("@Name", txtEmployeeName.Text);
            //    cmd.Parameters.AddWithValue("@Position", txtEmployeePosition.Text);
            //    cmd.Parameters.AddWithValue("@GroupID", txtEmployeeGroupID.Text);
            //    cmd.Parameters.AddWithValue("@Username", username);
            //    cmd.Parameters.AddWithValue("@PasswordHash", defaultPassword);

            //    conn.Open();
            //    cmd.ExecuteNonQuery();
            //}

            //LoadEmployees();
            //ClearInputs();
            //MessageBox.Show("Employee added with default password: 123456");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmployeeID.Text)) return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Employees 
                                 SET EmployeeCode=@Code, EmployeeName=@Name, Position=@Position, GroupID=@GroupID 
                                 WHERE EmployeeID=@Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", txtEmployeeID.Text);
                cmd.Parameters.AddWithValue("@Code", txtEmployeeCode.Text);
                cmd.Parameters.AddWithValue("@Name", txtEmployeeName.Text);
                cmd.Parameters.AddWithValue("@Position", txtEmployeePosition.Text);
                cmd.Parameters.AddWithValue("@GroupID", txtEmployeeGroupID.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadEmployees();
            ClearInputs();
            MessageBox.Show("Employee updated successfully.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.CurrentRow == null) return;

            int id = Convert.ToInt32(dgvEmployees.CurrentRow.Cells["EmployeeID"].Value);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Employees WHERE EmployeeID=@Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadEmployees();
            MessageBox.Show("Employee deleted.");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT EmployeeID, EmployeeCode, EmployeeName, Position, GroupID 
                                 FROM Employees
                                 WHERE EmployeeName LIKE @kw OR EmployeeCode LIKE @kw";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@kw", "%" + keyword + "%");
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvEmployees.DataSource = dt;
            }
        }

        private string ComputeSha256Hash(string rawData)
        {
            using (System.Security.Cryptography.SHA256 sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(rawData));
                return string.Concat(bytes.Select(b => b.ToString("x2")));
            }
        }

        private void dgvEmployees_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEmployees.CurrentRow != null)
            {
                txtEmployeeID.Text = dgvEmployees.CurrentRow.Cells["EmployeeID"].Value.ToString();
                txtEmployeeCode.Text = dgvEmployees.CurrentRow.Cells["EmployeeCode"].Value.ToString();
                txtEmployeeName.Text = dgvEmployees.CurrentRow.Cells["EmployeeName"].Value.ToString();
                txtEmployeePosition.Text = dgvEmployees.CurrentRow.Cells["Position"].Value.ToString();
                txtEmployeeGroupID.Text = dgvEmployees.CurrentRow.Cells["GroupID"].Value.ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }
    }
}
