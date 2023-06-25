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
    public class BUSSach
    {
        private static BUSSach instance;

        public static BUSSach Instance
        {
            get 
            { 
                if (instance == null) instance = new BUSSach();
                return instance; 
            }
            set { instance = value; }
        }

        public bool UpdAnSach(int id, int data)
        {
            if (!DALSach.Instance.UpdAnSach(id, data))
            {
                MessageBox.Show("Đã có lỗi xảy ra, không thể cập nhật những thay đổi.");
                return false;
            }
            return true;
        }
        public List<SACH> GetAllSach()
        {
            return DALSach.Instance.GetAllSach();
        }

        public SACH GetSachById(int id)
        {
            SACH sach = DALSach.Instance.GetSachById(id);
            if (sach == null) return null;
            else return sach;
        }

        public SACH GetSachByMa(string maSach)
        {
            SACH sach = DALSach.Instance.GetSachByMa(maSach);
            if (sach == null) return null;
            else return sach;
        }

        public List<SACH> FindSach(TUASACH tuaSach, int? namXB, string nhaXB)
        {
            return DALSach.Instance.FindSach(tuaSach, namXB, nhaXB);
        }

        public int AddSachMoi(TUASACH tuaSach, int donGia, int namXB, string nhaXB)
        {
            int i = DALSach.Instance.AddSachMoi(tuaSach, donGia, namXB, nhaXB); // Hàm trả về ID sách sau khi được thêm vào
            if (i == -1)
            {
                MessageBox.Show("Có lỗi xảy ra, không thể thêm sách mới.");
                return -1;
            }    
            else
            {
                MessageBox.Show("Thêm thành công");
                return i;
            }    
        }

        public bool UpdSach(int id, int? namXB, string nhaXB)
        {
            if (!DALSach.Instance.UpdSach(id, namXB, nhaXB))
            {
                MessageBox.Show("Có lỗi xảy ra, không thể cập nhật thông tin.");
                return false;
            }
            return true;
        }

        public bool DelSach(int id)
        {
            if (!DALSach.Instance.DelSach(id))
            {
                MessageBox.Show("Có lỗi xảy ra, không thể xoá.");
                return false;
            }
            return true;
        }

        public bool AddSachDaCo(int id, int soLuong)
        {
            if (DALSach.Instance.AddSachDaCo(id, soLuong))
            {
                MessageBox.Show("Thêm thành công");
                return true;
            }    
            else
            {
                MessageBox.Show("Thêm không thành công, vui lòng kiểm tra sách này đã có hay chưa nếu chưa có phải thêm sách mới đó vào trước");
                return false;
            }    
        }
    }
}
