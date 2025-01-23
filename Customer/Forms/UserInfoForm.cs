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

namespace YumYard.Customer.Forms
{
    public partial class UserInfoForm : Form
    {
        private string userEmail;
        private string currentPassword;

        public UserInfoForm(string email)
        {
            InitializeComponent();
            this.userEmail = email;
            LoadCustomerData(email);
            lblWarnID.Hide();
            lblWarnUN.Hide();
            lblWarnEmail.Hide();
            lblWarnCPass.Hide();
            lblWarnNPass.Hide();
            btnHidePass.Hide();
        }

        private void LoadCustomerData(string userEmail)
        {
            try
            {
                string query = $"SELECT C_ID, C_Name, C_Password, C_Email, C_Gender FROM Customer WHERE C_Email = '{userEmail}'";
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
                    currentPassword = customerData.Rows[0]["C_Password"].ToString();
                    string gender = customerData.Rows[0]["C_Gender"].ToString();
                    if (gender == "Male")
                    {
                        rbtnMale.Checked = true;
                    }
                    else if (gender == "Female")
                    {
                        rbtnFemale.Checked = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading customer data: " + ex.Message);
            }
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

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            btnShowPass.Hide();
            btnHidePass.Show();
            tbCurrPass.Focus();
            tbCurrPass.PasswordChar = '\0';
            tbNewPass.PasswordChar = '\0';
        }

        private void btnHidePass_Click(object sender, EventArgs e)
        {
            btnHidePass.Hide();
            btnShowPass.Show();
            tbCurrPass.Focus();
            tbCurrPass.PasswordChar = '*';
            tbNewPass.PasswordChar = '*';
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string userID = tbUserID.Text;
            string updatedName = tbUserName.Text;
            string updatedEmail = tbEmail.Text;
            string updatedGender = rbtnMale.Checked ? "Male" : rbtnFemale.Checked ? "Female" : "";
            string enteredCurrentPassword = tbCurrPass.Text;
            string newPassword = tbNewPass.Text;

            lblWarnID.Hide();
            lblWarnUN.Hide();
            lblWarnEmail.Hide();
            lblWarnCPass.Hide();
            lblWarnNPass.Hide();

            if (string.IsNullOrWhiteSpace(updatedName))
            {
                lblWarnUN.Text = "Name cannot be empty.";
                lblWarnUN.Show();
                return;
            }
            else
            {
                lblWarnUN.Hide();
            }

            if (string.IsNullOrWhiteSpace(updatedEmail) || !IsValidEmail(updatedEmail))
            {
                lblWarnEmail.Text = "Valid email is required.";
                lblWarnEmail.Show();
                return;
            }
            else
            {
                lblWarnEmail.Hide();
            }

            if (!string.IsNullOrWhiteSpace(enteredCurrentPassword) || !string.IsNullOrWhiteSpace(newPassword))
            {
                if (string.IsNullOrWhiteSpace(enteredCurrentPassword))
                {
                    lblWarnCPass.Text = "Current password is required.";
                    lblWarnCPass.Show();
                    return;
                }
                else
                {
                    lblWarnCPass.Hide();
                }

                if (string.IsNullOrWhiteSpace(newPassword) || !IsValidPassword(newPassword))
                {
                    lblWarnNPass.Text = "At least 8 characters long and contain a mix of letters and numbers.";
                    lblWarnNPass.Show();
                    return;
                }
                else
                {
                    lblWarnNPass.Hide();
                }
                if (enteredCurrentPassword != currentPassword)
                {
                    lblWarnCPass.Text = "Wrong current password";
                    lblWarnCPass.Show();

                    return;
                }
                else if (enteredCurrentPassword == newPassword)
                {
                    lblWarnNPass.Text = "New password cannot be the same as the current password.";
                    lblWarnNPass.Show();
                    return;
                }
                else
                {
                    lblWarnNPass.Hide();
                    lblWarnCPass.Hide();
                }
            }

            try
            {
                // Check if the updated email already exists in the database
                string checkEmailQuery = $"SELECT COUNT(*) AS EmailCount FROM Customer WHERE C_Email = '{updatedEmail}' AND C_ID != '{userID}'";
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

                // Update customer information
                string updateQuery = $"UPDATE Customer SET C_Name = '{updatedName}', C_Email = '{updatedEmail}', C_Gender = '{updatedGender}' WHERE C_ID = '{userID}'";
                DbAccess.ExecuteQuery(updateQuery, out error);
                if (!string.IsNullOrEmpty(error))
                {
                    MessageBox.Show("Oops! Something went wrong: " + error);
                    return;
                }

                // Update password if provided
                if (!string.IsNullOrWhiteSpace(enteredCurrentPassword) && !string.IsNullOrWhiteSpace(newPassword))
                {
                    // Check if the entered current password matches the one in the database
                    if (enteredCurrentPassword != currentPassword)
                    {
                        lblWarnCPass.Text = "Current password is incorrect.";
                        lblWarnCPass.Show();
                        return;
                    }

                    // Update the password
                    string updatePasswordQuery = $"UPDATE Customer SET C_Password = '{newPassword}' WHERE C_ID = '{userID}'";
                    DbAccess.ExecuteQuery(updatePasswordQuery, out error);
                    if (!string.IsNullOrEmpty(error))
                    {
                        MessageBox.Show("Oops! Something went wrong: " + error);
                        return;
                    }
                }

                MessageBox.Show("Customer information updated successfully.");

                // Reload customer data to reflect changes
                LoadCustomerData(updatedEmail);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating customer information: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string userID = tbUserID.Text;

            var confirmResult = MessageBox.Show("Are you sure you want to delete this customer?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    string deleteQuery = $"DELETE FROM Customer WHERE C_ID = '{userID}'";
                    string error;
                    DbAccess.ExecuteQuery(deleteQuery, out error);
                    if (!string.IsNullOrEmpty(error))
                    {
                        MessageBox.Show("Oops! Something went wrong: " + error);
                        return;
                    }
                    MessageBox.Show("Customer deleted successfully.");
                    Register___Login.LogIn logIn = new Register___Login.LogIn();
                    logIn.Show();
                    this.Close(); // Close the form after deletion
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while deleting the customer: " + ex.Message);
                }
            }
        }
    }
}
