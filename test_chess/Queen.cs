using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_chess
{
    class Queen : Piece 
    {

        // override for queen
        public override bool checkMoveIsValid(Square targetPosition, Board gameBoard)
        {
            Square[,] board = gameBoard.getSquares(); 

            if (base.checkMoveIsValid(targetPosition, gameBoard) == false) // performs the generic checkMoveIsValid procedure first
            {
                return false;
            }
            else // otherwise the overriding for the queen happens
            {
                 int targetYindex = targetPosition.Y, targetXindex = targetPosition.X, currentYindex = this.getPosition().Y, currentXindex = this.getPosition().X;
                // creates variables to store the current coordinates and the target coordinates

                // a queens movement is both horizontal and diagonal so checks must be made for both cases
                // for loops are used to check subsequent squares between the queen and the target position
                 if (targetYindex == currentYindex || targetXindex == currentXindex || Math.Abs(targetXindex - currentXindex) == Math.Abs(targetYindex - currentYindex))
                 {
                     // checks whether the target square is either horizontal or diagonal movement

                     if (targetYindex == currentYindex || targetXindex == currentXindex)
                     {
                         // then checks whether the movement is specifically horizontal
                         if (targetYindex == currentYindex)
                         {
                            
                             if ((targetXindex - currentXindex) < 0)
                             {
                                 // checks whether the movement is to the left 
                                 for (int i = currentXindex - 1; i >= targetXindex; i--)
                                 {
                                     
                                     if (board[i, currentYindex ].occ == true)
                                     {
                                         // if a particular square is occupied then the move to the target square cannot be made
                                         if (i == targetXindex)
                                         {
                                             
                                             if (canCapture(board[i, currentYindex], gameBoard) == true)
                                             {
                                                 // invoke the canCapture procedure to determine whether capturing can take place
                                                 return true;
                                             }
                                         }
                                         return false; 
                                     }
                                 }
                             }
                             else // otherwise the movement is to the right
                             {
                                 for (int i = currentXindex + 1; i <= targetXindex; i++)
                                 {
                                   

                                     if (board[i, currentYindex ].occ == true)
                                     {
                                        
                                         if (i == targetXindex)
                                         {
                                            
                                             if (canCapture(board[i, currentYindex], gameBoard) == true)
                                             {
                                                 // invoke canCapture procedure to see whether the occupants of the square can be captured
                                                 return true;
                                             }
                                         }
                                         return false; 
                                     }

                                 }
                             }
                         }
                         else // otherwise the movement is in the y direction
                         {
                             if ((targetYindex - currentYindex) < 0)
                             {
                                 // checks whether the movement is upwards
                                
                                 for (int i = currentYindex - 1; i >= targetYindex; i--)
                                 {
                                    
                                     if (board[currentXindex,i].occ == true)
                                     {
                                         
                                         if (i == targetYindex)
                                         {
                                            
                                             if (canCapture(board[currentXindex, i], gameBoard) == true)
                                             // if so then check whether the occpuants can be captured
                                             {
                                              
                                                 return true;
                                             }
                                         }
                                         return false; 
                                     }
                                 }
                             }
                             else // otherwise the movement is downwards
                             {
                                 for (int i = currentYindex + 1; i <= targetYindex; i++)
                                 {
                                    
                                     if (board[currentXindex, i].occ == true)
                                     {
                                         // checks whether the square is occupied 
                                         if (i == targetYindex)
                                         {
                                            
                                             if (canCapture(board[currentXindex, i], gameBoard) == true)
                                             // if so then check whether the occpuants can be captured
                                             {
                                                 return true;
                                             }
                                         }
                                         return false; 
                                     }
                                 }
                             }

                         }
                     }

                     if (Math.Abs(targetXindex - currentXindex) == Math.Abs(targetYindex - currentYindex))
                         //checks whether the movement is diagonal (equal increments of y and x) by using the absolute function
                     {
                         if ((targetXindex - currentXindex) < 0 && (targetYindex - currentYindex) < 0)
                             // checks whether the movement is upwards, left diagonal
                         {
                            
                             for (int i = Math.Abs((targetXindex - currentXindex )); i > 0; i--)
                                 // loop a number of times which is equal to the difference in either x or y
                             {
                                
                                     currentXindex = currentXindex - 1; 
                                     currentYindex = currentYindex - 1; 
                                     if (currentXindex >= 0 && currentYindex >= 0)                             
                                     {
                                     if (board[currentXindex, currentYindex].occ == true)
                                     {
                                         if (currentXindex == targetXindex && currentYindex == targetYindex)
                                           
                                         {
                                             if (canCapture(board[currentXindex, currentYindex], gameBoard) == true)
                                                 // invokes canCapture routine to check whether capturing can take place
                                             {
                                                 return true; 
                                             }
                                         }
                                         return false; 
                                     }
                                 }
                             }

                         }
                         if ((targetXindex - currentXindex) < 0 && (targetYindex - currentYindex) > 0)
                             // checks whether the movement is downards, left diagonal
                         {
                             for (int i = Math.Abs((targetXindex - currentXindex )); i > 0; i--)
                             {

                                 currentXindex = currentXindex - 1;  
                                 currentYindex = currentYindex + 1; 
                                     if (currentYindex != 8 && currentXindex >= 0 )
                                     {
                                     if (board[currentXindex, currentYindex].occ == true)
                                     {
                                         if (currentXindex == targetXindex && currentYindex == targetYindex)
                                         {
                                             if (canCapture(board[currentXindex, currentYindex], gameBoard) == true)
                                             {
                                                 return true;
                                             }
                                         }
                                         return false; 
                                     }
                                 }
                             }

                         }
                         if ((targetXindex - currentXindex) > 0 && (targetYindex - currentYindex) < 0)
                             // checks whether the movement is upwards, right diagonal
                         {
                             for (int i = Math.Abs((targetXindex - currentXindex)); i > 0; i--)
                             {

                                 currentXindex = currentXindex + 1;  
                                 currentYindex = currentYindex - 1;  
                                     if (currentXindex != 8 && currentYindex >= 0)
                                     {
                                     if (board[currentXindex, currentYindex].occ == true)
                                     {
                                         if (currentXindex == targetXindex && currentYindex == targetYindex)
                                         {
                                             if (canCapture(board[currentXindex, currentYindex], gameBoard) == true)
                                             {
                                                 return true;
                                             }
                                         }
                                         return false; 
                                     }
                                 }
                             }

                         }
                        
                         if ((targetXindex - currentXindex) > 0 && (targetYindex - currentYindex) > 0)
                             // checks whether the movement is downwards, right diagonal
                         {             
                             for (int i = Math.Abs((targetXindex - currentXindex)); i > 0; i--)
                             {

                                 currentXindex = currentXindex + 1; 
                                 currentYindex = currentYindex + 1; 
                                     if (currentXindex != 8 && currentYindex != 8 )
                                     {
                                     if (board[currentXindex, currentYindex].occ == true)
                                     {
                                         if (currentXindex == targetXindex && currentYindex == targetYindex)
                                         {
                                             if (canCapture(board[currentXindex, currentYindex], gameBoard) == true)
                                             {
                                                 return true;
                                             }
                                         }
                                         return false; 
                                     }
                                 }
                             }

                         }

                     }
                     
                     return true; // return true for the current position of the queen

                 }
                 else
                 {

                     return false; // return false as the target square is not horizontal or diagonal away from the current piece.
                 }
            }

        }

        public override void promotePawn()
        {
            throw new NotImplementedException();
        }

    }
}
