using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YumYard.Rform
{
    public partial class r1Order : Form
    {
        private string uId;
        public string Uid { get; set; }
        private string rId;
        public string Rid { get; set; }
        public r1Order(string uid, string rid)
        {
            InitializeComponent();
            this.Uid = uid;
            this.Rid = rid;
        }
    }
}
