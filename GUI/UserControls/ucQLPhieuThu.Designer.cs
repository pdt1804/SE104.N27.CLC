namespace GUI.UserControls
{
    partial class ucQLPhieuThu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PhieuThuGrid = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.SoPhieuThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTienThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.butFindNgay = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.txtNam = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtThang = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtNgay = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.butFind = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.txtFind = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.butAdd = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.butRefresh = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.pHIEUTHUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PhieuThuGrid)).BeginInit();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUTHUBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PhieuThuGrid
            // 
            this.PhieuThuGrid.AllowUserToAddRows = false;
            this.PhieuThuGrid.AllowUserToDeleteRows = false;
            this.PhieuThuGrid.AllowUserToOrderColumns = true;
            this.PhieuThuGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.PhieuThuGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PhieuThuGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.PhieuThuGrid.ColumnHeadersHeight = 35;
            this.PhieuThuGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.PhieuThuGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoPhieuThu,
            this.MaDocGia,
            this.SoTienThu,
            this.NgayLap});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PhieuThuGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.PhieuThuGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PhieuThuGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PhieuThuGrid.Location = new System.Drawing.Point(0, 139);
            this.PhieuThuGrid.Name = "PhieuThuGrid";
            this.PhieuThuGrid.ReadOnly = true;
            this.PhieuThuGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.PhieuThuGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.PhieuThuGrid.RowHeadersVisible = false;
            this.PhieuThuGrid.RowHeadersWidth = 51;
            this.PhieuThuGrid.RowTemplate.Height = 30;
            this.PhieuThuGrid.Size = new System.Drawing.Size(997, 457);
            this.PhieuThuGrid.TabIndex = 5;
            this.PhieuThuGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.PhieuThuGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.PhieuThuGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.PhieuThuGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.PhieuThuGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.PhieuThuGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.PhieuThuGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PhieuThuGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.PhieuThuGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.PhieuThuGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhieuThuGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.PhieuThuGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.PhieuThuGrid.ThemeStyle.HeaderStyle.Height = 35;
            this.PhieuThuGrid.ThemeStyle.ReadOnly = true;
            this.PhieuThuGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.PhieuThuGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.PhieuThuGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhieuThuGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.PhieuThuGrid.ThemeStyle.RowsStyle.Height = 30;
            this.PhieuThuGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PhieuThuGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // SoPhieuThu
            // 
            this.SoPhieuThu.HeaderText = "Số phiếu thu";
            this.SoPhieuThu.MinimumWidth = 6;
            this.SoPhieuThu.Name = "SoPhieuThu";
            this.SoPhieuThu.ReadOnly = true;
            // 
            // MaDocGia
            // 
            this.MaDocGia.HeaderText = "Mã độc giả";
            this.MaDocGia.MinimumWidth = 6;
            this.MaDocGia.Name = "MaDocGia";
            this.MaDocGia.ReadOnly = true;
            // 
            // SoTienThu
            // 
            this.SoTienThu.HeaderText = "Số tiền thu";
            this.SoTienThu.MinimumWidth = 6;
            this.SoTienThu.Name = "SoTienThu";
            this.SoTienThu.ReadOnly = true;
            // 
            // NgayLap
            // 
            this.NgayLap.HeaderText = "Ngày lập";
            this.NgayLap.MinimumWidth = 6;
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.ReadOnly = true;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.AliceBlue;
            this.topPanel.Controls.Add(this.butFindNgay);
            this.topPanel.Controls.Add(this.txtNam);
            this.topPanel.Controls.Add(this.txtThang);
            this.topPanel.Controls.Add(this.txtNgay);
            this.topPanel.Controls.Add(this.butFind);
            this.topPanel.Controls.Add(this.txtFind);
            this.topPanel.Controls.Add(this.butRefresh);
            this.topPanel.Controls.Add(this.butAdd);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(997, 139);
            this.topPanel.TabIndex = 4;
            // 
            // butFindNgay
            // 
            this.butFindNgay.AutoRoundedCorners = true;
            this.butFindNgay.BorderRadius = 20;
            this.butFindNgay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butFindNgay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butFindNgay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butFindNgay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butFindNgay.FillColor = System.Drawing.Color.RoyalBlue;
            this.butFindNgay.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFindNgay.ForeColor = System.Drawing.Color.White;
            this.butFindNgay.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butFindNgay.ImageOffset = new System.Drawing.Point(3, 0);
            this.butFindNgay.Location = new System.Drawing.Point(728, 79);
            this.butFindNgay.Name = "butFindNgay";
            this.butFindNgay.Size = new System.Drawing.Size(191, 42);
            this.butFindNgay.TabIndex = 21;
            this.butFindNgay.Text = "Lọc ngày lập";
            this.butFindNgay.TextOffset = new System.Drawing.Point(3, 0);
            // 
            // txtNam
            // 
            this.txtNam.AutoRoundedCorners = true;
            this.txtNam.BorderColor = System.Drawing.Color.Gray;
            this.txtNam.BorderRadius = 20;
            this.txtNam.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNam.DefaultText = "";
            this.txtNam.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNam.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNam.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNam.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNam.Location = new System.Drawing.Point(582, 79);
            this.txtNam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNam.Name = "txtNam";
            this.txtNam.PasswordChar = '\0';
            this.txtNam.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtNam.PlaceholderText = "Năm";
            this.txtNam.SelectedText = "";
            this.txtNam.Size = new System.Drawing.Size(94, 42);
            this.txtNam.TabIndex = 20;
            // 
            // txtThang
            // 
            this.txtThang.AutoRoundedCorners = true;
            this.txtThang.BorderColor = System.Drawing.Color.Gray;
            this.txtThang.BorderRadius = 20;
            this.txtThang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtThang.DefaultText = "";
            this.txtThang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtThang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtThang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtThang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtThang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtThang.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtThang.Location = new System.Drawing.Point(471, 79);
            this.txtThang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtThang.Name = "txtThang";
            this.txtThang.PasswordChar = '\0';
            this.txtThang.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtThang.PlaceholderText = "Tháng";
            this.txtThang.SelectedText = "";
            this.txtThang.Size = new System.Drawing.Size(102, 42);
            this.txtThang.TabIndex = 19;
            // 
            // txtNgay
            // 
            this.txtNgay.AutoRoundedCorners = true;
            this.txtNgay.BorderColor = System.Drawing.Color.Gray;
            this.txtNgay.BorderRadius = 20;
            this.txtNgay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNgay.DefaultText = "";
            this.txtNgay.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNgay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNgay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNgay.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNgay.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNgay.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgay.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNgay.Location = new System.Drawing.Point(359, 79);
            this.txtNgay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.PasswordChar = '\0';
            this.txtNgay.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtNgay.PlaceholderText = "Ngày";
            this.txtNgay.SelectedText = "";
            this.txtNgay.Size = new System.Drawing.Size(102, 42);
            this.txtNgay.TabIndex = 18;
            // 
            // butFind
            // 
            this.butFind.AutoRoundedCorners = true;
            this.butFind.BorderRadius = 21;
            this.butFind.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butFind.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butFind.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butFind.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butFind.FillColor = System.Drawing.Color.RoyalBlue;
            this.butFind.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFind.ForeColor = System.Drawing.Color.White;
            this.butFind.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butFind.ImageOffset = new System.Drawing.Point(3, 0);
            this.butFind.Location = new System.Drawing.Point(728, 19);
            this.butFind.Name = "butFind";
            this.butFind.Size = new System.Drawing.Size(191, 44);
            this.butFind.TabIndex = 16;
            this.butFind.Text = "Tìm kiếm";
            this.butFind.TextOffset = new System.Drawing.Point(3, 0);
            // 
            // txtFind
            // 
            this.txtFind.AutoRoundedCorners = true;
            this.txtFind.BorderColor = System.Drawing.Color.Gray;
            this.txtFind.BorderRadius = 21;
            this.txtFind.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFind.DefaultText = "";
            this.txtFind.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFind.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFind.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFind.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFind.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFind.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFind.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txtFind.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFind.Location = new System.Drawing.Point(359, 19);
            this.txtFind.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFind.Name = "txtFind";
            this.txtFind.PasswordChar = '\0';
            this.txtFind.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtFind.PlaceholderText = "Số phiếu, mã độc giả";
            this.txtFind.SelectedText = "";
            this.txtFind.Size = new System.Drawing.Size(317, 44);
            this.txtFind.TabIndex = 17;
            // 
            // butAdd
            // 
            this.butAdd.AutoRoundedCorners = true;
            this.butAdd.BorderRadius = 24;
            this.butAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butAdd.FillColor = System.Drawing.Color.RoyalBlue;
            this.butAdd.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAdd.ForeColor = System.Drawing.Color.White;
            this.butAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butAdd.ImageOffset = new System.Drawing.Point(2, 0);
            this.butAdd.Location = new System.Drawing.Point(123, 48);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(151, 50);
            this.butAdd.TabIndex = 5;
            this.butAdd.Text = "Thêm Phiếu";
            this.butAdd.TextOffset = new System.Drawing.Point(3, 0);
            // 
            // butRefresh
            // 
            this.butRefresh.CheckedState.ImageSize = new System.Drawing.Size(45, 45);
            this.butRefresh.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.butRefresh.Image = global::GUI.Properties.Resources.refresh__2_;
            this.butRefresh.ImageOffset = new System.Drawing.Point(0, 0);
            this.butRefresh.ImageRotate = 0F;
            this.butRefresh.ImageSize = new System.Drawing.Size(50, 50);
            this.butRefresh.Location = new System.Drawing.Point(34, 43);
            this.butRefresh.Name = "butRefresh";
            this.butRefresh.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.butRefresh.Size = new System.Drawing.Size(62, 56);
            this.butRefresh.TabIndex = 9;
            // 
            // pHIEUTHUBindingSource
            // 
            this.pHIEUTHUBindingSource.DataSource = typeof(DTO.PHIEUTHU);
            // 
            // ucQLPhieuThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PhieuThuGrid);
            this.Controls.Add(this.topPanel);
            this.Name = "ucQLPhieuThu";
            this.Size = new System.Drawing.Size(997, 596);
            ((System.ComponentModel.ISupportInitialize)(this.PhieuThuGrid)).EndInit();
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUTHUBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView PhieuThuGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPhieuThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTienThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private Siticone.Desktop.UI.WinForms.SiticonePanel topPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butFindNgay;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtNam;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtThang;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtNgay;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butFind;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtFind;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton butRefresh;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butAdd;
        private System.Windows.Forms.BindingSource pHIEUTHUBindingSource;
    }
}
