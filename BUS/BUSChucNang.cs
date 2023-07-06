using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class BUSChucNang
    {
        private static BUSChucNang instance;
        public static BUSChucNang Instance
        {
            get
            {
                if (instance == null) instance = new BUSChucNang();
                return instance;
            }
            set => instance = value;
        }
        // Lấy ra danh sách tất cả chức năng
        public List<CHUCNANG> GetAllChucNang()
        {
            return DALChucNang.Instance.GetAllChucNang();
        }
        // Lấy ra chức năng dựa trên thuộc tính ID của chức năng

        public CHUCNANG GetChucNangById(int id)
        {
            CHUCNANG CN = DALChucNang.Instance.GetChucNangById(id);
            if(CN == null) return null;
            else return CN;
        }
        public CHUCNANG GetChucNangByMa(string ma)
        {
            CHUCNANG CN = DALChucNang.Instance.GetChucNangByMa(ma);
            if (CN == null) return null;
            else return CN;
        }
    }
}
