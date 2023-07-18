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
                    int s = BUSSach.Instance.AddSachMoi(tuasach, Convert.ToInt32(row.Cells[4].Value), Convert.ToInt32(row.Cells[2].Value),row.Cells[3].Value.ToString());
                    BUSCTPhieuNhap.Instance.AddCtPhieuNhap(ph, s, Convert.ToInt32(row.Cells[4].Value), Convert.ToInt32(row.Cells[5].Value));
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
            foreach (DataGridViewRow row in SachGrid.Rows)
            {
                if(tuaSach.id == Convert.ToInt32(row.Cells[0].Value))
                {
                    row.Cells[5].Value = (int.Parse(txtSoLuongNhap.Text) + int.Parse(row.Cells[5].Value.ToString())).ToString();
                    row.Cells[6].Value = (int.Parse(txtDonGia.Text) * int.Parse(row.Cells[5].Value.ToString())).ToString();
                    return;
                }
            }
            SachGrid.Rows.Add(tuaSach.id, tuaSach.TenTuaSach, txtNamXB.Text, txtNhaXB.Text, txtDonGia.Text, txtSoLuongNhap.Text, txtThanhtien.Text);
        }

        private void txtNamXB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtSoLuongNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
