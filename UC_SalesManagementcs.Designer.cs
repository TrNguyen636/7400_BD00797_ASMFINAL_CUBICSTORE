namespace CubicStore.Controls
{
    partial class UC_SalesManagementcs
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
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.cboCustomer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConfirmSale = new System.Windows.Forms.Button();
            this.btnClearCart = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnAddtoCart = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCustomer
            // 
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(372, 106);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(142, 24);
            this.cbCustomer.TabIndex = 0;
            // 
            // cboCustomer
            // 
            this.cboCustomer.AutoSize = true;
            this.cboCustomer.Location = new System.Drawing.Point(287, 109);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(64, 16);
            this.cboCustomer.TabIndex = 1;
            this.cboCustomer.Text = "Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Product";
            // 
            // cbProduct
            // 
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Location = new System.Drawing.Point(372, 174);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(142, 24);
            this.cbProduct.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(370, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sale Management";
            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName,
            this.Quantity,
            this.SellingPrice,
            this.TotalPrice});
            this.dgvCart.Location = new System.Drawing.Point(15, 307);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.RowHeadersWidth = 51;
            this.dgvCart.RowTemplate.Height = 24;
            this.dgvCart.Size = new System.Drawing.Size(950, 227);
            this.dgvCart.TabIndex = 5;
            // 
            // ProductID
            // 
            this.ProductID.DataPropertyName = "ProductID";
            this.ProductID.HeaderText = "Product ID";
            this.ProductID.MinimumWidth = 6;
            this.ProductID.Name = "ProductID";
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            // 
            // SellingPrice
            // 
            this.SellingPrice.DataPropertyName = "SellingPrice";
            this.SellingPrice.HeaderText = "SellingPrice";
            this.SellingPrice.MinimumWidth = 6;
            this.SellingPrice.Name = "SellingPrice";
            // 
            // TotalPrice
            // 
            this.TotalPrice.DataPropertyName = "TotalPrice";
            this.TotalPrice.HeaderText = "Total Price";
            this.TotalPrice.MinimumWidth = 6;
            this.TotalPrice.Name = "TotalPrice";
            // 
            // btnConfirmSale
            // 
            this.btnConfirmSale.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnConfirmSale.Location = new System.Drawing.Point(501, 242);
            this.btnConfirmSale.Name = "btnConfirmSale";
            this.btnConfirmSale.Size = new System.Drawing.Size(106, 45);
            this.btnConfirmSale.TabIndex = 6;
            this.btnConfirmSale.Text = "Confirm Sale";
            this.btnConfirmSale.UseVisualStyleBackColor = false;
            this.btnConfirmSale.Click += new System.EventHandler(this.btnConfirmSale_Click);
            // 
            // btnClearCart
            // 
            this.btnClearCart.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnClearCart.Location = new System.Drawing.Point(627, 242);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.Size = new System.Drawing.Size(106, 45);
            this.btnClearCart.TabIndex = 7;
            this.btnClearCart.Text = "Clear Cart";
            this.btnClearCart.UseVisualStyleBackColor = false;
            this.btnClearCart.Click += new System.EventHandler(this.btnClearCart_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(624, 106);
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(71, 24);
            this.txtQuantity.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(556, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Employee ID";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(125, 107);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(100, 22);
            this.txtEmployeeID.TabIndex = 11;
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnRemoveItem.Location = new System.Drawing.Point(753, 242);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(106, 45);
            this.btnRemoveItem.TabIndex = 12;
            this.btnRemoveItem.Text = "Remove";
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnAddtoCart
            // 
            this.btnAddtoCart.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAddtoCart.Location = new System.Drawing.Point(374, 242);
            this.btnAddtoCart.Name = "btnAddtoCart";
            this.btnAddtoCart.Size = new System.Drawing.Size(106, 45);
            this.btnAddtoCart.TabIndex = 13;
            this.btnAddtoCart.Text = "Add";
            this.btnAddtoCart.UseVisualStyleBackColor = false;
            this.btnAddtoCart.Click += new System.EventHandler(this.btnAddtoCart_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(657, 564);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Total amount:";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(795, 564);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(0, 25);
            this.lblTotalAmount.TabIndex = 15;
            // 
            // UC_SalesManagementcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAddtoCart);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.btnClearCart);
            this.Controls.Add(this.btnConfirmSale);
            this.Controls.Add(this.dgvCart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbProduct);
            this.Controls.Add(this.cboCustomer);
            this.Controls.Add(this.cbCustomer);
            this.Name = "UC_SalesManagementcs";
            this.Size = new System.Drawing.Size(978, 705);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.Label cboCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Button btnConfirmSale;
        private System.Windows.Forms.Button btnClearCart;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnAddtoCart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
    }
}
