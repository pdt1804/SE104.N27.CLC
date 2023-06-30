namespace GUI.UserControls
{
    partial class ucSach
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AskDia = new Siticone.Desktop.UI.WinForms.SiticoneMessageDialog();
            this.SuccDia = new Siticone.Desktop.UI.WinForms.SiticoneMessageDialog();
            this.ErrorDia = new Siticone.Desktop.UI.WinForms.SiticoneMessageDialog();
            this.siticoneCreditCardValidationTool1 = new Siticone.Desktop.UI.Winforms.SiticoneCreditCardValidationTool();
            this.DaAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConLai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TuaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTuaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siticoneContextMenuStrip1 = new Siticone.Desktop.UI.WinForms.SiticoneContextMenuStrip();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isChosen = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SachGrid = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboTinhTrang = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.butTenSach = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.butMaSach = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.butAddOld = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.butAdd = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.txtMaSach = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.topPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.butRefresh = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.sACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SachGrid)).BeginInit();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.SuccDia.Icon = Siticone.Desktop.UI.WinForms.MessageDialogIcon.None;
            this.SuccDia.Parent = null;
            this.SuccDia.Style = Siticone.Desktop.UI.WinForms.MessageDialogStyle.Light;
            this.SuccDia.Text = null;
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
            // DaAn
            // 
            this.DaAn.DataPropertyName = "DaAn";
            this.DaAn.HeaderText = "Đã ẩn";
            this.DaAn.MinimumWidth = 6;
            this.DaAn.Name = "DaAn";
            this.DaAn.ReadOnly = true;
            this.DaAn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ConLai
            // 
            this.ConLai.HeaderText = "Còn lại";
            this.ConLai.MinimumWidth = 6;
            this.ConLai.Name = "ConLai";
            this.ConLai.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // NXB
            // 
            this.NXB.HeaderText = "NXB";
            this.NXB.MinimumWidth = 6;
            this.NXB.Name = "NXB";
            this.NXB.ReadOnly = true;
            // 
            // NamXB
            // 
            this.NamXB.HeaderText = "Năm XB";
            this.NamXB.MinimumWidth = 6;
            this.NamXB.Name = "NamXB";
            this.NamXB.ReadOnly = true;
            // 
            // TuaSach
            // 
            this.TuaSach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TuaSach.HeaderText = "Tựa Sách";
            this.TuaSach.MinimumWidth = 6;
            this.TuaSach.Name = "TuaSach";
            this.TuaSach.ReadOnly = true;
            // 
            // MaTuaSach
            // 
            this.MaTuaSach.HeaderText = "Mã tựa sách";
            this.MaTuaSach.MinimumWidth = 6;
            this.MaTuaSach.Name = "MaTuaSach";
            this.MaTuaSach.ReadOnly = true;
            // 
            // siticoneContextMenuStrip1
            // 
            this.siticoneContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.siticoneContextMenuStrip1.Name = "siticoneContextMenuStrip1";
            this.siticoneContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.siticoneContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.siticoneContextMenuStrip1.RenderStyle.ColorTable = null;
            this.siticoneContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.siticoneContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.siticoneContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.siticoneContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.siticoneContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.siticoneContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.siticoneContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MaSach
            // 
            this.MaSach.HeaderText = "Mã sách";
            this.MaSach.MinimumWidth = 6;
            this.MaSach.Name = "MaSach";
            this.MaSach.ReadOnly = true;
            // 
            // isChosen
            // 
            this.isChosen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.isChosen.FalseValue = "0";
            this.isChosen.HeaderText = "";
            this.isChosen.IndeterminateValue = "0";
            this.isChosen.MinimumWidth = 6;
            this.isChosen.Name = "isChosen";
            this.isChosen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isChosen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.isChosen.TrueValue = "1";
            this.isChosen.Width = 17;
            // 
            // SachGrid
            // 
            this.SachGrid.AllowUserToAddRows = false;
            this.SachGrid.AllowUserToDeleteRows = false;
            this.SachGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.SachGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SachGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.SachGrid.ColumnHeadersHeight = 35;
            this.SachGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.SachGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isChosen,
            this.id,
            this.MaSach,
            this.MaTuaSach,
            this.TuaSach,
            this.NamXB,
            this.NXB,
            this.SoLuong,
            this.ConLai,
            this.DaAn});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SachGrid.DefaultCellStyle = dataGridViewCellStyle9;
            this.SachGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SachGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SachGrid.Location = new System.Drawing.Point(0, 138);
            this.SachGrid.Margin = new System.Windows.Forms.Padding(2);
            this.SachGrid.Name = "SachGrid";
            this.SachGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SachGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.SachGrid.RowHeadersVisible = false;
            this.SachGrid.RowHeadersWidth = 51;
            this.SachGrid.RowTemplate.Height = 30;
            this.SachGrid.Size = new System.Drawing.Size(948, 380);
            this.SachGrid.TabIndex = 4;
            this.SachGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.SachGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.SachGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.SachGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.SachGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.SachGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.SachGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SachGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.SachGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SachGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SachGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.SachGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.SachGrid.ThemeStyle.HeaderStyle.Height = 35;
            this.SachGrid.ThemeStyle.ReadOnly = false;
            this.SachGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.SachGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.SachGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SachGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.SachGrid.ThemeStyle.RowsStyle.Height = 30;
            this.SachGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SachGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // id
            // 
            this.id.HeaderText = "";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Visible = false;
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
            this.comboTinhTrang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTinhTrang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboTinhTrang.ItemHeight = 30;
            this.comboTinhTrang.Location = new System.Drawing.Point(575, 20);
            this.comboTinhTrang.Margin = new System.Windows.Forms.Padding(2);
            this.comboTinhTrang.Name = "comboTinhTrang";
            this.comboTinhTrang.Size = new System.Drawing.Size(188, 36);
            this.comboTinhTrang.TabIndex = 15;
            this.comboTinhTrang.SelectedValueChanged += new System.EventHandler(this.comboTinhTrang_SelectedValueChanged);
            // 
            // butTenSach
            // 
            this.butTenSach.AutoRoundedCorners = true;
            this.butTenSach.BorderColor = System.Drawing.Color.Transparent;
            this.butTenSach.BorderRadius = 16;
            this.butTenSach.BorderThickness = 2;
            this.butTenSach.CheckedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.butTenSach.CheckedState.CustomBorderColor = System.Drawing.Color.DodgerBlue;
            this.butTenSach.CheckedState.FillColor = System.Drawing.Color.Lavender;
            this.butTenSach.CheckedState.ForeColor = System.Drawing.Color.DodgerBlue;
            this.butTenSach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butTenSach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butTenSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butTenSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butTenSach.FillColor = System.Drawing.Color.RoyalBlue;
            this.butTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butTenSach.ForeColor = System.Drawing.Color.White;
            this.butTenSach.HoverState.BorderColor = System.Drawing.Color.RoyalBlue;
            this.butTenSach.HoverState.CustomBorderColor = System.Drawing.Color.RoyalBlue;
            this.butTenSach.HoverState.FillColor = System.Drawing.Color.Lavender;
            this.butTenSach.HoverState.ForeColor = System.Drawing.Color.RoyalBlue;
            this.butTenSach.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butTenSach.ImageOffset = new System.Drawing.Point(3, 0);
            this.butTenSach.Location = new System.Drawing.Point(782, 20);
            this.butTenSach.Margin = new System.Windows.Forms.Padding(2);
            this.butTenSach.Name = "butTenSach";
            this.butTenSach.Size = new System.Drawing.Size(145, 34);
            this.butTenSach.TabIndex = 14;
            this.butTenSach.Text = "Lọc tình trạng";
            this.butTenSach.TextOffset = new System.Drawing.Point(3, 0);
            // 
            // butMaSach
            // 
            this.butMaSach.AutoRoundedCorners = true;
            this.butMaSach.BorderColor = System.Drawing.Color.Transparent;
            this.butMaSach.BorderRadius = 16;
            this.butMaSach.BorderThickness = 2;
            this.butMaSach.CheckedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.butMaSach.CheckedState.CustomBorderColor = System.Drawing.Color.DodgerBlue;
            this.butMaSach.CheckedState.FillColor = System.Drawing.Color.Lavender;
            this.butMaSach.CheckedState.ForeColor = System.Drawing.Color.DodgerBlue;
            this.butMaSach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butMaSach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butMaSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butMaSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butMaSach.FillColor = System.Drawing.Color.RoyalBlue;
            this.butMaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butMaSach.ForeColor = System.Drawing.Color.White;
            this.butMaSach.HoverState.BorderColor = System.Drawing.Color.RoyalBlue;
            this.butMaSach.HoverState.CustomBorderColor = System.Drawing.Color.RoyalBlue;
            this.butMaSach.HoverState.FillColor = System.Drawing.Color.Lavender;
            this.butMaSach.HoverState.ForeColor = System.Drawing.Color.RoyalBlue;
            this.butMaSach.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butMaSach.ImageOffset = new System.Drawing.Point(3, 0);
            this.butMaSach.Location = new System.Drawing.Point(782, 77);
            this.butMaSach.Margin = new System.Windows.Forms.Padding(2);
            this.butMaSach.Name = "butMaSach";
            this.butMaSach.Size = new System.Drawing.Size(145, 34);
            this.butMaSach.TabIndex = 9;
            this.butMaSach.Text = "Tìm kiếm";
            this.butMaSach.TextOffset = new System.Drawing.Point(3, 0);
            // 
            // butAddOld
            // 
            this.butAddOld.AutoRoundedCorners = true;
            this.butAddOld.BorderColor = System.Drawing.Color.Transparent;
            this.butAddOld.BorderRadius = 16;
            this.butAddOld.BorderThickness = 2;
            this.butAddOld.CheckedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.butAddOld.CheckedState.CustomBorderColor = System.Drawing.Color.DodgerBlue;
            this.butAddOld.CheckedState.FillColor = System.Drawing.Color.Lavender;
            this.butAddOld.CheckedState.ForeColor = System.Drawing.Color.DodgerBlue;
            this.butAddOld.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butAddOld.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butAddOld.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butAddOld.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butAddOld.FillColor = System.Drawing.Color.RoyalBlue;
            this.butAddOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.butAddOld.ForeColor = System.Drawing.Color.White;
            this.butAddOld.HoverState.BorderColor = System.Drawing.Color.RoyalBlue;
            this.butAddOld.HoverState.CustomBorderColor = System.Drawing.Color.RoyalBlue;
            this.butAddOld.HoverState.FillColor = System.Drawing.Color.Lavender;
            this.butAddOld.HoverState.ForeColor = System.Drawing.Color.RoyalBlue;
            this.butAddOld.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butAddOld.ImageOffset = new System.Drawing.Point(2, 0);
            this.butAddOld.Location = new System.Drawing.Point(118, 20);
            this.butAddOld.Margin = new System.Windows.Forms.Padding(2);
            this.butAddOld.Name = "butAddOld";
            this.butAddOld.Size = new System.Drawing.Size(176, 34);
            this.butAddOld.TabIndex = 4;
            this.butAddOld.Text = "Nhập Sách Đã Có";
            this.butAddOld.TextOffset = new System.Drawing.Point(3, 0);
            // 
            // butAdd
            // 
            this.butAdd.AutoRoundedCorners = true;
            this.butAdd.BorderColor = System.Drawing.Color.Transparent;
            this.butAdd.BorderRadius = 16;
            this.butAdd.BorderThickness = 2;
            this.butAdd.CheckedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.butAdd.CheckedState.CustomBorderColor = System.Drawing.Color.DodgerBlue;
            this.butAdd.CheckedState.FillColor = System.Drawing.Color.Lavender;
            this.butAdd.CheckedState.ForeColor = System.Drawing.Color.DodgerBlue;
            this.butAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butAdd.FillColor = System.Drawing.Color.RoyalBlue;
            this.butAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.butAdd.ForeColor = System.Drawing.Color.White;
            this.butAdd.HoverState.BorderColor = System.Drawing.Color.RoyalBlue;
            this.butAdd.HoverState.CustomBorderColor = System.Drawing.Color.RoyalBlue;
            this.butAdd.HoverState.FillColor = System.Drawing.Color.Lavender;
            this.butAdd.HoverState.ForeColor = System.Drawing.Color.RoyalBlue;
            this.butAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butAdd.ImageOffset = new System.Drawing.Point(2, 0);
            this.butAdd.Location = new System.Drawing.Point(118, 77);
            this.butAdd.Margin = new System.Windows.Forms.Padding(2);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(176, 34);
            this.butAdd.TabIndex = 4;
            this.butAdd.Text = "Nhập Sách Mới";
            this.butAdd.TextOffset = new System.Drawing.Point(3, 0);
            // 
            // txtMaSach
            // 
            this.txtMaSach.AutoRoundedCorners = true;
            this.txtMaSach.BorderRadius = 16;
            this.txtMaSach.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaSach.DefaultText = "";
            this.txtMaSach.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaSach.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaSach.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaSach.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSach.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txtMaSach.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaSach.Location = new System.Drawing.Point(575, 77);
            this.txtMaSach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.PasswordChar = '\0';
            this.txtMaSach.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtMaSach.PlaceholderText = "Mã sách";
            this.txtMaSach.SelectedText = "";
            this.txtMaSach.Size = new System.Drawing.Size(188, 34);
            this.txtMaSach.TabIndex = 13;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.AliceBlue;
            this.topPanel.Controls.Add(this.comboTinhTrang);
            this.topPanel.Controls.Add(this.butTenSach);
            this.topPanel.Controls.Add(this.butRefresh);
            this.topPanel.Controls.Add(this.butMaSach);
            this.topPanel.Controls.Add(this.butAddOld);
            this.topPanel.Controls.Add(this.butAdd);
            this.topPanel.Controls.Add(this.txtMaSach);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(948, 138);
            this.topPanel.TabIndex = 3;
            // 
            // butRefresh
            // 
            this.butRefresh.CheckedState.ImageSize = new System.Drawing.Size(45, 45);
            this.butRefresh.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.butRefresh.Image = global::GUI.Properties.Resources.refresh__2_;
            this.butRefresh.ImageOffset = new System.Drawing.Point(0, 0);
            this.butRefresh.ImageRotate = 0F;
            this.butRefresh.ImageSize = new System.Drawing.Size(50, 50);
            this.butRefresh.Location = new System.Drawing.Point(14, 20);
            this.butRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.butRefresh.Name = "butRefresh";
            this.butRefresh.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.butRefresh.Size = new System.Drawing.Size(48, 44);
            this.butRefresh.TabIndex = 8;
            this.butRefresh.Click += new System.EventHandler(this.butRefresh_Click);
            // 
            // sACHBindingSource
            // 
            this.sACHBindingSource.DataSource = typeof(DTO.SACH);
            // 
            // ucSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SachGrid);
            this.Controls.Add(this.topPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucSach";
            this.Size = new System.Drawing.Size(948, 518);
            ((System.ComponentModel.ISupportInitialize)(this.SachGrid)).EndInit();
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneMessageDialog AskDia;
        private Siticone.Desktop.UI.WinForms.SiticoneMessageDialog SuccDia;
        private Siticone.Desktop.UI.WinForms.SiticoneMessageDialog ErrorDia;
        private System.Windows.Forms.BindingSource sACHBindingSource;
        private Siticone.Desktop.UI.Winforms.SiticoneCreditCardValidationTool siticoneCreditCardValidationTool1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConLai;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TuaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTuaSach;
        private Siticone.Desktop.UI.WinForms.SiticoneContextMenuStrip siticoneContextMenuStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isChosen;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView SachGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox comboTinhTrang;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butTenSach;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton butRefresh;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butMaSach;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butAddOld;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butAdd;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtMaSach;
        private Siticone.Desktop.UI.WinForms.SiticonePanel topPanel;
    }
}
