using System;
using System.Collections;
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

            lblWarnUN.Hide();
            lblWarnEmail.Hide();
            lblWarnPass.Hide();
            lblWarnConPass.Hide();
            btnHidePass.Hide();
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsValidPassword(string password)
        {
            if (password.Length < 8)
                return false;

            bool hasLetter = false;
            bool hasDigit = false;

            foreach (char c in password)
            {
                if (char.IsLetter(c))
                    hasLetter = true;
                else if (char.IsDigit(c))
                    hasDigit = true;

                if (hasLetter && hasDigit)
                    return true;
            }

            return false;
        }
        
        private void passMatch(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbPassword.Text) || string.IsNullOrEmpty(tbConPass.Text))
            {
                lblWarnConPass.Hide();
            }
            else if (tbPassword.Text != tbConPass.Text)
            {
                lblWarnConPass.Text = "Passwords do not match.";
                lblWarnConPass.Show();
            }
            else
            {
                lblWarnConPass.Hide();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = tbName.Text;
            string password = tbPassword.Text;
            string confirmPassword = tbConPass.Text;
            string email = tbEmail.Text;

            if (string.IsNullOrWhiteSpace(username))
            {
                lblWarnUN.Text = "Username is required.";
                lblWarnUN.Show();
                return;
            }
            else
            {
                lblWarnUN.Hide();
            }

            if (string.IsNullOrWhiteSpace(email) || !IsValidEmail(email))
            {
                lblWarnEmail.Text = "Valid email is required.";
                lblWarnEmail.Show();
                return;
            }
            else
            {
                lblWarnEmail.Hide();
            }

            if (string.IsNullOrWhiteSpace(password) || !IsValidPassword(password))
            {
                lblWarnPass.Text = "At least 8 characters and contains a mix of letters and numbers.";
                lblWarnPass.Show();
                return;
            }
            else
            {
                lblWarnPass.Hide();
            }

            if (password != confirmPassword)
            {
                lblWarnConPass.Text = "Passwords do not match.";
                lblWarnConPass.Show();
                return;
            }
            else
            {
                lblWarnConPass.Hide();
            }

            string gender = "";
            if (rbtnMale.Checked)
            {
                gender = "Male";
            }
            else if (rbtnFemale.Checked)
            {
                gender = "Female";
            }
            else
            {
                MessageBox.Show("Input Gender");
                return;
            }

            // Check if email already exists in the database
            string checkEmailQuery = $"SELECT COUNT(*) AS EmailCount FROM Customer WHERE C_Email = '{email}'";
            string error;
            var emailCheckResult = DbAccess.GetData(checkEmailQuery, out error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show("Oops! Something went wrong: " + error);
                return;
            }

            if (emailCheckResult.Rows.Count > 0 && Convert.ToInt32(emailCheckResult.Rows[0]["EmailCount"]) > 0)
            {
                lblWarnEmail.Text = "Email already exists.";
                lblWarnEmail.Show();
                return;
            }

            //inserting customer data into database
            string RegQuery = $"INSERT INTO Customer (C_Name,C_Password,C_Email,C_Gender) values ('{username}','{password}','{email}','{gender}') ";
            DbAccess.ExecuteQuery(RegQuery, out error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }
            MessageBox.Show("Registration Successful");
        }

        

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            btnShowPass.Hide();
            btnHidePass.Show();
            tbPassword.PasswordChar = '\0';
            tbConPass.PasswordChar = '\0';
        }

        private void btnHidePass_Click(object sender, EventArgs e)
        {
            btnHidePass.Hide();
            btnShowPass.Show();
            tbPassword.PasswordChar = '*';
            tbConPass.PasswordChar = '*';
        }
    }
}
