﻿using BUS;
using DTO;
using GUI.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fHome : Form
    {

        private NGUOIDUNG user;
        public fHome(int id)
        {
            InitializeComponent();

            user = BUSNguoiDung.Instance.GetNguoiDungById(id);
            container.Controls.Add(new ucHome_TTTK(id) { Dock = DockStyle.Fill, Name = "tttk" });
            container.Controls.Add(new ucHome_TCS() { Dock = DockStyle.Fill, Name = "tcsach" });
            butTTTK.Checked = true;
            Control[] con = container.Controls.Find("tttk", false);
            con[0].BringToFront();
        }

        private void butTTTK_Click(object sender, EventArgs e)
        {
            Control[] con = container.Controls.Find("tttk", false);
            con[0].BringToFront();
        }

        private void butTraCuu_Click(object sender, EventArgs e)
        {
            Control[] con = container.Controls.Find("tcsach", false);
            con[0].BringToFront();
        }

        private void exitControlBox_Click(object sender, EventArgs e)
        {
            DialogResult res = new DialogResult();
            res = MessageBox.Show("Bạn có chắc muốn thoát?", "Thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes) this.Close();
        }

        private void butManager_Click(object sender, EventArgs e)
        {
            bool canAccess = false;
            foreach (var cn in user.NHOMNGUOIDUNG.CHUCNANGs)
            {
                if (cn.TenChucNang != "DG")
                {
                    canAccess = true;
                    break;
                }
            }
            if (canAccess)
            {
                var f = new fManager(user.id);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
