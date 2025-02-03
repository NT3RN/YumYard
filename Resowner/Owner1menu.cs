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
        //private Owner1menu mainForm;
        public Owner1menu(string Owneremail)
        {
         
            InitializeComponent();
            LoadProductData();
           

        }


        public void LoadProductData()
        {
            try
            {
                string query = "SELECT ProductID, ProductName, ProductPrice FROM RestaurantProducts";
                string error;
                DataTable dt = DbAccess.GetData(query, out error);

                if (!string.IsNullOrEmpty(error))
                {
                    MessageBox.Show($"Error loading product data: {error}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                dgvProducts.DataSource = dt;
                dgvProducts.ReadOnly = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnmenuadd_Click(object sender, EventArgs e)
        {

            owner1add owner1Menuadd = new owner1add();
            // owner1Menuadd.Show();
            //this.Hide();
            //Owner1add addMenuForm = new Owner1add(this); // ✅ Pass "this" as the argument
            //addMenuForm.ShowDialog();


        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
