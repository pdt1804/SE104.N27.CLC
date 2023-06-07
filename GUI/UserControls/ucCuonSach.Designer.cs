namespace GUI.UserControls
{
    partial class ucCuonSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucCuonSach));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.topPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.butHien = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.comboTinhTrang = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.butTinhTrang = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.butMaSach = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.butRefresh = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.txtMaSach = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.butDel = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.CuonSachGrid = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.isChosen = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MaCuonSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUONSACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ErrorDia = new Siticone.Desktop.UI.WinForms.SiticoneMessageDialog();
            this.AskDia = new Siticone.Desktop.UI.WinForms.SiticoneMessageDialog();
            this.SuccDia = new Siticone.Desktop.UI.WinForms.SiticoneMessageDialog();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CuonSachGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUONSACHBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.butHien);
            this.topPanel.Controls.Add(this.comboTinhTrang);
            this.topPanel.Controls.Add(this.butTinhTrang);
            this.topPanel.Controls.Add(this.butMaSach);
            this.topPanel.Controls.Add(this.butRefresh);
            this.topPanel.Controls.Add(this.txtMaSach);
            this.topPanel.Controls.Add(this.butDel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(997, 121);
            this.topPanel.TabIndex = 1;
            // 
            // butHien
            // 
            this.butHien.AutoRoundedCorners = true;
            this.butHien.BorderRadius = 13;
            this.butHien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butHien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butHien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butHien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butHien.FillColor = System.Drawing.Color.SlateBlue;
            this.butHien.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold);
            this.butHien.ForeColor = System.Drawing.Color.White;
            this.butHien.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butHien.ImageOffset = new System.Drawing.Point(2, 0);
            this.butHien.Location = new System.Drawing.Point(205, 88);
            this.butHien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butHien.Name = "butHien";
            this.butHien.Size = new System.Drawing.Size(178, 28);
            this.butHien.TabIndex = 18;
            this.butHien.Text = "Hiện Cuốn Sách";
            this.butHien.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butHien.TextOffset = new System.Drawing.Point(3, 0);
            // 
            // comboTinhTrang
            // 
            this.comboTinhTrang.AutoRoundedCorners = true;
            this.comboTinhTrang.BackColor = System.Drawing.Color.Transparent;
            this.comboTinhTrang.BorderRadius = 17;
            this.comboTinhTrang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTinhTrang.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboTinhTrang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboTinhTrang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboTinhTrang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboTinhTrang.ItemHeight = 30;
            this.comboTinhTrang.Location = new System.Drawing.Point(502, 44);
            this.comboTinhTrang.Name = "comboTinhTrang";
            this.comboTinhTrang.Size = new System.Drawing.Size(201, 36);
            this.comboTinhTrang.TabIndex = 17;
            // 
            // butTinhTrang
            // 
            this.butTinhTrang.AutoRoundedCorners = true;
            this.butTinhTrang.BorderRadius = 11;
            this.butTinhTrang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butTinhTrang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butTinhTrang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butTinhTrang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butTinhTrang.FillColor = System.Drawing.Color.SlateBlue;
            this.butTinhTrang.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold);
            this.butTinhTrang.ForeColor = System.Drawing.Color.White;
            this.butTinhTrang.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butTinhTrang.ImageOffset = new System.Drawing.Point(3, 0);
            this.butTinhTrang.Location = new System.Drawing.Point(709, 44);
            this.butTinhTrang.Name = "butTinhTrang";
            this.butTinhTrang.Size = new System.Drawing.Size(129, 24);
            this.butTinhTrang.TabIndex = 16;
            this.butTinhTrang.Text = "Lọc tình trạng";
            this.butTinhTrang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butTinhTrang.TextOffset = new System.Drawing.Point(3, 0);
            // 
            // butMaSach
            // 
            this.butMaSach.AutoRoundedCorners = true;
            this.butMaSach.BorderRadius = 11;
            this.butMaSach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butMaSach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butMaSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butMaSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butMaSach.FillColor = System.Drawing.Color.SlateBlue;
            this.butMaSach.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold);
            this.butMaSach.ForeColor = System.Drawing.Color.White;
            this.butMaSach.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butMaSach.ImageOffset = new System.Drawing.Point(3, 0);
            this.butMaSach.Location = new System.Drawing.Point(709, 87);
            this.butMaSach.Name = "butMaSach";
            this.butMaSach.Size = new System.Drawing.Size(129, 24);
            this.butMaSach.TabIndex = 14;
            this.butMaSach.Text = "Tìm kiếm";
            this.butMaSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butMaSach.TextOffset = new System.Drawing.Point(3, 0);
            // 
            // butRefresh
            // 
            this.butRefresh.CheckedState.ImageSize = new System.Drawing.Size(45, 45);
            this.butRefresh.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.butRefresh.Image = ((System.Drawing.Image)(resources.GetObject("butRefresh.Image")));
            this.butRefresh.ImageOffset = new System.Drawing.Point(0, 0);
            this.butRefresh.ImageRotate = 0F;
            this.butRefresh.ImageSize = new System.Drawing.Size(30, 30);
            this.butRefresh.Location = new System.Drawing.Point(12, 18);
            this.butRefresh.Name = "butRefresh";
            this.butRefresh.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.butRefresh.Size = new System.Drawing.Size(64, 54);
            this.butRefresh.TabIndex = 10;
            // 
            // txtMaSach
            // 
            this.txtMaSach.AutoRoundedCorners = true;
            this.txtMaSach.BorderRadius = 11;
            this.txtMaSach.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaSach.DefaultText = "";
            this.txtMaSach.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaSach.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaSach.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaSach.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtMaSach.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txtMaSach.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaSach.Location = new System.Drawing.Point(502, 87);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.PasswordChar = '\0';
            this.txtMaSach.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtMaSach.PlaceholderText = "Mã, tên ";
            this.txtMaSach.SelectedText = "";
            this.txtMaSach.Size = new System.Drawing.Size(201, 24);
            this.txtMaSach.TabIndex = 15;
            // 
            // butDel
            // 
            this.butDel.AutoRoundedCorners = true;
            this.butDel.BorderRadius = 13;
            this.butDel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butDel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butDel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butDel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butDel.FillColor = System.Drawing.Color.SlateBlue;
            this.butDel.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold);
            this.butDel.ForeColor = System.Drawing.Color.White;
            this.butDel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butDel.ImageOffset = new System.Drawing.Point(2, 0);
            this.butDel.Location = new System.Drawing.Point(6, 87);
            this.butDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butDel.Name = "butDel";
            this.butDel.Size = new System.Drawing.Size(178, 28);
            this.butDel.TabIndex = 7;
            this.butDel.Text = "Ẩn Cuốn Sách";
            this.butDel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butDel.TextOffset = new System.Drawing.Point(3, 0);
            // 
            // CuonSachGrid
            // 
            this.CuonSachGrid.AllowUserToAddRows = false;
            this.CuonSachGrid.AllowUserToDeleteRows = false;
            this.CuonSachGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CuonSachGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CuonSachGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.CuonSachGrid.ColumnHeadersHeight = 35;
            this.CuonSachGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CuonSachGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isChosen,
            this.MaCuonSach,
            this.MaSach,
            this.TenSach,
            this.TinhTrang});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CuonSachGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.CuonSachGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CuonSachGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CuonSachGrid.Location = new System.Drawing.Point(0, 121);
            this.CuonSachGrid.Name = "CuonSachGrid";
            this.CuonSachGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CuonSachGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.CuonSachGrid.RowHeadersVisible = false;
            this.CuonSachGrid.RowHeadersWidth = 51;
            this.CuonSachGrid.RowTemplate.Height = 30;
            this.CuonSachGrid.Size = new System.Drawing.Size(997, 475);
            this.CuonSachGrid.TabIndex = 2;
            this.CuonSachGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CuonSachGrid.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CuonSachGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CuonSachGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CuonSachGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CuonSachGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.CuonSachGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CuonSachGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CuonSachGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CuonSachGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CuonSachGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CuonSachGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CuonSachGrid.ThemeStyle.HeaderStyle.Height = 35;
            this.CuonSachGrid.ThemeStyle.ReadOnly = false;
            this.CuonSachGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CuonSachGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CuonSachGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CuonSachGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CuonSachGrid.ThemeStyle.RowsStyle.Height = 30;
            this.CuonSachGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CuonSachGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // isChosen
            // 
            this.isChosen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.isChosen.FalseValue = "0";
            this.isChosen.HeaderText = "";
            this.isChosen.IndeterminateValue = "0";
            this.isChosen.MinimumWidth = 6;
            this.isChosen.Name = "isChosen";
            this.isChosen.TrueValue = "1";
            this.isChosen.Width = 6;
            // 
            // MaCuonSach
            // 
            this.MaCuonSach.HeaderText = "Mã cuốn sách";
            this.MaCuonSach.MinimumWidth = 6;
            this.MaCuonSach.Name = "MaCuonSach";
            this.MaCuonSach.ReadOnly = true;
            // 
            // MaSach
            // 
            this.MaSach.HeaderText = "Mã sách";
            this.MaSach.MinimumWidth = 6;
            this.MaSach.Name = "MaSach";
            this.MaSach.ReadOnly = true;
            this.MaSach.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TenSach
            // 
            this.TenSach.HeaderText = "Tựa sách";
            this.TenSach.MinimumWidth = 6;
            this.TenSach.Name = "TenSach";
            this.TenSach.ReadOnly = true;
            this.TenSach.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TinhTrang
            // 
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.MinimumWidth = 6;
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.ReadOnly = true;
            this.TinhTrang.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cUONSACHBindingSource
            // 
            this.cUONSACHBindingSource.DataSource = typeof(DTO.CUONSACH);
            // 
            // ErrorDia
            // 
            this.ErrorDia.Buttons = Siticone.Desktop.UI.WinForms.MessageDialogButtons.OK;
            this.ErrorDia.Caption = null;
            this.ErrorDia.Icon = Siticone.Desktop.UI.WinForms.MessageDialogIcon.Error;
            this.ErrorDia.Parent = null;
            this.ErrorDia.Style = Siticone.Desktop.UI.WinForms.MessageDialogStyle.Default;
            this.ErrorDia.Text = null;
            // 
            // AskDia
            // 
            this.AskDia.Buttons = Siticone.Desktop.UI.WinForms.MessageDialogButtons.YesNo;
            this.AskDia.Caption = null;
            this.AskDia.Icon = Siticone.Desktop.UI.WinForms.MessageDialogIcon.Question;
            this.AskDia.Parent = null;
            this.AskDia.Style = Siticone.Desktop.UI.WinForms.MessageDialogStyle.Default;
            this.AskDia.Text = null;
            // 
            // SuccDia
            // 
            this.SuccDia.Buttons = Siticone.Desktop.UI.WinForms.MessageDialogButtons.OK;
            this.SuccDia.Caption = null;
            this.SuccDia.Icon = Siticone.Desktop.UI.WinForms.MessageDialogIcon.None;
            this.SuccDia.Parent = null;
            this.SuccDia.Style = Siticone.Desktop.UI.WinForms.MessageDialogStyle.Default;
            this.SuccDia.Text = null;
            // 
            // ucCuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CuonSachGrid);
            this.Controls.Add(this.topPanel);
            this.Name = "ucCuonSach";
            this.Size = new System.Drawing.Size(997, 596);
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CuonSachGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUONSACHBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel topPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butHien;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox comboTinhTrang;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butTinhTrang;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butMaSach;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton butRefresh;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtMaSach;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butDel;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView CuonSachGrid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isChosen;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCuonSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.BindingSource cUONSACHBindingSource;
        private Siticone.Desktop.UI.WinForms.SiticoneMessageDialog ErrorDia;
        private Siticone.Desktop.UI.WinForms.SiticoneMessageDialog AskDia;
        private Siticone.Desktop.UI.WinForms.SiticoneMessageDialog SuccDia;
    }
}
