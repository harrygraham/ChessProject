using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_chess
{
    class MathsGame : TimedGame 
    {
        // properties specific to a maths game

        private int m_Player1questionDifficulty;

        private int Player1questionDifficulty
        {
            get { return m_Player1questionDifficulty; }
            set { m_Player1questionDifficulty = value; }
        }

        private int m_Player2questionDifficulty;

        private int Player2questionDifficulty
        {
            get { return m_Player2questionDifficulty; }
            set { m_Player2questionDifficulty = value; }
        }

        public override void setDifficulty(int player1, int player2)
        {
            Player1questionDifficulty = player1;
            Player2questionDifficulty = player2;
        }

        public override int getPlayer1Difficulty()
        {
            return Player1questionDifficulty;
        }
        public override int getPlayer2Difficulty()
        {
            return Player2questionDifficulty;
        }

        public override void createGame(Piece.Piececolour player1colour, Piece.Piececolour player2colour)
        {
            base.createGame(player1colour,player2colour);
          

        }

    }
}
