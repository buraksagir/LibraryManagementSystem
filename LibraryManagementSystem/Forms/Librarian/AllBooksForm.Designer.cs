namespace LibraryManagementSystem.Forms
{
    partial class AllBooksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllBooksForm));
            this.booksListView = new System.Windows.Forms.ListView();
            this.BID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Genre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.authorTB = new System.Windows.Forms.TextBox();
            this.genreTB = new System.Windows.Forms.TextBox();
            this.titleTB = new System.Windows.Forms.TextBox();
            this.deleteBTN = new System.Windows.Forms.Button();
            this.addBTN = new System.Windows.Forms.Button();
            this.deleteBookTB = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.closeBTN = new System.Windows.Forms.Button();
            this.minimizeBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // booksListView
            // 
            this.booksListView.AllowColumnReorder = true;
            this.booksListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(70)))), ((int)(((byte)(50)))));
            this.booksListView.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("booksListView.BackgroundImage")));
            this.booksListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.booksListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BID,
            this.Title,
            this.Author,
            this.Genre});
            this.booksListView.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksListView.FullRowSelect = true;
            this.booksListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.booksListView.HideSelection = false;
            this.booksListView.Location = new System.Drawing.Point(1, 65);
            this.booksListView.Name = "booksListView";
            this.booksListView.Size = new System.Drawing.Size(702, 543);
            this.booksListView.TabIndex = 1;
            this.booksListView.UseCompatibleStateImageBehavior = false;
            this.booksListView.View = System.Windows.Forms.View.Details;
            this.booksListView.Click += new System.EventHandler(this.booksListView_Click);
            // 
            // BID
            // 
            this.BID.Tag = "BID";
            this.BID.Text = "BID";
            this.BID.Width = 90;
            // 
            // Title
            // 
            this.Title.Tag = "Title";
            this.Title.Text = "Title";
            this.Title.Width = 200;
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
            this.Genre.Width = 190;
            // 
            // authorTB
            // 
            this.authorTB.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold);
            this.authorTB.Location = new System.Drawing.Point(719, 65);
            this.authorTB.Name = "authorTB";
            this.authorTB.Size = new System.Drawing.Size(142, 27);
            this.authorTB.TabIndex = 8;
            // 
            // genreTB
            // 
            this.genreTB.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold);
            this.genreTB.Location = new System.Drawing.Point(719, 98);
            this.genreTB.Name = "genreTB";
            this.genreTB.Size = new System.Drawing.Size(142, 27);
            this.genreTB.TabIndex = 7;
            // 
            // titleTB
            // 
            this.titleTB.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold);
            this.titleTB.Location = new System.Drawing.Point(719, 32);
            this.titleTB.Name = "titleTB";
            this.titleTB.Size = new System.Drawing.Size(143, 27);
            this.titleTB.TabIndex = 6;
            // 
            // deleteBTN
            // 
            this.deleteBTN.BackColor = System.Drawing.Color.Transparent;
            this.deleteBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBTN.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.deleteBTN.FlatAppearance.BorderSize = 3;
            this.deleteBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SaddleBrown;
            this.deleteBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown;
            this.deleteBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBTN.Font = new System.Drawing.Font("Agency FB", 17F, System.Drawing.FontStyle.Bold);
            this.deleteBTN.Location = new System.Drawing.Point(720, 317);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.Size = new System.Drawing.Size(142, 43);
            this.deleteBTN.TabIndex = 11;
            this.deleteBTN.Text = "Delete Book";
            this.deleteBTN.UseVisualStyleBackColor = false;
            this.deleteBTN.Click += new System.EventHandler(this.deleteBTN_Click);
            // 
            // addBTN
            // 
            this.addBTN.BackColor = System.Drawing.Color.Transparent;
            this.addBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBTN.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addBTN.FlatAppearance.BorderSize = 3;
            this.addBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SaddleBrown;
            this.addBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown;
            this.addBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBTN.Font = new System.Drawing.Font("Agency FB", 17F, System.Drawing.FontStyle.Bold);
            this.addBTN.Location = new System.Drawing.Point(719, 131);
            this.addBTN.Name = "addBTN";
            this.addBTN.Size = new System.Drawing.Size(142, 43);
            this.addBTN.TabIndex = 12;
            this.addBTN.Text = "Add Book";
            this.addBTN.UseVisualStyleBackColor = false;
            this.addBTN.Click += new System.EventHandler(this.addBTN_Click);
            // 
            // deleteBookTB
            // 
            this.deleteBookTB.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold);
            this.deleteBookTB.Location = new System.Drawing.Point(720, 284);
            this.deleteBookTB.Name = "deleteBookTB";
            this.deleteBookTB.Size = new System.Drawing.Size(142, 27);
            this.deleteBookTB.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Controls.Add(this.closeBTN);
            this.panel3.Controls.Add(this.minimizeBTN);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(874, 25);
            this.panel3.TabIndex = 17;
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
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
            this.closeBTN.TabIndex = 15;
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
            this.minimizeBTN.TabIndex = 16;
            this.minimizeBTN.UseVisualStyleBackColor = false;
            this.minimizeBTN.Click += new System.EventHandler(this.minimizeBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 15.75F);
            this.label1.Location = new System.Drawing.Point(90, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Book Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 15.75F);
            this.label2.Location = new System.Drawing.Point(290, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Georgia", 15.75F);
            this.label3.Location = new System.Drawing.Point(-4, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Book ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Georgia", 15.75F);
            this.label4.Location = new System.Drawing.Point(511, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Genre";
            // 
            // AllBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(88)))), ((int)(((byte)(58)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(874, 609);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteBookTB);
            this.Controls.Add(this.addBTN);
            this.Controls.Add(this.deleteBTN);
            this.Controls.Add(this.authorTB);
            this.Controls.Add(this.genreTB);
            this.Controls.Add(this.titleTB);
            this.Controls.Add(this.booksListView);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AllBooksForm";
            this.Text = "AllBooksForm";
            this.Load += new System.EventHandler(this.AllBooksForm_Load);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView booksListView;
        private System.Windows.Forms.ColumnHeader BID;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Genre;
        private System.Windows.Forms.ColumnHeader Author;
        private System.Windows.Forms.TextBox authorTB;
        private System.Windows.Forms.TextBox genreTB;
        private System.Windows.Forms.TextBox titleTB;
        private System.Windows.Forms.Button deleteBTN;
        private System.Windows.Forms.Button addBTN;
        private System.Windows.Forms.TextBox deleteBookTB;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button minimizeBTN;
        private System.Windows.Forms.Button closeBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}