using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_chess
{
    class TimedGame : Game
    {
        private int m_timervalue;

        private int timerValue
        {
            get { return m_timervalue; }
            set { m_timervalue = value; }
        }


        public override void createGame(Piece.Piececolour player1colour, Piece.Piececolour player2colour)
        {
            base.createGame(player1colour,player2colour);
            

        }

        public override void setTimerValue(int aValue)
        {
            timerValue = aValue;
           
        }
        public override int getTimerValue()
        {
            return timerValue;
        }






        public override void setDifficulty(int player1, int player2)
        {
        }

        public override int getPlayer1Difficulty()
        {
            return 0;
        }
        public override int getPlayer2Difficulty()
        {
            return 0;
        }
    }
}
