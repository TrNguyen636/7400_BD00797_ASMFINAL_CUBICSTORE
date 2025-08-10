using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CubicStore.Controls
{
    public partial class UC_Report : UserControl
    {
        private string connectionString = "Server=MSI\\SQLEXPRESS;Database=CubicStore;Integrated Security=true;";

        public UC_Report()
        {
            InitializeComponent();
            cbReportType.Items.AddRange(new string[]
       {
            "Import Quantity by Product",
            "Sales Revenue by Day",
            "Sales Revenue by Month",
            "Sales Revenue by Year",
            "Profit by Product",
            "Profit by Employee"
       });
            cbReportType.SelectedIndex = 0;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string selected = cbReportType.SelectedItem.ToString();
            string query = "";

            switch (selected)
            {
                case "Import Quantity by Product":
                    query = @"
                    SELECT 
                        p.ProductCode,
                        p.ProductName,
                        SUM(pi.Quantity) AS TotalImported
                    FROM ProductImports pi
                    JOIN Products p ON pi.ProductID = p.ProductID
                    GROUP BY p.ProductCode, p.ProductName";
                    break;

                case "Sales Revenue by Day":
                    query = @"
                    SELECT 
                        CONVERT(DATE, s.SaleDate) AS SaleDay,
                        SUM(sd.Quantity * sd.SellingPrice) AS TotalRevenue
                    FROM Sales s
                    JOIN SaleDetails sd ON s.SaleID = sd.SaleID
                    GROUP BY CONVERT(DATE, s.SaleDate)";
                    break;

                case "Sales Revenue by Month":
                    query = @"
                    SELECT 
                        FORMAT(s.SaleDate, 'yyyy-MM') AS SaleMonth,
                        SUM(sd.Quantity * sd.SellingPrice) AS TotalRevenue
                    FROM Sales s
                    JOIN SaleDetails sd ON s.SaleID = sd.SaleID
                    GROUP BY FORMAT(s.SaleDate, 'yyyy-MM')";
                    break;

                case "Sales Revenue by Year":
                    query = @"
                    SELECT 
                        YEAR(s.SaleDate) AS SaleYear,
                        SUM(sd.Quantity * sd.SellingPrice) AS TotalRevenue
                    FROM Sales s
                    JOIN SaleDetails sd ON s.SaleID = sd.SaleID
                    GROUP BY YEAR(s.SaleDate)";
                    break;

                case "Profit by Product":
                    query = @"
    SELECT 
        p.ProductCode,
        p.ProductName,
        SUM(sd.Quantity * sd.SellingPrice) AS Revenue,
        SUM(sd.Quantity * ISNULL(avgImp.AvgImportPrice, 0)) AS EstimatedImportCost,
        SUM(sd.Quantity * sd.SellingPrice) - 
        SUM(sd.Quantity * ISNULL(avgImp.AvgImportPrice, 0)) AS Profit
    FROM SaleDetails sd
    JOIN Products p ON sd.ProductID = p.ProductID
    LEFT JOIN (
        SELECT ProductID, AVG(ImportPrice) AS AvgImportPrice
        FROM ProductImports
        GROUP BY ProductID
    ) avgImp ON sd.ProductID = avgImp.ProductID
    GROUP BY p.ProductCode, p.ProductName";
                    break;

                case "Profit by Employee":
                    query = @"
    SELECT 
        e.EmployeeName,
        SUM(sd.Quantity * sd.SellingPrice) AS Revenue,
        SUM(sd.Quantity * ISNULL(avgImp.AvgImportPrice, 0)) AS EstimatedImportCost,
        SUM(sd.Quantity * sd.SellingPrice) - 
        SUM(sd.Quantity * ISNULL(avgImp.AvgImportPrice, 0)) AS Profit
    FROM Sales s
    JOIN Employees e ON s.EmployeeID = e.EmployeeID
    JOIN SaleDetails sd ON s.SaleID = sd.SaleID
    LEFT JOIN (
        SELECT ProductID, AVG(ImportPrice) AS AvgImportPrice
        FROM ProductImports
        GROUP BY ProductID
    ) avgImp ON sd.ProductID = avgImp.ProductID
    GROUP BY e.EmployeeName";
                    break;

                    break;
            }
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvReport.DataSource = dt;
            }
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            if (dgvReport.DataSource == null || dgvReport.Rows.Count == 0)
            {
                MessageBox.Show("No data to visualize.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable dt = dgvReport.DataSource as DataTable;
            if (dt == null) return;

            // Suggest based on selected report type
            string selected = cbReportType.SelectedItem.ToString();
            string xField = "";
            string yField = "";

            switch (selected)
            {
                case "Import Quantity by Product":
                    xField = "ProductName";
                    yField = "TotalImported";
                    break;
                case "Sales Revenue by Day":
                    xField = "SaleDay";
                    yField = "TotalRevenue";
                    break;
                case "Sales Revenue by Month":
                    xField = "SaleMonth";
                    yField = "TotalRevenue";
                    break;
                case "Sales Revenue by Year":
                    xField = "SaleYear";
                    yField = "TotalRevenue";
                    break;
                case "Profit by Product":
                case "Profit by Product (FIFO)":
                    xField = "ProductName";
                    yField = "Profit";
                    break;
                case "Profit by Employee":
                    xField = "EmployeeName";
                    yField = "Profit";
                    break;
                default:
                    MessageBox.Show("Chart not supported for this report.");
                    return;
            }

            ChartForm chartForm = new ChartForm(dt, selected, xField, yField);
            chartForm.Show();
        }
    }
}
