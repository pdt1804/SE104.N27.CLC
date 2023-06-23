using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using BUS;
using System.Windows.Forms;

namespace GUI
{
    public partial class fInfoNguoiDung : Form
    {
    
        public fInfoNguoiDung(int _id)
        {
            InitializeComponent();

        }

       
        private void butChange_Click(object sender, EventArgs e)
        {
            var f = new fEditNguoiDung();
            f.ShowDialog();
        }

        private void fInfoNguoiDung_Load(object sender, EventArgs e)
        {

        }
    }
}
