﻿using DTO;
using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.UserControls;
using GUI.Print;

namespace GUI.FORM
{
    public partial class fPhieuThu : Form
    {
        private DOCGIA docgia;
        private P_PhieuThu report;
        public fPhieuThu()
        {
            InitializeComponent();
            init();
        }
        private int TienThu;
        private void init()
        {
            TienThu = 0;
            dateNgayLap.Value = DateTime.Now.Date;
            comboDocGia.DataSource = BUSDocGia.Instance.GetAllDocGia();
            comboDocGia.ValueMember = "ID";
            comboDocGia.DisplayMember = "MaDocGia";
            comboDocGia.SelectedIndex = 0;
            docgia = BUSDocGia.Instance.GetDocGiaById(Convert.ToInt32(comboDocGia.SelectedValue));
            labelNoHienTai.Text = docgia.TongNoHienTai.ToString();
        }

        private void textTienThu_TextChanged(object sender, EventArgs e)
        {
            if (textTienThu.Text == "")
            {
                labelNoMoi.Text = "";
                return;
            }
            try
            {
                TienThu = Convert.ToInt32(textTienThu.Text);
                Console.WriteLine("TienThu");
                Console.WriteLine(TienThu);
            }
            catch
            {
                textTienThu.Text = "";
                MessageBox.Show("Số tiền thu sai format", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            THAMSO thamso = BUSThamSo.Instance.GetAllThamSo();
            if (thamso.AD_QDKTTienThu == 1 && TienThu > docgia
                .TongNoHienTai)
            {
                textTienThu.Text = "";
                MessageBox.Show("Số tiền thu vượt quá quy định", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                labelNoMoi.Text = labelNoHienTai.Text;
                return;
            }
            labelNoMoi.Text = ((int)docgia.TongNoHienTai - (int)TienThu).ToString();
        }

        private void comboDocGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            docgia = BUSDocGia.Instance.GetDocGiaById(Convert.ToInt32(comboDocGia.SelectedValue));
            labelHoten.Text = docgia.TenDocGia.ToString();
            labelNoHienTai.Text = docgia.TongNoHienTai.ToString();
            TienThu = 0;
            labelNoMoi.Text = "";
            textTienThu.Text = "";
        }

        private void Print(int idPT, string maDG, string tenDG, string soTT, string noMoi, string ngaythu)
        {
            report = new P_PhieuThu(idPT, maDG, tenDG, soTT, noMoi, ngaythu);
            report.PrintReport();
        }
        private void butSave_Click(object sender, EventArgs e)
        {
            if(textTienThu.Text == "")
            {
                MessageBox.Show("Chưa nhập số tiền thu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            TienThu = Convert.ToInt32(textTienThu.Text);
            
            if(dateNgayLap.Value> DateTime.Now.Date || dateNgayLap.Value.Date < docgia.NgayLapThe)
            {
                MessageBox.Show("Ngày lập không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Console.WriteLine(TienThu);
            int result = BUSPhieuThu.Instance.AddPhieuThu(docgia.ID, TienThu, dateNgayLap.Value.Date);

            if (result == -1)
            {
                MessageBox.Show("Thêm phiếu thu không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Thêm phiếu thu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            Print(result, comboDocGia.Text, labelHoten.Text, textTienThu.Text, labelNoMoi.Text, dateNgayLap.Text);
        }
    }
}
