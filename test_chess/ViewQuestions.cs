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
    public partial class ViewQuestions : Form
    {
        public ViewQuestions()
        {
            InitializeComponent();
            populateListBox();

            //set certain proeprties on the form
            Answer1Box.ReadOnly = true;
            Answer2Box.ReadOnly = true;
            DifficultyBox.ReadOnly = true;
            Answer1Box.BackColor = Color.White;
            Answer2Box.BackColor = Color.White;
            DifficultyBox.BackColor = Color.White;


        }

        //populate the list view control of all the question objects
        private void populateListBox()
        {
            foreach (QuestionBank aQuestion in BoardAdmin.questions)
            {
                QuestionTextList.Items.Add(aQuestion.questiontext);
            }
        }

  
        // when a question is selected in the list box, update the other textboxes to show the corresponding properties
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

            // if there is no second answer then grey the field out
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
            this.Close();
        }

        
    }
}
