using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            PHIEUNHAPSACH p = DALPhieuNhapSach.Instance.GetPhieuById(id);
            if (p == null) return null;
            else return p;
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
            int i = DALPhieuNhapSach.Instance.AddPhieuNhap(ngayNhap);
            if (i > 0) return i;
            else return 0;
        }

        public bool UpdPhieuNhap(int id, DateTime? ngayNhap, int? tongTien)
        {
            if (!DALPhieuNhapSach.Instance.UpdPhieuNhap(id, ngayNhap, tongTien))
            {
                MessageBox.Show("Có lỗi xảy ra, không thể cập nhật.");
                return false;
            }    
            return true;
        }

        public bool DelPhieuNhap(int id)
        {
            if (!DALPhieuNhapSach.Instance.DelPhieuNhap(id))
            {
                MessageBox.Show("Có lỗi xảy ra, không thể xoá.");
                return false;
            }
            return true;
        }


    }
}
