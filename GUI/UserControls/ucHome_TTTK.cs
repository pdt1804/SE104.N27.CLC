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
    public partial class ucHome_TTTK : UserControl
    {
        public NGUOIDUNG user { get; set; }
        public DOCGIA docgia { get; set; }

        public ucHome_TTTK(int id)
        {
            InitializeComponent();
            user = new NGUOIDUNG();
            user = BUSNguoiDung.Instance.GetNguoiDungById(id);
            docgia = new DOCGIA();
            foreach (var p in BUSDocGia.Instance.GetAllDocGia())
            {
                if (p.idNguoiDung == id)
                {
                    docgia = p;
                    break;
                }    
            }    
            if (docgia != null)
            {
                labelDiaChi.Text = docgia.DiaChi;
                labelEmail.Text = user.EMAIL;
                labelHoTen.Text = docgia.TenDocGia;
                labelLoaiDG.Text = docgia.LOAIDOCGIA.TenLoaiDocGia;
                labelMaDG.Text = docgia.MaDocGia;
                labelNgayHetHan.Text = docgia.NgayHetHan.ToString();
                labelNgayLapThe.Text = docgia.NgayLapThe.ToString();
                labelNgaySinh.Text = docgia.NgaySinh.ToString();
                labelTenDangNhap.Text = user.TenDangNhap;
                labelTongNo.Text = docgia.TongNoHienTai.ToString();

                var phieumuonList = BUSPhieuMuonTra.Instance.FindPhieuMuonByDocGia(docgia.ID);
                if (phieumuonList.Any())
                    foreach (var pm in phieumuonList)
                    {
                        string ngayTra = (pm.NgayTra != null ? pm.NgayTra.Value.ToShortDateString() : "Chưa trả");
                        string soTienPhat = (pm.SoTienPhat != null ? pm.SoTienPhat.Value.ToString() : "");
                        PhieuMuonDataGrid.Rows.Add(pm.SoPhieuMuonTra, pm.CUONSACH.MaCuonSach,
                            pm.CUONSACH.SACH.TUASACH.TenTuaSach, pm.NgayMuon.ToShortDateString(), pm.HanTra.ToShortDateString(),
                            ngayTra, soTienPhat);
                    }
            }    
        }

        private void butChange_Click(object sender, EventArgs e)
        {
            fChangePassword f = new fChangePassword(user.id, null);
            f.ShowDialog();
        }

        private void siticonePanel3_Paint(object sender, PaintEventArgs e)
        {
                  
        }

        private void siticoneDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
