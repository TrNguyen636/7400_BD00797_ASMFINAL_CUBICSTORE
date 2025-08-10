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
using System.Windows.Forms.DataVisualization.Charting;

namespace CubicStore.Controls
{
    public partial class ChartForm : Form
    {
        private string connectionString = "Server=MSI\\SQLEXPRESS;Database=CubicStore;Integrated Security=true;";
        public ChartForm(DataTable data, string title, string xField, string yField)
        {
            InitializeComponent();
            LoadChart(data, title, xField, yField);
        }

        private void LoadChart(DataTable data, string title, string xField, string yField)
        {
            chart1.Series.Clear();
            chart1.Titles.Clear();
            chart1.Titles.Add(title);

            Series series = new Series
            {
                ChartType = SeriesChartType.Column,
                XValueMember = xField,
                YValueMembers = yField,
                IsValueShownAsLabel = true
            };

            chart1.DataSource = data;
            chart1.Series.Add(series);
            chart1.DataBind();
        }

        private void ChartForm_Load(object sender, EventArgs e)
        {
           
        }
    }
}
    

