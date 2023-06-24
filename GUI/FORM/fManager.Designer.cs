using GUI.UserControls;

namespace GUI
{
    partial class fManager 
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fManager));
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.siticoneBorderlessForm1 = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.customPanel1 = new GUI.CustomPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl = new Siticone.Desktop.UI.WinForms.SiticoneTabControl();
            this.tabAccount = new System.Windows.Forms.TabPage();
            this.tabQLDG = new System.Windows.Forms.TabPage();
            this.tabQLS = new System.Windows.Forms.TabPage();
            this.tabQLMT = new System.Windows.Forms.TabPage();
            this.tabQLPT = new System.Windows.Forms.TabPage();
            this.tabBC = new System.Windows.Forms.TabPage();
            this.tabQLND = new System.Windows.Forms.TabPage();
            this.tabTDQD = new System.Windows.Forms.TabPage();
            this.exitControlBox = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconList
            // 
            this.iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList.ImageStream")));
            this.iconList.TransparentColor = System.Drawing.Color.SlateBlue;
            this.iconList.Images.SetKeyName(0, "usern.png");
            this.iconList.Images.SetKeyName(1, "bookn.png");
            this.iconList.Images.SetKeyName(2, "libraryn.png");
            this.iconList.Images.SetKeyName(3, "invoicen.png");
            this.iconList.Images.SetKeyName(4, "taxes.png");
            this.iconList.Images.SetKeyName(5, "pie-chart.png");
            this.iconList.Images.SetKeyName(6, "bills.png");
            this.iconList.Images.SetKeyName(7, "gear.png");
            this.iconList.Images.SetKeyName(8, "exchange.png");
            // 
            // siticoneBorderlessForm1
            // 
            this.siticoneBorderlessForm1.ContainerControl = this;
            this.siticoneBorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneBorderlessForm1.ResizeForm = false;
            this.siticoneBorderlessForm1.TransparentWhileDrag = true;
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderRadius = 65;
            this.customPanel1.Controls.Add(this.pictureBox1);
            this.customPanel1.Controls.Add(this.label2);
            this.customPanel1.Controls.Add(this.tabControl);
            this.customPanel1.Controls.Add(this.exitControlBox);
            this.customPanel1.Controls.Add(this.siticoneControlBox1);
            this.customPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 90F;
            this.customPanel1.GradientBottomColor = System.Drawing.Color.CadetBlue;
            this.customPanel1.GradientTopColor = System.Drawing.Color.RoyalBlue;
            this.customPanel1.Location = new System.Drawing.Point(0, 0);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(1942, 1102);
            this.customPanel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::GUI.Properties.Resources.lib;
            this.pictureBox1.Location = new System.Drawing.Point(13, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(69, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 41);
            this.label2.TabIndex = 4;
            this.label2.Text = "Library Manager";
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl.Controls.Add(this.tabAccount);
            this.tabControl.Controls.Add(this.tabQLDG);
            this.tabControl.Controls.Add(this.tabQLS);
            this.tabControl.Controls.Add(this.tabQLMT);
            this.tabControl.Controls.Add(this.tabQLPT);
            this.tabControl.Controls.Add(this.tabBC);
            this.tabControl.Controls.Add(this.tabQLND);
            this.tabControl.Controls.Add(this.tabTDQD);
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.ImageList = this.iconList;
            this.tabControl.ItemSize = new System.Drawing.Size(260, 65);
            this.tabControl.Location = new System.Drawing.Point(0, 69);
            this.tabControl.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(0, 0);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(2045, 1024);
            this.tabControl.TabButtonHoverState.BorderColor = System.Drawing.Color.RoyalBlue;
            this.tabControl.TabButtonHoverState.FillColor = System.Drawing.Color.Lavender;
            this.tabControl.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tabControl.TabButtonHoverState.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.tabControl.TabButtonHoverState.InnerColor = System.Drawing.Color.RoyalBlue;
            this.tabControl.TabButtonIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.tabControl.TabButtonIdleState.FillColor = System.Drawing.Color.RoyalBlue;
            this.tabControl.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tabControl.TabButtonIdleState.ForeColor = System.Drawing.Color.White;
            this.tabControl.TabButtonIdleState.InnerColor = System.Drawing.Color.White;
            this.tabControl.TabButtonImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tabControl.TabButtonImageOffset = new System.Drawing.Point(10, 0);
            this.tabControl.TabButtonSelectedState.BorderColor = System.Drawing.Color.White;
            this.tabControl.TabButtonSelectedState.FillColor = System.Drawing.Color.White;
            this.tabControl.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold);
            this.tabControl.TabButtonSelectedState.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tabControl.TabButtonSelectedState.InnerColor = System.Drawing.Color.DarkBlue;
            this.tabControl.TabButtonSize = new System.Drawing.Size(260, 65);
            this.tabControl.TabButtonTextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tabControl.TabButtonTextOffset = new System.Drawing.Point(10, 0);
            this.tabControl.TabIndex = 4;
            this.tabControl.TabMenuBackColor = System.Drawing.Color.RoyalBlue;
            // 
            // tabAccount
            // 
            this.tabAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.tabAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabAccount.ImageIndex = 0;
            this.tabAccount.Location = new System.Drawing.Point(264, 4);
            this.tabAccount.Margin = new System.Windows.Forms.Padding(0);
            this.tabAccount.Name = "tabAccount";
            this.tabAccount.Size = new System.Drawing.Size(1777, 1016);
            this.tabAccount.TabIndex = 0;
            this.tabAccount.Text = "Tài khoản";
            // 
            // tabQLDG
            // 
            this.tabQLDG.BackColor = System.Drawing.Color.White;
            this.tabQLDG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabQLDG.ImageIndex = 1;
            this.tabQLDG.Location = new System.Drawing.Point(264, 4);
            this.tabQLDG.Margin = new System.Windows.Forms.Padding(0);
            this.tabQLDG.Name = "tabQLDG";
            this.tabQLDG.Size = new System.Drawing.Size(1777, 1016);
            this.tabQLDG.TabIndex = 1;
            this.tabQLDG.Text = "Độc giả";
            this.tabQLDG.Click += new System.EventHandler(this.tabQLDG_Click);
            // 
            // tabQLS
            // 
            this.tabQLS.BackColor = System.Drawing.Color.White;
            this.tabQLS.ImageIndex = 2;
            this.tabQLS.Location = new System.Drawing.Point(264, 4);
            this.tabQLS.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabQLS.Name = "tabQLS";
            this.tabQLS.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabQLS.Size = new System.Drawing.Size(1777, 1016);
            this.tabQLS.TabIndex = 2;
            this.tabQLS.Text = "Sách";
            // 
            // tabQLMT
            // 
            this.tabQLMT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.tabQLMT.ImageIndex = 3;
            this.tabQLMT.Location = new System.Drawing.Point(264, 4);
            this.tabQLMT.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabQLMT.Name = "tabQLMT";
            this.tabQLMT.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabQLMT.Size = new System.Drawing.Size(1777, 1016);
            this.tabQLMT.TabIndex = 3;
            this.tabQLMT.Text = "Phiếu mượn trả";
            // 
            // tabQLPT
            // 
            this.tabQLPT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.tabQLPT.ImageIndex = 6;
            this.tabQLPT.Location = new System.Drawing.Point(264, 4);
            this.tabQLPT.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabQLPT.Name = "tabQLPT";
            this.tabQLPT.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabQLPT.Size = new System.Drawing.Size(1777, 1016);
            this.tabQLPT.TabIndex = 4;
            this.tabQLPT.Text = "Phiếu thu";
            // 
            // tabBC
            // 
            this.tabBC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.tabBC.ImageIndex = 5;
            this.tabBC.Location = new System.Drawing.Point(264, 4);
            this.tabBC.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabBC.Name = "tabBC";
            this.tabBC.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabBC.Size = new System.Drawing.Size(1777, 1016);
            this.tabBC.TabIndex = 5;
            this.tabBC.Text = "Báo cáo thống kê";
            // 
            // tabQLND
            // 
            this.tabQLND.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.tabQLND.ImageIndex = 7;
            this.tabQLND.Location = new System.Drawing.Point(264, 4);
            this.tabQLND.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabQLND.Name = "tabQLND";
            this.tabQLND.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabQLND.Size = new System.Drawing.Size(1777, 1016);
            this.tabQLND.TabIndex = 6;
            this.tabQLND.Text = "Người dùng";
            // 
            // tabTDQD
            // 
            this.tabTDQD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.tabTDQD.ImageIndex = 8;
            this.tabTDQD.Location = new System.Drawing.Point(264, 4);
            this.tabTDQD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabTDQD.Name = "tabTDQD";
            this.tabTDQD.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabTDQD.Size = new System.Drawing.Size(1777, 1016);
            this.tabTDQD.TabIndex = 7;
            this.tabTDQD.Text = "Thay đổi quy định";
            // 
            // exitControlBox
            // 
            this.exitControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitControlBox.BackColor = System.Drawing.Color.Transparent;
            this.exitControlBox.CustomClick = true;
            this.exitControlBox.FillColor = System.Drawing.Color.Transparent;
            this.exitControlBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitControlBox.IconColor = System.Drawing.Color.White;
            this.exitControlBox.Location = new System.Drawing.Point(1845, 5);
            this.exitControlBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.exitControlBox.Name = "exitControlBox";
            this.exitControlBox.Size = new System.Drawing.Size(60, 63);
            this.exitControlBox.TabIndex = 0;
            this.exitControlBox.Click += new System.EventHandler(this.exitControlBox_Click);
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox1.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.Location = new System.Drawing.Point(1774, 4);
            this.siticoneControlBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.Size = new System.Drawing.Size(72, 63);
            this.siticoneControlBox1.TabIndex = 0;
            // 
            // fManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.customPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneTabControl tabControl;
        private System.Windows.Forms.TabPage tabAccount;
        private System.Windows.Forms.TabPage tabQLDG;
        private System.Windows.Forms.TabPage tabQLS;
        private System.Windows.Forms.TabPage tabQLMT;
        private System.Windows.Forms.TabPage tabQLPT;
        private System.Windows.Forms.TabPage tabBC;
        private System.Windows.Forms.TabPage tabQLND;
        private System.Windows.Forms.TabPage tabTDQD;
        private System.Windows.Forms.ImageList iconList;
        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
        private System.Windows.Forms.Label label2;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox exitControlBox;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private CustomPanel customPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        //private static ucBanAccess ucBan;
        private static ucQLDG ucqldg;
        private static ucQLSach ucqlsach;
        private static ucQLPhieuMuon ucphieumuontra;
        private static ucQLPhieuThu ucphieuthu;
        private static ucBCTK ucbaocao;
        private static ucQLND ucnguoidung;
        private static ucThongTinTaiKhoan uctaikhoan;
        private static ucThayDoiQuiDinh ucquidinh;
    }
}