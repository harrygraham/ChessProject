namespace test_chess
{
    partial class AdminLogin
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
            this.AdminLoginTitle = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.userNameBox = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.PictureBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.enterButton = new System.Windows.Forms.PictureBox();
            this.AdminLogoPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdminLogoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminLoginTitle
            // 
            this.AdminLoginTitle.AutoSize = true;
            this.AdminLoginTitle.BackColor = System.Drawing.Color.Transparent;
            this.AdminLoginTitle.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLoginTitle.Location = new System.Drawing.Point(213, 16);
            this.AdminLoginTitle.Name = "AdminLoginTitle";
            this.AdminLoginTitle.Size = new System.Drawing.Size(182, 39);
            this.AdminLoginTitle.TabIndex = 0;
            this.AdminLoginTitle.Text = "Admin Login";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(220, 166);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(156, 20);
            this.passwordBox.TabIndex = 1;
            // 
            // userNameBox
            // 
            this.userNameBox.Location = new System.Drawing.Point(220, 127);
            this.userNameBox.Name = "userNameBox";
            this.userNameBox.Size = new System.Drawing.Size(156, 20);
            this.userNameBox.TabIndex = 2;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Transparent;
            this.BackButton.Image = global::test_chess.Properties.Resources.BackButton;
            this.BackButton.Location = new System.Drawing.Point(12, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(81, 43);
            this.BackButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackButton.TabIndex = 100;
            this.BackButton.TabStop = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UsernameLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(87, 121);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(107, 26);
            this.UsernameLabel.TabIndex = 101;
            this.UsernameLabel.Text = "Username:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(87, 160);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(100, 26);
            this.PasswordLabel.TabIndex = 102;
            this.PasswordLabel.Text = "Password:";
            // 
            // enterButton
            // 
            this.enterButton.BackColor = System.Drawing.Color.Transparent;
            this.enterButton.Image = global::test_chess.Properties.Resources.EnterButton;
            this.enterButton.Location = new System.Drawing.Point(220, 235);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(140, 73);
            this.enterButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enterButton.TabIndex = 103;
            this.enterButton.TabStop = false;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // AdminLogoPicture
            // 
            this.AdminLogoPicture.BackColor = System.Drawing.Color.Transparent;
            this.AdminLogoPicture.Image = global::test_chess.Properties.Resources.AdminLogo;
            this.AdminLogoPicture.Location = new System.Drawing.Point(450, 12);
            this.AdminLogoPicture.Name = "AdminLogoPicture";
            this.AdminLogoPicture.Size = new System.Drawing.Size(61, 57);
            this.AdminLogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AdminLogoPicture.TabIndex = 104;
            this.AdminLogoPicture.TabStop = false;
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::test_chess.Properties.Resources.StationaryTexture;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(533, 357);
            this.Controls.Add(this.AdminLogoPicture);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.userNameBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.AdminLoginTitle);
            this.DoubleBuffered = true;
            this.Name = "AdminLogin";
            this.Text = "AdminLogin";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AdminLogin_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AdminLogin_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdminLogoPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AdminLoginTitle;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox userNameBox;
        private System.Windows.Forms.PictureBox BackButton;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.PictureBox enterButton;
        private System.Windows.Forms.PictureBox AdminLogoPicture;
    }
}