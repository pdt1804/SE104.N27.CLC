using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using GUI.FORM;

namespace GUI.UserControls
{
    public partial class ucTuaSach : UserControl
    {
        public List<THELOAI> listTL { get; set; }
        public List<TUASACH> listTS { get; set; }

        public ucTuaSach()
        {
            listTL = new List<THELOAI>();
            listTS = new List<TUASACH>();
            InitializeComponent();
            comboTheLoai.Items.Add("Tất cả");
            comboTheLoai.Text = "Tất cả";
            foreach (var p in BUSTheLoai.Instance.GetAllTheLoai())
            {
                listTL.Add(p);
                comboTheLoai.Items.Add(p.TenTheLoai);
            }    
            //comboTheLoai.DataSource = listTL;
            //comboTheLoai.DisplayMember = "TenTheLoai";
            //comboTheLoai.ValueMember = "id";

        }
        public void Binding(List<TUASACH> TuaSachList)
        {

            Image img = Properties.Resources.edit_icon;
            img = (Image)(new Bitmap(img, new Size(20, 20)));

            TuaSachGrid.Rows.Clear();
            // Icon myIcon = new Icon("F:\\QLTV\\GUI\\Resources\\edit_icon.png");
            foreach (TUASACH tuasach in TuaSachList)
            {
                string tacgia = "";
                foreach (TACGIA tg in tuasach.TACGIAs)
                {
                    tacgia += tg.TenTacGia + ", ";
                }
                if (tacgia != "") tacgia = tacgia.Remove(tacgia.Length - 2, 2);
                TuaSachGrid.Rows.Add(0, tuasach.id, tuasach.MaTuaSach, tuasach.TenTuaSach, tuasach.THELOAI.TenTheLoai, tacgia, tuasach.DaAn, img);
            }
        }
        private void ucTuaSach_Load(object sender, EventArgs e)
        {
            listTS = BUSTuaSach.Instance.GetAllTuaSach();
            Binding(listTS);
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            fAddTuaSach f = new fAddTuaSach();
            f.ShowDialog();
            f.BringToFront();
            ucTuaSach_Load(sender, e);
        }

        private void comboTheLoai_SelectedValueChanged(object sender, EventArgs e)
        {
            listTS.Clear();
            string seletedValued = comboTheLoai.SelectedItem.ToString();
            if (seletedValued.Equals("Tất cả"))
            {
                listTS = BUSTuaSach.Instance.GetAllTuaSach();
                Binding(listTS);
            }
            else
            {
                foreach (var p in BUSTuaSach.Instance.GetAllTuaSach())
                {
                    if (p.THELOAI.TenTheLoai.Equals(seletedValued))
                    {
                        listTS.Add(p);
                    }
                }
                Binding(listTS);
            }
        }

        private void butRefresh_Click(object sender, EventArgs e)
        {
            Binding(BUSTuaSach.Instance.GetAllTuaSach());
            txtFind.Text = "";
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtFind.Text))
            {
                Binding(listTS);
            }
            else
            {
                List<TUASACH> listTSSearching = new List<TUASACH>();
                foreach (var p in listTS)
                {
                    if (p.TenTuaSach.ToLower().Contains(txtFind.Text.ToLower()))
                    {
                        listTSSearching.Add(p);
                    }
                }
                Binding(listTSSearching);
            }
        }

        private void TuaSachGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx < 0) return;
            if (e.ColumnIndex == 0) return;
            if (e.ColumnIndex == TuaSachGrid.Columns["Edit"].Index)
            {
                var f = new fEditTuaSach((Convert.ToInt32(TuaSachGrid.Rows[idx].Cells["id"].Value)));
                f.ShowDialog();
                Binding(BUSTuaSach.Instance.GetAllTuaSach());
                return;
            }
            var fInfor = new fInfoTuaSach(Convert.ToInt32(TuaSachGrid.Rows[idx].Cells["id"].Value));
            fInfor.ShowDialog();
            Binding(BUSTuaSach.Instance.GetAllTuaSach());
            return;
        }
    }
}
