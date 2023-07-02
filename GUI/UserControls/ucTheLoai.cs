using BUS;
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
    public partial class ucTheLoai : UserControl
    {
        public ucTheLoai()
        {
            InitializeComponent();
            Binding(BUSTheLoai.Instance.GetAllTheLoai());
        }

        public void Binding(List<THELOAI> TheLoaiList)
        {
            TheLoaiGrid.Rows.Clear();
            int index = 0;
            foreach (THELOAI p in TheLoaiList)
            {
                index = 0;
                foreach (var k in BUSTuaSach.Instance.GetAllTuaSach())
                {
                    if (k.THELOAI.id.Equals(p.id))
                    {
                        index++;
                    }    
                }    
                TheLoaiGrid.Rows.Add(p.id, p.MaTheLoai, p.TenTheLoai, index);
            }

        }

        private void butRefresh_Click(object sender, EventArgs e)
        {
            txtTenTL.Text = "";
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            var f = new fEditTheLoai();
            f.ShowDialog();

        }

        private void butRefresh_Click_1(object sender, EventArgs e)
        {
            txtTenTL.Text = "";
        }

        private void butAdd_Click_1(object sender, EventArgs e)
        {
            var f = new fEditTheLoai();
            f.ShowDialog();
            Binding(BUSTheLoai.Instance.GetAllTheLoai());
        }
    }
}
