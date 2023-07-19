using BUS;
using GUI.Print;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fInfoPhieuNhap : Form
    {
        private P_PhieuNhap report;
        private static int id;
        public fInfoPhieuNhap(int _id)
        {
            InitializeComponent();
            id = _id;
            Bind();
        }

        private void Bind()
        {
            var phieu = BUSPhieuNhapSach.Instance.GetPhieuNhap(id);
            var dsct = phieu.CT_PHIEUNHAP.ToList();
            labelNgayNhap.Text = phieu.NgayNhap.ToShortDateString();
            labelSoPhieu.Text = phieu.SoPhieuNhap.ToString();
            labelTongTien.Text = phieu.TongTien.ToString();
            foreach (var ct in dsct)
            {
                dataGrid.Rows.Add(ct.SACH.MaSach, ct.SACH.TUASACH.TenTuaSach, ct.SACH.DonGia, ct.SoLuongNhap, ct.ThanhTien);
            }
        }

        private void butPrint_Click(object sender, EventArgs e)
        {
            report = new P_PhieuNhap(dataGrid, labelSoPhieu, labelNgayNhap, labelTongTien, 0);
            report.PrintReport();           
        }
    }
}
