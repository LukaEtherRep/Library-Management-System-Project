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
using ToggleButton.RJControls;

namespace LibManageSys
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void timer1_Tick(object sender, EventArgs e)
        {
            rjpgbUser.Value += rjpgbUser.IncrementValue;
            rjpgbUser_MaximumReached();
        }

        private void rjpgbUser_MaximumReached()
        {
            if (rjpgbUser.Value >= rjpgbUser.Maximum)
                rjpgbUser.Value = 0;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            rjpgbUser.Value = 0;
        }

        private void rjbtnLogin_Click(object sender, EventArgs e)
        {
            if (EmptyTextBoxCheck(rjtxbUsername, rjtxbPassword))
            {
                MessageBox.Show("Không được để trống Tài Khoản, Mật Khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlConnectionCheck();
        }

        private void SqlConnectionCheck()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=LAPTOP-P99NMEFK\SQLEXPRESS;Initial Catalog=LibraryManagementSystem;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from TAIKHOAN where username ='" + rjtxbUsername.Texts + "' and passcode ='" + rjtxbPassword.Texts + "' ";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count != 0)
            {
                this.Hide();
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Sai Tài Khoản hoặc Mật Khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool EmptyTextBoxCheck(RJTextBoxBorderCus username, RJTextBoxBorderCus passcode)
        {
            if (string.IsNullOrEmpty(username.Texts) || string.IsNullOrEmpty(passcode.Texts))
                return true;
            else return false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rjcpicbUser_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Chọn ảnh đại diện";
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                rjcpicbUser.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void pnlTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
