namespace LibManageSys.Forms
{
    partial class ViewBook
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
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.picbTitle = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblBName = new System.Windows.Forms.Label();
            this.rjtxbBName = new ToggleButton.RJControls.RJTextBoxBorderCus();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dtgvInfo = new System.Windows.Forms.DataGridView();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblBook = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblPublication = new System.Windows.Forms.Label();
            this.lblPurchaseDate = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.rjtxbBook = new ToggleButton.RJControls.RJTextBoxBorderCus();
            this.rjtxbPublication = new ToggleButton.RJControls.RJTextBoxBorderCus();
            this.rjtxbAuthor = new ToggleButton.RJControls.RJTextBoxBorderCus();
            this.rjtxbQuantity = new ToggleButton.RJControls.RJTextBoxBorderCus();
            this.rjtxbPrice = new ToggleButton.RJControls.RJTextBoxBorderCus();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rjDropdownMenu1 = new ToggleButton.RJControls.RJDropdownMenu(this.components);
            this.rjDateTimePicker1 = new ToggleButton.RJControls.RJDateTimePicker();
            this.rjbtnExit = new ToggleButton.RJControls.RJGoodShapeBtn();
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
            this.pnlTitle.TabIndex = 0;
            this.pnlTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseDown);
            // 
            // picbTitle
            // 
            this.picbTitle.BackColor = System.Drawing.Color.Transparent;
            this.picbTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbTitle.Image = global::LibManageSys.Properties.Resources.viewbook;
            this.picbTitle.Location = new System.Drawing.Point(227, -34);
            this.picbTitle.Name = "picbTitle";
            this.picbTitle.Size = new System.Drawing.Size(340, 203);
            this.picbTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbTitle.TabIndex = 0;
            this.picbTitle.TabStop = false;
            this.picbTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseDown);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTitle.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTitle.Location = new System.Drawing.Point(496, 53);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(248, 28);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Xem Danh Sách Sách";
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseDown);
            // 
            // lblBName
            // 
            this.lblBName.AutoSize = true;
            this.lblBName.Font = new System.Drawing.Font("Gadugi", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBName.ForeColor = System.Drawing.Color.Black;
            this.lblBName.Location = new System.Drawing.Point(262, 161);
            this.lblBName.Name = "lblBName";
            this.lblBName.Size = new System.Drawing.Size(95, 24);
            this.lblBName.TabIndex = 2;
            this.lblBName.Text = "Tên Sách";
            // 
            // rjtxbBName
            // 
            this.rjtxbBName.BackColor = System.Drawing.SystemColors.Window;
            this.rjtxbBName.BorderColor = System.Drawing.Color.Black;
            this.rjtxbBName.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.rjtxbBName.BorderRadius = 0;
            this.rjtxbBName.BorderSize = 2;
            this.rjtxbBName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rjtxbBName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjtxbBName.ForeColor = System.Drawing.Color.Black;
            this.rjtxbBName.Location = new System.Drawing.Point(364, 157);
            this.rjtxbBName.Margin = new System.Windows.Forms.Padding(4);
            this.rjtxbBName.Multiline = false;
            this.rjtxbBName.Name = "rjtxbBName";
            this.rjtxbBName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjtxbBName.PasswordChar = false;
            this.rjtxbBName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjtxbBName.PlaceholderText = "";
            this.rjtxbBName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.rjtxbBName.Size = new System.Drawing.Size(250, 31);
            this.rjtxbBName.TabIndex = 3;
            this.rjtxbBName.Texts = "";
            this.rjtxbBName.UnderlinedStyle = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoSize = true;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(621, 157);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(88, 32);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Tải lại";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // dtgvInfo
            // 
            this.dtgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvInfo.Location = new System.Drawing.Point(12, 195);
            this.dtgvInfo.Name = "dtgvInfo";
            this.dtgvInfo.Size = new System.Drawing.Size(970, 305);
            this.dtgvInfo.TabIndex = 5;
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.Silver;
            this.pnlInfo.Controls.Add(this.rjDateTimePicker1);
            this.pnlInfo.Controls.Add(this.btnCancel);
            this.pnlInfo.Controls.Add(this.btnDelete);
            this.pnlInfo.Controls.Add(this.btnUpdate);
            this.pnlInfo.Controls.Add(this.rjtxbPrice);
            this.pnlInfo.Controls.Add(this.rjtxbQuantity);
            this.pnlInfo.Controls.Add(this.rjtxbAuthor);
            this.pnlInfo.Controls.Add(this.rjtxbPublication);
            this.pnlInfo.Controls.Add(this.rjtxbBook);
            this.pnlInfo.Controls.Add(this.lblQuantity);
            this.pnlInfo.Controls.Add(this.lblPrice);
            this.pnlInfo.Controls.Add(this.lblPurchaseDate);
            this.pnlInfo.Controls.Add(this.lblPublication);
            this.pnlInfo.Controls.Add(this.lblAuthor);
            this.pnlInfo.Controls.Add(this.lblBook);
            this.pnlInfo.Location = new System.Drawing.Point(12, 513);
            this.pnlInfo.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(970, 326);
            this.pnlInfo.TabIndex = 6;
            // 
            // lblBook
            // 
            this.lblBook.AutoSize = true;
            this.lblBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblBook.Font = new System.Drawing.Font("Gadugi", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBook.Location = new System.Drawing.Point(54, 52);
            this.lblBook.Margin = new System.Windows.Forms.Padding(3, 0, 3, 45);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(84, 24);
            this.lblBook.TabIndex = 0;
            this.lblBook.Text = "Tên sách";
            this.lblBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblAuthor.Font = new System.Drawing.Font("Gadugi", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(54, 121);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(3, 0, 3, 45);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(69, 24);
            this.lblAuthor.TabIndex = 1;
            this.lblAuthor.Text = "Tác giả";
            this.lblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPublication
            // 
            this.lblPublication.AutoSize = true;
            this.lblPublication.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblPublication.Font = new System.Drawing.Font("Gadugi", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublication.Location = new System.Drawing.Point(54, 190);
            this.lblPublication.Margin = new System.Windows.Forms.Padding(3, 0, 3, 45);
            this.lblPublication.Name = "lblPublication";
            this.lblPublication.Size = new System.Drawing.Size(122, 24);
            this.lblPublication.TabIndex = 2;
            this.lblPublication.Text = "Nhà xuất bản";
            this.lblPublication.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPurchaseDate
            // 
            this.lblPurchaseDate.AutoSize = true;
            this.lblPurchaseDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblPurchaseDate.Font = new System.Drawing.Font("Gadugi", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchaseDate.Location = new System.Drawing.Point(498, 52);
            this.lblPurchaseDate.Margin = new System.Windows.Forms.Padding(3, 0, 3, 45);
            this.lblPurchaseDate.Name = "lblPurchaseDate";
            this.lblPurchaseDate.Size = new System.Drawing.Size(104, 24);
            this.lblPurchaseDate.TabIndex = 3;
            this.lblPurchaseDate.Text = "Ngày nhập";
            this.lblPurchaseDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblPrice.Font = new System.Drawing.Font("Gadugi", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(498, 121);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(3, 0, 3, 45);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(39, 24);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Giá";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblQuantity.Font = new System.Drawing.Font("Gadugi", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(498, 190);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(3, 0, 3, 45);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(112, 24);
            this.lblQuantity.TabIndex = 5;
            this.lblQuantity.Text = "Số lượng tồn";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rjtxbBook
            // 
            this.rjtxbBook.BackColor = System.Drawing.SystemColors.Window;
            this.rjtxbBook.BorderColor = System.Drawing.Color.Black;
            this.rjtxbBook.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.rjtxbBook.BorderRadius = 10;
            this.rjtxbBook.BorderSize = 1;
            this.rjtxbBook.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rjtxbBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjtxbBook.ForeColor = System.Drawing.Color.Black;
            this.rjtxbBook.Location = new System.Drawing.Point(183, 45);
            this.rjtxbBook.Margin = new System.Windows.Forms.Padding(4);
            this.rjtxbBook.Multiline = false;
            this.rjtxbBook.Name = "rjtxbBook";
            this.rjtxbBook.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjtxbBook.PasswordChar = false;
            this.rjtxbBook.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjtxbBook.PlaceholderText = "";
            this.rjtxbBook.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.rjtxbBook.Size = new System.Drawing.Size(275, 31);
            this.rjtxbBook.TabIndex = 6;
            this.rjtxbBook.Texts = "";
            this.rjtxbBook.UnderlinedStyle = false;
            // 
            // rjtxbPublication
            // 
            this.rjtxbPublication.BackColor = System.Drawing.SystemColors.Window;
            this.rjtxbPublication.BorderColor = System.Drawing.Color.Black;
            this.rjtxbPublication.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.rjtxbPublication.BorderRadius = 10;
            this.rjtxbPublication.BorderSize = 1;
            this.rjtxbPublication.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rjtxbPublication.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjtxbPublication.ForeColor = System.Drawing.Color.Black;
            this.rjtxbPublication.Location = new System.Drawing.Point(183, 183);
            this.rjtxbPublication.Margin = new System.Windows.Forms.Padding(4);
            this.rjtxbPublication.Multiline = false;
            this.rjtxbPublication.Name = "rjtxbPublication";
            this.rjtxbPublication.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjtxbPublication.PasswordChar = false;
            this.rjtxbPublication.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjtxbPublication.PlaceholderText = "";
            this.rjtxbPublication.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.rjtxbPublication.Size = new System.Drawing.Size(275, 31);
            this.rjtxbPublication.TabIndex = 7;
            this.rjtxbPublication.Texts = "";
            this.rjtxbPublication.UnderlinedStyle = false;
            // 
            // rjtxbAuthor
            // 
            this.rjtxbAuthor.BackColor = System.Drawing.SystemColors.Window;
            this.rjtxbAuthor.BorderColor = System.Drawing.Color.Black;
            this.rjtxbAuthor.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.rjtxbAuthor.BorderRadius = 10;
            this.rjtxbAuthor.BorderSize = 1;
            this.rjtxbAuthor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rjtxbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjtxbAuthor.ForeColor = System.Drawing.Color.Black;
            this.rjtxbAuthor.Location = new System.Drawing.Point(183, 114);
            this.rjtxbAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.rjtxbAuthor.Multiline = false;
            this.rjtxbAuthor.Name = "rjtxbAuthor";
            this.rjtxbAuthor.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjtxbAuthor.PasswordChar = false;
            this.rjtxbAuthor.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjtxbAuthor.PlaceholderText = "";
            this.rjtxbAuthor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.rjtxbAuthor.Size = new System.Drawing.Size(275, 31);
            this.rjtxbAuthor.TabIndex = 8;
            this.rjtxbAuthor.Texts = "";
            this.rjtxbAuthor.UnderlinedStyle = false;
            // 
            // rjtxbQuantity
            // 
            this.rjtxbQuantity.BackColor = System.Drawing.SystemColors.Window;
            this.rjtxbQuantity.BorderColor = System.Drawing.Color.Black;
            this.rjtxbQuantity.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.rjtxbQuantity.BorderRadius = 10;
            this.rjtxbQuantity.BorderSize = 1;
            this.rjtxbQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rjtxbQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjtxbQuantity.ForeColor = System.Drawing.Color.Black;
            this.rjtxbQuantity.Location = new System.Drawing.Point(617, 183);
            this.rjtxbQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.rjtxbQuantity.Multiline = false;
            this.rjtxbQuantity.Name = "rjtxbQuantity";
            this.rjtxbQuantity.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjtxbQuantity.PasswordChar = false;
            this.rjtxbQuantity.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjtxbQuantity.PlaceholderText = "";
            this.rjtxbQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.rjtxbQuantity.Size = new System.Drawing.Size(275, 31);
            this.rjtxbQuantity.TabIndex = 10;
            this.rjtxbQuantity.Texts = "";
            this.rjtxbQuantity.UnderlinedStyle = false;
            // 
            // rjtxbPrice
            // 
            this.rjtxbPrice.BackColor = System.Drawing.SystemColors.Window;
            this.rjtxbPrice.BorderColor = System.Drawing.Color.Black;
            this.rjtxbPrice.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.rjtxbPrice.BorderRadius = 10;
            this.rjtxbPrice.BorderSize = 1;
            this.rjtxbPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rjtxbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjtxbPrice.ForeColor = System.Drawing.Color.Black;
            this.rjtxbPrice.Location = new System.Drawing.Point(617, 114);
            this.rjtxbPrice.Margin = new System.Windows.Forms.Padding(4);
            this.rjtxbPrice.Multiline = false;
            this.rjtxbPrice.Name = "rjtxbPrice";
            this.rjtxbPrice.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjtxbPrice.PasswordChar = false;
            this.rjtxbPrice.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjtxbPrice.PlaceholderText = "";
            this.rjtxbPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.rjtxbPrice.Size = new System.Drawing.Size(275, 31);
            this.rjtxbPrice.TabIndex = 11;
            this.rjtxbPrice.Texts = "";
            this.rjtxbPrice.UnderlinedStyle = false;
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
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(772, 259);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 32);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // rjDropdownMenu1
            // 
            this.rjDropdownMenu1.IsMainMenu = false;
            this.rjDropdownMenu1.MenuItemHeight = 25;
            this.rjDropdownMenu1.MenuItemTextColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu1.Name = "rjDropdownMenu1";
            this.rjDropdownMenu1.PrimaryColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu1.Size = new System.Drawing.Size(61, 4);
            // 
            // rjDateTimePicker1
            // 
            this.rjDateTimePicker1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjDateTimePicker1.BorderSize = 0;
            this.rjDateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjDateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.rjDateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.rjDateTimePicker1.Location = new System.Drawing.Point(617, 47);
            this.rjDateTimePicker1.MinimumSize = new System.Drawing.Size(0, 35);
            this.rjDateTimePicker1.Name = "rjDateTimePicker1";
            this.rjDateTimePicker1.Size = new System.Drawing.Size(275, 35);
            this.rjDateTimePicker1.SkinColor = System.Drawing.Color.Black;
            this.rjDateTimePicker1.TabIndex = 15;
            this.rjDateTimePicker1.TextColor = System.Drawing.Color.White;
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
            this.rjbtnExit.Location = new System.Drawing.Point(950, 6);
            this.rjbtnExit.Name = "rjbtnExit";
            this.rjbtnExit.Size = new System.Drawing.Size(20, 20);
            this.rjbtnExit.TabIndex = 2;
            this.rjbtnExit.Text = "rjGoodShapeBtn1";
            this.rjbtnExit.TextColor = System.Drawing.Color.White;
            this.rjbtnExit.UseVisualStyleBackColor = false;
            this.rjbtnExit.Click += new System.EventHandler(this.rjbtnExit_Click);
            // 
            // ViewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(994, 525);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.dtgvInfo);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.rjtxbBName);
            this.Controls.Add(this.lblBName);
            this.Controls.Add(this.pnlTitle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewBook";
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
        private System.Windows.Forms.PictureBox picbTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblBName;
        private ToggleButton.RJControls.RJTextBoxBorderCus rjtxbBName;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dtgvInfo;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPurchaseDate;
        private System.Windows.Forms.Label lblPublication;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblBook;
        private ToggleButton.RJControls.RJTextBoxBorderCus rjtxbPrice;
        private ToggleButton.RJControls.RJTextBoxBorderCus rjtxbQuantity;
        private ToggleButton.RJControls.RJTextBoxBorderCus rjtxbAuthor;
        private ToggleButton.RJControls.RJTextBoxBorderCus rjtxbPublication;
        private ToggleButton.RJControls.RJTextBoxBorderCus rjtxbBook;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private ToggleButton.RJControls.RJDateTimePicker rjDateTimePicker1;
        private ToggleButton.RJControls.RJDropdownMenu rjDropdownMenu1;
        private ToggleButton.RJControls.RJGoodShapeBtn rjbtnExit;
    }
}