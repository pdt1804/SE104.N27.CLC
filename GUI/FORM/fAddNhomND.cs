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
    }
}
