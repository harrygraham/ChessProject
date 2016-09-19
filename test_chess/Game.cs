using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_chess
{
    abstract class Game
    {
        public enum result
        {
            BlackWon,
            WhiteWon,
            None
        }

        public enum gameType
        {
            Standard,
            Timed,
            Maths,

        }

        private Player m_player1 = new Player();
        private Player m_player2 = new Player();
        private Board m_gameBoard = new Board();
        private result m_gameResult;
        private Piece.Piececolour m_turn;
        private List<Move> m_MoveHistory = new List<Move>();
        private gameType m_gameType;

        private gameType p_gameType
        {
            get { return m_gameType; }
            set { m_gameType = value;}
        }

        private result gameResult
        {
            get { return m_gameResult; }
            set { m_gameResult = value; }
        }

        private Piece.Piececolour turn
        {
            get { return m_turn; }
            set { m_turn = value; }
        }

        private Player player1
        {
            get { return m_player1; }
            set { m_player1 = value; }
        }
        private Player player2
        {
            get { return m_player2; }
            set { m_player2 = value; }
        }
        private Board gameBoard
        {
            get { return m_gameBoard; }
            set { m_gameBoard = value; }
        }

        private List<Move> MoveHistory
        {
            get { return m_MoveHistory; }
            set { m_MoveHistory = value; }
        }

        // creates the game by setting player colours and by creating th game board and setting it up with pieces 
        public virtual void createGame(Piece.Piececolour player1colour, Piece.Piececolour player2colour)
        {
            player1.setPlayerColour(player1colour);
            player2.setPlayerColour(player2colour);
            gameBoard = new Board();

            gameBoard.setUpBoard(player1colour);
            // white moves first in chess
            turn = Piece.Piececolour.WHITE;

        }



        public gameType getGameType()
        {
            return p_gameType;
        }
        public void setGameType(gameType aGameType)
        {
            p_gameType = aGameType;
        }

        public result getGameResult()
        {
            return gameResult;
        }
        public void setGameResult(result aGameResult)
        {
            gameResult = aGameResult ;
        }

        public List<Move> getMoveHistory()
        {
            return MoveHistory;
        }
        public void addTomoveHistory(Move aMove)
        {
            MoveHistory.Add(aMove);
        }

        public Piece.Piececolour getTurn()
        {
            return turn;
        }
        public void setTurn(Piece.Piececolour TurnColour)
        {
            turn = TurnColour;
        }
        public Board getGameBoard()
        {
            return gameBoard;
        }
        public Player getPlayer1()
        {
            return player1;
        }
        public Player getPlayer2()
        {
            return player2;
        }

        // method to undo last move
        // uses the top-most MOVE object in the game objects moveHistory list property to undo the move
        public void undoLastMove()
        {

            if (m_MoveHistory.Count != 0)
            {

                Move lastMove = getMoveHistory().Last<Move>();

                if (m_turn == Piece.Piececolour.BLACK)
                {
                    foreach (Piece apiece in gameBoard.getPieceSets()[1].getPieceSet())
                    {
                        if (apiece.getPosition() == lastMove.PieceMoved.getPosition())
                            // incase of pawn promotion, the new piece will have the same position
                        {
                            if (apiece.getType() != lastMove.PieceMoved.getType())
                            {

                                gameBoard.getPieceSets()[1].getPieceSet().Remove(apiece);
                                gameBoard.getPieceSets()[1].getPieceSet().Add(lastMove.PieceMoved);
                                

                                break;
                            }
                        }
                    }
                }
                if (m_turn == Piece.Piececolour.WHITE) // same for white pieces
                {
                    foreach (Piece apiece in gameBoard.getPieceSets()[0].getPieceSet())
                    {
                        if (apiece.getPosition() == lastMove.PieceMoved.getPosition())
                        {
                            if (apiece.getType() != lastMove.PieceMoved.getType())
                            {

                                gameBoard.getPieceSets()[0].getPieceSet().Remove(apiece);
                                gameBoard.getPieceSets()[0].getPieceSet().Add(lastMove.PieceMoved);
                            }
                        }
                    }
                }

                // uses properties of move object to reverse the effects of the move
                lastMove.PieceMoved.setPosition(lastMove.initialPosition);
                lastMove.PieceMoved.decrementMoveCount(1);
                lastMove.initialPosition.occ = true;
                lastMove.finalPosition.occ = false;

                this.setTurn(lastMove.PlayerMoved.getPlayerColour());

                if (lastMove.pieceCaptured != null)
                {
                    Piece pieceToReturn = lastMove.pieceCaptured;
                    if (pieceToReturn.getColour() == Piece.Piececolour.BLACK)
                    {
                        m_gameBoard.getPieceSets()[0].getPieceSet().Add(pieceToReturn);
                        pieceToReturn.getPosition().occ = true;
                    }
                    else
                    {
                        m_gameBoard.getPieceSets()[1].getPieceSet().Add(pieceToReturn);
                        pieceToReturn.getPosition().occ = true;
                    }
                }

                // if the previous move was a castling procedure then the rook needs to be moved back also
                // this is only for temporary movement
                if (BoardAdmin.isCastling == true)
                {

                    if (BoardAdmin.TempMoving == true)
                    {
                        if (BoardAdmin.KingsideRook != null)
                        {
                            BoardAdmin.KingsideRook.getPosition().occ = false;
                            BoardAdmin.KingsideRook.setPosition(gameBoard.getSquares()[BoardAdmin.KingsideRook.getPosition().X - 2, BoardAdmin.KingsideRook.getPosition().Y]);
                            BoardAdmin.KingsideRook.getPosition().occ = true;
                            BoardAdmin.KingsideRook.decrementMoveCount(1);
                            BoardAdmin.isCastling = false;

                           

                        }
                    }



                }
                // removes the move object from the list
                m_MoveHistory.Remove(lastMove);

                if (BoardAdmin.game1.getMoveHistory().Count != 0)
                {
                    // if the actual moe was a castling procedure and not temporary then the rook has its own move object
                    // therefore the top TWO moves in the moveHistory list needs to be removed
                    // Hence this is recursive as the method is called again for the rook to undo its move aswell
                    // as the king.
                    if (BoardAdmin.game1.getMoveHistory().Last<Move>().castled == true)
                    {
                        
                            if (BoardAdmin.TempMoving == false)
                            {
                                BoardAdmin.isCastling = false;
                                this.undoLastMove();   // call method again for rook


                            }
                            else
                            {
                                m_MoveHistory.Remove(m_MoveHistory.Last<Move>()); 
                            }
                       
                    }
                }
            }
        }

        public abstract void setTimerValue(int aTimerValue);
        public abstract int getTimerValue();
        public abstract void setDifficulty(int player1, int player2);
        public abstract int getPlayer1Difficulty();
        public abstract int getPlayer2Difficulty();





    }
}
