namespace CubicStore.Controls
{
    partial class ProductManagement
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
            this.btnSearchProduct = new System.Windows.Forms.Button();
            this.lblPriceError = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrices = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.lblErrorQuantity = new System.Windows.Forms.Label();
            this.lblErrorName = new System.Windows.Forms.Label();
            this.lblIDError = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventoryQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnViewImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(643, 194);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(172, 31);
            this.txtSearch.TabIndex = 52;
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.Location = new System.Drawing.Point(564, 197);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(73, 23);
            this.btnSearchProduct.TabIndex = 51;
            this.btnSearchProduct.Text = "Search";
            this.btnSearchProduct.UseVisualStyleBackColor = true;
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // lblPriceError
            // 
            this.lblPriceError.AutoSize = true;
            this.lblPriceError.ForeColor = System.Drawing.Color.Red;
            this.lblPriceError.Location = new System.Drawing.Point(640, 110);
            this.lblPriceError.Name = "lblPriceError";
            this.lblPriceError.Size = new System.Drawing.Size(0, 16);
            this.lblPriceError.TabIndex = 50;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(640, 72);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(98, 31);
            this.txtPrice.TabIndex = 49;
            // 
            // lblPrices
            // 
            this.lblPrices.AutoSize = true;
            this.lblPrices.Location = new System.Drawing.Point(582, 79);
            this.lblPrices.Name = "lblPrices";
            this.lblPrices.Size = new System.Drawing.Size(38, 16);
            this.lblPrices.TabIndex = 48;
            this.lblPrices.Text = "Price";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnCancel.Location = new System.Drawing.Point(566, 265);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 40);
            this.btnCancel.TabIndex = 47;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnDelete.Location = new System.Drawing.Point(450, 265);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 40);
            this.btnDelete.TabIndex = 46;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnUpdate.Location = new System.Drawing.Point(335, 265);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(110, 40);
            this.btnUpdate.TabIndex = 45;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnInsert.Location = new System.Drawing.Point(218, 265);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(110, 40);
            this.btnInsert.TabIndex = 44;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // lblErrorQuantity
            // 
            this.lblErrorQuantity.AutoSize = true;
            this.lblErrorQuantity.ForeColor = System.Drawing.Color.Red;
            this.lblErrorQuantity.Location = new System.Drawing.Point(357, 228);
            this.lblErrorQuantity.Name = "lblErrorQuantity";
            this.lblErrorQuantity.Size = new System.Drawing.Size(0, 16);
            this.lblErrorQuantity.TabIndex = 42;
            // 
            // lblErrorName
            // 
            this.lblErrorName.AutoSize = true;
            this.lblErrorName.ForeColor = System.Drawing.Color.Red;
            this.lblErrorName.Location = new System.Drawing.Point(218, 170);
            this.lblErrorName.Name = "lblErrorName";
            this.lblErrorName.Size = new System.Drawing.Size(0, 16);
            this.lblErrorName.TabIndex = 41;
            // 
            // lblIDError
            // 
            this.lblIDError.AutoSize = true;
            this.lblIDError.ForeColor = System.Drawing.Color.Red;
            this.lblIDError.Location = new System.Drawing.Point(218, 110);
            this.lblIDError.Name = "lblIDError";
            this.lblIDError.Size = new System.Drawing.Size(0, 16);
            this.lblIDError.TabIndex = 40;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(218, 190);
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(172, 31);
            this.txtQuantity.TabIndex = 39;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(218, 130);
            this.txtProductName.Multiline = true;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(172, 31);
            this.txtProductName.TabIndex = 38;
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(218, 72);
            this.txtProductCode.Multiline = true;
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(172, 31);
            this.txtProductCode.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(565, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 35;
            this.label6.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "Quantity";
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductCode,
            this.ProductName,
            this.SellingPrice,
            this.InventoryQuantity,
            this.Description});
            this.dgvProducts.Location = new System.Drawing.Point(37, 356);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.Size = new System.Drawing.Size(891, 346);
            this.dgvProducts.TabIndex = 33;
            this.dgvProducts.SelectionChanged += new System.EventHandler(this.dgvProducts_SelectionChanged);
            // 
            // ProductID
            // 
            this.ProductID.DataPropertyName = "ProductID";
            this.ProductID.HeaderText = "Product ID";
            this.ProductID.MinimumWidth = 6;
            this.ProductID.Name = "ProductID";
            // 
            // ProductCode
            // 
            this.ProductCode.DataPropertyName = "ProductCode";
            this.ProductCode.HeaderText = "Product Code";
            this.ProductCode.MinimumWidth = 6;
            this.ProductCode.Name = "ProductCode";
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            // 
            // SellingPrice
            // 
            this.SellingPrice.DataPropertyName = "SellingPrice";
            this.SellingPrice.HeaderText = "Price";
            this.SellingPrice.MinimumWidth = 6;
            this.SellingPrice.Name = "SellingPrice";
            // 
            // InventoryQuantity
            // 
            this.InventoryQuantity.DataPropertyName = "InventoryQuantity";
            this.InventoryQuantity.HeaderText = "Quantity";
            this.InventoryQuantity.MinimumWidth = 6;
            this.InventoryQuantity.Name = "InventoryQuantity";
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Product Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "Product Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(393, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 36);
            this.label3.TabIndex = 30;
            this.label3.Text = "List of Products";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(345, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 36);
            this.label2.TabIndex = 29;
            this.label2.Text = "Product Managements";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(640, 130);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(169, 34);
            this.txtDescription.TabIndex = 53;
            // 
            // btnViewImage
            // 
            this.btnViewImage.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnViewImage.Location = new System.Drawing.Point(682, 265);
            this.btnViewImage.Name = "btnViewImage";
            this.btnViewImage.Size = new System.Drawing.Size(110, 39);
            this.btnViewImage.TabIndex = 54;
            this.btnViewImage.Text = "View Image";
            this.btnViewImage.UseVisualStyleBackColor = false;
            this.btnViewImage.Click += new System.EventHandler(this.btnViewImage_Click);
            // 
            // ProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.btnViewImage);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearchProduct);
            this.Controls.Add(this.lblPriceError);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrices);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.lblErrorQuantity);
            this.Controls.Add(this.lblErrorName);
            this.Controls.Add(this.lblIDError);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "ProductManagement";
            this.Size = new System.Drawing.Size(978, 705);
            this.Load += new System.EventHandler(this.ProductManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearchProduct;
        private System.Windows.Forms.Label lblPriceError;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrices;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label lblErrorQuantity;
        private System.Windows.Forms.Label lblErrorName;
        private System.Windows.Forms.Label lblIDError;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnViewImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoryQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}
