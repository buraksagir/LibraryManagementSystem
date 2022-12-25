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

namespace LibraryManagementSystem.Forms
{
    public partial class UserAllBooksForm : Form
    {
        public UserAllBooksForm()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=" + Program.serverName + ";Initial Catalog=LibraryManagementSystem;Integrated Security=True");
        void listAllBooks()
        {
            connection.Open();
            string q = "SELECT * FROM Books WHERE IfDeleted = 'No';";
            SqlCommand cmd = new SqlCommand(q, connection);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem add = new ListViewItem(dr["Title"].ToString());
                add.SubItems.Add(dr["Author"].ToString());
                add.SubItems.Add(dr["Genre"].ToString());
                add.SubItems.Add(dr["Availability"].ToString());
                allBooksLW.Items.Add(add);
            }
            connection.Close();
        }
        private void UserAllBooksForm_Load(object sender, EventArgs e)
        {
            listAllBooks();
        }
        private void minimizeBTN_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void closeBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
