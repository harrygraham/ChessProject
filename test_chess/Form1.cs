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
    public partial class Form1 : Form
    {
        Rook BlackRook1 = new Rook();
       
        

        public Form1()
        {
            InitializeComponent();
        }

        public void updateView()
        {

            //string[,] boardPositions = generateBoardPositions();
            //PictureBox[,] squares = new PictureBox[8, 8];

            //for (int i = 0; i < 8; i++)
            //{
            //    for (int j = 0; j < 8; j++)
            //    {
            //        squares[i, j] = (PictureBox)this.Controls.Find(boardPositions[i, j], true)[0];


            //    }
            //}

           

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (BlackRook1.getPosition() == squares[i,j].Name)
                    {
                        squares[i,j].Image = test_chess.Properties.Resources.Rook2;
                    }
                    else
                    {
                        squares[i,j].Image = null;

                    }
                }
            }   
        }

        public bool CheckTargetPosition()
        {
            String[,] board2 = generateBoardPositions();
            for(int i = 0; i < 8 ; i++)
            {
                for (int j = 0; j< 8; j++)
                {
            if (board2[i,j] == textBox1.Text)
            {

                return true;
              
            }
                }
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          

            if (CheckTargetPosition() == true && BlackRook1.checkValidMove(textBox1.Text, generateBoardPositions())  == true)
            {
                BlackRook1.setPosition(textBox1.Text);
                updateView();
            }
            

        }

        public String[,] generateBoardPositions()
        {
            String[,] positions = new string[8,8];

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (i == 0)
                    {
                        positions[i, j] = "A" + (j + 1);
                    }
                    if (i == 1)
                    {
                        positions[i, j] = "B" + (j + 1);
                    }
                    if (i == 2)
                    {
                        positions[i, j] = "C" + (j + 1);
                    }
                    if (i == 3)
                    {
                        positions[i, j] = "D" + (j + 1);
                    }
                    if (i == 4)
                    {
                        positions[i, j] = "E" + (j + 1);
                    }
                    if (i == 5)
                    {
                        positions[i, j] = "F" + (j + 1);
                    }
                    if (i == 6)
                    {
                        positions[i, j] = "G" + (j + 1);
                    }
                    if (i == 7)
                    {
                        positions[i, j] = "H" + (j + 1);
                    }
                }
               
            }

            return positions;



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
