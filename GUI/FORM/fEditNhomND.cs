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
    public partial class fEditNhomND : Form
    {
        private static int id;
        public fEditNhomND(int _id)
        {
            InitializeComponent();
            id = _id;
            Bind();
        }
        private void Bind()
        {
            var nnd = BUSNhomNguoiDung.Instance.GetNhomNguoiDungById(id);
            labelMaNND.Text += nnd.MaNhomNguoiDung;
            txtTenNhom.Text = nnd.TenNhomNguoiDung;
            var dscn = BUSChucNang.Instance.GetAllChucNang();

            foreach (var cn in dscn)
            {
                if (nnd.CHUCNANGs.Contains(cn))
                {
                    dsChucNang.Rows.Add("1", cn.id, cn.MaChucNang, cn.TenChucNang, cn.TenManHinh);
                }
                else
                    dsChucNang.Rows.Add("0", cn.id, cn.MaChucNang, cn.TenChucNang, cn.TenManHinh);
            }
        }
    }
}
