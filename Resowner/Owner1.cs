﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace YumYard.Resowner
{
    public partial class Owner1 : Form
    {

        private string Owneremail; 
        //private string resEmail;
        public Owner1(string owneremail)
        {   
            InitializeComponent();
            Owneremail = owneremail;
            // resEmail = restuarantemail;
             //LoadProductData();
        }




        private void btnMenu_Click(object sender, EventArgs e)
        {
            Owner1menu owner1Menu = new Owner1menu(Owneremail);
            owner1Menu.Show();
             this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            
        }
    }
}
