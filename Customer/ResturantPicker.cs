﻿using System;
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
        private int resID1;
        private int resID2;
        private int resID3;
        private int resID4;
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
                // Fetch restaurant details
                string restaurantQuery = "SELECT TOP 4 rID ,rName, rDetails FROM Restaurant";
                var restaurantData = DbAccess.GetData(restaurantQuery, out error);
                if (!string.IsNullOrEmpty(error))
                {
                    MessageBox.Show("Oops! Something went wrong while fetching restaurant data: " + error);
                    return;
                }

                if (restaurantData.Rows.Count > 0)
                {
                    resID1 = restaurantData.Rows[0].Field<int>("rID");
                    resID2 = restaurantData.Rows[1].Field<int>("rID");
                    resID3 = restaurantData.Rows[2].Field<int>("rID");
                    resID4 = restaurantData.Rows[3].Field<int>("rID");

                    btnResturant1.Text = restaurantData.Rows[0]["rName"].ToString();
                    btnResturant2.Text = restaurantData.Rows[1]["rName"].ToString();
                    btnResturant3.Text = restaurantData.Rows[2]["rName"].ToString();
                    btnResturant4.Text = restaurantData.Rows[3]["rName"].ToString();


                    rtbRes1.Text = restaurantData.Rows[0]["rDetails"].ToString();
                    rtbRes2.Text = restaurantData.Rows[1]["rDetails"].ToString();
                    rtbRes3.Text = restaurantData.Rows[2]["rDetails"].ToString();
                    rtbRes4.Text = restaurantData.Rows[3]["rDetails"].ToString();
                }
                    rtbRes1.BackColor = Color.DarkSalmon;
                    rtbRes2.BackColor = Color.DarkSalmon;
                    rtbRes3.BackColor = Color.DarkSalmon;
                    rtbRes4.BackColor = Color.DarkSalmon;
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
            Res1 res1 = new Res1(userEmail, userID, res1Name, resID1);
            res1.Show();
            this.Hide();
        }

        private void btnResturant2_Click(object sender, EventArgs e)
        {
            res2Name = btnResturant2.Text;
            Res1 res2 = new Res1(userEmail, userID, res2Name, resID2);
            res2.Show();
            this.Hide();
        }

        private void btnResturant3_Click(object sender, EventArgs e)
        {
            res3Name = btnResturant3.Text;
            Res1 res3 = new Res1(userEmail, userID, res3Name, resID3);
            res3.Show();
            this.Hide();

        }

        private void btnResturant4_Click(object sender, EventArgs e)
        {
            res4Name = btnResturant4.Text;
            Res1 res4 = new Res1(userEmail, userID, res4Name, resID4);
            res4.Show();
            this.Hide();
        }
    }
}
