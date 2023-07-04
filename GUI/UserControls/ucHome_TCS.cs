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
        public ucHome_TCS()
        {
            InitializeComponent();
            Binding(BUSSach.Instance.GetAllSach());
            comboTheLoai.DataSource = BUSTheLoai.Instance.GetAllTheLoai();
            comboTheLoai.ValueMember = "id";
            comboTheLoai.DisplayMember = "TenTheLoai";
            List<string> TinhTrangList = new List<string> { "Còn", "Hết" };
            comboTinhTrang.DataSource = TinhTrangList;
        }

        private void Binding(List<SACH> sACHes)
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
    }
}
