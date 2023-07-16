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
            LoadDocGia(BUSDocGia.Instance.GetAllDocGia());
        }

        // Lỗi hiển thị sau mỗi lần tìm kiếm

        private void LoadDocGia(List<DOCGIA> DocGiaList)
        {
            DocGiaGrid.Rows.Clear();
            DocGiaGrid.Refresh();
            Image edit_img = Properties.Resources.edit_icon;
            edit_img = (Image)(new Bitmap(edit_img, new Size(25, 25)));
            Image del_img = Properties.Resources.delete;
            del_img = (Image)(new Bitmap(del_img, new Size(25, 25)));
            foreach (DOCGIA docgia in DocGiaList)
            {
                int SachMuon = BUSDocGia.Instance.GetSoSachDangMuon(docgia.ID);
                DocGiaGrid.Rows.Add(docgia.ID, 0, docgia.MaDocGia, docgia.TenDocGia, docgia.LOAIDOCGIA.TenLoaiDocGia, SachMuon, docgia.NgayHetHan.ToShortDateString(), docgia.TongNoHienTai, edit_img, del_img);
            }
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            var fAdddg = new fAddDocGia();
            //fAdddg.BringToFront();
            fAdddg.ShowDialog();
            LoadDocGia(BUSDocGia.Instance.GetAllDocGia());
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            List<DOCGIA> list = new List<DOCGIA>();
            foreach(DOCGIA docGia in BUSDocGia.Instance.GetAllDocGia())
            {
                if (docGia.TenDocGia.ToLower().Contains(txtFind.Text))
                {
                    list.Add(docGia);
                }    
            }
            LoadDocGia(list);
        }

        private void butRefresh_Click(object sender, EventArgs e)
        {
            LoadDocGia(BUSDocGia.Instance.GetAllDocGia());
            txtFind.Text = "";
        }

        private void DocGiaGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex == -1)
            {
                return;
            }
            if (e.ColumnIndex == DocGiaGrid.Columns["Edit"].Index)
            {
                var f = new fEditDocGia((Convert.ToInt32(DocGiaGrid.Rows[e.RowIndex].Cells["id"].Value)));
                f.ShowDialog();
                LoadDocGia(BUSDocGia.Instance.GetAllDocGia());
                return;
            }else if(e.ColumnIndex == DocGiaGrid.Columns["Delete"].Index)
            {
                string result = BUSDocGia.Instance.DelDocGia(Convert.ToInt32(DocGiaGrid.Rows[e.RowIndex].Cells["id"].Value));
                if(result == "") 
                {
                    MessageBox.Show("Xóa độc giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDocGia(BUSDocGia.Instance.GetAllDocGia());
                }
                else
                {
                    MessageBox.Show(result, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
            var fInfor = new fInfoDocGia(Convert.ToInt32(DocGiaGrid.Rows[e.RowIndex].Cells["id"].Value));
            fInfor.ShowDialog();
            LoadDocGia(BUSDocGia.Instance.GetAllDocGia());
            return;
        }
    }
}
