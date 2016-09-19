namespace test_chess
{
    partial class AskQuestion
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
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.userAnswer1 = new System.Windows.Forms.RichTextBox();
            this.userAnswer2 = new System.Windows.Forms.RichTextBox();
            this.Answer1Label = new System.Windows.Forms.Label();
            this.Answer2Label = new System.Windows.Forms.Label();
            this.RootSymbolLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.PlayerTurnPicBox = new System.Windows.Forms.PictureBox();
            this.PlayerLabel = new System.Windows.Forms.Label();
            this.enterButton = new System.Windows.Forms.PictureBox();
            this.SquareRootButton = new System.Windows.Forms.PictureBox();
            this.BackButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerTurnPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SquareRootButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).BeginInit();
            this.SuspendLayout();
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.BackColor = System.Drawing.Color.Transparent;
            this.QuestionLabel.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionLabel.Location = new System.Drawing.Point(112, 97);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(34, 42);
            this.QuestionLabel.TabIndex = 0;
            this.QuestionLabel.Text = "?";
            // 
            // userAnswer1
            // 
            this.userAnswer1.Location = new System.Drawing.Point(82, 195);
            this.userAnswer1.Name = "userAnswer1";
            this.userAnswer1.Size = new System.Drawing.Size(128, 46);
            this.userAnswer1.TabIndex = 1;
            this.userAnswer1.Text = "";
            // 
            // userAnswer2
            // 
            this.userAnswer2.Location = new System.Drawing.Point(247, 195);
            this.userAnswer2.Name = "userAnswer2";
            this.userAnswer2.Size = new System.Drawing.Size(128, 46);
            this.userAnswer2.TabIndex = 2;
            this.userAnswer2.Text = "";
            this.userAnswer2.Visible = false;
            // 
            // Answer1Label
            // 
            this.Answer1Label.AutoSize = true;
            this.Answer1Label.BackColor = System.Drawing.Color.Transparent;
            this.Answer1Label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Answer1Label.Location = new System.Drawing.Point(79, 169);
            this.Answer1Label.Name = "Answer1Label";
            this.Answer1Label.Size = new System.Drawing.Size(69, 19);
            this.Answer1Label.TabIndex = 3;
            this.Answer1Label.Text = "Answer1:";
            // 
            // Answer2Label
            // 
            this.Answer2Label.AutoSize = true;
            this.Answer2Label.BackColor = System.Drawing.Color.Transparent;
            this.Answer2Label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Answer2Label.Location = new System.Drawing.Point(255, 169);
            this.Answer2Label.Name = "Answer2Label";
            this.Answer2Label.Size = new System.Drawing.Size(69, 19);
            this.Answer2Label.TabIndex = 4;
            this.Answer2Label.Text = "Answer2:";
            // 
            // RootSymbolLabel
            // 
            this.RootSymbolLabel.AutoSize = true;
            this.RootSymbolLabel.BackColor = System.Drawing.Color.Transparent;
            this.RootSymbolLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RootSymbolLabel.Location = new System.Drawing.Point(427, 178);
            this.RootSymbolLabel.Name = "RootSymbolLabel";
            this.RootSymbolLabel.Size = new System.Drawing.Size(131, 19);
            this.RootSymbolLabel.TabIndex = 8;
            this.RootSymbolLabel.Text = "Enter Root Symbol:";
            this.RootSymbolLabel.Click += new System.EventHandler(this.RootSymbolLabel_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(220, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(127, 33);
            this.TitleLabel.TabIndex = 9;
            this.TitleLabel.Text = "Question!";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PlayerTurnPicBox
            // 
            this.PlayerTurnPicBox.BackColor = System.Drawing.Color.Transparent;
            this.PlayerTurnPicBox.Location = new System.Drawing.Point(447, 8);
            this.PlayerTurnPicBox.Name = "PlayerTurnPicBox";
            this.PlayerTurnPicBox.Size = new System.Drawing.Size(42, 43);
            this.PlayerTurnPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerTurnPicBox.TabIndex = 96;
            this.PlayerTurnPicBox.TabStop = false;
            // 
            // PlayerLabel
            // 
            this.PlayerLabel.AutoSize = true;
            this.PlayerLabel.BackColor = System.Drawing.Color.Transparent;
            this.PlayerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerLabel.Location = new System.Drawing.Point(495, 18);
            this.PlayerLabel.Name = "PlayerLabel";
            this.PlayerLabel.Size = new System.Drawing.Size(79, 24);
            this.PlayerLabel.TabIndex = 94;
            this.PlayerLabel.Text = "Player1";
            // 
            // enterButton
            // 
            this.enterButton.BackColor = System.Drawing.Color.Transparent;
            this.enterButton.Image = global::test_chess.Properties.Resources.EnterButton;
            this.enterButton.Location = new System.Drawing.Point(226, 265);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(85, 47);
            this.enterButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enterButton.TabIndex = 97;
            this.enterButton.TabStop = false;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // SquareRootButton
            // 
            this.SquareRootButton.BackColor = System.Drawing.Color.Transparent;
            this.SquareRootButton.Image = global::test_chess.Properties.Resources.SqrtButton;
            this.SquareRootButton.Location = new System.Drawing.Point(462, 200);
            this.SquareRootButton.Name = "SquareRootButton";
            this.SquareRootButton.Size = new System.Drawing.Size(45, 41);
            this.SquareRootButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SquareRootButton.TabIndex = 98;
            this.SquareRootButton.TabStop = false;
            this.SquareRootButton.Click += new System.EventHandler(this.SquareRootButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Transparent;
            this.BackButton.Image = global::test_chess.Properties.Resources.BackButton;
            this.BackButton.Location = new System.Drawing.Point(12, 8);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(81, 43);
            this.BackButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackButton.TabIndex = 99;
            this.BackButton.TabStop = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AskQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::test_chess.Properties.Resources.StationaryTexture;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(586, 382);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SquareRootButton);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.PlayerTurnPicBox);
            this.Controls.Add(this.PlayerLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.RootSymbolLabel);
            this.Controls.Add(this.Answer2Label);
            this.Controls.Add(this.Answer1Label);
            this.Controls.Add(this.userAnswer2);
            this.Controls.Add(this.userAnswer1);
            this.Controls.Add(this.QuestionLabel);
            this.DoubleBuffered = true;
            this.Name = "AskQuestion";
            this.Text = "Question!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AskQuestion_FormClosing);
            this.Load += new System.EventHandler(this.AskQuestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerTurnPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SquareRootButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.RichTextBox userAnswer1;
        private System.Windows.Forms.RichTextBox userAnswer2;
        private System.Windows.Forms.Label Answer1Label;
        private System.Windows.Forms.Label Answer2Label;
        private System.Windows.Forms.Label RootSymbolLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.PictureBox PlayerTurnPicBox;
        private System.Windows.Forms.Label PlayerLabel;
        private System.Windows.Forms.PictureBox enterButton;
        private System.Windows.Forms.PictureBox SquareRootButton;
        private System.Windows.Forms.PictureBox BackButton;
    }
}