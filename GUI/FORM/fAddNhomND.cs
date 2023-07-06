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

namespace GUI.FORM
{
    public partial class fAddNhomND : Form
    {
        public fAddNhomND()
        {
            InitializeComponent();
            Bind();
        }
        private void Bind()
        {
            var dscn = BUSChucNang.Instance.GetAllChucNang();
            foreach(var cn in dscn)
            {
                dsChucNang.Rows.Add("0", cn.MaChucNang, cn.TenChucNang, cn.TenManHinh);
            }
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            string ten = txtTenNhom.Text;
            if (ten == "")
            {
                MessageBox.Show("Tên nhóm người dùng không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int id = BUSNhomNguoiDung.Instance.AddNhomNguoiDung(ten);
            if (id == -1)
            {
                return;
            }
            List<String> dsCn = new List<String>();
            foreach (DataGridViewRow row in this.dsChucNang.Rows)
            {
                if (row.Cells["isChoosen"].Value.ToString() == "1")
                {
                    dsCn.Add(row.Cells["MaChucNang"].Value.ToString());
                }
            }
            string res = BUSNhomNguoiDung.Instance.AddChucNangNhom(id, dsCn);
            if (res == "") MessageBox.Show("Thêm nhóm người dùng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show(res, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();
        }
    }
}
