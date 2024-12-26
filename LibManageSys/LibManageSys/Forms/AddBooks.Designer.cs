namespace LibManageSys
{
    partial class AddBooks
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
            this.pnlHead = new System.Windows.Forms.Panel();
            this.rjbtnExit = new ToggleButton.RJControls.RJGoodShapeBtn();
            this.lblAddBooks = new System.Windows.Forms.Label();
            this.pnlBottem = new System.Windows.Forms.Panel();
            this.rjpgbProgress = new ToggleButton.RJControls.RJProgressBar();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txbBQuan = new ToggleButton.RJControls.RJTextBoxBorderCus();
            this.txbBPublication = new ToggleButton.RJControls.RJTextBoxBorderCus();
            this.txbBAuthor = new ToggleButton.RJControls.RJTextBoxBorderCus();
            this.txbBName = new ToggleButton.RJControls.RJTextBoxBorderCus();
            this.rjdtpkBBought = new ToggleButton.RJControls.RJDateTimePicker();
            this.txbBPrice = new ToggleButton.RJControls.RJTextBoxBorderCus();
            this.lblBQuan = new System.Windows.Forms.Label();
            this.lblBPrice = new System.Windows.Forms.Label();
            this.lblBBought = new System.Windows.Forms.Label();
            this.lblBName = new System.Windows.Forms.Label();
            this.lblBAuthor = new System.Windows.Forms.Label();
            this.lblBPublication = new System.Windows.Forms.Label();
            this.timerProgress = new System.Windows.Forms.Timer(this.components);
            this.picbBooks = new System.Windows.Forms.PictureBox();
            this.picbBranner = new System.Windows.Forms.PictureBox();
            this.pnlHead.SuspendLayout();
            this.pnlBottem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbBranner)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHead
            // 
            this.pnlHead.BackColor = System.Drawing.Color.BurlyWood;
            this.pnlHead.Controls.Add(this.rjbtnExit);
            this.pnlHead.Controls.Add(this.lblAddBooks);
            this.pnlHead.Controls.Add(this.picbBooks);
            this.pnlHead.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHead.Location = new System.Drawing.Point(0, 0);
            this.pnlHead.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHead.Name = "pnlHead";
            this.pnlHead.Size = new System.Drawing.Size(684, 77);
            this.pnlHead.TabIndex = 1;
            this.pnlHead.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHead_MouseDown);
            // 
            // rjbtnExit
            // 
            this.rjbtnExit.BackColor = System.Drawing.Color.BurlyWood;
            this.rjbtnExit.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.rjbtnExit.BorderColor = System.Drawing.Color.Red;
            this.rjbtnExit.BorderRadius = 20;
            this.rjbtnExit.BorderSize = 2;
            this.rjbtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjbtnExit.FlatAppearance.BorderSize = 0;
            this.rjbtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjbtnExit.ForeColor = System.Drawing.Color.White;
            this.rjbtnExit.Location = new System.Drawing.Point(657, 7);
            this.rjbtnExit.Margin = new System.Windows.Forms.Padding(0);
            this.rjbtnExit.Name = "rjbtnExit";
            this.rjbtnExit.Size = new System.Drawing.Size(20, 20);
            this.rjbtnExit.TabIndex = 2;
            this.rjbtnExit.TextColor = System.Drawing.Color.White;
            this.rjbtnExit.UseVisualStyleBackColor = false;
            this.rjbtnExit.Click += new System.EventHandler(this.rjbtnExit_Click);
            // 
            // lblAddBooks
            // 
            this.lblAddBooks.AutoSize = true;
            this.lblAddBooks.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddBooks.ForeColor = System.Drawing.Color.Black;
            this.lblAddBooks.Location = new System.Drawing.Point(318, 26);
            this.lblAddBooks.Margin = new System.Windows.Forms.Padding(0);
            this.lblAddBooks.Name = "lblAddBooks";
            this.lblAddBooks.Size = new System.Drawing.Size(125, 24);
            this.lblAddBooks.TabIndex = 1;
            this.lblAddBooks.Text = "Thêm Sách";
            this.lblAddBooks.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHead_MouseDown);
            // 
            // pnlBottem
            // 
            this.pnlBottem.BackColor = System.Drawing.Color.Bisque;
            this.pnlBottem.Controls.Add(this.rjpgbProgress);
            this.pnlBottem.Controls.Add(this.btnDelete);
            this.pnlBottem.Controls.Add(this.btnSave);
            this.pnlBottem.Controls.Add(this.txbBQuan);
            this.pnlBottem.Controls.Add(this.txbBPublication);
            this.pnlBottem.Controls.Add(this.txbBAuthor);
            this.pnlBottem.Controls.Add(this.txbBName);
            this.pnlBottem.Controls.Add(this.rjdtpkBBought);
            this.pnlBottem.Controls.Add(this.txbBPrice);
            this.pnlBottem.Controls.Add(this.lblBQuan);
            this.pnlBottem.Controls.Add(this.lblBPrice);
            this.pnlBottem.Controls.Add(this.lblBBought);
            this.pnlBottem.Controls.Add(this.lblBName);
            this.pnlBottem.Controls.Add(this.lblBAuthor);
            this.pnlBottem.Controls.Add(this.lblBPublication);
            this.pnlBottem.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBottem.Location = new System.Drawing.Point(275, 77);
            this.pnlBottem.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBottem.Name = "pnlBottem";
            this.pnlBottem.Size = new System.Drawing.Size(409, 351);
            this.pnlBottem.TabIndex = 2;
            // 
            // rjpgbProgress
            // 
            this.rjpgbProgress.ChannelColor = System.Drawing.Color.Lavender;
            this.rjpgbProgress.ChannelHeight = 10;
            this.rjpgbProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjpgbProgress.ForeBackColor = System.Drawing.Color.Transparent;
            this.rjpgbProgress.ForeColor = System.Drawing.Color.Black;
            this.rjpgbProgress.IncrementValue = 1;
            this.rjpgbProgress.Location = new System.Drawing.Point(18, 311);
            this.rjpgbProgress.Name = "rjpgbProgress";
            this.rjpgbProgress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rjpgbProgress.ShowMaximun = false;
            this.rjpgbProgress.ShowValue = ToggleButton.RJControls.TextPosition.Sliding;
            this.rjpgbProgress.Size = new System.Drawing.Size(139, 30);
            this.rjpgbProgress.SliderColor = System.Drawing.Color.Lime;
            this.rjpgbProgress.SliderHeight = 10;
            this.rjpgbProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.rjpgbProgress.SymbolAfter = "%";
            this.rjpgbProgress.SymbolBefore = "";
            this.rjpgbProgress.TabIndex = 14;
            this.rjpgbProgress.Value = 20;
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(276, 311);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 30);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "XÓA";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(177, 311);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 30);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "LƯU";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txbBQuan
            // 
            this.txbBQuan.BackColor = System.Drawing.Color.Bisque;
            this.txbBQuan.BorderColor = System.Drawing.Color.SaddleBrown;
            this.txbBQuan.BorderFocusColor = System.Drawing.Color.MidnightBlue;
            this.txbBQuan.BorderRadius = 0;
            this.txbBQuan.BorderSize = 2;
            this.txbBQuan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbBQuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBQuan.ForeColor = System.Drawing.Color.Black;
            this.txbBQuan.Location = new System.Drawing.Point(142, 267);
            this.txbBQuan.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.txbBQuan.Multiline = false;
            this.txbBQuan.Name = "txbBQuan";
            this.txbBQuan.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbBQuan.PasswordChar = false;
            this.txbBQuan.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbBQuan.PlaceholderText = "";
            this.txbBQuan.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbBQuan.Size = new System.Drawing.Size(250, 31);
            this.txbBQuan.TabIndex = 11;
            this.txbBQuan.Texts = "";
            this.txbBQuan.UnderlinedStyle = true;
            this.txbBQuan._TextChanged += new System.EventHandler(this.rjTextBoxBorderCus1__TextChanged);
            // 
            // txbBPublication
            // 
            this.txbBPublication.BackColor = System.Drawing.Color.Bisque;
            this.txbBPublication.BorderColor = System.Drawing.Color.SaddleBrown;
            this.txbBPublication.BorderFocusColor = System.Drawing.Color.MidnightBlue;
            this.txbBPublication.BorderRadius = 0;
            this.txbBPublication.BorderSize = 2;
            this.txbBPublication.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbBPublication.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBPublication.ForeColor = System.Drawing.Color.Black;
            this.txbBPublication.Location = new System.Drawing.Point(142, 120);
            this.txbBPublication.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.txbBPublication.Multiline = false;
            this.txbBPublication.Name = "txbBPublication";
            this.txbBPublication.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbBPublication.PasswordChar = false;
            this.txbBPublication.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbBPublication.PlaceholderText = "";
            this.txbBPublication.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbBPublication.Size = new System.Drawing.Size(250, 31);
            this.txbBPublication.TabIndex = 10;
            this.txbBPublication.Texts = "";
            this.txbBPublication.UnderlinedStyle = true;
            // 
            // txbBAuthor
            // 
            this.txbBAuthor.BackColor = System.Drawing.Color.Bisque;
            this.txbBAuthor.BorderColor = System.Drawing.Color.SaddleBrown;
            this.txbBAuthor.BorderFocusColor = System.Drawing.Color.MidnightBlue;
            this.txbBAuthor.BorderRadius = 0;
            this.txbBAuthor.BorderSize = 2;
            this.txbBAuthor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbBAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBAuthor.ForeColor = System.Drawing.Color.Black;
            this.txbBAuthor.Location = new System.Drawing.Point(142, 71);
            this.txbBAuthor.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.txbBAuthor.Multiline = false;
            this.txbBAuthor.Name = "txbBAuthor";
            this.txbBAuthor.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbBAuthor.PasswordChar = false;
            this.txbBAuthor.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbBAuthor.PlaceholderText = "";
            this.txbBAuthor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbBAuthor.Size = new System.Drawing.Size(250, 31);
            this.txbBAuthor.TabIndex = 9;
            this.txbBAuthor.Texts = "";
            this.txbBAuthor.UnderlinedStyle = true;
            // 
            // txbBName
            // 
            this.txbBName.BackColor = System.Drawing.Color.Bisque;
            this.txbBName.BorderColor = System.Drawing.Color.SaddleBrown;
            this.txbBName.BorderFocusColor = System.Drawing.Color.MidnightBlue;
            this.txbBName.BorderRadius = 0;
            this.txbBName.BorderSize = 2;
            this.txbBName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbBName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBName.ForeColor = System.Drawing.Color.Black;
            this.txbBName.Location = new System.Drawing.Point(142, 22);
            this.txbBName.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.txbBName.Multiline = false;
            this.txbBName.Name = "txbBName";
            this.txbBName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbBName.PasswordChar = false;
            this.txbBName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbBName.PlaceholderText = "";
            this.txbBName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbBName.Size = new System.Drawing.Size(250, 31);
            this.txbBName.TabIndex = 8;
            this.txbBName.Texts = "";
            this.txbBName.UnderlinedStyle = true;
            // 
            // rjdtpkBBought
            // 
            this.rjdtpkBBought.BorderColor = System.Drawing.Color.Black;
            this.rjdtpkBBought.BorderSize = 1;
            this.rjdtpkBBought.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjdtpkBBought.CalendarForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.rjdtpkBBought.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack;
            this.rjdtpkBBought.CalendarTitleBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rjdtpkBBought.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rjdtpkBBought.CalendarTrailingForeColor = System.Drawing.SystemColors.Control;
            this.rjdtpkBBought.CustomFormat = "dd/MM/yyyy";
            this.rjdtpkBBought.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjdtpkBBought.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.rjdtpkBBought.Location = new System.Drawing.Point(142, 167);
            this.rjdtpkBBought.MinimumSize = new System.Drawing.Size(4, 35);
            this.rjdtpkBBought.Name = "rjdtpkBBought";
            this.rjdtpkBBought.Size = new System.Drawing.Size(250, 35);
            this.rjdtpkBBought.SkinColor = System.Drawing.Color.MidnightBlue;
            this.rjdtpkBBought.TabIndex = 7;
            this.rjdtpkBBought.TextColor = System.Drawing.Color.White;
            // 
            // txbBPrice
            // 
            this.txbBPrice.BackColor = System.Drawing.Color.Bisque;
            this.txbBPrice.BorderColor = System.Drawing.Color.SaddleBrown;
            this.txbBPrice.BorderFocusColor = System.Drawing.Color.MidnightBlue;
            this.txbBPrice.BorderRadius = 0;
            this.txbBPrice.BorderSize = 2;
            this.txbBPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbBPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBPrice.ForeColor = System.Drawing.Color.Black;
            this.txbBPrice.Location = new System.Drawing.Point(142, 218);
            this.txbBPrice.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.txbBPrice.Multiline = false;
            this.txbBPrice.Name = "txbBPrice";
            this.txbBPrice.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbBPrice.PasswordChar = false;
            this.txbBPrice.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbBPrice.PlaceholderText = "";
            this.txbBPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbBPrice.Size = new System.Drawing.Size(250, 31);
            this.txbBPrice.TabIndex = 6;
            this.txbBPrice.Texts = "";
            this.txbBPrice.UnderlinedStyle = true;
            this.txbBPrice._TextChanged += new System.EventHandler(this.rjTextBoxBorderCus1__TextChanged);
            // 
            // lblBQuan
            // 
            this.lblBQuan.AutoSize = true;
            this.lblBQuan.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBQuan.ForeColor = System.Drawing.Color.Black;
            this.lblBQuan.Location = new System.Drawing.Point(15, 274);
            this.lblBQuan.Margin = new System.Windows.Forms.Padding(15, 0, 0, 30);
            this.lblBQuan.Name = "lblBQuan";
            this.lblBQuan.Size = new System.Drawing.Size(76, 19);
            this.lblBQuan.TabIndex = 5;
            this.lblBQuan.Text = "Số Lượng";
            // 
            // lblBPrice
            // 
            this.lblBPrice.AutoSize = true;
            this.lblBPrice.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBPrice.ForeColor = System.Drawing.Color.Black;
            this.lblBPrice.Location = new System.Drawing.Point(15, 225);
            this.lblBPrice.Margin = new System.Windows.Forms.Padding(15, 0, 0, 30);
            this.lblBPrice.Name = "lblBPrice";
            this.lblBPrice.Size = new System.Drawing.Size(67, 19);
            this.lblBPrice.TabIndex = 4;
            this.lblBPrice.Text = "Giá Tiền";
            // 
            // lblBBought
            // 
            this.lblBBought.AutoSize = true;
            this.lblBBought.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBBought.ForeColor = System.Drawing.Color.Black;
            this.lblBBought.Location = new System.Drawing.Point(15, 176);
            this.lblBBought.Margin = new System.Windows.Forms.Padding(15, 0, 0, 30);
            this.lblBBought.Name = "lblBBought";
            this.lblBBought.Size = new System.Drawing.Size(117, 19);
            this.lblBBought.TabIndex = 3;
            this.lblBBought.Text = "Ngày Mua Sách";
            // 
            // lblBName
            // 
            this.lblBName.AutoSize = true;
            this.lblBName.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBName.ForeColor = System.Drawing.Color.Black;
            this.lblBName.Location = new System.Drawing.Point(15, 29);
            this.lblBName.Margin = new System.Windows.Forms.Padding(15, 0, 0, 30);
            this.lblBName.Name = "lblBName";
            this.lblBName.Size = new System.Drawing.Size(71, 19);
            this.lblBName.TabIndex = 2;
            this.lblBName.Text = "Tên Sách";
            // 
            // lblBAuthor
            // 
            this.lblBAuthor.AutoSize = true;
            this.lblBAuthor.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBAuthor.ForeColor = System.Drawing.Color.Black;
            this.lblBAuthor.Location = new System.Drawing.Point(15, 78);
            this.lblBAuthor.Margin = new System.Windows.Forms.Padding(15, 0, 0, 30);
            this.lblBAuthor.Name = "lblBAuthor";
            this.lblBAuthor.Size = new System.Drawing.Size(91, 19);
            this.lblBAuthor.TabIndex = 1;
            this.lblBAuthor.Text = "Tên Tác Giả";
            // 
            // lblBPublication
            // 
            this.lblBPublication.AutoSize = true;
            this.lblBPublication.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBPublication.ForeColor = System.Drawing.Color.Black;
            this.lblBPublication.Location = new System.Drawing.Point(15, 127);
            this.lblBPublication.Margin = new System.Windows.Forms.Padding(15, 0, 0, 30);
            this.lblBPublication.Name = "lblBPublication";
            this.lblBPublication.Size = new System.Drawing.Size(108, 19);
            this.lblBPublication.TabIndex = 0;
            this.lblBPublication.Text = "Nhà Xuất Bản";
            // 
            // timerProgress
            // 
            this.timerProgress.Interval = 15;
            this.timerProgress.Tick += new System.EventHandler(this.timerProgress_Tick);
            // 
            // picbBooks
            // 
            this.picbBooks.Image = global::LibManageSys.Properties.Resources.icons8_books_77;
            this.picbBooks.Location = new System.Drawing.Point(241, 0);
            this.picbBooks.Margin = new System.Windows.Forms.Padding(0);
            this.picbBooks.Name = "picbBooks";
            this.picbBooks.Size = new System.Drawing.Size(77, 77);
            this.picbBooks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbBooks.TabIndex = 0;
            this.picbBooks.TabStop = false;
            this.picbBooks.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHead_MouseDown);
            // 
            // picbBranner
            // 
            this.picbBranner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbBranner.Image = global::LibManageSys.Properties.Resources.motivation1;
            this.picbBranner.Location = new System.Drawing.Point(0, 77);
            this.picbBranner.Margin = new System.Windows.Forms.Padding(0);
            this.picbBranner.Name = "picbBranner";
            this.picbBranner.Size = new System.Drawing.Size(275, 351);
            this.picbBranner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbBranner.TabIndex = 0;
            this.picbBranner.TabStop = false;
            this.picbBranner.Click += new System.EventHandler(this.picbBranner_Click);
            // 
            // AddBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 428);
            this.Controls.Add(this.pnlBottem);
            this.Controls.Add(this.pnlHead);
            this.Controls.Add(this.picbBranner);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBooks";
            this.pnlHead.ResumeLayout(false);
            this.pnlHead.PerformLayout();
            this.pnlBottem.ResumeLayout(false);
            this.pnlBottem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbBranner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picbBranner;
        private System.Windows.Forms.Panel pnlHead;
        private System.Windows.Forms.Panel pnlBottem;
        private System.Windows.Forms.PictureBox picbBooks;
        private System.Windows.Forms.Label lblAddBooks;
        private ToggleButton.RJControls.RJGoodShapeBtn rjbtnExit;
        private System.Windows.Forms.Label lblBPublication;
        private System.Windows.Forms.Label lblBQuan;
        private System.Windows.Forms.Label lblBPrice;
        private System.Windows.Forms.Label lblBBought;
        private System.Windows.Forms.Label lblBName;
        private System.Windows.Forms.Label lblBAuthor;
        private ToggleButton.RJControls.RJTextBoxBorderCus txbBQuan;
        private ToggleButton.RJControls.RJTextBoxBorderCus txbBPublication;
        private ToggleButton.RJControls.RJTextBoxBorderCus txbBAuthor;
        private ToggleButton.RJControls.RJTextBoxBorderCus txbBName;
        private ToggleButton.RJControls.RJDateTimePicker rjdtpkBBought;
        private ToggleButton.RJControls.RJTextBoxBorderCus txbBPrice;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Timer timerProgress;
        private ToggleButton.RJControls.RJProgressBar rjpgbProgress;
    }
}