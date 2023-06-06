using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUSTacGia
    {
        private static BUSTacGia instance;
        public static BUSTacGia Instance
        {
            get
            {
                if (instance == null) instance = new BUSTacGia();
                return instance;
            }
            set => instance = value;
        }

        // Lấy ra tất cả tác giả
        public List<TACGIA> GetAllTacGia()
        {
            return DALTacGia.Instance.GetAllTacGia();
        }
        // Lấy tác giả bằng id
        public TACGIA GetTacGia(int id)
        {
            TACGIA tg;
            tg = DALTacGia.Instance.GetTacGiaById(id);
            return tg;
        }
        // Tìm thông tin tác giả
        public List<TACGIA> FindTacGia(string name)
        {
            return DALTacGia.Instance.FindTacGia(name);
        }
        //Thêm tác giả
        public int AddTacGia(string name)
        {
            return (DALTacGia.Instance.AddTacGia(name));

        }
        // Chỉnh sửa tên tác giả
        public bool UpdTacGia(int id, string name)
        {
            TACGIA tacgia = DALTacGia.Instance.GetTacGiaById(id);
            if (tacgia == null) return false;
            if (DALTacGia.Instance.UpdTacGia(id, name))
                return true;
            else return false;
        }
        //Xóa tác giả
        public string DelTacGia(int id)
        {
            TACGIA tg = DALTacGia.Instance.GetTacGiaById(id);
            if (tg == null) return "Mã tác giả không đúng ";
            if (DALTacGia.Instance.DelTacGia(tg.id))
                return "";
            return "Không thể xóa tác giả";
        }
    }
}
