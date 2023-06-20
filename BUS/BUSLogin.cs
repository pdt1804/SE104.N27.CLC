using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUSLogin
    {
        private static BUSLogin instance;
        public static BUSLogin Instance
        {
            get
            {
                if (instance == null) instance = new BUSLogin();
                return instance;
            }
            set => instance = value;
        }

        public int checkValidLogin(string usrname, string usrpwd)
        { 
            foreach (var user in DALNguoiDung.Instance.GetAllNguoiDung())
            {
                if (user.TenDangNhap.Equals(usrname) && user.MatKhau.Equals(usrpwd))
                {
                    return user.id;
                }
            }
            return -1;
        }
    }
}
