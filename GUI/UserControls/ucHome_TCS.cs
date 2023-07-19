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

namespace GUI.UserControls
{
    public partial class ucHome_TCS : UserControl
    {
        public List<SACH> list { get; set; }

        public ucHome_TCS()
        {
            InitializeComponent();
            list = new List<SACH>();
            list = BUSSach.Instance.GetAllSach();
            Binding(list);
            List<string> listTL = new List<string>();
            listTL.Add("Tất cả");
            foreach (var p in BUSTheLoai.Instance.GetAllTheLoai())
            {
                listTL.Add(p.TenTheLoai);
            }    
            comboTheLoai.DataSource = listTL;
            comboTheLoai.DisplayMember = "TenTheLoai";
            List<string> TinhTrangList = new List<string> {"Tất cả", "Còn", "Hết" };
            comboTinhTrang.DataSource = TinhTrangList;
        }

        private void Binding(List<SACH> SachList)
        {
            SachGrid.Rows.Clear();
            foreach (SACH sach in SachList)
                if (sach.DaAn == 0)
                {
                    string tacgia = "";
                    foreach (TACGIA tg in sach.TUASACH.TACGIAs)
                        tacgia += tg.TenTacGia + ", ";
                    if (tacgia != "")
                        tacgia = tacgia.Remove(tacgia.Length - 2, 2);
                    string Con = (sach.SoLuongConLai > 0) ? "Còn" : "Hết";
                    SachGrid.Rows.Add(sach.MaSach, sach.TUASACH.TenTuaSach, sach.TUASACH.THELOAI.TenTheLoai, sach.NamXB, sach.NhaXB, tacgia, Con);
                }
        }

        private void comboTheLoai_SelectedValueChanged(object sender, EventArgs e)
        {
            if(comboTheLoai.SelectedIndex == 0)
            {
                Binding(BUSSach.Instance.GetAllSach());
                return;
            }
            List<SACH> Res = new List<SACH>();
            foreach (SACH sach in BUSSach.Instance.GetAllSach())
            {
                if (sach.TUASACH.THELOAI.TenTheLoai.Equals(comboTheLoai.SelectedItem.ToString()))
                    Res.Add(sach);
            }
            Binding(Res);
        }

        private void comboTinhTrang_SelectedValueChanged(object sender, EventArgs e)
        {
            int tt = comboTinhTrang.SelectedIndex;
            if (tt == 0)
            {
                Binding(BUSSach.Instance.GetAllSach());
                return;
            }
            List<SACH> Res = new List<SACH>();
            foreach (SACH sach in BUSSach.Instance.GetAllSach())
            {
                if (tt == 1 && sach.SoLuongConLai > 0)
                {
                    Res.Add(sach);
                }
                if (tt == 2 && sach.SoLuongConLai <= 0)
                    Res.Add(sach);
            }

            Binding(Res);
        }

        private void txtMaSach_TextChanged(object sender, EventArgs e)
        {
            List<SACH> Res = new List<SACH>();
            string pat = txtMaSach.Text.ToLower();

            foreach (SACH sach in BUSSach.Instance.GetAllSach())
            {
                if (sach.TUASACH.TenTuaSach.ToLower().Contains(pat) ||
                     sach.MaSach.ToLower().Contains(pat) ||
                     sach.NhaXB.ToLower().Contains(pat) ||
                     sach.NamXB.ToString().Contains(pat))
                    Res.Add(sach);
                else
                    foreach (TACGIA tg in sach.TUASACH.TACGIAs)
                        if (tg.TenTacGia.ToLower().Contains(pat))
                            Res.Add(sach);
            }
            Binding(Res);
        }

        private void butRefresh_Click(object sender, EventArgs e)
        {
            Binding(BUSSach.Instance.GetAllSach());
            txtMaSach.Text = "";
        }
    }
}
