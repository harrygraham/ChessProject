using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_chess
{
    class PieceSet
    {
        // a set of pieces contains 16 pieces initally
        private List<Piece> m_pieceSet = new List<Piece>(16);
        private Piece.Piececolour m_colour;

        private Piece.Piececolour colour
        {
            get { return m_colour; }
            set { m_colour = value; }
        }

        private List<Piece> pieceSet
        {
            get { return m_pieceSet; }
            set { m_pieceSet = value; }
        }

        public List<Piece> getPieceSet()
        {

            return pieceSet;
        }

        //initiallises all piece objects and fills up the corresponding piece list.
        
        public void setInitalPieceList(Piece.Piececolour piececolour, Square[,] squares, Piece.Piececolour player1colour)
        {


            int index; // the index of the pieces on the board (first row pieces - king, rook etc)
            int pawnindex; // pawns are in the second row, so have their own index
            

            setColour(piececolour);

            //creates all the piece objects neccessary
            Pawn[] Blackpawns = new Pawn[8];
            Pawn[] Whitepawns = new Pawn[8];
            Rook[] BlackRooks = new Rook[2];
            Rook[] WhiteRooks = new Rook[2];
            Bishop[] WhiteBishops = new Bishop[2];
            Bishop[] BlackBishops = new Bishop[2];
            Knight[] WhiteKnights = new Knight[2];
            Knight[] BlackKnights = new Knight[2];
            Queen WhiteQueen = new Queen();
            King WhiteKing = new King();
            Queen BlackQueen = new Queen();
            King BlackKing = new King();

            int i = 0;

            //Initiallise all piece objects
            for (int j = 0; j < 8; j++)
            {
                Blackpawns[j] = new Pawn();
                 Whitepawns[j] = new Pawn();
            }

            for (int j = 0; j < 2; j++)
            {
               WhiteBishops[j] = new Bishop();
               BlackBishops[j] = new Bishop();
            }

            for (int j = 0; j < 2; j++)
            {
                BlackRooks[j] = new Rook();
                WhiteRooks[j] = new Rook();
            }
            for (int j = 0; j < 2; j++)
            {
                WhiteKnights[j] = new Knight();
                BlackKnights[j] = new Knight();
            }
            
       
            //fills up the list with the pieces and setting their properties

            if (colour == Piece.Piececolour.BLACK)
            {
                i = 0; // the x coordinate this can be reassigned as the pieces are populated


                //player 1 pieces needs to be at the bottom of the board so assign the indexes accordingly
                if (player1colour == Piece.Piececolour.BLACK)
                {
                    index = 7;
                    pawnindex = 6;
                }
                else
                {
                    index = 0;
                    pawnindex = 1;
                }

                // sets properties of pawns
                foreach (Pawn pawn in Blackpawns)
                {
                    pawn.setType(Piece.pieceType.PAWN);
                    pawn.setColour(Piece.Piececolour.BLACK);
                    pawn.setImage(test_chess.Properties.Resources.Chess_pdt60);
                    pawn.setPosition(squares[i, pawnindex ]);
                    if (player1colour == Piece.Piececolour.BLACK)
                    {
                        pawn.movedirection = -1;
                    }
                    else
                    {
                        pawn.movedirection = 1;
                    }
                    m_pieceSet.Add(pawn);
                    i++;
                }

                i = 0; // x coordinate value
                // sets properties of rooks
                foreach (Rook rook in BlackRooks)
                {
                    rook.setType(Piece.pieceType.ROOK);
                    rook.setColour(Piece.Piececolour.BLACK);
                    rook.setImage(test_chess.Properties.Resources.Chess_rdt60);
                    rook.setPosition(squares[i, index]);
                    m_pieceSet.Add(rook);

                    i = 7;
                }

                i = 1;// x coordinate value
                foreach (Knight knight in BlackKnights)
                {
                    knight.setType(Piece.pieceType.KNIGHT);
                    knight.setColour(Piece.Piececolour.BLACK);
                    knight.setImage(test_chess.Properties.Resources.Chess_ndt60);
                    knight.setPosition(squares[i, index]);
                    m_pieceSet.Add(knight);
                    i = 6;
                }


                i = 2; // x coordinate value

                foreach (Bishop bishop in BlackBishops)
                {
                    bishop.setType(Piece.pieceType.BISHOP);
                    bishop.setColour(Piece.Piececolour.BLACK);
                    bishop.setImage(test_chess.Properties.Resources.Chess_bdt60);
                    bishop.setPosition(squares[i, index]);
                    m_pieceSet.Add(bishop);
                    i = 5;
                }
                

                BlackKing.setType(Piece.pieceType.KING);
                BlackKing.setColour(Piece.Piececolour.BLACK);
                BlackKing.setImage(test_chess.Properties.Resources.Chess_kdt60);
                BlackKing.setPosition(squares[3, index]);
                

                BlackQueen.setType(Piece.pieceType.QUEEN);
                BlackQueen.setColour(Piece.Piececolour.BLACK);
                BlackQueen.setImage(test_chess.Properties.Resources.Chess_qdt60);
                BlackQueen.setPosition(squares[4, index]);

                m_pieceSet.Add(BlackKing);
                
                m_pieceSet.Add(BlackQueen);
                
                

            }
            else
            {
                // otherwise player 1 is black and so black pieces must be at the bottom of the board
                if (player1colour == Piece.Piececolour.BLACK)
                {
                    index = 0;
                    pawnindex = 1;
                }
                else
                {
                    index = 7;
                    pawnindex = 6;
                }

                i = 0;

                foreach (Pawn pawn in Whitepawns)
                {
                    pawn.setType(Piece.pieceType.PAWN);
                    pawn.setColour(Piece.Piececolour.WHITE);
                    pawn.setImage(test_chess.Properties.Resources.Chess_plt60);
                    pawn.setPosition(squares[i, pawnindex ]);
                    if (player1colour == Piece.Piececolour.WHITE)
                    {
                        pawn.movedirection = -1;
                    }
                    else
                    {
                        pawn.movedirection = 1;
                    }
                        m_pieceSet.Add(pawn);
                        i++;
                    
                }

                i = 0;

                foreach (Rook rook in WhiteRooks)
                {
                    rook.setType(Piece.pieceType.ROOK);
                    rook.setColour(Piece.Piececolour.WHITE);
                    rook.setImage(test_chess.Properties.Resources.Chess_rlt60);
                    rook.setPosition(squares[i, index]);
                    m_pieceSet.Add(rook);
                    i = 7;
                }


                i = 2;

                foreach (Bishop bishop in WhiteBishops)
                {
                    bishop.setType(Piece.pieceType.BISHOP);
                    bishop.setColour(Piece.Piececolour.WHITE);
                    bishop.setImage(test_chess.Properties.Resources.Chess_blt60);
                    bishop.setPosition(squares[i, index]);
                    m_pieceSet.Add(bishop);
                    i = 5;
                }

                i = 1;

                foreach (Knight knight in WhiteKnights)
                {
                    knight.setType(Piece.pieceType.KNIGHT);
                    knight.setColour(Piece.Piececolour.WHITE);
                    knight.setImage(test_chess.Properties.Resources.Chess_nlt60);
                    knight.setPosition(squares[i, index]);
                    m_pieceSet.Add(knight);
                    i = 6;
                }

                WhiteKing.setType(Piece.pieceType.KING);
                WhiteKing.setColour(Piece.Piececolour.WHITE);
                WhiteKing.setImage(test_chess.Properties.Resources.Chess_klt60);
                WhiteKing.setPosition(squares[3, index]);

                WhiteQueen.setType(Piece.pieceType.QUEEN);
                WhiteQueen.setColour(Piece.Piececolour.WHITE);
                WhiteQueen.setImage(test_chess.Properties.Resources.Chess_qlt60);
                WhiteQueen.setPosition(squares[4, index]);

                m_pieceSet.Add(WhiteQueen);
                m_pieceSet.Add(WhiteKing);

            }
            

           


        }

        private void setColour(Piece.Piececolour acolour)
        {
            colour = acolour;
        }
    }
}
