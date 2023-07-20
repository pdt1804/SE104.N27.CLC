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
    public class P_BCSachTraTre
    {
        private int rowIndex = 0;
        private int x = 80;
        private DataGridView dataGrid;
        private Label labelBC;
        public P_BCSachTraTre(DataGridView dataGrid, Label labelBC)
        {
            this.dataGrid = dataGrid;
            this.labelBC = labelBC;    
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
            if (rowIndex == 0)
            {
                e.Graphics.DrawString("BÁO CÁO SÁCH TRẢ TRỄ", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(300, 100));
                e.Graphics.DrawString("Thời gian báo cáo: " + labelBC.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(80, 170));
                e.Graphics.DrawString("Số thứ tự", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(80, 250));
                e.Graphics.DrawString("Mã cuốn sách", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(200, 250));
                e.Graphics.DrawString("Tên tựa sách", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(350, 250));
                e.Graphics.DrawString("Ngày mượn", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(550, 250));
                e.Graphics.DrawString("Số ngày trễ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(670, 250));
                x = 300;
            }

            while (rowIndex < rowCount)
            {
                DataGridViewRow row = dataGrid.Rows[rowIndex];
                e.Graphics.DrawString(row.Cells[0].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(105, x));
                string tentuasach = row.Cells[2].Value.ToString();
                if (tentuasach.Length > 30)
                {
                    tentuasach = tentuasach.Substring(0, 30) + "...";
                }
                e.Graphics.DrawString(row.Cells[1].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(200, x));
                e.Graphics.DrawString(tentuasach, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(350, x));
                e.Graphics.DrawString(row.Cells[3].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(550, x));
                e.Graphics.DrawString(row.Cells[4].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(695, x));
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
