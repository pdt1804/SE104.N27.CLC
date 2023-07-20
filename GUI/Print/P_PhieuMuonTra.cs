using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Print
{
    public class P_PhieuMuonTra
    {
        private CUONSACH cuonsach;
        private DOCGIA docgia;
        private string ngaymuon;
        private string ngaytra;
        private int sntt;
        private int dongiaphat;
        private int sotienphat;
        private string hantra;
        public P_PhieuMuonTra(int idCS, int idDG, string ngaymuon, string hantra, string ngaytra, int sntt, int dongiaphat, int sotienphat)
        {
            this.cuonsach = CuonSach(idCS);
            this.docgia = DocGia(idDG);
            this.ngaymuon = ngaymuon;
            this.ngaytra = ngaytra;
            this.sntt = sntt;
            this.dongiaphat = dongiaphat;
            this.sotienphat = sotienphat;
            this.hantra = hantra;
        }

        public P_PhieuMuonTra(PHIEUMUONTRA pmt, int sntt, int dongiaphat, int sotienphat) 
        { 
            this.cuonsach = pmt.CUONSACH;
            this.docgia = pmt.DOCGIA;
            this.ngaymuon = pmt.NgayMuon.ToShortDateString();
            this.hantra = pmt.HanTra.ToShortDateString();
            this.ngaytra = pmt.NgayTra.ToString();
            this.sntt = sntt;
            this.dongiaphat = dongiaphat;
            this.sotienphat = sotienphat;
        }

        private CUONSACH CuonSach(int idCS)
        {
            cuonsach = BUSCuonSach.Instance.GetCuonSachById(idCS);
            return cuonsach;
        }

        private DOCGIA DocGia(int idDG)
        {
            docgia = BUSDocGia.Instance.GetDocGiaById(idDG);
            return docgia;
        }

        public void PrintReport()
        {
            PrintDocument printPN = new PrintDocument();
            printPN.PrintPage += new PrintPageEventHandler(printPN_PrintPage);

            DialogResult _result = MessageBox.Show("Bạn muốn xuất phiếu mượn trả ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
            int height = paperSize.Height;
            int width = paperSize.Width;
            int _height = 200;
            int _width = 80;
            while (_height < height - 450)
            {
                e.Graphics.DrawString("|", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(width/2, _height));
                _height += 20;
            }
            while (_width < width - 80)
            {
                e.Graphics.DrawString("--", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(_width, 400));
                _width += 20;
            }
            e.Graphics.DrawString("PHIẾU MƯỢN TRẢ SÁCH", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(300, 100));
            string tencs = cuonsach.SACH.TUASACH.TenTuaSach;
            string theloai = cuonsach.SACH.TUASACH.THELOAI.TenTheLoai;
            string tendg = docgia.TenDocGia;
            string tinhtrang = "Đã trả sách";
            if (tencs.Length > 30)
            {
                tencs = tencs.Substring(0, 30) + "...";
            }
            if (theloai.Length > 30)
            {
                theloai = theloai.Substring(0, 30) + "...";
            }
            if(tendg.Length > 30)
            {
                tendg = tendg.Substring(0,30) + "...";
            }
            if(ngaytra == "" || ngaytra == null)
            {
                tinhtrang = "Chưa trả sách";
            }
            // Thông tin cuốn sách
            e.Graphics.DrawString("Thông tin cuốn sách", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(110, 200));
            e.Graphics.DrawString("Mã cuốn sách: " + cuonsach.MaCuonSach, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(80, 250));
            e.Graphics.DrawString("Tên cuốn sách: " + tencs, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(80, 300));
            e.Graphics.DrawString("Thể loại: " + theloai, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(80, 350));
            // Thông tin độc giả 
            e.Graphics.DrawString("Thông tin độc giả", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(width / 2 + 50, 200));
            e.Graphics.DrawString("Mã độc giả: " + docgia.MaDocGia, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(width / 2 + 30, 250));
            e.Graphics.DrawString("Tên độc giả: " + tendg, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(width / 2 + 30, 300));
            e.Graphics.DrawString("Tổng nợ hiện tại: " + docgia.TongNoHienTai.ToString() + " VND", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(width / 2 + 30, 350));

            // Thông tin ngày mượn trả
            e.Graphics.DrawString("Thông tin thời gian mượn trả", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(80, 450));
            e.Graphics.DrawString("Ngày mượn sách: " + ngaymuon, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(80, 500));
            e.Graphics.DrawString("Hạn trả sách: " + hantra, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(80, 550));
            e.Graphics.DrawString("Ngày trả sách: " + ngaytra, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(80, 600));
            e.Graphics.DrawString("Tình trạng phiếu: " + tinhtrang, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(80, 650));

            // Thông tin phiếu phạt
            e.Graphics.DrawString("Thông tin tiền phạt", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(width / 2 + 50, 450));
            e.Graphics.DrawString("Số ngày trả trễ: " + sntt.ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(width / 2 + 30, 500));
            e.Graphics.DrawString("Đơn giá phạt: " + dongiaphat.ToString() + " VND/ngay", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(width / 2 + 30, 550));
            e.Graphics.DrawString("Tổng tiền phạt: " + sotienphat.ToString() + " VND", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(width / 2 + 30, 600));

            // Ký tên
            string date = "..., ngày " + DateTime.Now.Day + ", tháng " + DateTime.Now.Month + ", năm " + DateTime.Now.Year;
            e.Graphics.DrawString(date, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(480, 780));
            e.Graphics.DrawString("Người lập phiếu", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(535, 810));
            e.Graphics.DrawString("Người mượn trả sách", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(110, 810));


        }
    }
}
