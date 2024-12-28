namespace LibManageSys.Forms
{
    partial class ReturnBook
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
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.dtgvInfo = new System.Windows.Forms.DataGridView();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.pnlDivider = new System.Windows.Forms.Panel();
            this.lblFoundStudent = new System.Windows.Forms.Label();
            this.rjbtnExit = new ToggleButton.RJControls.RJGoodShapeBtn();
            this.rjbtnRefresh = new ToggleButton.RJControls.RJGoodShapeBtn();
            this.rjtxbSearchEnroll = new ToggleButton.RJControls.RJTextBoxBorderCus();
            this.rjbtnSearchEnroll = new ToggleButton.RJControls.RJGoodShapeBtn();
            this.lblSearchEnroll = new System.Windows.Forms.Label();
            this.rjpicbSearchStudent = new ToggleButton.RJControls.RJCircularPicB();
            this.rjtxbIssueDate = new ToggleButton.RJControls.RJTextBoxBorderCus();
            this.rjtxbBName = new ToggleButton.RJControls.RJTextBoxBorderCus();
            this.lblDepart = new System.Windows.Forms.Label();
            this.lblEnroll = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnComfirm = new System.Windows.Forms.Button();
            this.rjdtpkReturnDate = new ToggleButton.RJControls.RJDateTimePicker();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInfo)).BeginInit();
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjpicbSearchStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlSearch.Controls.Add(this.pnlDivider);
            this.pnlSearch.Controls.Add(this.lblFoundStudent);
            this.pnlSearch.Controls.Add(this.rjbtnExit);
            this.pnlSearch.Controls.Add(this.rjbtnRefresh);
            this.pnlSearch.Controls.Add(this.rjtxbSearchEnroll);
            this.pnlSearch.Controls.Add(this.rjbtnSearchEnroll);
            this.pnlSearch.Controls.Add(this.lblSearchEnroll);
            this.pnlSearch.Controls.Add(this.rjpicbSearchStudent);
            this.pnlSearch.Location = new System.Drawing.Point(12, 12);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(259, 368);
            this.pnlSearch.TabIndex = 0;
            // 
            // dtgvInfo
            // 
            this.dtgvInfo.AllowUserToAddRows = false;
            this.dtgvInfo.AllowUserToDeleteRows = false;
            this.dtgvInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvInfo.Location = new System.Drawing.Point(277, 12);
            this.dtgvInfo.Name = "dtgvInfo";
            this.dtgvInfo.Size = new System.Drawing.Size(719, 368);
            this.dtgvInfo.TabIndex = 1;
            this.dtgvInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvInfo_CellClick);
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlInfo.Controls.Add(this.rjdtpkReturnDate);
            this.pnlInfo.Controls.Add(this.btnCancel);
            this.pnlInfo.Controls.Add(this.btnComfirm);
            this.pnlInfo.Controls.Add(this.rjtxbIssueDate);
            this.pnlInfo.Controls.Add(this.rjtxbBName);
            this.pnlInfo.Controls.Add(this.lblDepart);
            this.pnlInfo.Controls.Add(this.lblEnroll);
            this.pnlInfo.Controls.Add(this.lblName);
            this.pnlInfo.Location = new System.Drawing.Point(277, 386);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(719, 141);
            this.pnlInfo.TabIndex = 2;
            // 
            // pnlDivider
            // 
            this.pnlDivider.BackColor = System.Drawing.Color.Black;
            this.pnlDivider.Location = new System.Drawing.Point(54, 140);
            this.pnlDivider.Name = "pnlDivider";
            this.pnlDivider.Size = new System.Drawing.Size(150, 1);
            this.pnlDivider.TabIndex = 15;
            // 
            // lblFoundStudent
            // 
            this.lblFoundStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoundStudent.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblFoundStudent.Location = new System.Drawing.Point(0, 112);
            this.lblFoundStudent.Margin = new System.Windows.Forms.Padding(0);
            this.lblFoundStudent.Name = "lblFoundStudent";
            this.lblFoundStudent.Size = new System.Drawing.Size(259, 23);
            this.lblFoundStudent.TabIndex = 14;
            this.lblFoundStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rjbtnExit
            // 
            this.rjbtnExit.BackColor = System.Drawing.Color.LightCoral;
            this.rjbtnExit.BackgroundColor = System.Drawing.Color.LightCoral;
            this.rjbtnExit.BorderColor = System.Drawing.Color.Gray;
            this.rjbtnExit.BorderRadius = 5;
            this.rjbtnExit.BorderSize = 2;
            this.rjbtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjbtnExit.FlatAppearance.BorderSize = 0;
            this.rjbtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjbtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjbtnExit.ForeColor = System.Drawing.Color.Black;
            this.rjbtnExit.Location = new System.Drawing.Point(147, 321);
            this.rjbtnExit.Name = "rjbtnExit";
            this.rjbtnExit.Size = new System.Drawing.Size(74, 24);
            this.rjbtnExit.TabIndex = 13;
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
            this.rjbtnRefresh.Location = new System.Drawing.Point(37, 321);
            this.rjbtnRefresh.Name = "rjbtnRefresh";
            this.rjbtnRefresh.Size = new System.Drawing.Size(74, 24);
            this.rjbtnRefresh.TabIndex = 12;
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
            this.rjtxbSearchEnroll.Location = new System.Drawing.Point(18, 197);
            this.rjtxbSearchEnroll.Margin = new System.Windows.Forms.Padding(4);
            this.rjtxbSearchEnroll.Multiline = false;
            this.rjtxbSearchEnroll.Name = "rjtxbSearchEnroll";
            this.rjtxbSearchEnroll.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjtxbSearchEnroll.PasswordChar = false;
            this.rjtxbSearchEnroll.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjtxbSearchEnroll.PlaceholderText = "";
            this.rjtxbSearchEnroll.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.rjtxbSearchEnroll.Size = new System.Drawing.Size(221, 31);
            this.rjtxbSearchEnroll.TabIndex = 11;
            this.rjtxbSearchEnroll.Texts = "";
            this.rjtxbSearchEnroll.UnderlinedStyle = false;
            this.rjtxbSearchEnroll._TextChanged += new System.EventHandler(this.rjtxbSearchEnroll__TextChanged);
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
            this.rjbtnSearchEnroll.Location = new System.Drawing.Point(54, 250);
            this.rjbtnSearchEnroll.Name = "rjbtnSearchEnroll";
            this.rjbtnSearchEnroll.Size = new System.Drawing.Size(150, 40);
            this.rjbtnSearchEnroll.TabIndex = 10;
            this.rjbtnSearchEnroll.Text = "Tìm Kiếm";
            this.rjbtnSearchEnroll.TextColor = System.Drawing.Color.Black;
            this.rjbtnSearchEnroll.UseVisualStyleBackColor = false;
            this.rjbtnSearchEnroll.Click += new System.EventHandler(this.rjbtnSearchEnroll_Click);
            // 
            // lblSearchEnroll
            // 
            this.lblSearchEnroll.AutoSize = true;
            this.lblSearchEnroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchEnroll.Location = new System.Drawing.Point(68, 166);
            this.lblSearchEnroll.Name = "lblSearchEnroll";
            this.lblSearchEnroll.Size = new System.Drawing.Size(123, 24);
            this.lblSearchEnroll.TabIndex = 9;
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
            this.rjpicbSearchStudent.Location = new System.Drawing.Point(84, 11);
            this.rjpicbSearchStudent.Name = "rjpicbSearchStudent";
            this.rjpicbSearchStudent.Size = new System.Drawing.Size(90, 90);
            this.rjpicbSearchStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjpicbSearchStudent.TabIndex = 8;
            this.rjpicbSearchStudent.TabStop = false;
            // 
            // rjtxbIssueDate
            // 
            this.rjtxbIssueDate.BackColor = System.Drawing.SystemColors.Window;
            this.rjtxbIssueDate.BorderColor = System.Drawing.Color.Black;
            this.rjtxbIssueDate.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.rjtxbIssueDate.BorderRadius = 10;
            this.rjtxbIssueDate.BorderSize = 1;
            this.rjtxbIssueDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rjtxbIssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjtxbIssueDate.ForeColor = System.Drawing.Color.Black;
            this.rjtxbIssueDate.Location = new System.Drawing.Point(218, 60);
            this.rjtxbIssueDate.Margin = new System.Windows.Forms.Padding(4);
            this.rjtxbIssueDate.Multiline = false;
            this.rjtxbIssueDate.Name = "rjtxbIssueDate";
            this.rjtxbIssueDate.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjtxbIssueDate.PasswordChar = false;
            this.rjtxbIssueDate.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjtxbIssueDate.PlaceholderText = "";
            this.rjtxbIssueDate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.rjtxbIssueDate.Size = new System.Drawing.Size(275, 30);
            this.rjtxbIssueDate.TabIndex = 14;
            this.rjtxbIssueDate.Texts = "";
            this.rjtxbIssueDate.UnderlinedStyle = false;
            // 
            // rjtxbBName
            // 
            this.rjtxbBName.BackColor = System.Drawing.SystemColors.Window;
            this.rjtxbBName.BorderColor = System.Drawing.Color.Black;
            this.rjtxbBName.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.rjtxbBName.BorderRadius = 10;
            this.rjtxbBName.BorderSize = 1;
            this.rjtxbBName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rjtxbBName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjtxbBName.ForeColor = System.Drawing.Color.Black;
            this.rjtxbBName.Location = new System.Drawing.Point(218, 18);
            this.rjtxbBName.Margin = new System.Windows.Forms.Padding(4);
            this.rjtxbBName.Multiline = false;
            this.rjtxbBName.Name = "rjtxbBName";
            this.rjtxbBName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjtxbBName.PasswordChar = false;
            this.rjtxbBName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjtxbBName.PlaceholderText = "";
            this.rjtxbBName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.rjtxbBName.Size = new System.Drawing.Size(275, 30);
            this.rjtxbBName.TabIndex = 12;
            this.rjtxbBName.Texts = "";
            this.rjtxbBName.UnderlinedStyle = false;
            // 
            // lblDepart
            // 
            this.lblDepart.AutoSize = true;
            this.lblDepart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDepart.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepart.Location = new System.Drawing.Point(76, 107);
            this.lblDepart.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.lblDepart.Name = "lblDepart";
            this.lblDepart.Size = new System.Drawing.Size(81, 22);
            this.lblDepart.TabIndex = 11;
            this.lblDepart.Text = "Ngày trả";
            this.lblDepart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEnroll
            // 
            this.lblEnroll.AutoSize = true;
            this.lblEnroll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblEnroll.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnroll.Location = new System.Drawing.Point(76, 65);
            this.lblEnroll.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.lblEnroll.Name = "lblEnroll";
            this.lblEnroll.Size = new System.Drawing.Size(104, 22);
            this.lblEnroll.TabIndex = 10;
            this.lblEnroll.Text = "Ngày mượn";
            this.lblEnroll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblName.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(72, 23);
            this.lblName.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(84, 22);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Tên sách";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(534, 106);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 27);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnComfirm
            // 
            this.btnComfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnComfirm.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComfirm.Location = new System.Drawing.Point(534, 60);
            this.btnComfirm.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.btnComfirm.Name = "btnComfirm";
            this.btnComfirm.Size = new System.Drawing.Size(94, 27);
            this.btnComfirm.TabIndex = 15;
            this.btnComfirm.Text = "Xác Nhận";
            this.btnComfirm.UseVisualStyleBackColor = true;
            this.btnComfirm.Click += new System.EventHandler(this.btnComfirm_Click);
            // 
            // rjdtpkReturnDate
            // 
            this.rjdtpkReturnDate.BorderColor = System.Drawing.Color.Black;
            this.rjdtpkReturnDate.BorderSize = 1;
            this.rjdtpkReturnDate.CustomFormat = "dd/MM/yyyy";
            this.rjdtpkReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjdtpkReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.rjdtpkReturnDate.Location = new System.Drawing.Point(218, 101);
            this.rjdtpkReturnDate.MinimumSize = new System.Drawing.Size(0, 35);
            this.rjdtpkReturnDate.Name = "rjdtpkReturnDate";
            this.rjdtpkReturnDate.Size = new System.Drawing.Size(275, 35);
            this.rjdtpkReturnDate.SkinColor = System.Drawing.Color.Cyan;
            this.rjdtpkReturnDate.TabIndex = 17;
            this.rjdtpkReturnDate.TextColor = System.Drawing.Color.Black;
            // 
            // ReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1024, 483);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.dtgvInfo);
            this.Controls.Add(this.pnlSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReturnBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReturnBook";
            this.Load += new System.EventHandler(this.ReturnBook_Load);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInfo)).EndInit();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjpicbSearchStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.DataGridView dtgvInfo;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Panel pnlDivider;
        private System.Windows.Forms.Label lblFoundStudent;
        private ToggleButton.RJControls.RJGoodShapeBtn rjbtnExit;
        private ToggleButton.RJControls.RJGoodShapeBtn rjbtnRefresh;
        private ToggleButton.RJControls.RJTextBoxBorderCus rjtxbSearchEnroll;
        private ToggleButton.RJControls.RJGoodShapeBtn rjbtnSearchEnroll;
        private System.Windows.Forms.Label lblSearchEnroll;
        private ToggleButton.RJControls.RJCircularPicB rjpicbSearchStudent;
        private ToggleButton.RJControls.RJTextBoxBorderCus rjtxbIssueDate;
        private ToggleButton.RJControls.RJTextBoxBorderCus rjtxbBName;
        private System.Windows.Forms.Label lblDepart;
        private System.Windows.Forms.Label lblEnroll;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnComfirm;
        private ToggleButton.RJControls.RJDateTimePicker rjdtpkReturnDate;
    }
}