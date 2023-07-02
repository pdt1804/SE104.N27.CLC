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
using DTO;
using GUI;
namespace GUI.UserControls
{
    public partial class ucTacGia : UserControl
    {
        List<TACGIA> TacGiaList;
        public ucTacGia()
        {
            InitializeComponent();
            Binding();
        }
        public void Binding()
        {
            TacGiaList = BUSTacGia.Instance.GetAllTacGia();
            TacGiaGrid.DataSource = TacGiaList;
        }
        private void butAdd_Click(object sender, EventArgs e)
        {
            fEditTacGia f = new fEditTacGia();
            f.ShowDialog();
            Binding();
        }


        private void butRefresh_Click(object sender, EventArgs e)
        {
            txtHoTen.Text = "";
        }

        private void TacGiaGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx == -1) return;
            var f = new fEditTacGia (Convert.ToInt32(TacGiaGrid.Rows[idx].Cells["id"].Value));
            f.ShowDialog();
            Binding();

        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtHoTen.Text))
            {
                Binding();
            }    
            else
            {
                List<TACGIA> listTacGia = new List<TACGIA>();
                foreach (var p in BUSTacGia.Instance.GetAllTacGia())
                {
                    if (p.TenTacGia.ToLower().Contains(txtHoTen.Text.ToLower()))
                    {
                        listTacGia.Add(p);
                    }    
                }
                TacGiaGrid.DataSource = listTacGia;
            }    
        }

        private void TacGiaGrid_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx < 0) return;
            if (e.ColumnIndex == 0) return;
            //if (e.ColumnIndex == SachGrid.Columns["Edit"].Index)
            //{
            //    var f = new fAddSachMoi((Convert.ToInt32(SachGrid.Rows[idx].Cells["id"].Value)))
            //    f.ShowDialog();
            //    return;
            //}
            var fInfor = new fEditTacGia(Convert.ToInt32(TacGiaGrid.Rows[idx].Cells["id"].Value));
            fInfor.ShowDialog();
            Binding();
            txtHoTen.Text = "";
        }
    }
}
