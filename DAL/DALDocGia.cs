using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALDocGia
    {
        private static DALDocGia instance;

        public static DALDocGia Instance
        {
            get
            {
                if (instance == null) instance = new DALDocGia();
                return instance;
            }
            set => instance = value;
        }
        public List<DOCGIA> GetAllDocGia()
        {
            return QLTVEntities.Instance.DOCGIAs.AsNoTracking().ToList();
        }
        public DOCGIA GetDocGiaById(int id) 
        {
            return QLTVEntities.Instance.DOCGIAs.Find(id);
        }
        public DOCGIA GetDocGiaByMa(string ma)
        {
            var res = QLTVEntities.Instance.DOCGIAs.AsNoTracking().Where(m => m.MaDocGia == ma);
            if(res.Any())
            {
                return res.FirstOrDefault();
            }
            return null;
        }
        public List<DOCGIA> FindDocGia(string ten, string email, int? idLoaiDocGia)
        {
            var res = QLTVEntities.Instance.DOCGIAs.ToList();
            if(ten != null) res = res.Where(t => t.TenDocGia == ten).Select(t => t).ToList();
            if (email != null) res = res.Where(e => e.TenDocGia == email).Select(e => e).ToList();
            if (idLoaiDocGia != null) res = res.Where(d => d.idLoaiDocGia == idLoaiDocGia).Select(d => d).ToList();
            return res;
        }
        public DOCGIA FindDocGiaByIdND(int idnguoidung)
        {
            return QLTVEntities.Instance.DOCGIAs.AsNoTracking().Where(d => d.idNguoiDung == idnguoidung).First();
        }
        public bool AddDocGia(string tenDocGia, DateTime ngaySinh, string diaChi, string email,
            DateTime ngayLapThe, DateTime ngayHetHan, int idLoaiDocGia, int tongNoHienTai, int idND)
        {
            try
            {
                var obj = new DOCGIA();
                obj.TenDocGia = tenDocGia;
                obj.NgaySinh = ngaySinh;
                obj.DiaChi = diaChi;
                obj.Email = email;
                obj.NgayLapThe = ngayLapThe;
                obj.NgayHetHan = ngayHetHan;
                obj.idLoaiDocGia = idLoaiDocGia;
                obj.TongNoHienTai = tongNoHienTai;
                obj.idNguoiDung = idND;
                obj.NGUOIDUNG = DALNguoiDung.Instance.GetNguoiDungById(idND);
                QLTVEntities.Instance.DOCGIAs.Add(obj);
                QLTVEntities.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }
        public bool UpdDocGia(int idDocGia, string tenDocGia, DateTime? ngaySinh, string diaChi, string email,
            DateTime? ngayHetHan, int? idLoaiDocGia)
        {
            try
            {
                DOCGIA dg = GetDocGiaById(idDocGia);
                if (dg == null) return false;

                if (tenDocGia != null) dg.TenDocGia = tenDocGia;
                if (ngaySinh != null) dg.NgaySinh = (DateTime)ngaySinh;
                if (diaChi != null) dg.DiaChi = diaChi;
                if (email != null) dg.Email = email;
                if (ngayHetHan != null) dg.NgayHetHan = (DateTime)ngayHetHan;
                if (idLoaiDocGia != null) dg.idLoaiDocGia = (int)idLoaiDocGia;

                QLTVEntities.Instance.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DelDocGia(int idDocGia)
        {
            try
            {
                DOCGIA dg = GetDocGiaById(idDocGia);
                if (dg == null) return false;
                QLTVEntities.Instance.DOCGIAs.Remove(dg);
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
