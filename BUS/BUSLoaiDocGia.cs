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
    public class BUSLoaiDocGia
    {
        private static BUSLoaiDocGia instance;
        public static BUSLoaiDocGia Instance
        {
            get
            {
                if (instance == null) instance = new BUSLoaiDocGia();
                return instance;
            }
            set => instance = value;
        }
        //Lấy ra danh sách tất cả các loại đọc giả
        public List<LOAIDOCGIA> GetAllLoaiDocGia()
        {
            return DALLoaiDocGia.Instance.GetAllLoaiDocGia();
        }

        public List<LOAIDOCGIA> GetLoaiDocGiaByTen(string ten)
        {
            return DALLoaiDocGia.Instance.GetLoaiDocGiaByTen(ten);
        }

        public LOAIDOCGIA GetLoaiDocGiaById(int id)
        {
            return DALLoaiDocGia.Instance.GetLoaiDocGiaById(id);    
        }
        public bool AddLoaiDocGia(string tenLoaiDocGia)
        {
            bool ldg = DALLoaiDocGia.Instance.AddLoaiDocGia(tenLoaiDocGia);
            if (ldg == false)
            {
                MessageBox.Show("Có lỗi xảy ra, không thể thêm.");
                return false;
            }
            else
            {
                MessageBox.Show("Thêm thành công");
                return ldg;
            }
        }
        public bool UpdLoaiDocGia(int id, string tenLoaiDocGia)
        {
            if (!DALLoaiDocGia.Instance.UpdLoaiDocGia(id, tenLoaiDocGia))
            {
                MessageBox.Show("Có lỗi xảy ra, không thể cập nhật thông tin.");
                return false;
            }
            return true;
        }
        public bool DelLoaiDocGia(int id)
        {
            var list = BUSDocGia.Instance.GetAllDocGia();
            foreach (var p in list)
            {
                if (p.LOAIDOCGIA.id == id)
                {
                    return false;
                }
            }
            if (!DALLoaiDocGia.Instance.DelLoaiDocGia(id))
            {
                MessageBox.Show("Có lỗi xảy ra, không thể cập nhật thông tin.");
                return false;
            }
            return true;
        }
    }
}
