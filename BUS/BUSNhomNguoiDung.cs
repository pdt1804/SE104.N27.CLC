using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class BUSNhomNguoiDung
    {
        private static BUSNhomNguoiDung instance;

        public static BUSNhomNguoiDung Instance
        {
            get { if (instance == null) instance = new BUSNhomNguoiDung(); return instance; }
            set { instance = value; }
        }

        public List<NHOMNGUOIDUNG> GetAllNhomNguoiDung()
        {
            return DALNhomNguoiDung.Instance.GetAllNhomNguoiDung();
        }

        public NHOMNGUOIDUNG GetNhomNguoiDungById(int id)
        {
            NHOMNGUOIDUNG nnd = DALNhomNguoiDung.Instance.GetNhomNguoiDungById(id);
            if (nnd == null) return null;
            else return nnd;
        }

        public NHOMNGUOIDUNG GetNhomNguoiDungByMa(string ma)
        {
            NHOMNGUOIDUNG nnd = DALNhomNguoiDung.Instance.GetNhomNguoiDungByMa(ma);
            if (nnd == null) return null;
            else return nnd;
        }

        public int AddNhomNguoiDung(string tenDocGiaNhom)
        {
            int i = DALNhomNguoiDung.Instance.AddNhomNguoiDung(tenDocGiaNhom);
            if (i == -1)
            {
                //MessageBox.Show("Thêm nhóm người dùng không thành công");
                return i; // return -1
            }
            else
            {
                //MessageBox.Show("Thêm nhóm người dùng thành công");
                return i; // return về ID của nhóm vừa được tạo
            }
        }

        public bool UpdNhomNguoiDung(int id, string tenDocGiaNhom)
        {
            if (!DALNhomNguoiDung.Instance.UpdNhomNguoiDung(id, tenDocGiaNhom))
            {
               // MessageBox.Show("Có lỗi xảy ra, cập nhật không thành công.");
                return false;
            }
            return true;
        }
        public bool DelNhomNguoiDung(int id)
        {
            if (!DALNhomNguoiDung.Instance.DelNhomNguoiDung(id))
            {
               // MessageBox.Show("Xoá không thành công.");
                return false;
            }
            return true;
        }
    }
}