using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.FORM
{
    public partial class fAddDocGia : Form
    {
        public fAddDocGia()
        {
            InitializeComponent();
            var listDG = BUSLoaiDocGia.Instance.GetAllLoaiDocGia();
            foreach (var item in listDG)
            {
                comboLoaiDG.Items.Add(item.TenLoaiDocGia);
            }
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            try
            {
                string loaidg = comboLoaiDG.SelectedItem.ToString();
                var list = BUSLoaiDocGia.Instance.GetAllLoaiDocGia();
                int id = -1;
                foreach(var p in list)
                {
                    if (p.TenLoaiDocGia.Equals(loaidg))
                    {
                        id = p.id;
                    }    
                }

                if (id > 0)
                {
                    // mặc định id nhóm người dùng là 3 (độc giả)
                    int idUser = BUSNguoiDung.Instance.AddNguoiDung(txtHoTen.Text, dateNgaySinh.Value, txtChucVu.Text, 
                                                       txtUsername.Text, txtUserpwd.Text, txtEmail.Text, 3);

                    BUSDocGia.Instance.AddDocGia(txtHoTen.Text, dateNgaySinh.Value, txtDiaChi.Text, DateTime.Now,
                                                 DateTime.Now.AddMonths(6), id, 0, idUser);

                    this.Close();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ");
            }
        }
    }
}
