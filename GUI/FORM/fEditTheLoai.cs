using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.FORM
{
    public partial class fEditTheLoai : Form
    {
        public fEditTheLoai()
        {
            InitializeComponent();
            siticoneButtonCN.Visible = false;
            labelMaTheLoai.Visible = false;
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void butOK_Click(object sender, EventArgs e)
        {
            if (BUSTheLoai.Instance.AddTheLoai(txtTen.Text))
            this.Close();
        }
    }
}
