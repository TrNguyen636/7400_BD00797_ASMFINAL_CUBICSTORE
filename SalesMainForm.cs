using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CubicStore.Controls;

namespace CubicStore
{
    public partial class SalesMainForm : Form
    {
        private int employeeId;

        public SalesMainForm(int empId)
        {
            InitializeComponent();
            this.employeeId = empId;   
        }


        private void btnCustomerManagement_Click(object sender, EventArgs e)
        {
            panelSalesManagement.Controls.Clear();
            UC_CustomerManagement customerManagement = new UC_CustomerManagement();
            customerManagement.Dock = DockStyle.Fill;
            panelSalesManagement.Controls.Add(customerManagement);
        }

        private void btnSalseManagement_Click(object sender, EventArgs e)
        {
            panelSalesManagement.Controls.Clear();
            UC_SalesManagementcs salesManagement = new UC_SalesManagementcs(employeeId);
            salesManagement.Dock = DockStyle.Fill;
            panelSalesManagement.Controls.Add(salesManagement);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panelSalesManagement.Controls.Clear();
            UC_Home home = new UC_Home();
            home.Dock = DockStyle.Fill;
            panelSalesManagement.Controls.Add(home);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to log out?",
                                          "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide(); // Hide current form
                LoginForm loginForm = new LoginForm(); // Reopen login form
                loginForm.Show();
            }
        }
    }
}
