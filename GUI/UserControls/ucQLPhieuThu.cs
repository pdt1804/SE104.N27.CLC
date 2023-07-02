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
    public partial class ucQLPhieuThu : UserControl
    {
        List<PHIEUTHU> PhieuThuList;
        public ucQLPhieuThu()
        {
            InitializeComponent();
            // Binding data từ database
            Binding(BUSPhieuThu.Instance.GetAllPhieuThu());
        }
        public void Binding(List<PHIEUTHU> PhieuThuList)
        {
            PhieuThuGrid.Rows.Clear();
            foreach(PHIEUTHU pt in PhieuThuList)
            {
                PhieuThuGrid.Rows.Add(pt.SoPhieuThu, pt.DOCGIA.MaDocGia, pt.SoTienThu, ((DateTime)pt.NgayLap).ToShortDateString());
            }
        }
        private void butRefresh_Click(object sender, EventArgs e)
        {
            Binding(BUSPhieuThu.Instance.GetAllPhieuThu());
            txtNam.Text = txtThang.Text = txtNgay.Text = txtFind.Text = "";
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
    }
}
