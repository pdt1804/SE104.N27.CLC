using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DALTheLoai
    {
        private static DALTheLoai instance;

        public static DALTheLoai Instance
        {
            get
            {
                if (instance == null) instance = new DALTheLoai();
                return instance;
            }
            set => instance = value;
        }
        // Lấy ra tất cả thể loại
        public List<THELOAI> GetAllTheLoai()
        {
            return QLTVEntities.Instance.THELOAIs.AsNoTracking().ToList();
        }

        /// <summary>
        /// Lấy thể loại bằng id
        /// </summary>
        ///<param name="id"></param>
        /// <returns></returns>
        public THELOAI GetTheLoaiById(int id)
        {
            return QLTVEntities.Instance.THELOAIs.Find(id);
        }

        /// <summary>
        /// Tìm kiếm thể loại bằng tên thể loại
        /// </summary>
        /// <param name="tenTheLoai"></param>
        /// <returns></returns>
        public List<THELOAI> FindTheLoai(string tenTheLoai)
        {
            return QLTVEntities.Instance.THELOAIs.AsNoTracking().Where(t => t.TenTheLoai == tenTheLoai).Select(t => t).ToList();
        }

        // Thêm mới thể loại 
        public bool AddTheLoai(string tenTheLoai)
        {
            try
            {
                THELOAI theloai = new THELOAI { TenTheLoai = tenTheLoai };
                QLTVEntities.Instance.THELOAIs.Add(theloai);
                QLTVEntities.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }

        // Cập nhật tên thể loại
        public bool UpdTheLoai(int id, string tenTheLoai)
        {
            try
            {
                var theloai = GetTheLoaiById(id);
                if (theloai == null) return false;
                theloai.TenTheLoai = tenTheLoai;
                QLTVEntities.Instance.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Xóa thể loại
        public bool DelTheLoai(int id)
        {
            try
            {
                var theloai = GetTheLoaiById(id);
                if (theloai == null) return false;
                QLTVEntities.Instance.THELOAIs.Remove(theloai);
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
