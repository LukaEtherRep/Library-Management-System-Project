namespace LibManageSys.Forms
{
    partial class AddStudent
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
            this.pnlHead = new System.Windows.Forms.Panel();
            this.rjbtnExit = new ToggleButton.RJControls.RJGoodShapeBtn();
            this.lblAddStudent = new System.Windows.Forms.Label();
            this.picbStudent = new System.Windows.Forms.PictureBox();
            this.pnlBottem = new System.Windows.Forms.Panel();
            this.btnClear = new ToggleButton.RJControls.RJGoodShapeBtn();
            this.btnSave = new ToggleButton.RJControls.RJGoodShapeBtn();
            this.txbSemester = new ToggleButton.RJControls.RJTextBoxBorderCus();
            this.txbEmail = new ToggleButton.RJControls.RJTextBoxBorderCus();
            this.txbDepartment = new ToggleButton.RJControls.RJTextBoxBorderCus();
            this.txbEnroll = new ToggleButton.RJControls.RJTextBoxBorderCus();
            this.txbName = new ToggleButton.RJControls.RJTextBoxBorderCus();
            this.txbPhone = new ToggleButton.RJControls.RJTextBoxBorderCus();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblSemester = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEnroll = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.picbGif = new System.Windows.Forms.PictureBox();
            this.pnlHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbStudent)).BeginInit();
            this.pnlBottem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbGif)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHead
            // 
            this.pnlHead.BackColor = System.Drawing.Color.MediumAquamarine;
            this.pnlHead.Controls.Add(this.rjbtnExit);
            this.pnlHead.Controls.Add(this.lblAddStudent);
            this.pnlHead.Controls.Add(this.picbStudent);
            this.pnlHead.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHead.Location = new System.Drawing.Point(0, 0);
            this.pnlHead.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHead.Name = "pnlHead";
            this.pnlHead.Size = new System.Drawing.Size(684, 77);
            this.pnlHead.TabIndex = 2;
            this.pnlHead.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHead_MouseDown);
            // 
            // rjbtnExit
            // 
            this.rjbtnExit.BackColor = System.Drawing.Color.MediumAquamarine;
            this.rjbtnExit.BackgroundColor = System.Drawing.Color.MediumAquamarine;
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
            // lblAddStudent
            // 
            this.lblAddStudent.AutoSize = true;
            this.lblAddStudent.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddStudent.ForeColor = System.Drawing.Color.Black;
            this.lblAddStudent.Location = new System.Drawing.Point(318, 26);
            this.lblAddStudent.Margin = new System.Windows.Forms.Padding(0);
            this.lblAddStudent.Name = "lblAddStudent";
            this.lblAddStudent.Size = new System.Drawing.Size(176, 24);
            this.lblAddStudent.TabIndex = 1;
            this.lblAddStudent.Text = "Thêm Sinh Viên";
            this.lblAddStudent.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHead_MouseDown);
            // 
            // picbStudent
            // 
            this.picbStudent.Image = global::LibManageSys.Properties.Resources.icons8_student_male_1000;
            this.picbStudent.Location = new System.Drawing.Point(241, 0);
            this.picbStudent.Margin = new System.Windows.Forms.Padding(0);
            this.picbStudent.Name = "picbStudent";
            this.picbStudent.Size = new System.Drawing.Size(77, 77);
            this.picbStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbStudent.TabIndex = 0;
            this.picbStudent.TabStop = false;
            this.picbStudent.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHead_MouseDown);
            // 
            // pnlBottem
            // 
            this.pnlBottem.BackColor = System.Drawing.Color.Turquoise;
            this.pnlBottem.Controls.Add(this.btnClear);
            this.pnlBottem.Controls.Add(this.btnSave);
            this.pnlBottem.Controls.Add(this.txbSemester);
            this.pnlBottem.Controls.Add(this.txbEmail);
            this.pnlBottem.Controls.Add(this.txbDepartment);
            this.pnlBottem.Controls.Add(this.txbEnroll);
            this.pnlBottem.Controls.Add(this.txbName);
            this.pnlBottem.Controls.Add(this.txbPhone);
            this.pnlBottem.Controls.Add(this.lblEmail);
            this.pnlBottem.Controls.Add(this.lblPhone);
            this.pnlBottem.Controls.Add(this.lblSemester);
            this.pnlBottem.Controls.Add(this.lblName);
            this.pnlBottem.Controls.Add(this.lblEnroll);
            this.pnlBottem.Controls.Add(this.lblDepartment);
            this.pnlBottem.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBottem.Location = new System.Drawing.Point(275, 77);
            this.pnlBottem.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBottem.Name = "pnlBottem";
            this.pnlBottem.Size = new System.Drawing.Size(409, 351);
            this.pnlBottem.TabIndex = 4;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Turquoise;
            this.btnClear.BackgroundColor = System.Drawing.Color.Turquoise;
            this.btnClear.BorderColor = System.Drawing.Color.Cyan;
            this.btnClear.BorderRadius = 10;
            this.btnClear.BorderSize = 2;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(279, 309);
            this.btnClear.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 30);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Xóa";
            this.btnClear.TextColor = System.Drawing.Color.Black;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Turquoise;
            this.btnSave.BackgroundColor = System.Drawing.Color.Turquoise;
            this.btnSave.BorderColor = System.Drawing.Color.Cyan;
            this.btnSave.BorderRadius = 10;
            this.btnSave.BorderSize = 2;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(171, 309);
            this.btnSave.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 30);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextColor = System.Drawing.Color.Black;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txbSemester
            // 
            this.txbSemester.BackColor = System.Drawing.Color.Bisque;
            this.txbSemester.BorderColor = System.Drawing.Color.Black;
            this.txbSemester.BorderFocusColor = System.Drawing.Color.Crimson;
            this.txbSemester.BorderRadius = 0;
            this.txbSemester.BorderSize = 2;
            this.txbSemester.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSemester.ForeColor = System.Drawing.Color.Black;
            this.txbSemester.Location = new System.Drawing.Point(142, 169);
            this.txbSemester.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.txbSemester.Multiline = false;
            this.txbSemester.Name = "txbSemester";
            this.txbSemester.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbSemester.PasswordChar = false;
            this.txbSemester.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbSemester.PlaceholderText = "";
            this.txbSemester.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbSemester.Size = new System.Drawing.Size(250, 31);
            this.txbSemester.TabIndex = 15;
            this.txbSemester.Texts = "";
            this.txbSemester.UnderlinedStyle = true;
            this.txbSemester._TextChanged += new System.EventHandler(this.txbID__TextChanged);
            // 
            // txbEmail
            // 
            this.txbEmail.BackColor = System.Drawing.Color.Bisque;
            this.txbEmail.BorderColor = System.Drawing.Color.Black;
            this.txbEmail.BorderFocusColor = System.Drawing.Color.Crimson;
            this.txbEmail.BorderRadius = 0;
            this.txbEmail.BorderSize = 2;
            this.txbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmail.ForeColor = System.Drawing.Color.Black;
            this.txbEmail.Location = new System.Drawing.Point(142, 267);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.txbEmail.Multiline = false;
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbEmail.PasswordChar = false;
            this.txbEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbEmail.PlaceholderText = "";
            this.txbEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbEmail.Size = new System.Drawing.Size(250, 31);
            this.txbEmail.TabIndex = 11;
            this.txbEmail.Texts = "";
            this.txbEmail.UnderlinedStyle = true;
            // 
            // txbDepartment
            // 
            this.txbDepartment.BackColor = System.Drawing.Color.Bisque;
            this.txbDepartment.BorderColor = System.Drawing.Color.Black;
            this.txbDepartment.BorderFocusColor = System.Drawing.Color.Crimson;
            this.txbDepartment.BorderRadius = 0;
            this.txbDepartment.BorderSize = 2;
            this.txbDepartment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDepartment.ForeColor = System.Drawing.Color.Black;
            this.txbDepartment.Location = new System.Drawing.Point(142, 120);
            this.txbDepartment.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.txbDepartment.Multiline = false;
            this.txbDepartment.Name = "txbDepartment";
            this.txbDepartment.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbDepartment.PasswordChar = false;
            this.txbDepartment.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbDepartment.PlaceholderText = "";
            this.txbDepartment.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbDepartment.Size = new System.Drawing.Size(250, 31);
            this.txbDepartment.TabIndex = 10;
            this.txbDepartment.Texts = "";
            this.txbDepartment.UnderlinedStyle = true;
            // 
            // txbEnroll
            // 
            this.txbEnroll.BackColor = System.Drawing.Color.Bisque;
            this.txbEnroll.BorderColor = System.Drawing.Color.Black;
            this.txbEnroll.BorderFocusColor = System.Drawing.Color.Crimson;
            this.txbEnroll.BorderRadius = 0;
            this.txbEnroll.BorderSize = 2;
            this.txbEnroll.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbEnroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEnroll.ForeColor = System.Drawing.Color.Black;
            this.txbEnroll.Location = new System.Drawing.Point(142, 71);
            this.txbEnroll.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.txbEnroll.Multiline = false;
            this.txbEnroll.Name = "txbEnroll";
            this.txbEnroll.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbEnroll.PasswordChar = false;
            this.txbEnroll.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbEnroll.PlaceholderText = "";
            this.txbEnroll.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbEnroll.Size = new System.Drawing.Size(250, 31);
            this.txbEnroll.TabIndex = 9;
            this.txbEnroll.Texts = "";
            this.txbEnroll.UnderlinedStyle = true;
            // 
            // txbName
            // 
            this.txbName.BackColor = System.Drawing.Color.Bisque;
            this.txbName.BorderColor = System.Drawing.Color.Black;
            this.txbName.BorderFocusColor = System.Drawing.Color.Crimson;
            this.txbName.BorderRadius = 0;
            this.txbName.BorderSize = 2;
            this.txbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.ForeColor = System.Drawing.Color.Black;
            this.txbName.Location = new System.Drawing.Point(142, 22);
            this.txbName.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.txbName.Multiline = false;
            this.txbName.Name = "txbName";
            this.txbName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbName.PasswordChar = false;
            this.txbName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbName.PlaceholderText = "";
            this.txbName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbName.Size = new System.Drawing.Size(250, 31);
            this.txbName.TabIndex = 8;
            this.txbName.Texts = "";
            this.txbName.UnderlinedStyle = true;
            // 
            // txbPhone
            // 
            this.txbPhone.BackColor = System.Drawing.Color.Bisque;
            this.txbPhone.BorderColor = System.Drawing.Color.Black;
            this.txbPhone.BorderFocusColor = System.Drawing.Color.Crimson;
            this.txbPhone.BorderRadius = 0;
            this.txbPhone.BorderSize = 2;
            this.txbPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPhone.ForeColor = System.Drawing.Color.Black;
            this.txbPhone.Location = new System.Drawing.Point(142, 218);
            this.txbPhone.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.txbPhone.Multiline = false;
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbPhone.PasswordChar = false;
            this.txbPhone.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbPhone.PlaceholderText = "";
            this.txbPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbPhone.Size = new System.Drawing.Size(250, 31);
            this.txbPhone.TabIndex = 6;
            this.txbPhone.Texts = "";
            this.txbPhone.UnderlinedStyle = true;
            this.txbPhone._TextChanged += new System.EventHandler(this.txbID__TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(15, 274);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(15, 0, 0, 30);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 19);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.Black;
            this.lblPhone.Location = new System.Drawing.Point(15, 225);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(15, 0, 0, 30);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(109, 19);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Số Điện Thoại";
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemester.ForeColor = System.Drawing.Color.Black;
            this.lblSemester.Location = new System.Drawing.Point(15, 176);
            this.lblSemester.Margin = new System.Windows.Forms.Padding(15, 0, 0, 30);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(44, 19);
            this.lblSemester.TabIndex = 3;
            this.lblSemester.Text = "Năm";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(15, 29);
            this.lblName.Margin = new System.Windows.Forms.Padding(15, 0, 0, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(104, 19);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Tên Sinh Viên";
            // 
            // lblEnroll
            // 
            this.lblEnroll.AutoSize = true;
            this.lblEnroll.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnroll.ForeColor = System.Drawing.Color.Black;
            this.lblEnroll.Location = new System.Drawing.Point(15, 78);
            this.lblEnroll.Margin = new System.Windows.Forms.Padding(15, 0, 0, 30);
            this.lblEnroll.Name = "lblEnroll";
            this.lblEnroll.Size = new System.Drawing.Size(100, 19);
            this.lblEnroll.TabIndex = 1;
            this.lblEnroll.Text = "Mã Ghi Danh";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.ForeColor = System.Drawing.Color.Black;
            this.lblDepartment.Location = new System.Drawing.Point(15, 127);
            this.lblDepartment.Margin = new System.Windows.Forms.Padding(15, 0, 0, 30);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(45, 19);
            this.lblDepartment.TabIndex = 0;
            this.lblDepartment.Text = "Khoa";
            // 
            // picbGif
            // 
            this.picbGif.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.picbGif.Image = global::LibManageSys.Properties.Resources.addstudent;
            this.picbGif.Location = new System.Drawing.Point(0, 77);
            this.picbGif.Margin = new System.Windows.Forms.Padding(0);
            this.picbGif.Name = "picbGif";
            this.picbGif.Size = new System.Drawing.Size(275, 351);
            this.picbGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbGif.TabIndex = 3;
            this.picbGif.TabStop = false;
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 428);
            this.Controls.Add(this.pnlBottem);
            this.Controls.Add(this.picbGif);
            this.Controls.Add(this.pnlHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddStudent";
            this.pnlHead.ResumeLayout(false);
            this.pnlHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbStudent)).EndInit();
            this.pnlBottem.ResumeLayout(false);
            this.pnlBottem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbGif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHead;
        private ToggleButton.RJControls.RJGoodShapeBtn rjbtnExit;
        private System.Windows.Forms.Label lblAddStudent;
        private System.Windows.Forms.PictureBox picbStudent;
        private System.Windows.Forms.PictureBox picbGif;
        private System.Windows.Forms.Panel pnlBottem;
        private ToggleButton.RJControls.RJTextBoxBorderCus txbEmail;
        private ToggleButton.RJControls.RJTextBoxBorderCus txbDepartment;
        private ToggleButton.RJControls.RJTextBoxBorderCus txbEnroll;
        private ToggleButton.RJControls.RJTextBoxBorderCus txbName;
        private ToggleButton.RJControls.RJTextBoxBorderCus txbPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEnroll;
        private System.Windows.Forms.Label lblDepartment;
        private ToggleButton.RJControls.RJTextBoxBorderCus txbSemester;
        private ToggleButton.RJControls.RJGoodShapeBtn btnSave;
        private ToggleButton.RJControls.RJGoodShapeBtn btnClear;
    }
}