using BUS;
using DTO;
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
            label2.Visible = false;
        }

        public THELOAI theloai { get; set; }
        public fEditTheLoai(int id)
        {
            InitializeComponent();
            butOK.Visible = false;
            theloai = new THELOAI();
            theloai = BUSTheLoai.Instance.GetTheLoai(id);
            txtTen.Text = theloai.TenTheLoai;
            label2.Text = theloai.MaTheLoai;
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

        private void siticoneButtonCN_Click(object sender, EventArgs e)
        {
            if (BUSTheLoai.Instance.UpdTheLoai(theloai.id, txtTen.Text))
            {
                MessageBox.Show("Cập nhật thành công");
                this.Close();
            }    
        }
    }
}
