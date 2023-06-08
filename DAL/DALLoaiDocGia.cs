using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALLoaiDocGia
    {
        private static DALLoaiDocGia instance;

        public static DALLoaiDocGia Instance
        {
            get
            {
                if (instance == null) instance = new DALLoaiDocGia();
                return instance;
            }
            set => instance = value;
        }
        public List<LOAIDOCGIA> GetAllLoaiDocGia()
        {
            return QLTVEntities.Instance.LOAIDOCGIAs.AsNoTracking().ToList();
        }
        public LOAIDOCGIA GetLoaiDocGiaById(int id)
        {
            return QLTVEntities.Instance.LOAIDOCGIAs.Find(id);
        }
        public bool AddLoaiDocGia(string tenLoaiDocGia)
        {
            try
            {
                LOAIDOCGIA obj = new LOAIDOCGIA { TenLoaiDocGia = tenLoaiDocGia };
                QLTVEntities.Instance.LOAIDOCGIAs.Add(obj);
                QLTVEntities.Instance.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdLoaiDocGia(int id, string tenLoaiDocGia)
        {
            try
            {
                LOAIDOCGIA ldg = GetLoaiDocGiaById(id);
                if (ldg == null) return false;
                if (tenLoaiDocGia != null) ldg.TenLoaiDocGia = tenLoaiDocGia;
                QLTVEntities.Instance.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DelLoaiDocGia(int id)
        {
            try
            {
                LOAIDOCGIA ldg = GetLoaiDocGiaById(id);
                if (ldg == null) return false;
                QLTVEntities.Instance.LOAIDOCGIAs.Remove(ldg);
                QLTVEntities.Instance.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
