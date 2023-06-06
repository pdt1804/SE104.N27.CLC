using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALTacGia
    {
        private static DALTacGia instance;
        public static DALTacGia Instance
        {
            get
            {
                if (instance == null) instance = new DALTacGia();
                return instance;
            }
            set => instance = value;
        }

        // Lấy ra tất cả tác giả
        public List<TACGIA> GetAllTacGia()
        {
            return QLTVEntities.Instance.TACGIAs.AsNoTracking().ToList();
        }

        // Lấy tác giả bằng id
        public TACGIA GetTacGiaById(int id)
        {
            return QLTVEntities.Instance.TACGIAs.Find(id);
        }

        /// <summary>
        /// Tìm kiếm tác giả
        /// </summary>
        /// <param name="tenTacGia"></param>
        /// <returns></returns>
        public List<TACGIA> FindTacGia(string tenTacGia)
        {
            return QLTVEntities.Instance.TACGIAs.Where(t => t.TenTacGia == tenTacGia).Select(t => t).ToList();
        }

        // Thêm tác giả
        public int AddTacGia(string tenTacGia)
        {
            try
            {
                TACGIA tacGia = new TACGIA { TenTacGia = tenTacGia };
                QLTVEntities.Instance.TACGIAs.Add(tacGia);
                QLTVEntities.Instance.SaveChanges();
                return tacGia.id;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return -1;
            }
        }

        // Cập nhật tên tác giả 
        public bool UpdTacGia(int id, string tenTacGia)
        {
            try
            {
                TACGIA tacgia = GetTacGiaById(id);
                if (tacgia == null) return false;
                tacgia.TenTacGia = tenTacGia;
                QLTVEntities.Instance.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Xóa tác giả khi có id
        public bool DelTacGia(int id)
        {
            try
            {
                TACGIA tacgia = GetTacGiaById(id);
                if (tacgia == null) return false;
                QLTVEntities.Instance.TACGIAs.Remove(tacgia);
                QLTVEntities.Instance.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
