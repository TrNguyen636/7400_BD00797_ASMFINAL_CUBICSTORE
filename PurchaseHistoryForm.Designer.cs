namespace CubicStore.Controls
{
    partial class PurchaseHistoryForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHistoryID = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.dgvPurchaseHistory = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtSellingPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPurchaseDate = new System.Windows.Forms.TextBox();
            this.HistoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "History ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Product ID";
            // 
            // txtHistoryID
            // 
            this.txtHistoryID.Enabled = false;
            this.txtHistoryID.Location = new System.Drawing.Point(121, 81);
            this.txtHistoryID.Name = "txtHistoryID";
            this.txtHistoryID.Size = new System.Drawing.Size(100, 22);
            this.txtHistoryID.TabIndex = 4;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Enabled = false;
            this.txtCustomerID.Location = new System.Drawing.Point(121, 136);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(100, 22);
            this.txtCustomerID.TabIndex = 5;
            // 
            // txtProductID
            // 
            this.txtProductID.Enabled = false;
            this.txtProductID.Location = new System.Drawing.Point(121, 189);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(100, 22);
            this.txtProductID.TabIndex = 6;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Enabled = false;
            this.txtQuantity.Location = new System.Drawing.Point(121, 241);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 22);
            this.txtQuantity.TabIndex = 7;
            // 
            // dgvPurchaseHistory
            // 
            this.dgvPurchaseHistory.AllowUserToAddRows = false;
            this.dgvPurchaseHistory.AllowUserToDeleteRows = false;
            this.dgvPurchaseHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchaseHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HistoryID,
            this.CustomerID,
            this.ProductID,
            this.Quantity,
            this.SellingPrice,
            this.PurchaseDate});
            this.dgvPurchaseHistory.Location = new System.Drawing.Point(30, 288);
            this.dgvPurchaseHistory.Name = "dgvPurchaseHistory";
            this.dgvPurchaseHistory.ReadOnly = true;
            this.dgvPurchaseHistory.RowHeadersWidth = 51;
            this.dgvPurchaseHistory.RowTemplate.Height = 24;
            this.dgvPurchaseHistory.Size = new System.Drawing.Size(491, 218);
            this.dgvPurchaseHistory.TabIndex = 8;
            this.dgvPurchaseHistory.SelectionChanged += new System.EventHandler(this.dgvPurchaseHistory_SelectionChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(468, 526);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 31);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtSellingPrice
            // 
            this.txtSellingPrice.Enabled = false;
            this.txtSellingPrice.Location = new System.Drawing.Point(399, 84);
            this.txtSellingPrice.Name = "txtSellingPrice";
            this.txtSellingPrice.Size = new System.Drawing.Size(100, 22);
            this.txtSellingPrice.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Selling Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(279, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Purchase Date";
            // 
            // txtPurchaseDate
            // 
            this.txtPurchaseDate.Enabled = false;
            this.txtPurchaseDate.Location = new System.Drawing.Point(399, 130);
            this.txtPurchaseDate.Name = "txtPurchaseDate";
            this.txtPurchaseDate.Size = new System.Drawing.Size(100, 22);
            this.txtPurchaseDate.TabIndex = 15;
            // 
            // HistoryID
            // 
            this.HistoryID.DataPropertyName = "HistoryID";
            this.HistoryID.HeaderText = "History ID";
            this.HistoryID.MinimumWidth = 6;
            this.HistoryID.Name = "HistoryID";
            this.HistoryID.ReadOnly = true;
            this.HistoryID.Width = 125;
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "Customer ID";
            this.CustomerID.MinimumWidth = 6;
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            this.CustomerID.Width = 125;
            // 
            // ProductID
            // 
            this.ProductID.DataPropertyName = "ProductID";
            this.ProductID.HeaderText = "Product ID";
            this.ProductID.MinimumWidth = 6;
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 125;
            // 
            // SellingPrice
            // 
            this.SellingPrice.DataPropertyName = "SellingPrice";
            this.SellingPrice.HeaderText = "Selling Price";
            this.SellingPrice.MinimumWidth = 6;
            this.SellingPrice.Name = "SellingPrice";
            this.SellingPrice.ReadOnly = true;
            this.SellingPrice.Width = 125;
            // 
            // PurchaseDate
            // 
            this.PurchaseDate.DataPropertyName = "PurchaseDate";
            this.PurchaseDate.HeaderText = "Puchase Date";
            this.PurchaseDate.MinimumWidth = 6;
            this.PurchaseDate.Name = "PurchaseDate";
            this.PurchaseDate.ReadOnly = true;
            this.PurchaseDate.Width = 125;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(172, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(229, 32);
            this.label8.TabIndex = 16;
            this.label8.Text = "Purchase History";
            // 
            // PurchaseHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 569);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPurchaseDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSellingPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvPurchaseHistory);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.txtHistoryID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PurchaseHistoryForm";
            this.Text = "PurchaseHistoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHistoryID;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.DataGridView dgvPurchaseHistory;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtSellingPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPurchaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn HistoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseDate;
        private System.Windows.Forms.Label label8;
    }
}