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
using BUS;
namespace GUI.UserControls
{
    public partial class ucLoaiDG : UserControl
    {
        public ucLoaiDG()
        {
            InitializeComponent();
            LoadLoaiDocGia(BUSLoaiDocGia.Instance.GetAllLoaiDocGia());
        }

        public void LoadLoaiDocGia(List<LOAIDOCGIA> LoaiDocGiaList)
        {
            LoaiDocGiaGrid.Rows.Clear();
            LoaiDocGiaGrid.Refresh();
            Image del_img = Properties.Resources.delete;
            del_img = (Image)(new Bitmap(del_img, new Size(25, 25)));
            foreach (LOAIDOCGIA loaidocgia in LoaiDocGiaList)
            {

                LoaiDocGiaGrid.Rows.Add(loaidocgia.id, loaidocgia.MaLoaiDocGia, loaidocgia.TenLoaiDocGia, del_img);
            }
        }

       

        private void butAdd_Click(object sender, EventArgs e)
        {
            var fAddLoaidg = new fAddLoaiDG();
            fAddLoaidg.BringToFront();
            fAddLoaidg.ShowDialog();
            LoadLoaiDocGia(BUSLoaiDocGia.Instance.GetAllLoaiDocGia());
        }

        private void txtTenLoaiDG_TextChanged(object sender, EventArgs e)
        {
            List<LOAIDOCGIA> list = new List<LOAIDOCGIA>();
            foreach (LOAIDOCGIA loaidocGia in BUSLoaiDocGia.Instance.GetAllLoaiDocGia())
            {
                if (loaidocGia.TenLoaiDocGia.ToLower().Contains(txtTenLoaiDG.Text.ToLower()))
                {
                    list.Add(loaidocGia);
                }
            }
            LoadLoaiDocGia(list);
        }

        private void butRefresh_Click(object sender, EventArgs e)
        {
            txtTenLoaiDG.Text = "";
            LoadLoaiDocGia(BUSLoaiDocGia.Instance.GetAllLoaiDocGia());
        }

        private void LoaiDocGiaGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx < 0) return;
            if(e.ColumnIndex == LoaiDocGiaGrid.Columns["Delete"].Index)
            {
                if (BUSLoaiDocGia.Instance.DelLoaiDocGia(Convert.ToInt32(LoaiDocGiaGrid.Rows[idx].Cells["id"].Value)))
                {
                    MessageBox.Show("Xoá thành công");
                    LoadLoaiDocGia(BUSLoaiDocGia.Instance.GetAllLoaiDocGia());
                }
                else
                {
                    MessageBox.Show("Không thể xoá, cần xoá hết độc giả có loại độc giả muốn xoá trước khi xoá loại độc giả");
                }
                return;
            }
            var f = new fEditLoaiDG(Convert.ToInt32(LoaiDocGiaGrid.Rows[idx].Cells["id"].Value));
            f.ShowDialog();
            LoadLoaiDocGia(BUSLoaiDocGia.Instance.GetAllLoaiDocGia());
            return;
        }
    }
}
