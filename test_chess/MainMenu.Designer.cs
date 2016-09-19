namespace test_chess
{
    partial class MainMenu
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
            this.Title = new System.Windows.Forms.Label();
            this.gameModeGroupBox = new System.Windows.Forms.GroupBox();
            this.TimedGame = new System.Windows.Forms.RadioButton();
            this.StandardGame = new System.Windows.Forms.RadioButton();
            this.MathsGroupBox = new System.Windows.Forms.GroupBox();
            this.NoMathsGame = new System.Windows.Forms.RadioButton();
            this.MathsGame = new System.Windows.Forms.RadioButton();
            this.Player1ColourGroupBox = new System.Windows.Forms.GroupBox();
            this.White = new System.Windows.Forms.RadioButton();
            this.Black = new System.Windows.Forms.RadioButton();
            this.MathsDiffGroupBox = new System.Windows.Forms.GroupBox();
            this.Player2MathsDifficulty = new System.Windows.Forms.NumericUpDown();
            this.Player1MathsDifficulty = new System.Windows.Forms.NumericUpDown();
            this.Player2Label = new System.Windows.Forms.Label();
            this.Player1Label = new System.Windows.Forms.Label();
            this.TimerGroupBox = new System.Windows.Forms.GroupBox();
            this.timerValue = new System.Windows.Forms.NumericUpDown();
            this.TimerValueLabel = new System.Windows.Forms.Label();
            this.GameBoardStyleGroupBox = new System.Windows.Forms.GroupBox();
            this.PlainPurpleStyle = new System.Windows.Forms.RadioButton();
            this.PlainBrownStyle = new System.Windows.Forms.RadioButton();
            this.PlainRedStyle = new System.Windows.Forms.RadioButton();
            this.PlainBlueStyle = new System.Windows.Forms.RadioButton();
            this.MarbleStyle = new System.Windows.Forms.RadioButton();
            this.WoodStyle = new System.Windows.Forms.RadioButton();
            this.PlayButton = new System.Windows.Forms.PictureBox();
            this.AdminButton = new System.Windows.Forms.PictureBox();
            this.gameModeGroupBox.SuspendLayout();
            this.MathsGroupBox.SuspendLayout();
            this.Player1ColourGroupBox.SuspendLayout();
            this.MathsDiffGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player2MathsDifficulty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1MathsDifficulty)).BeginInit();
            this.TimerGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timerValue)).BeginInit();
            this.GameBoardStyleGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdminButton)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(312, 18);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(171, 39);
            this.Title.TabIndex = 0;
            this.Title.Text = "Main Menu";
            // 
            // gameModeGroupBox
            // 
            this.gameModeGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.gameModeGroupBox.Controls.Add(this.TimedGame);
            this.gameModeGroupBox.Controls.Add(this.StandardGame);
            this.gameModeGroupBox.Location = new System.Drawing.Point(46, 75);
            this.gameModeGroupBox.Name = "gameModeGroupBox";
            this.gameModeGroupBox.Size = new System.Drawing.Size(331, 121);
            this.gameModeGroupBox.TabIndex = 1;
            this.gameModeGroupBox.TabStop = false;
            this.gameModeGroupBox.Text = "Please select a game mode...";
            // 
            // TimedGame
            // 
            this.TimedGame.BackColor = System.Drawing.Color.Transparent;
            this.TimedGame.BackgroundImage = global::test_chess.Properties.Resources.TimedGameButton;
            this.TimedGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TimedGame.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.TimedGame.Location = new System.Drawing.Point(193, 19);
            this.TimedGame.Name = "TimedGame";
            this.TimedGame.Size = new System.Drawing.Size(103, 96);
            this.TimedGame.TabIndex = 8;
            this.TimedGame.TabStop = true;
            this.TimedGame.UseVisualStyleBackColor = false;
            this.TimedGame.CheckedChanged += new System.EventHandler(this.TimedGame_CheckedChanged);
            // 
            // StandardGame
            // 
            this.StandardGame.BackColor = System.Drawing.Color.Transparent;
            this.StandardGame.BackgroundImage = global::test_chess.Properties.Resources.StandardButton;
            this.StandardGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StandardGame.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.StandardGame.Location = new System.Drawing.Point(19, 19);
            this.StandardGame.Name = "StandardGame";
            this.StandardGame.Size = new System.Drawing.Size(103, 96);
            this.StandardGame.TabIndex = 7;
            this.StandardGame.TabStop = true;
            this.StandardGame.UseVisualStyleBackColor = false;
            this.StandardGame.CheckedChanged += new System.EventHandler(this.StandardGame_CheckedChanged_1);
            // 
            // MathsGroupBox
            // 
            this.MathsGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.MathsGroupBox.Controls.Add(this.NoMathsGame);
            this.MathsGroupBox.Controls.Add(this.MathsGame);
            this.MathsGroupBox.Location = new System.Drawing.Point(46, 216);
            this.MathsGroupBox.Name = "MathsGroupBox";
            this.MathsGroupBox.Size = new System.Drawing.Size(331, 121);
            this.MathsGroupBox.TabIndex = 3;
            this.MathsGroupBox.TabStop = false;
            this.MathsGroupBox.Text = "Maths?";
            // 
            // NoMathsGame
            // 
            this.NoMathsGame.BackColor = System.Drawing.Color.Transparent;
            this.NoMathsGame.BackgroundImage = global::test_chess.Properties.Resources.NoMathsButton;
            this.NoMathsGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NoMathsGame.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.NoMathsGame.Location = new System.Drawing.Point(193, 10);
            this.NoMathsGame.Name = "NoMathsGame";
            this.NoMathsGame.Size = new System.Drawing.Size(123, 105);
            this.NoMathsGame.TabIndex = 12;
            this.NoMathsGame.TabStop = true;
            this.NoMathsGame.UseVisualStyleBackColor = false;
            this.NoMathsGame.CheckedChanged += new System.EventHandler(this.NoMathsGame_CheckedChanged);
            // 
            // MathsGame
            // 
            this.MathsGame.BackColor = System.Drawing.Color.Transparent;
            this.MathsGame.BackgroundImage = global::test_chess.Properties.Resources.MathsButton;
            this.MathsGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MathsGame.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.MathsGame.Location = new System.Drawing.Point(19, 10);
            this.MathsGame.Name = "MathsGame";
            this.MathsGame.Size = new System.Drawing.Size(123, 105);
            this.MathsGame.TabIndex = 11;
            this.MathsGame.TabStop = true;
            this.MathsGame.UseVisualStyleBackColor = false;
            this.MathsGame.CheckedChanged += new System.EventHandler(this.MathsGame_CheckedChanged);
            // 
            // Player1ColourGroupBox
            // 
            this.Player1ColourGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.Player1ColourGroupBox.Controls.Add(this.White);
            this.Player1ColourGroupBox.Controls.Add(this.Black);
            this.Player1ColourGroupBox.Location = new System.Drawing.Point(412, 75);
            this.Player1ColourGroupBox.Name = "Player1ColourGroupBox";
            this.Player1ColourGroupBox.Size = new System.Drawing.Size(331, 121);
            this.Player1ColourGroupBox.TabIndex = 4;
            this.Player1ColourGroupBox.TabStop = false;
            this.Player1ColourGroupBox.Text = "Player 1 Colour...";
            // 
            // White
            // 
            this.White.BackColor = System.Drawing.Color.Transparent;
            this.White.BackgroundImage = global::test_chess.Properties.Resources.WhiteButton;
            this.White.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.White.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.White.Location = new System.Drawing.Point(199, 14);
            this.White.Name = "White";
            this.White.Size = new System.Drawing.Size(103, 96);
            this.White.TabIndex = 12;
            this.White.TabStop = true;
            this.White.UseVisualStyleBackColor = false;
            this.White.CheckedChanged += new System.EventHandler(this.White_CheckedChanged);
            // 
            // Black
            // 
            this.Black.BackColor = System.Drawing.Color.Transparent;
            this.Black.BackgroundImage = global::test_chess.Properties.Resources.BlackButton;
            this.Black.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Black.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Black.Location = new System.Drawing.Point(38, 14);
            this.Black.Name = "Black";
            this.Black.Size = new System.Drawing.Size(103, 96);
            this.Black.TabIndex = 11;
            this.Black.TabStop = true;
            this.Black.UseVisualStyleBackColor = false;
            this.Black.CheckedChanged += new System.EventHandler(this.Black_CheckedChanged);
            // 
            // MathsDiffGroupBox
            // 
            this.MathsDiffGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.MathsDiffGroupBox.Controls.Add(this.Player2MathsDifficulty);
            this.MathsDiffGroupBox.Controls.Add(this.Player1MathsDifficulty);
            this.MathsDiffGroupBox.Controls.Add(this.Player2Label);
            this.MathsDiffGroupBox.Controls.Add(this.Player1Label);
            this.MathsDiffGroupBox.Location = new System.Drawing.Point(46, 352);
            this.MathsDiffGroupBox.Name = "MathsDiffGroupBox";
            this.MathsDiffGroupBox.Size = new System.Drawing.Size(331, 121);
            this.MathsDiffGroupBox.TabIndex = 5;
            this.MathsDiffGroupBox.TabStop = false;
            this.MathsDiffGroupBox.Text = "Maths Difficulty Level...";
            // 
            // Player2MathsDifficulty
            // 
            this.Player2MathsDifficulty.Location = new System.Drawing.Point(193, 68);
            this.Player2MathsDifficulty.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.Player2MathsDifficulty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Player2MathsDifficulty.Name = "Player2MathsDifficulty";
            this.Player2MathsDifficulty.Size = new System.Drawing.Size(120, 20);
            this.Player2MathsDifficulty.TabIndex = 10;
            this.Player2MathsDifficulty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Player1MathsDifficulty
            // 
            this.Player1MathsDifficulty.Location = new System.Drawing.Point(193, 27);
            this.Player1MathsDifficulty.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.Player1MathsDifficulty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Player1MathsDifficulty.Name = "Player1MathsDifficulty";
            this.Player1MathsDifficulty.Size = new System.Drawing.Size(120, 20);
            this.Player1MathsDifficulty.TabIndex = 9;
            this.Player1MathsDifficulty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Player2Label
            // 
            this.Player2Label.AutoSize = true;
            this.Player2Label.BackColor = System.Drawing.Color.Transparent;
            this.Player2Label.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2Label.Location = new System.Drawing.Point(15, 66);
            this.Player2Label.Name = "Player2Label";
            this.Player2Label.Size = new System.Drawing.Size(82, 22);
            this.Player2Label.TabIndex = 8;
            this.Player2Label.Text = "Player 2:";
            // 
            // Player1Label
            // 
            this.Player1Label.AutoSize = true;
            this.Player1Label.BackColor = System.Drawing.Color.Transparent;
            this.Player1Label.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1Label.Location = new System.Drawing.Point(15, 26);
            this.Player1Label.Name = "Player1Label";
            this.Player1Label.Size = new System.Drawing.Size(82, 22);
            this.Player1Label.TabIndex = 7;
            this.Player1Label.Text = "Player 1:";
            // 
            // TimerGroupBox
            // 
            this.TimerGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.TimerGroupBox.Controls.Add(this.timerValue);
            this.TimerGroupBox.Controls.Add(this.TimerValueLabel);
            this.TimerGroupBox.Location = new System.Drawing.Point(46, 494);
            this.TimerGroupBox.Name = "TimerGroupBox";
            this.TimerGroupBox.Size = new System.Drawing.Size(331, 77);
            this.TimerGroupBox.TabIndex = 6;
            this.TimerGroupBox.TabStop = false;
            this.TimerGroupBox.Text = "Timer Value...";
            // 
            // timerValue
            // 
            this.timerValue.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.timerValue.Location = new System.Drawing.Point(193, 36);
            this.timerValue.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.timerValue.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.timerValue.Name = "timerValue";
            this.timerValue.Size = new System.Drawing.Size(120, 20);
            this.timerValue.TabIndex = 12;
            this.timerValue.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // TimerValueLabel
            // 
            this.TimerValueLabel.AutoSize = true;
            this.TimerValueLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimerValueLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerValueLabel.Location = new System.Drawing.Point(15, 35);
            this.TimerValueLabel.Name = "TimerValueLabel";
            this.TimerValueLabel.Size = new System.Drawing.Size(115, 22);
            this.TimerValueLabel.TabIndex = 11;
            this.TimerValueLabel.Text = "Timer Value:";
            // 
            // GameBoardStyleGroupBox
            // 
            this.GameBoardStyleGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.GameBoardStyleGroupBox.Controls.Add(this.PlainPurpleStyle);
            this.GameBoardStyleGroupBox.Controls.Add(this.PlainBrownStyle);
            this.GameBoardStyleGroupBox.Controls.Add(this.PlainRedStyle);
            this.GameBoardStyleGroupBox.Controls.Add(this.PlainBlueStyle);
            this.GameBoardStyleGroupBox.Controls.Add(this.MarbleStyle);
            this.GameBoardStyleGroupBox.Controls.Add(this.WoodStyle);
            this.GameBoardStyleGroupBox.Location = new System.Drawing.Point(412, 216);
            this.GameBoardStyleGroupBox.Name = "GameBoardStyleGroupBox";
            this.GameBoardStyleGroupBox.Size = new System.Drawing.Size(331, 335);
            this.GameBoardStyleGroupBox.TabIndex = 5;
            this.GameBoardStyleGroupBox.TabStop = false;
            this.GameBoardStyleGroupBox.Text = "GameBoard Style...";
            // 
            // PlainPurpleStyle
            // 
            this.PlainPurpleStyle.BackColor = System.Drawing.Color.Transparent;
            this.PlainPurpleStyle.BackgroundImage = global::test_chess.Properties.Resources.PlainPurpleStyleButton;
            this.PlainPurpleStyle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlainPurpleStyle.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.PlainPurpleStyle.Location = new System.Drawing.Point(199, 233);
            this.PlainPurpleStyle.Name = "PlainPurpleStyle";
            this.PlainPurpleStyle.Size = new System.Drawing.Size(103, 96);
            this.PlainPurpleStyle.TabIndex = 18;
            this.PlainPurpleStyle.TabStop = true;
            this.PlainPurpleStyle.UseVisualStyleBackColor = false;
            this.PlainPurpleStyle.CheckedChanged += new System.EventHandler(this.PlainPurpleStyle_CheckedChanged);
            // 
            // PlainBrownStyle
            // 
            this.PlainBrownStyle.BackColor = System.Drawing.Color.Transparent;
            this.PlainBrownStyle.BackgroundImage = global::test_chess.Properties.Resources.PlainBrownStyleButton;
            this.PlainBrownStyle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlainBrownStyle.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.PlainBrownStyle.Location = new System.Drawing.Point(38, 233);
            this.PlainBrownStyle.Name = "PlainBrownStyle";
            this.PlainBrownStyle.Size = new System.Drawing.Size(103, 96);
            this.PlainBrownStyle.TabIndex = 17;
            this.PlainBrownStyle.TabStop = true;
            this.PlainBrownStyle.UseVisualStyleBackColor = false;
            this.PlainBrownStyle.CheckedChanged += new System.EventHandler(this.PlainBrownStyle_CheckedChanged);
            // 
            // PlainRedStyle
            // 
            this.PlainRedStyle.BackColor = System.Drawing.Color.Transparent;
            this.PlainRedStyle.BackgroundImage = global::test_chess.Properties.Resources.PlainRedStyleButton;
            this.PlainRedStyle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlainRedStyle.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.PlainRedStyle.Location = new System.Drawing.Point(199, 128);
            this.PlainRedStyle.Name = "PlainRedStyle";
            this.PlainRedStyle.Size = new System.Drawing.Size(103, 96);
            this.PlainRedStyle.TabIndex = 16;
            this.PlainRedStyle.TabStop = true;
            this.PlainRedStyle.UseVisualStyleBackColor = false;
            this.PlainRedStyle.CheckedChanged += new System.EventHandler(this.PlainRedStyle_CheckedChanged);
            // 
            // PlainBlueStyle
            // 
            this.PlainBlueStyle.BackColor = System.Drawing.Color.Transparent;
            this.PlainBlueStyle.BackgroundImage = global::test_chess.Properties.Resources.PlainBlueStyleButton;
            this.PlainBlueStyle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlainBlueStyle.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.PlainBlueStyle.Location = new System.Drawing.Point(38, 128);
            this.PlainBlueStyle.Name = "PlainBlueStyle";
            this.PlainBlueStyle.Size = new System.Drawing.Size(103, 96);
            this.PlainBlueStyle.TabIndex = 15;
            this.PlainBlueStyle.TabStop = true;
            this.PlainBlueStyle.UseVisualStyleBackColor = false;
            this.PlainBlueStyle.CheckedChanged += new System.EventHandler(this.PlainBlueStyle_CheckedChanged);
            // 
            // MarbleStyle
            // 
            this.MarbleStyle.BackColor = System.Drawing.Color.Transparent;
            this.MarbleStyle.BackgroundImage = global::test_chess.Properties.Resources.MarbleStyleButton;
            this.MarbleStyle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MarbleStyle.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.MarbleStyle.Location = new System.Drawing.Point(199, 19);
            this.MarbleStyle.Name = "MarbleStyle";
            this.MarbleStyle.Size = new System.Drawing.Size(103, 96);
            this.MarbleStyle.TabIndex = 14;
            this.MarbleStyle.TabStop = true;
            this.MarbleStyle.UseVisualStyleBackColor = false;
            this.MarbleStyle.CheckedChanged += new System.EventHandler(this.MarbleStyle_CheckedChanged);
            // 
            // WoodStyle
            // 
            this.WoodStyle.BackColor = System.Drawing.Color.Transparent;
            this.WoodStyle.BackgroundImage = global::test_chess.Properties.Resources.WoodStyleButton;
            this.WoodStyle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WoodStyle.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.WoodStyle.Location = new System.Drawing.Point(38, 19);
            this.WoodStyle.Name = "WoodStyle";
            this.WoodStyle.Size = new System.Drawing.Size(103, 96);
            this.WoodStyle.TabIndex = 13;
            this.WoodStyle.TabStop = true;
            this.WoodStyle.UseVisualStyleBackColor = false;
            this.WoodStyle.CheckedChanged += new System.EventHandler(this.WoodStyle_CheckedChanged);
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.Color.Transparent;
            this.PlayButton.Image = global::test_chess.Properties.Resources.PlayButton;
            this.PlayButton.Location = new System.Drawing.Point(512, 557);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(127, 66);
            this.PlayButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayButton.TabIndex = 8;
            this.PlayButton.TabStop = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // AdminButton
            // 
            this.AdminButton.BackColor = System.Drawing.Color.Transparent;
            this.AdminButton.Image = global::test_chess.Properties.Resources.AdminButton;
            this.AdminButton.Location = new System.Drawing.Point(41, 586);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Size = new System.Drawing.Size(127, 66);
            this.AdminButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AdminButton.TabIndex = 9;
            this.AdminButton.TabStop = false;
            this.AdminButton.Click += new System.EventHandler(this.AdminButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::test_chess.Properties.Resources.StationaryTexture;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(790, 664);
            this.Controls.Add(this.AdminButton);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.GameBoardStyleGroupBox);
            this.Controls.Add(this.TimerGroupBox);
            this.Controls.Add(this.MathsDiffGroupBox);
            this.Controls.Add(this.Player1ColourGroupBox);
            this.Controls.Add(this.MathsGroupBox);
            this.Controls.Add(this.gameModeGroupBox);
            this.Controls.Add(this.Title);
            this.DoubleBuffered = true;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.gameModeGroupBox.ResumeLayout(false);
            this.MathsGroupBox.ResumeLayout(false);
            this.Player1ColourGroupBox.ResumeLayout(false);
            this.MathsDiffGroupBox.ResumeLayout(false);
            this.MathsDiffGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player2MathsDifficulty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1MathsDifficulty)).EndInit();
            this.TimerGroupBox.ResumeLayout(false);
            this.TimerGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timerValue)).EndInit();
            this.GameBoardStyleGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PlayButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdminButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.GroupBox gameModeGroupBox;
        private System.Windows.Forms.RadioButton StandardGame;
        private System.Windows.Forms.GroupBox MathsGroupBox;
        private System.Windows.Forms.GroupBox Player1ColourGroupBox;
        private System.Windows.Forms.GroupBox MathsDiffGroupBox;
        private System.Windows.Forms.GroupBox TimerGroupBox;
        private System.Windows.Forms.GroupBox GameBoardStyleGroupBox;
        private System.Windows.Forms.RadioButton TimedGame;
        private System.Windows.Forms.RadioButton MathsGame;
        private System.Windows.Forms.RadioButton NoMathsGame;
        private System.Windows.Forms.RadioButton Black;
        private System.Windows.Forms.RadioButton White;
        private System.Windows.Forms.NumericUpDown Player2MathsDifficulty;
        private System.Windows.Forms.NumericUpDown Player1MathsDifficulty;
        private System.Windows.Forms.Label Player2Label;
        private System.Windows.Forms.Label Player1Label;
        private System.Windows.Forms.NumericUpDown timerValue;
        private System.Windows.Forms.Label TimerValueLabel;
        private System.Windows.Forms.RadioButton MarbleStyle;
        private System.Windows.Forms.RadioButton WoodStyle;
        private System.Windows.Forms.PictureBox PlayButton;
        private System.Windows.Forms.RadioButton PlainBlueStyle;
        private System.Windows.Forms.RadioButton PlainRedStyle;
        private System.Windows.Forms.RadioButton PlainBrownStyle;
        private System.Windows.Forms.RadioButton PlainPurpleStyle;
        private System.Windows.Forms.PictureBox AdminButton;
    }
}