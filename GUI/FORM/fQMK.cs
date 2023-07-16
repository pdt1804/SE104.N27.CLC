using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GUI
{
    public partial class fQMK : Form
    {
        private NGUOIDUNG usr;
        public fQMK()
        {
            InitializeComponent();
        }

        private void butGet_Click(object sender, EventArgs e)
        {
            if (txtUN.Text == "" || txtEMAIL.Text == "")
            {
                MessageBox.Show("Chưa điền đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            usr = BUSNguoiDung.Instance.GetNguoiDungByUsername(txtUN.Text.ToString());
            int code = sendEmail(usr.EMAIL);
        }

        private int sendEmail(string mail)
        {
            Random random = new Random();
            int code = random.Next(100000, 1000000);
            MailMessage mailMessage = new MailMessage();
            mailMessage.To.Add(mail);
            mailMessage.From = new MailAddress("sonle102003@gmail.com");
            mailMessage.Subject = "Gửi mã xác nhận mật khẩu";
            mailMessage.Body = code.ToString();

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.EnableSsl = true;
            smtpClient.Port = 587;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.Credentials = new NetworkCredential("sonle102003@gmail.com", "ykzqjdquybpdbzkt");
            try
            {
                smtpClient.Send(mailMessage);
                MessageBox.Show("Đã gửi mã xác nhận");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return code;
        }
    }
}
