﻿namespace GUI.UserControls
{
    partial class ucLoaiDG
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
            this.LoaiDocGiaGrid = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.topPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.txtTenLoaiDG = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.butAdd = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.AskDia = new Siticone.Desktop.UI.WinForms.SiticoneMessageDialog();
            this.ErrorDia = new Siticone.Desktop.UI.WinForms.SiticoneMessageDialog();
            this.SuccDia = new Siticone.Desktop.UI.WinForms.SiticoneMessageDialog();
            this.butRefresh = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLoaiDocGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLoaiDocGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOAIDOCGIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.LoaiDocGiaGrid)).BeginInit();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIDOCGIABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LoaiDocGiaGrid
            // 
            this.LoaiDocGiaGrid.AllowUserToAddRows = false;
            this.LoaiDocGiaGrid.AllowUserToDeleteRows = false;
            this.LoaiDocGiaGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.LoaiDocGiaGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.LoaiDocGiaGrid.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LoaiDocGiaGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.LoaiDocGiaGrid.ColumnHeadersHeight = 35;
            this.LoaiDocGiaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.LoaiDocGiaGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.maLoaiDocGiaDataGridViewTextBoxColumn,
            this.tenLoaiDocGiaDataGridViewTextBoxColumn});
            this.LoaiDocGiaGrid.DataSource = this.lOAIDOCGIABindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LoaiDocGiaGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.LoaiDocGiaGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoaiDocGiaGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.LoaiDocGiaGrid.Location = new System.Drawing.Point(0, 78);
            this.LoaiDocGiaGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoaiDocGiaGrid.Name = "LoaiDocGiaGrid";
            this.LoaiDocGiaGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.LoaiDocGiaGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.LoaiDocGiaGrid.RowHeadersVisible = false;
            this.LoaiDocGiaGrid.RowHeadersWidth = 51;
            this.LoaiDocGiaGrid.RowTemplate.Height = 30;
            this.LoaiDocGiaGrid.Size = new System.Drawing.Size(653, 431);
            this.LoaiDocGiaGrid.TabIndex = 8;
            this.LoaiDocGiaGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.LoaiDocGiaGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.LoaiDocGiaGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.LoaiDocGiaGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.LoaiDocGiaGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.LoaiDocGiaGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.LoaiDocGiaGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.LoaiDocGiaGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.LoaiDocGiaGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.LoaiDocGiaGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoaiDocGiaGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.LoaiDocGiaGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.LoaiDocGiaGrid.ThemeStyle.HeaderStyle.Height = 35;
            this.LoaiDocGiaGrid.ThemeStyle.ReadOnly = false;
            this.LoaiDocGiaGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.LoaiDocGiaGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.LoaiDocGiaGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoaiDocGiaGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.LoaiDocGiaGrid.ThemeStyle.RowsStyle.Height = 30;
            this.LoaiDocGiaGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.LoaiDocGiaGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.AliceBlue;
            this.topPanel.Controls.Add(this.butRefresh);
            this.topPanel.Controls.Add(this.txtTenLoaiDG);
            this.topPanel.Controls.Add(this.butAdd);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.topPanel.Size = new System.Drawing.Size(653, 78);
            this.topPanel.TabIndex = 7;
            // 
            // txtTenLoaiDG
            // 
            this.txtTenLoaiDG.BorderColor = System.Drawing.Color.Silver;
            this.txtTenLoaiDG.BorderRadius = 15;
            this.txtTenLoaiDG.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenLoaiDG.DefaultText = "";
            this.txtTenLoaiDG.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenLoaiDG.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenLoaiDG.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenLoaiDG.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenLoaiDG.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenLoaiDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTenLoaiDG.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenLoaiDG.Location = new System.Drawing.Point(116, 23);
            this.txtTenLoaiDG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenLoaiDG.Name = "txtTenLoaiDG";
            this.txtTenLoaiDG.PasswordChar = '\0';
            this.txtTenLoaiDG.PlaceholderText = "Tên Loại Độc Giả";
            this.txtTenLoaiDG.SelectedText = "";
            this.txtTenLoaiDG.Size = new System.Drawing.Size(211, 35);
            this.txtTenLoaiDG.TabIndex = 11;
            this.txtTenLoaiDG.TextChanged += new System.EventHandler(this.txtTenLoaiDG_TextChanged);
            // 
            // butAdd
            // 
            this.butAdd.BorderColor = System.Drawing.Color.Transparent;
            this.butAdd.BorderRadius = 15;
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
            this.butAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.butAdd.ForeColor = System.Drawing.Color.White;
            this.butAdd.HoverState.BorderColor = System.Drawing.Color.RoyalBlue;
            this.butAdd.HoverState.CustomBorderColor = System.Drawing.Color.RoyalBlue;
            this.butAdd.HoverState.FillColor = System.Drawing.Color.Lavender;
            this.butAdd.HoverState.ForeColor = System.Drawing.Color.RoyalBlue;
            this.butAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butAdd.ImageOffset = new System.Drawing.Point(2, 0);
            this.butAdd.Location = new System.Drawing.Point(405, 23);
            this.butAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(154, 35);
            this.butAdd.TabIndex = 2;
            this.butAdd.Text = "Thêm Loại Độc Giả";
            this.butAdd.TextOffset = new System.Drawing.Point(3, 0);
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
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
            // ErrorDia
            // 
            this.ErrorDia.Buttons = Siticone.Desktop.UI.WinForms.MessageDialogButtons.OK;
            this.ErrorDia.Caption = null;
            this.ErrorDia.Icon = Siticone.Desktop.UI.WinForms.MessageDialogIcon.Error;
            this.ErrorDia.Parent = null;
            this.ErrorDia.Style = Siticone.Desktop.UI.WinForms.MessageDialogStyle.Light;
            this.ErrorDia.Text = null;
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
            this.butRefresh.Location = new System.Drawing.Point(12, 15);
            this.butRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.butRefresh.Name = "butRefresh";
            this.butRefresh.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.butRefresh.Size = new System.Drawing.Size(46, 45);
            this.butRefresh.TabIndex = 9;
            this.butRefresh.Click += new System.EventHandler(this.butRefresh_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // maLoaiDocGiaDataGridViewTextBoxColumn
            // 
            this.maLoaiDocGiaDataGridViewTextBoxColumn.DataPropertyName = "MaLoaiDocGia";
            this.maLoaiDocGiaDataGridViewTextBoxColumn.FillWeight = 109.893F;
            this.maLoaiDocGiaDataGridViewTextBoxColumn.HeaderText = "Mã loại độc giả";
            this.maLoaiDocGiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maLoaiDocGiaDataGridViewTextBoxColumn.Name = "maLoaiDocGiaDataGridViewTextBoxColumn";
            this.maLoaiDocGiaDataGridViewTextBoxColumn.ReadOnly = true;
            this.maLoaiDocGiaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tenLoaiDocGiaDataGridViewTextBoxColumn
            // 
            this.tenLoaiDocGiaDataGridViewTextBoxColumn.DataPropertyName = "TenLoaiDocGia";
            this.tenLoaiDocGiaDataGridViewTextBoxColumn.FillWeight = 109.893F;
            this.tenLoaiDocGiaDataGridViewTextBoxColumn.HeaderText = "Tên loại độc giả";
            this.tenLoaiDocGiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenLoaiDocGiaDataGridViewTextBoxColumn.Name = "tenLoaiDocGiaDataGridViewTextBoxColumn";
            this.tenLoaiDocGiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lOAIDOCGIABindingSource
            // 
            this.lOAIDOCGIABindingSource.DataSource = typeof(DTO.LOAIDOCGIA);
            // 
            // ucLoaiDG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LoaiDocGiaGrid);
            this.Controls.Add(this.topPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ucLoaiDG";
            this.Size = new System.Drawing.Size(653, 509);
            ((System.ComponentModel.ISupportInitialize)(this.LoaiDocGiaGrid)).EndInit();
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lOAIDOCGIABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView LoaiDocGiaGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiDocGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLoaiDocGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource lOAIDOCGIABindingSource;
        private Siticone.Desktop.UI.WinForms.SiticonePanel topPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton butRefresh;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtTenLoaiDG;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butAdd;
        private Siticone.Desktop.UI.WinForms.SiticoneMessageDialog AskDia;
        private Siticone.Desktop.UI.WinForms.SiticoneMessageDialog ErrorDia;
        private Siticone.Desktop.UI.WinForms.SiticoneMessageDialog SuccDia;
    }
}
