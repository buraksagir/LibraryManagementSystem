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

namespace LibraryManagementSystem.Forms
{
    public partial class UserPanel : Form
    {
        public UserPanel()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=" + Program.serverName + ";Initial Catalog=LibraryManagementSystem;Integrated Security=True");
        void listBooks()
        {
            string userName = Main.usrnmTB;
            connection.Open();
            string q = "SELECT * FROM (SELECT dbo.Books.BID, dbo.Books.Title, dbo.Books.Author, dbo.Books.Genre, dbo.Books.Availability, dbo.Books.IssueDate, dbo.Books.ReturnDate, dbo.Books.IfDeleted, dbo.[Users].SysID, dbo.[Users].Username, dbo.[Users].Password,  dbo.[Users].Email, dbo.[Users].Name, dbo.[Users].Surname, dbo.[Users].Address FROM dbo.Books INNER JOIN dbo.BookIssued ON dbo.Books.BID = dbo.BookIssued.BID INNER JOIN dbo.[Users] ON dbo.BookIssued.SysID = dbo.[Users].SysID) AS derivedtbl_1 WHERE (Username = '" + userName + "');";
            SqlCommand cmd = new SqlCommand(q, connection);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ListViewItem add = new ListViewItem(dr["Title"].ToString());
                add.SubItems.Add(dr["Author"].ToString());
                add.SubItems.Add(dr["ReturnDate"].ToString());
                myBooksLW.Items.Add(add);
            }
            connection.Close();
        }
        private void UserPanel_Load(object sender, EventArgs e)
        {
            idLBL.Text = Main.mainSysID.ToString();
            listBooks();
        }
        private void allbooksBTN_Click(object sender, EventArgs e)
        {
            UserAllBooksForm userAllBooksForm= new UserAllBooksForm();
            userAllBooksForm.Show();
        }
        private void closeBTN_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void minimizeBTN_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
        private void logoutBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }
    }
}
