namespace LibManageSys.Forms
{
    partial class ViewStudent
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
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.rjbtnExit = new ToggleButton.RJControls.RJGoodShapeBtn();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picbTitle = new System.Windows.Forms.PictureBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.rjtxbSearchEnroll = new ToggleButton.RJControls.RJTextBoxBorderCus();
            this.lbSearchEnroll = new System.Windows.Forms.Label();
            this.dtgvInfo = new System.Windows.Forms.DataGridView();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.rjtxbSem = new ToggleButton.RJControls.RJTextBoxBorderCus();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.rjtxbPhone = new ToggleButton.RJControls.RJTextBoxBorderCus();
            this.rjtxbEmail = new ToggleButton.RJControls.RJTextBoxBorderCus();
            this.rjtxbEnroll = new ToggleButton.RJControls.RJTextBoxBorderCus();
            this.rjtxbDepart = new ToggleButton.RJControls.RJTextBoxBorderCus();
            this.rjtxbName = new ToggleButton.RJControls.RJTextBoxBorderCus();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblSem = new System.Windows.Forms.Label();
            this.lblDepart = new System.Windows.Forms.Label();
            this.lblEnroll = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInfo)).BeginInit();
            this.pnlInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.White;
            this.pnlTitle.Controls.Add(this.rjbtnExit);
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Controls.Add(this.picbTitle);
            this.pnlTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(982, 134);
            this.pnlTitle.TabIndex = 1;
            this.pnlTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseDown);
            // 
            // rjbtnExit
            // 
            this.rjbtnExit.BackColor = System.Drawing.Color.Transparent;
            this.rjbtnExit.BackgroundColor = System.Drawing.Color.Transparent;
            this.rjbtnExit.BorderColor = System.Drawing.Color.Red;
            this.rjbtnExit.BorderRadius = 20;
            this.rjbtnExit.BorderSize = 2;
            this.rjbtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjbtnExit.FlatAppearance.BorderSize = 0;
            this.rjbtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjbtnExit.ForeColor = System.Drawing.Color.White;
            this.rjbtnExit.Location = new System.Drawing.Point(963, 6);
            this.rjbtnExit.Name = "rjbtnExit";
            this.rjbtnExit.Size = new System.Drawing.Size(20, 20);
            this.rjbtnExit.TabIndex = 2;
            this.rjbtnExit.TextColor = System.Drawing.Color.White;
            this.rjbtnExit.UseVisualStyleBackColor = false;
            this.rjbtnExit.Click += new System.EventHandler(this.rjbtnExit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTitle.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTitle.Location = new System.Drawing.Point(508, 53);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(245, 28);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Danh Sách Sinh Viên";
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseDown);
            // 
            // picbTitle
            // 
            this.picbTitle.BackColor = System.Drawing.Color.Transparent;
            this.picbTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbTitle.Image = global::LibManageSys.Properties.Resources.search;
            this.picbTitle.Location = new System.Drawing.Point(224, -34);
            this.picbTitle.Name = "picbTitle";
            this.picbTitle.Size = new System.Drawing.Size(340, 203);
            this.picbTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbTitle.TabIndex = 0;
            this.picbTitle.TabStop = false;
            this.picbTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseDown);
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoSize = true;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(643, 152);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(88, 32);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Tải lại";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // rjtxbSearchEnroll
            // 
            this.rjtxbSearchEnroll.BackColor = System.Drawing.SystemColors.Window;
            this.rjtxbSearchEnroll.BorderColor = System.Drawing.Color.Black;
            this.rjtxbSearchEnroll.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.rjtxbSearchEnroll.BorderRadius = 0;
            this.rjtxbSearchEnroll.BorderSize = 2;
            this.rjtxbSearchEnroll.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rjtxbSearchEnroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjtxbSearchEnroll.ForeColor = System.Drawing.Color.Black;
            this.rjtxbSearchEnroll.Location = new System.Drawing.Point(386, 152);
            this.rjtxbSearchEnroll.Margin = new System.Windows.Forms.Padding(4);
            this.rjtxbSearchEnroll.Multiline = false;
            this.rjtxbSearchEnroll.Name = "rjtxbSearchEnroll";
            this.rjtxbSearchEnroll.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjtxbSearchEnroll.PasswordChar = false;
            this.rjtxbSearchEnroll.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjtxbSearchEnroll.PlaceholderText = "";
            this.rjtxbSearchEnroll.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.rjtxbSearchEnroll.Size = new System.Drawing.Size(250, 31);
            this.rjtxbSearchEnroll.TabIndex = 6;
            this.rjtxbSearchEnroll.Texts = "";
            this.rjtxbSearchEnroll.UnderlinedStyle = false;
            this.rjtxbSearchEnroll._TextChanged += new System.EventHandler(this.rjtxbEnroll__TextChanged);
            // 
            // lbSearchEnroll
            // 
            this.lbSearchEnroll.AutoSize = true;
            this.lbSearchEnroll.Font = new System.Drawing.Font("Gadugi", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearchEnroll.ForeColor = System.Drawing.Color.Black;
            this.lbSearchEnroll.Location = new System.Drawing.Point(245, 156);
            this.lbSearchEnroll.Name = "lbSearchEnroll";
            this.lbSearchEnroll.Size = new System.Drawing.Size(135, 24);
            this.lbSearchEnroll.TabIndex = 5;
            this.lbSearchEnroll.Text = "Mã Sinh Viên";
            // 
            // dtgvInfo
            // 
            this.dtgvInfo.AllowUserToAddRows = false;
            this.dtgvInfo.AllowUserToDeleteRows = false;
            this.dtgvInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvInfo.Location = new System.Drawing.Point(12, 190);
            this.dtgvInfo.MultiSelect = false;
            this.dtgvInfo.Name = "dtgvInfo";
            this.dtgvInfo.RowHeadersWidth = 51;
            this.dtgvInfo.Size = new System.Drawing.Size(970, 305);
            this.dtgvInfo.TabIndex = 8;
            this.dtgvInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvInfo_CellClick);
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.Silver;
            this.pnlInfo.Controls.Add(this.rjtxbSem);
            this.pnlInfo.Controls.Add(this.btnCancel);
            this.pnlInfo.Controls.Add(this.btnDelete);
            this.pnlInfo.Controls.Add(this.btnUpdate);
            this.pnlInfo.Controls.Add(this.rjtxbPhone);
            this.pnlInfo.Controls.Add(this.rjtxbEmail);
            this.pnlInfo.Controls.Add(this.rjtxbEnroll);
            this.pnlInfo.Controls.Add(this.rjtxbDepart);
            this.pnlInfo.Controls.Add(this.rjtxbName);
            this.pnlInfo.Controls.Add(this.lblEmail);
            this.pnlInfo.Controls.Add(this.lblPhone);
            this.pnlInfo.Controls.Add(this.lblSem);
            this.pnlInfo.Controls.Add(this.lblDepart);
            this.pnlInfo.Controls.Add(this.lblEnroll);
            this.pnlInfo.Controls.Add(this.lblName);
            this.pnlInfo.Location = new System.Drawing.Point(12, 508);
            this.pnlInfo.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(970, 326);
            this.pnlInfo.TabIndex = 9;
            // 
            // rjtxbSem
            // 
            this.rjtxbSem.BackColor = System.Drawing.SystemColors.Window;
            this.rjtxbSem.BorderColor = System.Drawing.Color.Black;
            this.rjtxbSem.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.rjtxbSem.BorderRadius = 10;
            this.rjtxbSem.BorderSize = 1;
            this.rjtxbSem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rjtxbSem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjtxbSem.ForeColor = System.Drawing.Color.Black;
            this.rjtxbSem.Location = new System.Drawing.Point(617, 45);
            this.rjtxbSem.Margin = new System.Windows.Forms.Padding(4);
            this.rjtxbSem.Multiline = false;
            this.rjtxbSem.Name = "rjtxbSem";
            this.rjtxbSem.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjtxbSem.PasswordChar = false;
            this.rjtxbSem.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjtxbSem.PlaceholderText = "";
            this.rjtxbSem.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.rjtxbSem.Size = new System.Drawing.Size(275, 31);
            this.rjtxbSem.TabIndex = 15;
            this.rjtxbSem.Texts = "";
            this.rjtxbSem.UnderlinedStyle = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(772, 259);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 32);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(649, 259);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 32);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(526, 259);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 32);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Cập Nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // rjtxbPhone
            // 
            this.rjtxbPhone.BackColor = System.Drawing.SystemColors.Window;
            this.rjtxbPhone.BorderColor = System.Drawing.Color.Black;
            this.rjtxbPhone.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.rjtxbPhone.BorderRadius = 10;
            this.rjtxbPhone.BorderSize = 1;
            this.rjtxbPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rjtxbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjtxbPhone.ForeColor = System.Drawing.Color.Black;
            this.rjtxbPhone.Location = new System.Drawing.Point(617, 114);
            this.rjtxbPhone.Margin = new System.Windows.Forms.Padding(4);
            this.rjtxbPhone.Multiline = false;
            this.rjtxbPhone.Name = "rjtxbPhone";
            this.rjtxbPhone.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjtxbPhone.PasswordChar = false;
            this.rjtxbPhone.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjtxbPhone.PlaceholderText = "";
            this.rjtxbPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.rjtxbPhone.Size = new System.Drawing.Size(275, 31);
            this.rjtxbPhone.TabIndex = 11;
            this.rjtxbPhone.Texts = "";
            this.rjtxbPhone.UnderlinedStyle = false;
            // 
            // rjtxbEmail
            // 
            this.rjtxbEmail.BackColor = System.Drawing.SystemColors.Window;
            this.rjtxbEmail.BorderColor = System.Drawing.Color.Black;
            this.rjtxbEmail.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.rjtxbEmail.BorderRadius = 10;
            this.rjtxbEmail.BorderSize = 1;
            this.rjtxbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rjtxbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjtxbEmail.ForeColor = System.Drawing.Color.Black;
            this.rjtxbEmail.Location = new System.Drawing.Point(617, 183);
            this.rjtxbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.rjtxbEmail.Multiline = false;
            this.rjtxbEmail.Name = "rjtxbEmail";
            this.rjtxbEmail.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjtxbEmail.PasswordChar = false;
            this.rjtxbEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjtxbEmail.PlaceholderText = "";
            this.rjtxbEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.rjtxbEmail.Size = new System.Drawing.Size(275, 31);
            this.rjtxbEmail.TabIndex = 10;
            this.rjtxbEmail.Texts = "";
            this.rjtxbEmail.UnderlinedStyle = false;
            // 
            // rjtxbEnroll
            // 
            this.rjtxbEnroll.BackColor = System.Drawing.SystemColors.Window;
            this.rjtxbEnroll.BorderColor = System.Drawing.Color.Black;
            this.rjtxbEnroll.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.rjtxbEnroll.BorderRadius = 10;
            this.rjtxbEnroll.BorderSize = 1;
            this.rjtxbEnroll.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rjtxbEnroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjtxbEnroll.ForeColor = System.Drawing.Color.Black;
            this.rjtxbEnroll.Location = new System.Drawing.Point(183, 114);
            this.rjtxbEnroll.Margin = new System.Windows.Forms.Padding(4);
            this.rjtxbEnroll.Multiline = false;
            this.rjtxbEnroll.Name = "rjtxbEnroll";
            this.rjtxbEnroll.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjtxbEnroll.PasswordChar = false;
            this.rjtxbEnroll.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjtxbEnroll.PlaceholderText = "";
            this.rjtxbEnroll.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.rjtxbEnroll.Size = new System.Drawing.Size(275, 31);
            this.rjtxbEnroll.TabIndex = 8;
            this.rjtxbEnroll.Texts = "";
            this.rjtxbEnroll.UnderlinedStyle = false;
            // 
            // rjtxbDepart
            // 
            this.rjtxbDepart.BackColor = System.Drawing.SystemColors.Window;
            this.rjtxbDepart.BorderColor = System.Drawing.Color.Black;
            this.rjtxbDepart.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.rjtxbDepart.BorderRadius = 10;
            this.rjtxbDepart.BorderSize = 1;
            this.rjtxbDepart.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rjtxbDepart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjtxbDepart.ForeColor = System.Drawing.Color.Black;
            this.rjtxbDepart.Location = new System.Drawing.Point(183, 183);
            this.rjtxbDepart.Margin = new System.Windows.Forms.Padding(4);
            this.rjtxbDepart.Multiline = false;
            this.rjtxbDepart.Name = "rjtxbDepart";
            this.rjtxbDepart.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjtxbDepart.PasswordChar = false;
            this.rjtxbDepart.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjtxbDepart.PlaceholderText = "";
            this.rjtxbDepart.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.rjtxbDepart.Size = new System.Drawing.Size(275, 31);
            this.rjtxbDepart.TabIndex = 7;
            this.rjtxbDepart.Texts = "";
            this.rjtxbDepart.UnderlinedStyle = false;
            // 
            // rjtxbName
            // 
            this.rjtxbName.BackColor = System.Drawing.SystemColors.Window;
            this.rjtxbName.BorderColor = System.Drawing.Color.Black;
            this.rjtxbName.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.rjtxbName.BorderRadius = 10;
            this.rjtxbName.BorderSize = 1;
            this.rjtxbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rjtxbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjtxbName.ForeColor = System.Drawing.Color.Black;
            this.rjtxbName.Location = new System.Drawing.Point(183, 45);
            this.rjtxbName.Margin = new System.Windows.Forms.Padding(4);
            this.rjtxbName.Multiline = false;
            this.rjtxbName.Name = "rjtxbName";
            this.rjtxbName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjtxbName.PasswordChar = false;
            this.rjtxbName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjtxbName.PlaceholderText = "";
            this.rjtxbName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.rjtxbName.Size = new System.Drawing.Size(275, 31);
            this.rjtxbName.TabIndex = 6;
            this.rjtxbName.Texts = "";
            this.rjtxbName.UnderlinedStyle = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblEmail.Font = new System.Drawing.Font("Gadugi", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(498, 190);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(3, 0, 3, 45);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 24);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblPhone.Font = new System.Drawing.Font("Gadugi", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(498, 121);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(3, 0, 3, 45);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(115, 24);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Số điện thoại";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSem
            // 
            this.lblSem.AutoSize = true;
            this.lblSem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblSem.Font = new System.Drawing.Font("Gadugi", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSem.Location = new System.Drawing.Point(498, 52);
            this.lblSem.Margin = new System.Windows.Forms.Padding(3, 0, 3, 45);
            this.lblSem.Name = "lblSem";
            this.lblSem.Size = new System.Drawing.Size(50, 24);
            this.lblSem.TabIndex = 3;
            this.lblSem.Text = "Năm";
            this.lblSem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDepart
            // 
            this.lblDepart.AutoSize = true;
            this.lblDepart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDepart.Font = new System.Drawing.Font("Gadugi", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepart.Location = new System.Drawing.Point(54, 190);
            this.lblDepart.Margin = new System.Windows.Forms.Padding(3, 0, 3, 45);
            this.lblDepart.Name = "lblDepart";
            this.lblDepart.Size = new System.Drawing.Size(55, 24);
            this.lblDepart.TabIndex = 2;
            this.lblDepart.Text = "Khoa";
            this.lblDepart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEnroll
            // 
            this.lblEnroll.AutoSize = true;
            this.lblEnroll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblEnroll.Font = new System.Drawing.Font("Gadugi", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnroll.Location = new System.Drawing.Point(54, 121);
            this.lblEnroll.Margin = new System.Windows.Forms.Padding(3, 0, 3, 45);
            this.lblEnroll.Name = "lblEnroll";
            this.lblEnroll.Size = new System.Drawing.Size(120, 24);
            this.lblEnroll.TabIndex = 1;
            this.lblEnroll.Text = "Mã ghi danh";
            this.lblEnroll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblName.Font = new System.Drawing.Font("Gadugi", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(54, 52);
            this.lblName.Margin = new System.Windows.Forms.Padding(3, 0, 3, 45);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(122, 24);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Tên sinh viên";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ViewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(177)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(994, 525);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.dtgvInfo);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.rjtxbSearchEnroll);
            this.Controls.Add(this.lbSearchEnroll);
            this.Controls.Add(this.pnlTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewStudent";
            this.Load += new System.EventHandler(this.ViewStudent_Load);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInfo)).EndInit();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private ToggleButton.RJControls.RJGoodShapeBtn rjbtnExit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picbTitle;
        private System.Windows.Forms.Button btnRefresh;
        private ToggleButton.RJControls.RJTextBoxBorderCus rjtxbSearchEnroll;
        private System.Windows.Forms.Label lbSearchEnroll;
        private System.Windows.Forms.DataGridView dtgvInfo;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private ToggleButton.RJControls.RJTextBoxBorderCus rjtxbPhone;
        private ToggleButton.RJControls.RJTextBoxBorderCus rjtxbEmail;
        private ToggleButton.RJControls.RJTextBoxBorderCus rjtxbEnroll;
        private ToggleButton.RJControls.RJTextBoxBorderCus rjtxbDepart;
        private ToggleButton.RJControls.RJTextBoxBorderCus rjtxbName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblSem;
        private System.Windows.Forms.Label lblDepart;
        private System.Windows.Forms.Label lblEnroll;
        private System.Windows.Forms.Label lblName;
        private ToggleButton.RJControls.RJTextBoxBorderCus rjtxbSem;
    }
}