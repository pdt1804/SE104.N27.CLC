using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class BUSThamSo
    {
        private static BUSThamSo instance;

        public static BUSThamSo Instance
        {
            get
            {
                if (instance == null) instance = new BUSThamSo();
                return instance;
            }
            set => instance = value;
        }
        public THAMSO GetAllThamSo()
        {
            return DALThamSo.Instance.GetAllThamSo();
        }
        public string UpdThoiHanThe(int Hansd)
        {
            if (DALThamSo.Instance.UpdThoiHanThe(Hansd))
                return "";
            return "Lỗi";
        }
        public string UpdKhoangCachXB(int KcXB)
        {
            if (DALThamSo.Instance.UpdKhoangCachXB(KcXB))
                return "";
            return "Lỗi";
        }
        public string UpTuoiToiDa(int tuoitd)
        {
            if (tuoitd < DALThamSo.Instance.GetAllThamSo().TuoiToiThieu) 
                return "Tuổi tối đa không được nhỏ hơn tuổi tối thiểu.";
            if (DALThamSo.Instance.UpdTuoiToiDa(tuoitd))
                return "";
            return "Lỗi";
        }
        public string UpdTuoiToiThieu(int tuoitt)
        {
            if (tuoitt > DALThamSo.Instance.GetAllThamSo().TuoiToiDa) 
                return "Tuổi tối thiểu không được lớn hơn tuổi tối đa.";

            if (DALThamSo.Instance.UpdTuoiToiThieu(tuoitt))
                return "";
            return "Lỗi";
        }
        public string UpdSoNgayMuonToiDa(int SoNgayMuonToiDa)
        {
            if (DALThamSo.Instance.UpdSoNgayMuonToiDa(SoNgayMuonToiDa))
                return "";
            return "Lỗi";
        }
        public string UpdSoSachMuonToiDa(int SoSachMuonToiDa)
        {
            if (DALThamSo.Instance.UpdSoSachMuonToiDa(SoSachMuonToiDa))
                return "";
            return "Lỗi";
        }
        public string UpdQDKTTienPhat(int QDKTTP)
        {
            if (DALThamSo.Instance.UpdQDKTTienPhat(QDKTTP))
                return "";
            return "Lỗi";
        }
        public string UpdDonGiaPhat(int TienPhat)
        {
            if (DALThamSo.Instance.UpdDonGiaPhat(TienPhat))
                return "";
            return "Lỗi";
        }
    }
}
