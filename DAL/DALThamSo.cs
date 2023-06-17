using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALThamSo
    {
        private static DALThamSo instance;

        public static DALThamSo Instance
        {
            get
            {
                if (instance == null) instance = new DALThamSo();
                return instance;
            }
            set => instance = value;
        }

        public DALThamSo()
        {
            if (!QLTVEntities.Instance.THAMSOes.Any())
            {
                QLTVEntities.Instance.THAMSOes.Add(new THAMSO
                {
                    TuoiToiThieu = 18,
                    TuoiToiDa = 55,
                    ThoiHanThe = 6,
                    KhoangCachXuatBan = 8,
                    SoSachMuonToiDa = 5,
                    SoNgayMuonToiDa = 4,
                    DonGiaPhat = 1000,
                    AD_QDKTTienThu = 1
                });
                QLTVEntities.Instance.SaveChanges();
            }
        }
        public THAMSO GetAllThamSo()
        {

            return QLTVEntities.Instance.THAMSOes.First();
        }

        public bool UpdTuoiToiThieu(int tuoitt)
        {
            try
            {
                THAMSO ts = GetAllThamSo();
                ts.TuoiToiThieu = tuoitt;
                QLTVEntities.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }

        }
        public bool UpdTuoiToiDa(int tuoitd)
        {
            try
            {
                THAMSO ts = GetAllThamSo();
                ts.TuoiToiDa = tuoitd;
                QLTVEntities.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }

        public bool UpdThoiHanThe(int Hansd)
        {
            try
            {
                THAMSO ts = GetAllThamSo();
                ts.ThoiHanThe = Hansd;
                QLTVEntities.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }

        public bool UpdKhoangCachXB(int KcXB)
        {
            try
            {
                THAMSO ts = GetAllThamSo();
                ts.KhoangCachXuatBan = KcXB;
                QLTVEntities.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }

        }

        public bool UpdSoSachMuonToiDa(int SoSachMuonToiDa)
        {
            try
            {
                THAMSO ts = GetAllThamSo();
                ts.SoSachMuonToiDa = SoSachMuonToiDa;
                QLTVEntities.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }

        }

        public bool UpdSoNgayMuonToiDa(int SoNgayMuonToiDa)
        {
            try
            {
                THAMSO ts = GetAllThamSo();
                ts.SoNgayMuonToiDa = SoNgayMuonToiDa;
                QLTVEntities.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }

        }

        public bool UpdDonGiaPhat(int TienPhat)
        {
            try
            {
                THAMSO ts = GetAllThamSo();
                ts.DonGiaPhat = TienPhat;
                QLTVEntities.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }

        public bool UpdQDKTTienPhat(int QDKTTP)
        {
            try
            {
                THAMSO ts = GetAllThamSo();
                ts.AD_QDKTTienThu = QDKTTP;
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
