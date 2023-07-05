using BUS;
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
            Image img = Properties.Resources.edit_icon;
            img = (Image)(new Bitmap(img, new Size(20, 20)));
            this.NDGrid.DataSource = BUSNhomNguoiDung.Instance.GetAllNhomNguoiDung();
            foreach (DataGridViewRow row in NDGrid.Rows)
            {
                row.Cells["Edit"].Value = img;
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

        private void butDel_Click(object sender, EventArgs e)
        {
            List<int> idDel = new List<int>();
            foreach (DataGridViewRow row in NDGrid.Rows)
            {
                Console.WriteLine(row.Cells["isChosen"].Value);
                if (row.Cells["isChosen"].Value == "1")
                {
                    idDel.Add((int)row.Cells["id"].Value);

                }
            }
            if (idDel.Count == 0) { return; }
            int cnt = 0;
            if (MessageBox.Show("Bạn có chắc muốn xoá " + idDel.Count + " nhóm người dùng?", "Xóa nhóm người dùng",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            foreach (int id in idDel)
            {
            Retry:
                string error = Convert.ToString(BUSNhomNguoiDung.Instance.DelNhomNguoiDung(id));
                if (error != "")
                {
                    if (MessageBox.Show(error, "Lỗi", MessageBoxButtons.RetryCancel,
                        MessageBoxIcon.Error) == DialogResult.Retry)
                        goto Retry;
                    else continue;
                }
                else cnt++;
            }

            MessageBox.Show("Đã xoá thành công " + cnt + " nhóm người dùng", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            Bind();
        }
    }
}
