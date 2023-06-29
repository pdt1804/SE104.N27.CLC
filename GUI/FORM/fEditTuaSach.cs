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

namespace GUI.FORM
{
    public partial class fEditTuaSach : Form
    {
        public fEditTuaSach()
        {
            InitializeComponent();
        }

        TUASACH tuasach;
        List<TACGIA> TacGiaList;

        public fEditTuaSach(int id)
        {
            InitializeComponent();
            tuasach = BUSTuaSach.Instance.GetTuaSachById(id);
            txtTenTuaSach.Text = tuasach.TenTuaSach;
            List<THELOAI> theloai = BUSTheLoai.Instance.GetAllTheLoai();
            comboTheLoai.DataSource = theloai;
            comboTheLoai.DisplayMember = "TenTheLoai";
            comboTheLoai.ValueMember = "id";
            int idx = 0;
            foreach (THELOAI tl in theloai)
            {
                if (tl.TenTheLoai == tuasach.THELOAI.TenTheLoai)
                    comboTheLoai.SelectedIndex = idx;
                idx++;
            }
            foreach (TACGIA tg in tuasach.TACGIAs)
            {
                TacGiaGrid.Rows.Add(tg.TenTacGia, tg.id);
            }
            Binding();
        }

        private void Binding()
        {
            TacGiaList = BUSTacGia.Instance.GetAllTacGia();
            comboTacGia.DataSource = TacGiaList;
            comboTacGia.DisplayMember = "TenTacGia";
            comboTacGia.ValueMember = "id";
        }

        private void butOK_Click(object sender, EventArgs e)
        {

        }
    }
}
