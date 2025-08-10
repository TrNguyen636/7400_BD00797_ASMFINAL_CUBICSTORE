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
using static System.Collections.Specialized.BitVector32;

namespace CubicStore
{
    public partial class LoginForm : Form
    {
        //String connectionString = "Data Source=localhost;Initial Catalog=CubicStore;Integrated Security=True;"; // Update with your actual connection string
        private string connectionString = "Server=MSI\\SQLEXPRESS;Database=CubicStore;Integrated Security=true;";
        public LoginForm()
        {
            InitializeComponent();
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username and Password cannot be blank!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            string hashed = ComputeSha256Hash(password);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT e.EmployeeID, e.EmployeeName, e.MustChangePassword, g.GroupName
                    FROM Employees e
                    JOIN EmployeeGroups g ON e.GroupID = g.GroupID
                    WHERE e.Username = @Username AND e.PasswordHash = @Hash";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Hash", hashed);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int empId = (int)reader["EmployeeID"];
                    string empName = reader["EmployeeName"].ToString();
                    string group = reader["GroupName"].ToString();
                    bool mustChange = (bool)reader["MustChangePassword"];
                    reader.Close();

                    this.Hide();

                    if (mustChange)
                    {
                        ChangePasswordForm changeForm = new ChangePasswordForm(empId, empName);
                        changeForm.ShowDialog();
                        this.Show(); // Return to login after changing password
                    }
                    else
                    {
                        switch (group)
                        {
                            case "Admin":
                                MessageBox.Show($"Welcome {empName} - Admin");
                                new Form1(empId).Show();
                                break;

                            case "Sales":
                                MessageBox.Show($"Welcome {empName} - Sales");
                                new SalesMainForm(empId).Show();
                                break;

                            case "Inventory":
                                MessageBox.Show($"Welcome {empName} - Warehouse Manager");
                                new WarehouseMainForm().Show();
                                break;

                            default:
                                MessageBox.Show($"Unknown role: {group}. Please contact administrator.");
                                this.Show();
                                return;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '*';
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private string ComputeSha256Hash(string raw)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(raw));
                return string.Concat(bytes.Select(b => b.ToString("x2")));
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.ShowDialog();
        }
    }
}
