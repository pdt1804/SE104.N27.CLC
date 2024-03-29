﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Print
{
    public class P_PhieuNhap
    {
        private int rowIndex = 0;
        private int x = 80;
        private int add;
        private DataGridView dataGrid;
        private Label labelSoPhieu;
        private Label labelNgayNhap;
        private Label labelTongTien;
        public P_PhieuNhap(DataGridView dataGrid, Label labelSoPhieu, Label labelNgayNhap, Label labelTongTien, int add)
        {
            this.add = add;
            this.dataGrid = dataGrid;
            this.labelSoPhieu = labelSoPhieu;
            this.labelNgayNhap = labelNgayNhap;
            this.labelTongTien = labelTongTien;
        }
        
        public void PrintReport()
        {
            PrintDocument printPN = new PrintDocument();
            printPN.PrintPage += new PrintPageEventHandler(printPN_PrintPage);

            DialogResult _result = MessageBox.Show("Bạn muốn xuất phiếu nhập ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                e.Graphics.DrawString("PHIẾU NHẬP", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(350, 80));
                e.Graphics.DrawString("Số phiếu nhập: " + labelSoPhieu.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(80, 150));
                e.Graphics.DrawString("Ngày nhập: " + labelNgayNhap.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(80, 180));
                e.Graphics.DrawString("Tổng tiền: " + labelTongTien.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(80, 210));

                e.Graphics.DrawString("Mã sách", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(80, 310));
                e.Graphics.DrawString("Tên tựa sách", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(200, 310));
                e.Graphics.DrawString("Đơn giá", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(430, 310));
                e.Graphics.DrawString("Số lượng", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(550, 310));
                e.Graphics.DrawString("Thành tiền", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(670, 310));
                x = 360;
            }
            while(rowIndex < rowCount)
            {
                DataGridViewRow row = dataGrid.Rows[rowIndex];
                e.Graphics.DrawString(row.Cells[0 + add].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(80, x));
                string tentuasach = row.Cells[1 + add].Value.ToString();
                if (tentuasach.Length > 30)
                {
                    tentuasach = tentuasach.Substring(0, 30) + "...";
                }
                e.Graphics.DrawString(tentuasach, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(200, x));
                e.Graphics.DrawString(row.Cells[2 + add].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(430, x));           
                e.Graphics.DrawString(row.Cells[3 + add].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(550, x));
                e.Graphics.DrawString(row.Cells[4 + add].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(670, x));
                x += 40;
                rowIndex++;
                if (rowsPerPage - x <= 100 && rowCount > rowIndex)
                {
                    x = 80;
                    e.HasMorePages = true;
                    return;
                }
            }
           
            string date = "..., ngày " + DateTime.Now.Day + ", tháng " + DateTime.Now.Month + ", năm " + DateTime.Now.Year;
            e.Graphics.DrawString(date, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(480, x));
            e.Graphics.DrawString("Người lập phiếu", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(535, x + 40));
        }
    }
}
