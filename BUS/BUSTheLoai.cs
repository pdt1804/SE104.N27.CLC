using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class BUSTheLoai
    {
        private static BUSTheLoai instance;
        public static BUSTheLoai Instance
        {
            get
            {
                if (instance == null) instance = new BUSTheLoai();
                return instance;
            }
            set => instance = value;
        }

        // Lấy ra tất cả thể loại
        public List<THELOAI> GetAllTheLoai()
        {
            return DALTheLoai.Instance.GetAllTheLoai();
        }
        // Lấy thể loại bằng id
        public THELOAI GetTheLoai(int id)
        {
            return DALTheLoai.Instance.GetTheLoaiById(id);
        }
        // Tìm kiếm thể loại 
        public List<THELOAI> FindTheLoai(string name)
        {
            return DALTheLoai.Instance.FindTheLoai(name);
        }
        // Thêm thể loại mới
        public bool AddTheLoai(string name)
        {
            return DALTheLoai.Instance.AddTheLoai(name);
        }
        // Cập nhật tên thể loại
        public bool UpdTheLoai(int id, string name)
        {
            return DALTheLoai.Instance.UpdTheLoai(id, name);
        }
        //Xóa thể loại
        public bool DelTheLoai(int id)
        {
            return DALTheLoai.Instance.DelTheLoai(id);
        }
    }
}
