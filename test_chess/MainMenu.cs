using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace test_chess
{
    public partial class MainMenu : Form
    {
        // the game board form which will be loaded when the play button is clicked
        BoardUI gameBoardForm;

        public MainMenu()
        {
            InitializeComponent();
            // sets these controls to not enabled as they are not immediately accessbile until other selections have been made
            MathsDiffGroupBox.Visible = false;
            MathsGroupBox.Visible = false;
            TimerGroupBox.Visible = false;

            Player1MathsDifficulty.ReadOnly = true;
            Player2MathsDifficulty.ReadOnly = true;
            timerValue.ReadOnly = true;

            Player1MathsDifficulty.BackColor = Color.White;
            Player2MathsDifficulty.BackColor = Color.White;
            timerValue.BackColor = Color.White;

           

            // gathers the questions from the text file on the sever and stores the contents in question objects in the system.
            GatherQuestionsInputFromFile();

           
        }

        // selections are shown with green highlighting
        private void StandardGame_CheckedChanged_1(object sender, EventArgs e)
        {
            if (StandardGame.Checked == true)
            {
                StandardGame.BackgroundImage = test_chess.Properties.Resources.StandardButton_GreenBorder;

            }
            else
            {
                StandardGame.BackgroundImage = test_chess.Properties.Resources.StandardButton;
            }
        }

        private void TimedGame_CheckedChanged(object sender, EventArgs e)
        {
           
            if (TimedGame.Checked == true)
            {
                TimedGame.BackgroundImage = test_chess.Properties.Resources.TimedGameButton_GreenBorder;
                MathsGroupBox.Visible = true;
                TimerGroupBox.Visible = true;
                if (MathsGame.Checked == true)
                {

                    MathsDiffGroupBox.Visible = true;
                }
            }
            else
            {
                TimedGame.BackgroundImage = test_chess.Properties.Resources.TimedGameButton;
                MathsGroupBox.Visible = false;
                TimerGroupBox.Visible = false;
                MathsDiffGroupBox.Visible = false;
            }
        }


      
        private void MathsGame_CheckedChanged(object sender, EventArgs e)
        {
            
            if (MathsGame.Checked == true)
            {
                MathsGame.BackgroundImage = test_chess.Properties.Resources.MathsButton_GreenBorder;
                MathsDiffGroupBox.Visible = true;
            }
            else
            {
                MathsGame.BackgroundImage = test_chess.Properties.Resources.MathsButton;
                MathsDiffGroupBox.Visible = false;
            }
        }

        private void NoMathsGame_CheckedChanged(object sender, EventArgs e)
        {
            
            if (NoMathsGame.Checked == true)
            {
                NoMathsGame.BackgroundImage = test_chess.Properties.Resources.NoMathsButton_GreenBorder;
            }
            else
            {
                NoMathsGame.BackgroundImage = test_chess.Properties.Resources.NoMathsButton;
            }
        }

        private void Black_CheckedChanged(object sender, EventArgs e)
        {
            if (Black.Checked == true)
            {
                Black.BackgroundImage = test_chess.Properties.Resources.BlackButton_GreenBorder;
            }
            else
            {
                Black.BackgroundImage = test_chess.Properties.Resources.BlackButton;

            }
        }

        private void White_CheckedChanged(object sender, EventArgs e)
        {
            
            if (White.Checked == true)
            {
                White.BackgroundImage = test_chess.Properties.Resources.WhiteButton_GreenBorder;
            }
            else
            {
                White.BackgroundImage = test_chess.Properties.Resources.WhiteButton;

            }
        }

        private void WoodStyle_CheckedChanged(object sender, EventArgs e)
        {
            if (WoodStyle.Checked == true)
            {
                WoodStyle.BackgroundImage = test_chess.Properties.Resources.WoodStyleButton_GreenBorder;
            }
            else
            {
                WoodStyle.BackgroundImage = test_chess.Properties.Resources.WoodStyleButton;

            }
        }

        private void MarbleStyle_CheckedChanged(object sender, EventArgs e)
        {
            if (MarbleStyle.Checked == true)
            {
                MarbleStyle.BackgroundImage = test_chess.Properties.Resources.MarbleStyleButton_GreenBorder;
            }
            else
            {
                MarbleStyle.BackgroundImage = test_chess.Properties.Resources.MarbleStyleButton;

            }
        }


       
        // sets the game object and populates it accordingly 
        private void PlayButton_Click(object sender, EventArgs e)
        {
            Game game1;
            String gameStyle = "NULL";
            Piece.Piececolour player1Colour = Piece.Piececolour.BLACK ;

            //sets properties of game object depending on which game mode has been selected
            if (StandardGame.Checked == true)
            {
                game1 = new StandardGame();
                if (ValidateSelection(ref player1Colour, ref gameStyle) == true)
                {
                    game1.setGameType(Game.gameType.Standard);
                    BoardAdmin.game1 = game1;
                    BoardAdmin.gameStyle = gameStyle;
                    BoardAdmin.player1Colour = player1Colour;
                    gameBoardForm  = new BoardUI();
                    gameBoardForm.Show();
                    
                }
            }
            else
            {
                if(MathsGame.Checked == true)
                {
                    game1 = new MathsGame();
                    if (ValidateSelection(ref player1Colour, ref gameStyle) == true)
                    {
                        game1.setGameType(Game.gameType.Maths);
                        game1.setTimerValue((int)timerValue.Value);
                        BoardAdmin.game1 = game1;
                        BoardAdmin.gameStyle = gameStyle;
                        BoardAdmin.player1Colour = player1Colour;
                        BoardAdmin.player1Diff = (int)Player1MathsDifficulty.Value;
                        BoardAdmin.player2Diff = (int)Player2MathsDifficulty.Value;
                        BoardUI gameBoardForm = new BoardUI();
                        gameBoardForm.Show();

                    }
                    
                }
                if (NoMathsGame.Checked == true)
                {
                    game1 = new TimedGame();
                    if (ValidateSelection(ref player1Colour, ref gameStyle) == true)
                    {
                        game1.setGameType(Game.gameType.Timed);
                        game1.setTimerValue((int)timerValue.Value);
                        BoardAdmin.game1 = game1;
                        BoardAdmin.gameStyle = gameStyle;
                        BoardAdmin.player1Colour = player1Colour;
                        BoardUI gameBoardForm = new BoardUI();
                        gameBoardForm.Show();

                    }
                    
                }
                if (MathsGame.Checked == false && NoMathsGame.Checked == false)
                {
                    System.Windows.Forms.MessageBox.Show("Please select an Option for a maths game");
                }



            }

            

            

        }
        // makes sure that all the neccessary selections have been made
        private bool ValidateSelection(ref Piece.Piececolour player1Colour, ref String gameStyle)
        {
            if (Black.Checked == false && White.Checked == false)
            {
                System.Windows.Forms.MessageBox.Show("Please select an Option for Player1 Colour");
                return false;
            }
            else
            {
                if (Black.Checked == true)
                {
                    player1Colour = Piece.Piececolour.BLACK;
                }
                else
                {
                    player1Colour = Piece.Piececolour.WHITE;
                }
                
            }

            if (MarbleStyle.Checked == false && WoodStyle.Checked == false && PlainBlueStyle.Checked == false && PlainRedStyle.Checked == false && PlainPurpleStyle.Checked == false && PlainBrownStyle.Checked == false)
            {
                System.Windows.Forms.MessageBox.Show("Please select an Option for game board style");
                return false;
            }
            else
            {
                if (MarbleStyle.Checked == true)
                {
                    gameStyle = "MARBLE";
                }
                if (WoodStyle.Checked == true)
                {
                    gameStyle = "WOOD";
                }
                if (PlainBlueStyle.Checked == true)
                {
                    gameStyle = "PLAINBLUE";
                }
                if (PlainRedStyle.Checked == true)
                {
                    gameStyle = "PLAINRED";
                }
                if (PlainPurpleStyle.Checked == true)
                {
                    gameStyle = "PLAINPURPLE";
                }
                if (PlainBrownStyle.Checked == true)
                {
                    gameStyle = "PLAINBROWN";
                }
                
            }
            return true;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void PlainBlueStyle_CheckedChanged(object sender, EventArgs e)
        {
            if (PlainBlueStyle.Checked == true)
            {
                PlainBlueStyle.BackgroundImage = test_chess.Properties.Resources.PlainBlueStyleButton_GreenBorder;
            }
            else
            {
                PlainBlueStyle.BackgroundImage = test_chess.Properties.Resources.PlainBlueStyleButton;
            }
        }

        private void PlainRedStyle_CheckedChanged(object sender, EventArgs e)
        {
            if (PlainRedStyle.Checked == true)
            {
                PlainRedStyle.BackgroundImage = test_chess.Properties.Resources.PlainRedStyleButton_GreenBorder;
            }
            else
            {
                PlainRedStyle.BackgroundImage = test_chess.Properties.Resources.PlainRedStyleButton;
            }
        }

        private void PlainBrownStyle_CheckedChanged(object sender, EventArgs e)
        {
            if (PlainBrownStyle.Checked == true)
            {
                PlainBrownStyle.BackgroundImage = test_chess.Properties.Resources.PlainBrownStyleButton_GreenBorder;
            }
            else
            {
                PlainBrownStyle.BackgroundImage = test_chess.Properties.Resources.PlainBrownStyleButton;
            }
        }

        private void PlainPurpleStyle_CheckedChanged(object sender, EventArgs e)
        {
            if (PlainPurpleStyle.Checked == true)
            {
                PlainPurpleStyle.BackgroundImage = test_chess.Properties.Resources.PlainPurpleStyleButton_GreenBorder;
            }
            else
            {
                PlainPurpleStyle.BackgroundImage = test_chess.Properties.Resources.PlainPurpleStyleButton;
            }
        }

        // retrieves the contents of the text file and splits each line up and populates a question object
        public void GatherQuestionsInputFromFile()
        {

            const string filename = "QuestionBank 2.csv"; //FilePath of the question textfile.
            StreamReader aSW = new StreamReader(File.Open(filename, FileMode.Open)); // opens a new stream reader which can read from the file
            BoardAdmin.questions = new List<QuestionBank>(); // initiates the list of questions variable in the board admin class

            while (aSW.EndOfStream == false) // happens until the end of the file has been reached
            {
                string[] a = aSW.ReadLine().Split(','); // read a line in from the file and split the data from that line based on the comma separation, store each portion in a string array 

                // adds a question object at the same time as populating that object using the overriden constructor
                BoardAdmin.questions.Add(new QuestionBank(a[0], a[1], a[2], Convert.ToInt16(a[3])));
            }


            aSW.Close(); // closes the stream 
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
           
            // creates the admin login form 
            AdminLogin aAdminLogin = new AdminLogin();


            if (aAdminLogin.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                //Waits until the question form has been dealt with 

            }

           
        }

    }
}
