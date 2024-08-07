﻿using BUS;
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

namespace GUI.FORM
{
    public partial class fEditTuaSach : Form
    {

        TUASACH tuasach;
        List<TACGIA> TacGiaList;

        public fEditTuaSach(int id)
        {
            InitializeComponent();
            tuasach = BUSTuaSach.Instance.GetTuaSachById(id);
            txtTenTuaSach.Text = tuasach.TenTuaSach;
            List<THELOAI> theloai = BUSTheLoai.Instance.GetAllTheLoai();
            comboTheLoai.DataSource = theloai;
            comboTheLoai.DisplayMember = "TenTheLoai";
            comboTheLoai.ValueMember = "id";
            int idx = 0;
            foreach (THELOAI tl in theloai)
            {
                if (tl.TenTheLoai == tuasach.THELOAI.TenTheLoai)
                    comboTheLoai.SelectedIndex = idx;
                idx++;
            }
            foreach (TACGIA tg in tuasach.TACGIAs)
            {
                TacGiaGrid.Rows.Add(tg.id, tg.TenTacGia);
            }
            Binding();
        }

        private void Binding()
        {
            TacGiaList = BUSTacGia.Instance.GetAllTacGia();
            comboTacGia.DataSource = TacGiaList;
            comboTacGia.DisplayMember = "TenTacGia";
            comboTacGia.ValueMember = "id";
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            List<TACGIA> TgList = new List<TACGIA>();
            string TenTuaSach = txtTenTuaSach.Text;
            if (TenTuaSach == "")
            {
                MessageBox.Show("Tên tựa sách không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int TheLoai = Convert.ToInt32(comboTheLoai.SelectedValue);
            THELOAI tl = BUSTheLoai.Instance.GetTheLoai(TheLoai);
            foreach (DataGridViewRow row in TacGiaGrid.Rows)
            {
                if (TgList.Contains(BUSTacGia.Instance.GetTacGia(Convert.ToInt32(row.Cells["id"].Value))))
                    continue;
                TgList.Add(BUSTacGia.Instance.GetTacGia(Convert.ToInt32(row.Cells["id"].Value)));
            }
            Boolean err = BUSTuaSach.Instance.UpdTuaSach(tuasach.id, TenTuaSach, tl, TgList);
            if (err == false)
            {
                MessageBox.Show("Cập nhật không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Chỉnh sửa tựa sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void butAddTacGia_Click(object sender, EventArgs e)
        {
            bool check_tk = false;
            bool check_tt = false;
            int selectedValue = Convert.ToInt32(comboTacGia.SelectedValue);
            string newtg = comboTacGia.Text;
            foreach (var tg in BUSTacGia.Instance.GetAllTacGia())
            {
                if (tg.id == selectedValue)
                {
                    check_tk = true;
                    foreach (DataGridViewRow row in TacGiaGrid.Rows)
                    {
                        if (selectedValue == Convert.ToInt32(row.Cells[0].Value))
                        {
                            check_tt = true;
                            MessageBox.Show("Tác giả bạn vừa chọn đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    }
                    break;
                }
            }
            if (check_tk == false)
            {
                var ask = MessageBox.Show("Tác giả chưa có, bạn có muốn thêm mới?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ask == DialogResult.Yes)
                {
                    selectedValue = BUSTacGia.Instance.AddTacGia(newtg);
                    Binding();
                }
                else return;
            }
            if (!check_tt) TacGiaGrid.Rows.Add(selectedValue, newtg);
        }
    }
}
