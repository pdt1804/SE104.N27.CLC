using BUS;
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
    public partial class fEditLoaiDG : Form
    {
        private LOAIDOCGIA ldg;
        public fEditLoaiDG(int id)
        {
            InitializeComponent();
            ldg = BUSLoaiDocGia.Instance.GetLoaiDocGiaById(id);
        }
        public fEditLoaiDG()
        {
            InitializeComponent();
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            if (txtTenLoai.Text == "")
            {
                MessageBox.Show("Chưa nhập tên loại độc giả!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Boolean err = BUSLoaiDocGia.Instance.UpdLoaiDocGia(ldg.id, txtTenLoai.Text);
            if (err == true) MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Cập nhật không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();
        }
    }
}
