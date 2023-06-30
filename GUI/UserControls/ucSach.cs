using BUS;
using DTO;
using GUI;
using System;
using System.Collections.Generic;
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
            comboTinhTrang.Text = "Tất cả";
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
                SachGrid.Rows.Add(0, sach.id, sach.MaSach, sach.TUASACH.MaTuaSach, sach.TUASACH.TenTuaSach, sach.NamXB, sach.NhaXB, sach.SoLuong, sach.SoLuongConLai, sach.DaAn);
            }

        }
        private void ucSach_Load(object sender, EventArgs e)
        {
            Binding(BUSSach.Instance.GetAllSach());
        }

        private void butRefresh_Click(object sender, EventArgs e)
        {
            txtMaSach.Text = "";
        }

        private void comboTinhTrang_SelectedValueChanged(object sender, EventArgs e)
        {
            string selectedTT = comboTinhTrang.SelectedItem.ToString();
            if (selectedTT.Equals("Hết"))
            {
                List<SACH> listSachHet = new List<SACH>();
                foreach(var p in SachList)
                {
                    if (p.SoLuongConLai == 0)
                    {
                        listSachHet.Add(p);
                    }    
                }
                Binding(listSachHet);
            }   
            else if (selectedTT.Equals("Còn"))
            {
                List<SACH> listSachChuaHet = new List<SACH>();
                foreach (var p in SachList)
                {
                    if (p.SoLuongConLai > 0)
                    {
                        listSachChuaHet.Add(p);
                    }
                }
                Binding(listSachChuaHet);
            }
            else
            {
                SachList = BUSSach.Instance.GetAllSach();
                Binding(SachList);
            }    
        }
    }
}
