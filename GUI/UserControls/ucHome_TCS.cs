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

        private void comboTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void butFilTL_Click(object sender, EventArgs e)
        {
            List<SACH> Res = new List<SACH>();
            foreach (SACH sach in BUSSach.Instance.GetAllSach())
            {
                if (sach.TUASACH.THELOAI.TenTheLoai.Equals(comboTheLoai.SelectedText))
                    Res.Add(sach);
            }
            Binding(Res);
        }

        private void butFilTT_Click(object sender, EventArgs e)
        {
            int tt = comboTinhTrang.SelectedIndex;
            List<SACH> Res = new List<SACH>();
            foreach (SACH sach in BUSSach.Instance.GetAllSach())
                if (sach.DaAn == 0)
                {
                    if (sach.SoLuongConLai > 0 && tt == 0)
                    {
                        Res.Add(sach);
                    }
                    if (sach.SoLuongConLai <= 0 && tt == 1)
                        Res.Add(sach);
                }
            Binding(Res);
        }
    }
}
