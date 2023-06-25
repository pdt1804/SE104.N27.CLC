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
    public partial class fEditNguoiDung : Form
    {
        private static int id;
        public fEditNguoiDung(int _id)
        {
            InitializeComponent();
            id = _id;
            Bind();
        }

        private void Bind()
        {
            var nd = BUSNguoiDung.Instance.GetNguoiDungById(id);
            labelMaNd.Text += nd.MaNguoiDung;
            txtHoTen.Text = nd.TenNguoiDung;
            txtChucVu.Text = nd.ChucVu;
            var dsNND = BUSNhomNguoiDung.Instance.GetAllNhomNguoiDung();
            foreach (var n in dsNND)
            {
                n.TenNhomNguoiDung = n.TenNhomNguoiDung + "(" + n.MaNhomNguoiDung + ")";
            }
            labelNhomNND.Text = nd.NHOMNGUOIDUNG.TenNhomNguoiDung;
            //comboNhomND.SelectedValue = nd.id;

            if (nd.NgaySinh != null) dateNgaySinh.Value = (DateTime)nd.NgaySinh;
        }

        
        private void butReset_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có chắc muốn reset mật khẩu?", "Reset mật khẩu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                BUSNguoiDung.Instance.UpdMK(id, "123");
                MessageBox.Show("Reset mật khẩu thành công, mật khẩu là 123", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
    }
}
