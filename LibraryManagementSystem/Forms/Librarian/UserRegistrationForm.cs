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

namespace LibraryManagementSystem.Forms.Librarian
{
    public partial class UserRegistrationForm : Form
    {
        public UserRegistrationForm()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=" + Program.serverName + ";Initial Catalog=LibraryManagementSystem;Integrated Security=True");
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        void listUsers()
        {
            string query = "SELECT * FROM Users WHERE Status = 'Active';";
            if (showDeletedCB.Checked)
            {
                query = "SELECT * FROM Users WHERE Status = 'Deleted';";
            }
            usersListView.Items.Clear();
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem add = new ListViewItem(dr["SysID"].ToString());
                    add.SubItems.Add(dr["Username"].ToString());
                    add.SubItems.Add(dr["Password"].ToString());
                    add.SubItems.Add(dr["Name"].ToString());
                    add.SubItems.Add(dr["Surname"].ToString());
                    add.SubItems.Add(dr["Email"].ToString());
                    add.SubItems.Add(dr["Address"].ToString());
                    add.SubItems.Add(dr["Role"].ToString());
                    add.SubItems.Add(dr["Status"].ToString());
                usersListView.Items.Add(add);
            }
            connection.Close();
        }
        void createUser()
        {
            string q = "SELECT Username FROM Users";
            string checkUsername = "";
            string roleCheck = "";
            connection.Open();
            SqlCommand cmd = new SqlCommand(q, connection);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                checkUsername = dr["Username"].ToString();
            }
            connection.Close();

            if (checkUsername == oneTB.Text.ToString())
            {
                MessageBox.Show("This username is already exist.");
            }
            else
            {
                if (roleLibrarianRB.Checked)
                {
                    roleCheck = "librarian";
                }
                else
                {
                    roleCheck = "user";
                }
                string query = "INSERT INTO Users(Username, Password, Name, Surname, Email, Address, Role) VALUES ('" + oneTB.Text.ToString() + "','" + twoTB.Text.ToString() + "','" + threeTB.Text.ToString() + "','" + fourTB.Text.ToString() + "','" + fiveTB.Text.ToString() + "','" + sixTB.Text.ToString() + "','" + roleCheck + "')";
                connection.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter(query, connection);
                sqlDA.SelectCommand.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("User " + oneTB.Text.ToString() + " is successfully created.");
            }
        }
        void deleteUser()
        {
            var getSysID = usersListView.SelectedItems[0].SubItems[0].Text.ToString();
            string q = "UPDATE Users SET Status = 'Deleted' WHERE SysID = '" + getSysID + "';";
            connection.Open();
            SqlDataAdapter sqlData= new SqlDataAdapter(q, connection);
            sqlData.SelectCommand.ExecuteNonQuery();
            connection.Close();
            listUsers();
        }
        private void showDeletedCB_CheckedChanged(object sender, EventArgs e)
        {
            listUsers();
        }
        private void UserRegistrationForm_Load(object sender, EventArgs e)
        {
            listUsers();
            listUserWin();
        }
        void createUserWin()
        {
            usersListView.Hide();
            createUserBTN.Hide();
            showDeletedCB.Hide();
            oneTB.Show();
            twoTB.Show();
            threeTB.Show();
            fourTB.Show();
            fiveTB.Show();
            sixTB.Show();
            label1.Show();
            label2.Show();
            label3.Show();
            label4.Show();
            label5.Show();
            label6.Show();
            label7.Show();
            label8.Hide();
            label9.Hide();
            label10.Hide();
            label11.Hide();
            label12.Hide();
            label13.Hide();
            label14.Hide();
            label15.Hide();
            label16.Hide();
            createLBTN.Show();
            backLBTN.Show();
            roleUserRB.Show();
            roleLibrarianRB.Show();
            this.Width = 535;
            this.Height = 400;
        }
        void listUserWin()
        {
            usersListView.Show();
            createUserBTN.Show();
            showDeletedCB.Show();
            oneTB.Hide();
            twoTB.Hide();
            threeTB.Hide();
            fourTB.Hide();
            fiveTB.Hide();
            sixTB.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Show();
            label9.Show();
            label10.Show();
            label11.Show();
            label12.Show();
            label13.Show();
            label14.Show();
            label15.Show();
            label16.Show();
            createLBTN.Hide();
            backLBTN.Hide();
            roleUserRB.Hide();
            roleLibrarianRB.Hide();
            this.Width = 1066;
            this.Height = 574;
        }
        private void createUserBTN_Click(object sender, EventArgs e)
        {
            createUserWin();
        }
        private void createLBTN_Click(object sender, EventArgs e)
        {
            createUser();
        }
        private void backLBTN_Click(object sender, EventArgs e)
        {
            listUsers();
            listUserWin();
        }
        private void deleteUserLBTN_Click(object sender, EventArgs e)
        {
            var getSysID = usersListView.SelectedItems[0].SubItems[0].Text.ToString();
            string q = "SELECT Username FROM Users WHERE SysID = '" + getSysID + "'";
            string getUsername = "";
            connection.Open();
            SqlCommand cmd = new SqlCommand(q, connection);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                getUsername = dr["Username"].ToString();
            }
            connection.Close();
            if (MessageBox.Show("Do you want to delete this user?\n    " + getUsername, "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                deleteUser();
            }
        }
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