using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CubicStore
{
    public partial class WarehouseMainForm : Form
    {
        public WarehouseMainForm()
        {
            InitializeComponent();
        }

        private void btnProductManagement_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            Controls.ProductManagement productManagement = new Controls.ProductManagement();
            productManagement.Dock = DockStyle.Fill;
            panelMain.Controls.Add(productManagement);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            Controls.UC_Home home = new Controls.UC_Home();
            home.Dock = DockStyle.Fill;
            panelMain.Controls.Add(home);
        }

        private void btnImportManagement_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            Controls.UC_ImportManagement importManagement = new Controls.UC_ImportManagement();
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
