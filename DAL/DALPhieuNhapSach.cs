using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALPhieuNhapSach
    {
        private static DALPhieuNhapSach instance;

        public static DALPhieuNhapSach Instance
        {
            get
            {
                if (instance == null) instance = new DALPhieuNhapSach();
                return instance;
            }
            set => instance = value;
        }

        public List<PHIEUNHAPSACH> GetAllPhieuNhapSach()
        {
            return QLTVEntities.Instance.PHIEUNHAPSACHes.AsNoTracking().ToList();
        }

        public PHIEUNHAPSACH GetPhieuById(int id)
        {
            return QLTVEntities.Instance.PHIEUNHAPSACHes.Find(id);
        }

        public List<PHIEUNHAPSACH> GetPhieuByNgayNhap(DateTime ngayNhap)
        {
            var res = QLTVEntities.Instance.PHIEUNHAPSACHes.AsNoTracking().Where(p => p.NgayNhap == ngayNhap);
            return (res.Any() ? res.ToList() : null);
        }

        public List<PHIEUNHAPSACH> FindPhieuByNgayNhap(int? ngay, int? thang, int? nam)
        {
            List<PHIEUNHAPSACH> res = GetAllPhieuNhapSach();
            if (ngay != null) res = res.Where(p => p.NgayNhap.Day == ngay).ToList();
            if (thang != null) res = res.Where(p => p.NgayNhap.Month == thang).ToList();
            if (nam != null) res = res.Where(p => p.NgayNhap.Year == nam).ToList();
            return res;
        }

        public int AddPhieuNhap(DateTime ngayNhap)
        {
            try
            {
                var phieu = new PHIEUNHAPSACH
                {
                    NgayNhap = ngayNhap,
                    TongTien = 0
                };

                QLTVEntities.Instance.PHIEUNHAPSACHes.Add(phieu);
                QLTVEntities.Instance.SaveChanges();
                return phieu.SoPhieuNhap;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return -1;
            }
        }

        public bool UpdPhieuNhap(int id, DateTime? ngayNhap, int? tongTien)
        {
            try
            {
                PHIEUNHAPSACH phieu = QLTVEntities.Instance.PHIEUNHAPSACHes.Find(id);
                if (phieu == null) return false;
                if (ngayNhap != null) phieu.NgayNhap = ngayNhap.Value;
                if (tongTien != null) phieu.TongTien = tongTien.Value;
                QLTVEntities.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }

        public bool DelPhieuNhap(int id)
        {
            try
            {
                PHIEUNHAPSACH phieu = QLTVEntities.Instance.PHIEUNHAPSACHes.Find(id);
                if (phieu == null) return false;
                QLTVEntities.Instance.PHIEUNHAPSACHes.Remove(phieu);
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
