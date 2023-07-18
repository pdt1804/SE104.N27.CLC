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
            List<string> listCS = new List<string>();
            foreach (var cs in BUSCuonSach.Instance.GetAllCuonSachAvailable())
            {
                listCS.Add(cs.id + " | " + cs.MaCuonSach + " | " + cs.SACH.TUASACH.TenTuaSach);
            }
            comboCuonSach.DataSource = listCS;
            List<string> listDG = new List<string>();
            foreach (var dg in BUSDocGia.Instance.GetAllDocGiaAvailable())
            {
                listDG.Add(dg.ID + " | " + dg.MaDocGia + " | " + dg.TenDocGia);
            }
            comboDocGia.DataSource = listDG;

        }
        private void dateNgayMuon_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void butSave_Click(object sender, EventArgs e)
        {
           
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
