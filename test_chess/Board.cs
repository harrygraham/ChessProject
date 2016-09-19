using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_chess
{
    class Board
    {
        //the board is represented by 8 x 8 array of square objects - initiallised in the setupboard method
        private Square[,] squares = new Square[8, 8];

        //two piecesets, black and white for the board.
        private PieceSet[] pieceSets = new PieceSet[2];

        private Square[,] p_squares
        {
            get { return squares; }
            set { squares = value; }
        }

        private PieceSet[] p_pieceSets
        {
            get { return pieceSets; }
            set { pieceSets = value; }
        }

        public PieceSet[] getPieceSets()
        {
            return p_pieceSets;
        }
        public void setPieceSets(PieceSet[] pieceSetVariable)
        {
            p_pieceSets = pieceSetVariable;
        }
        public Square[,] getSquares()
        {
            return p_squares;
        }
        public void setsquares(Square[,] squaresVariable)
        {
            p_squares = squaresVariable;
        }

        //sets up the board by creating two piecelists, initiallising those lists.
        //also initallising the square object array.
        public void setUpBoard(Piece.Piececolour player1colour)
        {

            //instantiates square objects
            for (int j = 0; j < 8; j++)
            {
                for (int k = 0; k < 8; k++)
                {
                    squares[j, k] = new Square();
                }
            }




            PieceSet blackPieces = new PieceSet();
            PieceSet whitePieces = new PieceSet();

            // invokes methods which set all the properties if each piece
            blackPieces.setInitalPieceList(Piece.Piececolour.BLACK, squares, player1colour );
            whitePieces.setInitalPieceList(Piece.Piececolour.WHITE, squares, player1colour );

            pieceSets[0] = blackPieces;
            pieceSets[1] = whitePieces;

           

            //assigns the x and y co-ordinate properties to the squares of the board
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    squares[i, j].X = i;
                    squares[i, j].Y = j;
                }

            }

            //sets the squares that the pieces are on, to occupied status
            foreach (Piece piece in blackPieces.getPieceSet())
            {
                piece.getPosition().occ = true;
            }
            foreach (Piece piece in whitePieces.getPieceSet())
            {
                piece.getPosition().occ = true;
            }

        }

        //generates string array of board positions "A2" etc
        public String[,] generateBoardPositions()
        {
            String[,] positions = new string[8, 8];

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (i == 0)
                    {
                        positions[i, j] = "A" + (j + 1);
                    }
                    if (i == 1)
                    {
                        positions[i, j] = "B" + (j + 1);
                    }
                    if (i == 2)
                    {
                        positions[i, j] = "C" + (j + 1);
                    }
                    if (i == 3)
                    {
                        positions[i, j] = "D" + (j + 1);
                    }
                    if (i == 4)
                    {
                        positions[i, j] = "E" + (j + 1);
                    }
                    if (i == 5)
                    {
                        positions[i, j] = "F" + (j + 1);
                    }
                    if (i == 6)
                    {
                        positions[i, j] = "G" + (j + 1);
                    }
                    if (i == 7)
                    {
                        positions[i, j] = "H" + (j + 1);
                    }
                }

            }

            return positions;



        }
        

    }
}
