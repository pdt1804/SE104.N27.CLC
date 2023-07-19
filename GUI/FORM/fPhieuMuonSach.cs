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
    public partial class fPhieuMuonSach : Form
    {
        private DateTime NgayTra;
        private DateTime NgayMuon;

        public fPhieuMuonSach()
        {
            InitializeComponent();
            Binding();
        }

        private void Binding()
        {
            List<CUONSACH> listCS = BUSCuonSach.Instance.GetAllCuonSachAvailable();
            comboCuonSach.DataSource = listCS;
            comboCuonSach.DisplayMember = "MaCuonSach";
            comboCuonSach.ValueMember = "id";

            List<DOCGIA> listDG = BUSDocGia.Instance.GetAllDocGiaAvailable();
            comboDocGia.DataSource = listDG;
            comboDocGia.DisplayMember = "MaDocGia";
            comboDocGia.ValueMember = "id";
            if (listCS.Count == 0)
                return;
            dateNgayMuon.Value = DateTime.Now.Date;
            CUONSACH cuonsach = BUSCuonSach.Instance.GetCuonSachById(Convert.ToInt32(comboCuonSach.SelectedValue));
            labelTenCS.Text = "Tên: " + cuonsach.SACH.TUASACH.TenTuaSach;
            labelTheLoai.Text = "Thể loại: " + cuonsach.SACH.TUASACH.THELOAI.TenTheLoai;
            if (listDG.Count != 0)
            {
                DOCGIA docgia = BUSDocGia.Instance.GetDocGiaById(Convert.ToInt32(comboDocGia.SelectedValue));
                labelHoTen.Text = "Họ tên: " + docgia.TenDocGia;
                labelTongNoHienTai.Text = "Tổng nợ hiện tại: " + docgia.TongNoHienTai.ToString();
            }
            THAMSO thamso = BUSThamSo.Instance.GetAllThamSo();
            NgayMuon = dateNgayMuon.Value.Date;
            labelHanTra.Text = NgayMuon.AddDays((int)thamso.SoNgayMuonToiDa).ToShortDateString();


        }
        private void dateNgayMuon_ValueChanged(object sender, EventArgs e)
        {
            THAMSO thamso = BUSThamSo.Instance.GetAllThamSo();
            NgayMuon = dateNgayMuon.Value.Date;
            labelHanTra.Text = NgayMuon.AddDays((int)thamso.SoNgayMuonToiDa).ToShortDateString();
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            if (comboCuonSach.SelectedValue == null)
            {
                MessageBox.Show("Cuốn sách được chọn không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboDocGia.SelectedValue == null)
            {
                MessageBox.Show("Độc giả được chọn không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            NgayMuon = dateNgayMuon.Value.Date;

            if (NgayMuon > DateTime.Now)
            {
                MessageBox.Show("Ngày mượn không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DOCGIA docgia = BUSDocGia.Instance.GetDocGiaById(Convert.ToInt32(comboDocGia.SelectedValue));
            CUONSACH cuonsach = BUSCuonSach.Instance.GetCuonSachById(Convert.ToInt32(comboCuonSach.SelectedValue));
            string error = BUSPhieuMuonTra.Instance.AddPhieuMuonTra(cuonsach.MaCuonSach, docgia.MaDocGia, NgayMuon);
            if (error != "")
            {
                MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Thêm phiếu mượn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void comboDocGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            DOCGIA docgia = BUSDocGia.Instance.GetDocGiaById(Convert.ToInt32(comboDocGia.SelectedValue));
            if (docgia == null) return;

            labelHoTen.Text = "Họ tên: " + docgia.TenDocGia;
            labelTongNoHienTai.Text = "Tổng nợ hiện tại: " + docgia.TongNoHienTai.ToString();
        }

        private void comboCuonSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            CUONSACH cuonsach = BUSCuonSach.Instance.GetCuonSachById(Convert.ToInt32(comboCuonSach.SelectedValue));
            if (cuonsach == null) return;
            labelTenCS.Text = "Tên: " + cuonsach.SACH.TUASACH.TenTuaSach;
            labelTheLoai.Text = "Thể loại: " + cuonsach.SACH.TUASACH.THELOAI.TenTheLoai;
        }
    }
}
