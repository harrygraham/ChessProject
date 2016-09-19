using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_chess
{
    class Bishop : Piece 
    {

        //overriding procedure for the BISHOP
        public override bool checkMoveIsValid(Square targetPosition, Board gameBoard)
        {
            Square[,] board = gameBoard.getSquares();

            if (base.checkMoveIsValid(targetPosition, gameBoard) == false) // generic method from piece class
            {
                return false;
            }
            else
            {

                //System.Windows.Forms.MessageBox.Show("BISHOP CHECK TEST");
                int targetYindex = targetPosition.Y, targetXindex = targetPosition.X, currentYindex = this.getPosition().Y, currentXindex = this.getPosition().X;

                //Bishop moves diagonally, so check that the change in x and the change in y are equal
                //then check which direction the movement is (>0 etc).
                if (Math.Abs(targetXindex - currentXindex) == Math.Abs(targetYindex - currentYindex))
                {
                    //moving upwards and to the left
                    if (targetXindex - currentXindex < 0 && targetYindex - currentYindex < 0)
                    {
                        for (int i = currentXindex - 1; i >= targetXindex; i--)
                            //loops through to see if any squares inbetween are occupied
                        {
                            currentYindex -= 1;
                            if (board[i, currentYindex].occ == true)
                            {
                                if (i == targetXindex)
                                {
                                    if (canCapture(board[i, currentYindex], gameBoard) == true)
                                    {
                                        return true;
                                    }
                                }
                                return false;
                            }
                        }

                    }
                    //moving downwards and to the left
                    if (targetXindex - currentXindex < 0 && targetYindex - currentYindex > 0)
                    {
                        for (int i = currentXindex - 1; i >= targetXindex; i--)
                        //loops through to see if any squares inbetween are occupied
                        {
                            currentYindex += 1;
                            if (board[i, currentYindex].occ == true)
                            {
                                if (i == targetXindex)
                                {
                                    if (canCapture(board[i, currentYindex], gameBoard) == true)
                                    {
                                        return true;
                                    }
                                }
                                return false;
                            }
                        }
                    }
                    //moving upwards and to the right
                    if (targetXindex - currentXindex > 0 && targetYindex - currentYindex < 0)
                    {
                        for (int i = currentXindex + 1; i <= targetXindex; i++)
                        //loops through to see if any squares inbetween are occupied
                        {
                            currentYindex -= 1;
                            if (board[i, currentYindex].occ == true)
                            {
                                if (i == targetXindex)
                                {
                                    if (canCapture(board[i, currentYindex], gameBoard) == true)
                                    {
                                        return true;
                                    }
                                }
                                return false;
                            }
                        }
                    }
                    //moving downwards and to the right
                    if (targetXindex - currentXindex > 0 && targetYindex - currentYindex > 0)
                    {
                        for (int i = currentXindex + 1; i <= targetXindex; i++)
                        //loops through to see if any squares inbetween are occupied
                        {
                            currentYindex += 1;
                            if (board[i, currentYindex].occ == true)
                            {
                                if (i == targetXindex)
                                {
                                    if (canCapture(board[i, currentYindex], gameBoard) == true)
                                    {
                                        return true;
                                    }
                                }
                                return false;
                            }
                        }
                    }

                    return true;
                }
                return false;
            }

        }

        // abstract method for pawn piece only but must be implemented in all inherited classes.
        public override void promotePawn()
        {
            throw new NotImplementedException();
        }
    }
}
