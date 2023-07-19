using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.FORM
{
    public partial class fAddTuaSach : Form
    {
        private List<TACGIA> listTG;


        public fAddTuaSach()
        {
            InitializeComponent();
            LoadTheLoai();
            LoadTacGia();
        }

        private void LoadTheLoai()
        {
            foreach (var p in BUSTheLoai.Instance.GetAllTheLoai())
            {
                comboTheLoai.Items.Add(p.TenTheLoai);
            }

        }
        private void LoadTacGia()
        {
            comboTacGia.DataSource = null;
            if (listTG == null)
            {
                listTG = BUSTacGia.Instance.GetAllTacGia();
            }
            comboTacGia.DataSource = listTG;
            comboTacGia.DisplayMember = "TenTacGia";
            comboTacGia.ValueMember = "id";
        }

        private void butAddTacGia_Click(object sender, EventArgs e)
        {
            bool check_tk = false;
            bool check_tt = false;
            int selectedValue = Convert.ToInt32(comboTacGia.SelectedValue);
            string newtg = comboTacGia.Text;
            foreach (var tg in BUSTacGia.Instance.GetAllTacGia())
            {
                if (tg.id == selectedValue)
                {
                    check_tk = true;
                   foreach(DataGridViewRow row in TacGiaGrid.Rows)
                   {
                        if(selectedValue == Convert.ToInt32(row.Cells[0].Value))
                        {
                            check_tt = true;
                            MessageBox.Show("Tác giả bạn vừa chọn đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                   }
                    break;
                }
            }
            if (check_tk == false)
            {
                var ask = MessageBox.Show("Tác giả chưa có, bạn có muốn thêm mới?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ask == DialogResult.Yes)
                {
                    selectedValue = BUSTacGia.Instance.AddTacGia(newtg);
                    LoadTacGia() ;
                }
                else return;
            }
            if(!check_tt) TacGiaGrid.Rows.Add(selectedValue,newtg);
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            if (txtTenTuaSach.Text == "" || TacGiaGrid == null || comboTheLoai.SelectedIndex == -1)
            {
                MessageBox.Show("Thông tin nhập vào chưa đầy đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string tentheloai = comboTheLoai.SelectedItem.ToString();
            THELOAI theloai = new THELOAI();
            List<TACGIA> tglist = new List<TACGIA>();
            foreach (DataGridViewRow row in TacGiaGrid.Rows)
            {
                if (tglist.Contains(BUSTacGia.Instance.GetTacGia(Convert.ToInt32(row.Cells["id"].Value))))
                    continue;
                tglist.Add(BUSTacGia.Instance.GetTacGia(Convert.ToInt32(row.Cells["id"].Value)));
            }
            foreach (var p in BUSTheLoai.Instance.GetAllTheLoai())
            {
                if (p.TenTheLoai.Equals(tentheloai))
                {
                    theloai = p;
                }
            }
            if (BUSTuaSach.Instance.AddTuaSach(txtTenTuaSach.Text, theloai, tglist))
            {
                this.Close();
            }
        }
    }
}
