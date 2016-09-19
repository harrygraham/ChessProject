using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace test_chess
{
    abstract class Piece
    {
        public enum Piececolour
        {
            BLACK,
            WHITE
        }
        public enum pieceType
        {
            PAWN,
            KING,
            QUEEN,
            ROOK,
            KNIGHT,
            BISHOP

        }

        private Square m_position;
        private Piececolour m_pieceColour;
        private pieceType m_pieceType;
        private System.Drawing.Image m_image;
        private int m_moveCount;
        
        
       

        private int p_moveCount
        {
            get { return m_moveCount; }
            set { m_moveCount = value; }
        }

        private Square p_position
        {
            get { return m_position; }
            set { m_position = value; }
        }

        private Piececolour p_pieceColour
        {
            get { return m_pieceColour; }
            set { m_pieceColour = value; }
        }

        private pieceType p_pieceType
        {
            get { return m_pieceType; }
            set { m_pieceType = value; }
        }

        public System.Drawing.Image p_image
        {
            get { return m_image; }
            set{ m_image = value;}
        }

        public void IncrementMoveCount(int x)
        {
            p_moveCount += x;
        }
        public void decrementMoveCount(int x)
        {
            p_moveCount -= x;
        }

       

        public int getMoveCount()
        {
            return p_moveCount;
        }
        public  void setPosition(Square x)
        {

            p_position = x;

        }

        public Square getPosition()
        {
            return p_position;
        }

        public void setImage(System.Drawing.Image x)
        {
            p_image = x;
        }

        public System.Drawing.Image getImage()
        {
            return p_image;
        }

        public pieceType getType()
        {
            return p_pieceType;
        }

        public void setType(pieceType type)
        {
            p_pieceType = type;
        }

        public void setColour(Piececolour colour)
        {
            p_pieceColour = colour;

        }

        public Piececolour getColour()
        {
            return p_pieceColour;
        }
        

        //Check the move is valid for the selected piece
        public virtual bool checkMoveIsValid(Square targetPosition, Board gameBoard)
        {
            Square[,] board = gameBoard.getSquares();
            int targetYindex = 0, targetXindex = 0, currentYindex = 0, currentXindex = 0;

                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (targetPosition == board[i, j])
                        {
                            targetXindex = i;
                            targetYindex = j;
                        }
                        if (this.getPosition() == board[i, j])
                        {
                            currentXindex = i;
                            currentYindex = j;
                  
                        }
                        
                    }
                }

                if (CheckTargetPositionIsOnBoard(targetPosition, board) == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }

               



        }

        // this procedure checks the target position to see whether the piece occupying it can be captured
        public virtual bool canCapture(Square targetPosition, Board gameBoard)
        {



            Piece.Piececolour colour = this.getColour();
            PieceSet[] piecesets = gameBoard.getPieceSets();


            if (colour == Piece.Piececolour.BLACK)
            {
                foreach (Piece piece in piecesets[1].getPieceSet())
                {
                    if (piece.getPosition() == targetPosition)
                    {
                        return true;
                    }
                }
                return false;
            }
            else
            {
                foreach (Piece piece in piecesets[0].getPieceSet())
                {
                    if (piece.getPosition() == targetPosition)
                    {
                        return true;
                    }
                }
                return false;
            }



        }

        // this populates the possible moves array with all the moves that the piece can make
        // this is used alongside the checkValidMOve algorithm 
        public Square[] getPossibleMoves(Board gameBoard)
        {
            Square[,] board = gameBoard.getSquares();
            int index = 0;
             Square[] possiblemoves = new Square[25]; // max number of moves will not exceed 25
             
            // instantiates the square objects in the array
            for (int x = 0; x < 25; x++)
            {
                possiblemoves[x] = new Square();
            }

            // populates the array with ll valid moves - after scanning through the board
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (this.checkMoveIsValid(board[i, j], gameBoard ) == true)
                    {
                        
                        possiblemoves[index] = board[i, j];
                        if (index < 24)
                        {
                            index++;
                        }
                    }
                }

            }
            Array.Resize(ref possiblemoves, index); // "truncates" the array to its length size
            return possiblemoves;

        }
       

        //This checks the target position to see whether it is on the 8x8 board. (ie not outside the bounds of the array)
        public virtual bool CheckTargetPositionIsOnBoard(Square targetposition, Square[,] board2)
        {
           
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (board2[i, j] == targetposition)
                    {

                        return true;

                    }
                }
            }
            return false;
        }

        public abstract void promotePawn();

    }
}
