using System;
using System.Text;
using System.Threading;

namespace PII_Game_Of_Life{
    public class DibujarTabla{
        public static void dibujarTablero(bool[,] board)
        {
            bool[,] gameBoard = board;
            int width = board.GetLength(0);
            int height = board.GetLength(0);

            while (true)
            {
                Console.Clear();
                StringBuilder s = new StringBuilder();
                
                for (int y=0; y<height;y++)
                {
                    for (int x=0;x<width;x++)
                    {
                        if (gameBoard[x,y])
                        {
                            s.Append("|X|");
                        }
                        else
                        {
                        s. Append ("___");
                        }
                    }
                    s.Append("\n");
                }
                Console.WriteLine(s.ToString());
                gameBoard = Logica.Play(gameBoard);
                Thread.Sleep(300);
            }
        }
    }
}