using BUS;
using GUI.Print;
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
    public partial class ucMuonTheoTheLoai : UserControl
    {
        private P_BCLuotMuonTheoTheLoai report;
        public ucMuonTheoTheLoai()
        {
            InitializeComponent();
            dateBC.Value = DateTime.Now;
        }

        private void Print(DataGridView dataGrid, string mabc, int month, int year, string tongluotmuon)
        {
            Label labelMaBC = new Label();
            Label labelDate = new Label();
            Label labelTongLuotMuon = new Label();
            labelMaBC.Text = mabc;
            labelTongLM.Text = tongluotmuon;
            string formattedDate = month + "/" + year;
            labelDate.Text = formattedDate;
            report = new P_BCLuotMuonTheoTheLoai(dataGrid, labelMaBC, labelDate, labelTongLuotMuon);
            report.PrintReport();
        }
        private void butAdd_Click(object sender, EventArgs e)
        {
            int month = dateBC.Value.Month;
            int year = dateBC.Value.Year;

            var bc = BUSBCLuotMuonTheoTheLoai.Instance.FindBaoCaoByDate(month, year);
            if (bc == null)
            {
                string err = BUSBCLuotMuonTheoTheLoai.Instance.AddBaoCao(month, year);
                if (err != "")
                {
                    MessageBox.Show(err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                bc = BUSBCLuotMuonTheoTheLoai.Instance.FindBaoCaoByDate(month, year);
            }
            labelTongLM.Text = "Tổng số lượt mượn: " + bc.TongSoLuotMuon.ToString();
            var ctbc = bc.CT_BCLUOTMUONTHEOTHELOAI;
            dataGrid.Rows.Clear();
            foreach (var c in ctbc)
            {
                dataGrid.Rows.Add(c.THELOAI.MaTheLoai, c.THELOAI.TenTheLoai, c.SoLuotMuon, c.TiLe);
            }
            Print(dataGrid, bc.MaBaoCao, month, year, labelTongLM.Text);
        }

        private void butDel_Click(object sender, EventArgs e)
        {
            int month = dateBC.Value.Month;
            int year = dateBC.Value.Year;

            var bc = BUSBCLuotMuonTheoTheLoai.Instance.FindBaoCaoByDate(month, year);
            if (bc == null)
            {
                MessageBox.Show("Chưa có báo cáo trong tháng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var res = MessageBox.Show("Bạn có chắc muốn xóa báo cáo của tháng" + month.ToString() + "/" + year.ToString() + "?",
                "Xóa báo cáo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) return;
            BUSBCLuotMuonTheoTheLoai.Instance.DelBC(bc.MaBaoCao);
            MessageBox.Show("Đã xóa báo cáo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGrid.Rows.Clear();
        }
    }
}
