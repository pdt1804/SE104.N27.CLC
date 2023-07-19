using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Print
{
    public class P_PhieuThu
    {
        private int idPT;
        private string maDG;
        private string tenDG;
        private string noHT;
        private string soTT;
        private string noMoi;
        private string ngaythu;
        public P_PhieuThu(int idPT, string maDG, string tenDG, string noHT, string soTT, string noMoi, string ngaythu)
        {
            this.idPT = idPT;
            this.maDG = maDG;
            this.tenDG = tenDG;
            this.noHT = noHT;
            this.soTT = soTT;
            this.noMoi = noMoi;
            this.ngaythu = ngaythu;
        }

        public void PrintReport()
        {
            PrintDocument printPN = new PrintDocument();
            printPN.PrintPage += new PrintPageEventHandler(printPN_PrintPage);

            DialogResult _result = MessageBox.Show("Bạn muốn xuất phiếu thu ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (_result == DialogResult.Yes)
            {
                PrintPreviewDialog printPreviewDialogPN = new PrintPreviewDialog();
                printPreviewDialogPN.Document = printPN;
                printPreviewDialogPN.ShowDialog();
            }
        }

        private void printPN_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("PHIẾU THU", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(350, 100));
            e.Graphics.DrawString("Thời gian báo cáo : " + ngaythu, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(90, 170));
            e.Graphics.DrawString("Mã phiếu thu: " + idPT.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(90, 220));
            e.Graphics.DrawString("Mã độc giả: " + maDG, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(90, 270));
            e.Graphics.DrawString("Tên độc giả: " + tenDG, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(90, 320));
            e.Graphics.DrawString("Tổng nợ hiện tại: " + noHT, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(90, 370));
            e.Graphics.DrawString("Số tiền thu: " + soTT, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(90, 420));
            e.Graphics.DrawString("Tổng nợ mới: " + noMoi, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(90, 470));
            string date = "..., ngày " + DateTime.Now.Day + ", tháng " + DateTime.Now.Month + ", năm " + DateTime.Now.Year;
            e.Graphics.DrawString(date, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(480, 550));
            e.Graphics.DrawString("Người lập phiếu", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(535, 580));
            e.Graphics.DrawString("Người được thu", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(120, 580));
        }
    }
}
