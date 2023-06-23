using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public CUONSACH GetCuonSachByMa(string MaCuonSach)
        {
            CUONSACH cs;
            cs = DALCuonSach.Instance.GetCuonSachByMa(MaCuonSach);

            return DALCuonSach.Instance.GetCuonSachByMa(MaCuonSach);
        }
        public List<CUONSACH> FindCuonSach(SACH name, int? tinhtrang)
        {
            return DALCuonSach.Instance.FindCuonSach(name, tinhtrang);
        }
        public bool AddCuonSach(SACH sach, int tinhTrang = 0)
        {
            return DALCuonSach.Instance.AddCuonSach(sach, tinhTrang);
        }
        public string UpdCuonSach(string id, int data)
        {
            CUONSACH cs = DALCuonSach.Instance.GetCuonSachByMa(id);
            if (data == 1 && cs.TinhTrang == 0)
                return "Không thể ẩn vì còn sách đang được mượn";
            if (cs.TinhTrang == 0) return "";
            if (DALCuonSach.Instance.UpdCuonSach(cs.id, data))
                return "";
            return "Lỗi";
        }

        public string DelCuonSach(string MaCuonSach)
        {
            CUONSACH cs;
            cs = DALCuonSach.Instance.GetCuonSachByMa(MaCuonSach);
            if (cs == null)
            {
                return "Mã cuốn sách không hợp lệ";
            }
            if (cs.TinhTrang == 0)
                return "Cuốn sách đang được mượn không thể xoá";
            if (DALCuonSach.Instance.DelCuonSach(cs.id))
                return "";
            return "Không thể xoá cuốn sách";
        }
        // Lấy ra cuốn sách dựa trên ID của sách
        public CUONSACH GetCuonSachById(int id)
        {
            return DALCuonSach.Instance.GetCuonSachById(id);
        }
    }
}
