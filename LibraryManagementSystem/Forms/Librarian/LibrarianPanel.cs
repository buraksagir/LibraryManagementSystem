using LibraryManagementSystem.Forms.Librarian;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Forms
{
    public partial class LibrarianPanel : Form
    {
        public LibrarianPanel()
        {
            InitializeComponent();
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
        private void issuedBooksBTN_Click(object sender, EventArgs e)
        {
            IssuedBooksForm booksForm = new IssuedBooksForm();
            booksForm.Show();
        }
        private void allBooksBTN_Click(object sender, EventArgs e)
        {
            AllBooksForm allBooksForm = new AllBooksForm();
            allBooksForm.Show();
        }
        private void bookRegistrationBTN_Click(object sender, EventArgs e)
        {
            BookRegistrationForm registerBookForm = new BookRegistrationForm();
            registerBookForm.Show();
        }
        private void userRegistrationBTN_Click(object sender, EventArgs e)
        {
            UserRegistrationForm studentRegistrationForm = new UserRegistrationForm();
            studentRegistrationForm.Show();
        }
        private void LibrarianPanel_Load(object sender, EventArgs e)
        {
            issuedBooksBTN.Hide();
            allBooksBTN.Hide();
            bookRegistrationBTN.Hide();
            userRegistrationBTN.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
        }
        int j = 1;
        int i = 1;
        private void booksbtnBTN_Click(object sender, EventArgs e)
        {
            j++;
            if (j % 2 == 0)
            {
                allBooksBTN.Show();
                issuedBooksBTN.Show();
                label3.Show();
                label6.Show();
            }
            else
            {
                allBooksBTN.Hide();
                issuedBooksBTN.Hide();
                label3.Hide();
                label6.Hide();
            }
        }
        private void regbtnBTN_Click(object sender, EventArgs e)
        {
            i++;
            if (i % 2 == 0)
            {
                bookRegistrationBTN.Show();
                userRegistrationBTN.Show();
                label4.Show();
                label5.Show();
            }
            else
            {
                bookRegistrationBTN.Hide();
                userRegistrationBTN.Hide();
                label4.Hide();
                label5.Hide();
            }
        }
        private void closeBTN_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void minimizeBTN_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void logoutBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }
    }
}
