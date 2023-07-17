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
    public class BUSTacGia
    {
        private static BUSTacGia instance;
        public static BUSTacGia Instance
        {
            get
            {
                if (instance == null) instance = new BUSTacGia();
                return instance;
            }
            set => instance = value;
        }

        public List<TACGIA> GetAllTacGia()
        {
            return DALTacGia.Instance.GetAllTacGia();
        }

        public TACGIA GetTacGia(int id)
        {
            TACGIA tg = DALTacGia.Instance.GetTacGiaById(id);
            if (tg == null) return null;
            else return tg;
        }

        public List<TACGIA> FindTacGia(string name)
        {
            return DALTacGia.Instance.FindTacGia(name);
        }

        public int AddTacGia(string name)
        {
            int i = DALTacGia.Instance.AddTacGia(name);
            if (i == -1)
            {
                MessageBox.Show("Thêm tác giả không thành công");
                return i; // return về -1
            }    
            else
            {
                MessageBox.Show("Thêm thành công");
                return i; // return về id của tác giả vừa được thêm
            }    
        }

        public bool UpdTacGia(int id, string name)
        {
            if (!DALTacGia.Instance.UpdTacGia(id, name))
            {
                MessageBox.Show("Cập nhật thông tin tác giả không thành công.");
                return false;
            }
            return true;
        }

        public string DelTacGia(int id)
        {
            TACGIA tg;
            try
            {
                tg = BUSTacGia.Instance.GetTacGia(id);
            }
            catch
            {
                return "Mã tác giả không hợp lệ";
            }
            foreach(TUASACH tuasach in tg.TUASACHes)
            {
                if (tuasach.TACGIAs.Where(TG => TG.MATACGIA == tg.MATACGIA).Any())
                {
                    return "Không thể xóa tác giả";
                } 
                    
            }
            DALTacGia.Instance.DelTacGia(id);
            return "";
        }
    }
}
