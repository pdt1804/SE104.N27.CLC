﻿using BUS;
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
            Bind();
        }
        public void Bind()
        {
            Image img_edit = Properties.Resources.edit_icon;
            img_edit = (Image)(new Bitmap(img_edit, new Size(25, 25)));
            Image img_del = Properties.Resources.delete;
            img_del = (Image)(new Bitmap(img_del, new Size(25, 25)));
            this.NDGrid.DataSource = BUSNhomNguoiDung.Instance.GetAllNhomNguoiDung();
            foreach (DataGridViewRow row in NDGrid.Rows)
            {
                row.Cells["Edit"].Value = img_edit;
                row.Cells["Delete"].Value = img_del;
            }
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            var f = new fAddNhomND();
            f.ShowDialog();
            Bind();
        }

        private void butRefresh_Click(object sender, EventArgs e)
        {
            Bind();
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
                Bind();
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
                Bind();
                return;
            }
            if (stt == -1) return;
            var fInfor = new fInfoNhomND(Convert.ToInt32(NDGrid.Rows[stt].Cells["id"].Value));
            fInfor.ShowDialog();
            Bind();
        }
    }
}
