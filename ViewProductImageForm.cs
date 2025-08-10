using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CubicStore.Controls
{
    public partial class ViewProductImageForm : Form
    {
        private int productId;
        string connectionString = "Server=MSI\\SQLEXPRESS;Database=CubicStore;Integrated Security=true;";
        public ViewProductImageForm(int productId)
        {
            InitializeComponent();
            this.productId = productId;
            LoadImages();

        }
        private void LoadImages()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM ProductImages WHERE ProductID = @Id";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@Id", productId);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvListImage.DataSource = dt;
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dgvListImage_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvListImage.CurrentRow != null)
            {
                txtImageID.Text = dgvListImage.CurrentRow.Cells["ImageID"].Value.ToString();
                txtProductID.Text = dgvListImage.CurrentRow.Cells["ProductID"].Value.ToString();
                txtImageName.Text = dgvListImage.CurrentRow.Cells["ImageName"].Value.ToString();

                byte[] imgData = (byte[])dgvListImage.CurrentRow.Cells["ImageData"].Value;
                using (MemoryStream ms = new MemoryStream(imgData))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                byte[] imgBytes = File.ReadAllBytes(ofd.FileName);
                string imgName = Path.GetFileName(ofd.FileName);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"INSERT INTO ProductImages (ProductID, ImageData, ImageName) 
                                     VALUES (@Pid, @Data, @Name)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Pid", productId);
                    cmd.Parameters.AddWithValue("@Data", imgBytes);
                    cmd.Parameters.AddWithValue("@Name", imgName);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                LoadImages();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvListImage.CurrentRow == null) return;
            int imageId = Convert.ToInt32(dgvListImage.CurrentRow.Cells["ImageID"].Value);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM ProductImages WHERE ImageID = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", imageId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadImages();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
   
}
