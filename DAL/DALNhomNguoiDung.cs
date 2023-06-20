using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALNhomNguoiDung
    {
        private static DALNhomNguoiDung instance;

        public static DALNhomNguoiDung Instance
        {
            get
            {
                if (instance == null) instance = new DALNhomNguoiDung();
                return instance;
            }
            set => instance = value;
        }

        public List<NHOMNGUOIDUNG> GetAllNhomNguoiDung()
        {
            return QLTVEntities.Instance.NHOMNGUOIDUNGs.AsNoTracking().ToList();
        }

        public NHOMNGUOIDUNG GetNhomNguoiDungById(int id)
        {
            return QLTVEntities.Instance.NHOMNGUOIDUNGs.Find(id);
        }

        public NHOMNGUOIDUNG GetNhomNguoiDungByMa(string ma)
        {
            var res = QLTVEntities.Instance.NHOMNGUOIDUNGs.AsNoTracking().Where(n => n.MaNhomNguoiDung == ma);
            return (res.Any() ? res.First() : null);
        }

        public int AddNhomNguoiDung(string tenNhom)
        {
            try
            {
                var nhom = new NHOMNGUOIDUNG
                {
                    TenNhomNguoiDung = tenNhom
                };
                QLTVEntities.Instance.NHOMNGUOIDUNGs.Add(nhom);
                QLTVEntities.Instance.SaveChanges();
                return nhom.id;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return -1;
            }
        }

        public bool UpdNhomNguoiDung(int id, string tenNhom)
        {
            try
            {
                var nhom = GetNhomNguoiDungById(id);
                if (nhom == null) return false;
                nhom.TenNhomNguoiDung = tenNhom;
                QLTVEntities.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }
        public bool DelNhomNguoiDung(int id)
        {
            try
            {
                var nhom = GetNhomNguoiDungById(id);
                if (nhom == null) return false;
                QLTVEntities.Instance.NHOMNGUOIDUNGs.Remove(nhom);
                QLTVEntities.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }
        public bool AddChucNangNhom(int id, List<CHUCNANG> dsChucNang)
        {
            try
            {
                var nhom = GetNhomNguoiDungById(id);
                if (nhom == null) return false;
                nhom.CHUCNANGs.Clear();
                nhom.CHUCNANGs = dsChucNang;
                QLTVEntities.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }

        public bool DelChucNangNhom(int id, List<CHUCNANG> dsChucNang)
        {
            try
            {
                var nhom = GetNhomNguoiDungById(id);
                if (nhom == null) return false;
                foreach (var cn in dsChucNang)
                {
                    if (!nhom.CHUCNANGs.Contains(cn)) nhom.CHUCNANGs.Remove(cn);
                }
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
