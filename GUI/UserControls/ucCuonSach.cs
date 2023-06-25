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
            comboTinhTrang.DataSource = comboList;
            Binding(BUSCuonSach.Instance.GetAllCuonSach());
        }
        List<int> tt;
        List<string> comboList;
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

        
    }
}
