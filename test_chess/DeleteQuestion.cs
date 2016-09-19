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
    public partial class DeleteQuestion : Form
    {
        public DeleteQuestion()
        {
            InitializeComponent();
           
            // when the form loads, populate the list box with questions from the list of question objects
            populateListBox();

            // set properties
            Answer1Box.ReadOnly = true;
            Answer2Box.ReadOnly = true;
            DifficultyBox.ReadOnly = true;
            Answer1Box.BackColor = Color.White;
            Answer2Box.BackColor = Color.White;
            DifficultyBox.BackColor = Color.White;


        }
        // retrieves the questions from the list of question objects and uses them to populate the control
        private void populateListBox()
        {
            foreach (QuestionBank aQuestion in BoardAdmin.questions)
            {
                QuestionTextList.Items.Add(aQuestion.questiontext);
            }
        }

        // when a question from the control is selected, update the other textboxes with the questions properties
        private void QuestionTextList_SelectedValueChanged(object sender, EventArgs e)
        {
            foreach (QuestionBank aQuestion in BoardAdmin.questions)
            {
                if ((string)QuestionTextList.SelectedItem == aQuestion.questiontext)
                {
                    Answer1Box.Text = aQuestion.answer.ToString();
                    Answer2Box.Text = aQuestion.answer2.ToString();
                    DifficultyBox.Text = aQuestion.difficulty.ToString();
                }
            }

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

        // carries out the deletion of the question
        // deletes from list of question objects first, then updates text file accordingly by rewriting all remaining 
        // question objects
        private void deleteQuestionFromFile()
        {
            QuestionBank QtoDelete = null;
            if (QuestionTextList.SelectedItem != null)
            {
                foreach (QuestionBank aQuestion in BoardAdmin.questions)
                {

                    if (aQuestion.questiontext.ToString() == QuestionTextList.SelectedItem.ToString())
                    {
                        QtoDelete = aQuestion;
                        BoardAdmin.questions.Remove(QtoDelete);
                        break;
                    }

                }

                // writer for writing to file 
                StreamWriter aSW = new StreamWriter(File.Open("QuestionBank 2.csv", FileMode.Truncate));

                // rewrites each question to the file - OVERWRITES
                foreach (QuestionBank aQuestion in BoardAdmin.questions)
                {
                    aSW.WriteLine(aQuestion.questiontext + "," + aQuestion.answer + "," + aQuestion.answer2 + "," + aQuestion.difficulty);
                }

                aSW.Close(); // close stream

                // re-populate list box with the new contents of the question object list and hence the text file
                QuestionTextList.Items.Clear();
                populateListBox();
            }
        }
        // when the delete button is clicked
        private void DeleteQuestionButton_Click(object sender, EventArgs e)
        {
            if (QuestionTextList.SelectedItem != null)
            {
                // gives a warning to the user about deleting the question
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this question? ", "Warning", MessageBoxButtons.YesNo);
               
                if (dialogResult == DialogResult.Yes)
                {
                    deleteQuestionFromFile();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //cancels delete operation of question
                }
            }
            
        }

        


    }
}
