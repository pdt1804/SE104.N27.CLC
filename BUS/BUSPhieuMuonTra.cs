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
        public bool AddPhieuMuonTra(int idDocGia, int idCuonSach, DateTime ngayMuon, DateTime hanTra)
        {
            if (!DALPhieuMuonTra.Instance.AddPhieuMuonTra(idDocGia, idCuonSach, ngayMuon, hanTra))
            {
                MessageBox.Show("Thêm phiếu không thành công");
                return false;
            }    
            else
            {
                MessageBox.Show("Thêm phiếu thành công");
                return true;
            }    
        }

        public bool UpdPhieuMuonTra(int soPhieu, DateTime? ngayMuon, DateTime? hanTra, DateTime? ngayTra, int? soTienPhat)
        {
            if (!DALPhieuMuonTra.Instance.UpdPhieuMuonTra(soPhieu, ngayMuon, hanTra, ngayTra, soTienPhat))
            {
                MessageBox.Show("Cập nhật thông tin phiếu không thành công");
                return false;
            }
            return true;
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
