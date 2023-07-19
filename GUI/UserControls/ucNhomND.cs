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
    public partial class ucNhomND : UserControl
    {
        public ucNhomND()
        {
            InitializeComponent();
            Bind(BUSNhomNguoiDung.Instance.GetAllNhomNguoiDung());
        }
        public void Bind(List<NHOMNGUOIDUNG> NhomNguoiDungList)
        {
            NDGrid.Rows.Clear();
            Image img_edit = Properties.Resources.edit_icon;
            img_edit = (Image)(new Bitmap(img_edit, new Size(25, 25)));
            Image img_del = Properties.Resources.delete;
            img_del = (Image)(new Bitmap(img_del, new Size(25, 25)));
            foreach (NHOMNGUOIDUNG nnd in NhomNguoiDungList)
            {
                NDGrid.Rows.Add(nnd.id, nnd.MaNhomNguoiDung, nnd.TenNhomNguoiDung, img_edit, img_del);
            }
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            var f = new fAddNhomND();
            f.ShowDialog();
            Bind(BUSNhomNguoiDung.Instance.GetAllNhomNguoiDung());
        }

        private void butRefresh_Click(object sender, EventArgs e)
        {
            Bind(BUSNhomNguoiDung.Instance.GetAllNhomNguoiDung());
        }


        private void NDGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int stt = e.RowIndex;
            if (e.ColumnIndex == -1) return;
            if (e.ColumnIndex == 1) return;
            if (e.ColumnIndex == NDGrid.Columns["Edit"].Index)
            {
                var fEdit = new fEditNhomND(Convert.ToInt32(NDGrid.Rows[stt].Cells["id"].Value));
                fEdit.ShowDialog();
                Bind(BUSNhomNguoiDung.Instance.GetAllNhomNguoiDung());
                return;
            }else if(e.ColumnIndex == NDGrid.Columns["Delete"].Index)
            {
                string error = Convert.ToString(BUSNhomNguoiDung.Instance.DelNhomNguoiDung(Convert.ToInt32(NDGrid.Rows[stt].Cells["id"].Value)));
                if (error != "")
                {
                    MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Đã xoá thành công nhóm người dùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Bind(BUSNhomNguoiDung.Instance.GetAllNhomNguoiDung());
                return;
            }
            if (stt == -1) return;
            var fInfor = new fInfoNhomND(Convert.ToInt32(NDGrid.Rows[stt].Cells["id"].Value));
            fInfor.ShowDialog();
            Bind(BUSNhomNguoiDung.Instance.GetAllNhomNguoiDung());
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            string pat = txtFind.Text.ToLower();
            List<NHOMNGUOIDUNG> Res = new List<NHOMNGUOIDUNG>();
            foreach (NHOMNGUOIDUNG nd in BUSNhomNguoiDung.Instance.GetAllNhomNguoiDung())
            {
                if (nd.TenNhomNguoiDung.ToLower().Contains(pat)|| nd.MaNhomNguoiDung.ToLower().Contains(pat))
                    Res.Add(nd);
            }
            Bind(Res);
        }
    }
}
