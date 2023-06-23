using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALPhieuMuonTra
    {
        private static DALPhieuMuonTra instance;

        public static DALPhieuMuonTra Instance
        {
            get
            {
                if (instance == null) instance = new DALPhieuMuonTra();
                return instance;
            }
            set => instance = value;
        }

        public List<PHIEUMUONTRA> GetAllPhieuMuonTra()
        {
            return QLTVEntities.Instance.PHIEUMUONTRAs.AsNoTracking().ToList();
        }

        public PHIEUMUONTRA GetPhieuMuonTraById(int id)
        {
            return QLTVEntities.Instance.PHIEUMUONTRAs.Find(id);
        }

        public List<PHIEUMUONTRA> FindTheoNgayMuon(int? ngay, int? thang, int? nam)
        {
            List<PHIEUMUONTRA> res = GetAllPhieuMuonTra();
            if (ngay != null) res = res.Where(p => p.NgayMuon.Day == ngay).ToList();
            if (thang != null) res = res.Where(p => p.NgayMuon.Month == thang).ToList();
            if (nam != null) res = res.Where(p => p.NgayMuon.Year == nam).ToList();
            return res;

        }


        public List<PHIEUMUONTRA> FindTheoNgayTra(int? ngay, int? thang, int? nam)
        {
            List<PHIEUMUONTRA> res = GetAllPhieuMuonTra();
            if (ngay != null) res = res.Where(p => p.NgayTra.Value.Day == ngay).ToList();
            if (thang != null) res = res.Where(p => p.NgayTra.Value.Month == thang).ToList();
            if (nam != null) res = res.Where(p => p.NgayTra.Value.Year == nam).ToList();
            return res;
        }
        public List<PHIEUMUONTRA> FindPhieuMuonTre(DateTime today)
        {
            return QLTVEntities.Instance.PHIEUMUONTRAs.AsNoTracking().Where(p => p.NgayTra == null && p.HanTra < today).ToList();
        }

        public List<PHIEUMUONTRA> FindPhieuMuonTre(List<PHIEUMUONTRA> ds, DateTime today)
        {
            return ds.Where(p => p.NgayTra == null && p.HanTra < today).ToList();
        }

        public List<PHIEUMUONTRA> FindPhieuMuonByDocGia(int idDocGia)
        {
            return QLTVEntities.Instance.PHIEUMUONTRAs.AsNoTracking().Where(p => p.idDocGia == idDocGia).ToList();
        }
        public bool AddPhieuMuonTra(int idDocGia, int idCuonSach, DateTime ngayMuon, DateTime hanTra)
        {
            try
            {
                var phieu = new PHIEUMUONTRA
                {
                    idDocGia = idDocGia,
                    DOCGIA = DALDocGia.Instance.GetDocGiaById(idDocGia),
                    idCuonSach = idCuonSach,
                    CUONSACH = DALCuonSach.Instance.GetCuonSachById(idCuonSach),
                    NgayMuon = ngayMuon,
                    HanTra = hanTra
                };
                DALCuonSach.Instance.UpdCuonSach(idCuonSach, 0);
                QLTVEntities.Instance.PHIEUMUONTRAs.Add(phieu);
                QLTVEntities.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }

        public bool UpdPhieuMuonTra(int soPhieu, DateTime? ngayMuon, DateTime? hanTra, DateTime? ngayTra, int? soTienPhat)
        {
            try
            {
                var phieu = GetPhieuMuonTraById(soPhieu);
                if (phieu == null) return false;
                if (ngayMuon != null) phieu.NgayMuon = ngayMuon.Value;
                if (hanTra != null) phieu.HanTra = hanTra.Value;
                if (ngayTra != null)
                {
                    phieu.NgayTra = ngayTra;
                    DALCuonSach.Instance.UpdCuonSach((int)phieu.idCuonSach, 1);
                }
                if (soTienPhat != null) phieu.SoTienPhat = soTienPhat;
                QLTVEntities.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }

        public bool DelPhieuMuonTra(int soPhieu)
        {
            try
            {
                var phieu = GetPhieuMuonTraById(soPhieu);
                if (phieu == null) return false;
                QLTVEntities.Instance.PHIEUMUONTRAs.Remove(phieu);
                QLTVEntities.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }
    }
}

