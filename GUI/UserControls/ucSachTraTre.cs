using BUS;
using GUI.Print;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UserControls
{
    public partial class ucSachTraTre : UserControl
    {
        private P_BCSachTraTre report;
        public ucSachTraTre()
        {
            InitializeComponent();
            dateBC.Value = DateTime.Now;
        }

        private void Print(DataGridView dataGrid, DateTime date)
        {
            Label datetime = new Label();
            datetime.Text = date.ToString();
            report = new P_BCSachTraTre(dataGrid, datetime);
            report.PrintReport();
        }
        private string AddBC(DateTime ngayBC)
        {
            string err = BUSBCSachTraTre.Instance.AddBaoCao(ngayBC);
            if (err != "")
            {
                return "Thêm không thành công";
            }
            return "Đã thêm thành công";
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            dataGrid.Rows.Clear();
            var ngayBC = dateBC.Value;
            var bc = BUSBCSachTraTre.Instance.FindBaoCaoByDate(ngayBC);
            if (bc == null)
            {
                string result = AddBC(ngayBC);
                MessageBox.Show(result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                foreach(var _bc in bc)
                {
                    BUSBCSachTraTre.Instance.DelBaoCao(_bc.Ngay, _bc.idCuonSach);
                }
                string result = AddBC(ngayBC);
                MessageBox.Show(result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            bc = BUSBCSachTraTre.Instance.FindBaoCaoByDate(ngayBC);
            if (bc == null)
            {
                MessageBox.Show("Có lỗi xảy ra! Vui lòng thử lại sau", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int i = 1;
            dataGrid.Rows.Clear();
            foreach (var b in bc)
            {
                dataGrid.Rows.Add(i, b.CUONSACH.MaCuonSach, b.CUONSACH.SACH.TUASACH.TenTuaSach, b.NgayMuon.ToShortDateString(), b.SoNgayTre);
                i++;
            }
            Print(dataGrid, ngayBC);
        }
    }
}
