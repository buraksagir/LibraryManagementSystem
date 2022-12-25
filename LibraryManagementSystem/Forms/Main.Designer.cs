namespace LibraryManagementSystem.Forms
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.loginBTN = new System.Windows.Forms.Button();
            this.mainGifPB = new System.Windows.Forms.PictureBox();
            this.closeBTN = new System.Windows.Forms.Button();
            this.minimizeBTN = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.mainGifPB)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameTB
            // 
            this.usernameTB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.usernameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTB.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 21.75F);
            this.usernameTB.Location = new System.Drawing.Point(135, 231);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(179, 35);
            this.usernameTB.TabIndex = 0;
            this.usernameTB.Text = "Username";
            this.usernameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.usernameTB.Click += new System.EventHandler(this.usernameTB_Click);
            // 
            // passwordTB
            // 
            this.passwordTB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.passwordTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTB.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 21.75F);
            this.passwordTB.Location = new System.Drawing.Point(135, 273);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '*';
            this.passwordTB.Size = new System.Drawing.Size(179, 35);
            this.passwordTB.TabIndex = 1;
            this.passwordTB.Text = "password";
            this.passwordTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordTB.Click += new System.EventHandler(this.passwordTB_Click);
            // 
            // loginBTN
            // 
            this.loginBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginBTN.BackColor = System.Drawing.Color.Transparent;
            this.loginBTN.BackgroundImage = global::LibraryManagementSystem.Properties.Resources.Untitled_design;
            this.loginBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(139)))));
            this.loginBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.loginBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.loginBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBTN.Font = new System.Drawing.Font("Candara Light", 17.75F);
            this.loginBTN.ForeColor = System.Drawing.Color.Transparent;
            this.loginBTN.ImageKey = "(none)";
            this.loginBTN.Location = new System.Drawing.Point(173, 314);
            this.loginBTN.Name = "loginBTN";
            this.loginBTN.Size = new System.Drawing.Size(112, 109);
            this.loginBTN.TabIndex = 2;
            this.loginBTN.UseVisualStyleBackColor = false;
            this.loginBTN.Click += new System.EventHandler(this.loginBTN_Click);
            // 
            // mainGifPB
            // 
            this.mainGifPB.Image = global::LibraryManagementSystem.Properties.Resources.White_March_Background_Instagram_Story;
            this.mainGifPB.Location = new System.Drawing.Point(-1, 0);
            this.mainGifPB.Name = "mainGifPB";
            this.mainGifPB.Size = new System.Drawing.Size(452, 787);
            this.mainGifPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainGifPB.TabIndex = 4;
            this.mainGifPB.TabStop = false;
            this.mainGifPB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
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
            this.closeBTN.Location = new System.Drawing.Point(2, 0);
            this.closeBTN.Name = "closeBTN";
            this.closeBTN.Size = new System.Drawing.Size(25, 25);
            this.closeBTN.TabIndex = 5;
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
            this.minimizeBTN.Location = new System.Drawing.Point(33, 0);
            this.minimizeBTN.Name = "minimizeBTN";
            this.minimizeBTN.Size = new System.Drawing.Size(27, 27);
            this.minimizeBTN.TabIndex = 7;
            this.minimizeBTN.UseVisualStyleBackColor = false;
            this.minimizeBTN.Click += new System.EventHandler(this.minimizeBTN_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(66, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 25);
            this.panel1.TabIndex = 8;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(449, 787);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.minimizeBTN);
            this.Controls.Add(this.closeBTN);
            this.Controls.Add(this.mainGifPB);
            this.Controls.Add(this.loginBTN);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.usernameTB);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainGifPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Button loginBTN;
        private System.Windows.Forms.PictureBox mainGifPB;
        private System.Windows.Forms.Button closeBTN;
        private System.Windows.Forms.Button minimizeBTN;
        private System.Windows.Forms.Panel panel1;
    }
}