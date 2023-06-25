using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUSCuonSach
    {
        private static BUSCuonSach instance;
        public static BUSCuonSach Instance
        {
            get
            {
                if (instance == null) instance = new BUSCuonSach();
                return instance;
            }
            set => instance = value;
        }

        // Lấy tất cả cuốn sách có trong hệ thống
        public List<CUONSACH> GetAllCuonSach()
        {
            return DALCuonSach.Instance.GetAllCuonSach();
        }
        // Lấy ra tất cả sách có trong kho trong trạng thái available(còn trong kho)
        public List<CUONSACH> GetAllCuonSachAvailable()
        {
            List<CUONSACH> CuonSachList = new List<CUONSACH>();
            foreach (CUONSACH cs in DALCuonSach.Instance.GetAllCuonSach())
                if (cs.TinhTrang == 1)
                    CuonSachList.Add(cs);
            return CuonSachList;
        }
        // Lấy ra cuốn sách dựa trên mã cuốn sách
        public CUONSACH GetCuonSachById(int id)
        {
            CUONSACH cuonsach = DALCuonSach.Instance.GetCuonSachById(id);
            if (cuonsach == null) return null;
            else return cuonsach;
        }
        public CUONSACH GetCuonSachByMa(string MaCuonSach)
        {
            CUONSACH cuonsach = DALCuonSach.Instance.GetCuonSachByMa(MaCuonSach);
            if (cuonsach == null) return null;
            else return cuonsach;
        }
        public List<CUONSACH> FindCuonSach(SACH name, int? tinhtrang)
        {
            return DALCuonSach.Instance.FindCuonSach(name, tinhtrang);
        }
        public bool AddCuonSach(SACH sach, int tinhTrang = 0)
        {
            bool i = DALCuonSach.Instance.AddCuonSach(sach, tinhTrang);
            if (i == false)
            {
                MessageBox.Show("Có lỗi xảy ra, không thể thêm sách mới.");
                return false;
            }
            else
            {
                MessageBox.Show("Thêm thành công");
                return i;
            }
        }
        public bool UpdCuonSach(int id, int data)
        {
            if (!DALCuonSach.Instance.UpdCuonSach(id, data))
            {
                MessageBox.Show("Có lỗi xảy ra, không thể cập nhật thông tin.");
                return false;
            }
            return true;
        }

        public bool DelCuonSach(int idCuonSach)
        {
            if (!DALCuonSach.Instance.DelCuonSach(idCuonSach))
            {
                MessageBox.Show("Có lỗi xảy ra, không thể xoá.");
                return false;
            }
            return true;
        }
    }
}
