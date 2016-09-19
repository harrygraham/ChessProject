using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_chess
{
    class Player
    {
        private Piece.Piececolour m_playercolour;
        private double m_timeleft = 00.00;
        
        private Piece.Piececolour p_playercolour
        {
            get{return m_playercolour;}
            set{m_playercolour = value;}

        }

        private double timeleft
        {
            get { return m_timeleft; }
            set { m_timeleft = value; }
        }

        public void setTimeLeft(double aTime)
        {
            timeleft = aTime;
        }
        public double getTimeLeft()
        {
            return timeleft;
        }
        public Piece.Piececolour getPlayerColour()
        {
            return p_playercolour;

        }

        public void setPlayerColour(Piece.Piececolour colour)
        {
            p_playercolour = colour;

        }

        // this is where the moves of the game are made, and where the moves are added to history
        public void makeMove(Square targetposition, Board gameBoard, Piece movingPiece)
        {

            PieceSet[] pieceSets = gameBoard.getPieceSets(); 
            PieceSet BlackPieces = pieceSets[0]; 
            PieceSet WhitePieces = pieceSets[1]; 
            
            //Move object created and populated
            Move aMove = new Move(); 
            aMove.finalPosition = targetposition; 
            aMove.initialPosition = movingPiece.getPosition();  
            aMove.PieceMoved = movingPiece; 

            if (BoardAdmin.game1.getTurn() == BoardAdmin.game1.getPlayer1().getPlayerColour())
                
            {
                aMove.PlayerMoved = BoardAdmin.game1.getPlayer1(); 


                if (BoardAdmin.game1.getPlayer1().getPlayerColour() == Piece.Piececolour.WHITE)
                    
                {
                    foreach (Piece piece in gameBoard.getPieceSets()[0].getPieceSet())
                       
                    {
                        if (piece.getPosition() == targetposition)
                           
                        {
                            aMove.pieceCaptured = piece;
                        }
                    }

                    BlackPieces.getPieceSet().Remove(aMove.pieceCaptured); 

                }
                if (BoardAdmin.game1.getPlayer1().getPlayerColour() == Piece.Piececolour.BLACK)
                    
                {
                    foreach (Piece piece in gameBoard.getPieceSets()[1].getPieceSet())
                        
                    {
                        if (piece.getPosition() == targetposition)
                            
                        {
                            aMove.pieceCaptured = piece; 
                        }
                    }

                    WhitePieces.getPieceSet().Remove(aMove.pieceCaptured); 
                }

            }
            else // otherwise it is player 2's turn so do exactly the same but for player 2
            {
                aMove.PlayerMoved = BoardAdmin.game1.getPlayer2();


                if (BoardAdmin.game1.getPlayer2().getPlayerColour() == Piece.Piececolour.WHITE)
                {
                    foreach (Piece piece in gameBoard.getPieceSets()[0].getPieceSet())
                    {
                        if (piece.getPosition() == targetposition)
                        {
                            aMove.pieceCaptured = piece;
                        }
                    }
                    BlackPieces.getPieceSet().Remove(aMove.pieceCaptured);
                }
                if (BoardAdmin.game1.getPlayer2().getPlayerColour() == Piece.Piececolour.BLACK)
                {
                    foreach (Piece piece in gameBoard.getPieceSets()[1].getPieceSet())
                    {
                        if (piece.getPosition() == targetposition)
                        {
                            aMove.pieceCaptured = piece;
                        }
                    }
                    WhitePieces.getPieceSet().Remove(aMove.pieceCaptured);
                }

            }


            if (movingPiece.getType() == Piece.pieceType.KING) 
                // if the moving piece is a king, castling may occur
             {
                King movingKing = (King)movingPiece; 
                if (movingKing.canCastle(targetposition, gameBoard) == true)
                    // invokes the canCastle method of the king class to check whether castling can occur
                {

                    BoardAdmin.isCastling = true;

                    Rook movingRook= null; 

                    if(this.getPlayerColour() == Piece.Piececolour.WHITE)
                       
                    {
                        foreach(Piece piece in WhitePieces.getPieceSet())
                        {
                            if(piece.getType() == Piece.pieceType.ROOK && Math.Abs(piece.getPosition().X - movingKing.getPosition().X) == 3)
                                
                            {
                                movingRook = (Rook)piece; 
                            }
                        }
                    }
                     if(this.getPlayerColour() == Piece.Piececolour.BLACK )
                        
                    {
                        foreach(Piece piece in BlackPieces.getPieceSet())
                        {
                            if(piece.getType() == Piece.pieceType.ROOK && Math.Abs(piece.getPosition().X - movingKing.getPosition().X) == 3)
                            {
                                movingRook = (Rook)piece;
                            } 
                        }
                    }
                     BoardAdmin.KingsideRook = movingRook; 
                     movingKing.PerformCastle(BoardAdmin.KingsideRook, movingKing, targetposition, gameBoard);
                    // invokes the performCastle method in the king class to make the castling move.
                     
                     if (BoardAdmin.TempMoving == false) 
                         // if temp moving is true, then the move needs to be retracted so the boolean representing castling needs to remain true otherwise the kingside rook will not be moved back aswell as the king
                     {
                         BoardAdmin.isCastling = false;
                         // so if temp moving is false, the castling can be made false aswell as the move is not temporary.
                     }
                }
            }


            // adjusts properties of the piece moving and the squares involved
            movingPiece.getPosition().occ = false; 
            movingPiece.setPosition(targetposition); 
            movingPiece.getPosition().occ = true; 
            movingPiece.IncrementMoveCount(1);

            if (movingPiece.getType() == Piece.pieceType.PAWN) // if the moving piece is a pawn, promototion may occur
            {

                if (movingPiece.getPosition().Y == 0 || movingPiece.getPosition().Y == 7)
                    //if either the bottom or the top of the board is reached
                {
                    if (BoardAdmin.TempMoving == false) // only promotes pawn if it is not a temporary move
                    {
                       
                        movingPiece.promotePawn(); // invokes the promotePawn method to perform the move.
                    }
                }

            }

                BoardAdmin.game1.addTomoveHistory(aMove); 

        }

        // this is an algorithm to determine whether the player is in check
        // this is acheievd by searching the other players pieces and seeing whether the friendly king
        // is occupying one of the other players piece's possible moves
        public bool isInCheck(Board gameBoard)
        {
            PieceSet[] pieceSets = gameBoard.getPieceSets(); 
            PieceSet BlackPieces = pieceSets[0]; 
            PieceSet WhitePieces = pieceSets[1]; 
            Piece kingToCheck = null;
            
            if (this.getPlayerColour() == Piece.Piececolour.BLACK) 
            {
                foreach (Piece piece in BlackPieces.getPieceSet()) 
                {
                    if (piece.getType() == Piece.pieceType.KING) 
                    {
                        kingToCheck = piece; 
                    }
                }

            }
            if (this.getPlayerColour() == Piece.Piececolour.WHITE) 
            {
                foreach (Piece piece in WhitePieces.getPieceSet()) 
                {
                    if (piece.getType() == Piece.pieceType.KING) 
                    {
                        kingToCheck = piece; // set the piece variable with this king piece.
                    }
                }

            }

            if (kingToCheck != null) // makes sure that the piece is not null.
            {

                if (this.getPlayerColour() == Piece.Piececolour.BLACK) 
                {
                    foreach(Piece piece in WhitePieces.getPieceSet()) 
                    {
                        if (piece.getPossibleMoves(gameBoard).Contains(kingToCheck.getPosition())) 
     // populates each pieces possible moves and then scans those possible moves to see whether the kingToCheck has the same position as one of those moves

                        {
                            return true; 
                        }
                    }
                    return false; 
                }
                else // otherwise the player is using black pieces
                {
                    foreach (Piece piece in BlackPieces.getPieceSet())
                    {
                        if (piece.getPossibleMoves(gameBoard).Contains(kingToCheck.getPosition()))
                        {
        

                            return true; 
                        }
                    }
                    return false;  

                }



            }

            return false; // if the piece is null then return false as their is no comparisons made.

        }

        
    }
}
