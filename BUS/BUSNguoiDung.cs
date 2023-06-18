using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class BUSNguoiDung
    {
        private static BUSNguoiDung instance;

        public static BUSNguoiDung Instance
        {
            get { if (instance == null) instance = new BUSNguoiDung(); return instance; }
            set { instance = value; }
        }

        public List<NGUOIDUNG> GetAllNguoiDung()
        {
            return DALNguoiDung.Instance.GetAllNguoiDung();
        }

        public NGUOIDUNG GetNguoiDungById(int id)
        {
            NGUOIDUNG nd = DALNguoiDung.Instance.GetNguoiDungById(id);
            if (nd == null) return null;
            else return nd;
        }

        public NGUOIDUNG GetNguoiDungByMa(string maNguoiDung)
        {
            NGUOIDUNG nd = DALNguoiDung.Instance.GetNguoiDungByMa(maNguoiDung);
            if (nd == null) return null;
            else return nd;
        }

        public int AddNguoiDung(string tenDocGiaNguoiDung, DateTime ngaySinh, string chucVu,
                                 string tenDocGiaDangNhap, string matKhau,string email, int idNhomNguoiDung)
        {
            int i = DALNguoiDung.Instance.AddNguoiDung(tenDocGiaNguoiDung, ngaySinh, chucVu, tenDocGiaDangNhap, matKhau,email, idNhomNguoiDung);
            if (i == -1)
            {
/*                MessageBox.Show("Đã có lỗi, không thể thêm người dùng.");
*/                return i; // return -1 
            }
            else
            {
/*                MessageBox.Show("Thêm thành công");
*/                return i; // return về ID của người dùng 
            }
        }

        public bool UpdNguoiDung(int id, string tenNguoiDung, DateTime? ngaySinh, string chucVu, string email,
                                 int? idNhomNguoiDung)
        {
            
            idNhomNguoiDung = Convert.ToInt32(DALNhomNguoiDung.Instance.GetNhomNguoiDungById(id));
            if (!DALNguoiDung.Instance.UpdNguoiDung(id, tenNguoiDung, ngaySinh, chucVu,email, idNhomNguoiDung))
            {
/*                MessageBox.Show("Cập nhật thông tin không thành công");
*/                return false;
            }
            return true;
        }

        public bool DelNguoiDung(int id)
        {
            if (!DALNguoiDung.Instance.DelNguoiDung(id))
            {
/*                MessageBox.Show("Xoá không thành công");
*/                return false;
            }
            return true;
        }

        public bool UpdPassword(int id, string password)
        {
            if (!DALNguoiDung.Instance.UpdPassword(id, password))
            {
/*                MessageBox.Show("Đổi mật khẩu không thành công");
*/                return false;
            }
            else
            {
/*                MessageBox.Show("Đổi mật khẩu thành công");
*/                return true;
            }
        }
    }
}