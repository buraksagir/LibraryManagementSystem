namespace LibraryManagementSystem.Forms.Librarian
{
    partial class UserRegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRegistrationForm));
            this.usersListView = new System.Windows.Forms.ListView();
            this.SysID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mame = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Surname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Role = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.showDeletedCB = new System.Windows.Forms.CheckBox();
            this.createUserBTN = new System.Windows.Forms.Button();
            this.oneTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.twoTB = new System.Windows.Forms.TextBox();
            this.threeTB = new System.Windows.Forms.TextBox();
            this.fourTB = new System.Windows.Forms.TextBox();
            this.fiveTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sixTB = new System.Windows.Forms.TextBox();
            this.roleUserRB = new System.Windows.Forms.RadioButton();
            this.roleLibrarianRB = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.createLBTN = new System.Windows.Forms.Button();
            this.backLBTN = new System.Windows.Forms.Button();
            this.deleteUserLBTN = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.closeBTN = new System.Windows.Forms.Button();
            this.minimizeBTN = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // usersListView
            // 
            this.usersListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(93)))), ((int)(((byte)(65)))));
            this.usersListView.BackgroundImageTiled = true;
            this.usersListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SysID,
            this.Username,
            this.Password,
            this.Mame,
            this.Surname,
            this.Email,
            this.Address,
            this.Role,
            this.Status});
            this.usersListView.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.usersListView.FullRowSelect = true;
            this.usersListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.usersListView.HideSelection = false;
            this.usersListView.Location = new System.Drawing.Point(0, 52);
            this.usersListView.Name = "usersListView";
            this.usersListView.Size = new System.Drawing.Size(903, 483);
            this.usersListView.TabIndex = 0;
            this.usersListView.UseCompatibleStateImageBehavior = false;
            this.usersListView.View = System.Windows.Forms.View.Details;
            // 
            // SysID
            // 
            this.SysID.Tag = "SysID";
            this.SysID.Text = "SysID";
            // 
            // Username
            // 
            this.Username.Tag = "Username";
            this.Username.Text = "Username";
            this.Username.Width = 100;
            // 
            // Password
            // 
            this.Password.Tag = "Password";
            this.Password.Text = "Password";
            this.Password.Width = 100;
            // 
            // Mame
            // 
            this.Mame.Tag = "Mame";
            this.Mame.Text = "Name";
            this.Mame.Width = 100;
            // 
            // Surname
            // 
            this.Surname.Tag = "Surname";
            this.Surname.Text = "Surname";
            this.Surname.Width = 100;
            // 
            // Email
            // 
            this.Email.Tag = "Email";
            this.Email.Text = "Email";
            this.Email.Width = 150;
            // 
            // Address
            // 
            this.Address.Tag = "Address";
            this.Address.Text = "Address";
            this.Address.Width = 150;
            // 
            // Role
            // 
            this.Role.Tag = "Role";
            this.Role.Text = "Role";
            this.Role.Width = 79;
            // 
            // Status
            // 
            this.Status.Tag = "Status";
            this.Status.Text = "Status";
            // 
            // showDeletedCB
            // 
            this.showDeletedCB.AutoSize = true;
            this.showDeletedCB.BackColor = System.Drawing.Color.Transparent;
            this.showDeletedCB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showDeletedCB.FlatAppearance.CheckedBackColor = System.Drawing.Color.SaddleBrown;
            this.showDeletedCB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SaddleBrown;
            this.showDeletedCB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown;
            this.showDeletedCB.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold);
            this.showDeletedCB.ForeColor = System.Drawing.Color.Black;
            this.showDeletedCB.Location = new System.Drawing.Point(909, 54);
            this.showDeletedCB.Name = "showDeletedCB";
            this.showDeletedCB.Size = new System.Drawing.Size(131, 24);
            this.showDeletedCB.TabIndex = 2;
            this.showDeletedCB.Text = "Show Deleted Users";
            this.showDeletedCB.UseVisualStyleBackColor = false;
            this.showDeletedCB.CheckedChanged += new System.EventHandler(this.showDeletedCB_CheckedChanged);
            // 
            // createUserBTN
            // 
            this.createUserBTN.BackColor = System.Drawing.Color.Transparent;
            this.createUserBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createUserBTN.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.createUserBTN.FlatAppearance.BorderSize = 3;
            this.createUserBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SaddleBrown;
            this.createUserBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown;
            this.createUserBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createUserBTN.Font = new System.Drawing.Font("Agency FB", 17F, System.Drawing.FontStyle.Bold);
            this.createUserBTN.ForeColor = System.Drawing.Color.Black;
            this.createUserBTN.Location = new System.Drawing.Point(909, 277);
            this.createUserBTN.Name = "createUserBTN";
            this.createUserBTN.Size = new System.Drawing.Size(123, 42);
            this.createUserBTN.TabIndex = 18;
            this.createUserBTN.Text = "Create User";
            this.createUserBTN.UseVisualStyleBackColor = false;
            this.createUserBTN.Click += new System.EventHandler(this.createUserBTN_Click);
            // 
            // oneTB
            // 
            this.oneTB.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.oneTB.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Bold);
            this.oneTB.Location = new System.Drawing.Point(104, 51);
            this.oneTB.Name = "oneTB";
            this.oneTB.Size = new System.Drawing.Size(391, 33);
            this.oneTB.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 31);
            this.label1.TabIndex = 20;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 31);
            this.label2.TabIndex = 21;
            this.label2.Text = "E-Mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(1, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 31);
            this.label3.TabIndex = 22;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(1, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 31);
            this.label4.TabIndex = 23;
            this.label4.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(1, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 31);
            this.label5.TabIndex = 24;
            this.label5.Text = "Surname:";
            // 
            // twoTB
            // 
            this.twoTB.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Bold);
            this.twoTB.Location = new System.Drawing.Point(104, 90);
            this.twoTB.Name = "twoTB";
            this.twoTB.Size = new System.Drawing.Size(391, 33);
            this.twoTB.TabIndex = 25;
            // 
            // threeTB
            // 
            this.threeTB.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Bold);
            this.threeTB.Location = new System.Drawing.Point(104, 129);
            this.threeTB.Name = "threeTB";
            this.threeTB.Size = new System.Drawing.Size(391, 33);
            this.threeTB.TabIndex = 26;
            // 
            // fourTB
            // 
            this.fourTB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.fourTB.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Bold);
            this.fourTB.Location = new System.Drawing.Point(104, 168);
            this.fourTB.Name = "fourTB";
            this.fourTB.Size = new System.Drawing.Size(391, 33);
            this.fourTB.TabIndex = 27;
            // 
            // fiveTB
            // 
            this.fiveTB.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.fiveTB.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Bold);
            this.fiveTB.Location = new System.Drawing.Point(104, 207);
            this.fiveTB.Name = "fiveTB";
            this.fiveTB.Size = new System.Drawing.Size(391, 33);
            this.fiveTB.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(1, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 31);
            this.label6.TabIndex = 29;
            this.label6.Text = "Address:";
            // 
            // sixTB
            // 
            this.sixTB.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Bold);
            this.sixTB.Location = new System.Drawing.Point(104, 246);
            this.sixTB.Name = "sixTB";
            this.sixTB.Size = new System.Drawing.Size(391, 33);
            this.sixTB.TabIndex = 30;
            // 
            // roleUserRB
            // 
            this.roleUserRB.AutoSize = true;
            this.roleUserRB.BackColor = System.Drawing.Color.Transparent;
            this.roleUserRB.Checked = true;
            this.roleUserRB.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.roleUserRB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.roleUserRB.Font = new System.Drawing.Font("Agency FB", 17F, System.Drawing.FontStyle.Bold);
            this.roleUserRB.ForeColor = System.Drawing.Color.Black;
            this.roleUserRB.Location = new System.Drawing.Point(7, 322);
            this.roleUserRB.Name = "roleUserRB";
            this.roleUserRB.Size = new System.Drawing.Size(66, 32);
            this.roleUserRB.TabIndex = 31;
            this.roleUserRB.TabStop = true;
            this.roleUserRB.Text = "User";
            this.roleUserRB.UseVisualStyleBackColor = false;
            // 
            // roleLibrarianRB
            // 
            this.roleLibrarianRB.AutoSize = true;
            this.roleLibrarianRB.BackColor = System.Drawing.Color.Transparent;
            this.roleLibrarianRB.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.roleLibrarianRB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.roleLibrarianRB.Font = new System.Drawing.Font("Agency FB", 17F, System.Drawing.FontStyle.Bold);
            this.roleLibrarianRB.ForeColor = System.Drawing.Color.Black;
            this.roleLibrarianRB.Location = new System.Drawing.Point(7, 360);
            this.roleLibrarianRB.Name = "roleLibrarianRB";
            this.roleLibrarianRB.Size = new System.Drawing.Size(97, 32);
            this.roleLibrarianRB.TabIndex = 32;
            this.roleLibrarianRB.Text = "Librarian";
            this.roleLibrarianRB.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(1, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 31);
            this.label7.TabIndex = 33;
            this.label7.Text = "Role";
            // 
            // createLBTN
            // 
            this.createLBTN.BackColor = System.Drawing.Color.Transparent;
            this.createLBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createLBTN.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.createLBTN.FlatAppearance.BorderSize = 3;
            this.createLBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SaddleBrown;
            this.createLBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown;
            this.createLBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createLBTN.Font = new System.Drawing.Font("Agency FB", 17F, System.Drawing.FontStyle.Bold);
            this.createLBTN.ForeColor = System.Drawing.Color.Black;
            this.createLBTN.Location = new System.Drawing.Point(372, 288);
            this.createLBTN.Name = "createLBTN";
            this.createLBTN.Size = new System.Drawing.Size(123, 42);
            this.createLBTN.TabIndex = 34;
            this.createLBTN.Text = "Create";
            this.createLBTN.UseVisualStyleBackColor = false;
            this.createLBTN.Click += new System.EventHandler(this.createLBTN_Click);
            // 
            // backLBTN
            // 
            this.backLBTN.BackColor = System.Drawing.Color.Transparent;
            this.backLBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backLBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backLBTN.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.backLBTN.FlatAppearance.BorderSize = 3;
            this.backLBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SaddleBrown;
            this.backLBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown;
            this.backLBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backLBTN.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Bold);
            this.backLBTN.ForeColor = System.Drawing.Color.Black;
            this.backLBTN.Location = new System.Drawing.Point(425, 336);
            this.backLBTN.Name = "backLBTN";
            this.backLBTN.Size = new System.Drawing.Size(70, 40);
            this.backLBTN.TabIndex = 35;
            this.backLBTN.Text = "Back";
            this.backLBTN.UseVisualStyleBackColor = false;
            this.backLBTN.Click += new System.EventHandler(this.backLBTN_Click);
            // 
            // deleteUserLBTN
            // 
            this.deleteUserLBTN.BackColor = System.Drawing.Color.Transparent;
            this.deleteUserLBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteUserLBTN.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.deleteUserLBTN.FlatAppearance.BorderSize = 3;
            this.deleteUserLBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SaddleBrown;
            this.deleteUserLBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown;
            this.deleteUserLBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteUserLBTN.Font = new System.Drawing.Font("Agency FB", 17F, System.Drawing.FontStyle.Bold);
            this.deleteUserLBTN.ForeColor = System.Drawing.Color.Black;
            this.deleteUserLBTN.Location = new System.Drawing.Point(908, 481);
            this.deleteUserLBTN.Name = "deleteUserLBTN";
            this.deleteUserLBTN.Size = new System.Drawing.Size(123, 42);
            this.deleteUserLBTN.TabIndex = 36;
            this.deleteUserLBTN.Text = "Delete User";
            this.deleteUserLBTN.UseVisualStyleBackColor = false;
            this.deleteUserLBTN.Click += new System.EventHandler(this.deleteUserLBTN_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Georgia", 13F);
            this.label8.Location = new System.Drawing.Point(0, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 21);
            this.label8.TabIndex = 40;
            this.label8.Text = "ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Georgia", 13F);
            this.label9.Location = new System.Drawing.Point(609, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 21);
            this.label9.TabIndex = 41;
            this.label9.Text = "Address";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Georgia", 13F);
            this.label10.Location = new System.Drawing.Point(457, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 21);
            this.label10.TabIndex = 42;
            this.label10.Text = "Email";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Georgia", 13F);
            this.label11.Location = new System.Drawing.Point(358, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 21);
            this.label11.TabIndex = 43;
            this.label11.Text = "Surname";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Georgia", 13F);
            this.label12.Location = new System.Drawing.Point(260, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 21);
            this.label12.TabIndex = 44;
            this.label12.Text = "Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Georgia", 13F);
            this.label13.Location = new System.Drawing.Point(158, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 21);
            this.label13.TabIndex = 45;
            this.label13.Text = "Password";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Georgia", 13F);
            this.label14.Location = new System.Drawing.Point(60, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 21);
            this.label14.TabIndex = 46;
            this.label14.Text = "Username";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Georgia", 13F);
            this.label15.Location = new System.Drawing.Point(836, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 21);
            this.label15.TabIndex = 47;
            this.label15.Text = "Status";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Georgia", 13F);
            this.label16.Location = new System.Drawing.Point(757, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 21);
            this.label16.TabIndex = 48;
            this.label16.Text = "Role";
            // 
            // closeBTN
            // 
            this.closeBTN.BackColor = System.Drawing.Color.Transparent;
            this.closeBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeBTN.BackgroundImage")));
            this.closeBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBTN.FlatAppearance.BorderSize = 0;
            this.closeBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.closeBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.closeBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBTN.Location = new System.Drawing.Point(0, 0);
            this.closeBTN.Name = "closeBTN";
            this.closeBTN.Size = new System.Drawing.Size(25, 25);
            this.closeBTN.TabIndex = 50;
            this.closeBTN.UseVisualStyleBackColor = false;
            this.closeBTN.Click += new System.EventHandler(this.closeBTN_Click);
            // 
            // minimizeBTN
            // 
            this.minimizeBTN.BackColor = System.Drawing.Color.Transparent;
            this.minimizeBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimizeBTN.BackgroundImage")));
            this.minimizeBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimizeBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeBTN.FlatAppearance.BorderSize = 0;
            this.minimizeBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.minimizeBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.minimizeBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeBTN.Location = new System.Drawing.Point(25, 0);
            this.minimizeBTN.Name = "minimizeBTN";
            this.minimizeBTN.Size = new System.Drawing.Size(25, 25);
            this.minimizeBTN.TabIndex = 51;
            this.minimizeBTN.UseVisualStyleBackColor = false;
            this.minimizeBTN.Click += new System.EventHandler(this.minimizeBTN_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.closeBTN);
            this.panel1.Controls.Add(this.minimizeBTN);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1052, 25);
            this.panel1.TabIndex = 53;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // UserRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(93)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1050, 535);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.deleteUserLBTN);
            this.Controls.Add(this.backLBTN);
            this.Controls.Add(this.createLBTN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.roleLibrarianRB);
            this.Controls.Add(this.roleUserRB);
            this.Controls.Add(this.sixTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fiveTB);
            this.Controls.Add(this.fourTB);
            this.Controls.Add(this.threeTB);
            this.Controls.Add(this.twoTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oneTB);
            this.Controls.Add(this.createUserBTN);
            this.Controls.Add(this.showDeletedCB);
            this.Controls.Add(this.usersListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserRegistrationForm";
            this.Text = "StudentRegistrationForm";
            this.Load += new System.EventHandler(this.UserRegistrationForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView usersListView;
        private System.Windows.Forms.ColumnHeader SysID;
        private System.Windows.Forms.ColumnHeader Username;
        private System.Windows.Forms.ColumnHeader Password;
        private System.Windows.Forms.ColumnHeader Mame;
        private System.Windows.Forms.ColumnHeader Surname;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader Role;
        private System.Windows.Forms.CheckBox showDeletedCB;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.Button createUserBTN;
        private System.Windows.Forms.TextBox oneTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox twoTB;
        private System.Windows.Forms.TextBox threeTB;
        private System.Windows.Forms.TextBox fourTB;
        private System.Windows.Forms.TextBox fiveTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox sixTB;
        private System.Windows.Forms.RadioButton roleUserRB;
        private System.Windows.Forms.RadioButton roleLibrarianRB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button createLBTN;
        private System.Windows.Forms.Button backLBTN;
        private System.Windows.Forms.Button deleteUserLBTN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button closeBTN;
        private System.Windows.Forms.Button minimizeBTN;
        private System.Windows.Forms.Panel panel1;
    }
}