using BUS;
using DTO;
using GUI.FORM;
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

namespace GUI.UserControls
{
    public partial class ucQLPhieuThu : UserControl
    {
        List<PHIEUTHU> PhieuThuList;
        private P_PhieuThu report;
        public ucQLPhieuThu()
        {
            InitializeComponent();
            // Binding data từ database
            Binding(BUSPhieuThu.Instance.GetAllPhieuThu());
        }
        public void Binding(List<PHIEUTHU> PhieuThuList)
        {
            PhieuThuGrid.Rows.Clear();
            Image print_img = Properties.Resources.printer;
            print_img = (Image)(new Bitmap(print_img, new Size(25, 25)));
            foreach (PHIEUTHU pt in PhieuThuList)
            {
                PhieuThuGrid.Rows.Add(pt.SoPhieuThu, pt.DOCGIA.MaDocGia, pt.SoTienThu, ((DateTime)pt.NgayLap).ToShortDateString(), print_img);
            }
        }
        private void butRefresh_Click(object sender, EventArgs e)
        {
            Binding(BUSPhieuThu.Instance.GetAllPhieuThu());
            txtNam.Text = txtThang.Text = txtNgay.Text = txtFind.Text = "";
        }

        private void Print(int idPT, string maDG, string tenDG, string soTT, string noMoi, string ngaythu)
        {
            report = new P_PhieuThu(idPT, maDG, tenDG, soTT, noMoi, ngaythu);
            report.PrintReport();
        }
        private void butAdd_Click(object sender, EventArgs e)
        {
            var f = new fPhieuThu();
            f.ShowDialog();
            Binding(BUSPhieuThu.Instance.GetAllPhieuThu());
        }

        private void butFind_Click(object sender, EventArgs e)
        {
            string pat = txtFind.Text.ToLower();
            List<PHIEUTHU> list = new List<PHIEUTHU>();
            foreach (PHIEUTHU pt in BUSPhieuThu.Instance.GetAllPhieuThu())
            {
                if(pt.DOCGIA.MaDocGia.ToLower().Contains(pat) || pt.SoPhieuThu.ToString().Contains(pat) || pt.NgayLap.ToShortDateString().Contains(pat))
                { list.Add(pt); }
            }
            Binding(list);
        }

        private void butFindNgay_Click(object sender, EventArgs e)
        {
            int? Ngay = null, Thang = null, Nam = null;
            try
            {
                if (txtNgay.Text != "")
                    Ngay = (Convert.ToInt32(txtNgay.Text));
                if (txtThang.Text != "")
                    Thang = (Convert.ToInt32(txtThang.Text));
                if (txtNam.Text != "")
                    Nam = (Convert.ToInt32(txtNam.Text));
            }
            catch 
            {
                MessageBox.Show("Ngày tháng năm sai format!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;                    
            }
            Binding(BUSPhieuThu.Instance.FindPhieuThuByNgay(Ngay, Thang, Nam));
        }

        private void PhieuThuGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx < 0) return;
            if (e.ColumnIndex != PhieuThuGrid.Columns["xuathd"].Index)
            {
                return;
            }

            int idPT = Convert.ToInt32(PhieuThuGrid.Rows[idx].Cells["SoPhieuThu"].Value);
            string maDG = PhieuThuGrid.Rows[idx].Cells["MaDocGia"].Value.ToString();
            DOCGIA dg = BUSDocGia.Instance.GetDocGiaByMa(maDG);
            string tenDG = dg.TenDocGia;
            string soTT = PhieuThuGrid.Rows[idx].Cells["SoTienThu"].Value.ToString();
            string noMoi = dg.TongNoHienTai.ToString();
            string ngaythu = PhieuThuGrid.Rows[idx].Cells["NgayLap"].Value.ToString();
            Print(idPT, maDG, tenDG, soTT, noMoi, ngaythu);
        }
    }
}
