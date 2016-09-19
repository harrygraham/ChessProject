namespace test_chess
{
    partial class ViewQuestions
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
            this.AdminLogoPicture = new System.Windows.Forms.PictureBox();
            this.BackButton = new System.Windows.Forms.PictureBox();
            this.ViewQuestionsTitle = new System.Windows.Forms.Label();
            this.QuestionTextList = new System.Windows.Forms.ListBox();
            this.QuestionsLabel = new System.Windows.Forms.Label();
            this.Answer1Box = new System.Windows.Forms.RichTextBox();
            this.Answer2Box = new System.Windows.Forms.RichTextBox();
            this.DifficultyBox = new System.Windows.Forms.RichTextBox();
            this.Answer1Label = new System.Windows.Forms.Label();
            this.Answer2Label = new System.Windows.Forms.Label();
            this.DifficultyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AdminLogoPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminLogoPicture
            // 
            this.AdminLogoPicture.BackColor = System.Drawing.Color.Transparent;
            this.AdminLogoPicture.Image = global::test_chess.Properties.Resources.AdminLogo;
            this.AdminLogoPicture.Location = new System.Drawing.Point(450, 12);
            this.AdminLogoPicture.Name = "AdminLogoPicture";
            this.AdminLogoPicture.Size = new System.Drawing.Size(61, 57);
            this.AdminLogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AdminLogoPicture.TabIndex = 119;
            this.AdminLogoPicture.TabStop = false;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Transparent;
            this.BackButton.Image = global::test_chess.Properties.Resources.BackButton;
            this.BackButton.Location = new System.Drawing.Point(12, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(81, 43);
            this.BackButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackButton.TabIndex = 118;
            this.BackButton.TabStop = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ViewQuestionsTitle
            // 
            this.ViewQuestionsTitle.AutoSize = true;
            this.ViewQuestionsTitle.BackColor = System.Drawing.Color.Transparent;
            this.ViewQuestionsTitle.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewQuestionsTitle.Location = new System.Drawing.Point(165, 16);
            this.ViewQuestionsTitle.Name = "ViewQuestionsTitle";
            this.ViewQuestionsTitle.Size = new System.Drawing.Size(225, 39);
            this.ViewQuestionsTitle.TabIndex = 117;
            this.ViewQuestionsTitle.Text = "View Questions";
            // 
            // QuestionTextList
            // 
            this.QuestionTextList.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionTextList.FormattingEnabled = true;
            this.QuestionTextList.ItemHeight = 23;
            this.QuestionTextList.Location = new System.Drawing.Point(27, 99);
            this.QuestionTextList.Name = "QuestionTextList";
            this.QuestionTextList.Size = new System.Drawing.Size(231, 211);
            this.QuestionTextList.TabIndex = 120;
            this.QuestionTextList.SelectedValueChanged += new System.EventHandler(this.QuestionTextList_SelectedValueChanged);
            // 
            // QuestionsLabel
            // 
            this.QuestionsLabel.AutoSize = true;
            this.QuestionsLabel.BackColor = System.Drawing.Color.Transparent;
            this.QuestionsLabel.Location = new System.Drawing.Point(36, 83);
            this.QuestionsLabel.Name = "QuestionsLabel";
            this.QuestionsLabel.Size = new System.Drawing.Size(57, 13);
            this.QuestionsLabel.TabIndex = 121;
            this.QuestionsLabel.Text = "Questions:";
            // 
            // Answer1Box
            // 
            this.Answer1Box.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Answer1Box.Location = new System.Drawing.Point(316, 125);
            this.Answer1Box.Name = "Answer1Box";
            this.Answer1Box.Size = new System.Drawing.Size(135, 37);
            this.Answer1Box.TabIndex = 122;
            this.Answer1Box.Text = "";
            // 
            // Answer2Box
            // 
            this.Answer2Box.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Answer2Box.Location = new System.Drawing.Point(316, 190);
            this.Answer2Box.Name = "Answer2Box";
            this.Answer2Box.Size = new System.Drawing.Size(135, 37);
            this.Answer2Box.TabIndex = 123;
            this.Answer2Box.Text = "";
            // 
            // DifficultyBox
            // 
            this.DifficultyBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DifficultyBox.Location = new System.Drawing.Point(316, 255);
            this.DifficultyBox.Name = "DifficultyBox";
            this.DifficultyBox.Size = new System.Drawing.Size(135, 37);
            this.DifficultyBox.TabIndex = 124;
            this.DifficultyBox.Text = "";
            // 
            // Answer1Label
            // 
            this.Answer1Label.AutoSize = true;
            this.Answer1Label.BackColor = System.Drawing.Color.Transparent;
            this.Answer1Label.Location = new System.Drawing.Point(313, 109);
            this.Answer1Label.Name = "Answer1Label";
            this.Answer1Label.Size = new System.Drawing.Size(54, 13);
            this.Answer1Label.TabIndex = 125;
            this.Answer1Label.Text = "Answer 1:";
            // 
            // Answer2Label
            // 
            this.Answer2Label.AutoSize = true;
            this.Answer2Label.BackColor = System.Drawing.Color.Transparent;
            this.Answer2Label.Location = new System.Drawing.Point(313, 174);
            this.Answer2Label.Name = "Answer2Label";
            this.Answer2Label.Size = new System.Drawing.Size(54, 13);
            this.Answer2Label.TabIndex = 126;
            this.Answer2Label.Text = "Answer 2:";
            // 
            // DifficultyLabel
            // 
            this.DifficultyLabel.AutoSize = true;
            this.DifficultyLabel.BackColor = System.Drawing.Color.Transparent;
            this.DifficultyLabel.Location = new System.Drawing.Point(313, 239);
            this.DifficultyLabel.Name = "DifficultyLabel";
            this.DifficultyLabel.Size = new System.Drawing.Size(50, 13);
            this.DifficultyLabel.TabIndex = 127;
            this.DifficultyLabel.Text = "Difficulty:";
            // 
            // ViewQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::test_chess.Properties.Resources.StationaryTexture;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(533, 357);
            this.Controls.Add(this.DifficultyLabel);
            this.Controls.Add(this.Answer2Label);
            this.Controls.Add(this.Answer1Label);
            this.Controls.Add(this.DifficultyBox);
            this.Controls.Add(this.Answer2Box);
            this.Controls.Add(this.Answer1Box);
            this.Controls.Add(this.QuestionsLabel);
            this.Controls.Add(this.QuestionTextList);
            this.Controls.Add(this.AdminLogoPicture);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ViewQuestionsTitle);
            this.DoubleBuffered = true;
            this.Name = "ViewQuestions";
            this.Text = "ViewQuestions";
            ((System.ComponentModel.ISupportInitialize)(this.AdminLogoPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox AdminLogoPicture;
        private System.Windows.Forms.PictureBox BackButton;
        private System.Windows.Forms.Label ViewQuestionsTitle;
        private System.Windows.Forms.ListBox QuestionTextList;
        private System.Windows.Forms.Label QuestionsLabel;
        private System.Windows.Forms.RichTextBox Answer1Box;
        private System.Windows.Forms.RichTextBox Answer2Box;
        private System.Windows.Forms.RichTextBox DifficultyBox;
        private System.Windows.Forms.Label Answer1Label;
        private System.Windows.Forms.Label Answer2Label;
        private System.Windows.Forms.Label DifficultyLabel;
    }
}