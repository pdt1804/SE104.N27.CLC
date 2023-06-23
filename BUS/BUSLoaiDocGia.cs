using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public LOAIDOCGIA GetLoaiDocGiaById(int id)
        {
            return DALLoaiDocGia.Instance.GetLoaiDocGiaById(id);    
        }
        public bool AddLoaiDocGia(string tenLoaiDocGia)
        {
            return DALLoaiDocGia.Instance.AddLoaiDocGia(tenLoaiDocGia);
        }
        public bool UpdLoaiDocGia(int id, string tenLoaiDocGia)
        {
            return DALLoaiDocGia.Instance.UpdLoaiDocGia(id, tenLoaiDocGia);

        }
        public bool DelLoaiDocGia(int id)
        {
            return DALLoaiDocGia.Instance.DelLoaiDocGia(id);
        }
    }
}
