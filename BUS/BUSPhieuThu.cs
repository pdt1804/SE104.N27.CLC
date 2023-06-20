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
    public class BUSPhieuThu
    {
        private static BUSPhieuThu instance;

        public static BUSPhieuThu Instance
        {
            get { if (instance == null) instance = new BUSPhieuThu(); return instance; }
            set { instance = value; }
        }

        public List<PHIEUTHU> GetAllPhieuThu()
        {
            return DALPhieuThu.Instance.GetAllPhieuThu();
        }

        public PHIEUTHU GetPhieuThuById(int id)
        {
            PHIEUTHU pt = DALPhieuThu.Instance.GetPhieuThuById(id);
            if (pt == null) return null;
            else return pt;
        }

        public List<PHIEUTHU> FindPhieuThuByNgay(int? ngay, int? thang, int? nam)
        {
            return DALPhieuThu.Instance.FindPhieuThuByNgay(ngay, thang, nam);
        }

        public bool AddPhieuThu(int idDocGia, int soTienThu, DateTime ngayLap)
        {
            if (!DALPhieuThu.Instance.AddPhieuThu(idDocGia, soTienThu, ngayLap))
            {
                MessageBox.Show("Thêm phiếu thu không thành công");
                return false;
            }  
            else
            {
                MessageBox.Show("Thêm phiếu thu thành công");
                return true;
            }          
        }

        public bool UpdPhieuThu(int soPhieu, int? soTienThu, DateTime? ngayLap)
        {
            if (!DALPhieuThu.Instance.UpdPhieuThu(soPhieu, soTienThu, ngayLap))
            {
                MessageBox.Show("Cập nhật thông tin phiếu thu không thành công");
                return false;
            }
            return true;
        }
        public bool DelPhieuThu(int soPhieu)
        {
            if (!DALPhieuThu.Instance.DelPhieuThu(soPhieu))
            {
                MessageBox.Show("Xoá phiếu thu không thành công");
                return false;
            }
            return true;
        }

    }
}
