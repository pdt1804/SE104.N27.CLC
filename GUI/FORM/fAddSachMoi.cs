using BUS;
using DTO;
using GUI.Print;
using GUI.UserControls;
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
        private P_PhieuNhap report;
        public fAddSachMoi()
        {
            InitializeComponent();
            LoadTuaSach();
        }


        private void LoadTuaSach()
        {
            List<TUASACH> listTuaSach = BUSTuaSach.Instance.GetAllTuaSach();
            //List<string> listTuaSach = new List<string>();
            //foreach(var p in BUSTuaSach.Instance.GetAllTuaSach())
            //{
            //    listTuaSach.Add(p.TenTuaSach);
            //}
            comboTuaSach.DataSource = listTuaSach;
            comboTuaSach.DisplayMember = "MaTuaSach";
            comboTuaSach.ValueMember = "id";
        }

        private void Print(int pn)
        {
            var phieu = BUSPhieuNhapSach.Instance.GetPhieuNhap(pn);
            var dsct = phieu.CT_PHIEUNHAP.ToList();
            foreach (var ct in dsct)
            {
                DataGridViewPrint.Rows.Add(ct.SACH.MaSach, ct.SACH.TUASACH.TenTuaSach, ct.SACH.DonGia, ct.SoLuongNhap, ct.ThanhTien);
            }
            Label labelSoPhieu = new Label();
            Label labelNgayNhap = new Label();
            Label labelTongTien = new Label();
            labelSoPhieu.Text = phieu.SoPhieuNhap.ToString();
            labelNgayNhap.Text = phieu.NgayNhap.ToString();
            labelTongTien.Text = phieu.TongTien.ToString();
            report = new P_PhieuNhap(DataGridViewPrint, labelSoPhieu, labelNgayNhap, labelTongTien, 0);
            report.PrintReport();

        }
        private void butOK_Click(object sender, EventArgs e)
        {
            if (SachGrid.Rows.Count > 0)
            {
                int ph = BUSPhieuNhapSach.Instance.AddPhieuNhap(DateTime.Now);
                foreach (DataGridViewRow row in SachGrid.Rows)
                {
                    TUASACH tuasach = BUSTuaSach.Instance.GetTuaSachById(Convert.ToInt32(row.Cells[0].Value));
                    int s = BUSSach.Instance.AddSachMoi(tuasach, Convert.ToInt32(row.Cells[4].Value), Convert.ToInt32(row.Cells[2].Value), row.Cells[3].Value.ToString());
                    BUSCTPhieuNhap.Instance.AddCtPhieuNhap(ph, s, Convert.ToInt32(row.Cells[4].Value), Convert.ToInt32(row.Cells[5].Value));
                }
                Print(ph);
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);   
            }
            else
            {
                MessageBox.Show("Danh sách rỗng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            TUASACH tuaSach = BUSTuaSach.Instance.GetTuaSachById(Convert.ToInt32(comboTuaSach.SelectedIndex));
            if(tuaSach == null)
            {
                MessageBox.Show("Tựa sách không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!(BUSSach.Instance.CheckThamSo(int.Parse(txtNamXB.Text))))
            {
                MessageBox.Show("Năm xuất bản không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(int.Parse(txtThanhtien.Text) <= 0)
            {
                MessageBox.Show("Thành tiện không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (DataGridViewRow row in SachGrid.Rows)
            {
                if(tuaSach.id == Convert.ToInt32(row.Cells[0].Value) && Convert.ToInt32(txtNamXB.Text) == Convert.ToInt32(row.Cells[2].Value) && txtNhaXB.Text.Equals(row.Cells[3].Value.ToString()))
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

        private void comboTuaSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            TUASACH tuaSach = BUSTuaSach.Instance.GetTuaSachById(Convert.ToInt32(comboTuaSach.SelectedIndex));
            if (tuaSach == null) return;
            labelTenTS.Text = tuaSach.TenTuaSach;
        }
    }
}
