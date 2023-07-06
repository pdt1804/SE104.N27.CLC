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
            // Lấy data từ database hiển thị lên datagridview
            Binding(BUSPhieuMuonTra.Instance.GetAllPhieuMuonTra());
            List<string> comboList = new List<string> { "Chưa trả", "Đã trả" };
            comboTinhTrang.DataSource = comboList;
        }
        public void Binding(List<PHIEUMUONTRA> PhieuMuonList)
        {
            PhieuMuonGrid.Rows.Clear();
            Image img = Properties.Resources.edit_icon;
            img = (Image)(new Bitmap(img, new Size(20, 20)));
            foreach (PHIEUMUONTRA pmt in PhieuMuonList)
            {
                string NgayTra = (pmt.NgayTra != null) ? (((DateTime)pmt.NgayTra).ToShortDateString()) : ("Chưa trả");
                PhieuMuonGrid.Rows.Add(0, pmt.SoPhieuMuonTra, pmt.CUONSACH.MaCuonSach, pmt.CUONSACH.SACH.TUASACH.TenTuaSach, pmt.DOCGIA.MaDocGia, ((DateTime)pmt.NgayMuon).ToShortDateString(), ((DateTime)pmt.HanTra).ToShortDateString(), NgayTra, pmt.SoTienPhat);
            }
        }
        private void butAdd_Click(object sender, EventArgs e)
        {
            var f = new fPhieuMuonSach();
            f.ShowDialog();
            Binding(BUSPhieuMuonTra.Instance.GetAllPhieuMuonTra());
        }

        private void PhieuMuonGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (e.ColumnIndex == 0) return;
            if (idx == -1) return;
            var f = new fEditPhieuMuon((Convert.ToInt32(PhieuMuonGrid.Rows[idx].Cells["SoPhieuMuon"].Value)));
            f.ShowDialog();
            Binding(BUSPhieuMuonTra.Instance.GetAllPhieuMuonTra());

            return;
        }

        private void butRefresh_Click(object sender, EventArgs e)
        {
            Binding(BUSPhieuMuonTra.Instance.GetAllPhieuMuonTra());
            txtFind.Text = "";
        }

        private void butFil_Click(object sender, EventArgs e)
        {
            string pat = comboTinhTrang.SelectedValue.ToString();

            List<PHIEUMUONTRA> list = new List<PHIEUMUONTRA>();

            foreach (PHIEUMUONTRA pmt in BUSPhieuMuonTra.Instance.GetAllPhieuMuonTra())
            {
                if (pmt.NgayTra != null && pat == "Đã trả")
                    list.Add(pmt);
                Console.Write(pmt.NgayTra.ToString());
                if (pmt.NgayTra == null && pat == "Chưa trả")
                    list.Add(pmt);
            }
            Binding(list);
        }

        private void butFind_Click(object sender, EventArgs e)
        {
            string str = txtFind.Text.ToString();
            List<PHIEUMUONTRA> list = new List<PHIEUMUONTRA>();
            foreach(PHIEUMUONTRA pmt in BUSPhieuMuonTra.Instance.GetAllPhieuMuonTra())
            {
                if(pmt.CUONSACH.MaCuonSach.ToLower().Contains(str) || pmt.DOCGIA.MaDocGia.ToLower().Contains(str) || pmt.SoPhieuMuonTra.ToString().Contains(str))
                {
                    list.Add(pmt);
                }
            }
            Binding(list);
        }
    }
}
    