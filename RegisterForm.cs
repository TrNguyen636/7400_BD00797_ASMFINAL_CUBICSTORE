using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CubicStore
{
    public partial class RegisterForm : Form
    {
        private string connectionString = "Server=MSI\\SQLEXPRESS;Database=CubicStore;Integrated Security=true;";

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT GroupID, GroupName FROM EmployeeGroups";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cboGroup.DataSource = dt;
                cboGroup.DisplayMember = "GroupName";
                cboGroup.ValueMember = "GroupID";
                cboGroup.SelectedIndex = -1; // No default selection
            }

        }
       

        private void btnRegisterConfirm_Click(object sender, EventArgs e)
        {
            string empCode = txtEmployeeCode.Text.Trim();
            string empName = txtEmployeeName.Text.Trim();
            string position = txtPosition.Text.Trim();
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (string.IsNullOrWhiteSpace(empCode) || string.IsNullOrWhiteSpace(empName) ||
                string.IsNullOrWhiteSpace(position) || string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) || cboGroup.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all required fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password.Length < 5)
            {
                MessageBox.Show("Password must be at least 5 characters.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string hash = ComputeSha256Hash(password);
            int groupId = Convert.ToInt32(cboGroup.SelectedValue);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Check for existing employee code or username
                string checkQuery = "SELECT COUNT(*) FROM Employees WHERE EmployeeCode = @code OR Username = @username";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@code", empCode);
                checkCmd.Parameters.AddWithValue("@username", username);
                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Employee Code or Username already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string insertQuery = @"
                    INSERT INTO Employees (
                        EmployeeCode, EmployeeName, Position, GroupID,
                        Username, PasswordHash, MustChangePassword
                    )
                    VALUES (
                        @code, @name, @position, @groupId,
                        @username, @hash, 1
                    )";

                SqlCommand cmd = new SqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@code", empCode);
                cmd.Parameters.AddWithValue("@name", empName);
                cmd.Parameters.AddWithValue("@position", position);
                cmd.Parameters.AddWithValue("@groupId", groupId);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@hash", hash);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee registered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Registration failed: " + ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ClearForm()
        {
            txtEmployeeCode.Clear();
            txtEmployeeName.Clear();
            txtUserName.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            txtPosition.Clear();
            cboGroup.SelectedIndex = -1;
        }

        private string ComputeSha256Hash(string raw)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(raw));
                return string.Concat(bytes.Select(b => b.ToString("x2")));
            }
        }
    }
}
