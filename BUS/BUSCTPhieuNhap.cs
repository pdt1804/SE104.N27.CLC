using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class BUSCTPhieuNhap
    {
        private static BUSCTPhieuNhap instance;
        public static BUSCTPhieuNhap Instance
        {
            get
            {
                if (instance == null) instance = new BUSCTPhieuNhap();
                return instance;
            }
            set { instance = value; }
        }

        // Lấy ra danh sách tất cả thông tin chi tiết về phiếu nhập
        public List<CT_PHIEUNHAP> GetAllCTPhieuNhap()
        {
            return DALCTPhieuNhap.Instance.GetAllCTPhieuNhap();
        }
        // Lấy ra thông tin chi tiết phiếu nhập dựa trên số phiếu và ID sách
        public CT_PHIEUNHAP GetCT_PHIEUNHAP(int soPhieu, int idSach)
        {
            return DALCTPhieuNhap.Instance.GetCT_PHIEUNHAP(soPhieu,idSach);
        }

        public string AddCtPhieuNhap(int soPhieu, int idSach, int donGia, int soLuongNhap)
        {
            PHIEUNHAPSACH pn = DALPhieuNhapSach.Instance.GetPhieuById(soPhieu);
            if (pn == null)
                return "Phiếu nhập sách không hợp lệ";
            SACH sach = DALSach.Instance.GetSachById(idSach);
            if(sach == null)
                return "Mã sách không hợp lệ";
            if (donGia < 0)
                return "Đơn giá không hợp lệ";
            if (soLuongNhap <= 0)
                return "Số lượng nhập không hợp lệ";
            THAMSO thamso = DALThamSo.Instance.GetAllThamSo();

            if (DALCTPhieuNhap.Instance.AddCTPhieuNhap(soPhieu, idSach, donGia, soLuongNhap))
                return "";
            return "Không thể nhập sách này";
        }
    }
}
