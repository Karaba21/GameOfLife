using System.Text;

namespace PII_Game_Of_Life{
    public class Tablero{
        public bool[,] gameBoard {get;}
        public int boardWidth{get;}
        public int boardHeight {get;}

        public Tablero (bool[,] board)
        {
            this.gameBoard = board;
            this.boardHeight = board.GetLength(0);
            this.boardWidth = board.GetLength(1);
        }
    }
}
