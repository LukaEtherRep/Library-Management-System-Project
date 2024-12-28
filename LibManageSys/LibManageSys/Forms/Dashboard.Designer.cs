namespace LibManageSys
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.rjbtnExit = new ToggleButton.RJControls.RJGoodShapeBtn();
            this.rjbtnFinish = new ToggleButton.RJControls.RJGoodShapeBtn();
            this.rjbtnReturn = new ToggleButton.RJControls.RJGoodShapeBtn();
            this.rjbtnIssue = new ToggleButton.RJControls.RJGoodShapeBtn();
            this.rjbtnStudent = new ToggleButton.RJControls.RJGoodShapeBtn();
            this.rjbtnBook = new ToggleButton.RJControls.RJGoodShapeBtn();
            this.rjddmnBook = new ToggleButton.RJControls.RJDropdownMenu(this.components);
            this.rjtsmiAddNewBook = new System.Windows.Forms.ToolStripMenuItem();
            this.rjtsmiViewBook = new System.Windows.Forms.ToolStripMenuItem();
            this.rjddmnStudent = new ToggleButton.RJControls.RJDropdownMenu(this.components);
            this.tsmiAddStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiViewStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTop.SuspendLayout();
            this.rjddmnBook.SuspendLayout();
            this.rjddmnStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Wheat;
            this.pnlTop.Controls.Add(this.rjbtnExit);
            this.pnlTop.Controls.Add(this.rjbtnFinish);
            this.pnlTop.Controls.Add(this.rjbtnReturn);
            this.pnlTop.Controls.Add(this.rjbtnIssue);
            this.pnlTop.Controls.Add(this.rjbtnStudent);
            this.pnlTop.Controls.Add(this.rjbtnBook);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1084, 60);
            this.pnlTop.TabIndex = 0;
            // 
            // rjbtnExit
            // 
            this.rjbtnExit.BackColor = System.Drawing.Color.Wheat;
            this.rjbtnExit.BackgroundColor = System.Drawing.Color.Wheat;
            this.rjbtnExit.BorderColor = System.Drawing.Color.Red;
            this.rjbtnExit.BorderRadius = 0;
            this.rjbtnExit.BorderSize = 0;
            this.rjbtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjbtnExit.Dock = System.Windows.Forms.DockStyle.Left;
            this.rjbtnExit.FlatAppearance.BorderSize = 0;
            this.rjbtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjbtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjbtnExit.ForeColor = System.Drawing.Color.Black;
            this.rjbtnExit.Image = global::LibManageSys.Properties.Resources.icons8_exit_sign_50;
            this.rjbtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjbtnExit.Location = new System.Drawing.Point(750, 0);
            this.rjbtnExit.Name = "rjbtnExit";
            this.rjbtnExit.Size = new System.Drawing.Size(110, 60);
            this.rjbtnExit.TabIndex = 5;
            this.rjbtnExit.Text = "Thoát";
            this.rjbtnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjbtnExit.TextColor = System.Drawing.Color.Black;
            this.rjbtnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rjbtnExit.UseVisualStyleBackColor = false;
            this.rjbtnExit.Click += new System.EventHandler(this.rjbtnExit_Click);
            // 
            // rjbtnFinish
            // 
            this.rjbtnFinish.BackColor = System.Drawing.Color.Wheat;
            this.rjbtnFinish.BackgroundColor = System.Drawing.Color.Wheat;
            this.rjbtnFinish.BorderColor = System.Drawing.Color.Orange;
            this.rjbtnFinish.BorderRadius = 0;
            this.rjbtnFinish.BorderSize = 0;
            this.rjbtnFinish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjbtnFinish.Dock = System.Windows.Forms.DockStyle.Left;
            this.rjbtnFinish.FlatAppearance.BorderSize = 0;
            this.rjbtnFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjbtnFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjbtnFinish.ForeColor = System.Drawing.Color.Black;
            this.rjbtnFinish.Image = global::LibManageSys.Properties.Resources.icons8_books_50;
            this.rjbtnFinish.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjbtnFinish.Location = new System.Drawing.Point(510, 0);
            this.rjbtnFinish.Name = "rjbtnFinish";
            this.rjbtnFinish.Size = new System.Drawing.Size(240, 60);
            this.rjbtnFinish.TabIndex = 4;
            this.rjbtnFinish.Text = "Kiểm Tra Mượn Trả Sách";
            this.rjbtnFinish.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjbtnFinish.TextColor = System.Drawing.Color.Black;
            this.rjbtnFinish.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rjbtnFinish.UseVisualStyleBackColor = false;
            this.rjbtnFinish.Click += new System.EventHandler(this.rjbtnFinish_Click);
            // 
            // rjbtnReturn
            // 
            this.rjbtnReturn.BackColor = System.Drawing.Color.Wheat;
            this.rjbtnReturn.BackgroundColor = System.Drawing.Color.Wheat;
            this.rjbtnReturn.BorderColor = System.Drawing.Color.Yellow;
            this.rjbtnReturn.BorderRadius = 0;
            this.rjbtnReturn.BorderSize = 0;
            this.rjbtnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjbtnReturn.Dock = System.Windows.Forms.DockStyle.Left;
            this.rjbtnReturn.FlatAppearance.BorderSize = 0;
            this.rjbtnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjbtnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjbtnReturn.ForeColor = System.Drawing.Color.Black;
            this.rjbtnReturn.Image = global::LibManageSys.Properties.Resources.icons8_return_book_50;
            this.rjbtnReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjbtnReturn.Location = new System.Drawing.Point(380, 0);
            this.rjbtnReturn.Name = "rjbtnReturn";
            this.rjbtnReturn.Size = new System.Drawing.Size(130, 60);
            this.rjbtnReturn.TabIndex = 3;
            this.rjbtnReturn.Text = "Trả Sách";
            this.rjbtnReturn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjbtnReturn.TextColor = System.Drawing.Color.Black;
            this.rjbtnReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rjbtnReturn.UseVisualStyleBackColor = false;
            this.rjbtnReturn.Click += new System.EventHandler(this.rjbtnReturn_Click);
            // 
            // rjbtnIssue
            // 
            this.rjbtnIssue.BackColor = System.Drawing.Color.Wheat;
            this.rjbtnIssue.BackgroundColor = System.Drawing.Color.Wheat;
            this.rjbtnIssue.BorderColor = System.Drawing.Color.Green;
            this.rjbtnIssue.BorderRadius = 0;
            this.rjbtnIssue.BorderSize = 0;
            this.rjbtnIssue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjbtnIssue.Dock = System.Windows.Forms.DockStyle.Left;
            this.rjbtnIssue.FlatAppearance.BorderSize = 0;
            this.rjbtnIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjbtnIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjbtnIssue.ForeColor = System.Drawing.Color.Black;
            this.rjbtnIssue.Image = global::LibManageSys.Properties.Resources.icons8_book_philosophy_50;
            this.rjbtnIssue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjbtnIssue.Location = new System.Drawing.Point(240, 0);
            this.rjbtnIssue.Name = "rjbtnIssue";
            this.rjbtnIssue.Size = new System.Drawing.Size(140, 60);
            this.rjbtnIssue.TabIndex = 2;
            this.rjbtnIssue.Text = "Mượn Sách";
            this.rjbtnIssue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjbtnIssue.TextColor = System.Drawing.Color.Black;
            this.rjbtnIssue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rjbtnIssue.UseVisualStyleBackColor = false;
            this.rjbtnIssue.Click += new System.EventHandler(this.rjbtnIssue_Click);
            // 
            // rjbtnStudent
            // 
            this.rjbtnStudent.BackColor = System.Drawing.Color.Wheat;
            this.rjbtnStudent.BackgroundColor = System.Drawing.Color.Wheat;
            this.rjbtnStudent.BorderColor = System.Drawing.Color.Blue;
            this.rjbtnStudent.BorderRadius = 0;
            this.rjbtnStudent.BorderSize = 0;
            this.rjbtnStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjbtnStudent.Dock = System.Windows.Forms.DockStyle.Left;
            this.rjbtnStudent.FlatAppearance.BorderSize = 0;
            this.rjbtnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjbtnStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjbtnStudent.ForeColor = System.Drawing.Color.Black;
            this.rjbtnStudent.Image = global::LibManageSys.Properties.Resources.icons8_student_male_50;
            this.rjbtnStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjbtnStudent.Location = new System.Drawing.Point(110, 0);
            this.rjbtnStudent.Name = "rjbtnStudent";
            this.rjbtnStudent.Size = new System.Drawing.Size(130, 60);
            this.rjbtnStudent.TabIndex = 1;
            this.rjbtnStudent.Text = "Sinh Viên";
            this.rjbtnStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjbtnStudent.TextColor = System.Drawing.Color.Black;
            this.rjbtnStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rjbtnStudent.UseVisualStyleBackColor = false;
            this.rjbtnStudent.Click += new System.EventHandler(this.rjbtnStudent_Click);
            // 
            // rjbtnBook
            // 
            this.rjbtnBook.BackColor = System.Drawing.Color.Wheat;
            this.rjbtnBook.BackgroundColor = System.Drawing.Color.Wheat;
            this.rjbtnBook.BorderColor = System.Drawing.Color.Fuchsia;
            this.rjbtnBook.BorderRadius = 0;
            this.rjbtnBook.BorderSize = 0;
            this.rjbtnBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjbtnBook.Dock = System.Windows.Forms.DockStyle.Left;
            this.rjbtnBook.FlatAppearance.BorderSize = 0;
            this.rjbtnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjbtnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjbtnBook.ForeColor = System.Drawing.Color.Black;
            this.rjbtnBook.Image = global::LibManageSys.Properties.Resources.icons8_books_50;
            this.rjbtnBook.Location = new System.Drawing.Point(0, 0);
            this.rjbtnBook.Name = "rjbtnBook";
            this.rjbtnBook.Size = new System.Drawing.Size(110, 60);
            this.rjbtnBook.TabIndex = 0;
            this.rjbtnBook.Text = "Sách";
            this.rjbtnBook.TextColor = System.Drawing.Color.Black;
            this.rjbtnBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rjbtnBook.UseVisualStyleBackColor = false;
            this.rjbtnBook.Click += new System.EventHandler(this.rjbtnBook_Click);
            // 
            // rjddmnBook
            // 
            this.rjddmnBook.IsMainMenu = false;
            this.rjddmnBook.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rjtsmiAddNewBook,
            this.rjtsmiViewBook});
            this.rjddmnBook.MenuItemHeight = 25;
            this.rjddmnBook.MenuItemTextColor = System.Drawing.Color.Empty;
            this.rjddmnBook.Name = "rjddmnBook";
            this.rjddmnBook.PrimaryColor = System.Drawing.Color.Empty;
            this.rjddmnBook.Size = new System.Drawing.Size(191, 116);
            // 
            // rjtsmiAddNewBook
            // 
            this.rjtsmiAddNewBook.ForeColor = System.Drawing.Color.Black;
            this.rjtsmiAddNewBook.Image = global::LibManageSys.Properties.Resources.icons8_add_book_48;
            this.rjtsmiAddNewBook.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.rjtsmiAddNewBook.Name = "rjtsmiAddNewBook";
            this.rjtsmiAddNewBook.Size = new System.Drawing.Size(190, 56);
            this.rjtsmiAddNewBook.Text = "Thêm sách mới";
            this.rjtsmiAddNewBook.Click += new System.EventHandler(this.rjtsmiAddNewBook_Click);
            // 
            // rjtsmiViewBook
            // 
            this.rjtsmiViewBook.ForeColor = System.Drawing.Color.Black;
            this.rjtsmiViewBook.Image = global::LibManageSys.Properties.Resources.icons8_view_50;
            this.rjtsmiViewBook.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.rjtsmiViewBook.Name = "rjtsmiViewBook";
            this.rjtsmiViewBook.Size = new System.Drawing.Size(190, 56);
            this.rjtsmiViewBook.Text = "Xem sách";
            this.rjtsmiViewBook.Click += new System.EventHandler(this.rjtsmiViewBook_Click);
            // 
            // rjddmnStudent
            // 
            this.rjddmnStudent.IsMainMenu = false;
            this.rjddmnStudent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddStudent,
            this.tsmiViewStudent});
            this.rjddmnStudent.MenuItemHeight = 25;
            this.rjddmnStudent.MenuItemTextColor = System.Drawing.Color.Empty;
            this.rjddmnStudent.Name = "rjddmnBook";
            this.rjddmnStudent.PrimaryColor = System.Drawing.Color.Empty;
            this.rjddmnStudent.Size = new System.Drawing.Size(190, 116);
            // 
            // tsmiAddStudent
            // 
            this.tsmiAddStudent.Image = global::LibManageSys.Properties.Resources.icons8_add_user_male_50;
            this.tsmiAddStudent.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiAddStudent.Name = "tsmiAddStudent";
            this.tsmiAddStudent.Size = new System.Drawing.Size(189, 56);
            this.tsmiAddStudent.Text = "Thêm sinh viên";
            this.tsmiAddStudent.Click += new System.EventHandler(this.tsmiAddStudent_Click);
            // 
            // tsmiViewStudent
            // 
            this.tsmiViewStudent.Image = global::LibManageSys.Properties.Resources.icons8_view_50;
            this.tsmiViewStudent.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiViewStudent.Name = "tsmiViewStudent";
            this.tsmiViewStudent.Size = new System.Drawing.Size(189, 56);
            this.tsmiViewStudent.Text = "Xem sinh viên";
            this.tsmiViewStudent.Click += new System.EventHandler(this.tsmiViewStudent_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1084, 450);
            this.Controls.Add(this.pnlTop);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlTop.ResumeLayout(false);
            this.rjddmnBook.ResumeLayout(false);
            this.rjddmnStudent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private ToggleButton.RJControls.RJGoodShapeBtn rjbtnBook;
        private ToggleButton.RJControls.RJGoodShapeBtn rjbtnStudent;
        private ToggleButton.RJControls.RJGoodShapeBtn rjbtnReturn;
        private ToggleButton.RJControls.RJGoodShapeBtn rjbtnIssue;
        private ToggleButton.RJControls.RJGoodShapeBtn rjbtnFinish;
        private ToggleButton.RJControls.RJGoodShapeBtn rjbtnExit;
        private ToggleButton.RJControls.RJDropdownMenu rjddmnBook;
        private System.Windows.Forms.ToolStripMenuItem rjtsmiAddNewBook;
        private System.Windows.Forms.ToolStripMenuItem rjtsmiViewBook;
        private ToggleButton.RJControls.RJDropdownMenu rjddmnStudent;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddStudent;
        private System.Windows.Forms.ToolStripMenuItem tsmiViewStudent;
    }
}