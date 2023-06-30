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
            InitializeComponent();
            Binding(BUSSach.Instance.GetAllSach());
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


        
    }
}
