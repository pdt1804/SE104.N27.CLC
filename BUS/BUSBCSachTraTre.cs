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
            return DALBCSachTraTre.Instance.FindBaoCaoByDate(ngayBC);
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
                if (pmt.NgayTra == null)
                {
                    int SoNgayTraTre = ((TimeSpan)(NgayBC - pmt.HanTra)).Days;
                    DALBCSachTraTre.Instance.AddBaoCao(NgayBC, (int)pmt.idCuonSach, (DateTime)pmt.NgayMuon, SoNgayTraTre);
                }
            }
            return "";
        }

        public bool DelBaoCao(DateTime ngayBC, int idCuonSach)
        {
            if (!DALBCSachTraTre.Instance.DelBaoCao(ngayBC, idCuonSach))
            {
                MessageBox.Show("Xoá báo cáo không thành công");
                return false;
            }
            return true;
        }
    }
}
