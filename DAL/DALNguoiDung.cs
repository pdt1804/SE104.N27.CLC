using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class DALNguoiDung
    {
        private static DALNguoiDung instance;

        public static DALNguoiDung Instance
        {
            get
            {
                if (instance == null) instance = new DALNguoiDung();
                return instance;
            }
            set => instance = value;
        }

        public List<NGUOIDUNG> GetAllNguoiDung()
        {
            return QLTVEntities.Instance.NGUOIDUNGs.AsNoTracking().ToList();
        }

        public NGUOIDUNG GetNguoiDungById(int id)
        {
            return QLTVEntities.Instance.NGUOIDUNGs.Find(id);
        }

        public NGUOIDUNG GetNguoiDungByMa(string maNguoiDung)
        {
            var res = QLTVEntities.Instance.NGUOIDUNGs.AsNoTracking().Where(n => n.MaNguoiDung == maNguoiDung);
            if (res.Any())
                return res.FirstOrDefault();
            return null;
        }
        public NGUOIDUNG GetNguoiDungByUsername(string username)
        {
            var res = QLTVEntities.Instance.NGUOIDUNGs.AsNoTracking().Where(n => n.TenDangNhap == username);
            if (res.Any())
                return res.FirstOrDefault();
            return null;
        }
        public NGUOIDUNG GetNguoiDungByUsernameAndEmail(string username, string email)
        {
            var res = QLTVEntities.Instance.NGUOIDUNGs.AsNoTracking().Where(n => n.TenDangNhap == username && n.EMAIL == email);
            if (res.Any())
                return res.FirstOrDefault();
            return null;
        }
        public int AddNguoiDung(string tenNguoiDung, DateTime ngaySinh, string chucVu,
                                 string tenDangNhap, string matKhau, string email, int idNhomNguoiDung)
        {

            try
            {
                var nd = new NGUOIDUNG
                {
                    TenNguoiDung = tenNguoiDung,
                    NgaySinh = ngaySinh,
                    ChucVu = chucVu,
                    TenDangNhap = tenDangNhap,
                    MatKhau = matKhau,
                    EMAIL = email,
                    idNhomNguoiDung = idNhomNguoiDung,
                    NHOMNGUOIDUNG = DALNhomNguoiDung.Instance.GetNhomNguoiDungById(idNhomNguoiDung)
                };
                QLTVEntities.Instance.NGUOIDUNGs.Add(nd);
                QLTVEntities.Instance.SaveChanges();
                return nd.id;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.ToString());
                return -1;
            }
        }
        public bool UpdNguoiDung(int id, string tenNguoiDung, DateTime? ngaySinh, string chucVu, string email,
                                 int? idNhomNguoiDung)
        {
            try
            {
                var nd = GetNguoiDungById(id);
                if (nd == null) return false;

                if (tenNguoiDung != null) nd.TenNguoiDung = tenNguoiDung;
                if (ngaySinh != null) nd.NgaySinh = ngaySinh;
                if (chucVu != null) nd.ChucVu = chucVu;
                if (idNhomNguoiDung != null) nd.idNhomNguoiDung = (int)idNhomNguoiDung;
                if (email != null) nd.EMAIL = email;
                QLTVEntities.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }
        public bool DelNguoiDung(int id)
        {
            try
            {
                var nd = GetNguoiDungById(id);
                if (nd == null) return false;

                QLTVEntities.Instance.NGUOIDUNGs.Remove(nd);
                QLTVEntities.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }
        public bool UpdPassword(int id, string password)
        {
            try
            {
                var nd = GetNguoiDungById(id);
                if (nd == null) return false;

                nd.MatKhau = password;
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
