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
    public partial class ChangePasswordForm : Form
    {
        private int employeeID;
        private string connectionString = "Server=MSI\\SQLEXPRESS;Database=CubicStore;Integrated Security=true;";
        public ChangePasswordForm(int empId, String empName)
        {
            InitializeComponent();
            employeeID = empId;
            txtUserName.Text = empName;
            txtUserName.ReadOnly = true;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string newPass = txtNewPassword.Text;
            string confirm = txtConfirmPassword.Text;
            // Kiểm tra nếu trống
            if (string.IsNullOrEmpty(newPass) || string.IsNullOrEmpty(confirm))
            {
                MessageBox.Show("Please enter new password and confirm password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (newPass != confirm)
            {
                MessageBox.Show("Passwords do not match.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPass.Length < 5)
            {
                MessageBox.Show("Password must be at least 5 characters!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string hash = ComputeSha256Hash(newPass);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(@"
                    UPDATE Employees 
                    SET PasswordHash = @hash, MustChangePassword = 0 
                    WHERE EmployeeID = @id", conn);
                cmd.Parameters.AddWithValue("@hash", hash);
                cmd.Parameters.AddWithValue("@id", employeeID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Password changed. You may now log in.");
            this.Close();
        }

        private string ComputeSha256Hash(string raw)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(raw));
                return string.Concat(bytes.Select(b => b.ToString("x2")));
            }
        }

        private void cbShowNewPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtNewPassword.PasswordChar = cbShowNewPassword.Checked ? '\0' : '*';
        }

        private void cbShowConfirmPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtConfirmPassword.PasswordChar = cbShowConfirmPassword.Checked ? '\0' : '*';
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
