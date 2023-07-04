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
                if (sach.TUASACH.THELOAI.TenTheLoai.Equals(comboTheLoai.SelectedItem.ToString()))
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

        private void comboTheLoai_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboTheLoai.SelectedItem.ToString().Equals("Tất cả") == true && comboTinhTrang.SelectedItem.ToString().Equals("Tất cả") == true)
            {
                list = BUSSach.Instance.GetAllSach();
                Binding(list);
            }
            else if (comboTheLoai.SelectedItem.ToString().Equals("Tất cả") == false && comboTinhTrang.SelectedItem.ToString().Equals("Tất cả") == true)
            {
                if (String.IsNullOrEmpty(comboTheLoai.SelectedItem.ToString()))
                {
                    list = BUSSach.Instance.GetAllSach();
                    Binding(list);
                }
                else
                {
                    list.Clear();
                    foreach (var p in BUSSach.Instance.GetAllSach())
                    {
                        if (p.TUASACH.THELOAI.TenTheLoai.ToLower().Equals(comboTheLoai.SelectedItem.ToString().ToLower()))
                        {
                            list.Add(p);
                        }
                    }
                    Binding(list);
                }
            }
            else if (comboTheLoai.SelectedItem.ToString().Equals("Tất cả") == true && comboTinhTrang.SelectedItem.ToString().Equals("Tất cả") == false)
            {
                if (String.IsNullOrEmpty(comboTinhTrang.SelectedItem.ToString()))
                {
                    list = BUSSach.Instance.GetAllSach();
                    Binding(list);
                }
                else
                {
                    if (comboTinhTrang.SelectedItem.ToString().Contains("n"))
                    {
                        list.Clear();
                        foreach (var p in BUSSach.Instance.GetAllSach())
                        {
                            if (p.SoLuongConLai > 0)
                            {
                                list.Add(p);
                            }
                        }
                        Binding(list);
                    }
                    else
                    {
                        list.Clear();
                        foreach (var p in BUSSach.Instance.GetAllSach())
                        {
                            if (p.SoLuongConLai == 0)
                            {
                                list.Add(p);
                            }
                        }
                        Binding(list);
                    }
                }
            }
            else if (comboTheLoai.SelectedItem.ToString().Equals("Tất cả") == false && comboTinhTrang.SelectedItem.ToString().Equals("Tất cả") == false)
            {
                if (String.IsNullOrEmpty(comboTheLoai.SelectedItem.ToString()))
                {
                    if (String.IsNullOrEmpty(comboTinhTrang.SelectedItem.ToString()))
                    {
                        list = BUSSach.Instance.GetAllSach();
                        Binding(list);
                    }
                    else
                    {
                        if (comboTinhTrang.SelectedItem.ToString().Contains("n"))
                        {
                            list.Clear();
                            foreach (var p in BUSSach.Instance.GetAllSach())
                            {
                                if (p.SoLuongConLai > 0)
                                {
                                    list.Add(p);
                                }
                            }
                            Binding(list);
                        }
                        else
                        {
                            list.Clear();
                            foreach (var p in BUSSach.Instance.GetAllSach())
                            {
                                if (p.SoLuongConLai == 0)
                                {
                                    list.Add(p);
                                }
                            }
                            Binding(list);
                        }
                    }
                }
                else if (!String.IsNullOrEmpty(comboTheLoai.SelectedItem.ToString()))
                {
                    if (String.IsNullOrEmpty(comboTinhTrang.SelectedItem.ToString()) == true)
                    {
                        list.Clear();
                        foreach (var p in BUSSach.Instance.GetAllSach())
                        {
                            if (p.TUASACH.THELOAI.TenTheLoai.ToLower().Equals(comboTheLoai.SelectedItem.ToString().ToLower()))
                            {
                                list.Add(p);
                            }
                        }
                        Binding(list);
                    }
                    else
                    {
                        if (comboTinhTrang.SelectedItem.ToString().Contains("n"))
                        {
                            list.Clear();
                            foreach (var p in BUSSach.Instance.GetAllSach())
                            {
                                if (p.TUASACH.THELOAI.TenTheLoai.ToLower().Equals(comboTheLoai.SelectedItem.ToString().ToLower()) == true && p.SoLuongConLai > 0)
                                {
                                    list.Add(p);
                                }
                            }
                            Binding(list);
                        }
                        else
                        {
                            list.Clear();
                            foreach (var p in BUSSach.Instance.GetAllSach())
                            {
                                if (p.TUASACH.THELOAI.TenTheLoai.ToLower().Equals(comboTheLoai.SelectedItem.ToString().ToLower()) == true && p.SoLuongConLai == 0)
                                {
                                    list.Add(p);
                                }
                            }
                            Binding(list);
                        }
                    }
                }
            }
            else
            {
                list = BUSSach.Instance.GetAllSach();
                Binding(list);
            }
        }

        private void comboTinhTrang_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboTheLoai.SelectedItem.ToString().Equals("Tất cả") == true && comboTinhTrang.SelectedItem.ToString().Equals("Tất cả") == true)
            {
                list = BUSSach.Instance.GetAllSach();
                Binding(list);
            }
            else if (comboTheLoai.SelectedItem.ToString().Equals("Tất cả") == false && comboTinhTrang.SelectedItem.ToString().Equals("Tất cả") == true)
            {
                if (String.IsNullOrEmpty(comboTheLoai.SelectedItem.ToString()))
                {
                    list = BUSSach.Instance.GetAllSach();
                    Binding(list);
                }
                else
                {
                    list.Clear();
                    foreach (var p in BUSSach.Instance.GetAllSach())
                    {
                        if (p.TUASACH.THELOAI.TenTheLoai.ToLower().Equals(comboTheLoai.SelectedItem.ToString().ToLower()))
                        {
                            list.Add(p);
                        }
                    }
                    Binding(list);
                }
            }
            else if (comboTheLoai.SelectedItem.ToString().Equals("Tất cả") == true && comboTinhTrang.SelectedItem.ToString().Equals("Tất cả") == false)
            {
                if (String.IsNullOrEmpty(comboTinhTrang.SelectedItem.ToString()))
                {
                    list = BUSSach.Instance.GetAllSach();
                    Binding(list);
                }
                else
                {
                    if (comboTinhTrang.SelectedItem.ToString().ToLower().Contains("n"))
                    {
                        list.Clear();
                        foreach (var p in BUSSach.Instance.GetAllSach())
                        {
                            if (p.SoLuongConLai > 0)
                            {
                                list.Add(p);
                            }
                        }
                        Binding(list);
                    }
                    else
                    {
                        list.Clear();
                        foreach (var p in BUSSach.Instance.GetAllSach())
                        {
                            if (p.SoLuongConLai == 0)
                            {
                                list.Add(p);
                            }
                        }
                        Binding(list);
                    }
                }
            }
            else if (comboTheLoai.SelectedItem.ToString().Equals("Tất cả") == false && comboTinhTrang.SelectedItem.ToString().Equals("Tất cả") == false)
            {
                if (String.IsNullOrEmpty(comboTheLoai.SelectedItem.ToString()))
                {
                    if (String.IsNullOrEmpty(comboTinhTrang.SelectedItem.ToString()))
                    {
                        list = BUSSach.Instance.GetAllSach();
                        Binding(list);
                    }
                    else
                    {
                        if (comboTinhTrang.SelectedItem.ToString().Contains("n"))
                        {
                            list.Clear();
                            foreach (var p in BUSSach.Instance.GetAllSach())
                            {
                                if (p.SoLuongConLai > 0)
                                {
                                    list.Add(p);
                                }
                            }
                            Binding(list);
                        }
                        else
                        {
                            list.Clear();
                            foreach (var p in BUSSach.Instance.GetAllSach())
                            {
                                if (p.SoLuongConLai == 0)
                                {
                                    list.Add(p);
                                }
                            }
                            Binding(list);
                        }
                    }
                }
                else if (!String.IsNullOrEmpty(comboTheLoai.SelectedItem.ToString()))
                {
                    if (String.IsNullOrEmpty(comboTinhTrang.SelectedItem.ToString()) == true)
                    {
                        list.Clear();
                        foreach (var p in BUSSach.Instance.GetAllSach())
                        {
                            if (p.TUASACH.THELOAI.TenTheLoai.ToLower().Equals(comboTheLoai.SelectedItem.ToString().ToLower()))
                            {
                                list.Add(p);
                            }
                        }
                        Binding(list);
                    }
                    else
                    {
                        if (comboTinhTrang.SelectedItem.ToString().Contains("n"))
                        {
                            list.Clear();
                            foreach (var p in BUSSach.Instance.GetAllSach())
                            {
                                if (p.TUASACH.THELOAI.TenTheLoai.ToLower().Equals(comboTheLoai.SelectedItem.ToString().ToLower()) == true && p.SoLuongConLai > 0)
                                {
                                    list.Add(p);
                                }
                            }
                            Binding(list);
                        }
                        else
                        {
                            list.Clear();
                            foreach (var p in BUSSach.Instance.GetAllSach())
                            {
                                if (p.TUASACH.THELOAI.TenTheLoai.ToLower().Equals(comboTheLoai.SelectedItem.ToString().ToLower()) == true && p.SoLuongConLai == 0)
                                {
                                    list.Add(p);
                                }
                            }
                            Binding(list);
                        }
                    }
                }
            }
            else
            {
                list = BUSSach.Instance.GetAllSach();
                Binding(list);
            }
        }

        private void txtMaSach_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMaSach.Text))
            {
                Binding(list);
            }    
            else
            {
                List<SACH> listSachSearching = new List<SACH>();
                foreach (var p in list)
                {
                    if (p.TUASACH.TenTuaSach.ToLower().Contains(txtMaSach.Text))
                    {
                        listSachSearching.Add(p);
                    }    
                }
                Binding(listSachSearching);
            }    
        }

        private void butRefresh_Click(object sender, EventArgs e)
        {
            txtMaSach.Text = "";
        }
    }
}
