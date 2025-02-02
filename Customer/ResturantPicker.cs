using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YumYard.DatabaseAccess;
using YumYard.Register___Login;
using YumYard.Restaurants;

namespace YumYard.Customer
{
    public partial class ResturantPicker : Form
    {
        private string userEmail;
        private string userID;
        private int resID;
        //restaurant names
        public string res1Name;
        public string res2Name;
        public string res3Name;
        public string res4Name;
        
        public ResturantPicker(string email)
        {
            InitializeComponent();
            userEmail = email;
            LoadCustomerData(email);

        }

        private void LoadCustomerData(string userEmail)
        {
            try
            {
                string query = $"SELECT C_ID FROM Customer WHERE C_Email = '{userEmail}'";
                string error;
                var customerData = DbAccess.GetData(query, out error);
                if (!string.IsNullOrEmpty(error))
                {
                    MessageBox.Show("Oops! Something went wrong: " + error);
                    return;
                }

                if (customerData.Rows.Count > 0)
                {
                    userID = customerData.Rows[0]["C_ID"].ToString();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading customer data: " + ex.Message);
            }
        }

        private void msiProfile_Click(object sender, EventArgs e)
        {
            BackUpOFCustomerInfo backUpOFCustomerInfo = new BackUpOFCustomerInfo(userEmail);
            backUpOFCustomerInfo.Show();
            this.Hide();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to logout?", "Confirm logout", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                LogIn logIn = new LogIn();
                logIn.Show();
                this.Hide();
            }
            
            
        }

        private void btnResturant1_Click(object sender, EventArgs e)
        {
            res1Name = btnResturant1.Text;
            resID = 1;
            Res1 res1 = new Res1(userEmail, userID, res1Name, resID);
            res1.Show();
            this.Hide();
        }
    }
}
