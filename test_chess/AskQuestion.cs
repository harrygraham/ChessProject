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
    public partial class AskQuestion : Form
    {
        // a form which presents a question for the player to answer.
        public AskQuestion()
        {
            InitializeComponent();
            gatherQuestion(); // gathers the question when the form is loaded
        }
        

        public void gatherQuestion()
        {
            Random RND = new Random(); // a random number generator to generate a random index to retrieve a question from the list

            // creates a second list of questions to store all the questions with the correct difficulty of the current player
            List<QuestionBank> questions2 = new List<QuestionBank>();

            //resets form properties
            enterButton.Enabled = true;
            userAnswer1.Enabled = true;
            userAnswer2.Enabled = true;
            SquareRootButton.Enabled = true;
            BackButton.Enabled = false;
            userAnswer1.Clear();
            userAnswer2.Clear();
            QuestionLabel.ForeColor = Color.Black;
            userAnswer1.ForeColor = Color.Black;
            userAnswer2.ForeColor = Color.Black;

            int targetDifficulty; // the difficulty that the question must be

            // retrieves the player difficulty level
            if (BoardAdmin.game1.getTurn() == BoardAdmin.game1.getPlayer1().getPlayerColour())
            {
                targetDifficulty = BoardAdmin.game1.getPlayer2Difficulty();
            }
            else
            {
                targetDifficulty = BoardAdmin.game1.getPlayer1Difficulty();
            }

            // stores all questions with the target difficulty in the secondary list
            foreach (QuestionBank aQuestion in BoardAdmin.questions)
            {

                if (aQuestion.difficulty == targetDifficulty)
                {
                    questions2.Add(aQuestion);
                }

            }

            //randomly generates a number to use as an index to retrieve a question, from the list of question objects
            int index = RND.Next(0, questions2.Count);
            BoardAdmin.currentQuestion = questions2[index];


            QuestionLabel.Text = (BoardAdmin.currentQuestion.questiontext);

            //if the question does not have a second answer, then do not show the second textbox
            if (BoardAdmin.currentQuestion.answer2 != "")
            {
                userAnswer2.Visible = true;
                Answer2Label.Visible = true;
            }
            else
            {
                userAnswer2.Visible = false;
                Answer2Label.Visible = false;
            }

            if (BoardAdmin.game1.getTurn() == BoardAdmin.game1.getPlayer1().getPlayerColour())
            {
                //increment the total number of questions asked for purposes of the UI
                BoardAdmin.NumOfQuestionsAsked2++;

                PlayerLabel.Text = "Player 2";
                //update the piece icon to show that it is player 2's question
                if (BoardAdmin.game1.getPlayer2().getPlayerColour() == Piece.Piececolour.BLACK)
                {
                    PlayerTurnPicBox.Image = test_chess.Properties.Resources.Chess_pdt60;
                }
                else
                {
                    PlayerTurnPicBox.Image = test_chess.Properties.Resources.Chess_plt60;

                }
            }
            else
            {
                BoardAdmin.NumOfQuestionsAsked1++; // increment the number of questions asked to player 1

                PlayerLabel.Text = "Player 1";
                //update the piece icon to show that it is player 1's question
                if (BoardAdmin.game1.getPlayer1().getPlayerColour() == Piece.Piececolour.BLACK)
                {
                    PlayerTurnPicBox.Image = test_chess.Properties.Resources.Chess_pdt60;
                }
                else
                {
                    PlayerTurnPicBox.Image = test_chess.Properties.Resources.Chess_plt60;

                }
            }

            

        }

        

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (BoardAdmin.currentQuestion.answer2 == "")
            {
                if (userAnswer1.Text.Trim() == BoardAdmin.currentQuestion.answer) // trims any white spaces
                {
                    if (BoardAdmin.game1.getTurn() == BoardAdmin.game1.getPlayer1().getPlayerColour())
                    {
                        BoardAdmin.player2Score++; // increment score
                    }
                    else
                    {
                        BoardAdmin.player1Score++;
                    }
                    QuestionLabel.ForeColor = Color.Green;
                    QuestionLabel.Text = "CORRECT!";

                    // clears answer box to the show solution
                    userAnswer1.Clear();
                    userAnswer1.ForeColor = Color.Green;
                    userAnswer1.Text = "The answer was: " + BoardAdmin.currentQuestion.answer;

                }
                else
                {
                    QuestionLabel.ForeColor = Color.Red;
                    QuestionLabel.Text = "INCORRECT!";

                    subtractTime();

                    userAnswer1.Clear();
                    userAnswer1.ForeColor = Color.Red;
                    userAnswer1.Text = "The answer was: " + BoardAdmin.currentQuestion.answer;
                }


            }
            else
            {
                //checks whether EITHER answer box contains the correct answers, there are two answers and the user could have
                //put them in any order, so check for both.
                if (userAnswer1.Text.Trim() == BoardAdmin.currentQuestion.answer || userAnswer2.Text.Trim() == BoardAdmin.currentQuestion.answer)
                {
                    if (userAnswer1.Text.Trim() == BoardAdmin.currentQuestion.answer2 || userAnswer2.Text.Trim() == BoardAdmin.currentQuestion.answer2)
                    {
                        if (BoardAdmin.game1.getTurn() == BoardAdmin.game1.getPlayer1().getPlayerColour())
                        {
                            BoardAdmin.player2Score++;
                        }
                        else
                        {
                            BoardAdmin.player1Score++;
                        }

                        QuestionLabel.ForeColor = Color.Green;
                        QuestionLabel.Text = "CORRECT!";

                        

                    }
                    else
                    {
                        QuestionLabel.ForeColor = Color.Red;
                        QuestionLabel.Text = "INCORRECT!";

                        subtractTime();

                        userAnswer1.Clear();
                        userAnswer1.ForeColor = Color.Red;
                        userAnswer1.Text = "The answer was: " + BoardAdmin.currentQuestion.answer;

                    }



                }
                else
                {
                    QuestionLabel.ForeColor = Color.Red;
                    QuestionLabel.Text = "INCORRECT!";

                    subtractTime();

                    userAnswer1.Clear();
                    userAnswer1.ForeColor = Color.Red;
                    userAnswer1.Text = "The answer was: " + BoardAdmin.currentQuestion.answer;

                }

              

                userAnswer1.Clear();
                userAnswer1.ForeColor = Color.Green;
                userAnswer1.Text = "The answer was: " + BoardAdmin.currentQuestion.answer;

                userAnswer2.Clear();
                userAnswer2.ForeColor = Color.Green;
                userAnswer2.Text = "The answer was: " + BoardAdmin.currentQuestion.answer2;

            }


           
            // sets properties to false so no more changes can be made, back button is now available.
            enterButton.Enabled = false;
            userAnswer1.Enabled = false;
            userAnswer2.Enabled = false;
            SquareRootButton.Enabled = false;
            BackButton.Enabled = true;
        }

        //This procedure adjusts the timeLeft property for the player who has just ended their turn.
        //This uses a double data type but ensures that the value shown is a time value by making
        //the value start counting down at 60 rather that 99
        private void subtractTime()
        {
            if (BoardAdmin.game1.getTurn() == BoardAdmin.game1.getPlayer2().getPlayerColour())
            {
                if (BoardAdmin.game1.getPlayer1Difficulty() == 1)
                {
                    BoardAdmin.game1.getPlayer1().setTimeLeft(BoardAdmin.game1.getPlayer1().getTimeLeft() - 0.30);
                }
                if (BoardAdmin.game1.getPlayer1Difficulty() == 2)
                {
                    BoardAdmin.game1.getPlayer1().setTimeLeft(BoardAdmin.game1.getPlayer1().getTimeLeft() - 0.20);
                }
                if (BoardAdmin.game1.getPlayer1Difficulty() == 3)
                {
                    BoardAdmin.game1.getPlayer1().setTimeLeft(BoardAdmin.game1.getPlayer1().getTimeLeft() - 0.10);
                }

                double seconds = (BoardAdmin.game1.getPlayer1().getTimeLeft() - Math.Floor(BoardAdmin.game1.getPlayer1().getTimeLeft()));
                double minutes = (Math.Floor(BoardAdmin.game1.getPlayer1().getTimeLeft()));
                if (seconds > 0.60)
                {
                    double difference = 1 - seconds; // the difference needs to be subtracted so the timer counts down from 0.60 (i.e 60 seconds)
                    seconds = 00.60 - difference;
                    
                    BoardAdmin.game1.getPlayer1().setTimeLeft(Math.Round(minutes + seconds, 2));
                }
            }
            //same again but for player 1
            if (BoardAdmin.game1.getTurn() == BoardAdmin.game1.getPlayer1().getPlayerColour())
            {
                if (BoardAdmin.game1.getPlayer2Difficulty() == 1)
                {
                    BoardAdmin.game1.getPlayer2().setTimeLeft(BoardAdmin.game1.getPlayer2().getTimeLeft() - 0.30);
                }
                if (BoardAdmin.game1.getPlayer2Difficulty() == 2)
                {
                    BoardAdmin.game1.getPlayer2().setTimeLeft(BoardAdmin.game1.getPlayer2().getTimeLeft() - 0.20);
                }
                if (BoardAdmin.game1.getPlayer2Difficulty() == 3)
                {
                    BoardAdmin.game1.getPlayer2().setTimeLeft(BoardAdmin.game1.getPlayer2().getTimeLeft() - 0.10);
                }

                double seconds = (BoardAdmin.game1.getPlayer2().getTimeLeft() - Math.Floor(BoardAdmin.game1.getPlayer2().getTimeLeft()));
                double minutes = (Math.Floor(BoardAdmin.game1.getPlayer2().getTimeLeft()));
                if (seconds > 0.60)
                {
                    double difference = 1 - seconds;
                    seconds = 00.60 - difference;
                   
                    BoardAdmin.game1.getPlayer2().setTimeLeft(Math.Round(minutes + seconds,2));
                }

            }
        }

        //appends square root symbol when button is clicked
        private void SquareRootButton_Click(object sender, EventArgs e)
        {
            userAnswer1.AppendText("√");
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AskQuestion_FormClosing(object sender, EventArgs e)
        {
            subtractTime();
        }

        private void AskQuestion_Load(object sender, EventArgs e)
        {

        }

        //if the player closes the form before the question has been answered, subract time.
        private void AskQuestion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (BackButton.Enabled != true)
            {
                subtractTime();
            }
            
        }

        private void RootSymbolLabel_Click(object sender, EventArgs e)
        {

        }
        
      

       

    }
}
