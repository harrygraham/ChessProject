using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_chess
{
    class StandardGame : Game 
    {

        public override void setTimerValue(int aTimerValue)
        {
        }

        public override int getTimerValue()
        {
            return 0;
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
