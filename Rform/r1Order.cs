using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YumYard.DatabaseAccess;

namespace YumYard.Rform
{
    public partial class r1Order : Form
    {
        private string uId;
        public string Uid { get; set; }
        private string rId;
        public string Rid { get; set; }

        private string f1;
        private string f2;
        private string f3;
        private string f4;
        private string f5;
        private string f6;
        private double fp1;
        private double fp2;
        private double fp3;
        private double fp4;
        private double fp5;
        private double fp6;

        public r1Order(string uid, string rid)
        {
            InitializeComponent();
            this.Uid = uid;
            this.Rid = rid;
            LoadProductData();
        }

        private void LoadProductData()
        {
            try
            {
                string query = $"SELECT TOP 6 ProductName, ProductPrice FROM RestaurantProducts WHERE RestaurantID = {Rid}";
                string error;
                DataTable productData = DbAccess.GetData(query, out error);

                if (!string.IsNullOrEmpty(error))
                {
                    MessageBox.Show("Error loading product data: " + error);
                    return;
                }

                if (productData.Rows.Count > 0)
                {
                    if (productData.Rows.Count > 0) { f1 = productData.Rows[0]["ProductName"].ToString(); fp1 = Convert.ToDouble(productData.Rows[0]["ProductPrice"]); }
                    if (productData.Rows.Count > 1) { f2 = productData.Rows[1]["ProductName"].ToString(); fp2 = Convert.ToDouble(productData.Rows[1]["ProductPrice"]); }
                    if (productData.Rows.Count > 2) { f3 = productData.Rows[2]["ProductName"].ToString(); fp3 = Convert.ToDouble(productData.Rows[2]["ProductPrice"]); }
                    if (productData.Rows.Count > 3) { f4 = productData.Rows[3]["ProductName"].ToString(); fp4 = Convert.ToDouble(productData.Rows[3]["ProductPrice"]); }
                    if (productData.Rows.Count > 4) { f5 = productData.Rows[4]["ProductName"].ToString(); fp5 = Convert.ToDouble(productData.Rows[4]["ProductPrice"]); }
                    if (productData.Rows.Count > 5) { f6 = productData.Rows[5]["ProductName"].ToString(); fp6 = Convert.ToDouble(productData.Rows[5]["ProductPrice"]); }

                    cbfood1.Text = f1;
                    cbfood2.Text = f2;
                    cbfood3.Text = f3;
                    cbfood4.Text = f4;
                    cbfood5.Text = f5;
                    cbfood6.Text = f6;
                    tbPrice1.Text = fp1.ToString();
                    tbPrice2.Text = fp2.ToString();
                    tbPrice3.Text = fp3.ToString();
                    tbPrice4.Text = fp4.ToString();
                    tbPrice5.Text = fp5.ToString();
                    tbPrice6.Text = fp6.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading product data: " + ex.Message);
            }
        }
    }
}
