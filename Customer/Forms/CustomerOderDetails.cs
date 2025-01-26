﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YumYard.DatabaseAccess;

namespace YumYard.Customer.Forms
{
    public partial class CustomerOderDetails : Form
    {
        private string email;
        private string UID;
        public CustomerOderDetails(string Email)
        {
            InitializeComponent();
            this.email = Email;
            LoadCustomerData(email);

        }

        private void LoadCustomerData(string userEmail)
        {
            try
            {
                string query = $"SELECT C_ID, C_Name FROM Customer WHERE C_Email = '{userEmail}'";
                string error;
                var customerData = DbAccess.GetData(query, out error);
                if (!string.IsNullOrEmpty(error))
                {
                    MessageBox.Show("Oops! Something went wrong: " + error);
                    return;
                }

                if (customerData.Rows.Count > 0)
                {
                    tbUserID.Text = customerData.Rows[0]["C_ID"].ToString();
                    tbUserName.Text = customerData.Rows[0]["C_Name"].ToString();
                    UID = tbUserID.Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading customer data: " + ex.Message);
            }
        }
    }
}
