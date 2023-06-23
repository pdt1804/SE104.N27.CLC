namespace GUI.UserControls
{
    partial class ucMuonTheoTheLoai
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGrid = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.MaTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuotMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiLe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.dateBC = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            this.butDel = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.labelTongLM = new System.Windows.Forms.Label();
            this.butAdd = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.errDia = new Siticone.Desktop.UI.WinForms.SiticoneMessageDialog();
            this.siticoneMessageDialog1 = new Siticone.Desktop.UI.WinForms.SiticoneMessageDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToResizeColumns = false;
            this.dataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid.ColumnHeadersHeight = 35;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTheLoai,
            this.TenTheLoai,
            this.SoLuotMuon,
            this.TiLe});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGrid.Location = new System.Drawing.Point(0, 100);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 30;
            this.dataGrid.Size = new System.Drawing.Size(1052, 576);
            this.dataGrid.TabIndex = 5;
            this.dataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGrid.ThemeStyle.HeaderStyle.Height = 35;
            this.dataGrid.ThemeStyle.ReadOnly = true;
            this.dataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGrid.ThemeStyle.RowsStyle.Height = 30;
            this.dataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // MaTheLoai
            // 
            this.MaTheLoai.HeaderText = "Mã Thể Loại";
            this.MaTheLoai.MinimumWidth = 6;
            this.MaTheLoai.Name = "MaTheLoai";
            this.MaTheLoai.ReadOnly = true;
            // 
            // TenTheLoai
            // 
            this.TenTheLoai.HeaderText = "Tên Thể Loại";
            this.TenTheLoai.MinimumWidth = 6;
            this.TenTheLoai.Name = "TenTheLoai";
            this.TenTheLoai.ReadOnly = true;
            // 
            // SoLuotMuon
            // 
            this.SoLuotMuon.HeaderText = "Số Lượt Mượn";
            this.SoLuotMuon.MinimumWidth = 6;
            this.SoLuotMuon.Name = "SoLuotMuon";
            this.SoLuotMuon.ReadOnly = true;
            // 
            // TiLe
            // 
            this.TiLe.HeaderText = "Tỉ Lệ";
            this.TiLe.MinimumWidth = 6;
            this.TiLe.Name = "TiLe";
            this.TiLe.ReadOnly = true;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.AliceBlue;
            this.topPanel.Controls.Add(this.dateBC);
            this.topPanel.Controls.Add(this.butDel);
            this.topPanel.Controls.Add(this.labelTongLM);
            this.topPanel.Controls.Add(this.butAdd);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1052, 100);
            this.topPanel.TabIndex = 4;
            // 
            // dateBC
            // 
            this.dateBC.BorderRadius = 20;
            this.dateBC.Checked = true;
            this.dateBC.FillColor = System.Drawing.Color.RoyalBlue;
            this.dateBC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateBC.ForeColor = System.Drawing.Color.White;
            this.dateBC.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateBC.Location = new System.Drawing.Point(47, 30);
            this.dateBC.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateBC.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateBC.Name = "dateBC";
            this.dateBC.Size = new System.Drawing.Size(193, 45);
            this.dateBC.TabIndex = 20;
            this.dateBC.Value = new System.DateTime(2023, 6, 23, 1, 42, 55, 149);
            // 
            // butDel
            // 
            this.butDel.AutoRoundedCorners = true;
            this.butDel.BorderColor = System.Drawing.Color.Transparent;
            this.butDel.BorderRadius = 21;
            this.butDel.BorderThickness = 2;
            this.butDel.CheckedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.butDel.CheckedState.CustomBorderColor = System.Drawing.Color.DodgerBlue;
            this.butDel.CheckedState.FillColor = System.Drawing.Color.Lavender;
            this.butDel.CheckedState.ForeColor = System.Drawing.Color.DodgerBlue;
            this.butDel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butDel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butDel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butDel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butDel.FillColor = System.Drawing.Color.RoyalBlue;
            this.butDel.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDel.ForeColor = System.Drawing.Color.White;
            this.butDel.HoverState.BorderColor = System.Drawing.Color.RoyalBlue;
            this.butDel.HoverState.CustomBorderColor = System.Drawing.Color.RoyalBlue;
            this.butDel.HoverState.FillColor = System.Drawing.Color.Lavender;
            this.butDel.HoverState.ForeColor = System.Drawing.Color.RoyalBlue;
            this.butDel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butDel.ImageOffset = new System.Drawing.Point(2, 0);
            this.butDel.Location = new System.Drawing.Point(691, 30);
            this.butDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butDel.Name = "butDel";
            this.butDel.PressedColor = System.Drawing.Color.WhiteSmoke;
            this.butDel.Size = new System.Drawing.Size(174, 45);
            this.butDel.TabIndex = 19;
            this.butDel.Text = "Xóa Báo Cáo";
            this.butDel.TextOffset = new System.Drawing.Point(3, 0);
            // 
            // labelTongLM
            // 
            this.labelTongLM.AutoSize = true;
            this.labelTongLM.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTongLM.Location = new System.Drawing.Point(576, 60);
            this.labelTongLM.Name = "labelTongLM";
            this.labelTongLM.Size = new System.Drawing.Size(0, 37);
            this.labelTongLM.TabIndex = 3;
            // 
            // butAdd
            // 
            this.butAdd.AutoRoundedCorners = true;
            this.butAdd.BorderColor = System.Drawing.Color.Transparent;
            this.butAdd.BorderRadius = 21;
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
            this.butAdd.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold);
            this.butAdd.ForeColor = System.Drawing.Color.White;
            this.butAdd.HoverState.BorderColor = System.Drawing.Color.RoyalBlue;
            this.butAdd.HoverState.CustomBorderColor = System.Drawing.Color.RoyalBlue;
            this.butAdd.HoverState.FillColor = System.Drawing.Color.Lavender;
            this.butAdd.HoverState.ForeColor = System.Drawing.Color.RoyalBlue;
            this.butAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butAdd.ImageOffset = new System.Drawing.Point(2, 0);
            this.butAdd.Location = new System.Drawing.Point(319, 30);
            this.butAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butAdd.Name = "butAdd";
            this.butAdd.PressedColor = System.Drawing.Color.WhiteSmoke;
            this.butAdd.Size = new System.Drawing.Size(178, 45);
            this.butAdd.TabIndex = 2;
            this.butAdd.Text = "Tạo Báo Cáo";
            this.butAdd.TextOffset = new System.Drawing.Point(3, 0);
            // 
            // errDia
            // 
            this.errDia.Buttons = Siticone.Desktop.UI.WinForms.MessageDialogButtons.OK;
            this.errDia.Caption = null;
            this.errDia.Icon = Siticone.Desktop.UI.WinForms.MessageDialogIcon.Error;
            this.errDia.Parent = null;
            this.errDia.Style = Siticone.Desktop.UI.WinForms.MessageDialogStyle.Light;
            this.errDia.Text = null;
            // 
            // siticoneMessageDialog1
            // 
            this.siticoneMessageDialog1.Buttons = Siticone.Desktop.UI.WinForms.MessageDialogButtons.OK;
            this.siticoneMessageDialog1.Caption = null;
            this.siticoneMessageDialog1.Icon = Siticone.Desktop.UI.WinForms.MessageDialogIcon.None;
            this.siticoneMessageDialog1.Parent = null;
            this.siticoneMessageDialog1.Style = Siticone.Desktop.UI.WinForms.MessageDialogStyle.Default;
            this.siticoneMessageDialog1.Text = null;
            // 
            // ucMuonTheoTheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.topPanel);
            this.Name = "ucMuonTheoTheLoai";
            this.Size = new System.Drawing.Size(1052, 676);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuotMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiLe;
        private Siticone.Desktop.UI.WinForms.SiticonePanel topPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butDel;
        private System.Windows.Forms.Label labelTongLM;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butAdd;
        private Siticone.Desktop.UI.WinForms.SiticoneMessageDialog errDia;
        private Siticone.Desktop.UI.WinForms.SiticoneMessageDialog siticoneMessageDialog1;
        private Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker dateBC;
    }
}
