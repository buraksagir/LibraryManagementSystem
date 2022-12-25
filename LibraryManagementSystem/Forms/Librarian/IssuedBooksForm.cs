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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryManagementSystem.Forms
{
    public partial class IssuedBooksForm : Form
    {
        public IssuedBooksForm()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=" + Program.serverName + ";Initial Catalog=LibraryManagementSystem;Integrated Security=True");
        void listBooks()
        {
            connection.Open();
            string q = "SELECT dbo.Books.BID, dbo.Books.Title, dbo.Books.Author, dbo.Books.Genre, dbo.[Users].SysID, dbo.[Users].Name, dbo.[Users].Surname, dbo.Books.IssueDate, dbo.Books.ReturnDate, dbo.[Users].Username, dbo.[Users].Password, dbo.[Users].Email, dbo.[Users].Address, dbo.Books.Availability, dbo.Books.IfDeleted FROM dbo.Books INNER JOIN dbo.BookIssued ON dbo.Books.BID = dbo.BookIssued.BID INNER JOIN dbo.[Users] ON dbo.BookIssued.SysID = dbo.[Users].SysID";
            SqlCommand cmd = new SqlCommand(q, connection);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem add = new ListViewItem(dr["BID"].ToString());
                add.SubItems.Add(dr["Title"].ToString());
                add.SubItems.Add(dr["Genre"].ToString());
                add.SubItems.Add(dr["Author"].ToString());
                add.SubItems.Add(dr["SysID"].ToString());
                add.SubItems.Add(dr["Name"].ToString());
                add.SubItems.Add(dr["Surname"].ToString());
                add.SubItems.Add(dr["IssueDate"].ToString());
                add.SubItems.Add(dr["ReturnDate"].ToString());
                add.SubItems.Add(dr["Availability"].ToString());
                add.SubItems.Add(dr["IfDeleted"].ToString());
                booksListView.Items.Add(add);
            }
            connection.Close();
        }
        private void BooksForm_Load(object sender, EventArgs e)
        {
            listBooks();
        }
        private void showbooksBTN_Click(object sender, EventArgs e)
        {
            AllBooksForm allBooksForm = new AllBooksForm();
            allBooksForm.Show();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void minimizeBTN_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void closeBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
