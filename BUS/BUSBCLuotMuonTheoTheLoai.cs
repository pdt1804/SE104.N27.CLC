using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUSBCLuotMuonTheoTheLoai
    {
        private static BUSBCLuotMuonTheoTheLoai instance;

        public static BUSBCLuotMuonTheoTheLoai Instance
        {
            get
            {
                if (instance == null) instance = new BUSBCLuotMuonTheoTheLoai();
                return instance;
            }
            set => instance = value;
        }
        public List<BCLUOTMUONTHEOTHELOAI> GetAllBaoCao()
        {
            return DALBCLuotMuonTheoTheLoai.Instance.GetAllBaoCao();
        }
        public BCLUOTMUONTHEOTHELOAI GetBaoCaoById(int id)
        {
            return DALBCLuotMuonTheoTheLoai.Instance.GetBaoCaoById(id);
        }public BCLUOTMUONTHEOTHELOAI GetBaoCaoByMa(int ma)
        {
            return DALBCLuotMuonTheoTheLoai.Instance.GetBaoCaoById(Convert.ToInt32(ma));
        }
        public BCLUOTMUONTHEOTHELOAI FindBaoCaoByDate(int month, int year)
        {
            var ds = DALBCLuotMuonTheoTheLoai.Instance.FindBaoCaoByDate(month, year);
            if (!ds.Any()) return null;
            return ds.First();
        }
        public string AddBaoCao(int thang, int nam)
        {
            if (nam > DateTime.Today.Year || (nam == DateTime.Today.Year && thang > DateTime.Today.Month))
                return "Thời gian không hợp lệ";
            int id = DALBCLuotMuonTheoTheLoai.Instance.AddBaoCao(thang, nam);
            if (id != -1)
            {
                List<THELOAI> ltl = DALTheLoai.Instance.GetAllTheLoai();
                foreach (THELOAI tl in ltl)
                {
                    string err = BUSCT_BCLuotMuonTheoTheLoai.Instance.AddCT_BCLuotMuon(id, tl.id, thang, nam);
                    if (err != "") return err;
                }

                DALBCLuotMuonTheoTheLoai.Instance.Compute(id);
                return "";
            }
            else return "Không thể lập báo cáo";
        }
        public string DelBC(string Mabc)
        {
            BCLUOTMUONTHEOTHELOAI bc = DALBCLuotMuonTheoTheLoai.Instance.GetBaoCaoByMa(Mabc);
            if (bc == null)
            {
                return "Mã báo cáo không hợp lệ";
            }
            if (DALBCLuotMuonTheoTheLoai.Instance.DelBaoCao(bc.id))
                return "";
            return "Lỗi khi xoá báo cáo ";
        }
    }
}
