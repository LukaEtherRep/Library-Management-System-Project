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
using System.Xml.Linq;

namespace LibManageSys.Forms
{
    public partial class IssueBooks : Form
    {
        public IssueBooks()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlHead_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txbSSem__TextChanged(object sender, EventArgs e)
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

        private void IssueBooks_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString =
                @"Data Source=LAPTOP-P99NMEFK\SQLEXPRESS;
                Initial Catalog=LibraryManagementSystem;
                Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd = new SqlCommand("Select bName from SACH", con);
            SqlDataReader Sdr = cmd.ExecuteReader();

            while (Sdr.Read())
            {
                for (int i = 0; i < Sdr.FieldCount; i++)
                {
                    rjcbBName.Items.Add(Sdr.GetString(i));
                }
            }
            Sdr.Close();
            con.Close();
        }

        private int _count;
        private void rjbtnSearchEnroll_Click(object sender, EventArgs e)
        {
            rjtxbSearchEnroll.Focus();

            if(!string.IsNullOrEmpty(rjtxbSearchEnroll.Texts))
            {
                String eid = rjtxbSearchEnroll.Texts;
                SqlConnection con = new SqlConnection();
                con.ConnectionString =
                    @"Data Source=LAPTOP-P99NMEFK\SQLEXPRESS;
                Initial Catalog=LibraryManagementSystem;
                Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"Select * from SINHVIEN where enroll = '{eid}'";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                //----------------------------------------------------------------------------
                // Code để đếm số lượng sách đã sinh viên này cho mượn
                cmd.CommandText = 
                    $"Select count(std_enroll) from MUONSACH where std_enroll = '{eid}' " +
                    $"and book_return_date is null";
                SqlDataAdapter DA1 = new SqlDataAdapter(cmd);
                DataSet DS1 = new DataSet();
                DA.Fill(DS1);

                _count = int.Parse(DS1.Tables[0].Rows[0][0].ToString());
                //----------------------------------------------------------------------------

                if (DS.Tables[0].Rows.Count != 0)
                {
                    txbSName.Texts = DS.Tables[0].Rows[0][1].ToString();
                    txbSDepart.Texts = DS.Tables[0].Rows[0][3].ToString();
                    txbSSem.Texts = DS.Tables[0].Rows[0][4].ToString();
                    txbSPhone.Texts = DS.Tables[0].Rows[0][5].ToString();
                    txbSEmail.Texts = DS.Tables[0].Rows[0][6].ToString();
                }
                else
                {
                    txbSName.Texts = "";
                    txbSDepart.Texts = "";
                    txbSSem.Texts = "";
                    txbSPhone.Texts = "";
                    txbSEmail.Texts = "";
                    rjcbBName.Text = "";
                    MessageBox.Show("Mã sinh viên không hợp lệ", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txbSName.Texts))
            {
                if(rjcbBName.SelectedIndex != -1 && _count <= 2)
                {
                    String enroll = rjtxbSearchEnroll.Texts;
                    String sname = txbSName.Texts;
                    String sdep = txbSDepart.Texts;
                    String sem = txbSSem.Texts;
                    Int64 sphone = Int64.Parse(txbSPhone.Texts);
                    String email = txbSEmail.Texts;
                    String bookName = rjcbBName.Texts;
                    String bookIssueDate = ParseLongDateToShortDate(rjdtpkIssueDate.Text);

                    SqlConnection con = new SqlConnection();
                    con.ConnectionString =
                        @"Data Source=LAPTOP-P99NMEFK\SQLEXPRESS;
                        Initial Catalog=LibraryManagementSystem;
                        Integrated Security=True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText =
                        $"Insert into MUONSACH (std_enroll,std_name,std_dep,std_sem," +
                        $"std_phone,std_email,book_name,book_issue_date) " +
                        $"values ('{enroll}','{sname}','{sdep}','{sem}',{sphone}," +
                        $"'{email}','{bookName}','{bookIssueDate}')";

                    try
                    {
                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật thành công!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            UpdateBookCount(enroll);
                        }
                        else
                        {
                            MessageBox.Show("Lỗi không xác định", "Lỗi",
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
                else
                {
                    MessageBox.Show("Hãy chọn sách. Hoặc số lượng sách mượn vướt quá quy định.",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập vào mã sinh viên hợp lệ!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateBookCount(string enroll)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString =
                @"Data Source=LAPTOP-P99NMEFK\SQLEXPRESS;
                Initial Catalog=LibraryManagementSystem;
                Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText =
                $"Select count(std_enroll) from MUONSACH where std_enroll = " +
                $"'{enroll}' and book_return_date is null";
            SqlDataAdapter DA1 = new SqlDataAdapter(cmd);
            DataSet DS1 = new DataSet();
            DA1.Fill(DS1);

            _count = int.Parse(DS1.Tables[0].Rows[0][0].ToString());
        }

        private String ParseLongDateToShortDate(String longDate)
        {
            DateTime parseDate;

            if(DateTime.TryParse(longDate, out parseDate))
            {
                return parseDate.ToString("dd/MM/yyyy");
            }
            else
            {
                MessageBox.Show("Không thể chuyển đổi chuỗi ngày tháng");
                return "";
            }
        }

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
            if (!string.IsNullOrEmpty(txbSName.Texts) ||
                !string.IsNullOrEmpty(txbSDepart.Texts) ||
                !string.IsNullOrEmpty(txbSSem.Texts) ||
                !string.IsNullOrEmpty(txbSPhone.Texts) ||
                !string.IsNullOrEmpty(txbSEmail.Texts) ||
                !string.IsNullOrEmpty(rjcbBName.Texts))
                return true;
            else return false;
        }

        private void rjtxbSearchEnroll_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                rjbtnSearchEnroll.PerformClick();
            }
        }

        private void rjbtnRefresh_Click(object sender, EventArgs e)
        {
            rjtxbSearchEnroll.Texts = "";
        }
    }
}
