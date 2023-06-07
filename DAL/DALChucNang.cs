using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALChucNang
    {
        private static DALChucNang instance;

        public static DALChucNang Instance
        {
            get
            {
                if (instance == null) instance = new DALChucNang();
                return instance;
            }
            set => instance = value;
        }

        public List<CHUCNANG> GetAllChucNang()
        {
            return QLTVEntities.Instance.CHUCNANGs.AsNoTracking().ToList();
        }

        public CHUCNANG GetChucNangById(int id)
        {
            return QLTVEntities.Instance.CHUCNANGs.Find(id);
        }

        public CHUCNANG GetChucNangByMa(string ma)
        {
            var res = QLTVEntities.Instance.CHUCNANGs.Where(c => c.MaChucNang == ma);
            return (res.Any() ? res.First() : null);
        }
    }
}
