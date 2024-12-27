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
    public partial class AddStudent : Form
    {
        private String _stuName;
        private String _stuEnroll;
        private String _stuDepart;
        private String _stuSem;
        private long _stuPhone;
        private String _stuEmail;

        public AddStudent()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void rjbtnExit_Click(object sender, EventArgs e)
        {
            if (!CheckNotEmpty()) this.Close();
            else
            {
                DialogResult dlgr = MessageBox.Show(
                    "Dữ liệu chưa được lưu sẽ bị xóa, bạn có muốn tiếp tục?", 
                    "Lưu ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dlgr == DialogResult.Yes)
                    this.Close();
            }
        }

        private bool CheckNotEmpty()
        {
            if (!string.IsNullOrEmpty(txbName.Texts) || !string.IsNullOrEmpty(txbEnroll.Texts) ||
               !string.IsNullOrEmpty(txbDepartment.Texts) || 
               !string.IsNullOrEmpty(txbSemester.Texts) ||
               !string.IsNullOrEmpty(txbPhone.Texts) || !string.IsNullOrEmpty(txbEmail.Texts))
                return true;
            else return false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txbName.Texts = string.Empty;
            txbEnroll.Texts = string.Empty;
            txbDepartment.Texts = string.Empty;
            txbSemester.Texts = string.Empty;
            txbPhone.Texts = string.Empty;
            txbEmail.Texts = string.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckEmpty())
            {
                MessageBox.Show("Không được để trống dữ liệu", "Lưu ý",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                SqlConnectionFinished();
            }
        }

        private void SqlConnectionFinished()
        {
            _stuName = txbName.Texts;
            _stuEnroll = txbEnroll.Texts;
            _stuDepart = txbDepartment.Texts;
            _stuSem = txbSemester.Texts;
            _stuPhone = Int64.Parse(txbPhone.Texts);
            _stuEmail = txbEmail.Texts;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = 
                @"Data Source=LAPTOP-P99NMEFK\SQLEXPRESS;
                Initial Catalog=LibraryManagementSystem;
                Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            con.Open();
            cmd.CommandText = 
                $"insert into SINHVIEN " +
                $"(sname,enroll,dep,sem,contact,email) " +
                $"values (N'{_stuName}',N'{_stuEnroll}'," +
                $"N'{_stuDepart}','{_stuSem}',{_stuPhone}," +
                $"'{_stuEmail}')";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Dữ liệu đã được lưu thành công", "Thành công",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool CheckEmpty()
        {
            if (string.IsNullOrEmpty(txbName.Texts) ||
                string.IsNullOrEmpty(txbEnroll.Texts) ||
               string.IsNullOrEmpty(txbDepartment.Texts) || 
               string.IsNullOrEmpty(txbSemester.Texts) ||
               string.IsNullOrEmpty(txbPhone.Texts) || string.IsNullOrEmpty(txbEmail.Texts))
                return true;
            else return false;
        }

        private void txbID__TextChanged(object sender, EventArgs e)
        {
            TextBox txb = (TextBox)sender;

            if (txb != null)
            {
                string text = txb.Text;
                if (text.Length > 0 && !Char.IsDigit(text[text.Length - 1]))
                {
                    txb.Text = text.Substring(0, text.Length - 1);
                    txb.SelectionStart = txb.Text.Length;
                    MessageBox.Show("Bạn đã nhập sai định dạng dữ liệu", "Lỗi", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pnlHead_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
