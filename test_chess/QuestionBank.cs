using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_chess
{
    class QuestionBank
    {
        // properties corresponding to a question 
        private String m_questionText;
        private int m_difficulty;
        private string m_answer;
        private string m_answer2;


        public string questiontext 
        {
            get { return m_questionText; }
            set { m_questionText = value; }
        }

        public int difficulty
        {
            get { return m_difficulty; }
            set { m_difficulty = value; }
        }

        public string answer
        {
            get { return m_answer; }
            set { m_answer = value; }
        }

        public string answer2
        {
            get { return m_answer2; }
            set { m_answer2 = value; }
        }

        // overriden method which allows the properties to be assigned when the object is created
        public QuestionBank(string aQuest, string aAns, string aAns2, int aDiff)
        {
            questiontext = aQuest;
            difficulty = aDiff;
            answer = aAns;
            answer2 = aAns2;
        }

       
    }
}