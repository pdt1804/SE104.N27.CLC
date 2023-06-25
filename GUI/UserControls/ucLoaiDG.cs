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
using BUS;
namespace GUI.UserControls
{
    public partial class ucLoaiDG : UserControl
    {
        public ucLoaiDG()
        {
            InitializeComponent();
            LoadLoaiDocGia();
        }

        public void LoadLoaiDocGia()
        {
            List<LOAIDOCGIA> list = BUSLoaiDocGia.Instance.GetAllLoaiDocGia();
            LoaiDocGiaGrid.DataSource = list;
        }

        public void GetLoaiDocGiaByTenLoaiDocGia()
        {
            string ten = txtTenLoaiDG.Text;
            if (String.IsNullOrEmpty(ten))
            {
                LoadLoaiDocGia();
            }
            else
            {
                List<LOAIDOCGIA> list = BUSLoaiDocGia.Instance.GetLoaiDocGiaByTen(ten);
                LoaiDocGiaGrid.DataSource = list;
            }    
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            var fAddLoaidg = new fAddLoaiDG();
            fAddLoaidg.BringToFront();
            fAddLoaidg.ShowDialog();
            LoadLoaiDocGia();
        }

        private void txtTenLoaiDG_TextChanged(object sender, EventArgs e)
        {
            GetLoaiDocGiaByTenLoaiDocGia();
        }

        private void butRefresh_Click(object sender, EventArgs e)
        {
            txtTenLoaiDG.Text = "";
        }
    }
}
