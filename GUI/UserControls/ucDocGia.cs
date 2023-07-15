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
    public partial class ucDocGia : UserControl
    {
        public ucDocGia()
        {
            InitializeComponent();
            LoadDocGia();
        }


        private void LoadDocGia()
        {
            DocGiaGrid.Rows.Clear();
            DocGiaGrid.Refresh();
            List<DOCGIA> DocGiaList = BUSDocGia.Instance.GetAllDocGia();
            Image img = Properties.Resources.edit_icon;
            img = (Image)(new Bitmap(img, new Size(25, 25)));   
            foreach (DOCGIA docgia in DocGiaList)
            {
                int SachMuon = BUSDocGia.Instance.GetSoSachDangMuon(docgia.ID);
                DocGiaGrid.Rows.Add(docgia.ID, 0, docgia.MaDocGia, docgia.TenDocGia, docgia.LOAIDOCGIA.TenLoaiDocGia, SachMuon, docgia.NgayHetHan.ToShortDateString(), docgia.TongNoHienTai, img);
            }
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            var fAdddg = new fAddDocGia();
            fAdddg.BringToFront();
            fAdddg.ShowDialog();
            LoadDocGia();
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtFind.Text))
            {
                LoadDocGia();
            }    
            else
            {
                List<DOCGIA> list = new List<DOCGIA>();
                foreach(DOCGIA docGia in BUSDocGia.Instance.GetAllDocGia())
                {
                    if (docGia.TenDocGia.Contains(txtFind.Text))
                    {
                        list.Add(docGia);
                    }    
                }
                DocGiaGrid.DataSource = list;
            }    
        }

        private void butRefresh_Click(object sender, EventArgs e)
        {
            txtFind.Text = "";
        }
    }
}
