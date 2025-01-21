using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using YumYard.DatabaseAccess;
using YumYard.Customer;

namespace YumYard.Register___Login
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            btnHidePass.Hide();
            lblWarnEmail.Hide();
            lblWarnPass.Hide();
            lblF_pass.Hide();
        }

        private void TextChange(object sender, EventArgs e)
        {
            if (lblWarnEmail.Visible)
            {
                lblWarnEmail.Hide();
            }
            if (lblWarnPass.Visible)
            {
                lblWarnPass.Hide();
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text;
            string password = tbPass.Text;
            bool hasError = false;

            if (string.IsNullOrWhiteSpace(email))
            {
                lblWarnEmail.Text = "Email is required.";
                lblWarnEmail.Show();
                hasError = true;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                lblWarnPass.Text = "Password is required.";
                lblWarnPass.Show();
                hasError = true;
            }

            if (!hasError)
            {
                try
                {
                    // Check if email and password match in the database
                    string signInQuery = $"SELECT COUNT(*) AS UserCount FROM Customer WHERE C_Email = '{email}' AND C_Password = '{password}'";
                    string error;
                    var signInResult = DbAccess.GetData(signInQuery, out error);
                    if (!string.IsNullOrEmpty(error))
                    {
                        MessageBox.Show("Oops! Something went wrong: " + error);
                        return;
                    }

                    if (signInResult.Rows.Count > 0 && Convert.ToInt32(signInResult.Rows[0]["UserCount"]) > 0)
                    {
                        ResturantPicker resturantPicker = new ResturantPicker(email);
                        resturantPicker.Show();
                        this.Hide();
                        
                    }
                    else
                    {
                        MessageBox.Show("Invalid email or password.");
                        lblF_pass.Show();
                        lblWarnEmail.Hide();
                        lblWarnPass.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while trying to sign in: " + ex.Message);
                }
            }
        }

        // Go into registration form
        private void btnClickHere_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Hide();
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            btnShowPass.Hide();
            btnHidePass.Show();
            tbPass.PasswordChar = '\0';
            tbPass.Focus();
        }

        private void btnHidePass_Click(object sender, EventArgs e)
        {
            btnHidePass.Hide();
            btnShowPass.Show();
            tbPass.PasswordChar = '*';
            tbPass.Focus();
        }

        private void lblF_pass_Click(object sender, EventArgs e)
        {
            //PassForgot passForgot = new PassForgot();
            //passForgot.Show();
            //this.Hide();
            MessageBox.Show("Will got to Forget pass freature");
        }
    }
}
