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
using DTO;
using GUI;
using GUI.FORM;

namespace GUI.UserControls
{
    public partial class ucTacGia : UserControl
    {
        public ucTacGia()
        {
            InitializeComponent();
            Binding(BUSTacGia.Instance.GetAllTacGia());
        }
        public void Binding(List<TACGIA> TacGia)
        {
            TacGiaGrid.Rows.Clear();
            Image del_img = Properties.Resources.delete;
            del_img = (Image)(new Bitmap(del_img, new Size(25, 25)));
            foreach (TACGIA tacgia in TacGia)
            {
                TacGiaGrid.Rows.Add(tacgia.id, tacgia.MATACGIA, tacgia.TenTacGia, del_img);
            }
        }
        private void butAdd_Click(object sender, EventArgs e)
        {
            fEditTacGia f = new fEditTacGia();
            f.ShowDialog();
            Binding(BUSTacGia.Instance.GetAllTacGia());
        }


        private void butRefresh_Click(object sender, EventArgs e)
        {
            txtHoTen.Text = "";
            Binding(BUSTacGia.Instance.GetAllTacGia());
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {
            List<TACGIA> listTacGia = new List<TACGIA>();
            foreach (var p in BUSTacGia.Instance.GetAllTacGia())
            {
                if (p.TenTacGia.ToLower().Contains(txtHoTen.Text.ToLower()))
                {
                    listTacGia.Add(p);
                }    
            }
            Binding(listTacGia);
        }

        private void TacGiaGrid_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx < 0) return;
            if (e.ColumnIndex == TacGiaGrid.Columns["Delete"].Index)
            {
                string result = BUSTacGia.Instance.DelTacGia(Convert.ToInt32(TacGiaGrid.Rows[e.RowIndex].Cells["id"].Value));
                if (result == "")
                {
                    MessageBox.Show("Xóa tựa sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Binding(BUSTacGia.Instance.GetAllTacGia());
                }
                else
                {
                    MessageBox.Show(result, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
            var fInfor = new fEditTacGia(Convert.ToInt32(TacGiaGrid.Rows[idx].Cells["id"].Value));
            fInfor.ShowDialog();
            Binding(BUSTacGia.Instance.GetAllTacGia());
            txtHoTen.Text = "";
        }
    }
}
