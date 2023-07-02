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
    public partial class fAddSachMoi : Form
    {
        public fAddSachMoi()
        {
            InitializeComponent();
            LoadTuaSach();
            btnCapNhat.Visible = false;
        }

        public SACH sach { get; set; }
        // Gọi tới để chỉnh sửa thông tin sách
        public fAddSachMoi(int i)
        {
            InitializeComponent();
            LoadTuaSach();
            sach = BUSSach.Instance.GetSachById(i);
            //Load dữ liệu
            comboTuaSach.SelectedItem = sach.TUASACH.TenTuaSach;
            txtNamXB.Text = sach.NamXB.ToString();
            txtNhaXB.Text = sach.NhaXB;
            txtDonGia.Text = sach.DonGia.ToString();
            //Unseen những trường không dùng đến
            txtSoLuongNhap.Visible = false;
            txtThanhtien.Visible = false;
            label6.Visible = false;
            label8.Visible = false;
            labelThanhTien.Visible = false;
            siticoneSeparator2.Visible = false;
            butOK.Visible = false;
        }

        private void LoadTuaSach()
        {
            List<string> listTuaSach = new List<string>();
            foreach(var p in BUSTuaSach.Instance.GetAllTuaSach())
            {
                listTuaSach.Add(p.TenTuaSach);
            }
            comboTuaSach.DataSource = listTuaSach;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void butOK_Click(object sender, EventArgs e)
        {
            TUASACH tuaSach = new TUASACH();
            foreach (var p in BUSTuaSach.Instance.GetAllTuaSach())
            {
                if (p.TenTuaSach.Equals(comboTuaSach.SelectedItem.ToString()))
                {
                    tuaSach = p;
                    break;
                }    
            }
            int s = BUSSach.Instance.AddSachMoi(tuaSach, int.Parse(txtDonGia.Text), int.Parse(txtNamXB.Text), txtNhaXB.Text);
            int ph = BUSPhieuNhapSach.Instance.AddPhieuNhap(DateTime.Now);
            BUSCTPhieuNhap.Instance.AddCtPhieuNhap(ph, s, int.Parse(txtDonGia.Text), int.Parse(txtSoLuongNhap.Text));
            this.Close();
        }

        private void txtSoLuongNhap_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSoLuongNhap.Text))
            {
                txtThanhtien.Text = "";
            }    
            else
            {
                txtThanhtien.Text = (int.Parse(txtDonGia.Text) * int.Parse(txtSoLuongNhap.Text)).ToString();
            }    
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string tentuasach = comboTuaSach.SelectedItem.ToString();
            foreach (var p in BUSTuaSach.Instance.GetAllTuaSach())
            {
                if (p.TenTuaSach.ToLower().Equals(tentuasach.ToLower()))
                {
                    if (BUSSach.Instance.UpdSach(sach.id, int.Parse(txtDonGia.Text), p, int.Parse(txtNamXB.Text), txtNhaXB.Text))
                    {
                        MessageBox.Show("Cập nhật thành công");
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật không thành công");
                        break;
                    }    
                }    
            }
            this.Close();
        }
    }
}
