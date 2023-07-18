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


        private void butOK_Click(object sender, EventArgs e)
        {
            if (SachGrid.Rows.Count <= 0)
            {
                MessageBox.Show("Danh sách rỗng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int ph = BUSPhieuNhapSach.Instance.AddPhieuNhap(DateTime.Now);
                foreach (DataGridViewRow row in SachGrid.Rows)
                {
                    TUASACH tuasach = BUSTuaSach.Instance.GetTuaSachById(Convert.ToInt32(row.Cells[0].Value));
                    int s = BUSSach.Instance.AddSachMoi(tuasach, int.Parse(txtDonGia.Text), int.Parse(txtNamXB.Text), txtNhaXB.Text);
                    BUSCTPhieuNhap.Instance.AddCtPhieuNhap(ph, s, int.Parse(txtDonGia.Text), int.Parse(txtSoLuongNhap.Text));
                }
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        private void txtSoLuongNhap_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSoLuongNhap.Text) || String.IsNullOrEmpty(txtDonGia.Text))
            {
                txtThanhtien.Text = "";
            }
            else
            {
                txtThanhtien.Text = (int.Parse(txtDonGia.Text) * int.Parse(txtSoLuongNhap.Text)).ToString();
            }
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSoLuongNhap.Text) || String.IsNullOrEmpty(txtDonGia.Text))
            {
                txtThanhtien.Text = "";
            }
            else
            {
                txtThanhtien.Text = (int.Parse(txtDonGia.Text) * int.Parse(txtSoLuongNhap.Text)).ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Nếu tựa sách trùng thì chỉ thay đổi một số trường trong datagridview
            TUASACH tuaSach = new TUASACH();
            foreach (var p in BUSTuaSach.Instance.GetAllTuaSach())
            {
                if (p.TenTuaSach.Equals(comboTuaSach.SelectedItem.ToString()))
                {
                    tuaSach = p;
                    break;
                }
            }
            SachGrid.Rows.Add(tuaSach.id, tuaSach.TenTuaSach, txtNamXB.Text, txtNhaXB.Text, txtDonGia.Text, txtSoLuongNhap.Text, txtThanhtien.Text);
        }
    }
}
