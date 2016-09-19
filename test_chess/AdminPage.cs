using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_chess
{
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
            this.BringToFront(); // brings the form to the front so it is in view.
        }

        // when the view questions button is clicked, the viewQuestions form is loaded.
        private void ViewQuestionsButton_Click(object sender, EventArgs e)
        {
            ViewQuestions aViewQuestionsForm = new ViewQuestions();

            if (aViewQuestionsForm.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                //Waits until the question form has been dealt with 

            }
        }
        // when the delete questions button is clicked, the deleteQuestions form is loaded.
        private void DeleteQuestionButton_Click(object sender, EventArgs e)
        {
            DeleteQuestion aDeleteQuestionForm = new DeleteQuestion();

            if (aDeleteQuestionForm.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                //Waits until the question form has been dealt with 

            }
        }
        // when the edit questions button is clicked, the editQuestions form is loaded.
        private void EditQuestionsButton_Click(object sender, EventArgs e)
        {
            EditQuestion aEditQuestionForm = new EditQuestion();

            if (aEditQuestionForm.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                //Waits until the question form has been dealt with 

            }
        }
        // when the add questions button is clicked, the addQuestions form is loaded.
        private void AddQuestionButton_Click(object sender, EventArgs e)
        {
            AddQuestion aAddQuestion = new AddQuestion();

            if (aAddQuestion.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                //Waits until the question form has been dealt with 

            }
        }

        // the following are events when the mouse enters and leaves each button, changing the cursor.
        private void ViewQuestionsButton_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void ViewQuestionsButton_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void AddQuestionButton_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void AddQuestionButton_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void DeleteQuestionButton_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void DeleteQuestionButton_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void EditQuestionsButton_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void EditQuestionsButton_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void BackButton_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void BackButton_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
