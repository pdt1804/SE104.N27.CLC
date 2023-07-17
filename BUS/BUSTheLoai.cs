using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        public List<THELOAI> GetAllTheLoai()
        {
            return DALTheLoai.Instance.GetAllTheLoai();
        }

        public THELOAI GetTheLoai(int id)
        {
            THELOAI tl = DALTheLoai.Instance.GetTheLoaiById(id);
            if (tl == null) return null;
            else return tl;
        }

        public List<THELOAI> FindTheLoai(string name)
        {
            return DALTheLoai.Instance.FindTheLoai(name);
        }

        public bool AddTheLoai(string name)
        {
            if (!DALTheLoai.Instance.AddTheLoai(name))
            {
                MessageBox.Show("Thêm thể loại không thành công");
                return false;
            }
            else
            {
                MessageBox.Show("Thêm thành công");
                return true;
            }
        }

        public bool UpdTheLoai(int id, string name)
        {
            if (!DALTheLoai.Instance.UpdTheLoai(id, name))
            {
                MessageBox.Show("Cập nhật thông tin thể loại không thành công");
                return false;
            }
            return true;
        }

        public string DelTheLoai(int id)
        {
            THELOAI tl;
            try
            {
                tl = BUSTheLoai.Instance.GetTheLoai(id);
            }
            catch
            {
                return "Mã thể loại không hợp lệ";
            }
            foreach (TUASACH tuasach in tl.TUASACHes)
            {
                if (tuasach.idTheLoai == id) return "Không thể xóa thể loại sách";

            }
            DALTheLoai.Instance.DelTheLoai(id);
            return "";
        }
    }
}
