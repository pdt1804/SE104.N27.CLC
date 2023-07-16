using BUS;
using DTO;
using System;
using System.Collections;
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
    public partial class fAddDocGia : Form
    {
        public fAddDocGia()
        {
            InitializeComponent();
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text;
                string userpwd = txtUserpwd.Text;
                string chucVu = txtChucVu.Text;
                string tenDG = txtHoTen.Text;
                string email = txtEmail.Text;
                string DiaChi = txtDiaChi.Text;
                int idLDG = (int)comboLoaiDG.SelectedValue;
                DateTime NgaySinh = dateNgaySinh.Value.Date;
                DateTime NgayLapThe = dateNgayLap.Value.Date;
                THAMSO thamso = BUSThamSo.Instance.GetAllThamSo();
                DateTime NgayHetHan = NgayLapThe.AddMonths((int)thamso.ThoiHanThe);

                if (tenDG == "" || username == "" || userpwd == "" || comboNND.SelectedItem == null || comboLoaiDG.SelectedItem == null)
                {
                    MessageBox.Show("Chưa điền đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idNhom = (int)comboNND.SelectedValue;

                bool addDG = BUSDocGia.Instance.AddDocGia(tenDG, idLDG, NgayLapThe, email, DiaChi, NgaySinh, NgayHetHan,
                username, userpwd, chucVu, idNhom);

                if (!addDG)
                {
                    MessageBox.Show("Thêm độc giả không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show("Thêm độc giả thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ");
            }
        }

        private void dateNgayLap_ValueChanged(object sender, EventArgs e)
        {
            THAMSO thamso = BUSThamSo.Instance.GetAllThamSo();
            DateTime NgayLapThe = dateNgayLap.Value.Date;
            DateTime NgayHetHan = NgayLapThe.AddMonths((int)thamso.ThoiHanThe);
            dateNgayHetHan.Text = NgayHetHan.Date.ToShortDateString();
        }

        private void fAddDocGia_Load(object sender, EventArgs e)
        {
            // Load Loại độc giả
            var listLDG = BUSLoaiDocGia.Instance.GetAllLoaiDocGia();
            comboLoaiDG.DataSource = listLDG;
            comboLoaiDG.DisplayMember = "TenLoaiDocGia";
            comboLoaiDG.SelectedIndex = 0;
            comboLoaiDG.ValueMember = "id";
            // Load Nhóm người dùng được xem là độc giả
            var listNND = BUSNhomNguoiDung.Instance.GetAllNhomNguoiDung();
            List<NHOMNGUOIDUNG> listDG_NND = new List<NHOMNGUOIDUNG>();
            foreach (var nnd in listNND)
            {
                bool isDG = false;
                foreach (CHUCNANG cn in nnd.CHUCNANGs)
                    if (cn.TenChucNang == "DG")
                    {
                        isDG = true;
                        break;
                    }
                if (isDG) listDG_NND.Add(nnd);
            }
            comboNND.DataSource = listDG_NND;
            comboNND.DisplayMember = "TenNhomNguoiDung";
            comboNND.ValueMember = "id";
            //
            dateNgayLap.Value = DateTime.Now;
        }
    }
}
