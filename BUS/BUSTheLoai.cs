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

        public bool DelTheLoai(int id)
        {
            if (!DALTheLoai.Instance.DelTheLoai(id))
            {
                MessageBox.Show("Xoá thể loại không thành công");
                return false;
            }
            return true;
        }
    }
}
