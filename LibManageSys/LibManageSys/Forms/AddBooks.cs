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
    public partial class AddBooks : Form
    {
        private List<Image> images;
        private int order;

        private String _bookName;
        private String _bookAuthor;
        private String _bookPublication;
        private String _bookPurchaseDate;
        private long _bookPrice;
        private int _bookQuantity;

        private bool _isTransfering;

        public AddBooks()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            images = new List<Image>();
            images.Add(Properties.Resources.motivation1);
            images.Add(Properties.Resources._3_1);
            images.Add(Properties.Resources._3_2);
            images.Add(Properties.Resources._3_3);
            images.Add(Properties.Resources._3_4);
            order = 0;

            timerProgress.Enabled = false;
            rjpgbProgress.Value = 0;
            rjpgbProgress.Visible = true;

            _isTransfering = false;
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
                int incrementValue = rjpgbProgress.IncrementValue;
                rjpgbProgress.IncrementValue = 0;
                DialogResult dlgr = MessageBox.Show("Dữ liệu chưa được lưu sẽ bị xóa, bạn có muốn tiếp tục?", "Lưu ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dlgr == DialogResult.Yes)
                    this.Close();
                else rjpgbProgress.IncrementValue = incrementValue;
            }
        }

        private void pnlHead_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void picbBranner_Click(object sender, EventArgs e)
        {
            if (order < images.Count - 1) order++;
            else order = 0;
            picbBranner.Image = images[order];
        }

        private void rjTextBoxBorderCus1__TextChanged(object sender, EventArgs e)
        {
            TextBox txb = (TextBox)sender;

            if (txb != null)
            {
                string text = txb.Text;
                if (text.Length > 0 && !Char.IsDigit(text[text.Length - 1]))
                {
                    txb.Text = text.Substring(0, text.Length - 1);
                    txb.SelectionStart = txb.Text.Length;
                    MessageBox.Show("Bạn đã nhập sai định dạng dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckEmpty())
            {
                MessageBox.Show("Không được để trống dữ liệu", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _isTransfering = true;
            DisableTextBox();

            timerProgress.Enabled = true;
            timerProgress.Start();
            rjpgbProgress.Visible = true;
        }

        private void DisableTextBox()
        {
            txbBName.Enabled = false;
            txbBAuthor.Enabled = false;
            txbBPublication.Enabled = false;
            rjdtpkBBought.Enabled = false;
            txbBPrice.Enabled = false;
            txbBQuan.Enabled = false;

            txbBName.BackColor = Color.DarkGray;
            txbBAuthor.BackColor = Color.DarkGray;
            txbBPublication.BackColor = Color.DarkGray;
            rjdtpkBBought.BackColor = Color.DarkGray;
            txbBPrice.BackColor = Color.DarkGray;
            txbBQuan.BackColor = Color.DarkGray;
        }

        private bool CheckEmpty()
        {
            if (string.IsNullOrEmpty(txbBName.Texts) || string.IsNullOrEmpty(txbBAuthor.Texts) ||
               string.IsNullOrEmpty(txbBPublication.Texts) || string.IsNullOrEmpty(rjdtpkBBought.Text) ||
               string.IsNullOrEmpty(txbBPrice.Texts) || string.IsNullOrEmpty(txbBQuan.Texts))
                return true;
            else return false;
        }

        private bool CheckNotEmpty()
        {
            if (!string.IsNullOrEmpty(txbBName.Texts) || !string.IsNullOrEmpty(txbBAuthor.Texts) ||
               !string.IsNullOrEmpty(txbBPublication.Texts) ||
               !string.IsNullOrEmpty(txbBPrice.Texts) || !string.IsNullOrEmpty(txbBQuan.Texts))
                return true;
            else return false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_isTransfering == true) return;

            txbBName.Texts = string.Empty;
            txbBAuthor.Texts = string.Empty;
            txbBPublication.Texts = string.Empty;
            rjdtpkBBought.Value = DateTime.Now;
            txbBPrice.Texts = string.Empty;
            txbBQuan.Texts = string.Empty;
        }

        private void timerProgress_Tick(object sender, EventArgs e)
        {
            rjpgbProgress.Increment(rjpgbProgress.IncrementValue);
            if (rjpgbProgress.Value >= rjpgbProgress.Maximum)
            {
                timerProgress.Stop();
                timerProgress.Enabled = false;
                rjpgbProgress.Visible = false;
                rjpgbProgress.Value = 0;
                _isTransfering = false;
                EnableTextBox();

                SqlConnectionFinished();
            }
        }

        private void EnableTextBox()
        {
            txbBName.Enabled = true;
            txbBAuthor.Enabled = true;
            txbBPublication.Enabled = true;
            rjdtpkBBought.Enabled = true;
            txbBPrice.Enabled = true;
            txbBQuan.Enabled = true;

            txbBName.BackColor = txbBName.Parent.BackColor;
            txbBAuthor.BackColor = txbBName.Parent.BackColor;
            txbBPublication.BackColor = txbBName.Parent.BackColor;
            rjdtpkBBought.BackColor = txbBName.Parent.BackColor;
            txbBPrice.BackColor = txbBName.Parent.BackColor;
            txbBQuan.BackColor = txbBName.Parent.BackColor;
        }

        private void SqlConnectionFinished()
        {
            _bookName = txbBName.Text;
            _bookAuthor = txbBAuthor.Texts;
            _bookPublication = txbBPublication.Texts;
            _bookPurchaseDate = rjdtpkBBought.Text;
            _bookPrice = Convert.ToInt64(txbBPrice.Texts);
            _bookQuantity = Convert.ToInt32(txbBQuan.Texts);

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=LAPTOP-P99NMEFK\SQLEXPRESS;Initial Catalog=LibraryManagementSystem;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            con.Open();
            cmd.CommandText = $"insert into SACH (bName,bAuthor,bPubl,bPDate,bPrice,bQuan) values (N'{_bookName}',N'{_bookAuthor}',N'{_bookPublication}','{_bookPurchaseDate}','{_bookPrice}','{_bookQuantity}')";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Dữ liệu đã được lưu thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
