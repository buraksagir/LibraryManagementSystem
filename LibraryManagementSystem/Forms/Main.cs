using LibraryManagementSystem.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Runtime.InteropServices;

namespace LibraryManagementSystem.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
    }
        private System.Windows.Forms.Timer newTimer = new System.Windows.Forms.Timer();
        public static string usrnmTB = "";
        SqlConnection connection = new SqlConnection(@"Data Source=" + Program.serverName + ";Initial Catalog=LibraryManagementSystem;Integrated Security=True");
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public static string mainSysID;
        public void checkDetails()
        {
            usrnmTB = usernameTB.Text;
            var password = passwordTB.Text;
            var query = "SELECT * FROM Users WHERE Username = '" + usrnmTB + "' AND Password = " + "'" + password + "'";
            try
            {
                connection.Open();
                SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);
                if (dtable.Rows.Count > 0)
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataReader dr = cmd.ExecuteReader();
                    Bitmap b = new Bitmap(@"C:\Users\burak\Desktop\Resources\unlockedpng.png");
                    loginBTN.BackgroundImage = b;
                    loginBTN.FlatAppearance.BorderColor = Color.FromArgb(57, 154, 105);
                    while (dr.Read())
                    {
                        var role = (dr["Role"]).ToString();
                        var status = dr["Status"].ToString();
                        mainSysID = dr["SysID"].ToString();
                        if (role == "librarian" && status == "Active")
                        {
                            MessageBox.Show("Welcome to Bibliotech. Redirecting..");
                            LibrarianPanel librarianPanel = new LibrarianPanel();
                            librarianPanel.Show();
                            this.Hide();
                        }
                        else if (role == "user" && status == "Active")
                        {
                            MessageBox.Show("Welcome to Bibliotech. Redirecting..");
                            UserPanel userPanel = new UserPanel();
                            userPanel.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("There is no user named " + usrnmTB);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usernameTB.Clear();
                    passwordTB.Clear();
                    usernameTB.Focus();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error!");
            }
            finally
            {
                connection.Close();
            }
        }
        private void loginBTN_Click(object sender, EventArgs e)
        {
            checkDetails();
        }
        private void StartAsyncTimedWork()
        {
            newTimer.Interval = 5000;
            newTimer.Tick += new EventHandler(wait);
            newTimer.Start();
        }
        private void wait(object sender, EventArgs e)
        {
            mainGifPB.Hide();
            minimizeBTN.Show();
            closeBTN.Show();
            newTimer.Stop();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            
            StartAsyncTimedWork();
            minimizeBTN.Hide();
            closeBTN.Hide();
        }
        private void minimizeBTN_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void closeBTN_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void passwordTB_Click(object sender, EventArgs e)
        {
            passwordTB.Clear();
        }
        private void usernameTB_Click(object sender, EventArgs e)
        {
            usernameTB.Clear();
        }
    }
}