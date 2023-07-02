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

namespace GUI
{
    public partial class fEditTacGia : Form
    {
        private TACGIA tacgia;
        public fEditTacGia(int id)
        {
            InitializeComponent();
            tacgia = BUSTacGia.Instance.GetTacGia(id);
            labelMa.Text += tacgia.MATACGIA;
            txtTen.Text = tacgia.TenTacGia;
            siticoneButton1.Visible = false;
        }

        public fEditTacGia()
        {
            InitializeComponent();
            labelMa.Visible = false;
            butOK.Visible = false;
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            if (txtTen.Text == "")
            {
                MessageBox.Show("Tên tác giả không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (BUSTacGia.Instance.UpdTacGia(tacgia.id, txtTen.Text))
            {

                MessageBox.Show("Sửa thông tin tác giả thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Lỗi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            var tentg = txtTen.Text;
            if (String.IsNullOrEmpty(tentg)) return;
            var tglist = BUSTacGia.Instance.GetAllTacGia();
            //Tác giả có thể trùng tên
            //foreach (var tg in tglist)
            //{
            //    if (tg.TenTacGia == tentg)
            //        if (MessageBox.Show("Tên tác giả này đã có, bạn có chắc muốn thêm?",
            //            "Thêm tác giả", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) break;
            //        else return;
            //}
            int id = BUSTacGia.Instance.AddTacGia(tentg);
            if (id == -1) MessageBox.Show("Có lỗi xảy ra. Không thể thêm tác giả. Vui lòng kiểm tra lại!", "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            else MessageBox.Show("Thêm tác giả mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
