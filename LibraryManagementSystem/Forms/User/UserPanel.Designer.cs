namespace LibraryManagementSystem.Forms
{
    partial class UserPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPanel));
            this.mybooksBTN = new System.Windows.Forms.Button();
            this.allbooksBTN = new System.Windows.Forms.Button();
            this.myBooksLW = new System.Windows.Forms.ListView();
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReturnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logoutBTN = new System.Windows.Forms.Button();
            this.closeBTN = new System.Windows.Forms.Button();
            this.minimizeBTN = new System.Windows.Forms.Button();
            this.idLBL = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mybooksBTN
            // 
            this.mybooksBTN.BackColor = System.Drawing.Color.Transparent;
            this.mybooksBTN.Enabled = false;
            this.mybooksBTN.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.mybooksBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.mybooksBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.mybooksBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mybooksBTN.Font = new System.Drawing.Font("Agency FB", 17F, System.Drawing.FontStyle.Bold);
            this.mybooksBTN.Location = new System.Drawing.Point(12, 59);
            this.mybooksBTN.Name = "mybooksBTN";
            this.mybooksBTN.Size = new System.Drawing.Size(140, 43);
            this.mybooksBTN.TabIndex = 0;
            this.mybooksBTN.Text = "My Books";
            this.mybooksBTN.UseVisualStyleBackColor = false;
            // 
            // allbooksBTN
            // 
            this.allbooksBTN.BackColor = System.Drawing.Color.Transparent;
            this.allbooksBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.allbooksBTN.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.allbooksBTN.FlatAppearance.BorderSize = 3;
            this.allbooksBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SaddleBrown;
            this.allbooksBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown;
            this.allbooksBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allbooksBTN.Font = new System.Drawing.Font("Agency FB", 17F, System.Drawing.FontStyle.Bold);
            this.allbooksBTN.Location = new System.Drawing.Point(158, 59);
            this.allbooksBTN.Name = "allbooksBTN";
            this.allbooksBTN.Size = new System.Drawing.Size(140, 43);
            this.allbooksBTN.TabIndex = 1;
            this.allbooksBTN.Text = "Book List";
            this.allbooksBTN.UseVisualStyleBackColor = false;
            this.allbooksBTN.Click += new System.EventHandler(this.allbooksBTN_Click);
            // 
            // myBooksLW
            // 
            this.myBooksLW.AutoArrange = false;
            this.myBooksLW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.myBooksLW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.myBooksLW.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title,
            this.Author,
            this.ReturnDate});
            this.myBooksLW.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myBooksLW.FullRowSelect = true;
            this.myBooksLW.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.myBooksLW.HideSelection = false;
            this.myBooksLW.LabelWrap = false;
            this.myBooksLW.Location = new System.Drawing.Point(0, 108);
            this.myBooksLW.MultiSelect = false;
            this.myBooksLW.Name = "myBooksLW";
            this.myBooksLW.Size = new System.Drawing.Size(605, 425);
            this.myBooksLW.TabIndex = 2;
            this.myBooksLW.UseCompatibleStateImageBehavior = false;
            this.myBooksLW.View = System.Windows.Forms.View.Details;
            // 
            // Title
            // 
            this.Title.Tag = "Title";
            this.Title.Text = "Title";
            this.Title.Width = 120;
            // 
            // Author
            // 
            this.Author.Tag = "Author";
            this.Author.Text = "Author";
            this.Author.Width = 160;
            // 
            // ReturnDate
            // 
            this.ReturnDate.Tag = "ReturnDate";
            this.ReturnDate.Text = "ReturnDate";
            this.ReturnDate.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Agency FB", 17F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(455, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "User ID: ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.logoutBTN);
            this.panel2.Controls.Add(this.closeBTN);
            this.panel2.Controls.Add(this.minimizeBTN);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(605, 25);
            this.panel2.TabIndex = 14;
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // logoutBTN
            // 
            this.logoutBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoutBTN.BackgroundImage")));
            this.logoutBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoutBTN.FlatAppearance.BorderSize = 0;
            this.logoutBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBTN.Location = new System.Drawing.Point(50, 0);
            this.logoutBTN.Name = "logoutBTN";
            this.logoutBTN.Size = new System.Drawing.Size(25, 25);
            this.logoutBTN.TabIndex = 14;
            this.logoutBTN.UseVisualStyleBackColor = true;
            this.logoutBTN.Click += new System.EventHandler(this.logoutBTN_Click);
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
            this.closeBTN.TabIndex = 12;
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
            this.minimizeBTN.TabIndex = 13;
            this.minimizeBTN.UseVisualStyleBackColor = false;
            this.minimizeBTN.Click += new System.EventHandler(this.minimizeBTN_Click);
            // 
            // idLBL
            // 
            this.idLBL.AutoSize = true;
            this.idLBL.BackColor = System.Drawing.Color.Transparent;
            this.idLBL.Font = new System.Drawing.Font("Agency FB", 17F, System.Drawing.FontStyle.Bold);
            this.idLBL.Location = new System.Drawing.Point(520, 59);
            this.idLBL.Name = "idLBL";
            this.idLBL.Size = new System.Drawing.Size(0, 28);
            this.idLBL.TabIndex = 15;
            // 
            // UserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::LibraryManagementSystem.Properties.Resources.librarianPanel;
            this.ClientSize = new System.Drawing.Size(606, 533);
            this.Controls.Add(this.idLBL);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.myBooksLW);
            this.Controls.Add(this.allbooksBTN);
            this.Controls.Add(this.mybooksBTN);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserPanel";
            this.Text = "UserPanel";
            this.Load += new System.EventHandler(this.UserPanel_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mybooksBTN;
        private System.Windows.Forms.Button allbooksBTN;
        private System.Windows.Forms.ListView myBooksLW;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Author;
        private System.Windows.Forms.ColumnHeader ReturnDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button closeBTN;
        private System.Windows.Forms.Button minimizeBTN;
        private System.Windows.Forms.Button logoutBTN;
        private System.Windows.Forms.Label idLBL;
    }
}