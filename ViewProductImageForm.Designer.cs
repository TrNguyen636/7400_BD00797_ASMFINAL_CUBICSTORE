namespace CubicStore.Controls
{
    partial class ViewProductImageForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtImageID = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtImageName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvListImage = new System.Windows.Forms.DataGridView();
            this.ImageID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImageData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(584, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(388, 393);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Image ID:";
            // 
            // txtImageID
            // 
            this.txtImageID.Enabled = false;
            this.txtImageID.Location = new System.Drawing.Point(114, 428);
            this.txtImageID.Multiline = true;
            this.txtImageID.Name = "txtImageID";
            this.txtImageID.Size = new System.Drawing.Size(181, 22);
            this.txtImageID.TabIndex = 2;
            // 
            // txtProductID
            // 
            this.txtProductID.Enabled = false;
            this.txtProductID.Location = new System.Drawing.Point(114, 480);
            this.txtProductID.Multiline = true;
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(181, 22);
            this.txtProductID.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 480);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Product ID:";
            // 
            // txtImageName
            // 
            this.txtImageName.Location = new System.Drawing.Point(114, 528);
            this.txtImageName.Multiline = true;
            this.txtImageName.Name = "txtImageName";
            this.txtImageName.Size = new System.Drawing.Size(181, 22);
            this.txtImageName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 528);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Image name:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(339, 436);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 49);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(466, 436);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 49);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(899, 545);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 32);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvListImage
            // 
            this.dgvListImage.AllowUserToAddRows = false;
            this.dgvListImage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListImage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImageID,
            this.ProductID,
            this.ImageData,
            this.ImageName});
            this.dgvListImage.Location = new System.Drawing.Point(12, 122);
            this.dgvListImage.Name = "dgvListImage";
            this.dgvListImage.RowHeadersWidth = 51;
            this.dgvListImage.RowTemplate.Height = 24;
            this.dgvListImage.Size = new System.Drawing.Size(545, 283);
            this.dgvListImage.TabIndex = 12;
            this.dgvListImage.SelectionChanged += new System.EventHandler(this.dgvListImage_SelectionChanged);
            // 
            // ImageID
            // 
            this.ImageID.DataPropertyName = "ImageID";
            this.ImageID.HeaderText = "Image ID";
            this.ImageID.MinimumWidth = 6;
            this.ImageID.Name = "ImageID";
            this.ImageID.Width = 125;
            // 
            // ProductID
            // 
            this.ProductID.DataPropertyName = "ProductID";
            this.ProductID.HeaderText = "ProductID";
            this.ProductID.MinimumWidth = 6;
            this.ProductID.Name = "ProductID";
            this.ProductID.Width = 125;
            // 
            // ImageData
            // 
            this.ImageData.DataPropertyName = "ImageData";
            this.ImageData.HeaderText = "Image";
            this.ImageData.MinimumWidth = 6;
            this.ImageData.Name = "ImageData";
            this.ImageData.Width = 125;
            // 
            // ImageName
            // 
            this.ImageName.DataPropertyName = "ImageName";
            this.ImageName.HeaderText = "Image Name";
            this.ImageName.MinimumWidth = 6;
            this.ImageName.Name = "ImageName";
            this.ImageName.Width = 125;
            // 
            // ViewProductImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 589);
            this.Controls.Add(this.dgvListImage);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtImageName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtImageID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ViewProductImageForm";
            this.Text = "ViewProductImageForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtImageID;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtImageName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvListImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImageID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImageData;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImageName;
    }
}