using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YumYard.Customer.Forms;

namespace YumYard.Customer
{
    public partial class BackUpOFCustomerInfo : Form
    {
        private string email;
        
        public BackUpOFCustomerInfo(string Email)
        {
            InitializeComponent();
            this.email = Email;
            lblTitle.Text = "User Information";
            ActiveButton(btnUser);

            LoadForm(new UserInfoForm(email));
        }

        private void LoadForm(Form form)
        {
            if (this.panelCustomerDisplay.Controls.Count > 0)
                this.panelCustomerDisplay.Controls.RemoveAt(0);

            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.panelCustomerDisplay.Controls.Add(form);
            this.panelCustomerDisplay.Tag = form;
            form.Show();
        }

        private void NonActiveButton(Button nonActiveButton)
        {
            nonActiveButton.BackColor = Color.FromArgb(222, 143, 50);
        }

        private void ActiveButton(Button activeButton)
        {
            activeButton.BackColor = Color.LightBlue;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Home";
            ActiveButton(btnHome);
            ResturantPicker resturantPicker = new ResturantPicker(email);
            resturantPicker.Show();
            this.Close();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "User Information";
            ActiveButton(btnUser);
            NonActiveButton(btnOrderInfo);
            NonActiveButton(btnHome);
            LoadForm(new UserInfoForm(email));
        }

        private void btnOrderInfo_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "My Orders";
            ActiveButton(btnOrderInfo);
            NonActiveButton(btnUser);
            NonActiveButton(btnHome);
            LoadForm(new CustomerOderDetails(email));

        }
    }
}
