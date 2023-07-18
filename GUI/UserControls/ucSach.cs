using BUS;
using DTO;
using GUI;
using GUI.FORM;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace GUI.UserControls
{
    public partial class ucSach : UserControl
    {
        public ucSach()
        {
            SachList = new List<SACH> (BUSSach.Instance.GetAllSach());
            InitializeComponent();
            Binding(SachList);
            comboTinhTrang.SelectedItem = "Tất cả";
            comboTinhTrang.Items.Add("Tất cả");
            comboTinhTrang.Items.Add("Còn");
            comboTinhTrang.Items.Add("Hết");
        }
        private List<SACH> SachList;


        public void Binding(List<SACH> SachList)
        {
            SachGrid.Rows.Clear();
            foreach (SACH sach in SachList)
            {
                SachGrid.Rows.Add(sach.id, sach.MaSach, sach.TUASACH.MaTuaSach, sach.TUASACH.TenTuaSach, sach.NamXB, sach.NhaXB, sach.SoLuong, sach.SoLuongConLai);
            }

        }
        private void ucSach_Load(object sender, EventArgs e)
        {
            Binding(BUSSach.Instance.GetAllSach());
        }

        private void butRefresh_Click(object sender, EventArgs e)
        {
            Binding(BUSSach.Instance.GetAllSach());
            txtMaSach.Text = "";
        }

        private void comboTinhTrang_SelectedValueChanged(object sender, EventArgs e)
        {
            SachList.Clear();
            string selectedTT = comboTinhTrang.SelectedItem.ToString();
            if (selectedTT.Equals("Hết"))
            {
                foreach(var p in BUSSach.Instance.GetAllSach())
                {
                    if (p.SoLuongConLai == 0)
                    {
                        SachList.Add(p);
                    }    
                }
                Binding(SachList);
            }   
            else if (selectedTT.Equals("Còn"))
            {
                foreach (var p in BUSSach.Instance.GetAllSach())
                {
                    if (p.SoLuongConLai > 0)
                    {
                        SachList.Add(p);
                    }
                }
                Binding(SachList);
            }
            else
            {
                SachList = BUSSach.Instance.GetAllSach();
                Binding(SachList);
            }    
        }

        private void txtMaSach_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMaSach.Text))
            {
                Binding(SachList);
            }
            else
            {
                List<SACH> list = new List<SACH>();
                foreach (SACH sach in SachList)
            {
                if (sach.MaSach.ToLower().Contains(txtMaSach.Text.ToLower()) || sach.TUASACH.TenTuaSach.ToLower().Contains(txtMaSach.Text.ToLower()) || sach.TUASACH.MaTuaSach.ToLower().Contains(txtMaSach.Text.ToLower()))
                {
                    list.Add(sach);
                }
            }
                Binding(list);
            }
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            fAddSachMoi f = new fAddSachMoi();
            f.ShowDialog();
            Binding(BUSSach.Instance.GetAllSach());
            comboTinhTrang.Text = "Tất cả";
            txtMaSach.Text = "";
        }

        private void butAddOld_Click(object sender, EventArgs e)
        {
            fAddSachDaCo f = new fAddSachDaCo();
            f.ShowDialog();
            Binding(BUSSach.Instance.GetAllSach());
            comboTinhTrang.Text = "Tất cả";
            txtMaSach.Text = "";
        }
    }
}
