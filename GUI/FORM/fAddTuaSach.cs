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
    public partial class fAddTuaSach : Form
    {
        private List<TACGIA> listTG;

        public List<TACGIA> ListTG
        {
            get { return listTG; }
            set { listTG = value; }
        }

        public fAddTuaSach()
        {
            InitializeComponent();
            LoadTheLoai();
            LoadTacGia();
            listTG = new List<TACGIA>();
        }

        private void LoadTheLoai()
        {
            foreach(var p in BUSTheLoai.Instance.GetAllTheLoai())
            {
                comboTheLoai.Items.Add(p.TenTheLoai);
            }    

        }
        private void LoadTacGia()
        {
            foreach (var p in BUSTacGia.Instance.GetAllTacGia())
            {
                comboTacGia.Items.Add(p.TenTacGia);
            }

        }

        private void TacGiaGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void butAddTacGia_Click(object sender, EventArgs e)
        {
            foreach(var tg in BUSTacGia.Instance.GetAllTacGia())
            {
                if (tg.TenTacGia.Equals(comboTacGia.SelectedItem.ToString()))
                {
                    //listTG.Add(tg);
                    TacGiaGrid.Rows.Add(tg.TenTacGia); 
                }
            }    
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            string tentheloai = comboTheLoai.SelectedItem.ToString();
            THELOAI theloai = new THELOAI();
            foreach (DataGridViewRow row in TacGiaGrid.Rows)
            {
                if (ListTG.Contains(BUSTacGia.Instance.GetTacGia(Convert.ToInt32(row.Cells["id"].Value))))
                    continue;
                ListTG.Add(BUSTacGia.Instance.GetTacGia(Convert.ToInt32(row.Cells["id"].Value)));
            }
            foreach (var p in BUSTheLoai.Instance.GetAllTheLoai())
            {
                if (p.TenTheLoai.Equals(tentheloai))
                {
                    theloai = p;
                }    
            }
            if (BUSTuaSach.Instance.AddTuaSach(txtTenTuaSach.Text, theloai, ListTG))
            {
                this.Close();
            }     
        }
    }
}
