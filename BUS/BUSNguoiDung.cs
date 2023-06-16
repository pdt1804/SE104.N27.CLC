using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;

namespace BUS
{
    public class BUSNguoiDung
    {
        private BUSNguoiDung instance;

        public BUSNguoiDung Instance
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

        public int AddNguoiDung(string tenNguoiDung, DateTime ngaySinh, string chucVu,
                                 string tenDangNhap, string matKhau, int idNhomNguoiDung)
        {
            int i = DALNguoiDung.Instance.AddNguoiDung(tenNguoiDung, ngaySinh, chucVu, tenDangNhap, matKhau, idNhomNguoiDung);
            if (i == -1)
            {
                MessageBox.Show("Đã có lỗi, không thể thêm người dùng.");
                return i; // return -1 
            }    
            else
            {
                MessageBox.Show("Thêm thành công");
                return i; // return về ID của người dùng 
            }    
        }

        public bool UpdNguoiDung(int id, string tenNguoiDung, DateTime? ngaySinh, string chucVu,
                                 int? idNhomNguoiDung)
        {
            if (!DALNguoiDung.Instance.UpdNguoiDung(id, tenNguoiDung, ngaySinh, chucVu, idNhomNguoiDung))
            {
                MessageBox.Show("Cập nhật thông tin không thành công");
                return false;
            }
            return true;
        }

        public bool DelNguoiDung(int id)
        {
            if (!DALNguoiDung.Instance.DelNguoiDung(id))
            {
                MessageBox.Show("Xoá không thành công");
                return false;
            }
            return true;
        }

        public bool UpdPassword(int id, string password)
        {
            if (!DALNguoiDung.Instance.UpdPassword(id, password))
            {
                MessageBox.Show("Đổi mật khẩu không thành công");
                return false;
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu thành công");
                return true;
            }    
        }
    }
}
