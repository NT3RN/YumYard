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

namespace YumYard.Register___Login
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            string username = tbName.Text;
            string password = tbPassword.Text;
            string email = tbEmail.Text;
            string gender = "";
            if (rbtnMale.Checked == true)
            {
                gender = "Male";
            }
            else if (rbtnFemale.Checked == true)
            {
                gender = "Female";
            }
            else
            {
                MessageBox.Show("Input Gender");
            }

            string RegQuery = $"INSERT INTO Customer (C_Name,C_Password,C_Email,C_Gender) values ('{username}','{password}','{email}','{gender}') ";
            string error;
            DbAccess.ExecuteQuery(RegQuery, out error);
            if (string.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show(error);
                return;
            }
            MessageBox.Show("Registration Successful");
        }
    }
}
