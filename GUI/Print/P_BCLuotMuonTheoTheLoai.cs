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
    public class P_BCLuotMuonTheoTheLoai
    {
        private int rowIndex = 0;
        private int x = 80;
        private DataGridView dataGrid;
        private Label labelMaBC;
        private Label labelDate;
        private Label labelTongLuotMuon;

        public P_BCLuotMuonTheoTheLoai(DataGridView dataGrid, Label labelMaBC, Label labelDate, Label labelTongLuotMuon)
        {
            this.dataGrid = dataGrid;
            this.labelMaBC = labelMaBC;
            this.labelDate = labelDate;
            this.labelTongLuotMuon = labelTongLuotMuon;
        }

        public void PrintReport()
        {
            PrintDocument printPN = new PrintDocument();
            printPN.PrintPage += new PrintPageEventHandler(printPN_PrintPage);

            DialogResult _result = MessageBox.Show("Bạn muốn xuất báo cáo ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (_result == DialogResult.Yes)
            {
                PrintPreviewDialog printPreviewDialogPN = new PrintPreviewDialog();
                printPreviewDialogPN.Document = printPN;
                printPreviewDialogPN.ShowDialog();
            }
        }

        private void printPN_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            PrintDocument printDoc = new PrintDocument();
            PaperSize paperSize = printDoc.DefaultPageSettings.PaperSize;
            int rowsPerPage = paperSize.Height;
            int rowCount = dataGrid.Rows.Count;
            if(rowIndex == 0)
            {
                e.Graphics.DrawString("BÁO CÁO LƯỢT MƯỢN THEO THỂ LOẠI", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(210, 80));
                e.Graphics.DrawString("Mã báo cáo: " + labelMaBC.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(80, 150));
                e.Graphics.DrawString("Ngày báo cáo: " + labelDate.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(80, 180));
                e.Graphics.DrawString("Tổng lượt mượn: " + labelTongLuotMuon.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(80, 210));

                e.Graphics.DrawString("Mã Thể Loại", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(80, 310));
                e.Graphics.DrawString("Tên Thể Loại", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(200, 310));
                e.Graphics.DrawString("Tổng Số Lượt Mượn", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(430, 310));
                e.Graphics.DrawString("Tỉ Lệ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(650, 310));
                x = 360;
            }
            while( rowIndex < rowCount)
            {
                DataGridViewRow row = dataGrid.Rows[rowIndex];
                e.Graphics.DrawString(row.Cells[0].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(80, x));
                string tenTheLoai = row.Cells[1].Value.ToString();
                if (tenTheLoai.Length > 30)
                {
                    tenTheLoai = tenTheLoai.Substring(0, 30) + "...";
                }
                e.Graphics.DrawString(tenTheLoai, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(200, x));
                e.Graphics.DrawString(row.Cells[2].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(460, x));
                e.Graphics.DrawString(row.Cells[3].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(650, x));
                x += 40;
                rowIndex++;
                if (rowsPerPage - x <= 100 && rowCount > rowIndex)
                {
                    x = 80;
                    e.HasMorePages = true;
                    return;
                }
            }
            e.HasMorePages = false;

            rowIndex = 0;

            string date = "..., ngày " + DateTime.Now.Day + ", tháng " + DateTime.Now.Month + ", năm " + DateTime.Now.Year;
            e.Graphics.DrawString(date, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(480, x));
            e.Graphics.DrawString("Người lập phiếu", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(535, x + 40));
        }
    }
}
