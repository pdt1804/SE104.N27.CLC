using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUSPhieuNhapSach
    {
        private static BUSPhieuNhapSach instance;

        public static BUSPhieuNhapSach Instance
        {
            get 
            {
                if (instance == null) instance = new BUSPhieuNhapSach();
                return instance; 
            }
            set { instance = value; }
        }

        public List<PHIEUNHAPSACH> GetAllPhieuNhapSach()
        {
            return DALPhieuNhapSach.Instance.GetAllPhieuNhapSach();
        }

        public PHIEUNHAPSACH GetPhieuById(int id)
        {
            return DALPhieuNhapSach.Instance.GetPhieuById(id);
        }

        public List<PHIEUNHAPSACH> GetPhieuByNgayNhap(DateTime ngayNhap)
        {
            return DALPhieuNhapSach.Instance.GetPhieuByNgayNhap(ngayNhap);
        }

        public List<PHIEUNHAPSACH> FindPhieuByNgayNhap(int? ngay, int? thang, int? nam)
        {
            return DALPhieuNhapSach.Instance.FindPhieuByNgayNhap(ngay,thang,nam);
        }

        public int AddPhieuNhap(DateTime ngayNhap)
        {
            return DALPhieuNhapSach.Instance.AddPhieuNhap(ngayNhap);

        }

        public bool UpdPhieuNhap(int id, DateTime? ngayNhap, int? tongTien)
        {
            return DALPhieuNhapSach.Instance.UpdPhieuNhap(id, ngayNhap, tongTien);
        }

        public bool DelPhieuNhap(int id)
        {
            return DALPhieuNhapSach.Instance.DelPhieuNhap(id);
        }


    }
}
