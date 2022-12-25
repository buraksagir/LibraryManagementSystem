namespace LibraryManagementSystem.Forms
{
    partial class UserAllBooksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAllBooksForm));
            this.allBooksLW = new System.Windows.Forms.ListView();
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Genre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Availability = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.closeBTN = new System.Windows.Forms.Button();
            this.minimizeBTN = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // allBooksLW
            // 
            this.allBooksLW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.allBooksLW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.allBooksLW.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title,
            this.Author,
            this.Genre,
            this.Availability});
            this.allBooksLW.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.allBooksLW.FullRowSelect = true;
            this.allBooksLW.HideSelection = false;
            this.allBooksLW.Location = new System.Drawing.Point(0, 27);
            this.allBooksLW.Name = "allBooksLW";
            this.allBooksLW.Size = new System.Drawing.Size(725, 582);
            this.allBooksLW.TabIndex = 0;
            this.allBooksLW.UseCompatibleStateImageBehavior = false;
            this.allBooksLW.View = System.Windows.Forms.View.Details;
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
            this.Author.Width = 200;
            // 
            // Genre
            // 
            this.Genre.Tag = "Genre";
            this.Genre.Text = "Genre";
            this.Genre.Width = 200;
            // 
            // Availability
            // 
            this.Availability.Tag = "Availability";
            this.Availability.Text = "Availability";
            this.Availability.Width = 100;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.closeBTN);
            this.panel2.Controls.Add(this.minimizeBTN);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(725, 25);
            this.panel2.TabIndex = 15;
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // UserAllBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(725, 609);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.allBooksLW);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserAllBooksForm";
            this.Load += new System.EventHandler(this.UserAllBooksForm_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView allBooksLW;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Author;
        private System.Windows.Forms.ColumnHeader Genre;
        private System.Windows.Forms.ColumnHeader Availability;
        private System.Windows.Forms.Button closeBTN;
        private System.Windows.Forms.Button minimizeBTN;
        private System.Windows.Forms.Panel panel2;
    }
}