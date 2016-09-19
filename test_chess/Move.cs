using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_chess
{
    class Move
    {
        // properties that corrspond to a detail for a move in the game
        private Player m_PlayerMoved;  
        private Piece m_PieceMoved;
        private Square m_initialPosition;
        private Square m_finalPosition;
        private Piece m_pieceCaptured;
        private bool m_castled;

        public Player PlayerMoved
        {
            get { return m_PlayerMoved; }
            set { m_PlayerMoved = value; }
        }
        public Piece PieceMoved
        {
            get { return m_PieceMoved; }
            set { m_PieceMoved = value; }
        }
        public Square initialPosition
        {
            get { return m_initialPosition; }
            set { m_initialPosition = value; }
        }
        public Square finalPosition
        {
            get { return m_finalPosition; }
            set { m_finalPosition = value; }
        }
        public Piece pieceCaptured
        {
            get { return m_pieceCaptured; }
            set { m_pieceCaptured = value; }
        }
        public bool castled
        {
            get { return m_castled; }
            set { m_castled = value; }
        }

        

    }
}
