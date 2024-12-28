using LibManageSys.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToggleButton.RJControls;

namespace LibManageSys
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            SetUpRJDropDownMenu();
        }

        private void SetUpRJDropDownMenu()
        {
            rjddmnBook.IsMainMenu = true;
            rjddmnBook.Cursor = Cursors.Hand;
            rjddmnBook.MenuItemTextColor = Color.White;
            rjddmnBook.PrimaryColor = Color.SaddleBrown;

            rjddmnStudent.IsMainMenu = true;
            rjddmnStudent.Cursor = Cursors.Hand;
            rjddmnStudent.MenuItemTextColor = Color.White;
            rjddmnStudent.PrimaryColor = Color.Indigo;
        }

        private void rjbtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rjbtnBook_Click(object sender, EventArgs e)
        {
            rjddmnBook.Show(rjbtnBook, 0, rjbtnBook.Height);
        }

        private void rjbtnStudent_Click(object sender, EventArgs e)
        {
            rjddmnStudent.Show(rjbtnStudent, 0, rjbtnStudent.Height);
        }

        private void rjtsmiAddNewBook_Click(object sender, EventArgs e)
        {
            AddBooks addBooks = new AddBooks();
            addBooks.ShowDialog();
        }

        private void rjtsmiViewBook_Click(object sender, EventArgs e)
        {
            ViewBook viewBook = new ViewBook();
            viewBook.ShowDialog();
        }

        private void tsmiAddStudent_Click(object sender, EventArgs e)
        {
            AddStudent f = new AddStudent();
            f.ShowDialog();
        }

        private void tsmiViewStudent_Click(object sender, EventArgs e)
        {
            ViewStudent f = new ViewStudent();
            f.ShowDialog();
        }

        private void rjbtnIssue_Click(object sender, EventArgs e)
        {
            IssueBooks f = new IssueBooks();
            f.ShowDialog();
        }

        private void rjbtnReturn_Click(object sender, EventArgs e)
        {
            ReturnBook f = new ReturnBook();
            f.ShowDialog();
        }

        private void rjbtnFinish_Click(object sender, EventArgs e)
        {
            CompleteBookDetails f = new CompleteBookDetails();
            f.ShowDialog();
        }
    }
}
