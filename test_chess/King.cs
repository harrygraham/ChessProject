using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_chess
{
    class King : Piece 
    {
        // overrides from PIeCe class, specific to king piece
        public override bool checkMoveIsValid(Square targetPosition, Board gameBoard)
        {
            Square[,] board = gameBoard.getSquares();

            if (base.checkMoveIsValid(targetPosition, gameBoard) == false)
            {
                return false;
            }
            else
            {

                int targetYindex = targetPosition.Y, targetXindex = targetPosition.X, currentYindex = this.getPosition().Y, currentXindex = this.getPosition().X;
                // if the target position is 1 square in any horizontal direction, then this is valid
                if (targetXindex == currentXindex && targetYindex == currentYindex)
                {
                    return true;
                }
                // if the target position is 1 square is any diagonal direction, then this is valid
                if (Math.Abs(targetXindex - currentXindex)  > 1 || Math.Abs(targetYindex - currentYindex ) > 1)
                {
                    if (Math.Abs(targetXindex - currentXindex) > 1)
                    {
                        // checks whether the king can perform a castling move
                        if (canCastle(targetPosition, gameBoard) == true)
                        {
                            
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    if (targetPosition.occ == true)
                    {
                        // checks whether the occupying piece is an enemey piece and can be captured
                        if (canCapture(board[targetXindex , targetYindex ], gameBoard) == true)
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
            }
        }

        // evaluates whether the king can perform the castle procedure by finding the kingside rook and determining
        // whether both the king and rook havent moved yet and whether the spaces between them are empty
        public bool canCastle(Square targetPosition, Board gameBoard)
        {
           // if the target position is castling then the square will be 2 x - coordinates away
            if (Math.Abs(targetPosition.X - this.getPosition().X) == 2)
            {
                PieceSet blackpieces = gameBoard.getPieceSets()[0]; 
                PieceSet whitepieces = gameBoard.getPieceSets()[1]; 

                Rook kingsideRook = null; 

                if(this.getColour() == Piececolour.BLACK)
                   
                {
                foreach (Piece piece in blackpieces.getPieceSet())                  
                {
                    if (piece.getType() == pieceType.ROOK)
                    {
                        if (Math.Abs(this.getPosition().X - piece.getPosition().X) == 3)
                            
                        {
                            kingsideRook = (Rook)piece;
                        }
                    }
                }

                }
                if (this.getColour() == Piececolour.WHITE)
                   
                {
                    foreach (Piece piece in whitepieces.getPieceSet())
                       
                    {
                        if (piece.getType() == pieceType.ROOK)
                            
                        {
                            if (Math.Abs(this.getPosition().X - piece.getPosition().X) == 3)
                                
                            {
                                kingsideRook = (Rook)piece; 
                            }
                        }
                    }

                }

                if (kingsideRook != null)
                    
                {
                    if (kingsideRook.getMoveCount() == 0) 
                        
                    {
                        if (this.getMoveCount() == 0)
                            
                        {
                            if (targetPosition.Y == this.getPosition().Y && targetPosition.occ != true)
                                // checks that the y cooridnate of the target square is the same as the king's and also that the target square is not occupied
                            {

                            for (int i = this.getPosition().X -1 ; i > kingsideRook.getPosition().X; i--)
                                // loops through between the rook and the king, to check the squares in between to make sure they are not occupied.
                            {
                                if (gameBoard.getSquares()[i, this.getPosition().Y].occ == true)
                                  
                                {
                                    return false;
                                }
                               
                            }
                            if (targetPosition.X < this.getPosition().X)
                                // ensures that the algorithm only returns true for the correct target square ( in between rook and king ) and not the other side of the king
                            {
                                return true; 
                            }
                            else
                            {
                                return false; 
                            }
                         }
                          else // otherwise, if the square is occupied or the y coordinates are not the same
                          {
                                return false;
                          }
                        }
                        else // if the king has already moved then return false
                        {
                            return false;
                        }
                    }
                    else // if the rook has already moved before then return false
                    {
                        return false;
                    }
                }
                else // if the kingside rook variable is null then return false
                {
                    return false;
                }

            }
            else // if the target square is not 2 x-coordinates away then return false
            {
                return false;
            }
        }

        // performs the castling procedure
        // moves the kingside rook as the standard makeMove algorithm in the player class handles the king piece as that is the primary piece involved in the move and is the piece that is clicked to perform the castle move.
        public void PerformCastle(Rook kingsideRook, King movingKing, Square targetPosition, Board gameBoard)
        {
            // sets the target position for the rook
            Square rookTargetPosition = gameBoard.getSquares()[targetPosition.X +1,targetPosition.Y];
            

            //creates a move object for the rook and populates it
            Move aMove = new Move();
            aMove.initialPosition = kingsideRook.getPosition(); 
            aMove.finalPosition = rookTargetPosition; 
            aMove.PieceMoved = kingsideRook; 

            if (kingsideRook.getMoveCount() == 0)
            {
                aMove.castled = true; 
            }
            if (BoardAdmin.game1.getTurn() == BoardAdmin.game1.getPlayer1().getPlayerColour())
               
            {
                aMove.PlayerMoved = BoardAdmin.game1.getPlayer1();
               
            }
            else
            {
                aMove.PlayerMoved = BoardAdmin.game1.getPlayer2(); 

            }

            //sets properties of kingside rook piece
            BoardAdmin.game1.addTomoveHistory(aMove); // adds the move object to the list of moves for the game history
            kingsideRook.getPosition().occ = false; 
            kingsideRook.setPosition(rookTargetPosition); 
            kingsideRook.getPosition().occ = true;  
            kingsideRook.IncrementMoveCount(1); 

        }
        
        //abstract class needs implementing
        public override void promotePawn()
        {
            throw new NotImplementedException();
        }
    }
}
