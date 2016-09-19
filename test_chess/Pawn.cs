using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_chess
{
    class Pawn : Piece
    {
        private int m_movedirection;   // the pawn can only move in one direction until it is promoted

        public int movedirection
        {
            get { return m_movedirection; }
            set { m_movedirection = value; }
        }

        // overriden for pawn piece
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
                if (targetPosition == this.getPosition())
                {
                    return true;
                }
                // only moves upwards, so there is no change in y coordinate
                if (currentXindex == targetXindex)
                {
                    if (m_movedirection == -1 && targetYindex - currentYindex > 0)
                    {

                        return false;
                    }
                    if (m_movedirection == 1 && targetYindex - currentYindex < 0)
                    {
                        return false;
                    }
                    // if it is the pawns first move, then it may move 2 spaces
                    if (getMoveCount() == 0)
                    {
                        if (Math.Abs(targetYindex - currentYindex) > 2)
                        {
                            return false;
                        }
                        else
                        {
                            if (Math.Abs(targetYindex - currentYindex) == 2)
                            {
                                if (movedirection == -1)
                                {
                                    if (board[currentXindex, currentYindex - 1].occ == true || board[currentXindex, currentYindex - 2].occ == true)
                                    {
                                        return false;
                                    }
                                    else
                                    {
                                        return true;
                                    }

                                }
                                if (movedirection == 1)
                                {
                                    if (board[currentXindex, currentYindex + 1].occ == true || board[currentXindex, currentYindex + 2].occ == true)
                                    {
                                        return false;
                                    }
                                    else
                                    {
                                        return true;
                                    }

                                }
                            }
                            // but it may also move 1 space should the user wish 
                            if (Math.Abs(targetYindex - currentYindex) == 1)
                            {
                                if (movedirection == -1)
                                {
                                    if (board[currentXindex, currentYindex - 1].occ == true)
                                    {
                                        return false;
                                    }
                                    else
                                    {
                                        return true;
                                    }

                                }
                                if (movedirection == 1)
                                {
                                    if (board[currentXindex, currentYindex + 1].occ == true)
                                    {
                                        return false;
                                    }
                                    else
                                    {
                                        return true;
                                    }

                                }
                            }
                            else
                            {
                                return false;
                            }

                        }


                    }

                    if (getMoveCount() != 0) // after the first move, it is only one space per turn
                    {
                        if (Math.Abs(targetYindex - currentYindex) > 1 || Math.Abs(targetYindex - currentYindex) == 0)
                        {
                            return false;
                        }
                        else
                        {

                            if (Math.Abs(targetYindex - currentYindex) == 1)
                            {
                                if (movedirection == -1)
                                {
                                    if (board[currentXindex, currentYindex - 1].occ == true)
                                    {
                                        return false;
                                    }

                                }
                                if (movedirection == 1)
                                {
                                    if (board[currentXindex, currentYindex + 1].occ == true)
                                    {
                                        return false;
                                    }

                                }
                            }




                        }

                    }
                    return true;
                } // otherwise the pawn may capture a piece diagonally
                else
                {
                    if (Math.Abs(targetXindex - currentXindex) == 1)
                    {
                        if (movedirection == -1)
                        {

                            if (targetYindex - currentYindex == -1)
                            {

                                if (board[targetXindex, targetYindex].occ == true)
                                {
                                    if (canCapture(board[targetXindex, targetYindex], gameBoard) == true)
                                    {
                                        return true;
                                    }
                                }

                            }

                        }

                        if (movedirection == 1)
                        {
                            if (targetYindex - currentYindex == 1)
                            {
                                if (board[targetXindex, targetYindex].occ == true)
                                {
                                    if (canCapture(board[targetXindex, targetYindex], gameBoard) == true)
                                    {
                                        return true;
                                    }
                                }

                            }
                        }


                    }

                }

            }




            return false;
        }

        // this occurs when the pawn piece reaches the other side of the board, the user may promote the piece to a 
        // better type of piece
        public override void promotePawn()
        {
            
           // opens the promote pawn sections and awaits a user selection
                
                PromotePawn promotingForm = new PromotePawn();

                if (promotingForm.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                {
                    //Waits until a selection has occured on the other form
                }
                
           
            // checks that a selection has been made and stored
            if (BoardAdmin.promotingPawnType == pieceType.BISHOP || BoardAdmin.promotingPawnType == pieceType.QUEEN || BoardAdmin.promotingPawnType == pieceType.ROOK || BoardAdmin.promotingPawnType == pieceType.KNIGHT)
            {


                PieceSet[] pieceSets = BoardAdmin.game1.getGameBoard().getPieceSets();
                Piece promotedPiece = null;
                
                //sets properties of new piece to replace the pawn piece.
                    if (BoardAdmin.promotingPawnType == pieceType.QUEEN)
                    {
                        promotedPiece = new Queen();
                        promotedPiece.setType(pieceType.QUEEN);
                        if (this.getColour() == Piececolour.BLACK)
                        {
                            promotedPiece.setImage(test_chess.Properties.Resources.Chess_qdt60);
                        }
                        else
                        {
                            promotedPiece.setImage(test_chess.Properties.Resources.Chess_qlt60);
                        }
                    }
                    if (BoardAdmin.promotingPawnType == pieceType.BISHOP)
                    {
                        promotedPiece = new Bishop();
                        promotedPiece.setType(pieceType.BISHOP);
                        if (this.getColour() == Piececolour.BLACK)
                        {
                            promotedPiece.setImage(test_chess.Properties.Resources.Chess_bdt60);
                        }
                        else
                        {
                            promotedPiece.setImage(test_chess.Properties.Resources.Chess_blt60);
                        }
                    }
                    if (BoardAdmin.promotingPawnType == pieceType.KNIGHT)
                    {
                        promotedPiece = new Knight();
                        promotedPiece.setType(pieceType.KNIGHT);

                        if (this.getColour() == Piececolour.BLACK)
                        {
                            promotedPiece.setImage(test_chess.Properties.Resources.Chess_ndt60);
                        }
                        else
                        {
                            promotedPiece.setImage(test_chess.Properties.Resources.Chess_nlt60);
                        }
                    }
                    if (BoardAdmin.promotingPawnType == pieceType.ROOK)
                    {
                        promotedPiece = new Rook();
                        promotedPiece.setType(pieceType.ROOK);
                        if (this.getColour() == Piececolour.BLACK)
                        {
                            promotedPiece.setImage(test_chess.Properties.Resources.Chess_rdt60);
                        }
                        else
                        {
                            promotedPiece.setImage(test_chess.Properties.Resources.Chess_rlt60);
                        }
                    }

                    promotedPiece.setColour(this.getColour());
                    promotedPiece.setPosition(this.getPosition());


                // remove the pawn and add the new promoted piece
                    if (this.getColour() == Piececolour.BLACK)
                    {
                        pieceSets[0].getPieceSet().Remove(this);
                        pieceSets[0].getPieceSet().Add(promotedPiece);
                    }
                    else
                    {
                        pieceSets[1].getPieceSet().Remove(this);
                        pieceSets[1].getPieceSet().Add(promotedPiece);
                    }
                
            }

        }
    }
        }
        
    

