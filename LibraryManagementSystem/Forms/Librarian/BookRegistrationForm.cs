using System;
using System.Collections;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace LibraryManagementSystem.Forms.Librarian
{
    public partial class BookRegistrationForm : Form
    {
        public BookRegistrationForm()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=" + Program.serverName + ";Initial Catalog=LibraryManagementSystem;Integrated Security=True");
        void listBooks()
        {
            regBooksListView.Items.Clear();
            connection.Open();
            string q = "SELECT * FROM Books WHERE (IfDeleted = 'No' AND Availability = 'Available');";
            SqlCommand cmd = new SqlCommand(q, connection);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem add = new ListViewItem(dr["BID"].ToString());
                add.SubItems.Add(dr["Title"].ToString());
                add.SubItems.Add(dr["Author"].ToString());
                add.SubItems.Add(dr["Genre"].ToString());
                regBooksListView.Items.Add(add);
            }
            connection.Close();
        }
        void listIssuedBooks()
        {
           issuedBooksListView.Items.Clear();
            try
            {
                var sysIDD = sysIDTB.Text;
                connection.Open();
                string q = "SELECT dbo.Books.BID, dbo.Books.Title, dbo.Books.Author, dbo.Books.Genre, dbo.Books.Availability, dbo.Books.IssueDate, dbo.Books.ReturnDate, dbo.Books.IfDeleted, dbo.[Users].SysID, dbo.[Users].Username, dbo.[Users].Password,  dbo.[Users].Email, dbo.[Users].Name, dbo.[Users].Surname, dbo.[Users].Address\r\nFROM dbo.BookIssued INNER JOIN dbo.Books ON dbo.BookIssued.BID = dbo.Books.BID INNER JOIN dbo.[Users] ON dbo.BookIssued.SysID = dbo.[Users].SysID\r\nWHERE (dbo.BookIssued.SysID = '" + sysIDD.ToString() + "')";
                SqlCommand cmd = new SqlCommand(q, connection);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ListViewItem add = new ListViewItem(dr["BID"].ToString());
                    add.SubItems.Add(dr["Title"].ToString());
                    add.SubItems.Add(dr["Author"].ToString());
                    add.SubItems.Add(dr["SysID"].ToString());
                    add.SubItems.Add(dr["Name"].ToString());
                    add.SubItems.Add(dr["Surname"].ToString());
                    add.SubItems.Add(dr["IssueDate"].ToString());
                    add.SubItems.Add(dr["ReturnDate"].ToString());
                    issuedBooksListView.Items.Add(add);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a valid system id.");
                showListBooks();
            }
            finally { connection.Close(); }
        }
        void receiveBook()
        {
            try
            {
                var bid = BIDTB.Text;
                var bookSysID = bookSysIDTB.Text;
                string q = "DELETE FROM BookIssued WHERE (BID = " + BIDTB.Text + " AND SysID = " + bookSysIDTB.Text + "); " +
                    "UPDATE Books SET Availability = 'Available', IssueDate = NULL, ReturnDate = NULL WHERE BID = " + BIDTB.Text + ";";
                connection.Open();
                SqlDataAdapter sqlDAdapter = new SqlDataAdapter(q, connection);
                sqlDAdapter.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Book successfully received.");
            }
            catch (Exception)
            {
                MessageBox.Show("Receiving process failed.");
            }
            finally { connection.Close(); }
        }
        void registerBook()
        {
            try
            {
                DateTime today = DateTime.Now;
                DateTime returnDate = today;
                if (firstRB.Checked)
                {
                    returnDate = today.AddDays(15);
                }
                else
                {
                    returnDate = today.AddDays(30);
                }
                var systemID = sysIDTB.Text; ;
                string q = "INSERT INTO BookIssued(BID, SysID) VALUES ('" + bookIDTB.Text + "','" + systemID.ToString() + "');";
                string query = "UPDATE Books SET Availability = 'Issued', IssueDate = '" + today.ToShortDateString() + "', ReturnDate = '" + returnDate.ToShortDateString() + "' WHERE BID = '" + bookIDTB.Text + "'";
                connection.Open();
                SqlDataAdapter sqlDAdapter = new SqlDataAdapter(query, connection);
                sqlDAdapter.SelectCommand.ExecuteNonQuery();
                SqlDataAdapter sqlDA = new SqlDataAdapter(q, connection);
                sqlDA.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Book successfully registered for user: " + systemID.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Book registration is failed.");  
            }
            finally { connection.Close();
            }
        }
        private void BookRegistrationForm_Load(object sender, EventArgs e)
        {
            firstRB.Checked = true;
            listBooks();
            showListBooks();
        }
        private void registerBTN_Click(object sender, EventArgs e)
        {
            registerBook();
            listBooks();
        }
        private void showIssuedBooksBTN_Click(object sender, EventArgs e)
        {
            showIssuedBooks();
            listIssuedBooks();  
        }
        private void backBTN_Click(object sender, EventArgs e)
        {
            listBooks();
            showListBooks();
            issuedBooksListView.Items.Clear();
        }
        private void receiveBTN_Click(object sender, EventArgs e)
        {
            if (BIDTB.Text.Length <= 0)
            {
                MessageBox.Show("Please select a book.");
            }
            receiveBook();
            listIssuedBooks();
            BIDTB.Clear();
        }
        void showListBooks()
        {
            regBooksListView.Show();
            registerBTN.Show();
            bookIDTB.Show();
            sysIDTB.Show();
            showIssuedBooksBTN.Show();
            issuedBooksListView.Hide();
            backBTN.Hide();
            BIDTB.Hide();
            bookSysIDTB.Hide();
            receiveBTN.Hide();
            firstRB.Show();
            secondRB.Show();
            label1.Show();
            label2.Show();
            label3.Show();
            label4.Show();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
            label11.Hide();
            label12.Hide();
        }
        void showIssuedBooks()
        {
            regBooksListView.Hide();
            registerBTN.Hide();
            bookIDTB.Hide();
            sysIDTB.Hide();
            showIssuedBooksBTN.Hide();
            issuedBooksListView.Show();
            backBTN.Show();
            BIDTB.Show();
            bookSysIDTB.Show();
            receiveBTN.Show();
            firstRB.Hide();
            secondRB.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Show();
            label6.Show();
            label7.Show();
            label8.Show();
            label9.Show();
            label10.Show();
            label11.Show();
            label12.Show();
        }
        private void issuedBooksListView_Click(object sender, EventArgs e)
        {
            BIDTB.Text = issuedBooksListView.SelectedItems[0].SubItems[0].Text;
            bookSysIDTB.Text = issuedBooksListView.SelectedItems[0].SubItems[3].Text;
        }
        private void regBooksListView_Click(object sender, EventArgs e)
        {
            bookIDTB.Text = regBooksListView.SelectedItems[0].SubItems[0].Text;
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void closeBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void minimizeBTN_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
