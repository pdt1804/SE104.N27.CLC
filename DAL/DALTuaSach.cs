using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALTuaSach
    {
        private static DALTuaSach instance;

        public static DALTuaSach Instance
        {
            get
            {
                if (instance == null) instance = new DALTuaSach();
                return instance;
            }
            set => instance = value;
        }
        // Lấy tất cả tựa sách
        public List<TUASACH> GetAllTuaSach()
        {
            return QLTVEntities.Instance.TUASACHes.AsNoTracking().ToList();
        }
        // Lấy tựa sách bằng id
        public TUASACH GetTuaSachById(int id)
        {
            return QLTVEntities.Instance.TUASACHes.Find(id);
        }
        /// <summary>
        /// Lấy tựa sách bằng matuasach
        /// </summary>
        /// <param name="maTuaSach"></param>
        /// <returns></returns>
        public TUASACH GetTuaSachByMa(string maTuaSach)
        {
            var res = QLTVEntities.Instance.TUASACHes.AsNoTracking().Where(t => t.MaTuaSach == maTuaSach);
            if (res.Any())
                return res.FirstOrDefault();
            return null;
        }

        /// <summary>
        /// tìm tựa sách
        /// </summary>
        /// <param name="tenTuaSach"></param>
        /// <param name="theloai"></param>
        /// <param name="tacgias"></param>
        /// <returns></returns>
        public List<TUASACH> FindTuaSach(string tenTuaSach, THELOAI theloai, List<TACGIA> tacgias)
        {
            List<TUASACH> res = QLTVEntities.Instance.TUASACHes.AsNoTracking().ToList();
            if (tenTuaSach != null) res = res.Where(t => t.TenTuaSach == tenTuaSach).Select(t => t).ToList();
            if (theloai != null) res = res.Where(t => t.THELOAI == theloai).Select(t => t).ToList();
            if (tacgias != null)
                foreach (var tacgia in tacgias)
                    res = res.Where(t => t.TACGIAs.Contains(tacgia)).Select(t => t).ToList();
            return res;
        }
        // Thêm tựa sách mới
        public bool AddTuaSach(string tenTuaSach, THELOAI theLoai, List<TACGIA> dsTacGia)
        {
            try
            {
                TUASACH tuaSach = new TUASACH();
                tuaSach.TenTuaSach = tenTuaSach;
                tuaSach.idTheLoai = theLoai.id;
                tuaSach.THELOAI = theLoai;
                tuaSach.TACGIAs = dsTacGia;
                tuaSach.DaAn = 0;
                QLTVEntities.Instance.TUASACHes.Add(tuaSach);
                QLTVEntities.Instance.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        // Chỉnh sửa thông tin tựa sách
        public bool UpdTuaSach(int idTuaSach, string tenTuaSach, THELOAI theLoai, List<TACGIA> dsTacGia)
        {
            try
            {
                TUASACH tuaSach = QLTVEntities.Instance.TUASACHes.Find(idTuaSach);
                if (tuaSach == null) return false;
                if (tenTuaSach != null) tuaSach.TenTuaSach = tenTuaSach;
                if (theLoai != null)
                {
                    tuaSach.idTheLoai = theLoai.id;
                    tuaSach.THELOAI = theLoai;
                }
                if (dsTacGia != null) tuaSach.TACGIAs = dsTacGia;
                QLTVEntities.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }
        /// <summary>
        /// Xóa tựa sách
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DelTuaSach(int id)
        {
            using (var transaction = QLTVEntities.Instance.Database.BeginTransaction())
            {
                try
                {
                    TUASACH tuaSach = GetTuaSachById(id);
                    if (tuaSach == null) return false;
                    QLTVEntities.Instance.TUASACHes.Remove(tuaSach);
                    QLTVEntities.Instance.SaveChanges();
                    transaction.Commit();
                    return true;
                }
                catch
                {
                    transaction.Rollback();
                    return false;
                }
            }
        }
        // Cập nhật tình trạng sách (Ẩn tựa sách)
        public bool UpdAnTuaSach(int id, int data)
        {

            try
            {
                TUASACH tuaSach = QLTVEntities.Instance.TUASACHes.Find(id);
                tuaSach.DaAn = data;
                QLTVEntities.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }
    }
}
