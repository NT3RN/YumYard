using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using YumYard.DatabaseAccess;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace YumYard.Customer
{
    public partial class CustomerInfoUpdate : Form
    {
        public CustomerInfoUpdate(string email)
        {
            InitializeComponent();

            
            LoadCustomerData(email);
        }
        private void LoadCustomerData(string userEmail) 
        {
            try
            {
                string query = $"SELECT C_ID, C_Name, C_Email, C_Gender FROM Customer WHERE C_Email = '{userEmail}'";
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
                    tbEmail.Text = customerData.Rows[0]["C_Email"].ToString();
                    tbGender.Text = customerData.Rows[0]["C_Gender"].ToString();
                    
                }
                else
                {
                    MessageBox.Show("No customer data found for the provided email.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading customer data: " + ex.Message);
            }

        }
    }
}
