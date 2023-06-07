namespace GUI
{
    partial class formLogin
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
            this.siticoneBorderlessForm1 = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.siticoneDragControl1 = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
            this.siticoneDragControl2 = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
            this.exit = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox2 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneCustomGradientPanel1 = new Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtUserpwd = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.butLogin = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.customPictureBox1 = new GUI.CustomPictureBox();
            this.siticoneCustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneBorderlessForm1
            // 
            this.siticoneBorderlessForm1.ContainerControl = this;
            this.siticoneBorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneBorderlessForm1.ResizeForm = false;
            this.siticoneBorderlessForm1.TransparentWhileDrag = true;
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneDragControl1.TargetControl = this;
            this.siticoneDragControl1.UseTransparentDrag = true;
            // 
            // siticoneDragControl2
            // 
            this.siticoneDragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneDragControl2.UseTransparentDrag = true;
            // 
            // exit
            // 
            this.exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit.FillColor = System.Drawing.Color.Transparent;
            this.exit.ForeColor = System.Drawing.SystemColors.WindowText;
            this.exit.IconColor = System.Drawing.SystemColors.ControlDarkDark;
            this.exit.Location = new System.Drawing.Point(1177, -3);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(59, 60);
            this.exit.TabIndex = 2;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.siticoneControlBox2.IconColor = System.Drawing.SystemColors.ControlDarkDark;
            this.siticoneControlBox2.Location = new System.Drawing.Point(1102, -3);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.Size = new System.Drawing.Size(57, 60);
            this.siticoneControlBox2.TabIndex = 1;
            this.siticoneControlBox2.Click += new System.EventHandler(this.siticoneControlBox2_Click);
            // 
            // siticoneCustomGradientPanel1
            // 
            this.siticoneCustomGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneCustomGradientPanel1.BorderRadius = 50;
            this.siticoneCustomGradientPanel1.Controls.Add(this.butLogin);
            this.siticoneCustomGradientPanel1.Controls.Add(this.txtUserpwd);
            this.siticoneCustomGradientPanel1.Controls.Add(this.txtUsername);
            this.siticoneCustomGradientPanel1.Controls.Add(this.label1);
            this.siticoneCustomGradientPanel1.FillColor = System.Drawing.Color.CornflowerBlue;
            this.siticoneCustomGradientPanel1.FillColor2 = System.Drawing.Color.BlueViolet;
            this.siticoneCustomGradientPanel1.FillColor3 = System.Drawing.Color.RoyalBlue;
            this.siticoneCustomGradientPanel1.FillColor4 = System.Drawing.Color.BlueViolet;
            this.siticoneCustomGradientPanel1.Location = new System.Drawing.Point(687, 84);
            this.siticoneCustomGradientPanel1.Name = "siticoneCustomGradientPanel1";
            this.siticoneCustomGradientPanel1.Size = new System.Drawing.Size(498, 504);
            this.siticoneCustomGradientPanel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(124, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 59);
            this.label1.TabIndex = 3;
            this.label1.Text = "Đăng Nhập";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Transparent;
            this.txtUsername.BorderColor = System.Drawing.Color.Black;
            this.txtUsername.BorderRadius = 15;
            this.txtUsername.BorderThickness = 2;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            this.txtUsername.FocusedState.ForeColor = System.Drawing.Color.SlateBlue;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUsername.ForeColor = System.Drawing.Color.MediumPurple;
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.Silver;
            this.txtUsername.Location = new System.Drawing.Point(57, 161);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderForeColor = System.Drawing.Color.LightSteelBlue;
            this.txtUsername.PlaceholderText = "username";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(361, 50);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtUserpwd
            // 
            this.txtUserpwd.BackColor = System.Drawing.Color.Transparent;
            this.txtUserpwd.BorderColor = System.Drawing.Color.Black;
            this.txtUserpwd.BorderRadius = 15;
            this.txtUserpwd.BorderThickness = 2;
            this.txtUserpwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserpwd.DefaultText = "";
            this.txtUserpwd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserpwd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserpwd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserpwd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserpwd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            this.txtUserpwd.FocusedState.ForeColor = System.Drawing.Color.SlateBlue;
            this.txtUserpwd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUserpwd.ForeColor = System.Drawing.Color.MediumPurple;
            this.txtUserpwd.HoverState.BorderColor = System.Drawing.Color.Silver;
            this.txtUserpwd.Location = new System.Drawing.Point(57, 254);
            this.txtUserpwd.Name = "txtUserpwd";
            this.txtUserpwd.PasswordChar = '●';
            this.txtUserpwd.PlaceholderForeColor = System.Drawing.Color.LightSteelBlue;
            this.txtUserpwd.PlaceholderText = "password";
            this.txtUserpwd.SelectedText = "";
            this.txtUserpwd.Size = new System.Drawing.Size(361, 50);
            this.txtUserpwd.TabIndex = 1;
            this.txtUserpwd.UseSystemPasswordChar = true;
            this.txtUserpwd.TextChanged += new System.EventHandler(this.txtUserpwd_TextChanged);
            // 
            // butLogin
            // 
            this.butLogin.BackColor = System.Drawing.Color.Transparent;
            this.butLogin.BorderColor = System.Drawing.Color.BlueViolet;
            this.butLogin.BorderRadius = 30;
            this.butLogin.BorderThickness = 3;
            this.butLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butLogin.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.butLogin.ForeColor = System.Drawing.SystemColors.Window;
            this.butLogin.Location = new System.Drawing.Point(79, 380);
            this.butLogin.Name = "butLogin";
            this.butLogin.Size = new System.Drawing.Size(358, 65);
            this.butLogin.TabIndex = 11;
            this.butLogin.Text = "siticoneGradientButton1";
            this.butLogin.Click += new System.EventHandler(this.butLogin_Click);
            // 
            // customPictureBox1
            // 
            this.customPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.customPictureBox1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.customPictureBox1.BorderColor2 = System.Drawing.Color.HotPink;
            this.customPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.customPictureBox1.BorderSize = 4;
            this.customPictureBox1.GradientAngle = 50F;
            this.customPictureBox1.Location = new System.Drawing.Point(-219, -77);
            this.customPictureBox1.Name = "customPictureBox1";
            this.customPictureBox1.Size = new System.Drawing.Size(870, 870);
            this.customPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.customPictureBox1.TabIndex = 7;
            this.customPictureBox1.TabStop = false;
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 715);
            this.Controls.Add(this.siticoneCustomGradientPanel1);
            this.Controls.Add(this.customPictureBox1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.siticoneControlBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fLogin";
            this.siticoneCustomGradientPanel1.ResumeLayout(false);
            this.siticoneCustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
        private Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;
        private Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl2;
        private CustomPictureBox customPictureBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox exit;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox2;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton butLogin;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel siticoneCustomGradientPanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtUserpwd;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtUsername;
        private System.Windows.Forms.Label label1;
    }
}