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
    public partial class AdminLogin : Form
    {
        

        public AdminLogin()
        {
            InitializeComponent();
            //this.KeyDown += new KeyEventHandler(KeyDown);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            enterEvent();
        }

        private void checkEnter(object sender, System.Windows.Forms.KeyEventArgs e)
        {
           
        }

        private void enterEvent()
        {
            //checks the username and password combination
            if (userNameBox.Text.ToUpper() == "CHESSCLUBADMIN" && passwordBox.Text.ToUpper() == "GREENROOK")
            {
                this.Close();

                AdminPage aAdminPage = new AdminPage(); // create the admin page form

                if (aAdminPage.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                {
                    //Waits until the question form has been dealt with 

                }

            }
            else
            {
                System.Windows.Forms.MessageBox.Show("INVALID username or password combination");
            }
        }

        private void AdminLogin_KeyPress(object sender, KeyPressEventArgs e) // when the enter button is pressed
        {
            MessageBox.Show("TEST");
            if (e.KeyChar == (char)13)
            {
                enterEvent();
            }
        }

        private void AdminLogin_KeyDown(object sender, KeyEventArgs e) // when the enter button is pressed
        {
            MessageBox.Show("TEST");

            if (e.KeyCode == Keys.Return)
            {
                enterEvent();
            }
        }


    }
}
