using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_chess
{
    class Rook : Piece
    {
        // overriden for rook
        public override bool checkMoveIsValid(Square targetPosition, Board gameBoard)
        {
            Square[,] board = gameBoard.getSquares();

            if (base.checkMoveIsValid(targetPosition, gameBoard) == false)
            {
                return false;
            }
            else{

            int targetYindex = targetPosition.Y, targetXindex = targetPosition.X, currentYindex = this.getPosition().Y, currentXindex = this.getPosition().X ;

            //rooks movement is horizontal, so either the y cooridnate or the x coordinates will be the same
            // as with all pieces, the squares between the current and target position are checked to be empty

                if (targetXindex != currentXindex && targetYindex != currentYindex)
                {
                    return false;
                }
                else
                {
                    if(targetXindex == currentXindex )
                    {
                        if (targetYindex - currentYindex < 0)
                        {
                            for (int i = currentYindex - 1; i >= targetYindex; i--)
                                // loops through squares inbetween to check fo other pieces
                            {
                              

                                if (board[currentXindex, i].occ == true)
                                {
                                    if (i == targetYindex)
                                    {
                                        if (canCapture(board[currentXindex, i], gameBoard) == true)
                                        {
                                            return true;
                                        }
                                    }

                                    return false;
                                }
                            }
                        }
                        else
                        {
                            for (int i = currentYindex + 1; i <= targetYindex; i++)
                            // loops through squares inbetween to check fo other pieces

                            {
                               

                                if (board[currentXindex, i].occ == true)
                                {

                                    if (i == targetYindex)
                                    {
                                        if (canCapture(board[currentXindex, i], gameBoard) == true)
                                        {
                                            return true;
                                        }
                                    }
                                  
                                    return false;
                                }
                            }
                        }
                    }
                    if (targetYindex == currentYindex)
                    {
                        if (targetXindex - currentXindex < 0)
                        {
                            for (int i = currentXindex - 1; i >= targetXindex; i--)
                            // loops through squares inbetween to check fo other pieces

                            {

                                if (board[i, currentYindex].occ == true)
                                {
                                    if (i == targetXindex)
                                    {
                                        if (canCapture(board[i, currentYindex ], gameBoard) == true)
                                        {
                                            return true;
                                        }
                                    }
                                    return false;
                                }
                            }
                        }
                        else
                        {
                            for (int i = currentXindex + 1; i <= targetXindex; i++)
                            // loops through squares inbetween to check fo other pieces

                            {
                                if (board[i, currentYindex].occ == true)
                                {
                                    if (i == targetXindex)
                                    {
                                        if (canCapture(board[i, currentYindex ], gameBoard) == true)
                                        {
                                            return true;
                                        }
                                    }
                                    return false;
                                }
                            }
                        }
                    }


                    return true;



                }
            
            }
          


        }

        public override bool canCapture(Square targetPosition, Board gameBoard)
        {
            return base.canCapture(targetPosition, gameBoard);
        }

        public override void promotePawn()
        {
            throw new NotImplementedException();
        }

    }
}
