using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUSCT_BCLuotMuonTheoTheLoai
    {
        private static BUSCT_BCLuotMuonTheoTheLoai instance;

        public static BUSCT_BCLuotMuonTheoTheLoai Instance
        {
            get
            {
                if (instance == null) instance = new BUSCT_BCLuotMuonTheoTheLoai();
                return instance;
            }
            set => instance = value;
        }
        public List<CT_BCLUOTMUONTHEOTHELOAI> GetAllCTBC()
        {
            return DALCT_BCLuotMuonTheoTheLoai.Instance.GetAllCTBC();
        }
        public CT_BCLUOTMUONTHEOTHELOAI GetCTBC(int idBC, int idTheLoai)
        {
            return DALCT_BCLuotMuonTheoTheLoai.Instance.GetCTBC(idBC, idTheLoai);
        }
        public string AddCT_BCLuotMuon(int id, int idTL, int month, int year)
        {
            int soLuot = 0;
            var dspm = DALPhieuMuonTra.Instance.FindTheoNgayMuon(null, month, year);
            foreach (var pm in dspm)
            {
                if (pm.CUONSACH.SACH.TUASACH.THELOAI.id == idTL) soLuot++;
            }

            if (DALCT_BCLuotMuonTheoTheLoai.Instance.AddCTBC(id, idTL, soLuot))
                return "";
            return "Lỗi";

        }
    }
}
