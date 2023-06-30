using BUS;
using DTO;
using GUI.FORM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UserControls
{
    public partial class ucQLPhieuMuon : UserControl
    {
        List<PHIEUMUONTRA> PhieuMuonList;
        public ucQLPhieuMuon()
        {
            InitializeComponent();
            Binding(BUSPhieuMuonTra.Instance.GetAllPhieuMuonTra());
            List<string> comboList = new List<string> { "Chưa trả", "Đã trả" };
            comboTinhTrang.DataSource = comboList;
        }
        public void Binding(List<PHIEUMUONTRA> PhieuMuonList)
        {
            PhieuMuonGrid.Rows.Clear();
            /*Image img = Properties.Resources.edit_icon;
            img = (Image)(new Bitmap(img, new Size(20, 20)));*/
            foreach (PHIEUMUONTRA pmt in PhieuMuonList)
            {
                string NgayTra = (pmt.NgayTra != null) ? (((DateTime)pmt.NgayTra).ToShortDateString()) : ("Chưa trả");
                PhieuMuonGrid.Rows.Add(0, pmt.SoPhieuMuonTra, pmt.CUONSACH.MaCuonSach, pmt.CUONSACH.SACH.TUASACH.TenTuaSach, pmt.DOCGIA.MaDocGia, ((DateTime)pmt.NgayMuon).ToShortDateString(), ((DateTime)pmt.HanTra).ToShortDateString(), NgayTra, pmt.SoTienPhat);
            }
        }

        private void ucQLPhieuMuon_Load(object sender, EventArgs e)
        {
            Binding(BUSPhieuMuonTra.Instance.GetAllPhieuMuonTra());
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            var f = new fPhieuMuonSach();
            f.ShowDialog();
            Binding(BUSPhieuMuonTra.Instance.GetAllPhieuMuonTra());
        }
    }
}
