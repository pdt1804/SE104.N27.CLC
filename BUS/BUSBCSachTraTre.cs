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

        public bool AddBaoCao(DateTime ngayBC, int idCuonSach, DateTime ngayMuon, int soNgayTre)
        {
            if (!DALBCSachTraTre.Instance.AddBaoCao(ngayBC, idCuonSach, ngayMuon, soNgayTre))
            {
                MessageBox.Show("Thêm báo cáo không thành công");
                return false;
            }    
            else
            {
                MessageBox.Show("Thêm báo cáo thành công");
                return false;
            }    
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
