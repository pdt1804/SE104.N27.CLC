﻿namespace GUI.UserControls
{
    partial class ucTuaSach
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucTuaSach));
            this.topPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.butHien = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.butFil = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.comboTheLoai = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.butFind = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.txtFind = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.butAn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.butAdd = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.TuaSachGrid = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.isChosen = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTuaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTuaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.ErrorDia = new Siticone.Desktop.UI.WinForms.SiticoneMessageDialog();
            this.AskDia = new Siticone.Desktop.UI.WinForms.SiticoneMessageDialog();
            this.SuccDia = new Siticone.Desktop.UI.WinForms.SiticoneMessageDialog();
            this.butRefresh = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.tUASACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TuaSachGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUASACHBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.AliceBlue;
            this.topPanel.Controls.Add(this.butHien);
            this.topPanel.Controls.Add(this.butFil);
            this.topPanel.Controls.Add(this.comboTheLoai);
            this.topPanel.Controls.Add(this.butFind);
            this.topPanel.Controls.Add(this.txtFind);
            this.topPanel.Controls.Add(this.butRefresh);
            this.topPanel.Controls.Add(this.butAn);
            this.topPanel.Controls.Add(this.butAdd);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(997, 133);
            this.topPanel.TabIndex = 4;
            // 
            // butHien
            // 
            this.butHien.AutoRoundedCorners = true;
            this.butHien.BorderRadius = 20;
            this.butHien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butHien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butHien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butHien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butHien.FillColor = System.Drawing.Color.RoyalBlue;
            this.butHien.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butHien.ForeColor = System.Drawing.Color.White;
            this.butHien.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butHien.ImageOffset = new System.Drawing.Point(2, 0);
            this.butHien.Location = new System.Drawing.Point(311, 18);
            this.butHien.Name = "butHien";
            this.butHien.Size = new System.Drawing.Size(172, 42);
            this.butHien.TabIndex = 18;
            this.butHien.Text = "Hiện Tựa Sách";
            this.butHien.TextOffset = new System.Drawing.Point(3, 0);
            // 
            // butFil
            // 
            this.butFil.AutoRoundedCorners = true;
            this.butFil.BorderRadius = 17;
            this.butFil.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butFil.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butFil.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butFil.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butFil.FillColor = System.Drawing.Color.RoyalBlue;
            this.butFil.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFil.ForeColor = System.Drawing.Color.White;
            this.butFil.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butFil.ImageOffset = new System.Drawing.Point(3, 0);
            this.butFil.Location = new System.Drawing.Point(804, 18);
            this.butFil.Name = "butFil";
            this.butFil.Size = new System.Drawing.Size(152, 37);
            this.butFil.TabIndex = 17;
            this.butFil.Text = "Lọc Thể Loại";
            this.butFil.TextOffset = new System.Drawing.Point(3, 0);
            // 
            // comboTheLoai
            // 
            this.comboTheLoai.BackColor = System.Drawing.Color.Transparent;
            this.comboTheLoai.BorderRadius = 15;
            this.comboTheLoai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboTheLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTheLoai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboTheLoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboTheLoai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboTheLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboTheLoai.ItemHeight = 30;
            this.comboTheLoai.Location = new System.Drawing.Point(556, 18);
            this.comboTheLoai.Name = "comboTheLoai";
            this.comboTheLoai.Size = new System.Drawing.Size(227, 36);
            this.comboTheLoai.TabIndex = 16;
            // 
            // butFind
            // 
            this.butFind.AutoRoundedCorners = true;
            this.butFind.BorderRadius = 17;
            this.butFind.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butFind.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butFind.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butFind.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butFind.FillColor = System.Drawing.Color.RoyalBlue;
            this.butFind.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFind.ForeColor = System.Drawing.Color.White;
            this.butFind.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butFind.ImageOffset = new System.Drawing.Point(3, 0);
            this.butFind.Location = new System.Drawing.Point(804, 75);
            this.butFind.Name = "butFind";
            this.butFind.Size = new System.Drawing.Size(152, 37);
            this.butFind.TabIndex = 14;
            this.butFind.Text = "Tìm kiếm";
            this.butFind.TextOffset = new System.Drawing.Point(3, 0);
            // 
            // txtFind
            // 
            this.txtFind.AutoRoundedCorners = true;
            this.txtFind.BorderRadius = 17;
            this.txtFind.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFind.DefaultText = "";
            this.txtFind.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFind.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFind.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFind.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFind.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFind.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtFind.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txtFind.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFind.Location = new System.Drawing.Point(556, 75);
            this.txtFind.Name = "txtFind";
            this.txtFind.PasswordChar = '\0';
            this.txtFind.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtFind.PlaceholderText = "Mã, tên, tác giả";
            this.txtFind.SelectedText = "";
            this.txtFind.Size = new System.Drawing.Size(227, 37);
            this.txtFind.TabIndex = 15;
            // 
            // butAn
            // 
            this.butAn.AutoRoundedCorners = true;
            this.butAn.BorderRadius = 20;
            this.butAn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butAn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butAn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butAn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butAn.FillColor = System.Drawing.Color.RoyalBlue;
            this.butAn.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAn.ForeColor = System.Drawing.Color.White;
            this.butAn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butAn.ImageOffset = new System.Drawing.Point(2, 0);
            this.butAn.Location = new System.Drawing.Point(311, 75);
            this.butAn.Name = "butAn";
            this.butAn.Size = new System.Drawing.Size(172, 42);
            this.butAn.TabIndex = 5;
            this.butAn.Text = "Ẩn Tựa Sách";
            this.butAn.TextOffset = new System.Drawing.Point(3, 0);
            // 
            // butAdd
            // 
            this.butAdd.AutoRoundedCorners = true;
            this.butAdd.BorderRadius = 20;
            this.butAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butAdd.FillColor = System.Drawing.Color.RoyalBlue;
            this.butAdd.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAdd.ForeColor = System.Drawing.Color.White;
            this.butAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butAdd.ImageOffset = new System.Drawing.Point(2, 0);
            this.butAdd.Location = new System.Drawing.Point(25, 75);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(181, 42);
            this.butAdd.TabIndex = 6;
            this.butAdd.Text = "Thêm Tựa Sách";
            this.butAdd.TextOffset = new System.Drawing.Point(3, 0);
            // 
            // TuaSachGrid
            // 
            this.TuaSachGrid.AllowUserToAddRows = false;
            this.TuaSachGrid.AllowUserToDeleteRows = false;
            this.TuaSachGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.TuaSachGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TuaSachGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.TuaSachGrid.ColumnHeadersHeight = 35;
            this.TuaSachGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.TuaSachGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isChosen,
            this.id,
            this.MaTuaSach,
            this.TenTuaSach,
            this.TheLoai,
            this.TacGia,
            this.DaAn,
            this.Edit});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TuaSachGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.TuaSachGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TuaSachGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TuaSachGrid.Location = new System.Drawing.Point(0, 0);
            this.TuaSachGrid.Name = "TuaSachGrid";
            this.TuaSachGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TuaSachGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.TuaSachGrid.RowHeadersVisible = false;
            this.TuaSachGrid.RowHeadersWidth = 51;
            this.TuaSachGrid.RowTemplate.Height = 30;
            this.TuaSachGrid.Size = new System.Drawing.Size(997, 596);
            this.TuaSachGrid.TabIndex = 5;
            this.TuaSachGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.TuaSachGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.TuaSachGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.TuaSachGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.TuaSachGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.TuaSachGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.TuaSachGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TuaSachGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TuaSachGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TuaSachGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TuaSachGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.TuaSachGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.TuaSachGrid.ThemeStyle.HeaderStyle.Height = 35;
            this.TuaSachGrid.ThemeStyle.ReadOnly = false;
            this.TuaSachGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.TuaSachGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TuaSachGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TuaSachGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.TuaSachGrid.ThemeStyle.RowsStyle.Height = 30;
            this.TuaSachGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TuaSachGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // MaTuaSach
            // 
            this.MaTuaSach.HeaderText = "Mã tựa sách";
            this.MaTuaSach.MinimumWidth = 6;
            this.MaTuaSach.Name = "MaTuaSach";
            this.MaTuaSach.ReadOnly = true;
            // 
            // TenTuaSach
            // 
            this.TenTuaSach.HeaderText = "Tên tựa sách";
            this.TenTuaSach.MinimumWidth = 6;
            this.TenTuaSach.Name = "TenTuaSach";
            this.TenTuaSach.ReadOnly = true;
            // 
            // TheLoai
            // 
            this.TheLoai.HeaderText = "Thể loại";
            this.TheLoai.MinimumWidth = 6;
            this.TheLoai.Name = "TheLoai";
            this.TheLoai.ReadOnly = true;
            // 
            // TacGia
            // 
            this.TacGia.HeaderText = "Tác giả";
            this.TacGia.MinimumWidth = 6;
            this.TacGia.Name = "TacGia";
            this.TacGia.ReadOnly = true;
            // 
            // DaAn
            // 
            this.DaAn.DataPropertyName = "DaAn";
            this.DaAn.HeaderText = "Đã ẩn";
            this.DaAn.MinimumWidth = 6;
            this.DaAn.Name = "DaAn";
            this.DaAn.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle7.NullValue")));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.DefaultCellStyle = dataGridViewCellStyle7;
            this.Edit.HeaderText = "";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Edit.Width = 6;
            // 
            // ErrorDia
            // 
            this.ErrorDia.Buttons = Siticone.Desktop.UI.WinForms.MessageDialogButtons.RetryCancel;
            this.ErrorDia.Caption = null;
            this.ErrorDia.Icon = Siticone.Desktop.UI.WinForms.MessageDialogIcon.Error;
            this.ErrorDia.Parent = null;
            this.ErrorDia.Style = Siticone.Desktop.UI.WinForms.MessageDialogStyle.Light;
            this.ErrorDia.Text = null;
            // 
            // AskDia
            // 
            this.AskDia.Buttons = Siticone.Desktop.UI.WinForms.MessageDialogButtons.YesNo;
            this.AskDia.Caption = null;
            this.AskDia.Icon = Siticone.Desktop.UI.WinForms.MessageDialogIcon.Question;
            this.AskDia.Parent = null;
            this.AskDia.Style = Siticone.Desktop.UI.WinForms.MessageDialogStyle.Light;
            this.AskDia.Text = null;
            // 
            // SuccDia
            // 
            this.SuccDia.Buttons = Siticone.Desktop.UI.WinForms.MessageDialogButtons.OK;
            this.SuccDia.Caption = null;
            this.SuccDia.Icon = Siticone.Desktop.UI.WinForms.MessageDialogIcon.Information;
            this.SuccDia.Parent = null;
            this.SuccDia.Style = Siticone.Desktop.UI.WinForms.MessageDialogStyle.Light;
            this.SuccDia.Text = null;
            // 
            // butRefresh
            // 
            this.butRefresh.CheckedState.ImageSize = new System.Drawing.Size(45, 45);
            this.butRefresh.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.butRefresh.Image = global::GUI.Properties.Resources.refresh__2_;
            this.butRefresh.ImageOffset = new System.Drawing.Point(0, 0);
            this.butRefresh.ImageRotate = 0F;
            this.butRefresh.ImageSize = new System.Drawing.Size(50, 50);
            this.butRefresh.Location = new System.Drawing.Point(15, 7);
            this.butRefresh.Name = "butRefresh";
            this.butRefresh.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.butRefresh.Size = new System.Drawing.Size(64, 54);
            this.butRefresh.TabIndex = 9;
            // 
            // tUASACHBindingSource
            // 
            this.tUASACHBindingSource.DataSource = typeof(DTO.TUASACH);
            // 
            // ucTuaSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.TuaSachGrid);
            this.Name = "ucTuaSach";
            this.Size = new System.Drawing.Size(997, 596);
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TuaSachGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUASACHBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel topPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butHien;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butFil;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox comboTheLoai;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butFind;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtFind;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton butRefresh;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butAn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butAdd;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView TuaSachGrid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isChosen;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTuaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTuaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaAn;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.BindingSource tUASACHBindingSource;
        private Siticone.Desktop.UI.WinForms.SiticoneMessageDialog ErrorDia;
        private Siticone.Desktop.UI.WinForms.SiticoneMessageDialog AskDia;
        private Siticone.Desktop.UI.WinForms.SiticoneMessageDialog SuccDia;
    }
}