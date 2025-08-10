namespace CubicStore.Controls
{
    partial class UC_EmployeeManagement
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtEmployeeCode = new System.Windows.Forms.TextBox();
            this.txtEmployeePosition = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmployeeGroupID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(447, 657);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(190, 35);
            this.txtSearch.TabIndex = 38;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSearch.Location = new System.Drawing.Point(335, 657);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(106, 35);
            this.btnSearch.TabIndex = 37;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnUpdate.Location = new System.Drawing.Point(580, 589);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(103, 49);
            this.btnUpdate.TabIndex = 36;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnDelete.Location = new System.Drawing.Point(456, 589);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 49);
            this.btnDelete.TabIndex = 35;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnCancel.Location = new System.Drawing.Point(703, 589);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 49);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAdd.Location = new System.Drawing.Point(335, 589);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 49);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(146, 612);
            this.txtEmployeeName.Multiline = true;
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(145, 31);
            this.txtEmployeeName.TabIndex = 32;
            // 
            // txtEmployeeCode
            // 
            this.txtEmployeeCode.Location = new System.Drawing.Point(146, 546);
            this.txtEmployeeCode.Multiline = true;
            this.txtEmployeeCode.Name = "txtEmployeeCode";
            this.txtEmployeeCode.Size = new System.Drawing.Size(145, 31);
            this.txtEmployeeCode.TabIndex = 31;
            // 
            // txtEmployeePosition
            // 
            this.txtEmployeePosition.Location = new System.Drawing.Point(447, 487);
            this.txtEmployeePosition.Multiline = true;
            this.txtEmployeePosition.Name = "txtEmployeePosition";
            this.txtEmployeePosition.Size = new System.Drawing.Size(145, 31);
            this.txtEmployeePosition.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(355, 490);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "Position";
            // 
            // txtEmployeeGroupID
            // 
            this.txtEmployeeGroupID.Location = new System.Drawing.Point(447, 546);
            this.txtEmployeeGroupID.Multiline = true;
            this.txtEmployeeGroupID.Name = "txtEmployeeGroupID";
            this.txtEmployeeGroupID.Size = new System.Drawing.Size(145, 31);
            this.txtEmployeeGroupID.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(355, 549);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Group ID";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Enabled = false;
            this.txtEmployeeID.Location = new System.Drawing.Point(146, 484);
            this.txtEmployeeID.Multiline = true;
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(145, 31);
            this.txtEmployeeID.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 549);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Employee Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 615);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 484);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Employee ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(350, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 29);
            this.label1.TabIndex = 22;
            this.label1.Text = "EMPLOYEE MANAGEMENT";
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeID,
            this.EmployeeCode,
            this.EmployeeName,
            this.Position,
            this.GroupID});
            this.dgvEmployees.Location = new System.Drawing.Point(33, 68);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.RowHeadersWidth = 51;
            this.dgvEmployees.RowTemplate.Height = 24;
            this.dgvEmployees.Size = new System.Drawing.Size(910, 396);
            this.dgvEmployees.TabIndex = 21;
            this.dgvEmployees.SelectionChanged += new System.EventHandler(this.dgvEmployees_SelectionChanged);
            // 
            // EmployeeID
            // 
            this.EmployeeID.DataPropertyName = "EmployeeID";
            this.EmployeeID.HeaderText = "ID";
            this.EmployeeID.MinimumWidth = 6;
            this.EmployeeID.Name = "EmployeeID";
            // 
            // EmployeeCode
            // 
            this.EmployeeCode.DataPropertyName = "EmployeeCode";
            this.EmployeeCode.HeaderText = "Employee Code";
            this.EmployeeCode.MinimumWidth = 6;
            this.EmployeeCode.Name = "EmployeeCode";
            // 
            // EmployeeName
            // 
            this.EmployeeName.DataPropertyName = "EmployeeName";
            this.EmployeeName.HeaderText = "Employee Name";
            this.EmployeeName.MinimumWidth = 6;
            this.EmployeeName.Name = "EmployeeName";
            // 
            // Position
            // 
            this.Position.DataPropertyName = "Position";
            this.Position.HeaderText = "Position";
            this.Position.MinimumWidth = 6;
            this.Position.Name = "Position";
            // 
            // GroupID
            // 
            this.GroupID.DataPropertyName = "GroupID";
            this.GroupID.HeaderText = "Group ID";
            this.GroupID.MinimumWidth = 6;
            this.GroupID.Name = "GroupID";
            // 
            // UC_EmployeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.txtEmployeeCode);
            this.Controls.Add(this.txtEmployeePosition);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEmployeeGroupID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEmployees);
            this.Name = "UC_EmployeeManagement";
            this.Size = new System.Drawing.Size(978, 705);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeCode;
        private System.Windows.Forms.TextBox txtEmployeePosition;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmployeeGroupID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupID;
    }
}
