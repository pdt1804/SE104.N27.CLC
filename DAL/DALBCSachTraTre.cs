﻿using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class DALBCSachTraTre
    {
        private static DALBCSachTraTre instance;

        public static DALBCSachTraTre Instance
        {
            get
            {
                if (instance == null) instance = new DALBCSachTraTre();
                return instance;
            }
            set => instance = value;
        }

        public List<BCSACHTRATRE> GetAllBaoCao()
        {
            return QLTVEntities.Instance.BCSACHTRATREs.AsNoTracking().ToList();
        }

        public BCSACHTRATRE GetBaoCao(DateTime ngayBaoCao, int idCuonSach)
        {
            return QLTVEntities.Instance.BCSACHTRATREs.Find(new object[] { ngayBaoCao, idCuonSach });
        }

        public List<BCSACHTRATRE> FindBaoCaoByDate(DateTime ngayBC)
        {
            return QLTVEntities.Instance.BCSACHTRATREs.AsNoTracking().Where(b =>
            b.Ngay.Day == ngayBC.Day && b.Ngay.Month == ngayBC.Month && b.Ngay.Year == ngayBC.Year).ToList();
        }

        public List<BCSACHTRATRE> FindBaoCaoByCuonSach(int idCuonSach)
        {
            return QLTVEntities.Instance.BCSACHTRATREs.AsNoTracking().Where(b => b.idCuonSach == idCuonSach).ToList();
        }

        public bool AddBaoCao(DateTime ngayBC, int idCuonSach, DateTime ngayMuon, int soNgayTre)
        {
            try
            {
                var bc = new BCSACHTRATRE
                {
                    Ngay = ngayBC,
                    idCuonSach = idCuonSach,
                    CUONSACH = DALCuonSach.Instance.GetCuonSachById(idCuonSach),
                    NgayMuon = ngayMuon,
                    SoNgayTre = soNgayTre
                };
                QLTVEntities.Instance.BCSACHTRATREs.Add(bc);
                QLTVEntities.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }

        public BCSACHTRATRE FindBaoCao(int day, int month, int year, int idCS)
        {
            var res =  QLTVEntities.Instance.BCSACHTRATREs.Where(b => b.Ngay.Day == day
            && b.Ngay.Month == month 
            && b.Ngay.Year == year
            && b.idCuonSach == idCS
            );
            return res.FirstOrDefault();
        }

        public bool DelBaoCao(int day, int month, int year, int idCS)
        {
            try
            {
                var bc = FindBaoCao(day, month, year, idCS);
                if (bc == null) return false;
                QLTVEntities.Instance.BCSACHTRATREs.Remove(bc);
                QLTVEntities.Instance.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
