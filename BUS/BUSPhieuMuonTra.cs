using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Windows.Forms;

namespace BUS
{
    public class BUSPhieuMuonTra
    {
        private static BUSPhieuMuonTra instance;

        public static BUSPhieuMuonTra Instance
        {
            get { if (instance == null) instance = new BUSPhieuMuonTra(); return instance; }
            set { instance = value; }
        }


        public List<PHIEUMUONTRA> GetAllPhieuMuonTra()
        {
            return DALPhieuMuonTra.Instance.GetAllPhieuMuonTra();
        }

        public PHIEUMUONTRA GetPhieuMuonTraById(int id)
        {
            PHIEUMUONTRA phieuMuonTra = DALPhieuMuonTra.Instance.GetPhieuMuonTraById(id);
            if (phieuMuonTra == null) return null;
            else return phieuMuonTra;
        }

        public List<PHIEUMUONTRA> FindTheoNgayMuon(int? ngay, int? thang, int? nam)
        {
            return DALPhieuMuonTra.Instance.FindTheoNgayMuon(ngay, thang, nam);
        }


        public List<PHIEUMUONTRA> FindTheoNgayTra(int? ngay, int? thang, int? nam)
        {
            return DALPhieuMuonTra.Instance.FindTheoNgayTra(ngay, thang, nam);
        }
        public List<PHIEUMUONTRA> FindPhieuMuonTre(DateTime today)
        {
            return DALPhieuMuonTra.Instance.FindPhieuMuonTre(today);
        }

        public List<PHIEUMUONTRA> FindPhieuMuonTre(List<PHIEUMUONTRA> ds, DateTime today)
        {
            return DALPhieuMuonTra.Instance.FindPhieuMuonTre(ds, today);
        }

        public List<PHIEUMUONTRA> FindPhieuMuonByDocGia(int idDocGia)
        {
            return DALPhieuMuonTra.Instance.FindPhieuMuonByDocGia(idDocGia);
        }
        public string AddPhieuMuonTra(string MaCuonSach, string MaDocGia, DateTime NgayMuon)
        {
            CUONSACH cs;
            DOCGIA dg;
            if (NgayMuon > DateTime.Now) return "Ngày mượn không hợp lệ.";
            cs = DALCuonSach.Instance.GetCuonSachByMa(MaCuonSach);
            if (cs == null)
            {
                return "Thông tin sách không hợp lệ";
            }
            dg = DALDocGia.Instance.GetDocGiaByMa(MaDocGia);
            if (dg == null)
            {
                return "Thông tin độc giả không hợp lệ";
            }

            THAMSO thamso = DALThamSo.Instance.GetAllThamSo();
            //System.TimeSpan duration = new System.TimeSpan(thamso.ThoiHanMuonSach, 0, 0, 0);
            DateTime HanTra = NgayMuon.AddDays((int)thamso.SoNgayMuonToiDa);
            if (NgayMuon > dg.NgayHetHan)
                return "Thẻ đã hết hạn";
            if (NgayMuon < dg.NgayLapThe)
                return "Ngày mượn nhỏ hơn ngày lập thẻ!";
            if (cs.TinhTrang == 0) return "Cuốn sách đã được mượn!";
            int cnt = 0;

            foreach (PHIEUMUONTRA pmt in dg.PHIEUMUONTRAs)
            {
                if (pmt.NgayTra == null && NgayMuon > pmt.HanTra)
                    return "Độc giả đang có sách mượn trễ.";
                if (pmt.NgayTra == null) cnt++;
            }
            if (thamso.SoSachMuonToiDa <= cnt)
                return "Đã vượt quá số sách được mượn";
            if (DALPhieuMuonTra.Instance.AddPhieuMuonTra(dg.ID, cs.id, NgayMuon, HanTra))
                return "";
            return "Không thể thêm phiếu mượn.";
        }

        public string UpdPhieuMuonTra(int MaPhieuMuon, DateTime NgayTra)
        {
            PHIEUMUONTRA pm;
            pm = DALPhieuMuonTra.Instance.GetPhieuMuonTraById(MaPhieuMuon);
            if (pm == null)
            {
                return "Số phiếu mượn không hợp lệ";
            }
            if (pm.NgayTra != null)
            {
                return "Phiếu mượn đã được trả";
            }
            if (NgayTra > DateTime.Now)
                return "Ngày trả không hợp lệ.";
            int SoNgayTraTre = ((TimeSpan)(NgayTra - pm.HanTra)).Days;
            THAMSO ts = DALThamSo.Instance.GetAllThamSo();
            int TienPhat = 0;
            if (NgayTra > pm.HanTra)
                TienPhat = (SoNgayTraTre * (int)ts.DonGiaPhat);
            if (DALPhieuMuonTra.Instance.UpdPhieuMuonTra(MaPhieuMuon, pm.NgayMuon, pm.HanTra, DateTime.Now, TienPhat))
                return "";
            return "Lỗi không thể cập nhật phiếu mượn.";
        }

        public bool DelPhieuMuonTra(int soPhieu)
        {
            if (!DALPhieuMuonTra.Instance.DelPhieuMuonTra(soPhieu))
            {
                MessageBox.Show("Xoá phiếu không thành công");
                return false;
            }
            return true;
        }
    }
}
