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
using YumYard.DatabaseAccess;

namespace YumYard.Resowner
{
    public partial class Owner1menu : Form
    {
        public Owner1menu()
        {
            InitializeComponent();
            LoadProductData();

        }


        private void LoadProductData()
        {
            try
            {
                // Query to retrieve product details
                string query = "SELECT ProductID, ProductName, ProductPrice, ProductPicture FROM Product1";
                string error;
                DataTable dt = DbAccess.GetData(query, out error);

                if (!string.IsNullOrEmpty(error))
                {
                    MessageBox.Show("Error loading product data: " + error);
                    return;
                }

                dgvProducts.DataSource = dt; // Bind data to DataGridView

                // Add Image Column if not already added
                if (!dgvProducts.Columns.Contains("ProductImage"))
                {
                    DataGridViewImageColumn imgColumn = new DataGridViewImageColumn
                    {
                        Name = "ProductImage",
                        HeaderText = "Image",
                        ImageLayout = DataGridViewImageCellLayout.Zoom
                    };
                    dgvProducts.Columns.Add(imgColumn);
                }

                // Load images into the DataGridView
                foreach (DataGridViewRow row in dgvProducts.Rows)
                {
                    if (row.Cells["ProductPicture"].Value != null)
                    {
                        string imageName = row.Cells["ProductPicture"].Value.ToString().Trim(); // Remove extra spaces

                        if (!string.IsNullOrEmpty(imageName))
                        {
                            string imageFolderPath = Path.Combine(Application.StartupPath, "images");
                            string imagePath = Path.Combine(imageFolderPath, imageName);

                            if (File.Exists(imagePath))
                            {
                                row.Cells["ProductImage"].Value = Image.FromFile(imagePath);
                            }
                            else
                            {
                                MessageBox.Show($"Image not found: {imagePath}");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Image name is empty or null.");
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }




        private void btnmenuadd_Click(object sender, EventArgs e)
        {
            



        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
