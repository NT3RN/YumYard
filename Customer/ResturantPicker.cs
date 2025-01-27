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
using YumYard.Register___Login;

namespace YumYard.Customer
{
    public partial class ResturantPicker : Form
    {
        private string userEmail;
        public ResturantPicker(string email)
        {
            InitializeComponent();
            userEmail = email;

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
    }
}
