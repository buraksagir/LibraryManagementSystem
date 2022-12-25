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
    public partial class AllBooksForm : Form
    {
        public AllBooksForm()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=" + Program.serverName + ";Initial Catalog=LibraryManagementSystem;Integrated Security=True");
        void listBooks()
        {
            connection.Open();
            string q = "SELECT * FROM Books WHERE IfDeleted = 'No';";
            SqlCommand cmd = new SqlCommand(q, connection);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem add = new ListViewItem(dr["BID"].ToString());
                add.SubItems.Add(dr["Title"].ToString());
                add.SubItems.Add(dr["Author"].ToString());
                add.SubItems.Add(dr["Genre"].ToString());
                booksListView.Items.Add(add);
            }
            connection.Close();
        }
        void addBook()
        {
            try
            {
                connection.Open();
                string titleText = titleTB.Text;
                string authorText = authorTB.Text;
                string genreText = genreTB.Text;
                string query = "INSERT INTO Books (Title, Author, Genre) VALUES ('" + titleText + "','" + authorText + "','" + genreText + "');";
                SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                sda.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Book successfully created.");
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured. Please check inputs.\n Book couldn't created.");
            }
            finally { connection.Close(); }
        }
        void deleteBook()
        {
            try
            {
                var selectedBID = deleteBookTB.Text;
                connection.Open();
                string q = "UPDATE Books SET IfDeleted = 'Yes' WHERE BID = '" + deleteBookTB.Text + "'";
                SqlDataAdapter SDA = new SqlDataAdapter(q, connection);
                SDA.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Book successfully deleted.");
            }
            catch (Exception)
            {
                MessageBox.Show("Couldn't find a book for that Book ID.");
            }
            finally { connection.Close(); }
        }
        private void AllBooksForm_Load(object sender, EventArgs e)
        {
            listBooks();
        }
        private void addBTN_Click(object sender, EventArgs e)
        {
            booksListView.Items.Clear();
            addBook();
            listBooks();
        }
        private void deleteBTN_Click(object sender, EventArgs e)
        {
            booksListView.Items.Clear();
            deleteBook();
            listBooks();
        }
        private void booksListView_Click(object sender, EventArgs e)
        {
            deleteBookTB.Clear();
            deleteBookTB.Text = booksListView.SelectedItems[0].Text;
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
        private void minimizeBTN_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
