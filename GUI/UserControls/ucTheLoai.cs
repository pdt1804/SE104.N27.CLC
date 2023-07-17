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
    public partial class ucTheLoai : UserControl
    {
        public ucTheLoai()
        {
            InitializeComponent();
            Binding(BUSTheLoai.Instance.GetAllTheLoai());
        }

        public void Binding(List<THELOAI> TheLoaiList)
        {
            TheLoaiGrid.Rows.Clear();
            Image del_img = Properties.Resources.delete;
            del_img = (Image)(new Bitmap(del_img, new Size(25, 25)));
            int index = 0;
            foreach (THELOAI p in TheLoaiList)
            {
                index = 0;
                foreach (var k in BUSTuaSach.Instance.GetAllTuaSach())
                {
                    if (k.THELOAI.id.Equals(p.id))
                    {
                        index++;
                    }    
                }    
                TheLoaiGrid.Rows.Add(p.id, p.MaTheLoai, p.TenTheLoai, index, del_img);
            }

        }


        private void butRefresh_Click_1(object sender, EventArgs e)
        {
            txtTenTL.Text = "";
            Binding(BUSTheLoai.Instance.GetAllTheLoai());
        }

        private void butAdd_Click_1(object sender, EventArgs e)
        {
            var f = new fEditTheLoai();
            f.ShowDialog();
            Binding(BUSTheLoai.Instance.GetAllTheLoai());
        }

        private void txtTenTL_TextChanged(object sender, EventArgs e)
        {
            List<THELOAI> list = new List<THELOAI>();
            foreach (var p in BUSTheLoai.Instance.GetAllTheLoai())
            {
                if (p.TenTheLoai.ToLower().Contains(txtTenTL.Text.ToLower()))
                {
                    list.Add(p);
                }    
            }
            Binding(list);   
        }

        private void TheLoaiGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx < 0) return;
            if (e.ColumnIndex == TheLoaiGrid.Columns["Delete"].Index)
            {
                string result = BUSTheLoai.Instance.DelTheLoai(Convert.ToInt32(TheLoaiGrid.Rows[e.RowIndex].Cells["id"].Value));
                if (result == "")
                {
                    MessageBox.Show("Xóa tựa sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Binding(BUSTheLoai.Instance.GetAllTheLoai());
                }
                else
                {
                    MessageBox.Show(result, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
            var fInfor = new fEditTheLoai(Convert.ToInt32(TheLoaiGrid.Rows[idx].Cells["id"].Value));
            fInfor.ShowDialog();
            Binding(BUSTheLoai.Instance.GetAllTheLoai());
            txtTenTL.Text = "";
        }
    }
}
