using DTO;
using BUS;
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
    public partial class fPhieuThu : Form
    {
        private DOCGIA docgia;
        public fPhieuThu()
        {
            InitializeComponent();
            init();
        }
        private int TienThu;
        private void init()
        {
            TienThu = 0;
            dateNgayLap.Value = DateTime.Now.Date;
            comboDocGia.DataSource = BUSDocGia.Instance.GetAllDocGia();
            comboDocGia.ValueMember = "ID";
            comboDocGia.DisplayMember = "MaDocGia";
            comboDocGia.SelectedIndex = 0;
            docgia = BUSDocGia.Instance.GetDocGiaById(Convert.ToInt32(comboDocGia.SelectedValue));
            labelNoHienTai.Text = docgia.TongNoHienTai.ToString();
        }
    }
}
