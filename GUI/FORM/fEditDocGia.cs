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

namespace GUI
{
    public partial class fEditDocGia : Form
    {
        private static int id;
        public fEditDocGia(int _id)
        {
            InitializeComponent();
            id = _id;
            Binding();
        }
        private void Binding()
        {
            try
            {
                var dg = BUSDocGia.Instance.GetDocGiaById(id);
                var dgnd = BUSNguoiDung.Instance.GetNguoiDungById(dg.ID);
                labelMaDG.Text = "Mã Độc Giả: " + dg.MaDocGia;
                txtHoTen.Text = dg.TenDocGia;
                if (dg.NgaySinh != null) dateNgaySinh.Value = dg.NgaySinh;
                txtDiaChi.Text = dg.DiaChi;
                txtEmail.Text = dgnd.EMAIL;
                labelNgayLap.Text = dg.NgayLapThe.Date.ToShortDateString();
                labelHan.Text = dg.NgayHetHan.ToShortDateString();
                List<LOAIDOCGIA> LoaiDocGiaList;
                LoaiDocGiaList = BUSLoaiDocGia.Instance.GetAllLoaiDocGia();
                this.comboLoaiDG.DataSource = LoaiDocGiaList;
                comboLoaiDG.DisplayMember = "TenLoaiDocGia";
                comboLoaiDG.ValueMember = "id";
                comboLoaiDG.SelectedIndex = comboLoaiDG.FindString(dg.LOAIDOCGIA.TenLoaiDocGia);
            }
            catch
            {

            }
           
        }

    }
}
