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

        public NGUOIDUNG GetNguoiDungByUsernameAndEmail(string username, string email)
        {
            NGUOIDUNG nd = DALNguoiDung.Instance.GetNguoiDungByUsernameAndEmail(username, email);
            return nd;
        }

        public NGUOIDUNG GetNguoiDungByMa(string maNguoiDung)
        {
            NGUOIDUNG nd = DALNguoiDung.Instance.GetNguoiDungByMa(maNguoiDung);
            if (nd == null) return null;
            else return nd;
        }

        public int AddNguoiDung(string tenNguoiDung, DateTime ngaySinh, string chucVu,
                                 string tenDangNhap, string matKhau, string email, int idNhomNguoiDung)
        {
            foreach (NGUOIDUNG nd in BUSNguoiDung.Instance.GetAllNguoiDung())
                if (nd.TenDangNhap == tenDangNhap)
                    return -1;
            int i = DALNguoiDung.Instance.AddNguoiDung(tenNguoiDung, ngaySinh, chucVu, tenDangNhap, matKhau, email, idNhomNguoiDung);
            return i;
        }

        public string UpdNguoiDung(int id, string tenNguoiDung, DateTime? ngaySinh, string chucVu,
                                 int idNhomNguoiDung, string email)
        {
            NGUOIDUNG nd = DALNguoiDung.Instance.GetNguoiDungById(id);
            if (nd == null)
            {
                return "Người dùng không hợp lệ";
            }
            if (nd.TenDangNhap == "admin")
                return "Không thể sửa người dùng này";
            NHOMNGUOIDUNG nnd = DALNhomNguoiDung.Instance.GetNhomNguoiDungById(idNhomNguoiDung);
            if (nnd == null)
                return " Nhóm người dùng không hợp lệ";
            if (DALNguoiDung.Instance.UpdNguoiDung(id, tenNguoiDung, ngaySinh, chucVu, email, idNhomNguoiDung))
                return "";
            return "Không thể update người dùng";
        }

        public string DelNguoiDung(string maNguoiDung)
        {
            NGUOIDUNG nd = DALNguoiDung.Instance.GetNguoiDungByMa(maNguoiDung);
            if (nd == null)
            {
                return "Mã người dùng không hợp lệ";
            }
            if (nd.TenDangNhap == "admin")
            {
                return "Không thể xoá người dùng này";
            }
            bool isDG = false;
            foreach (CHUCNANG cn in nd.NHOMNGUOIDUNG.CHUCNANGs)
            {
                if (cn.TenChucNang == "DG") isDG = true;
            }
            if (isDG) return "Không thể xóa người dùng là độc giả";
            if (DALNguoiDung.Instance.DelNguoiDung(nd.id)) return "";
            return "Không thể xoá người dùng";
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

        public bool UpdMK(int id, string MatKhau)
        {
            return DALNguoiDung.Instance.UpdPassword(id, MatKhau);
        }
    }
}

