namespace CubicStore
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnProductManagement = new System.Windows.Forms.Button();
            this.btnSalseManagement = new System.Windows.Forms.Button();
            this.btnCustomerManagement = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnEmployeesManagement = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnImportManagement = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CUBICSTORE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnProductManagement
            // 
            this.btnProductManagement.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnProductManagement.Location = new System.Drawing.Point(12, 89);
            this.btnProductManagement.Name = "btnProductManagement";
            this.btnProductManagement.Size = new System.Drawing.Size(190, 73);
            this.btnProductManagement.TabIndex = 1;
            this.btnProductManagement.Text = " Product Management";
            this.btnProductManagement.UseVisualStyleBackColor = false;
            this.btnProductManagement.Click += new System.EventHandler(this.btnProductManagement_Click);
            // 
            // btnSalseManagement
            // 
            this.btnSalseManagement.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSalseManagement.Location = new System.Drawing.Point(12, 452);
            this.btnSalseManagement.Name = "btnSalseManagement";
            this.btnSalseManagement.Size = new System.Drawing.Size(190, 71);
            this.btnSalseManagement.TabIndex = 2;
            this.btnSalseManagement.Text = "Sales Management";
            this.btnSalseManagement.UseVisualStyleBackColor = false;
            this.btnSalseManagement.Click += new System.EventHandler(this.btnSalseManagement_Click);
            // 
            // btnCustomerManagement
            // 
            this.btnCustomerManagement.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCustomerManagement.Location = new System.Drawing.Point(12, 274);
            this.btnCustomerManagement.Name = "btnCustomerManagement";
            this.btnCustomerManagement.Size = new System.Drawing.Size(190, 66);
            this.btnCustomerManagement.TabIndex = 3;
            this.btnCustomerManagement.Text = "Customer Management";
            this.btnCustomerManagement.UseVisualStyleBackColor = false;
            this.btnCustomerManagement.Click += new System.EventHandler(this.btnCustomerManagement_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnReports.Location = new System.Drawing.Point(12, 541);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(190, 74);
            this.btnReports.TabIndex = 4;
            this.btnReports.Text = "View Reports";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnEmployeesManagement
            // 
            this.btnEmployeesManagement.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEmployeesManagement.Location = new System.Drawing.Point(12, 363);
            this.btnEmployeesManagement.Name = "btnEmployeesManagement";
            this.btnEmployeesManagement.Size = new System.Drawing.Size(190, 72);
            this.btnEmployeesManagement.TabIndex = 5;
            this.btnEmployeesManagement.Text = "Employees Management";
            this.btnEmployeesManagement.UseVisualStyleBackColor = false;
            this.btnEmployeesManagement.Click += new System.EventHandler(this.btnEmployeesManagement_Click);
            // 
            // panelMain
            // 
            this.panelMain.Location = new System.Drawing.Point(226, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(978, 705);
            this.panelMain.TabIndex = 6;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLogOut.Location = new System.Drawing.Point(12, 630);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(190, 63);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnImportManagement);
            this.panel1.Controls.Add(this.btnSalseManagement);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnProductManagement);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnReports);
            this.panel1.Controls.Add(this.btnEmployeesManagement);
            this.panel1.Controls.Add(this.btnCustomerManagement);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 705);
            this.panel1.TabIndex = 8;
            // 
            // btnImportManagement
            // 
            this.btnImportManagement.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnImportManagement.Location = new System.Drawing.Point(12, 183);
            this.btnImportManagement.Name = "btnImportManagement";
            this.btnImportManagement.Size = new System.Drawing.Size(190, 71);
            this.btnImportManagement.TabIndex = 8;
            this.btnImportManagement.Text = "Import Management";
            this.btnImportManagement.UseVisualStyleBackColor = false;
            this.btnImportManagement.Click += new System.EventHandler(this.btnImportManagement_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 705);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProductManagement;
        private System.Windows.Forms.Button btnSalseManagement;
        private System.Windows.Forms.Button btnCustomerManagement;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnEmployeesManagement;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnImportManagement;
    }
}

