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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AskDia = new Siticone.Desktop.UI.WinForms.SiticoneMessageDialog();
            this.SuccDia = new Siticone.Desktop.UI.WinForms.SiticoneMessageDialog();
            this.ErrorDia = new Siticone.Desktop.UI.WinForms.SiticoneMessageDialog();
            this.siticoneCreditCardValidationTool1 = new Siticone.Desktop.UI.Winforms.SiticoneCreditCardValidationTool();
            this.siticoneContextMenuStrip1 = new Siticone.Desktop.UI.WinForms.SiticoneContextMenuStrip();
            this.SachGrid = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTuaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TuaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConLai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboTinhTrang = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.butAddOld = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.butAdd = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.txtMaSach = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.topPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.butRefresh = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
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
            // SachGrid
            // 
            this.SachGrid.AllowUserToAddRows = false;
            this.SachGrid.AllowUserToDeleteRows = false;
            this.SachGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.SachGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SachGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.SachGrid.ColumnHeadersHeight = 35;
            this.SachGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.SachGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.MaSach,
            this.MaTuaSach,
            this.TuaSach,
            this.NamXB,
            this.NXB,
            this.SoLuong,
            this.ConLai});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SachGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.SachGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SachGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SachGrid.Location = new System.Drawing.Point(0, 138);
            this.SachGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SachGrid.Name = "SachGrid";
            this.SachGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SachGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
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
            // MaSach
            // 
            this.MaSach.FillWeight = 110.0789F;
            this.MaSach.HeaderText = "Mã sách";
            this.MaSach.MinimumWidth = 6;
            this.MaSach.Name = "MaSach";
            this.MaSach.ReadOnly = true;
            // 
            // MaTuaSach
            // 
            this.MaTuaSach.FillWeight = 110.0789F;
            this.MaTuaSach.HeaderText = "Mã tựa sách";
            this.MaTuaSach.MinimumWidth = 6;
            this.MaTuaSach.Name = "MaTuaSach";
            this.MaTuaSach.ReadOnly = true;
            // 
            // TuaSach
            // 
            this.TuaSach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TuaSach.FillWeight = 110.0789F;
            this.TuaSach.HeaderText = "Tựa Sách";
            this.TuaSach.MinimumWidth = 6;
            this.TuaSach.Name = "TuaSach";
            this.TuaSach.ReadOnly = true;
            // 
            // NamXB
            // 
            this.NamXB.FillWeight = 110.0789F;
            this.NamXB.HeaderText = "Năm XB";
            this.NamXB.MinimumWidth = 6;
            this.NamXB.Name = "NamXB";
            this.NamXB.ReadOnly = true;
            // 
            // NXB
            // 
            this.NXB.FillWeight = 110.0789F;
            this.NXB.HeaderText = "NXB";
            this.NXB.MinimumWidth = 6;
            this.NXB.Name = "NXB";
            this.NXB.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.FillWeight = 110.0789F;
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // ConLai
            // 
            this.ConLai.FillWeight = 110.0789F;
            this.ConLai.HeaderText = "Còn lại";
            this.ConLai.MinimumWidth = 6;
            this.ConLai.Name = "ConLai";
            this.ConLai.ReadOnly = true;
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
            this.comboTinhTrang.Location = new System.Drawing.Point(500, 20);
            this.comboTinhTrang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboTinhTrang.Name = "comboTinhTrang";
            this.comboTinhTrang.Size = new System.Drawing.Size(188, 36);
            this.comboTinhTrang.TabIndex = 15;
            this.comboTinhTrang.SelectedIndexChanged += new System.EventHandler(this.comboTinhTrang_SelectedIndexChanged);
            this.comboTinhTrang.SelectedValueChanged += new System.EventHandler(this.comboTinhTrang_SelectedValueChanged);
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
            this.butAddOld.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butAddOld.Name = "butAddOld";
            this.butAddOld.Size = new System.Drawing.Size(176, 34);
            this.butAddOld.TabIndex = 4;
            this.butAddOld.Text = "Nhập Sách Đã Có";
            this.butAddOld.TextOffset = new System.Drawing.Point(3, 0);
            this.butAddOld.Click += new System.EventHandler(this.butAddOld_Click);
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
            this.butAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(176, 34);
            this.butAdd.TabIndex = 4;
            this.butAdd.Text = "Nhập Sách Mới";
            this.butAdd.TextOffset = new System.Drawing.Point(3, 0);
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
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
            this.txtMaSach.Location = new System.Drawing.Point(500, 77);
            this.txtMaSach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.PasswordChar = '\0';
            this.txtMaSach.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtMaSach.PlaceholderText = "Mã sách";
            this.txtMaSach.SelectedText = "";
            this.txtMaSach.Size = new System.Drawing.Size(188, 34);
            this.txtMaSach.TabIndex = 13;
            this.txtMaSach.TextChanged += new System.EventHandler(this.txtMaSach_TextChanged);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.AliceBlue;
            this.topPanel.Controls.Add(this.siticoneButton1);
            this.topPanel.Controls.Add(this.comboTinhTrang);
            this.topPanel.Controls.Add(this.butRefresh);
            this.topPanel.Controls.Add(this.butAddOld);
            this.topPanel.Controls.Add(this.butAdd);
            this.topPanel.Controls.Add(this.txtMaSach);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.butRefresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butRefresh.Name = "butRefresh";
            this.butRefresh.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.butRefresh.Size = new System.Drawing.Size(48, 44);
            this.butRefresh.TabIndex = 8;
            this.butRefresh.Click += new System.EventHandler(this.butRefresh_Click);
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.AutoRoundedCorners = true;
            this.siticoneButton1.BorderColor = System.Drawing.Color.Transparent;
            this.siticoneButton1.BorderRadius = 16;
            this.siticoneButton1.BorderThickness = 2;
            this.siticoneButton1.CheckedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneButton1.CheckedState.CustomBorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneButton1.CheckedState.FillColor = System.Drawing.Color.Lavender;
            this.siticoneButton1.CheckedState.ForeColor = System.Drawing.Color.DodgerBlue;
            this.siticoneButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton1.FillColor = System.Drawing.Color.RoyalBlue;
            this.siticoneButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.HoverState.BorderColor = System.Drawing.Color.RoyalBlue;
            this.siticoneButton1.HoverState.CustomBorderColor = System.Drawing.Color.RoyalBlue;
            this.siticoneButton1.HoverState.FillColor = System.Drawing.Color.Lavender;
            this.siticoneButton1.HoverState.ForeColor = System.Drawing.Color.RoyalBlue;
            this.siticoneButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.siticoneButton1.ImageOffset = new System.Drawing.Point(2, 0);
            this.siticoneButton1.Location = new System.Drawing.Point(308, 20);
            this.siticoneButton1.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.Size = new System.Drawing.Size(176, 34);
            this.siticoneButton1.TabIndex = 16;
            this.siticoneButton1.Text = "Quét sách";
            this.siticoneButton1.TextOffset = new System.Drawing.Point(3, 0);
            this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private Siticone.Desktop.UI.WinForms.SiticoneContextMenuStrip siticoneContextMenuStrip1;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView SachGrid;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox comboTinhTrang;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton butRefresh;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butAddOld;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butAdd;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtMaSach;
        private Siticone.Desktop.UI.WinForms.SiticonePanel topPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTuaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TuaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn NXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConLai;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
    }
}
