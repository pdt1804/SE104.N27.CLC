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
            //string username = txtUsername.Text;
            //string userpwd = txtUserpwd.Text;
            ////BUSLogin bLogin = new BUSLogin();
            ////int id = bLogin.checkValidLogin(username, userpwd);
            //if (username == "" || userpwd == "")
            //{
            //    MessageBox.Show("Thông tin đăng nhập không đầy đủ!", "Thông báo", MessageBoxButtons.OK,
            //                    MessageBoxIcon.Warning);
            //    this.resetTextboxs();
            //}
            //else if (id != -1)
            //{
            //    MessageBox.Show("Đăng nhập thành công!\nChào mừng " + username + "!",
            //                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    //var user = BUSNguoiDung.Instance.GetNguoiDungById(id);
            //    bool isDG = false;
            //    //foreach (var cn in user.NHOMNGUOIDUNG.CHUCNANGs)
            //    //{
            //    //    if (cn.TenChucNang == "DG") { isDG = true; break; }
            //    //}
            //    this.Hide();
            //    if (isDG)
            //    {
            //        //var f = new fHome(id);
            //        //f.ShowDialog();
            //    }
            //    else
            //    {
            //        //var f = new fManager(id);
            //        //f.ShowDialog();
            //    }
            //    this.resetTextboxs();
            //    this.Show();
            //}
            this.Hide();
            Form loginForm = new fManager(1);
            loginForm.Show();
           
            

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void siticonePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void siticoneControlBox2_Click(object sender, EventArgs e)
        {

        }

        private void siticoneSeparator1_Click(object sender, EventArgs e)
        {

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

        private void siticonePanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
    }
}
