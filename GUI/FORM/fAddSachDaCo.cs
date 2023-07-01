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
    public partial class fAddSachDaCo : Form
    {
        public int TongTien { get; set; }
        public fAddSachDaCo()
        {
            InitializeComponent();
            TongTien = 0;
            LoadComboboxSach();

        }


        private void LoadComboboxSach()
        {
            List<string> listSach = new List<string>();
            foreach (var p in BUSSach.Instance.GetAllSach())
            {
                listSach.Add(p.TUASACH.TenTuaSach + "(" + p.MaSach + ")");
            }
            comboSach.DataSource = listSach;
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            DateTime NgayNhap = DateTime.Now;
            if (NgayNhap.Date > DateTime.Now)
            {
                MessageBox.Show("Ngày nhập không hợp lệ");
                return;
            }
            int pn = BUSPhieuNhapSach.Instance.AddPhieuNhap(NgayNhap);
            foreach (DataGridViewRow row in SachGrid.Rows)
            {
                int id = Convert.ToInt32(row.Cells["id"].Value);
                SACH sach = BUSSach.Instance.GetSachById(id);
                if (sach.NamXB > NgayNhap.Year)
                {
                    MessageBox.Show("Sách " + sach.MaSach + " có năm xuất bản lớn hơn ngày nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                }
            }
            foreach (DataGridViewRow row in SachGrid.Rows)
            {
                int id = Convert.ToInt32(row.Cells["id"].Value);
                int DonGia = Convert.ToInt32(row.Cells["donGia"].Value);
                int SoLuongNhap = Convert.ToInt32(row.Cells["SoLuong"].Value);
                BUSCTPhieuNhap.Instance.AddCtPhieuNhap(pn, id, DonGia, SoLuongNhap);
            }
            MessageBox.Show("Thêm phiếu nhập thành công");
            this.Close();
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            int SoLuongNhap;
            if (txtSoLuongNhap.Text == "")
            {
                MessageBox.Show("Chưa điền số lượng nhập");
                return;
            }
            try
            {
                SoLuongNhap = Convert.ToInt32(txtSoLuongNhap.Text);
            }
            catch
            {
                MessageBox.Show("Sai format", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (SoLuongNhap <= 0)
            {
                MessageBox.Show("Số lượng nhập không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string comboSachText = comboSach.SelectedItem.ToString();
            int begin = comboSachText.IndexOf("(");
            int last = comboSachText.IndexOf(")");
            string selectedSach = "";
            while (true)
            {
                begin++;
                if (begin >= last)
                {
                    break;
                }    
                else
                {
                    selectedSach = selectedSach + comboSachText[begin];
                }    
            }    
            SACH sach = BUSSach.Instance.GetSachByMa(selectedSach);
            if (sach.NamXB > DateTime.Now.Year)
            {
                MessageBox.Show("Năm xuất bản của sách lớn hơn ngày nhập", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int ThanhTien = SoLuongNhap * (int)sach.DonGia;
            TongTien += ThanhTien;
            labelTongTien.Text = "Tổng tiền: " + TongTien.ToString();
            foreach (DataGridViewRow row in SachGrid.Rows)
            {
                if (Convert.ToInt32(row.Cells["id"].Value) == sach.id)
                {
                    row.Cells["SoLuong"].Value = Convert.ToInt32(row.Cells["SoLuong"].Value) + SoLuongNhap;
                    row.Cells["ThanhTien"].Value = Convert.ToInt32(row.Cells["ThanhTien"].Value) + ThanhTien;
                    return;
                }
            }
            SachGrid.Rows.Add(sach.id, sach.MaSach, sach.TUASACH.TenTuaSach, sach.DonGia, SoLuongNhap, ThanhTien);
        }
    }
}
