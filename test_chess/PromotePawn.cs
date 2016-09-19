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
    public partial class PromotePawn : Form
    {
        public PromotePawn()
        {
            InitializeComponent();
        }

        private void PromotePawn_Load(object sender, EventArgs e)
        {

        }

        // changes the buttons to those with a green border to confirm selection when clicked
        private void KnightButton_CheckedChanged(object sender, EventArgs e)
        {
            if (KnightButton.Checked == true)
            {
                KnightButton.BackgroundImage = test_chess.Properties.Resources.KnightButton_GreenBorder;
            }
            else
            {
                KnightButton.BackgroundImage = test_chess.Properties.Resources.KnightButton;

            }
        }

        private void QueenButton_CheckedChanged(object sender, EventArgs e)
        {
            if (QueenButton.Checked == true)
            {
                QueenButton.BackgroundImage = test_chess.Properties.Resources.QueenButton_GreenBorder;
            }
            else
            {
                QueenButton.BackgroundImage = test_chess.Properties.Resources.QueenButton ;

            }
        }

        private void RookButton_CheckedChanged(object sender, EventArgs e)
        {
            if (RookButton.Checked == true)
            {
                RookButton.BackgroundImage = test_chess.Properties.Resources.RookButton_GreenBorder;
            }
            else
            {
                RookButton.BackgroundImage = test_chess.Properties.Resources.RookButton;

            }
        }

        private void BishopButton_CheckedChanged(object sender, EventArgs e)
        {
            if (BishopButton.Checked == true)
            {
                BishopButton.BackgroundImage = test_chess.Properties.Resources.BishopButton_GreenBorder;
            }
            else
            {
                BishopButton.BackgroundImage = test_chess.Properties.Resources.BishopButton;

            }
        }

        // when the promote button is clicked the user choice is stored in the global variable so the game board can process this move.
        private void PromoteButton_Click(object sender, EventArgs e)
        {
            if (RookButton.Checked == true)
            {
                BoardAdmin.promotingPawnType = (Piece.pieceType.ROOK);
            }
            if (BishopButton.Checked == true)
            {
                BoardAdmin.promotingPawnType = (Piece.pieceType.BISHOP);
            }
            if (KnightButton.Checked == true)
            {
                BoardAdmin.promotingPawnType = (Piece.pieceType.KNIGHT);
            }
            if (QueenButton.Checked == true)
            {
                BoardAdmin.promotingPawnType = (Piece.pieceType.QUEEN);
            }

            this.Close();

        }
    }
}
