using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fChangePassword : Form
    {
        private NGUOIDUNG usr;

        string MHT;
        public fChangePassword(int _id, int? code)
        {
            InitializeComponent();
            Binding(_id, code);
        }

        private void Binding(int _id, int? code)
        {
            usr = BUSNguoiDung.Instance.GetNguoiDungById(_id);
            if(code == null)
            {
                MHT = usr.MatKhau;
                return;
            }
            MHT = code.ToString();
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            if (txtMKHT.Text == "" || txtRMKM.Text == "" || txtMKM.Text == "")
            {
                MessageBox.Show("Chưa điền đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtMKHT.Text != MHT)
            {
                MessageBox.Show("Thông tin chưa trùng khớp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtMKM.Text != txtRMKM.Text)
            {
                MessageBox.Show("Mật khẩu mới không khớp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            BUSNguoiDung.Instance.UpdMK(usr.id, txtMKM.Text);
            MessageBox.Show("Cập nhật mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
