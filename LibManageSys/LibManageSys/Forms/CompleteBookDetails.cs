using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibManageSys.Forms
{
    public partial class CompleteBookDetails : Form
    {
        public CompleteBookDetails()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void CompleteBookDetails_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString =
                @"Data Source=LAPTOP-P99NMEFK\SQLEXPRESS;
                Initial Catalog=LibraryManagementSystem;
                Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            // dtgvIssued
            cmd.CommandText = "select * from MUONSACH where book_return_date is null";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dtgvIssued.DataSource = ds.Tables[0];

            // dtgvReturned
            cmd.CommandText = "select * from MUONSACH where book_return_date is not null";
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);

            dtgvReturned.DataSource = ds1.Tables[0];
        }

        private void rjbtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
