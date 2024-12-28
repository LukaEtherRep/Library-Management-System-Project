namespace LibManageSys.Forms
{
    partial class CompleteBookDetails
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
            this.lblIssuedBooks = new System.Windows.Forms.Label();
            this.dtgvIssued = new System.Windows.Forms.DataGridView();
            this.lblReturnedBooks = new System.Windows.Forms.Label();
            this.dtgvReturned = new System.Windows.Forms.DataGridView();
            this.rjbtnExit = new ToggleButton.RJControls.RJGoodShapeBtn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvIssued)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReturned)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIssuedBooks
            // 
            this.lblIssuedBooks.AutoSize = true;
            this.lblIssuedBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssuedBooks.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblIssuedBooks.Location = new System.Drawing.Point(443, 19);
            this.lblIssuedBooks.Name = "lblIssuedBooks";
            this.lblIssuedBooks.Size = new System.Drawing.Size(191, 24);
            this.lblIssuedBooks.TabIndex = 0;
            this.lblIssuedBooks.Text = "Sách Đã Cho Mượn";
            this.lblIssuedBooks.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // dtgvIssued
            // 
            this.dtgvIssued.AllowUserToAddRows = false;
            this.dtgvIssued.AllowUserToDeleteRows = false;
            this.dtgvIssued.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvIssued.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvIssued.Location = new System.Drawing.Point(12, 56);
            this.dtgvIssued.Name = "dtgvIssued";
            this.dtgvIssued.Size = new System.Drawing.Size(1052, 189);
            this.dtgvIssued.TabIndex = 1;
            // 
            // lblReturnedBooks
            // 
            this.lblReturnedBooks.AutoSize = true;
            this.lblReturnedBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnedBooks.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblReturnedBooks.Location = new System.Drawing.Point(448, 263);
            this.lblReturnedBooks.Name = "lblReturnedBooks";
            this.lblReturnedBooks.Size = new System.Drawing.Size(180, 24);
            this.lblReturnedBooks.TabIndex = 2;
            this.lblReturnedBooks.Text = "Sách Đã Được Trả";
            // 
            // dtgvReturned
            // 
            this.dtgvReturned.AllowUserToAddRows = false;
            this.dtgvReturned.AllowUserToDeleteRows = false;
            this.dtgvReturned.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvReturned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvReturned.Location = new System.Drawing.Point(12, 299);
            this.dtgvReturned.Name = "dtgvReturned";
            this.dtgvReturned.Size = new System.Drawing.Size(1052, 240);
            this.dtgvReturned.TabIndex = 3;
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
            this.rjbtnExit.Location = new System.Drawing.Point(1057, 1);
            this.rjbtnExit.Name = "rjbtnExit";
            this.rjbtnExit.Size = new System.Drawing.Size(20, 20);
            this.rjbtnExit.TabIndex = 4;
            this.rjbtnExit.TextColor = System.Drawing.Color.White;
            this.rjbtnExit.UseVisualStyleBackColor = false;
            this.rjbtnExit.Click += new System.EventHandler(this.rjbtnExit_Click);
            // 
            // panel1
            // 
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 56);
            this.panel1.TabIndex = 5;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // CompleteBookDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1076, 551);
            this.Controls.Add(this.rjbtnExit);
            this.Controls.Add(this.dtgvReturned);
            this.Controls.Add(this.lblReturnedBooks);
            this.Controls.Add(this.dtgvIssued);
            this.Controls.Add(this.lblIssuedBooks);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CompleteBookDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompleteBookDetails";
            this.Load += new System.EventHandler(this.CompleteBookDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvIssued)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReturned)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIssuedBooks;
        private System.Windows.Forms.DataGridView dtgvIssued;
        private System.Windows.Forms.Label lblReturnedBooks;
        private System.Windows.Forms.DataGridView dtgvReturned;
        private ToggleButton.RJControls.RJGoodShapeBtn rjbtnExit;
        private System.Windows.Forms.Panel panel1;
    }
}