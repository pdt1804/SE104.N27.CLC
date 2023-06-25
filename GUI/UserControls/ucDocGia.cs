using DTO;
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
    public partial class ucDocGia : UserControl
    {
        public ucDocGia()
        {
            InitializeComponent();
            LoadDocGia();
        }

        private void LoadDocGia()
        {
            List<DOCGIA> list = new List<DOCGIA>();
            DocGiaGrid.DataSource = list;
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            var fAdddg = new fAddDocGia();
            fAdddg.BringToFront();
            fAdddg.ShowDialog();
            LoadDocGia();
        }
    }
}
