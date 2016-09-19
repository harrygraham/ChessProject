using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_chess
{
    class Square
    {
        // each square has an x and y coordinate
        private int m_X;
        private int m_Y;
        private bool m_occ;  // to determine quickly whether the board square is occupied

        public int X
        {
            get { return m_X; }
            set { m_X = value; }
        }

        public int Y
        {
            get { return m_Y; }
            set { m_Y = value; }

        }
        public bool occ
        {
            get { return m_occ; }
            set { m_occ = value; }
        }
    }
}
