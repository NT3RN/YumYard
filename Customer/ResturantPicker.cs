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
            CustomerInfoUpdate customerInfoUpdate = new CustomerInfoUpdate(userEmail);
            customerInfoUpdate.Show();
            this.Hide();
        }
    }
}
