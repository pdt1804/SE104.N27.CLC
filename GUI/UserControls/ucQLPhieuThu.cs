using BUS;
using DTO;
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
    public partial class ucQLPhieuThu : UserControl
    {
        List<PHIEUTHU> PhieuThuList;
        public ucQLPhieuThu()
        {
            InitializeComponent();
            Binding(BUSPhieuThu.Instance.GetAllPhieuThu());
        }
        public void Binding(List<PHIEUTHU> PhieuThuList)
        {
            PhieuThuGrid.Rows.Clear();
            foreach(PHIEUTHU pt in PhieuThuList)
            {
                PhieuThuGrid.Rows.Add(pt.SoPhieuThu, pt.DOCGIA.MaDocGia, pt.SoTienThu, ((DateTime)pt.NgayLap).ToShortDateString());
            }
        }
    }
}
