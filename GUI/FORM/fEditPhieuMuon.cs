using BUS;
using DTO;
using GUI.Print;
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
    public partial class fEditPhieuMuon : Form
    {
        private int sntt;
        private int dgp;
        private int stp;
        private P_PhieuMuonTra report;
        private PHIEUMUONTRA PhieuMuon;
        public fEditPhieuMuon(int idPhieuMuon)
        {
            InitializeComponent();
            PhieuMuon = BUSPhieuMuonTra.Instance.GetPhieuMuonTraById(idPhieuMuon);
            init();
        }
        private void init()
        {
            labelMaCS.Text += " " + PhieuMuon.CUONSACH.MaCuonSach;
            labelTenCS.Text += PhieuMuon.CUONSACH.SACH.TUASACH.TenTuaSach;
            labelSoPhieu.Text += PhieuMuon.SoPhieuMuonTra;
            labelNgayMuon.Text = ((DateTime)PhieuMuon.NgayMuon).ToShortDateString();
            labelHanTra.Text = ((DateTime)PhieuMuon.HanTra).ToShortDateString();
            labelHoTen.Text += " " + PhieuMuon.DOCGIA.TenDocGia;
            labelMaDG.Text += ": " + PhieuMuon.DOCGIA.MaDocGia;
            labelTheLoai.Text += PhieuMuon.CUONSACH.SACH.TUASACH.THELOAI.TenTheLoai;
            if (PhieuMuon.NgayTra != null)
            {
                dateNgayTra.Visible = false;
                labelNgayTra.Visible = true;
                labelNgayTra.Text = ((DateTime)PhieuMuon.NgayTra).ToShortDateString();
                butSave.Visible = false;
                isDaTra.CheckState = CheckState.Checked;
                isDaTra.Enabled = false;
            }
            if (PhieuMuon.NgayTra != null) dateNgayTra.Value = (DateTime)PhieuMuon.NgayTra;
            else
                dateNgayTra.Value = DateTime.Now.Date;
            THAMSO thamso = BUSThamSo.Instance.GetAllThamSo();
            labelDonGiaPhat.Text += thamso.DonGiaPhat.ToString();
            int TienPhat = 0;
            if (dateNgayTra.Value > PhieuMuon.HanTra)
                TienPhat = (int)((DateTime)dateNgayTra.Value - (DateTime)PhieuMuon.HanTra).TotalDays;
            labelSoNgayTre.Text = "Số ngày trả trễ: " + TienPhat.ToString();
            labelTienPhat.Text = "Tiền phạt: " + (thamso.DonGiaPhat * TienPhat).ToString();
            labelTongNoHienTai.Text += PhieuMuon.DOCGIA.TongNoHienTai.ToString();
        }

        private void dateNgayTra_ValueChanged(object sender, EventArgs e)
        {
            if (isDaTra.Checked == true)
            {
                THAMSO thamso = BUSThamSo.Instance.GetAllThamSo();
                int ngay = 0;
                if (dateNgayTra.Value > PhieuMuon.HanTra)
                    ngay = (int)((DateTime)dateNgayTra.Value - (DateTime)PhieuMuon.HanTra).TotalDays;
                labelSoNgayTre.Text = "Số ngày trả trễ: " + ngay.ToString();
                labelTienPhat.Text = "Tiền phạt: " + (thamso.DonGiaPhat * ngay).ToString();
            }
        }

        private void Print(PHIEUMUONTRA pmt, int sntt, int dongiaphat, int sotienphat)
        {
            report = new P_PhieuMuonTra(pmt, sntt, dongiaphat, sotienphat);
            report.PrintReport();
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            if (isDaTra.Checked == false) return;
            THAMSO thamso = BUSThamSo.Instance.GetAllThamSo();
            if (dateNgayTra.Value < PhieuMuon.NgayMuon)
            {
                MessageBox.Show("Ngày trả không được trước ngày mượn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dateNgayTra.Value > DateTime.Now.Date)
            {
                MessageBox.Show("Ngày trả không được sau hôm nay!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string err = (BUSPhieuMuonTra.Instance.UpdPhieuMuonTra(PhieuMuon.SoPhieuMuonTra, dateNgayTra.Value.Date)).ToString();

            if (err != "")
            {
                MessageBox.Show(err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int ngay = 0;
            if (dateNgayTra.Value > PhieuMuon.HanTra)
                ngay = (int)((DateTime)dateNgayTra.Value - (DateTime)PhieuMuon.HanTra).TotalDays;
            err = BUSDocGia.Instance.UpdTongNo(PhieuMuon.DOCGIA.ID, (int)PhieuMuon.DOCGIA.TongNoHienTai + (int)(thamso.DonGiaPhat * ngay));
            MessageBox.Show("Đã cập nhật phiếu mượn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            sntt = ngay;
            dgp = thamso.DonGiaPhat;
            stp = (int)(thamso.DonGiaPhat * ngay);
            Print(PhieuMuon, sntt, dgp, stp);
            this.Close();
        }

        private void butPrint_Click(object sender, EventArgs e)
        {
            THAMSO thamso = BUSThamSo.Instance.GetAllThamSo();
            int ngay = 0;
            if (dateNgayTra.Value > PhieuMuon.HanTra)
                ngay = (int)((DateTime)dateNgayTra.Value - (DateTime)PhieuMuon.HanTra).TotalDays;
            sntt = ngay;
            dgp = thamso.DonGiaPhat;
            stp = (int)(thamso.DonGiaPhat * ngay);
            Print(PhieuMuon, sntt, dgp, stp);
        }
    }
}
