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
    public class BUSTuaSach
    {
        private static BUSTuaSach instance;

        public static BUSTuaSach Instance
        {
            get { if (instance == null) instance = new BUSTuaSach(); return instance; }
            set { instance = value; }
        }

        public List<TUASACH> GetAllTuaSach()
        {
            return DALTuaSach.Instance.GetAllTuaSach();
        }

        public TUASACH GetTuaSachById(int id)
        {
            TUASACH ts = DALTuaSach.Instance.GetTuaSachById(id);
            if (ts == null) return null;
            else return ts;
        }

        public TUASACH GetTuaSachByMa(string maTuaSach)
        {
            TUASACH ts = DALTuaSach.Instance.GetTuaSachByMa(maTuaSach);
            if (ts == null) return null;
            else return ts;
        }

        public List<TUASACH> FindTuaSach(string tenTuaSach, THELOAI theloai, List<TACGIA> tacgias)
        {
            return DALTuaSach.Instance.FindTuaSach(tenTuaSach, theloai, tacgias);
        }

        public bool AddTuaSach(string tenTuaSach, THELOAI theLoai, List<TACGIA> dsTacGia)
        {
            if (!DALTuaSach.Instance.AddTuaSach(tenTuaSach, theLoai, dsTacGia))
            {
                MessageBox.Show("Có lỗi xảy ra, không thể thêm tựa sách.");
                return false;
            }
            else
            {
                MessageBox.Show("Thêm thành công");
                return true;
            }
        }

        public bool UpdTuaSach(int idTuaSach, string tenTuaSach, THELOAI theLoai, List<TACGIA> dsTacGia)
        {
            if (!DALTuaSach.Instance.UpdTuaSach(idTuaSach, tenTuaSach, theLoai, dsTacGia))
            {
                MessageBox.Show("Có lỗi xảy ra, không thể cập nhật thông tin tựa sách.");
                return false;
            }
            return true;
        }

        public string DelTuaSach(int id)
        {
            TUASACH ts;
            try
            {
                ts = DALTuaSach.Instance.GetTuaSachById(id);
            }
            catch
            {
                return "Mã tựa sách không hợp lệ";
            }
            if (BUSSach.Instance.CheckTS(ts.id)) return "Không thể xóa tựa sách";
            DALTuaSach.Instance.DelTuaSach(ts.id);
            return "";
        }

        public bool UpdAnTuaSach(int id, int data)
        {
            if (!DALTuaSach.Instance.UpdAnTuaSach(id, data))
            {
                MessageBox.Show("Cập nhật không thành công");
                return false;
            }
            return true;
        }
    }
}
