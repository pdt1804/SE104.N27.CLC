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
    public class BUSBCSachTraTre
    {
        private static BUSBCSachTraTre instance;

        public static BUSBCSachTraTre Instance
        {
            get { if (instance == null) Instance = new BUSBCSachTraTre(); return instance; }
            set { instance = value; }
        }

        public List<BCSACHTRATRE> GetAllBaoCao()
        {
            return DALBCSachTraTre.Instance.GetAllBaoCao();
        }

        public BCSACHTRATRE GetBaoCao(DateTime ngayBaoCao, int idCuonSach)
        {
            BCSACHTRATRE baocao = DALBCSachTraTre.Instance.GetBaoCao(ngayBaoCao, idCuonSach);
            if (baocao == null) return null;
            else return baocao;
        }

        public List<BCSACHTRATRE> FindBaoCaoByDate(DateTime ngayBC)
        {
            List<BCSACHTRATRE> lbc = DALBCSachTraTre.Instance.FindBaoCaoByDate(ngayBC);
            if (lbc.Count == 0) return null;
            return lbc;
        }

        public List<BCSACHTRATRE> FindBaoCaoByCuonSach(int idCuonSach)
        {
            return DALBCSachTraTre.Instance.FindBaoCaoByCuonSach(idCuonSach);
        }

        public string AddBaoCao(DateTime NgayBC)
        {
            if (NgayBC > DateTime.Now) return "Ngày báo cáo không hợp lệ";
            List<PHIEUMUONTRA> lpmt = DALPhieuMuonTra.Instance.FindPhieuMuonTre(NgayBC);
            if (!lpmt.Any()) return "Không có sách trả trễ trong ngày này";
            foreach (PHIEUMUONTRA pmt in lpmt)
            {
                int SoNgayTraTre;
                if (pmt.NgayTra == null)
                {
                    SoNgayTraTre = ((TimeSpan)(NgayBC - pmt.HanTra)).Days;
                }
                else
                {
                    SoNgayTraTre = ((TimeSpan)(pmt.NgayTra - pmt.HanTra)).Days;
                }
                    DALBCSachTraTre.Instance.AddBaoCao(NgayBC, (int)pmt.idCuonSach, (DateTime)pmt.NgayMuon, SoNgayTraTre);
            }
            return "";
        }

        public bool DelBaoCao(DateTime ngayBC, int idCS)
        {
            int Day = ngayBC.Day;
            int Month = ngayBC.Month;
            int Year = ngayBC.Year;
            if (!DALBCSachTraTre.Instance.DelBaoCao(Day, Month, Year, idCS))
            {
                return false;
            }
            return true;
        }
    }
}
