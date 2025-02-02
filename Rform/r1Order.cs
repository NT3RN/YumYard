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

        private void ChkChanged(object sender, EventArgs e)
        {
            if (cbfood1.Checked)
            {
                comboBox1.Enabled = true;
            }
            else
            {
                comboBox1.Enabled = false;
                comboBox1.Text = "1";
            }
            if (cbfood2.Checked)
            {
                comboBox2.Enabled = true;
            }
            else
            {
                comboBox2.Enabled = false;
                comboBox2.Text = "1";
            }
            if (cbfood3.Checked)
            {
                comboBox3.Enabled = true;
            }
            else
            {
                comboBox3.Enabled = false;
                comboBox3.Text = "1";
            }
            if (cbfood4.Checked)
            {
                comboBox4.Enabled = true;
            }
            else
            {
                comboBox4.Enabled = false;
                comboBox4.Text = "1";
            }
            if (cbfood5.Checked)
            {
                comboBox5.Enabled = true;
            }
            else
            {
                comboBox5.Enabled = false;
                comboBox5.Text = "1";
            }
            if (cbfood6.Checked)
            {
                comboBox6.Enabled = true;
            }
            else
            {
                comboBox6.Enabled = false;
                comboBox6.Text = "1";
            }
        }

        private void cbTextChange(object sender, EventArgs e)
        {
            if (cbfood1.Enabled == true)
            {
                if (comboBox1.Text == "1")
                {
                    tbPrice1.Text = fp1.ToString();
                }
                else if (comboBox1.Text == "2")
                {
                    tbPrice1.Text = (fp1 * 2).ToString();
                }
                else if (comboBox1.Text == "3")
                {
                    tbPrice1.Text = (fp1 * 3).ToString();
                }
                else if (comboBox1.Text == "4")
                {
                    tbPrice1.Text = (fp1 * 4).ToString();
                }
                else if (comboBox1.Text == "5")
                {
                    tbPrice1.Text = (fp1 * 5).ToString();
                }
            }
            else
            {
                tbPrice1.Text = fp1.ToString();
            }

            if (cbfood2.Enabled == true)
            {
                if (comboBox2.Text == "1")
                {
                    tbPrice2.Text = fp2.ToString();
                }
                else if (comboBox2.Text == "2")
                {
                    tbPrice2.Text = (fp2 * 2).ToString();
                }
                else if (comboBox2.Text == "3")
                {
                    tbPrice2.Text = (fp2 * 3).ToString();
                }
                else if (comboBox2.Text == "4")
                {
                    tbPrice2.Text = (fp2 * 4).ToString();
                }
                else if (comboBox2.Text == "5")
                {
                    tbPrice2.Text = (fp2 * 5).ToString();
                }
            }
            else
            {
                tbPrice2.Text = fp2.ToString();
            }

            if (cbfood3.Enabled == true)
            {
                if (comboBox3.Text == "1")
                {
                    tbPrice3.Text = fp3.ToString();
                }
                else if (comboBox3.Text == "2")
                {
                    tbPrice3.Text = (fp3 * 2).ToString();
                }
                else if (comboBox3.Text == "3")
                {
                    tbPrice3.Text = (fp3 * 3).ToString();
                }
                else if (comboBox3.Text == "4")
                {
                    tbPrice3.Text = (fp3 * 4).ToString();
                }
                else if (comboBox3.Text == "5")
                {
                    tbPrice3.Text = (fp3 * 5).ToString();
                }
            }
            else
            {
                tbPrice3.Text = fp3.ToString();
            }


            if (cbfood4.Enabled == true)
            {
                if (comboBox4.Text == "1")
                {
                    tbPrice4.Text = fp4.ToString();
                }
                else if (comboBox4.Text == "2")
                {
                    tbPrice4.Text = (fp4 * 2).ToString();
                }
                else if (comboBox4.Text == "3")
                {
                    tbPrice4.Text = (fp4 * 3).ToString();
                }
                else if (comboBox4.Text == "4")
                {
                    tbPrice4.Text = (fp4 * 4).ToString();
                }
                else if (comboBox4.Text == "5")
                {
                    tbPrice4.Text = (fp4 * 5).ToString();
                }
            }
            else
            {
                tbPrice4.Text = fp4.ToString();
            }
            
            if (cbfood5.Enabled == true)
            {
                if (comboBox5.Text == "1")
                {
                    tbPrice5.Text = fp5.ToString();
                }
                else if (comboBox5.Text == "2")
                {
                    tbPrice5.Text = (fp5 * 2).ToString();
                }
                else if (comboBox5.Text == "3")
                {
                    tbPrice5.Text = (fp5 * 3).ToString();
                }
                else if (comboBox5.Text == "4")
                {
                    tbPrice5.Text = (fp5 * 4).ToString();
                }
                else if (comboBox5.Text == "5")
                {
                    tbPrice5.Text = (fp5 * 5).ToString();
                }
            }
            else
            {
                tbPrice5.Text = fp5.ToString();
            }

            if (cbfood6.Enabled == true)
            {
                if (comboBox6.Text == "1")
                {
                    tbPrice6.Text = fp6.ToString();
                }
                else if (comboBox6.Text == "2")
                {
                    tbPrice6.Text = (fp6 * 2).ToString();
                }
                else if (comboBox6.Text == "3")
                {
                    tbPrice6.Text = (fp6 * 3).ToString();
                }
                else if (comboBox6.Text == "4")
                {
                    tbPrice6.Text = (fp6 * 4).ToString();
                }
                else if (comboBox6.Text == "5")
                {
                    tbPrice6.Text = (fp6 * 5).ToString();
                }
            }
            else
            {
                tbPrice6.Text = fp6.ToString();
            }
        }
    }
}
