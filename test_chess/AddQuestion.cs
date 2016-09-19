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
    public partial class AddQuestion : Form
    {
        //stores the current focused text box
        private RichTextBox focusedTextBox;


        public AddQuestion()
        {
            InitializeComponent();

            //combines the 'enter' event for all texboxes on the form so they perform the same procedure
            //A global variable is assigned to which stores the textbox that the cursor is currently in 
            foreach (RichTextBox tb in this.Controls.OfType<RichTextBox>())
            {
                tb.Enter += QuestionTextBox_Enter;
            }

            focusedTextBox = QuestionTextBox;
        }

        //appends the text to the current textbox that is in focus 
        private void SquareRootButton_Click(object sender, EventArgs e)
        {

            focusedTextBox.AppendText("√");

        }

        //event that is run for all textboxes on the form 
        private void QuestionTextBox_Enter(object sender, EventArgs e)
        {
            focusedTextBox = (RichTextBox)sender;
        }

        // runs when the back button is clicked.
        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
        }


        // the following appends the symbols corresponding to the buttons clicked to the text box that has focus.

        private void DivideButton_Click(object sender, EventArgs e)
        {
            focusedTextBox.AppendText("÷");
        }

        private void powerButton_0_Click(object sender, EventArgs e)
        {
            focusedTextBox.AppendText("⁰");

        }

        private void powerButton_1_Click(object sender, EventArgs e)
        {
            focusedTextBox.AppendText("¹");

        }

        private void powerButton_2_Click(object sender, EventArgs e)
        {
            focusedTextBox.AppendText("²");

        }

        private void powerButton_3_Click(object sender, EventArgs e)
        {
            focusedTextBox.AppendText("³");

        }

        private void powerButton_4_Click(object sender, EventArgs e)
        {
            focusedTextBox.AppendText("⁴");

        }

        private void powerButton_5_Click(object sender, EventArgs e)
        {
            focusedTextBox.AppendText("⁵");

        }

        private void powerButton_6_Click(object sender, EventArgs e)
        {
            focusedTextBox.AppendText("⁶");

        }

        private void powerButton_7_Click(object sender, EventArgs e)
        {
            focusedTextBox.AppendText("⁷");

        }

        private void powerButton_8_Click(object sender, EventArgs e)
        {
            focusedTextBox.AppendText("⁸");

        }

        private void powerButton_9_Click(object sender, EventArgs e)
        {
            focusedTextBox.AppendText("⁹");

        }

        private void powerButton_n_Click(object sender, EventArgs e)
        {
            focusedTextBox.AppendText("ⁿ");

        }



        private void AddQuestion_Load(object sender, EventArgs e)
        {

        }

        private void RootSymbolLabel_Click(object sender, EventArgs e)
        {

        }

        private void Answer1Box_Enter(object sender, EventArgs e)
        {
            
        }

        private void Answer2Box_Enter(object sender, EventArgs e)
        {
            
        }

        private void DifficultyBox_Enter(object sender, EventArgs e)
        {
           
        }

        //This procedure carries out the task of adding the question to the file stored on the server.
        //It checks that the input is valid and then it appends a new line containing the new question,
        //in the correct format
        private void addQuestionToFile()
        {
            if (QuestionTextBox.Text == "")
            {
                MessageBox.Show("Please enter the question text", "error");
            }
            if (Answer1Box.Text == "")
            {
                MessageBox.Show("Please enter the question Answer", "error");
            }
            if (DifficultyBox.Text == "")
            {
                MessageBox.Show("Please enter the Difficulty", "error");
            }
            
            int num; // stores the result of the conversion 

            bool isint = int.TryParse(DifficultyBox.Text, out num); // this checks that the difficulty is an integer
            if (isint == true)
            {
                if(Convert.ToInt16(DifficultyBox.Text) > 3) // the difficulty level cannot be greater than 3
                {
                    MessageBox.Show("the difficulty cannot exceed 3", "error");
                }
                else{
                if (QuestionTextBox.Text != "" && Answer1Box.Text != "")
                {
                    QuestionBank newQuestion = new QuestionBank(QuestionTextBox.Text, Answer1Box.Text, Answer2Box.Text, Convert.ToInt16(DifficultyBox.Text));
                    BoardAdmin.questions.Add(newQuestion);

                    
                    File.AppendAllText("QuestionBank 2.csv", Environment.NewLine + newQuestion.questiontext + "," + newQuestion.answer + "," + newQuestion.answer2 + "," + newQuestion.difficulty);

                    MessageBox.Show("Question added successfully!", "Successful!");

                }
                }
            }

            
        }
        // runs when the add button is clicked
        private void AddQuestionButton_Click(object sender, EventArgs e)
        {
            addQuestionToFile();

        }

       
    }
}
