using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YumYard.Customer.Forms
{
    public partial class resWelcomeB : Form
    {
        
        public resWelcomeB(string resturantName)
        {
            InitializeComponent();
            richTextBox1.Text = $"Welcome to {resturantName}! \nSelect Order section to get started";
        }
    }
}
