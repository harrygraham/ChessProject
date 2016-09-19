using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_chess
{
    class Knight : Piece 
    {
        // override piece for the knight 
         public override bool checkMoveIsValid(Square targetPosition, Board gameBoard)
        {
            Square[,] board = gameBoard.getSquares();

            if (base.checkMoveIsValid(targetPosition, gameBoard) == false)
            {
                return false;
            }
            else
            {
                // sets target and current indexes as variables
                int targetYindex = targetPosition.Y, targetXindex = targetPosition.X, currentYindex = this.getPosition().Y, currentXindex = this.getPosition().X;
                if (targetXindex == currentXindex && targetYindex == currentYindex)
                {
                    return true;
                }

                //  a knight can move in an "L" shape and that means either 2 x-coordinates and 1 y-coordinate or vice versa

                if ((Math.Abs((targetYindex - currentYindex)) == 2 && Math.Abs(targetXindex - currentXindex) == 1) || (Math.Abs((targetXindex - currentXindex)) == 2 && Math.Abs(targetYindex - currentYindex) == 1))
                {
                    if (targetPosition.occ == true)
                    {
                        if (canCapture(board[targetXindex,targetYindex ], gameBoard) == true)
                        {
                            return true;
                        }

                        return false;
                    }
                    else
                    {

                        return true;
                    }
                }
                else
                {
                    return false;
                }

            }



            }
        //abstract class needs implementing
         public override void promotePawn()
         {
             throw new NotImplementedException();
         }
    }
}
