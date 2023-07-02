using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using DTO;
using BUS;

namespace GUI.UserControls
{

    public partial class ucCuonSach : UserControl
    {
        public ucCuonSach()
        {
            InitializeComponent();
            comboList = new List<string> { "Đã được mượn", "Còn", "Bị ẩn" };
            listCuonSach = BUSCuonSach.Instance.GetAllCuonSach();
            Binding(listCuonSach);
        }
        List<int> tt;
        List<string> comboList;
        List<CUONSACH> listCuonSach;

        public void Binding(List<CUONSACH> CuonSachList)
        {
            CuonSachGrid.Rows.Clear();
            foreach (CUONSACH cs in CuonSachList)
            {
                string TinhTrang = comboList[(int)cs.TinhTrang];
                CuonSachGrid.Rows.Add(0, cs.MaCuonSach, cs.SACH.MaSach, cs.SACH.TUASACH.TenTuaSach + " (" + cs.SACH.TUASACH.MaTuaSach + " )", TinhTrang);
            }

        }
        private void ucCuonSach_Load(object sender, EventArgs e)
        {
            Binding(BUSCuonSach.Instance.GetAllCuonSach());
        }

        private void butRefresh_Click(object sender, EventArgs e)
        {
            txtMaSach.Text = "";
        }

        private void txtMaSach_TextChanged(object sender, EventArgs e)
        {
            listCuonSach.Clear();
            if (String.IsNullOrEmpty(txtMaSach.Text))
            {
                listCuonSach = BUSCuonSach.Instance.GetAllCuonSach();
                Binding(listCuonSach);
            }    
            else
            {
                List<CUONSACH> listSearching = new List<CUONSACH>();
                foreach(var p in BUSCuonSach.Instance.GetAllCuonSach())
                {
                    if (p.MaCuonSach.ToLower().Contains(txtMaSach.Text.ToLower()))
                    {
                        listSearching.Add(p);
                    }    
                }
                Binding(listSearching);
            }    
        }
    }
}
