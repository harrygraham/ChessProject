using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace test_chess
{
    public partial class BoardUI : Form
    {
        //variables referenced everywhere, so made global
        PictureBox[,] squares = new PictureBox[8, 8];    // picturebox array
        Board gameBoard;
        PieceSet[] pieceSets;
        PictureBox currentPicBox;   // current picture box being processed
        Piece clickedPiece;         // current piece being processed
        Square[] possiblemoves;    // the current possible moves for a clicked piece
      
       

        public BoardUI()
        {
            InitializeComponent();
            assignBoardsquares();
            Piece.Piececolour player2Colour;

            //set player 2 colour, now we know player 1 colour
            if (BoardAdmin.player1Colour == Piece.Piececolour.BLACK)
            {
                player2Colour = Piece.Piececolour.WHITE;
            }
            else
            {
                player2Colour = Piece.Piececolour.BLACK;
            }
            //create the game by calling the method in the game class.
            //this will override depending on what type of game it is
            BoardAdmin.game1.createGame(BoardAdmin.player1Colour,player2Colour);
            gameBoard  = BoardAdmin.game1.getGameBoard();
            pieceSets = BoardAdmin.game1.getGameBoard().getPieceSets();
            BoardAdmin.game1.setGameResult(Game.result.None);

            //if the game mode is timed or maths, then set the timer values for the game and players
            //also make the timer controls visible
            if (BoardAdmin.game1.getGameType() == Game.gameType.Timed || BoardAdmin.game1.getGameType() == Game.gameType.Maths)
            {
                

                TimerLabel.Visible = true;
                Player1TimerLabel.Visible = true;
                Player2TimerLabel.Visible = true;

                BoardAdmin.game1.getPlayer1().setTimeLeft(BoardAdmin.game1.getTimerValue());
                BoardAdmin.game1.getPlayer2().setTimeLeft(BoardAdmin.game1.getTimerValue());

                Player1TimerLabel.Text = BoardAdmin.game1.getPlayer1().getTimeLeft().ToString();
                Player2TimerLabel.Text = BoardAdmin.game1.getPlayer2().getTimeLeft().ToString();

            }
            //if a maths game, set the difficulties of the players
            if (BoardAdmin.game1.getGameType() == Game.gameType.Maths)
            {
                BoardAdmin.game1.setDifficulty(BoardAdmin.player1Diff, BoardAdmin.player2Diff);

                MathsScores.Visible = true;
            }
            else
            {
                MathsScores.Visible = false;
            }

            UpdateViewTimer.Enabled = true;


           
        }

        

        //updates view of the board
        public void updateView()
        {

            //sets all picturebox images to empty
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    squares[i, j].Image = null;

                }
            }
           
            //sets all images of picture boxes representing a piece's position from black piece list
            foreach (Piece piece in pieceSets[0].getPieceSet())
            {
                int x = piece.getPosition().X;
                int y = piece.getPosition().Y;

                squares[x, y].Image = piece.getImage();
                    

            }
            //sets all images of picture boxes representing a piece's position from white piece list

            foreach (Piece piece in pieceSets[1].getPieceSet())
            {
                int x = piece.getPosition().X;
                int y = piece.getPosition().Y;

                squares[x, y].Image = piece.getImage();
            }

            // if the timer values are visible then it is a timed game, perform the following things
            if (Player1TimerLabel.Visible == true && Player2TimerLabel.Visible == true)
            {
                Player1TimerLabel.Text = BoardAdmin.game1.getPlayer1().getTimeLeft().ToString();
                Player2TimerLabel.Text = BoardAdmin.game1.getPlayer2().getTimeLeft().ToString();

                if (BoardAdmin.game1.getPlayer1().getTimeLeft() == 0) // if the timer falls to zero
                {
                    UpdateViewTimer.Enabled = false;
                    undoMoveButton.Enabled = false;

                    if (BoardAdmin.game1.getPlayer1().getPlayerColour() == Piece.Piececolour.BLACK)
                    {
                        BoardAdmin.game1.setGameResult(Game.result.WhiteWon);

                        foreach (PictureBox square in squares)
                        {
                            square.Enabled = false;
                        }

                        MessageBox.Show("WHITE WON! \x2654  (black time out)");
                    }
                    else
                    {
                        BoardAdmin.game1.setGameResult(Game.result.BlackWon);

                        foreach (PictureBox square in squares)
                        {
                            square.Enabled = false;
                        }

                        MessageBox.Show("BLACK WON! \x265A  (white time out)");
                    }
                }
                if (BoardAdmin.game1.getPlayer2().getTimeLeft() == 0) // if the timer falls to zero
                {
                    UpdateViewTimer.Enabled = false;
                    undoMoveButton.Enabled = false;

                    if (BoardAdmin.game1.getPlayer2().getPlayerColour() == Piece.Piececolour.BLACK)
                    {
                        BoardAdmin.game1.setGameResult(Game.result.WhiteWon);

                        foreach (PictureBox square in squares)
                        {
                            square.Enabled = false;
                        }

                        MessageBox.Show("WHITE WON! \x2654  (black time out)");
                    }
                    else
                    {
                        BoardAdmin.game1.setGameResult(Game.result.BlackWon);
                        foreach (PictureBox square in squares)
                        {
                            square.Enabled = false;
                        }

                        MessageBox.Show("BLACK WON! \x265A  (white time out)");
                    }
                }

                //if (BoardAdmin.game1.getGameResult() == Game.result.BlackWon)
                //{
                //    foreach (PictureBox square in squares)
                //    {
                //        square.Enabled = false;
                //    }

                //    MessageBox.Show("BLACK WON! \x265A  (white time out)");
                //}
                //if (BoardAdmin.game1.getGameResult() == Game.result.WhiteWon)
                //{
                //    foreach (PictureBox square in squares)
                //    {
                //        square.Enabled = false;
                //    }

                //    MessageBox.Show("WHITE WON! \x2654  (black time out)");
                //}

            }

            //updates the players timers by counting down and subtracting a 'second' from the double value
            //This update view procesure is called every second so this is why this happens here.
            //This also updates all the corresponding labels such as maths scores etc
            if (BoardAdmin.game1.getGameType() == Game.gameType.Timed || BoardAdmin.game1.getGameType() == Game.gameType.Maths)
            {
                if (BoardAdmin.game1.getTurn() == BoardAdmin.game1.getPlayer1().getPlayerColour())
                {
                    double seconds = (BoardAdmin.game1.getPlayer1().getTimeLeft() - Math.Floor(BoardAdmin.game1.getPlayer1().getTimeLeft()));
                    double minutes = (Math.Floor(BoardAdmin.game1.getPlayer1().getTimeLeft()));
                    if (seconds == 0 )
                    {
                        seconds = 00.60;
                        minutes -= 1;
                        BoardAdmin.game1.getPlayer1().setTimeLeft(Math.Round(minutes + seconds, 2));
                    }
                    else
                    {
                        BoardAdmin.game1.getPlayer1().setTimeLeft(Math.Round(BoardAdmin.game1.getPlayer1().getTimeLeft() - 00.01, 2));
                    }
                }
                else
                {
                    double seconds = (BoardAdmin.game1.getPlayer2().getTimeLeft() - Math.Floor(BoardAdmin.game1.getPlayer2().getTimeLeft()));
                    double minutes = (Math.Floor(BoardAdmin.game1.getPlayer2().getTimeLeft()));
                    if (seconds == 0)
                    {
                        seconds = 00.60;
                        minutes -= 1;
                        BoardAdmin.game1.getPlayer2().setTimeLeft(Math.Round(minutes + seconds, 2));
                    }
                    else
                    {
                        BoardAdmin.game1.getPlayer2().setTimeLeft(Math.Round(BoardAdmin.game1.getPlayer2().getTimeLeft() - 00.01, 2));
                    }
                }

                if (BoardAdmin.game1.getGameType() == Game.gameType.Maths)
                {
                    MathsScoreLabel1.Text = BoardAdmin.player1Score + "/" + BoardAdmin.NumOfQuestionsAsked1;
                    MathsScoreLabel2.Text = BoardAdmin.player2Score + "/" + BoardAdmin.NumOfQuestionsAsked2;

                }

            }

        }

        //makes a link between the picture boxes on board and a picturebox array in code
        public void assignBoardsquares()
        {
            string[,] boardPositions = generateBoardPositions();
            

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    //assigns the control to the index in the array.
                    squares[i, j] = (PictureBox)this.Controls.Find(boardPositions[i, j], true)[0];


                }
            }
        }

                

        //generates a 2-dimensional array of board positions, type : STRING
        public String[,] generateBoardPositions()
        {
            String[,] positions = new string[8,8];

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

        private void Form1_Load(object sender, EventArgs e)
        {
            //combines all click events so they run the same procedure
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    squares[i, j].Click += new EventHandler(clickEvent);
                }
            }

            resetSquarebackgrounds();
            updateView();
        }

        private void UpdateViewTimer_Tick(object sender, EventArgs e)
        {
            //update the turn icon to indicate who's turn it is currently
            if (BoardAdmin.game1.getTurn() == BoardAdmin.game1.getPlayer1().getPlayerColour())
            {
                player2TurnPicBox.Image = null;

                if (BoardAdmin.game1.getPlayer1().getPlayerColour() == Piece.Piececolour.BLACK)
                {
                    Player1TurnPicBox.Image = test_chess.Properties.Resources.Chess_pdt60;
                }
                else
                {
                    Player1TurnPicBox.Image = test_chess.Properties.Resources.Chess_plt60;
                }
            }
            else
            {
                Player1TurnPicBox.Image = null;

                if (BoardAdmin.game1.getPlayer2().getPlayerColour() == Piece.Piececolour.BLACK)
                {
                    player2TurnPicBox.Image = test_chess.Properties.Resources.Chess_pdt60;
                }
                else
                {
                    player2TurnPicBox.Image = test_chess.Properties.Resources.Chess_plt60;
                }
            }
            
            //update view every second
            updateView();

        }

        //a generic click event for all picture boxes on the form
        private void clickEvent(object sender, EventArgs e)
        {
            currentPicBox = (PictureBox)sender;

            resetSquarebackgrounds();

            Piece clickedPieceTemp = getPieceOnSquare(currentPicBox);



            if (clickedPieceTemp != null)
            {
                // if the clicked piece is of the opposite colour to the current turn of the game,
                // then capturing must be taking place, so call the "moving" procedure
                if (clickedPieceTemp.getColour() != BoardAdmin.game1.getTurn())
                {

                    PieceMovingClickEvent(currentPicBox);

                }
                else
                {
                    // otherwise, the clicked piece is the current player's so it can be moved.
                    standardClickEvent(currentPicBox, clickedPieceTemp);
                }
            }
            else
            {
                // if the square that has been clicked is empty, then a piece must be being moved,
                // the possible moves array will be checked to see whether the clicked square is avaible to move to
                PieceMovingClickEvent(currentPicBox);
            }

            
            updateView();


           

            

        }

        //happens when the user selects a piece to move
        private void standardClickEvent(PictureBox currentPicBox, Piece clickedPieceTemp)
        {
            clickedPiece = clickedPieceTemp;

            if (clickedPiece.getColour() == BoardAdmin.game1.getTurn())
            {

                

                possiblemoves = clickedPiece.getPossibleMoves(gameBoard);
              
                int nullcounter = 1;

                //makes each move in the possible moves to check whether the move would result in being in check
                foreach (Square possiblemove in possiblemoves)
                {
                    if (clickedPiece.getPosition() != possiblemove)
                    {
                        makeTempMove(possiblemove);

                        if (possiblemove == null)
                        {
                            nullcounter++;
                        }
                    }
                }

                // if highlighting option is on, then highlight all the possible moves in green
                if (HighlightingON.Checked == true)
                {
                    foreach (Square possiblemove in possiblemoves)
                    {
                        if (possiblemove != null)
                        {
                            if (squares[possiblemove.X, possiblemove.Y] != null)
                            {
                                if (squares[possiblemove.X, possiblemove.Y].Tag.ToString() == "Darkwood")
                                {
                                    setDarkStyleSquares_Green(squares[possiblemove.X, possiblemove.Y]);
                                }
                                else
                                {
                                    setLightStyleSquares_Green(squares[possiblemove.X, possiblemove.Y]);
                                }

                            }
                        }

                    }
                    // if the only possible move is the pieces current position, then do not highlight
                    //this indicates to the user that this piece cannot move anywhere.
                    if (possiblemoves.Length == 1)
                    {

                        if ((string)currentPicBox.Tag.ToString() == "Darkwood")
                        {
                            setDarkStyleSquares(currentPicBox);
                        }
                        if (currentPicBox.Tag.ToString() == "Lightwood")
                        {
                            setLightStyleSquares(currentPicBox);
                        }
                    }
                }
                else
                {
                    if (possiblemoves.Length > 1)
                    {
                        if ((string)currentPicBox.Tag.ToString() == "Darkwood")
                        {
                            setDarkStyleSquares_Green(currentPicBox);
                        }
                        if (currentPicBox.Tag.ToString() == "Lightwood")
                        {
                            setLightStyleSquares_Green(currentPicBox);
                        }
                    }
                }

            }

        }
    // this checks whether the current player is in the checkmate game state
        private bool isCheckMated()
        {
            //the clicked piece variable is going to change as a result of a temporary move
            // so it is stored temporarily to return to the current game state
            Piece tempPieceHolder = clickedPiece;
            int nullCounter = 0;     // a null counter to count all the pieces that have no possible moves

            if (BoardAdmin.game1.getTurn() == Piece.Piececolour.WHITE) 
            {
                PieceSet WhitePieces = gameBoard.getPieceSets()[1]; 
                foreach (Piece aPiece in WhitePieces.getPieceSet()) 
                {
                    possiblemoves = aPiece.getPossibleMoves(gameBoard); 
                    clickedPiece = aPiece; 
                   
                    
                    foreach (Square possiblemove in possiblemoves) 
                    {
                        if (possiblemove != aPiece.getPosition()) 
                        {
                            makeTempMove(possiblemove); // makes the temporary move from that possible move in the list, the makeTempMove algorithm will make any non-valid moves null.
                        }
                        else // otherwise, make the move null as you cant move to the current square.
                        {
                            int index = Array.IndexOf(possiblemoves, possiblemove); // gets index of the position of the possible move
                            possiblemoves[index] = null; 
                            
                        }
                    }

                    bool a = false; // a boolean flag to store a simple result of whether all moves are invalid.
                    int nullcounter2 = 0; // a counter to count how many possible moves are null for an individual piece
                   
                    foreach (Square possiblemove in possiblemoves)
                    {
                        if (possiblemove == null) 
                        {
                            nullcounter2++; 
                        }
                    }
                    // if ALL possible moves are null then set the boolean flag to true
                    if (nullcounter2 == possiblemoves.Length)
                    {
                        a = true; 
                    }
                    // otherwise set the boolean flag to false
                    if (nullcounter2 != possiblemoves.Length)
                    {
                        a = false;
                    }
                    
                    if (a == true)
                    {
                        nullCounter++;
                    }
                    //clear the possible moves array for the next piece in the for loop
                    Array.Clear(possiblemoves, 0, possiblemoves.Length);

                }

                clickedPiece = tempPieceHolder; 

                
                if (nullCounter ==WhitePieces.getPieceSet().Count)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else  // runs to check whether BLACK is in check mate then runs the same code but for black pieces specifically.
            {
                PieceSet BlackPieces = gameBoard.getPieceSets()[0];
                foreach (Piece aPiece in BlackPieces.getPieceSet())
                {
                    possiblemoves = aPiece.getPossibleMoves(gameBoard);
                    clickedPiece = aPiece;
                    
                    foreach (Square possiblemove in possiblemoves)
                    {
                        if (possiblemove != aPiece.getPosition())
                        {
                            makeTempMove(possiblemove);
                        }
                        else
                        {
                            int index = Array.IndexOf(possiblemoves, possiblemove);
                            possiblemoves[index] = null;

                        }

                    }

                    bool a = false;
                    int nullcounter2 = 0;

                    foreach (Square possiblemove in possiblemoves)
                    {
                        if (possiblemove == null)
                        {
                            nullcounter2++;
                        }
                    }

                    if (nullcounter2 == possiblemoves.Length)
                    {
                        a = true;
                    }
                    if (nullcounter2 != possiblemoves.Length)
                    {
                        a = false;
                    }

                    if (a == true)
                    {
                        nullCounter++;
                    }

                    Array.Clear(possiblemoves, 0, possiblemoves.Length);
                }
                clickedPiece = tempPieceHolder;
                if (nullCounter == BlackPieces.getPieceSet().Count)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }


        }
        // the procedure to make a move temporarily to evaluate something then retract that move
        private void makeTempMove(Square possiblemove)
        {
            BoardAdmin.TempMoving = true; //boolean variable for temp moving


            if (BoardAdmin.game1.getTurn() == BoardAdmin.game1.getPlayer1().getPlayerColour()) 
            {
                //makes temp move
                BoardAdmin.game1.getPlayer1().makeMove(possiblemove, gameBoard, clickedPiece); 
           
                if (BoardAdmin.game1.getPlayer1().isInCheck(gameBoard) == true) // the isInCheck method is invoked to determine whether the player is in check
                {
                    // if so, disregard the move
                    int index = Array.IndexOf(possiblemoves, possiblemove); 
                    possiblemoves[index] = null; 
                }

                BoardAdmin.game1.undoLastMove(); 

            }
            else // otherwise it is player 2's turn
            {

                BoardAdmin.game1.getPlayer2().makeMove(possiblemove, gameBoard, clickedPiece); 

                if (BoardAdmin.game1.getPlayer2().isInCheck(gameBoard) == true)  
                {
                    int index = Array.IndexOf(possiblemoves, possiblemove);  
                    possiblemoves[index] = null; 
                }

                BoardAdmin.game1.undoLastMove(); 

            }

            BoardAdmin.TempMoving = false;  
        }

        // event that is run when a piece is being moved
        private void PieceMovingClickEvent(PictureBox currentPicBox)
        {
            Square clickedSquare = new Square();

            // gets the square that was clicked by mapping the picture box array index onto the square array.
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (squares[i, j] == currentPicBox)
                        {
                            clickedSquare = gameBoard.getSquares()[i, j];
                        }
                    }

                }
                
            

                if (possiblemoves != null)
                {
                    // if the clicked square is one of the possible moves then make the move
                    if (possiblemoves.Contains(clickedSquare) == true)
                    {
                                              
                        if (BoardAdmin.game1.getPlayer1().getPlayerColour() == BoardAdmin.game1.getTurn())
                        {
                        
                             BoardAdmin.game1.getPlayer1().makeMove(clickedSquare, gameBoard, clickedPiece);
                           

                        
                        }
                        if (BoardAdmin.game1.getPlayer2().getPlayerColour() == BoardAdmin.game1.getTurn())
                        {
                        
                            BoardAdmin.game1.getPlayer2().makeMove(clickedSquare, gameBoard, clickedPiece);
                       
                        }

                        // update the move history text box with the latest move
                    updateUnicodeMoveBox(BoardAdmin.game1.getMoveHistory().Last<Move>());

                        if (BoardAdmin.game1.getTurn() == Piece.Piececolour.WHITE)
                        {
                            BoardAdmin.game1.setTurn(Piece.Piececolour.BLACK);
                        }
                        else
                        {
                            BoardAdmin.game1.setTurn(Piece.Piececolour.WHITE);
                        }
                    }

                    //This is where the maths question is called - a check is needed to determine that the click event 
                    //corresponds to a moving piece of the current player.
                    if (clickedPiece != null)
                    {
                        if (clickedPiece.getColour() != BoardAdmin.game1.getTurn())
                        {
                            if (BoardAdmin.game1.getGameType() == Game.gameType.Maths)
                                // if it is a maths game then a question must be presented to the player
                            {
                                AskQuestion aAskQuestionForm = new AskQuestion();

                                UpdateViewTimer.Enabled = false;

                                if (aAskQuestionForm.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                                {
                                    //Waits until the question form has been dealt with 
                                    
                                }
                                UpdateViewTimer.Enabled = true;
                            }
                        }
                    }

                    clickedPiece = null;
                    Array.Clear(possiblemoves, 0, possiblemoves.Length);
                    
                    // checks whether this move has resulted in check mate
                    if (isCheckMated() == true)
                    {
                        UpdateViewTimer.Enabled = false;

                        foreach (PictureBox square in squares)
                        {
                            square.Enabled = false;
                        }
                        string TempText = UnicodeMoveBox.Text;
                        UnicodeMoveBox.Clear();

                        // updates the unicode move box with the game result
                        if (BoardAdmin.game1.getTurn() == Piece.Piececolour.BLACK)
                        {
                            BoardAdmin.game1.setGameResult(Game.result.WhiteWon);
                            MessageBox.Show("WHITE WON! \x2654  (CheckMate)");
                            UnicodeMoveBox.AppendText("WHITE WON! \x2654  (CheckMate)" + Environment.NewLine + TempText);
                        }
                        else
                        {
                            BoardAdmin.game1.setGameResult(Game.result.BlackWon);
                            MessageBox.Show("BLACK WON! \x265A  (CheckMate)");
                            UnicodeMoveBox.AppendText("BLACK WON! \x265A  (CheckMate)" + Environment.NewLine + TempText);

                        }
                        // disable the undo move button as the game has finished
                        // the user may still look throught the list f moves made in the text box 
                        undoMoveButton.Enabled  = false;

                    }

                }
            }

        
        // finds the piece that is on the picturebox that has been clicked
        private Piece getPieceOnSquare(PictureBox clickedPicBox)
        {
            // the coorindates of the clicked picture box will correspond in parallel to the cooridnates of the square object.
            int x = 0;
            int y = 0;
            Piece clickedPiece = null;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (squares[i, j] == clickedPicBox)
                    {
                        x = i;
                        y = j;
                    }
                }

            }

            //scans the piece sets to find the piece that was clicked
            foreach (Piece piece in pieceSets[0].getPieceSet())
            {
                if (piece.getPosition().X == x && piece.getPosition().Y == y)
                {
                    clickedPiece = piece;
                }
            }
            foreach (Piece piece in pieceSets[1].getPieceSet())
            {
                if (piece.getPosition().X == x && piece.getPosition().Y == y)
                {
                    clickedPiece = piece;
                }
            }

            return clickedPiece; // return the piece that is occupyng the square on the board

        }

        //resets the backgrounds of the pictureboxes
        private void resetSquarebackgrounds()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if(squares[i,j].Tag.ToString() == "Darkwood")
                    {
                        setDarkStyleSquares(squares[i, j]);
                    }
                    if (squares[i, j].Tag.ToString() == "Lightwood")
                    {
                        setLightStyleSquares(squares[i, j]);
                    }
                }
            }
        }

        // this is needed to change the highlighting of squares dynamically when the highlighting toggle is swiched on and off
        private void ChangeStaticHighlighting()
        {
            if (possiblemoves != null)
            {
                

                foreach (Square possiblemove in possiblemoves)
                {
                    if (possiblemove != null)
                    {
                        if (squares[possiblemove.X, possiblemove.Y] != null)
                        {
                            if (squares[possiblemove.X, possiblemove.Y].Tag.ToString() == "Darkwood")
                            {
                                if (HighlightingOFF.Checked == true)
                                {
                                    // if highlighting is off, but the piece can still move then highlight the piece square only.
                                    if (squares[possiblemove.X, possiblemove.Y] == currentPicBox)
                                    {
                                        setDarkStyleSquares_Green(squares[possiblemove.X, possiblemove.Y]);
                                    }
                                    else
                                    {
                                        setDarkStyleSquares(squares[possiblemove.X, possiblemove.Y]);
                                    }                          
                                }
                                else
                                {
                                    // otherwise highlight all possible move squares in green
                                    setDarkStyleSquares_Green(squares[possiblemove.X, possiblemove.Y]);
                                }
                            }
                            else // otherwise it is light squares
                            {
                                if (HighlightingOFF.Checked == true)
                                {                                   
                                        if (squares[possiblemove.X, possiblemove.Y] == currentPicBox)
                                        {
                                            setLightStyleSquares_Green(squares[possiblemove.X, possiblemove.Y]);
                                        }
                                        else
                                        {
                                           setLightStyleSquares(squares[possiblemove.X, possiblemove.Y]);
                                        }
                                }
                                else
                                {
                                   setLightStyleSquares_Green(squares[possiblemove.X,possiblemove.Y]);
                                }
                            }

                        }
                    }      
                }
                if (possiblemoves.Length == 1) // if the possible moves array only contains the occupying square then do not highlight.
                {

                    if ((string)currentPicBox.Tag.ToString() == "Darkwood")
                    {
                        setDarkStyleSquares(currentPicBox);
                    }
                    if (currentPicBox.Tag.ToString() == "Lightwood")
                    {
                        setLightStyleSquares(currentPicBox);
                    }
                }
            }
        }

        // toggling of the highlighing option on the form
        private void HighlightingON_CheckedChanged(object sender, EventArgs e)
        {
            ChangeStaticHighlighting();
        }

        private void HighlightingOFF_CheckedChanged(object sender, EventArgs e)
        {

            ChangeStaticHighlighting();
        }

        //  this procedure changes the image of the current picture box to one without green highlighting
        private void setDarkStyleSquares(PictureBox aPicBox)
        {
            if (BoardAdmin.gameStyle == "WOOD")
            {
                aPicBox.BackgroundImage = test_chess.Properties.Resources.DarkWoodSquare;
            }
            if (BoardAdmin.gameStyle == "MARBLE")
            {
                aPicBox.BackgroundImage = test_chess.Properties.Resources.BlueMarble;
            }
            if (BoardAdmin.gameStyle == "PLAINBLUE")
            {
                aPicBox.BackgroundImage = test_chess.Properties.Resources.DarkBlue;
            }
            if (BoardAdmin.gameStyle == "PLAINPURPLE")
            {
                aPicBox.BackgroundImage = test_chess.Properties.Resources.DarkPurple;
            }
            if (BoardAdmin.gameStyle == "PLAINBROWN")
            {
                aPicBox.BackgroundImage = test_chess.Properties.Resources.DarkBrown;
            }
            if (BoardAdmin.gameStyle == "PLAINRED")
            {
                aPicBox.BackgroundImage = test_chess.Properties.Resources.DarkRed;
            }
        }

        //  this procedure changes the image of the current picture box to one without green highlighting
        private void setLightStyleSquares(PictureBox aPicBox)
        {
            if (BoardAdmin.gameStyle == "WOOD")
            {
                aPicBox.BackgroundImage = test_chess.Properties.Resources.LightWoodSquare;
            }
            if (BoardAdmin.gameStyle == "MARBLE")
            {
                aPicBox.BackgroundImage = test_chess.Properties.Resources.WhiteMarble;
            }
            if (BoardAdmin.gameStyle == "PLAINBLUE")
            {
                aPicBox.BackgroundImage = test_chess.Properties.Resources.LightBlue;
            }
            if (BoardAdmin.gameStyle == "PLAINPURPLE")
            {
                aPicBox.BackgroundImage = test_chess.Properties.Resources.LightPurple;
            }
            if (BoardAdmin.gameStyle == "PLAINBROWN")
            {
                aPicBox.BackgroundImage = test_chess.Properties.Resources.LightBrown;
            }
            if (BoardAdmin.gameStyle == "PLAINRED")
            {
                aPicBox.BackgroundImage = test_chess.Properties.Resources.LightRed;
            }
        }
        //  this procedure changes the image of the current picture box to one *with* green highlighting
        private void setDarkStyleSquares_Green(PictureBox aPicBox)
        {
            if (BoardAdmin.gameStyle == "WOOD")
            {
                aPicBox.BackgroundImage = test_chess.Properties.Resources.DarkWoodSquare_greenBorder;
            }
            if (BoardAdmin.gameStyle == "MARBLE")
            {
                aPicBox.BackgroundImage = test_chess.Properties.Resources.BlueMarble_GreenBorder;
            }
            if (BoardAdmin.gameStyle == "PLAINBLUE")
            {
                aPicBox.BackgroundImage = test_chess.Properties.Resources.DarkBlue_GreenBorder;
            }
            if (BoardAdmin.gameStyle == "PLAINPURPLE")
            {
                aPicBox.BackgroundImage = test_chess.Properties.Resources.DarkPurple_GreenBorder;
            }
            if (BoardAdmin.gameStyle == "PLAINBROWN")
            {
                aPicBox.BackgroundImage = test_chess.Properties.Resources.DarkBrown_GreenBorder;
            }
            if (BoardAdmin.gameStyle == "PLAINRED")
            {
                aPicBox.BackgroundImage = test_chess.Properties.Resources.DarkRed_GreenBorder;
            }
        }
        //  this procedure changes the image of the current picture box to one *with* green highlighting
        private void setLightStyleSquares_Green(PictureBox aPicBox)
        {
            if (BoardAdmin.gameStyle == "WOOD")
            {
                aPicBox.BackgroundImage = test_chess.Properties.Resources.LightWoodSquare_greenBorder;
            }
            if (BoardAdmin.gameStyle == "MARBLE")
            {
                aPicBox.BackgroundImage = test_chess.Properties.Resources.WhiteMarble_GreenBorder;
            }
            if (BoardAdmin.gameStyle == "PLAINBLUE")
            {
                aPicBox.BackgroundImage = test_chess.Properties.Resources.LightBlue_GreenBorder;
            }
            if (BoardAdmin.gameStyle == "PLAINPURPLE")
            {
                aPicBox.BackgroundImage = test_chess.Properties.Resources.LightPurple_GreenBorder;
            }
            if (BoardAdmin.gameStyle == "PLAINBROWN")
            {
                aPicBox.BackgroundImage = test_chess.Properties.Resources.LightBrown_GreenBorder;
            }
            if (BoardAdmin.gameStyle == "PLAINRED")
            {
                aPicBox.BackgroundImage = test_chess.Properties.Resources.LightRed_GreenBorder;
            }
        }

        // updates the textbox containing the list of moves made in unicode format
        // uses unicode hexadecimal codes for chess piece icons
        // the move object from the game's history is used as a reference
        private void updateUnicodeMoveBox(Move aMove)
        {
            string tempText = UnicodeMoveBox.Text;
            UnicodeMoveBox.Clear();

            UnicodeMoveBox.AppendText( BoardAdmin.game1.getMoveHistory().Count + ". ");

            if (aMove.PieceMoved.getType() == Piece.pieceType.BISHOP)
            {
                if (BoardAdmin.game1.getTurn() == Piece.Piececolour.BLACK)
                {
                    UnicodeMoveBox.AppendText("\x265D");
                }
                else
                {
                    UnicodeMoveBox.AppendText("\x2657");
                }
            }
            if (aMove.PieceMoved.getType() == Piece.pieceType.KING)
            {
                if (BoardAdmin.game1.getTurn() == Piece.Piececolour.BLACK)
                {
                    UnicodeMoveBox.AppendText("\x265A");
                }
                else
                {
                    UnicodeMoveBox.AppendText("\x2654");
                }
            }
            if (aMove.PieceMoved.getType() == Piece.pieceType.KNIGHT)
            {
                if (BoardAdmin.game1.getTurn() == Piece.Piececolour.BLACK)
                {
                    UnicodeMoveBox.AppendText("\x265E");
                }
                else
                {
                    UnicodeMoveBox.AppendText("\x2658");
                }
            }
            if (aMove.PieceMoved.getType() == Piece.pieceType.PAWN)
            {
                if (BoardAdmin.game1.getTurn() == Piece.Piececolour.BLACK)
                {
                    UnicodeMoveBox.AppendText("\x265F");
                }
                else
                {
                    UnicodeMoveBox.AppendText("\x2659");
                }
            }
            if (aMove.PieceMoved.getType() == Piece.pieceType.QUEEN)
            {
                if (BoardAdmin.game1.getTurn() == Piece.Piececolour.BLACK)
                {
                    UnicodeMoveBox.AppendText("\x265B");
                }
                else
                {
                    UnicodeMoveBox.AppendText("\x2655");
                }
            }
            if (aMove.PieceMoved.getType() == Piece.pieceType.ROOK)
            {
                if (BoardAdmin.game1.getTurn() == Piece.Piececolour.BLACK)
                {
                    UnicodeMoveBox.AppendText("\x265C");
                }
                else
                {
                    UnicodeMoveBox.AppendText("\x2656");
                }
            }

            string initialPosition = squares[aMove.initialPosition.X,aMove.initialPosition.Y].Name;
            string finalPosition = squares[aMove.finalPosition.X,aMove.finalPosition.Y].Name;



            UnicodeMoveBox.AppendText(" " + initialPosition + "\x02C3\x02C3 " + finalPosition);

            if (aMove.pieceCaptured != null)
            {
                UnicodeMoveBox.AppendText(Environment.NewLine + "Captured: ");

                if (aMove.pieceCaptured.getType() == Piece.pieceType.BISHOP)
                {
                    if (aMove.pieceCaptured.getColour() == Piece.Piececolour.BLACK)
                    {
                        UnicodeMoveBox.AppendText("\x265D");
                    }
                    else
                    {
                        UnicodeMoveBox.AppendText("\x2657");
                    }
                }
                if (aMove.pieceCaptured.getType() == Piece.pieceType.KING)
                {
                    if (aMove.pieceCaptured.getColour() == Piece.Piececolour.BLACK)
                    {
                        UnicodeMoveBox.AppendText("\x265A");
                    }
                    else
                    {
                        UnicodeMoveBox.AppendText("\x2654");
                    }
                }
                if (aMove.pieceCaptured.getType() == Piece.pieceType.KNIGHT)
                {
                    if (aMove.pieceCaptured.getColour() == Piece.Piececolour.BLACK)
                    {
                        UnicodeMoveBox.AppendText("\x265E");
                    }
                    else
                    {
                        UnicodeMoveBox.AppendText("\x2658");
                    }
                }
                if (aMove.pieceCaptured.getType() == Piece.pieceType.PAWN)
                {
                    if (aMove.pieceCaptured.getColour() == Piece.Piececolour.BLACK)
                    {
                        UnicodeMoveBox.AppendText("\x265F");
                    }
                    else
                    {
                        UnicodeMoveBox.AppendText("\x2659");
                    }
                }
                if (aMove.pieceCaptured.getType() == Piece.pieceType.QUEEN)
                {
                    if (aMove.pieceCaptured.getColour() == Piece.Piececolour.BLACK)
                    {
                        UnicodeMoveBox.AppendText("\x265B");
                    }
                    else
                    {
                        UnicodeMoveBox.AppendText("\x2655");
                    }
                }
                if (aMove.pieceCaptured.getType() == Piece.pieceType.ROOK)
                {
                    if (aMove.pieceCaptured.getColour() == Piece.Piececolour.BLACK)
                    {
                        UnicodeMoveBox.AppendText("\x265C");
                    }
                    else
                    {
                        UnicodeMoveBox.AppendText("\x2656");
                    }
                } 
            }

            UnicodeMoveBox.AppendText(Environment.NewLine);
            UnicodeMoveBox.AppendText(tempText);
        }

        // calls the undo procedure from the game object
        private void undoLastMove()
        {

            //System.Windows.Forms.MessageBox.Show("TEST");
            BoardAdmin.game1.undoLastMove();
            
            updateUnicodeText_afterRemoval();
            
        }

        // when a 
        private void updateUnicodeText_afterRemoval()
        {
            if (UnicodeMoveBox.Enabled == true)
            {
                // if the contents is not empty
                if (UnicodeMoveBox.Text != "")
                {
                    // remove the first line ( the move that has been undone )
                    UnicodeMoveBox.Text = UnicodeMoveBox.Text.Remove(0, UnicodeMoveBox.Lines[0].Length);

                    // store the remaining text temporarily
                    string tempText = UnicodeMoveBox.Text;
                    tempText = tempText.Trim();    // trim any preceding white trailing spaces
                    UnicodeMoveBox.Text = (tempText);  // replace the text without the blank line

                    if (tempText.StartsWith("C"))  // if a piece was captured then the line will start with a C
                    {
                        updateUnicodeText_afterRemoval();  // run the procedure again, recursively, to remove this line also
                    }

                }
            }
        }

        private void Player2Label_Click(object sender, EventArgs e)
        {

        }

       

        private void undoMoveButton_Click(object sender, EventArgs e)
        {
            //System.Windows.Forms.MessageBox.Show("TEST3");
            undoLastMove();
        }
    }
}
