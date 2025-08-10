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
    public partial class Form1 : Form
    {
        private int employeeId;

        public Form1(int empId)
        {
            InitializeComponent();
            employeeId = empId;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnProductManagement_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            ProductManagement productManagement = new ProductManagement();
            productManagement.Dock = DockStyle.Fill;
            panelMain.Controls.Add(productManagement);
        }

        private void btnCustomerManagement_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            UC_CustomerManagement customerManagement = new UC_CustomerManagement();
            customerManagement.Dock = DockStyle.Fill;
            panelMain.Controls.Add(customerManagement);
        }

        private void btnEmployeesManagement_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            UC_EmployeeManagement employeeManagement = new UC_EmployeeManagement();
            employeeManagement.Dock = DockStyle.Fill;
            panelMain.Controls.Add(employeeManagement);
        }

        private void btnSalseManagement_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear(); 
            UC_SalesManagementcs salesManagement = new UC_SalesManagementcs(employeeId);
            salesManagement.Dock = DockStyle.Fill;
            panelMain.Controls.Add(salesManagement);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            UC_Report reports = new UC_Report();
            reports.Dock = DockStyle.Fill;
            panelMain.Controls.Add(reports);
        }

        private void btnImportManagement_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            UC_ImportManagement importManagement = new UC_ImportManagement();   
            importManagement.Dock = DockStyle.Fill;
            panelMain.Controls.Add(importManagement);
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
