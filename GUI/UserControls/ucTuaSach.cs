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

        }
        public void Binding(List<TUASACH> TuaSachList)
        {
            Image edit_img = Properties.Resources.edit_icon;
            edit_img = (Image)(new Bitmap(edit_img, new Size(25, 25)));
            Image del_img = Properties.Resources.delete;
            del_img = (Image)(new Bitmap(del_img, new Size(25, 25)));
            TuaSachGrid.Rows.Clear();
            TuaSachGrid.Refresh();
            foreach (TUASACH tuasach in TuaSachList)
            {
                string tacgia = "";
                foreach (TACGIA tg in tuasach.TACGIAs)
                {
                    tacgia += tg.TenTacGia + ", ";
                }
                if (tacgia != "") tacgia = tacgia.Remove(tacgia.Length - 2, 2);
                TuaSachGrid.Rows.Add(0, tuasach.id, tuasach.MaTuaSach, tuasach.TenTuaSach, tuasach.THELOAI.TenTheLoai, tacgia, edit_img, del_img);
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
            List<TUASACH> listTSSearching = new List<TUASACH>();
            foreach (TUASACH TS in BUSTuaSach.Instance.GetAllTuaSach())
            {
                if (TS.TenTuaSach.ToLower().Contains(txtFind.Text.ToLower()))
                {
                    listTSSearching.Add(TS);
                }
            }
            Binding(listTSSearching);
        }

        private void TuaSachGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx < 0) return;
            if (e.ColumnIndex == TuaSachGrid.Columns["Edit"].Index)
            {
                var f = new fEditTuaSach((Convert.ToInt32(TuaSachGrid.Rows[idx].Cells["id"].Value)));
                f.ShowDialog();
                Binding(BUSTuaSach.Instance.GetAllTuaSach());
                return;
            }else if (e.ColumnIndex == TuaSachGrid.Columns["Delete"].Index)
            {
                string result = BUSTuaSach.Instance.DelTuaSach(Convert.ToInt32(TuaSachGrid.Rows[e.RowIndex].Cells["id"].Value));
                if (result == "")
                {
                    MessageBox.Show("Xóa tựa sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Binding(BUSTuaSach.Instance.GetAllTuaSach());
                }
                else
                {
                    MessageBox.Show(result, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
            var fInfor = new fInfoTuaSach(Convert.ToInt32(TuaSachGrid.Rows[idx].Cells["id"].Value));
            fInfor.ShowDialog();
            Binding(BUSTuaSach.Instance.GetAllTuaSach());
            return;
        }
    }
}
