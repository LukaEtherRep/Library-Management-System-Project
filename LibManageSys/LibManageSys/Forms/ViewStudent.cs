using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibManageSys.Forms
{
    public partial class ViewStudent : Form
    {
        private String _viewingStudent;
        private String _searchingStudent;

        public ViewStudent()
        {
            InitializeComponent();

            _viewingStudent = "Danh Sách Sinh Viên";
            _searchingStudent = "Tìm Kiếm Sinh Viên";
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void rjtxbEnroll__TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(rjtxbSearchEnroll.Texts))
            {
                lblTitle.Text = _searchingStudent;
                Image image = Properties.Resources.search1;
                picbTitle.Image = image;

                SqlConnection con = new SqlConnection();
                con.ConnectionString =
                    @"Data Source=LAPTOP-P99NMEFK\SQLEXPRESS;
                Initial Catalog=LibraryManagementSystem;
                Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = $"select * from SINHVIEN where enroll LIKE '{rjtxbSearchEnroll.Texts}%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dtgvInfo.DataSource = ds.Tables[0];
            }
            else
            {
                lblTitle.Text = _viewingStudent;
                Image image = Properties.Resources.search;
                picbTitle.Image = image;

                pnlInfo.Visible = false;
                SqlConnection con = new SqlConnection();
                con.ConnectionString =
                    @"Data Source=LAPTOP-P99NMEFK\SQLEXPRESS;
                Initial Catalog=LibraryManagementSystem;
                Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from SINHVIEN";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dtgvInfo.DataSource = ds.Tables[0];
            }
        }

        private void rjbtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewStudent_Load(object sender, EventArgs e)
        {
            pnlInfo.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString =
                @"Data Source=LAPTOP-P99NMEFK\SQLEXPRESS;
                Initial Catalog=LibraryManagementSystem;
                Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from SINHVIEN";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dtgvInfo.DataSource = ds.Tables[0];
        }

        private int _stuid;
        private Int64 _rowId;
        private void dtgvInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            object cell = dtgvInfo.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            if (!string.IsNullOrEmpty(cell.ToString()))
            {
                _stuid = int.Parse(dtgvInfo.Rows[e.RowIndex].Cells[0].Value.ToString());

                pnlInfo.Visible = true;
                DataSet rowData = SQLGetRowValue(_stuid);
                _rowId = Int64.Parse(rowData.Tables[0].Rows[0][0].ToString());
                ShowInfoInPanel(rowData);
                SetOldTextboxValue();
            }
        }

        private DataSet SQLGetRowValue(int primaryKey)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString =
                @"Data Source=LAPTOP-P99NMEFK\SQLEXPRESS;
                Initial Catalog=LibraryManagementSystem;
                Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = $"select * from SINHVIEN where stuid = {primaryKey}";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return ds;
        }

        private void ShowInfoInPanel(DataSet ds)
        {
            rjtxbName.Texts = ds.Tables[0].Rows[0][1].ToString();
            rjtxbEnroll.Texts = ds.Tables[0].Rows[0][2].ToString();
            rjtxbDepart.Texts = ds.Tables[0].Rows[0][3].ToString();
            rjtxbSem.Texts = ds.Tables[0].Rows[0][4].ToString();
            rjtxbPhone.Texts = ds.Tables[0].Rows[0][5].ToString();
            rjtxbEmail.Texts = ds.Tables[0].Rows[0][6].ToString();
        }

        private String _OldName;
        private String _OldEnroll;
        private String _OldDepart;
        private String _OldSem;
        private long _OldPhone;
        private String _OldEmail;

        private void SetOldTextboxValue()
        {
            _OldName = rjtxbName.Texts;
            _OldEnroll = rjtxbEnroll.Texts;
            _OldDepart = rjtxbDepart.Texts;
            _OldSem = rjtxbSem.Texts;
            _OldPhone = Int64.Parse(rjtxbPhone.Texts);
            _OldEmail = rjtxbEmail.Texts;
        }

        private bool DifferentValueBeforeAfterUpdate()
        {
            bool _one = _OldName != rjtxbName.Texts;
            bool _two = _OldEnroll != rjtxbEnroll.Texts;
            bool _three = _OldDepart != rjtxbDepart.Texts;
            bool _four = _OldSem != rjtxbSem.Texts;
            bool _five = _OldPhone != Int64.Parse(rjtxbPhone.Texts);
            bool _six = _OldEmail != rjtxbEmail.Texts;

            return _one || _two || _three || _four || _five || _six;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!DifferentValueBeforeAfterUpdate())
            {
                MessageBox.Show("Dữ liệu nhập vào phải khác dữ liệu cũ",
                "Cảnh báo", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

                return;
            }

            if (MessageBox.Show("Xác nhận cập nhật database?",
                "Xác nhận", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
                return;

            String sName = rjtxbName.Texts;
            String sEnroll = rjtxbEnroll.Texts;
            String sDepart = rjtxbDepart.Texts;
            String sSem = rjtxbSem.Texts;
            long sPhone = Int64.Parse(rjtxbPhone.Texts);
            String sEmail = rjtxbEmail.Texts;

            SqlConnection con = new SqlConnection();
            con.ConnectionString =
                @"Data Source=LAPTOP-P99NMEFK\SQLEXPRESS;
                Initial Catalog=LibraryManagementSystem;
                Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = $"UPDATE SINHVIEN SET " +
                //sname,enroll,dep,sem,contact,email
                $"sname = N'{sName}', " +
                $"enroll = N'{sEnroll}', " +
                $"dep = N'{sDepart}', " +
                $"sem = '{sSem}', " +
                $"contact = {sPhone}, " +
                $"email = '{sEmail}' " +
                $"WHERE stuid = {_rowId}";

            try
            {
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    SQLConnection_Load();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sinh viên để cập nhật.", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
            finally
            {
                con.Close();
            }
        }

        private void SQLConnection_Load()
        {
            pnlInfo.Visible = false;

            SqlConnection con = new SqlConnection();
            con.ConnectionString =
                @"Data Source=LAPTOP-P99NMEFK\SQLEXPRESS;
                Initial Catalog=LibraryManagementSystem;
                Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from SINHVIEN";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dtgvInfo.DataSource = ds.Tables[0];
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SQLConnection_Load();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa sinh viên khỏi database?", "Xác nhận",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            SqlConnection con = new SqlConnection();
            con.ConnectionString =
                @"Data Source=LAPTOP-P99NMEFK\SQLEXPRESS;
                    Initial Catalog=LibraryManagementSystem;
                    Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText =
                $"delete from SINHVIEN where stuid = {_rowId}";

            try
            {
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    SQLConnection_Load();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sách để xóa", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
            finally
            {
                con.Close();  // Đảm bảo đóng kết nối sau khi xong
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlInfo.Visible = false;
        }
    }
}
