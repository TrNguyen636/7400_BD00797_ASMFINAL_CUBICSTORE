namespace CubicStore.Controls
{
    partial class UC_Report
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbReportType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.btnChart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(459, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Report";
            // 
            // cbReportType
            // 
            this.cbReportType.FormattingEnabled = true;
            this.cbReportType.Location = new System.Drawing.Point(144, 139);
            this.cbReportType.Name = "cbReportType";
            this.cbReportType.Size = new System.Drawing.Size(121, 24);
            this.cbReportType.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Report Type";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(144, 191);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date";
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnGenerate.Location = new System.Drawing.Point(573, 271);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(107, 44);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // dgvReport
            // 
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(39, 363);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.RowHeadersWidth = 51;
            this.dgvReport.RowTemplate.Height = 24;
            this.dgvReport.Size = new System.Drawing.Size(892, 273);
            this.dgvReport.TabIndex = 6;
            // 
            // btnChart
            // 
            this.btnChart.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnChart.Location = new System.Drawing.Point(712, 272);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(107, 43);
            this.btnChart.TabIndex = 7;
            this.btnChart.Text = "View Chart";
            this.btnChart.UseVisualStyleBackColor = false;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // UC_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.btnChart);
            this.Controls.Add(this.dgvReport);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbReportType);
            this.Controls.Add(this.label1);
            this.Name = "UC_Report";
            this.Size = new System.Drawing.Size(978, 705);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbReportType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Button btnChart;
    }
}
