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
    public partial class fAddSachMoi : Form
    {
        public fAddSachMoi()
        {
            InitializeComponent();
            LoadTuaSach();
        }

        private void LoadTuaSach()
        {
            List<string> listTuaSach = new List<string>();
            foreach(var p in BUSTuaSach.Instance.GetAllTuaSach())
            {
                listTuaSach.Add(p.TenTuaSach);
            }
            comboTuaSach.DataSource = listTuaSach;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void butOK_Click(object sender, EventArgs e)
        {
            TUASACH tuaSach = new TUASACH();
            foreach (var p in BUSTuaSach.Instance.GetAllTuaSach())
            {
                if (p.TenTuaSach.Equals(comboTuaSach.SelectedItem.ToString()))
                {
                    tuaSach = p;
                    break;
                }    
            }
            int s = BUSSach.Instance.AddSachMoi(tuaSach, int.Parse(txtDonGia.Text), int.Parse(txtNamXB.Text), txtNhaXB.Text);
            int ph = BUSPhieuNhapSach.Instance.AddPhieuNhap(DateTime.Now);
            BUSCTPhieuNhap.Instance.AddCtPhieuNhap(ph, s, int.Parse(txtDonGia.Text), int.Parse(txtSoLuongNhap.Text));
            this.Close();
        }

        private void txtSoLuongNhap_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSoLuongNhap.Text))
            {
                txtThanhtien.Text = "";
            }    
            else
            {
                txtThanhtien.Text = (int.Parse(txtDonGia.Text) * int.Parse(txtSoLuongNhap.Text)).ToString();
            }    
        }
    }
}
