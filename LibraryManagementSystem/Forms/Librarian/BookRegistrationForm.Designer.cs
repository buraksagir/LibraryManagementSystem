namespace LibraryManagementSystem.Forms.Librarian
{
    partial class BookRegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookRegistrationForm));
            this.sysIDTB = new System.Windows.Forms.TextBox();
            this.regBooksListView = new System.Windows.Forms.ListView();
            this.BID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Genre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.registerBTN = new System.Windows.Forms.Button();
            this.bookIDTB = new System.Windows.Forms.TextBox();
            this.issuedBooksListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SysID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mame = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Surname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IssueDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReturnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.showIssuedBooksBTN = new System.Windows.Forms.Button();
            this.backBTN = new System.Windows.Forms.Button();
            this.bookSysIDTB = new System.Windows.Forms.TextBox();
            this.BIDTB = new System.Windows.Forms.TextBox();
            this.receiveBTN = new System.Windows.Forms.Button();
            this.firstRB = new System.Windows.Forms.RadioButton();
            this.secondRB = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeBTN = new System.Windows.Forms.Button();
            this.minimizeBTN = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sysIDTB
            // 
            this.sysIDTB.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sysIDTB.Location = new System.Drawing.Point(803, 52);
            this.sysIDTB.Name = "sysIDTB";
            this.sysIDTB.Size = new System.Drawing.Size(184, 27);
            this.sysIDTB.TabIndex = 2;
            this.sysIDTB.Text = "System ID";
            // 
            // regBooksListView
            // 
            this.regBooksListView.AllowColumnReorder = true;
            this.regBooksListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(70)))), ((int)(((byte)(50)))));
            this.regBooksListView.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("regBooksListView.BackgroundImage")));
            this.regBooksListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.regBooksListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BID,
            this.Title,
            this.Author,
            this.Genre});
            this.regBooksListView.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regBooksListView.FullRowSelect = true;
            this.regBooksListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.regBooksListView.HideSelection = false;
            this.regBooksListView.Location = new System.Drawing.Point(0, 53);
            this.regBooksListView.Name = "regBooksListView";
            this.regBooksListView.Size = new System.Drawing.Size(797, 656);
            this.regBooksListView.TabIndex = 3;
            this.regBooksListView.UseCompatibleStateImageBehavior = false;
            this.regBooksListView.View = System.Windows.Forms.View.Details;
            this.regBooksListView.Click += new System.EventHandler(this.regBooksListView_Click);
            // 
            // BID
            // 
            this.BID.Tag = "BID";
            this.BID.Text = "BID";
            this.BID.Width = 100;
            // 
            // Title
            // 
            this.Title.Tag = "Title";
            this.Title.Text = "Title";
            this.Title.Width = 220;
            // 
            // Author
            // 
            this.Author.Tag = "Author";
            this.Author.Text = "Author";
            this.Author.Width = 220;
            // 
            // Genre
            // 
            this.Genre.Tag = "Genre";
            this.Genre.Text = "Genre";
            this.Genre.Width = 220;
            // 
            // registerBTN
            // 
            this.registerBTN.BackColor = System.Drawing.Color.Transparent;
            this.registerBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerBTN.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.registerBTN.FlatAppearance.BorderSize = 3;
            this.registerBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SaddleBrown;
            this.registerBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown;
            this.registerBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerBTN.Font = new System.Drawing.Font("Agency FB", 17F, System.Drawing.FontStyle.Bold);
            this.registerBTN.Location = new System.Drawing.Point(803, 85);
            this.registerBTN.Name = "registerBTN";
            this.registerBTN.Size = new System.Drawing.Size(142, 42);
            this.registerBTN.TabIndex = 13;
            this.registerBTN.Text = "Register";
            this.registerBTN.UseVisualStyleBackColor = false;
            this.registerBTN.Click += new System.EventHandler(this.registerBTN_Click);
            // 
            // bookIDTB
            // 
            this.bookIDTB.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookIDTB.Location = new System.Drawing.Point(993, 52);
            this.bookIDTB.Name = "bookIDTB";
            this.bookIDTB.ReadOnly = true;
            this.bookIDTB.Size = new System.Drawing.Size(142, 27);
            this.bookIDTB.TabIndex = 14;
            this.bookIDTB.Text = "Book ID";
            // 
            // issuedBooksListView
            // 
            this.issuedBooksListView.AllowColumnReorder = true;
            this.issuedBooksListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(70)))), ((int)(((byte)(50)))));
            this.issuedBooksListView.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("issuedBooksListView.BackgroundImage")));
            this.issuedBooksListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.issuedBooksListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.SysID,
            this.Mame,
            this.Surname,
            this.IssueDate,
            this.ReturnDate});
            this.issuedBooksListView.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issuedBooksListView.FullRowSelect = true;
            this.issuedBooksListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.issuedBooksListView.HideSelection = false;
            this.issuedBooksListView.Location = new System.Drawing.Point(151, 52);
            this.issuedBooksListView.Name = "issuedBooksListView";
            this.issuedBooksListView.Size = new System.Drawing.Size(996, 656);
            this.issuedBooksListView.TabIndex = 16;
            this.issuedBooksListView.UseCompatibleStateImageBehavior = false;
            this.issuedBooksListView.View = System.Windows.Forms.View.Details;
            this.issuedBooksListView.Click += new System.EventHandler(this.issuedBooksListView_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Tag = "BID";
            this.columnHeader1.Text = "BID";
            this.columnHeader1.Width = 75;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Tag = "Title";
            this.columnHeader2.Text = "Title";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Tag = "Author";
            this.columnHeader3.Text = "Author";
            this.columnHeader3.Width = 150;
            // 
            // SysID
            // 
            this.SysID.Tag = "SysID";
            this.SysID.Text = "SysID";
            this.SysID.Width = 75;
            // 
            // Mame
            // 
            this.Mame.Tag = "Mame";
            this.Mame.Text = "Name";
            this.Mame.Width = 150;
            // 
            // Surname
            // 
            this.Surname.Tag = "Surname";
            this.Surname.Text = "Surname";
            this.Surname.Width = 150;
            // 
            // IssueDate
            // 
            this.IssueDate.Tag = "IssueDate";
            this.IssueDate.Text = "IssueDate";
            this.IssueDate.Width = 120;
            // 
            // ReturnDate
            // 
            this.ReturnDate.Tag = "ReturnDate";
            this.ReturnDate.Text = "ReturnDate";
            this.ReturnDate.Width = 120;
            // 
            // showIssuedBooksBTN
            // 
            this.showIssuedBooksBTN.BackColor = System.Drawing.Color.Transparent;
            this.showIssuedBooksBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showIssuedBooksBTN.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.showIssuedBooksBTN.FlatAppearance.BorderSize = 3;
            this.showIssuedBooksBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SaddleBrown;
            this.showIssuedBooksBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown;
            this.showIssuedBooksBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showIssuedBooksBTN.Font = new System.Drawing.Font("Agency FB", 17F, System.Drawing.FontStyle.Bold);
            this.showIssuedBooksBTN.Location = new System.Drawing.Point(951, 85);
            this.showIssuedBooksBTN.Name = "showIssuedBooksBTN";
            this.showIssuedBooksBTN.Size = new System.Drawing.Size(184, 42);
            this.showIssuedBooksBTN.TabIndex = 17;
            this.showIssuedBooksBTN.Text = "Show Issued Books";
            this.showIssuedBooksBTN.UseVisualStyleBackColor = false;
            this.showIssuedBooksBTN.Click += new System.EventHandler(this.showIssuedBooksBTN_Click);
            // 
            // backBTN
            // 
            this.backBTN.BackColor = System.Drawing.Color.Transparent;
            this.backBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backBTN.BackgroundImage")));
            this.backBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBTN.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.backBTN.FlatAppearance.BorderSize = 0;
            this.backBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBTN.Font = new System.Drawing.Font("Agency FB", 17F, System.Drawing.FontStyle.Bold);
            this.backBTN.Location = new System.Drawing.Point(10, 624);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(75, 75);
            this.backBTN.TabIndex = 20;
            this.backBTN.UseVisualStyleBackColor = false;
            this.backBTN.Click += new System.EventHandler(this.backBTN_Click);
            // 
            // bookSysIDTB
            // 
            this.bookSysIDTB.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold);
            this.bookSysIDTB.Location = new System.Drawing.Point(12, 85);
            this.bookSysIDTB.Name = "bookSysIDTB";
            this.bookSysIDTB.ReadOnly = true;
            this.bookSysIDTB.Size = new System.Drawing.Size(133, 27);
            this.bookSysIDTB.TabIndex = 21;
            // 
            // BIDTB
            // 
            this.BIDTB.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold);
            this.BIDTB.Location = new System.Drawing.Point(12, 53);
            this.BIDTB.Name = "BIDTB";
            this.BIDTB.ReadOnly = true;
            this.BIDTB.Size = new System.Drawing.Size(133, 27);
            this.BIDTB.TabIndex = 22;
            // 
            // receiveBTN
            // 
            this.receiveBTN.BackColor = System.Drawing.Color.Transparent;
            this.receiveBTN.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.receiveBTN.FlatAppearance.BorderSize = 3;
            this.receiveBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SaddleBrown;
            this.receiveBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown;
            this.receiveBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.receiveBTN.Font = new System.Drawing.Font("Agency FB", 17F, System.Drawing.FontStyle.Bold);
            this.receiveBTN.Location = new System.Drawing.Point(12, 117);
            this.receiveBTN.Name = "receiveBTN";
            this.receiveBTN.Size = new System.Drawing.Size(133, 42);
            this.receiveBTN.TabIndex = 23;
            this.receiveBTN.Text = "Receive Book";
            this.receiveBTN.UseVisualStyleBackColor = false;
            this.receiveBTN.Click += new System.EventHandler(this.receiveBTN_Click);
            // 
            // firstRB
            // 
            this.firstRB.AutoSize = true;
            this.firstRB.BackColor = System.Drawing.Color.Transparent;
            this.firstRB.FlatAppearance.CheckedBackColor = System.Drawing.Color.SaddleBrown;
            this.firstRB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SaddleBrown;
            this.firstRB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown;
            this.firstRB.Font = new System.Drawing.Font("Agency FB", 17F, System.Drawing.FontStyle.Bold);
            this.firstRB.Location = new System.Drawing.Point(803, 133);
            this.firstRB.Name = "firstRB";
            this.firstRB.Size = new System.Drawing.Size(87, 32);
            this.firstRB.TabIndex = 24;
            this.firstRB.TabStop = true;
            this.firstRB.Text = "15 Days";
            this.firstRB.UseVisualStyleBackColor = false;
            // 
            // secondRB
            // 
            this.secondRB.AutoSize = true;
            this.secondRB.BackColor = System.Drawing.Color.Transparent;
            this.secondRB.FlatAppearance.CheckedBackColor = System.Drawing.Color.SaddleBrown;
            this.secondRB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SaddleBrown;
            this.secondRB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown;
            this.secondRB.Font = new System.Drawing.Font("Agency FB", 17F, System.Drawing.FontStyle.Bold);
            this.secondRB.Location = new System.Drawing.Point(803, 171);
            this.secondRB.Name = "secondRB";
            this.secondRB.Size = new System.Drawing.Size(92, 32);
            this.secondRB.TabIndex = 25;
            this.secondRB.TabStop = true;
            this.secondRB.Text = "30 Days";
            this.secondRB.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.closeBTN);
            this.panel1.Controls.Add(this.minimizeBTN);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1147, 25);
            this.panel1.TabIndex = 28;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
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
            this.closeBTN.TabIndex = 26;
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
            this.minimizeBTN.Size = new System.Drawing.Size(27, 27);
            this.minimizeBTN.TabIndex = 27;
            this.minimizeBTN.UseVisualStyleBackColor = false;
            this.minimizeBTN.Click += new System.EventHandler(this.minimizeBTN_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Georgia", 15.75F);
            this.label4.Location = new System.Drawing.Point(538, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 32;
            this.label4.Text = "Genre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Georgia", 15.75F);
            this.label3.Location = new System.Drawing.Point(0, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 31;
            this.label3.Text = "Book ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 15.75F);
            this.label2.Location = new System.Drawing.Point(317, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "Author";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 15.75F);
            this.label1.Location = new System.Drawing.Point(99, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "Book Title";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Georgia", 13.75F);
            this.label6.Location = new System.Drawing.Point(150, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 23);
            this.label6.TabIndex = 35;
            this.label6.Text = "BID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Georgia", 13.75F);
            this.label7.Location = new System.Drawing.Point(375, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 23);
            this.label7.TabIndex = 34;
            this.label7.Text = "Author";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Georgia", 13.75F);
            this.label8.Location = new System.Drawing.Point(225, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 23);
            this.label8.TabIndex = 33;
            this.label8.Text = "Book Title";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Georgia", 13.75F);
            this.label5.Location = new System.Drawing.Point(525, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 23);
            this.label5.TabIndex = 36;
            this.label5.Text = "User ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Georgia", 13.75F);
            this.label9.Location = new System.Drawing.Point(601, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 23);
            this.label9.TabIndex = 37;
            this.label9.Text = "Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Georgia", 13.75F);
            this.label10.Location = new System.Drawing.Point(750, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 23);
            this.label10.TabIndex = 38;
            this.label10.Text = "Surname";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Georgia", 13.75F);
            this.label11.Location = new System.Drawing.Point(900, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 23);
            this.label11.TabIndex = 39;
            this.label11.Text = "Issue Date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Georgia", 13.75F);
            this.label12.Location = new System.Drawing.Point(1020, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 23);
            this.label12.TabIndex = 40;
            this.label12.Text = "Return Date";
            // 
            // BookRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1147, 708);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.secondRB);
            this.Controls.Add(this.firstRB);
            this.Controls.Add(this.receiveBTN);
            this.Controls.Add(this.BIDTB);
            this.Controls.Add(this.bookSysIDTB);
            this.Controls.Add(this.backBTN);
            this.Controls.Add(this.showIssuedBooksBTN);
            this.Controls.Add(this.bookIDTB);
            this.Controls.Add(this.registerBTN);
            this.Controls.Add(this.sysIDTB);
            this.Controls.Add(this.issuedBooksListView);
            this.Controls.Add(this.regBooksListView);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookRegistrationForm";
            this.Text = "BookRegistrationForm";
            this.Load += new System.EventHandler(this.BookRegistrationForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox sysIDTB;
        private System.Windows.Forms.ListView regBooksListView;
        private System.Windows.Forms.ColumnHeader BID;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Author;
        private System.Windows.Forms.ColumnHeader Genre;
        private System.Windows.Forms.Button registerBTN;
        private System.Windows.Forms.TextBox bookIDTB;
        private System.Windows.Forms.ListView issuedBooksListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader SysID;
        private System.Windows.Forms.ColumnHeader Mame;
        private System.Windows.Forms.ColumnHeader Surname;
        private System.Windows.Forms.ColumnHeader IssueDate;
        private System.Windows.Forms.ColumnHeader ReturnDate;
        private System.Windows.Forms.Button showIssuedBooksBTN;
        private System.Windows.Forms.Button backBTN;
        private System.Windows.Forms.TextBox bookSysIDTB;
        private System.Windows.Forms.TextBox BIDTB;
        private System.Windows.Forms.Button receiveBTN;
        private System.Windows.Forms.RadioButton firstRB;
        private System.Windows.Forms.RadioButton secondRB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button minimizeBTN;
        private System.Windows.Forms.Button closeBTN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}