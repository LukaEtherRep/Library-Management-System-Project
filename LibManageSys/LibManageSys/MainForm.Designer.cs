namespace LibManageSys
{
    partial class MainForm
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
            this.rjpgbUser = new ToggleButton.RJControls.RJProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rjtxbUsername = new ToggleButton.RJControls.RJTextBoxBorderCus();
            this.rjtxbPassword = new ToggleButton.RJControls.RJTextBoxBorderCus();
            this.rjbtnLogin = new ToggleButton.RJControls.RJGoodShapeBtn();
            this.rjbtnSignUp = new ToggleButton.RJControls.RJGoodShapeBtn();
            this.lblForgotPassword = new System.Windows.Forms.Label();
            this.linklblRecoverPass = new System.Windows.Forms.LinkLabel();
            this.lblOr = new System.Windows.Forms.Label();
            this.btnBorder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.rjcpicbUser = new ToggleButton.RJControls.RJCircularPicB();
            this.picbPassword = new System.Windows.Forms.PictureBox();
            this.picbUser = new System.Windows.Forms.PictureBox();
            this.picbBorder = new System.Windows.Forms.PictureBox();
            this.ckbRememberPass = new System.Windows.Forms.CheckBox();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjcpicbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbBorder)).BeginInit();
            this.SuspendLayout();
            // 
            // rjpgbUser
            // 
            this.rjpgbUser.ChannelColor = System.Drawing.Color.MidnightBlue;
            this.rjpgbUser.ChannelHeight = 10;
            this.rjpgbUser.ForeBackColor = System.Drawing.Color.RoyalBlue;
            this.rjpgbUser.ForeColor = System.Drawing.Color.White;
            this.rjpgbUser.IncrementValue = 1;
            this.rjpgbUser.Location = new System.Drawing.Point(110, 140);
            this.rjpgbUser.Name = "rjpgbUser";
            this.rjpgbUser.ShowMaximun = false;
            this.rjpgbUser.ShowValue = ToggleButton.RJControls.TextPosition.None;
            this.rjpgbUser.Size = new System.Drawing.Size(128, 10);
            this.rjpgbUser.SliderColor = System.Drawing.Color.Blue;
            this.rjpgbUser.SliderHeight = 10;
            this.rjpgbUser.SymbolAfter = "";
            this.rjpgbUser.SymbolBefore = "";
            this.rjpgbUser.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rjtxbUsername
            // 
            this.rjtxbUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(57)))));
            this.rjtxbUsername.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjtxbUsername.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjtxbUsername.BorderRadius = 0;
            this.rjtxbUsername.BorderSize = 2;
            this.rjtxbUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rjtxbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjtxbUsername.ForeColor = System.Drawing.Color.White;
            this.rjtxbUsername.Location = new System.Drawing.Point(77, 208);
            this.rjtxbUsername.Margin = new System.Windows.Forms.Padding(4);
            this.rjtxbUsername.Multiline = false;
            this.rjtxbUsername.Name = "rjtxbUsername";
            this.rjtxbUsername.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjtxbUsername.PasswordChar = false;
            this.rjtxbUsername.PlaceholderColor = System.Drawing.Color.Gray;
            this.rjtxbUsername.PlaceholderText = "Username";
            this.rjtxbUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.rjtxbUsername.Size = new System.Drawing.Size(224, 30);
            this.rjtxbUsername.TabIndex = 4;
            this.rjtxbUsername.Texts = "";
            this.rjtxbUsername.UnderlinedStyle = true;
            // 
            // rjtxbPassword
            // 
            this.rjtxbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(57)))));
            this.rjtxbPassword.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjtxbPassword.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjtxbPassword.BorderRadius = 0;
            this.rjtxbPassword.BorderSize = 2;
            this.rjtxbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rjtxbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjtxbPassword.ForeColor = System.Drawing.Color.White;
            this.rjtxbPassword.Location = new System.Drawing.Point(77, 243);
            this.rjtxbPassword.Margin = new System.Windows.Forms.Padding(4);
            this.rjtxbPassword.Multiline = false;
            this.rjtxbPassword.Name = "rjtxbPassword";
            this.rjtxbPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjtxbPassword.PasswordChar = true;
            this.rjtxbPassword.PlaceholderColor = System.Drawing.Color.Gray;
            this.rjtxbPassword.PlaceholderText = "Password";
            this.rjtxbPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.rjtxbPassword.Size = new System.Drawing.Size(224, 30);
            this.rjtxbPassword.TabIndex = 5;
            this.rjtxbPassword.Texts = "";
            this.rjtxbPassword.UnderlinedStyle = true;
            // 
            // rjbtnLogin
            // 
            this.rjbtnLogin.BackColor = System.Drawing.Color.RoyalBlue;
            this.rjbtnLogin.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.rjbtnLogin.BorderColor = System.Drawing.Color.Fuchsia;
            this.rjbtnLogin.BorderRadius = 20;
            this.rjbtnLogin.BorderSize = 2;
            this.rjbtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjbtnLogin.FlatAppearance.BorderSize = 0;
            this.rjbtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjbtnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjbtnLogin.ForeColor = System.Drawing.Color.White;
            this.rjbtnLogin.Location = new System.Drawing.Point(99, 320);
            this.rjbtnLogin.Name = "rjbtnLogin";
            this.rjbtnLogin.Size = new System.Drawing.Size(150, 40);
            this.rjbtnLogin.TabIndex = 6;
            this.rjbtnLogin.Text = "Đăng Nhập";
            this.rjbtnLogin.TextColor = System.Drawing.Color.White;
            this.rjbtnLogin.UseVisualStyleBackColor = false;
            this.rjbtnLogin.Click += new System.EventHandler(this.rjbtnLogin_Click);
            // 
            // rjbtnSignUp
            // 
            this.rjbtnSignUp.BackColor = System.Drawing.Color.MediumOrchid;
            this.rjbtnSignUp.BackgroundColor = System.Drawing.Color.MediumOrchid;
            this.rjbtnSignUp.BorderColor = System.Drawing.Color.RoyalBlue;
            this.rjbtnSignUp.BorderRadius = 20;
            this.rjbtnSignUp.BorderSize = 2;
            this.rjbtnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjbtnSignUp.FlatAppearance.BorderSize = 0;
            this.rjbtnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjbtnSignUp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjbtnSignUp.ForeColor = System.Drawing.Color.White;
            this.rjbtnSignUp.Location = new System.Drawing.Point(101, 385);
            this.rjbtnSignUp.Name = "rjbtnSignUp";
            this.rjbtnSignUp.Size = new System.Drawing.Size(150, 40);
            this.rjbtnSignUp.TabIndex = 7;
            this.rjbtnSignUp.Text = "Đăng Ký";
            this.rjbtnSignUp.TextColor = System.Drawing.Color.White;
            this.rjbtnSignUp.UseVisualStyleBackColor = false;
            // 
            // lblForgotPassword
            // 
            this.lblForgotPassword.AutoSize = true;
            this.lblForgotPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.lblForgotPassword.Location = new System.Drawing.Point(98, 474);
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Size = new System.Drawing.Size(115, 13);
            this.lblForgotPassword.TabIndex = 8;
            this.lblForgotPassword.Text = "Khôi phục lại mật khẩu";
            // 
            // linklblRecoverPass
            // 
            this.linklblRecoverPass.AutoSize = true;
            this.linklblRecoverPass.Location = new System.Drawing.Point(208, 474);
            this.linklblRecoverPass.Name = "linklblRecoverPass";
            this.linklblRecoverPass.Size = new System.Drawing.Size(43, 13);
            this.linklblRecoverPass.TabIndex = 9;
            this.linklblRecoverPass.TabStop = true;
            this.linklblRecoverPass.Text = "Tại đây";
            // 
            // lblOr
            // 
            this.lblOr.AutoSize = true;
            this.lblOr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOr.ForeColor = System.Drawing.Color.Blue;
            this.lblOr.Location = new System.Drawing.Point(156, 366);
            this.lblOr.Margin = new System.Windows.Forms.Padding(3);
            this.lblOr.Name = "lblOr";
            this.lblOr.Size = new System.Drawing.Size(37, 13);
            this.lblOr.TabIndex = 10;
            this.lblOr.Text = "Hoặc";
            // 
            // btnBorder
            // 
            this.btnBorder.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnBorder.Enabled = false;
            this.btnBorder.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnBorder.FlatAppearance.BorderSize = 3;
            this.btnBorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBorder.Location = new System.Drawing.Point(3, 3);
            this.btnBorder.Margin = new System.Windows.Forms.Padding(0);
            this.btnBorder.Name = "btnBorder";
            this.btnBorder.Size = new System.Drawing.Size(343, 495);
            this.btnBorder.TabIndex = 12;
            this.btnBorder.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(296, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(36, 34);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "O";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(57)))));
            this.pnlTitle.Controls.Add(this.btnExit);
            this.pnlTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlTitle.Location = new System.Drawing.Point(9, 9);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(331, 35);
            this.pnlTitle.TabIndex = 14;
            this.pnlTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseDown);
            // 
            // rjcpicbUser
            // 
            this.rjcpicbUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(99)))));
            this.rjcpicbUser.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjcpicbUser.BorderColor = System.Drawing.Color.Blue;
            this.rjcpicbUser.BorderColor2 = System.Drawing.Color.Brown;
            this.rjcpicbUser.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjcpicbUser.BorderSize = 2;
            this.rjcpicbUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjcpicbUser.GradientAngle = 90F;
            this.rjcpicbUser.Image = global::LibManageSys.Properties.Resources.icons8_user_100;
            this.rjcpicbUser.Location = new System.Drawing.Point(124, 34);
            this.rjcpicbUser.Name = "rjcpicbUser";
            this.rjcpicbUser.Size = new System.Drawing.Size(100, 100);
            this.rjcpicbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjcpicbUser.TabIndex = 0;
            this.rjcpicbUser.TabStop = false;
            this.rjcpicbUser.DoubleClick += new System.EventHandler(this.rjcpicbUser_DoubleClick);
            // 
            // picbPassword
            // 
            this.picbPassword.Image = global::LibManageSys.Properties.Resources.icons8_lock_30;
            this.picbPassword.Location = new System.Drawing.Point(40, 245);
            this.picbPassword.Name = "picbPassword";
            this.picbPassword.Size = new System.Drawing.Size(30, 30);
            this.picbPassword.TabIndex = 3;
            this.picbPassword.TabStop = false;
            // 
            // picbUser
            // 
            this.picbUser.Image = global::LibManageSys.Properties.Resources.icons8_user_30;
            this.picbUser.Location = new System.Drawing.Point(40, 209);
            this.picbUser.Name = "picbUser";
            this.picbUser.Size = new System.Drawing.Size(30, 30);
            this.picbUser.TabIndex = 2;
            this.picbUser.TabStop = false;
            // 
            // picbBorder
            // 
            this.picbBorder.Location = new System.Drawing.Point(30, 118);
            this.picbBorder.Name = "picbBorder";
            this.picbBorder.Size = new System.Drawing.Size(289, 83);
            this.picbBorder.TabIndex = 11;
            this.picbBorder.TabStop = false;
            // 
            // ckbRememberPass
            // 
            this.ckbRememberPass.AutoSize = true;
            this.ckbRememberPass.ForeColor = System.Drawing.Color.Gray;
            this.ckbRememberPass.Location = new System.Drawing.Point(77, 280);
            this.ckbRememberPass.Name = "ckbRememberPass";
            this.ckbRememberPass.Size = new System.Drawing.Size(93, 17);
            this.ckbRememberPass.TabIndex = 15;
            this.ckbRememberPass.Text = "Nhớ mật khẩu";
            this.ckbRememberPass.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(349, 500);
            this.Controls.Add(this.ckbRememberPass);
            this.Controls.Add(this.rjcpicbUser);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.lblOr);
            this.Controls.Add(this.linklblRecoverPass);
            this.Controls.Add(this.lblForgotPassword);
            this.Controls.Add(this.rjbtnSignUp);
            this.Controls.Add(this.rjbtnLogin);
            this.Controls.Add(this.rjtxbPassword);
            this.Controls.Add(this.rjtxbUsername);
            this.Controls.Add(this.picbPassword);
            this.Controls.Add(this.picbUser);
            this.Controls.Add(this.rjpgbUser);
            this.Controls.Add(this.picbBorder);
            this.Controls.Add(this.btnBorder);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjcpicbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbBorder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToggleButton.RJControls.RJCircularPicB rjcpicbUser;
        private ToggleButton.RJControls.RJProgressBar rjpgbUser;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picbUser;
        private System.Windows.Forms.PictureBox picbPassword;
        private ToggleButton.RJControls.RJTextBoxBorderCus rjtxbUsername;
        private ToggleButton.RJControls.RJTextBoxBorderCus rjtxbPassword;
        private ToggleButton.RJControls.RJGoodShapeBtn rjbtnLogin;
        private ToggleButton.RJControls.RJGoodShapeBtn rjbtnSignUp;
        private System.Windows.Forms.Label lblForgotPassword;
        private System.Windows.Forms.LinkLabel linklblRecoverPass;
        private System.Windows.Forms.Label lblOr;
        private System.Windows.Forms.PictureBox picbBorder;
        private System.Windows.Forms.Button btnBorder;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.CheckBox ckbRememberPass;
    }
}

