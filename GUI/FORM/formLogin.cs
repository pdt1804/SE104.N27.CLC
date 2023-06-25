using BUS;
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
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }
        private void resetTextboxs()
        {
            txtUsername.Clear();
            txtUserpwd.Clear();
            txtUsername.Focus();
        }

        private void butLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.ToString();
            string userpwd = txtUserpwd.Text.ToString();
            int id = BUSLogin.Instance.checkValidLogin(username, userpwd);
            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(userpwd))
            {
                MessageBox.Show("Thông tin đăng nhập không đầy đủ!", "Thông báo", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                this.resetTextboxs();
            }
            else if (id > 0)
            {
                MessageBox.Show("Đăng nhập thành công!\nChào mừng " + username + "!",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var user = BUSNguoiDung.Instance.GetNguoiDungById(id);
                bool isDG = false;
                foreach (var cn in user.NHOMNGUOIDUNG.CHUCNANGs)
                {
                    if (cn.TenChucNang.Equals("DG")) 
                    { 
                        isDG = true; 
                        break; 
                    }
                }
                this.Hide();
                if (isDG)
                {
                    var f = new fHome(id);
                    f.ShowDialog();
                }
                else
                {
                    var f = new fManager(id);
                    f.ShowDialog();
                }
                this.resetTextboxs();
                this.Show();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                this.resetTextboxs();
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void QMK_Click(object sender, EventArgs e)
        {
            var f = new fQMK();
            f.ShowDialog();
        }

        private void txtUserpwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
