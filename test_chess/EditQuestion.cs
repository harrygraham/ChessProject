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
    public partial class EditQuestion : Form
    {

        //stores the current focused text box
        private RichTextBox focusedTextBox;

        public EditQuestion()
        {
            InitializeComponent();
            populateListBox(); // populates the list box which contains the list of questions the user can select to edit

            // combines the "enter" event so that all textboxes run the same event code
            foreach (RichTextBox tb in this.Controls.OfType<RichTextBox>())
            {
                tb.Enter += QuestionTextBox_Enter;
            }

            focusedTextBox = QuestionTextBox;

        }

        // populates list control with the question text property of the questions
        private void populateListBox()
        {
            foreach (QuestionBank aQuestion in BoardAdmin.questions)
            {
                QuestionTextList.Items.Add(aQuestion.questiontext);
            }
        }

        // when an item is selected/changed in the list box
        private void QuestionTextList_SelectedValueChanged(object sender, EventArgs e)
        {
            // change the contents of the other textboxes on the form to match the selected question
            foreach (QuestionBank aQuestion in BoardAdmin.questions)
            {
                if ((string)QuestionTextList.SelectedItem == aQuestion.questiontext)
                {
                    QuestionTextBox.Text = aQuestion.questiontext.ToString();
                    Answer1Box.Text = aQuestion.answer.ToString();
                    Answer2Box.Text = aQuestion.answer2.ToString();
                    DifficultyBox.Text = aQuestion.difficulty.ToString();
                }
            }

            // if there is no second answer then grey the field out.
            if (Answer2Box.Text == "")
            {
                Answer2Box.BackColor = Color.Gray;
            }
            else
            {
                Answer2Box.BackColor = Color.White;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
        }

 

        private void QuestionTextBox_Enter(object sender, EventArgs e)
        {
            focusedTextBox = (RichTextBox)sender;
        }

        //append special symbols to the currently focused textbox
        private void SquareRootButton_Click_1(object sender, EventArgs e)
        {
            focusedTextBox.AppendText("√");
        }

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

        // when the edit button is clicked
        private void EditQuestionsButton_Click(object sender, EventArgs e)
        {
            //checks that there is a selection
            if (QuestionTextList.SelectedItem != null)
            {
               
                // validates to ensure all appropiate data is available
                if (QuestionTextBox.Text == "" || Answer1Box.Text == "")
                {
                    MessageBox.Show("fields are empty", "error");
                }
                else
                {
                    int num; // stores result of conversion
                    bool isint = int.TryParse(DifficultyBox.Text, out num); // checks for integer values
                    if (isint == true)
                    {
                        if (num > 3)
                        {
                            MessageBox.Show("the difficulty cannot exceed 3", "error");
                        }
                        else
                        {
                            QuestionBank QtoEdit = null;

                            foreach (QuestionBank aQuestion in BoardAdmin.questions)
                            {
                                QuestionTextList.SelectedItem = aQuestion;

                                if (aQuestion.questiontext.ToString() == QuestionTextList.SelectedItem.ToString())
                                {
                                    QtoEdit = aQuestion;
                                    BoardAdmin.questions.Remove(QtoEdit);
                                    break;
                                }

                            }

                            QtoEdit.questiontext = QuestionTextBox.Text;
                            QtoEdit.answer = Answer1Box.Text;
                            QtoEdit.answer2 = Answer2Box.Text;

                            QtoEdit.difficulty = Convert.ToInt16(DifficultyBox.Text);

                            BoardAdmin.questions.Add(QtoEdit);



                            File.WriteAllText("QuestionBank 2.csv", string.Empty);


                            StreamWriter aSW = new StreamWriter(File.Open("QuestionBank 2.csv", FileMode.Open));

                            foreach (QuestionBank aQuestion in BoardAdmin.questions)
                            {
                                // re writes each question as a line in the text file
                                aSW.WriteLine(aQuestion.questiontext + "," + aQuestion.answer + "," + aQuestion.answer2 + "," + aQuestion.difficulty);

                            }

                            aSW.Close(); // closes the stream

                            // the following takes the text from the file and removes all blank lines after the content to ensure no errors occur
                            // when reading in from the file on another process
                            string temptext = File.ReadAllText("QuestionBank 2.csv");
                            temptext = temptext.Trim();
                            File.WriteAllText("QuestionBank 2.csv", temptext); // overwrites

                            QuestionTextList.Items.Clear();
                            populateListBox();

                            MessageBox.Show("Question edited successfully!", "Successful!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("The difficulty must be a number", "error");
                    }


                    
                }
            }
        }

    }
}
