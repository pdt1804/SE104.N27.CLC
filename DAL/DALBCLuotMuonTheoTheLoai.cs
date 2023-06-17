using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALBCLuotMuonTheoTheLoai
    {
        private static DALBCLuotMuonTheoTheLoai instance;

        public static DALBCLuotMuonTheoTheLoai Instance
        {
            get
            {
                if (instance == null) instance = new DALBCLuotMuonTheoTheLoai();
                return instance;
            }
            set => instance = value;
        }

        public List<BCLUOTMUONTHEOTHELOAI> GetAllBaoCao()
        {
            return QLTVEntities.Instance.BCLUOTMUONTHEOTHELOAIs.AsNoTracking().ToList();
        }

        public BCLUOTMUONTHEOTHELOAI GetBaoCaoById(int id)
        {
            return QLTVEntities.Instance.BCLUOTMUONTHEOTHELOAIs.Find(id);
        }

        public BCLUOTMUONTHEOTHELOAI GetBaoCaoByMa(string ma)
        {
            var res = QLTVEntities.Instance.BCLUOTMUONTHEOTHELOAIs.AsNoTracking().Where(b => b.MaBaoCao == ma);
            return (res.Any() ? res.First() : null);
        }

        public List<BCLUOTMUONTHEOTHELOAI> FindBaoCaoByDate(int? thang, int? nam)
        {
            var res = GetAllBaoCao();
            if (thang != null) res = res.Where(b => b.Thang == thang).ToList();
            if (nam != null) res = res.Where(b => b.Nam == nam).ToList();
            return res;
        }

        public int AddBaoCao(int thang, int nam)
        {
            try
            {
                var bc = new BCLUOTMUONTHEOTHELOAI
                {
                    Thang = thang,
                    Nam = nam,
                    TongSoLuotMuon = 0
                };
                QLTVEntities.Instance.BCLUOTMUONTHEOTHELOAIs.Add(bc);
                QLTVEntities.Instance.SaveChanges();

                return bc.id;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return -1;
            }
        }

        public bool Compute(int id)
        {
            var bc = GetBaoCaoById(id);
            if (bc == null) return false;
            int sum = 0;

            foreach (var ct in bc.CT_BCLUOTMUONTHEOTHELOAI)
            {
                sum += (int)ct.SoLuotMuon;
            }
            bc.TongSoLuotMuon = sum;

            foreach (var ct in bc.CT_BCLUOTMUONTHEOTHELOAI)
            {
                if (sum != 0) ct.TiLe = (decimal)ct.SoLuotMuon / sum;
                else ct.TiLe = 0;
            }
            QLTVEntities.Instance.SaveChanges();
            return true;
        }

        public bool DelBaoCao(int id)
        {
            try
            {
                var bc = GetBaoCaoById(id);
                if (bc == null) return false;

                QLTVEntities.Instance.BCLUOTMUONTHEOTHELOAIs.Remove(bc);
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
