namespace test_chess
{
    partial class PromotePawn
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
            this.BishopButton = new System.Windows.Forms.RadioButton();
            this.RookButton = new System.Windows.Forms.RadioButton();
            this.QueenButton = new System.Windows.Forms.RadioButton();
            this.KnightButton = new System.Windows.Forms.RadioButton();
            this.Title = new System.Windows.Forms.Label();
            this.PromoteButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PromoteButton)).BeginInit();
            this.SuspendLayout();
            // 
            // BishopButton
            // 
            this.BishopButton.BackColor = System.Drawing.Color.Transparent;
            this.BishopButton.BackgroundImage = global::test_chess.Properties.Resources.BishopButton;
            this.BishopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BishopButton.Location = new System.Drawing.Point(98, 117);
            this.BishopButton.Name = "BishopButton";
            this.BishopButton.Size = new System.Drawing.Size(111, 96);
            this.BishopButton.TabIndex = 0;
            this.BishopButton.TabStop = true;
            this.BishopButton.UseVisualStyleBackColor = false;
            this.BishopButton.CheckedChanged += new System.EventHandler(this.BishopButton_CheckedChanged);
            // 
            // RookButton
            // 
            this.RookButton.BackColor = System.Drawing.Color.Transparent;
            this.RookButton.BackgroundImage = global::test_chess.Properties.Resources.RookButton;
            this.RookButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RookButton.Location = new System.Drawing.Point(278, 117);
            this.RookButton.Name = "RookButton";
            this.RookButton.Size = new System.Drawing.Size(111, 96);
            this.RookButton.TabIndex = 1;
            this.RookButton.TabStop = true;
            this.RookButton.UseVisualStyleBackColor = false;
            this.RookButton.CheckedChanged += new System.EventHandler(this.RookButton_CheckedChanged);
            // 
            // QueenButton
            // 
            this.QueenButton.BackColor = System.Drawing.Color.Transparent;
            this.QueenButton.BackgroundImage = global::test_chess.Properties.Resources.QueenButton;
            this.QueenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.QueenButton.Location = new System.Drawing.Point(454, 117);
            this.QueenButton.Name = "QueenButton";
            this.QueenButton.Size = new System.Drawing.Size(111, 96);
            this.QueenButton.TabIndex = 2;
            this.QueenButton.TabStop = true;
            this.QueenButton.UseVisualStyleBackColor = false;
            this.QueenButton.CheckedChanged += new System.EventHandler(this.QueenButton_CheckedChanged);
            // 
            // KnightButton
            // 
            this.KnightButton.BackColor = System.Drawing.Color.Transparent;
            this.KnightButton.BackgroundImage = global::test_chess.Properties.Resources.KnightButton;
            this.KnightButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.KnightButton.Location = new System.Drawing.Point(633, 117);
            this.KnightButton.Name = "KnightButton";
            this.KnightButton.Size = new System.Drawing.Size(111, 96);
            this.KnightButton.TabIndex = 3;
            this.KnightButton.TabStop = true;
            this.KnightButton.UseVisualStyleBackColor = false;
            this.KnightButton.CheckedChanged += new System.EventHandler(this.KnightButton_CheckedChanged);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Times New Roman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(314, 32);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(224, 33);
            this.Title.TabIndex = 4;
            this.Title.Text = "Promote a Pawn!";
            // 
            // PromoteButton
            // 
            this.PromoteButton.BackColor = System.Drawing.Color.Transparent;
            this.PromoteButton.Image = global::test_chess.Properties.Resources.PromoteButton;
            this.PromoteButton.Location = new System.Drawing.Point(348, 254);
            this.PromoteButton.Name = "PromoteButton";
            this.PromoteButton.Size = new System.Drawing.Size(151, 73);
            this.PromoteButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PromoteButton.TabIndex = 5;
            this.PromoteButton.TabStop = false;
            this.PromoteButton.Click += new System.EventHandler(this.PromoteButton_Click);
            // 
            // PromotePawn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::test_chess.Properties.Resources.StationaryTexture;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(872, 373);
            this.Controls.Add(this.PromoteButton);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.KnightButton);
            this.Controls.Add(this.QueenButton);
            this.Controls.Add(this.RookButton);
            this.Controls.Add(this.BishopButton);
            this.DoubleBuffered = true;
            this.Name = "PromotePawn";
            this.Text = "PromotePawn";
            this.Load += new System.EventHandler(this.PromotePawn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PromoteButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton BishopButton;
        private System.Windows.Forms.RadioButton RookButton;
        private System.Windows.Forms.RadioButton QueenButton;
        private System.Windows.Forms.RadioButton KnightButton;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.PictureBox PromoteButton;
    }
}