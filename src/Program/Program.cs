using System;

namespace PII_Game_Of_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[,] boardFile = importadorArchivo.LeerArchivo();
            Tablero board = new Tablero(boardFile);
            DibujarTabla.dibujarTablero(board.gameBoard);
        }
    }
}
