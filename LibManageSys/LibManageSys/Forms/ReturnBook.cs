using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibManageSys.Forms
{
    public partial class ReturnBook : Form
    {
        public ReturnBook()
        {
            InitializeComponent();
        }

        private void rjbtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rjbtnSearchEnroll_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString =
                @"Data Source=LAPTOP-P99NMEFK\SQLEXPRESS;
                Initial Catalog=LibraryManagementSystem;
                Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = 
                $"select * from MUONSACH where std_enroll = '{rjtxbSearchEnroll.Texts}' and " +
                $"book_return_date is NULL";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count != 0)
            {
                dtgvInfo.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Mã sinh viên không hợp lệ", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            pnlInfo.Visible = false;
            rjtxbSearchEnroll.Texts = "";
        }


        private String _bName;
        private String _bDate;
        private Int64 _rowId;
        private void dtgvInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            object cell = dtgvInfo.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            if (!string.IsNullOrEmpty(cell.ToString()))
            {
                _rowId = int.Parse(dtgvInfo.Rows[e.RowIndex].Cells[0].Value.ToString());
                _bName = dtgvInfo.Rows[e.RowIndex].Cells[7].Value.ToString();
                _bDate = dtgvInfo.Rows[e.RowIndex].Cells[8].Value.ToString();

                pnlInfo.Visible = true;

                rjtxbBName.Texts = _bName;
                rjtxbIssueDate.Texts = _bDate;
            }
        }

        private void btnComfirm_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString =
                @"Data Source=LAPTOP-P99NMEFK\SQLEXPRESS;
                Initial Catalog=LibraryManagementSystem;
                Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText =
                $"update MUONSACH set book_return_date = '{rjdtpkReturnDate.Text}' " +
                $"where std_enroll = N'{rjtxbSearchEnroll.Texts}' and id = {_rowId}";

            try
            {
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Trả sách thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    SQLConnection_Load("MUONSACH");

                    ReturnBook_Load(this, null);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy chỉ mục để cập nhật.", "Lỗi",
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

        private void SQLConnection_Load(string table)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString =
                @"Data Source=LAPTOP-P99NMEFK\SQLEXPRESS;
                Initial Catalog=LibraryManagementSystem;
                Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText =
                $"select * from MUONSACH where std_enroll = '{rjtxbSearchEnroll.Texts}' and " +
                $"book_return_date is NULL";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dtgvInfo.DataSource = ds.Tables[0];
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlInfo.Visible = false;
        }

        private void rjtxbSearchEnroll_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                rjbtnSearchEnroll.PerformClick();
            }
        }

        private void rjtxbSearchEnroll__TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(rjtxbSearchEnroll.Texts))
            {
                pnlInfo.Visible = false;
                dtgvInfo.DataSource = null;
            }
        }

        private void rjbtnRefresh_Click(object sender, EventArgs e)
        {
            rjtxbSearchEnroll.Texts = "";
        }
    }
}
