using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace GUI.FORM
{
    public partial class fAddLoaiDG : Form
    {
        public fAddLoaiDG()
        {
            InitializeComponent();
        }

        private void controlPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void butOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (BUSLoaiDocGia.Instance.AddLoaiDocGia(txtTenLoai.Text.ToString()))
                {
                    MessageBox.Show("Thêm thành công loại độc giả");
                }
                else
                {
                    MessageBox.Show("Thêm không thành công loại độc giả");
                }
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập tên loại độc giả");
            }
        }
    }
}
