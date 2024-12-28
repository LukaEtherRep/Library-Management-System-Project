using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibManageSys.Forms
{
    public partial class ViewBook : Form
    {
        private String _OldBookName;
        private String _OldBookAuthor;
        private String _OldBookPublication;
        private String _OldBookPurchaseDate;
        private long _OldBookPrice;
        private int _OldBookQuantity;

        public ViewBook()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void rjbtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ViewBook_Load(object sender, EventArgs e)
        {
            SQLConnection_Load();
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

            cmd.CommandText = "select * from SACH";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dtgvInfo.DataSource = ds.Tables[0];
        }

        private int _bid;
        private int rowID;
        private void dtgvInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            object cell = dtgvInfo.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            if (!string.IsNullOrEmpty(cell.ToString()))
            {
                _bid = int.Parse(dtgvInfo.Rows[e.RowIndex].Cells[0].Value.ToString());

                pnlInfo.Visible = true;
                DataSet rowData = SQLGetRowValue(_bid);
                rowID = Int32.Parse(rowData.Tables[0].Rows[0][0].ToString());
                ShowInfoInPanel(rowData);
                SetOldTextboxValue();
            }
        }

        private void SetOldTextboxValue()
        {
            _OldBookName = rjtxbBook.Texts;
            _OldBookAuthor = rjtxbAuthor.Texts;
            _OldBookPublication = rjtxbPublication.Texts;
            _OldBookPurchaseDate = rjdtpkPurchaseDate.Text;
            _OldBookPrice = Int64.Parse(rjtxbPrice.Texts);
            _OldBookQuantity = Int32.Parse(rjtxbQuantity.Texts);
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

            cmd.CommandText = $"select * from SACH where bid = {primaryKey}";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return ds;
        }

        private void ShowInfoInPanel(DataSet ds)
        {
            rjtxbBook.Texts = ds.Tables[0].Rows[0][1].ToString();
            rjtxbAuthor.Texts = ds.Tables[0].Rows[0][2].ToString();
            rjtxbPublication.Texts = ds.Tables[0].Rows[0][3].ToString();

            rjdtpkPurchaseDate.Text = ParseStringToDateTime(ds.Tables[0].Rows[0][4].ToString());

            rjtxbPrice.Texts = ds.Tables[0].Rows[0][5].ToString();
            rjtxbQuantity.Texts = ds.Tables[0].Rows[0][6].ToString();
        }

        private string ParseStringToDateTime(string dateString)
        {
            DateTime dateValue;

            if (DateTime.TryParseExact(dateString, "dd/MM/yyyy",
                CultureInfo.InvariantCulture, DateTimeStyles.None, out dateValue))
            {
                dateString = dateValue.ToString("MM/dd/yyyy");
            }
            else
            {
                dateString = "01/01/1111";
            }
            return dateString;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlInfo.Visible = false;
        }

        private void rjtxbBName__TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(rjtxbBName.Texts))
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString =
                    @"Data Source=LAPTOP-P99NMEFK\SQLEXPRESS;
                    Initial Catalog=LibraryManagementSystem;
                    Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText =
                    $"select * from SACH where bName LIKE N'{rjtxbBName.Texts}%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dtgvInfo.DataSource = ds.Tables[0];
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString =
                    @"Data Source=LAPTOP-P99NMEFK\SQLEXPRESS;
                    Initial Catalog=LibraryManagementSystem;
                    Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = $"select * from SACH";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dtgvInfo.DataSource = ds.Tables[0];
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            rjtxbBName.Texts = string.Empty;
            pnlInfo.Visible = false;
        }

        private bool DifferentValueBeforeAfterUpdate()
        {
            bool _one = _OldBookName != rjtxbBook.Texts;
            bool _two = _OldBookAuthor != rjtxbAuthor.Texts;
            bool _three = _OldBookPublication != rjtxbPublication.Texts;
            bool _four = _OldBookPurchaseDate != rjdtpkPurchaseDate.Text;
            bool _five = _OldBookPrice != Int64.Parse(rjtxbPrice.Texts);
            bool _six = _OldBookQuantity != Int32.Parse(rjtxbQuantity.Texts);

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

            String bookName = rjtxbBook.Texts;
            String bookAuthor = rjtxbAuthor.Texts;
            String bookPublication = rjtxbPublication.Texts;
            String bookPurchaseDate = rjdtpkPurchaseDate.Text;
            long bookPrice = Int64.Parse(rjtxbPrice.Texts);
            int bookQuantity = Int32.Parse(rjtxbQuantity.Texts);

            SqlConnection con = new SqlConnection();
            con.ConnectionString =
                @"Data Source=LAPTOP-P99NMEFK\SQLEXPRESS;
                Initial Catalog=LibraryManagementSystem;
                Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = $"UPDATE SACH SET " +
                $"bName = N'{bookName}', " +
                $"bAuthor = N'{bookAuthor}', " +
                $"bPubl = N'{bookPublication}', " +
                $"bPDate = '{bookPurchaseDate}', " +
                $"bPrice = {bookPrice}, " +
                $"bQuan = {bookQuantity} " +
                $"WHERE bid = {rowID}";

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
                    MessageBox.Show("Không tìm thấy sách để cập nhật.", "Lỗi",
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa sách khỏi database?", "Xác nhận",
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
                $"delete from SACH where bid = {rowID}";

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
    }
}
