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

namespace GUI.UserControls
{
    public partial class ucPhieuNhap : UserControl
    {
        public List<PHIEUNHAPSACH> listPNS { get; set; }
        public ucPhieuNhap()
        {
            InitializeComponent();
            listPNS = new List<PHIEUNHAPSACH>(BUSPhieuNhapSach.Instance.GetAllPhieuNhapSach());  
            Binding(listPNS);
        }
        public void Binding(List<PHIEUNHAPSACH> PhieuNhapList)
        {
            PhieuNhapgrid.DataSource = PhieuNhapList;
        }

        private void PhieuNhapgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int stt = e.RowIndex;
            if (stt < 0) return;
            int idPhieu = (int)PhieuNhapgrid.Rows[stt].Cells["SoPhieuNhap"].Value;
            var f = new fInfoPhieuNhap(idPhieu);
            f.ShowDialog();
        }

        private void butRefresh_Click(object sender, EventArgs e)
        {
            Binding(BUSPhieuNhapSach.Instance.GetAllPhieuNhapSach());
            txtNam.Text = txtThang.Text = txtNgay.Text = txtFind.Text = "";
        }


        private void butFind_Click(object sender, EventArgs e)
        {
            string pat = txtFind.Text.ToLower();
            List<PHIEUNHAPSACH> Res = new List<PHIEUNHAPSACH>();
            foreach (PHIEUNHAPSACH pn in BUSPhieuNhapSach.Instance.GetAllPhieuNhapSach())
            {
                if (pn.SoPhieuNhap.ToString().Contains(pat))
                    Res.Add(pn);
            }
            Binding(Res);

        }

        private void butFindDay_Click(object sender, EventArgs e)
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
            Binding(BUSPhieuNhapSach.Instance.FindPhieuByNgayNhap(Ngay, Thang, Nam));
            txtFind.Text = "";
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtFind.Text))
            {
                Binding(listPNS);
            }    
            else
            {
                List<PHIEUNHAPSACH> listSearching = new List<PHIEUNHAPSACH>();
                foreach (var p in listPNS)
                {
                    if (p.SoPhieuNhap.ToString().ToLower().Contains(txtFind.Text.ToString().ToLower()))
                    {
                        listSearching.Add(p);
                    }    
                }    
                Binding(listSearching);
            }    
        }
    }
}
