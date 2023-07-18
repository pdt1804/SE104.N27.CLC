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
        public int AddNhomNguoiDung(string tenNhom)
        {
            if (tenNhom == "Quản Lý") return -1;
            int i = DALNhomNguoiDung.Instance.AddNhomNguoiDung(tenNhom);
            if (i == -1)
            {
                MessageBox.Show("Thêm nhóm người dùng không thành công");
                return i; // return -1
            }    
            else
            {
                MessageBox.Show("Thêm nhóm người dùng thành công");
                return i; // return về ID của nhóm vừa được tạo
            }    
        }

        public bool UpdNhomNguoiDung(int id, string tenNhom)
        {

            if (!DALNhomNguoiDung.Instance.UpdNhomNguoiDung(id, tenNhom))
            {
                MessageBox.Show("Có lỗi xảy ra, cập nhật không thành công.");
                return false;
            }
            return true;
        }
        public string DelNhomNguoiDung(int id)
        {
            NHOMNGUOIDUNG nnd = DALNhomNguoiDung.Instance.GetNhomNguoiDungById(id);
            if (nnd == null)
            { return "Mã nhóm người dùng không đúng"; }
            if (nnd.id == 1)
                return "Không thể xoá nhóm người dùng Quản Lý";
            bool isDG = false;
            foreach (CHUCNANG cn in nnd.CHUCNANGs)
            {
                if (cn.TenChucNang == "DG") isDG = true;
            }
            if (isDG && nnd.NGUOIDUNGs.Count > 0)
                return "Không thể xóa nhóm người dùng này vì các người dùng thuộc nhóm có quyền độc giả!";
            if (DALNhomNguoiDung.Instance.DelNhomNguoiDung(nnd.id))
                return "";
            return "Không thể xoá nhóm người dùng";
        }

        public string AddChucNangNhom(int maNhomNguoiDung, List<String> dsChucNang)
        {
            List<CHUCNANG> ds = new List<CHUCNANG>();
            foreach (var ma in dsChucNang)
            {
                var cn = DALChucNang.Instance.GetChucNangByMa(ma);
                //Console.WriteLine(ma);
                if (cn == null) return "Danh sách các mã chức năng không hợp lệ.";

                ds.Add(cn);
            }

            var nnd = DALNhomNguoiDung.Instance.GetNhomNguoiDungById(maNhomNguoiDung);
            if (nnd == null) return "Mã nhóm người dùng không đúng.";
            if (nnd.id == 1) return "Không thể chỉnh sửa nhóm người dùng này";
            if (DALNhomNguoiDung.Instance.AddChucNangNhom(nnd.id, ds))
                return "";
            return "Không thể thêm chức năng cho nhóm người dùng.";

        }
        public string DelChucNangNhom(int id, List<String> dsChucNang)
        {
            List<CHUCNANG> ds = new List<CHUCNANG>();
            foreach (var ma in dsChucNang)
            {
                var cn = DALChucNang.Instance.GetChucNangByMa(ma);
                if (cn == null) return "Danh sách các mã chức năng không hợp lệ.";
                ds.Add(cn);
            }
            var nnd = DALNhomNguoiDung.Instance.GetNhomNguoiDungById(id);
            if (nnd == null) return "Mã nhóm người dùng không đúng.";
            if (nnd.id == 1)
                return "Không thể chỉnh sửa nhóm người dùng này";
            if (DALNhomNguoiDung.Instance.DelChucNangNhom(nnd.id, ds))
                return "";
            return "Không thể thêm chức năng cho nhóm người dùng.";
        }
    }
}
