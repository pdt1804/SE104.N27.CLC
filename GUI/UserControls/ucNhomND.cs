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

        }
        private void Bind()
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
    }
}
