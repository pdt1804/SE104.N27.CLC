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
            e.Graphics.DrawString("BÁO CÁO SÁCH TRẢ TRỄ", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(300, 100));
            e.Graphics.DrawString("Thời gian báo cáo: " + labelBC.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(80, 170));

            e.Graphics.DrawString("Số thứ tự", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(80, 250));
            e.Graphics.DrawString("Mã cuốn sách", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(200, 250));
            e.Graphics.DrawString("Tên tựa sách", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(430, 250));
            e.Graphics.DrawString("Ngày mượn", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(550, 250));
            e.Graphics.DrawString("Số ngày trễ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(670, 250));
            int x = 300;
            for (int i = 0; i < dataGrid.Rows.Count; i++)
            {
                e.Graphics.DrawString(dataGrid.Rows[i].Cells[0].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(105, x));
                string tentuasach = dataGrid.Rows[i].Cells[1].Value.ToString();
                if (tentuasach.Length > 30)
                {
                    tentuasach = tentuasach.Substring(0, 30) + "...";
                }
                e.Graphics.DrawString(dataGrid.Rows[i].Cells[1].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(200, x));
                e.Graphics.DrawString(tentuasach, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(430, x));
                e.Graphics.DrawString(dataGrid.Rows[i].Cells[3].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(550, x));
                e.Graphics.DrawString(dataGrid.Rows[i].Cells[4].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(695, x));
                x += 40;
            }
        }
    }
}
