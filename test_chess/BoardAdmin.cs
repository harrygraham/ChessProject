using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_chess
{
    abstract class BoardAdmin
    {

        //static variables passed from main menu
        public static Game game1;
        public static String gameStyle;
        public static Piece.Piececolour player1Colour;
        public static int player1Diff;
        public static int player2Diff;

        //static variables used in gameplay
        public static Piece.pieceType promotingPawnType ;
        public static bool isCastling = false;
        public static Rook KingsideRook;
        public static bool TempMoving = false;

        //maths static variables
        public static List<QuestionBank> questions;
        public static QuestionBank currentQuestion;
        public static int player1Score;
        public static int player2Score;
        public static int NumOfQuestionsAsked1;
        public static int NumOfQuestionsAsked2;

    }
}
