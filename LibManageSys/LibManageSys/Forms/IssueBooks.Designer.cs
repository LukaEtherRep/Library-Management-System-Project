namespace LibManageSys.Forms
{
    partial class IssueBooks
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.picbHeader = new System.Windows.Forms.PictureBox();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.pnlDivider = new System.Windows.Forms.Panel();
            this.lblFoundStudent = new System.Windows.Forms.Label();
            this.rjbtnExit = new ToggleButton.RJControls.RJGoodShapeBtn();
            this.rjbtnRefresh = new ToggleButton.RJControls.RJGoodShapeBtn();
            this.rjtxbSearchEnroll = new ToggleButton.RJControls.RJTextBoxBorderCus();
            this.rjbtnSearchEnroll = new ToggleButton.RJControls.RJGoodShapeBtn();
            this.lblSearchEnroll = new System.Windows.Forms.Label();
            this.rjpicbSearchStudent = new ToggleButton.RJControls.RJCircularPicB();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.rjcbBName = new ToggleButton.RJControls.RJComboBox();
            this.lblWarning = new System.Windows.Forms.Label();
            this.rjdtpkIssueDate = new ToggleButton.RJControls.RJDateTimePicker();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.txbSPhone = new ToggleButton.RJControls.RJTextBoxBorderCus();
            this.btnIssue = new System.Windows.Forms.Button();
            this.txbSSem = new ToggleButton.RJControls.RJTextBoxBorderCus();
            this.txbSDepart = new ToggleButton.RJControls.RJTextBoxBorderCus();
            this.txbSName = new ToggleButton.RJControls.RJTextBoxBorderCus();
            this.txbSEmail = new ToggleButton.RJControls.RJTextBoxBorderCus();
            this.lblBName = new System.Windows.Forms.Label();
            this.lblSEmail = new System.Windows.Forms.Label();
            this.lblSPhone = new System.Windows.Forms.Label();
            this.lblSName = new System.Windows.Forms.Label();
            this.lblSDepart = new System.Windows.Forms.Label();
            this.lblSSem = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbHeader)).BeginInit();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjpicbSearchStudent)).BeginInit();
            this.pnlInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Controls.Add(this.picbHeader);
            this.pnlHeader.Location = new System.Drawing.Point(12, 12);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(972, 125);
            this.pnlHeader.TabIndex = 0;
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHead_MouseDown);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblHeader.Location = new System.Drawing.Point(536, 56);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(130, 25);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Mượn Sách";
            this.lblHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHead_MouseDown);
            // 
            // picbHeader
            // 
            this.picbHeader.Image = global::LibManageSys.Properties.Resources.issueBook;
            this.picbHeader.Location = new System.Drawing.Point(306, 0);
            this.picbHeader.Margin = new System.Windows.Forms.Padding(0);
            this.picbHeader.Name = "picbHeader";
            this.picbHeader.Size = new System.Drawing.Size(311, 125);
            this.picbHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbHeader.TabIndex = 0;
            this.picbHeader.TabStop = false;
            this.picbHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHead_MouseDown);
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.Silver;
            this.pnlSearch.Controls.Add(this.pnlDivider);
            this.pnlSearch.Controls.Add(this.lblFoundStudent);
            this.pnlSearch.Controls.Add(this.rjbtnExit);
            this.pnlSearch.Controls.Add(this.rjbtnRefresh);
            this.pnlSearch.Controls.Add(this.rjtxbSearchEnroll);
            this.pnlSearch.Controls.Add(this.rjbtnSearchEnroll);
            this.pnlSearch.Controls.Add(this.lblSearchEnroll);
            this.pnlSearch.Controls.Add(this.rjpicbSearchStudent);
            this.pnlSearch.Location = new System.Drawing.Point(16, 144);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(259, 426);
            this.pnlSearch.TabIndex = 1;
            // 
            // pnlDivider
            // 
            this.pnlDivider.BackColor = System.Drawing.Color.Black;
            this.pnlDivider.Location = new System.Drawing.Point(54, 180);
            this.pnlDivider.Name = "pnlDivider";
            this.pnlDivider.Size = new System.Drawing.Size(150, 1);
            this.pnlDivider.TabIndex = 7;
            // 
            // lblFoundStudent
            // 
            this.lblFoundStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoundStudent.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblFoundStudent.Location = new System.Drawing.Point(0, 152);
            this.lblFoundStudent.Margin = new System.Windows.Forms.Padding(0);
            this.lblFoundStudent.Name = "lblFoundStudent";
            this.lblFoundStudent.Size = new System.Drawing.Size(259, 23);
            this.lblFoundStudent.TabIndex = 6;
            this.lblFoundStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rjbtnExit
            // 
            this.rjbtnExit.BackColor = System.Drawing.Color.LightGray;
            this.rjbtnExit.BackgroundColor = System.Drawing.Color.LightGray;
            this.rjbtnExit.BorderColor = System.Drawing.Color.Gray;
            this.rjbtnExit.BorderRadius = 5;
            this.rjbtnExit.BorderSize = 2;
            this.rjbtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjbtnExit.FlatAppearance.BorderSize = 0;
            this.rjbtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjbtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjbtnExit.ForeColor = System.Drawing.Color.Black;
            this.rjbtnExit.Location = new System.Drawing.Point(147, 375);
            this.rjbtnExit.Name = "rjbtnExit";
            this.rjbtnExit.Size = new System.Drawing.Size(74, 24);
            this.rjbtnExit.TabIndex = 5;
            this.rjbtnExit.Text = "Thoát";
            this.rjbtnExit.TextColor = System.Drawing.Color.Black;
            this.rjbtnExit.UseVisualStyleBackColor = false;
            this.rjbtnExit.Click += new System.EventHandler(this.rjbtnExit_Click);
            // 
            // rjbtnRefresh
            // 
            this.rjbtnRefresh.BackColor = System.Drawing.Color.LightGray;
            this.rjbtnRefresh.BackgroundColor = System.Drawing.Color.LightGray;
            this.rjbtnRefresh.BorderColor = System.Drawing.Color.Gray;
            this.rjbtnRefresh.BorderRadius = 5;
            this.rjbtnRefresh.BorderSize = 2;
            this.rjbtnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjbtnRefresh.FlatAppearance.BorderSize = 0;
            this.rjbtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjbtnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjbtnRefresh.ForeColor = System.Drawing.Color.Black;
            this.rjbtnRefresh.Location = new System.Drawing.Point(37, 375);
            this.rjbtnRefresh.Name = "rjbtnRefresh";
            this.rjbtnRefresh.Size = new System.Drawing.Size(74, 24);
            this.rjbtnRefresh.TabIndex = 4;
            this.rjbtnRefresh.Text = "Tải lại";
            this.rjbtnRefresh.TextColor = System.Drawing.Color.Black;
            this.rjbtnRefresh.UseVisualStyleBackColor = false;
            this.rjbtnRefresh.Click += new System.EventHandler(this.rjbtnRefresh_Click);
            // 
            // rjtxbSearchEnroll
            // 
            this.rjtxbSearchEnroll.BackColor = System.Drawing.SystemColors.Window;
            this.rjtxbSearchEnroll.BorderColor = System.Drawing.Color.Black;
            this.rjtxbSearchEnroll.BorderFocusColor = System.Drawing.Color.Aqua;
            this.rjtxbSearchEnroll.BorderRadius = 0;
            this.rjtxbSearchEnroll.BorderSize = 2;
            this.rjtxbSearchEnroll.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rjtxbSearchEnroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjtxbSearchEnroll.ForeColor = System.Drawing.Color.DimGray;
            this.rjtxbSearchEnroll.Location = new System.Drawing.Point(19, 266);
            this.rjtxbSearchEnroll.Margin = new System.Windows.Forms.Padding(4);
            this.rjtxbSearchEnroll.Multiline = false;
            this.rjtxbSearchEnroll.Name = "rjtxbSearchEnroll";
            this.rjtxbSearchEnroll.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjtxbSearchEnroll.PasswordChar = false;
            this.rjtxbSearchEnroll.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjtxbSearchEnroll.PlaceholderText = "";
            this.rjtxbSearchEnroll.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.rjtxbSearchEnroll.Size = new System.Drawing.Size(221, 31);
            this.rjtxbSearchEnroll.TabIndex = 3;
            this.rjtxbSearchEnroll.Texts = "";
            this.rjtxbSearchEnroll.UnderlinedStyle = false;
            this.rjtxbSearchEnroll.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rjtxbSearchEnroll_KeyPress);
            // 
            // rjbtnSearchEnroll
            // 
            this.rjbtnSearchEnroll.BackColor = System.Drawing.Color.LightGray;
            this.rjbtnSearchEnroll.BackgroundColor = System.Drawing.Color.LightGray;
            this.rjbtnSearchEnroll.BorderColor = System.Drawing.Color.Gray;
            this.rjbtnSearchEnroll.BorderRadius = 5;
            this.rjbtnSearchEnroll.BorderSize = 2;
            this.rjbtnSearchEnroll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjbtnSearchEnroll.FlatAppearance.BorderSize = 0;
            this.rjbtnSearchEnroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjbtnSearchEnroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjbtnSearchEnroll.ForeColor = System.Drawing.Color.Black;
            this.rjbtnSearchEnroll.Location = new System.Drawing.Point(54, 307);
            this.rjbtnSearchEnroll.Name = "rjbtnSearchEnroll";
            this.rjbtnSearchEnroll.Size = new System.Drawing.Size(150, 40);
            this.rjbtnSearchEnroll.TabIndex = 2;
            this.rjbtnSearchEnroll.Text = "Tìm Kiếm";
            this.rjbtnSearchEnroll.TextColor = System.Drawing.Color.Black;
            this.rjbtnSearchEnroll.UseVisualStyleBackColor = false;
            this.rjbtnSearchEnroll.Click += new System.EventHandler(this.rjbtnSearchEnroll_Click);
            // 
            // lblSearchEnroll
            // 
            this.lblSearchEnroll.AutoSize = true;
            this.lblSearchEnroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchEnroll.Location = new System.Drawing.Point(68, 238);
            this.lblSearchEnroll.Name = "lblSearchEnroll";
            this.lblSearchEnroll.Size = new System.Drawing.Size(123, 24);
            this.lblSearchEnroll.TabIndex = 1;
            this.lblSearchEnroll.Text = "Mã Sinh Viên";
            // 
            // rjpicbSearchStudent
            // 
            this.rjpicbSearchStudent.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjpicbSearchStudent.BorderColor = System.Drawing.Color.Black;
            this.rjpicbSearchStudent.BorderColor2 = System.Drawing.Color.White;
            this.rjpicbSearchStudent.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjpicbSearchStudent.BorderSize = 2;
            this.rjpicbSearchStudent.GradientAngle = 50F;
            this.rjpicbSearchStudent.Image = global::LibManageSys.Properties.Resources.icons8_student_male_100;
            this.rjpicbSearchStudent.Location = new System.Drawing.Point(79, 42);
            this.rjpicbSearchStudent.Name = "rjpicbSearchStudent";
            this.rjpicbSearchStudent.Size = new System.Drawing.Size(100, 100);
            this.rjpicbSearchStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjpicbSearchStudent.TabIndex = 0;
            this.rjpicbSearchStudent.TabStop = false;
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlInfo.Controls.Add(this.rjcbBName);
            this.pnlInfo.Controls.Add(this.lblWarning);
            this.pnlInfo.Controls.Add(this.rjdtpkIssueDate);
            this.pnlInfo.Controls.Add(this.lblIssueDate);
            this.pnlInfo.Controls.Add(this.txbSPhone);
            this.pnlInfo.Controls.Add(this.btnIssue);
            this.pnlInfo.Controls.Add(this.txbSSem);
            this.pnlInfo.Controls.Add(this.txbSDepart);
            this.pnlInfo.Controls.Add(this.txbSName);
            this.pnlInfo.Controls.Add(this.txbSEmail);
            this.pnlInfo.Controls.Add(this.lblBName);
            this.pnlInfo.Controls.Add(this.lblSEmail);
            this.pnlInfo.Controls.Add(this.lblSPhone);
            this.pnlInfo.Controls.Add(this.lblSName);
            this.pnlInfo.Controls.Add(this.lblSDepart);
            this.pnlInfo.Controls.Add(this.lblSSem);
            this.pnlInfo.Location = new System.Drawing.Point(282, 144);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(702, 426);
            this.pnlInfo.TabIndex = 2;
            // 
            // rjcbBName
            // 
            this.rjcbBName.BackColor = System.Drawing.Color.White;
            this.rjcbBName.BorderColor = System.Drawing.Color.Black;
            this.rjcbBName.BorderSize = 2;
            this.rjcbBName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rjcbBName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rjcbBName.ForeColor = System.Drawing.Color.Black;
            this.rjcbBName.IconColor = System.Drawing.Color.Black;
            this.rjcbBName.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.rjcbBName.ListTextColor = System.Drawing.Color.DimGray;
            this.rjcbBName.Location = new System.Drawing.Point(183, 260);
            this.rjcbBName.MinimumSize = new System.Drawing.Size(200, 30);
            this.rjcbBName.Name = "rjcbBName";
            this.rjcbBName.Padding = new System.Windows.Forms.Padding(2);
            this.rjcbBName.Size = new System.Drawing.Size(473, 30);
            this.rjcbBName.TabIndex = 32;
            this.rjcbBName.Texts = "";
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(316, 406);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(383, 20);
            this.lblWarning.TabIndex = 2;
            this.lblWarning.Text = "Một Sinh viên chỉ được cho mượn 3 quyển sách";
            // 
            // rjdtpkIssueDate
            // 
            this.rjdtpkIssueDate.BorderColor = System.Drawing.Color.Black;
            this.rjdtpkIssueDate.BorderSize = 2;
            this.rjdtpkIssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.rjdtpkIssueDate.Location = new System.Drawing.Point(183, 309);
            this.rjdtpkIssueDate.MinimumSize = new System.Drawing.Size(4, 35);
            this.rjdtpkIssueDate.Name = "rjdtpkIssueDate";
            this.rjdtpkIssueDate.Size = new System.Drawing.Size(473, 35);
            this.rjdtpkIssueDate.SkinColor = System.Drawing.Color.White;
            this.rjdtpkIssueDate.TabIndex = 31;
            this.rjdtpkIssueDate.TextColor = System.Drawing.Color.Black;
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueDate.ForeColor = System.Drawing.Color.Black;
            this.lblIssueDate.Location = new System.Drawing.Point(47, 316);
            this.lblIssueDate.Margin = new System.Windows.Forms.Padding(15, 0, 0, 30);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(128, 19);
            this.lblIssueDate.TabIndex = 30;
            this.lblIssueDate.Text = "Ngày Mượn Sách";
            // 
            // txbSPhone
            // 
            this.txbSPhone.BackColor = System.Drawing.Color.White;
            this.txbSPhone.BorderColor = System.Drawing.Color.Black;
            this.txbSPhone.BorderFocusColor = System.Drawing.Color.MidnightBlue;
            this.txbSPhone.BorderRadius = 0;
            this.txbSPhone.BorderSize = 2;
            this.txbSPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSPhone.Enabled = false;
            this.txbSPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSPhone.ForeColor = System.Drawing.Color.Black;
            this.txbSPhone.Location = new System.Drawing.Point(183, 162);
            this.txbSPhone.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.txbSPhone.Multiline = false;
            this.txbSPhone.Name = "txbSPhone";
            this.txbSPhone.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbSPhone.PasswordChar = false;
            this.txbSPhone.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbSPhone.PlaceholderText = "";
            this.txbSPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbSPhone.Size = new System.Drawing.Size(473, 31);
            this.txbSPhone.TabIndex = 29;
            this.txbSPhone.Texts = "";
            this.txbSPhone.UnderlinedStyle = true;
            this.txbSPhone._TextChanged += new System.EventHandler(this.txbSSem__TextChanged);
            // 
            // btnIssue
            // 
            this.btnIssue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIssue.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnIssue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnIssue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIssue.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.Location = new System.Drawing.Point(511, 357);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(123, 30);
            this.btnIssue.TabIndex = 27;
            this.btnIssue.Text = "XÁC NHẬN";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // txbSSem
            // 
            this.txbSSem.BackColor = System.Drawing.Color.White;
            this.txbSSem.BorderColor = System.Drawing.Color.Black;
            this.txbSSem.BorderFocusColor = System.Drawing.Color.MidnightBlue;
            this.txbSSem.BorderRadius = 0;
            this.txbSSem.BorderSize = 2;
            this.txbSSem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSSem.Enabled = false;
            this.txbSSem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSSem.ForeColor = System.Drawing.Color.Black;
            this.txbSSem.Location = new System.Drawing.Point(183, 113);
            this.txbSSem.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.txbSSem.Multiline = false;
            this.txbSSem.Name = "txbSSem";
            this.txbSSem.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbSSem.PasswordChar = false;
            this.txbSSem.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbSSem.PlaceholderText = "";
            this.txbSSem.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbSSem.Size = new System.Drawing.Size(473, 31);
            this.txbSSem.TabIndex = 25;
            this.txbSSem.Texts = "";
            this.txbSSem.UnderlinedStyle = true;
            this.txbSSem._TextChanged += new System.EventHandler(this.txbSSem__TextChanged);
            // 
            // txbSDepart
            // 
            this.txbSDepart.BackColor = System.Drawing.Color.White;
            this.txbSDepart.BorderColor = System.Drawing.Color.Black;
            this.txbSDepart.BorderFocusColor = System.Drawing.Color.MidnightBlue;
            this.txbSDepart.BorderRadius = 0;
            this.txbSDepart.BorderSize = 2;
            this.txbSDepart.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSDepart.Enabled = false;
            this.txbSDepart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSDepart.ForeColor = System.Drawing.Color.Black;
            this.txbSDepart.Location = new System.Drawing.Point(183, 64);
            this.txbSDepart.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.txbSDepart.Multiline = false;
            this.txbSDepart.Name = "txbSDepart";
            this.txbSDepart.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbSDepart.PasswordChar = false;
            this.txbSDepart.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbSDepart.PlaceholderText = "";
            this.txbSDepart.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbSDepart.Size = new System.Drawing.Size(473, 31);
            this.txbSDepart.TabIndex = 24;
            this.txbSDepart.Texts = "";
            this.txbSDepart.UnderlinedStyle = true;
            // 
            // txbSName
            // 
            this.txbSName.BackColor = System.Drawing.Color.White;
            this.txbSName.BorderColor = System.Drawing.Color.Black;
            this.txbSName.BorderFocusColor = System.Drawing.Color.MidnightBlue;
            this.txbSName.BorderRadius = 0;
            this.txbSName.BorderSize = 2;
            this.txbSName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSName.Enabled = false;
            this.txbSName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSName.ForeColor = System.Drawing.Color.Black;
            this.txbSName.Location = new System.Drawing.Point(183, 15);
            this.txbSName.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.txbSName.Multiline = false;
            this.txbSName.Name = "txbSName";
            this.txbSName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbSName.PasswordChar = false;
            this.txbSName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbSName.PlaceholderText = "";
            this.txbSName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbSName.Size = new System.Drawing.Size(473, 31);
            this.txbSName.TabIndex = 23;
            this.txbSName.Texts = "";
            this.txbSName.UnderlinedStyle = true;
            // 
            // txbSEmail
            // 
            this.txbSEmail.BackColor = System.Drawing.Color.White;
            this.txbSEmail.BorderColor = System.Drawing.Color.Black;
            this.txbSEmail.BorderFocusColor = System.Drawing.Color.MidnightBlue;
            this.txbSEmail.BorderRadius = 0;
            this.txbSEmail.BorderSize = 2;
            this.txbSEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSEmail.Enabled = false;
            this.txbSEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSEmail.ForeColor = System.Drawing.Color.Black;
            this.txbSEmail.Location = new System.Drawing.Point(183, 211);
            this.txbSEmail.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.txbSEmail.Multiline = false;
            this.txbSEmail.Name = "txbSEmail";
            this.txbSEmail.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbSEmail.PasswordChar = false;
            this.txbSEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbSEmail.PlaceholderText = "";
            this.txbSEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbSEmail.Size = new System.Drawing.Size(473, 31);
            this.txbSEmail.TabIndex = 21;
            this.txbSEmail.Texts = "";
            this.txbSEmail.UnderlinedStyle = true;
            // 
            // lblBName
            // 
            this.lblBName.AutoSize = true;
            this.lblBName.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBName.ForeColor = System.Drawing.Color.Black;
            this.lblBName.Location = new System.Drawing.Point(47, 267);
            this.lblBName.Margin = new System.Windows.Forms.Padding(15, 0, 0, 30);
            this.lblBName.Name = "lblBName";
            this.lblBName.Size = new System.Drawing.Size(71, 19);
            this.lblBName.TabIndex = 20;
            this.lblBName.Text = "Tên Sách";
            // 
            // lblSEmail
            // 
            this.lblSEmail.AutoSize = true;
            this.lblSEmail.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSEmail.ForeColor = System.Drawing.Color.Black;
            this.lblSEmail.Location = new System.Drawing.Point(47, 218);
            this.lblSEmail.Margin = new System.Windows.Forms.Padding(15, 0, 0, 30);
            this.lblSEmail.Name = "lblSEmail";
            this.lblSEmail.Size = new System.Drawing.Size(47, 19);
            this.lblSEmail.TabIndex = 19;
            this.lblSEmail.Text = "Email";
            // 
            // lblSPhone
            // 
            this.lblSPhone.AutoSize = true;
            this.lblSPhone.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSPhone.ForeColor = System.Drawing.Color.Black;
            this.lblSPhone.Location = new System.Drawing.Point(47, 169);
            this.lblSPhone.Margin = new System.Windows.Forms.Padding(15, 0, 0, 30);
            this.lblSPhone.Name = "lblSPhone";
            this.lblSPhone.Size = new System.Drawing.Size(109, 19);
            this.lblSPhone.TabIndex = 18;
            this.lblSPhone.Text = "Số Điện Thoại";
            // 
            // lblSName
            // 
            this.lblSName.AutoSize = true;
            this.lblSName.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSName.ForeColor = System.Drawing.Color.Black;
            this.lblSName.Location = new System.Drawing.Point(47, 22);
            this.lblSName.Margin = new System.Windows.Forms.Padding(15, 0, 0, 30);
            this.lblSName.Name = "lblSName";
            this.lblSName.Size = new System.Drawing.Size(104, 19);
            this.lblSName.TabIndex = 17;
            this.lblSName.Text = "Tên Sinh Viên";
            // 
            // lblSDepart
            // 
            this.lblSDepart.AutoSize = true;
            this.lblSDepart.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDepart.ForeColor = System.Drawing.Color.Black;
            this.lblSDepart.Location = new System.Drawing.Point(47, 71);
            this.lblSDepart.Margin = new System.Windows.Forms.Padding(15, 0, 0, 30);
            this.lblSDepart.Name = "lblSDepart";
            this.lblSDepart.Size = new System.Drawing.Size(45, 19);
            this.lblSDepart.TabIndex = 16;
            this.lblSDepart.Text = "Khoa";
            // 
            // lblSSem
            // 
            this.lblSSem.AutoSize = true;
            this.lblSSem.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSSem.ForeColor = System.Drawing.Color.Black;
            this.lblSSem.Location = new System.Drawing.Point(47, 120);
            this.lblSSem.Margin = new System.Windows.Forms.Padding(15, 0, 0, 30);
            this.lblSSem.Name = "lblSSem";
            this.lblSSem.Size = new System.Drawing.Size(44, 19);
            this.lblSSem.TabIndex = 15;
            this.lblSSem.Text = "Năm";
            // 
            // IssueBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(996, 582);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IssueBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IssueBooks";
            this.Load += new System.EventHandler(this.IssueBooks_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbHeader)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjpicbSearchStudent)).EndInit();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox picbHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel pnlSearch;
        private ToggleButton.RJControls.RJCircularPicB rjpicbSearchStudent;
        private System.Windows.Forms.Label lblSearchEnroll;
        private ToggleButton.RJControls.RJTextBoxBorderCus rjtxbSearchEnroll;
        private ToggleButton.RJControls.RJGoodShapeBtn rjbtnSearchEnroll;
        private ToggleButton.RJControls.RJGoodShapeBtn rjbtnExit;
        private ToggleButton.RJControls.RJGoodShapeBtn rjbtnRefresh;
        private System.Windows.Forms.Panel pnlDivider;
        private System.Windows.Forms.Label lblFoundStudent;
        private System.Windows.Forms.Panel pnlInfo;
        private ToggleButton.RJControls.RJTextBoxBorderCus txbSPhone;
        private System.Windows.Forms.Button btnIssue;
        private ToggleButton.RJControls.RJTextBoxBorderCus txbSSem;
        private ToggleButton.RJControls.RJTextBoxBorderCus txbSDepart;
        private ToggleButton.RJControls.RJTextBoxBorderCus txbSName;
        private ToggleButton.RJControls.RJTextBoxBorderCus txbSEmail;
        private System.Windows.Forms.Label lblBName;
        private System.Windows.Forms.Label lblSEmail;
        private System.Windows.Forms.Label lblSPhone;
        private System.Windows.Forms.Label lblSName;
        private System.Windows.Forms.Label lblSDepart;
        private System.Windows.Forms.Label lblSSem;
        private ToggleButton.RJControls.RJDateTimePicker rjdtpkIssueDate;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.Label lblWarning;
        private ToggleButton.RJControls.RJComboBox rjcbBName;
    }
}