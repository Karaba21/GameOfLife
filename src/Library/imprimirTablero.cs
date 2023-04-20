using System;
using System.Text;

public class imprimirTablero{

    public static bool[,] imprimirTablero(bool[,] tablero)
    {
        bool[,] b = tablero;
        int width = b.GetLength(0);
        int height = b.GetLength(1);
        while (true)
        {
            Console.Clear();
            StringBuilder a = new StringBuilder();
            for (int y = 0; y<height; y++)
            {
                for (int x = 0; x<width; x++)
                {
                    if (b[x,y])
                    {
                        a.Append("|X|");
                    }
                    else
                    {
                        a.Append("__");
                    }
                }
                a.Append("\n");
            }
            Console.WriteLine(a.ToString());
            b= Logica.Play(b);
            Thread.Sleep(300);
        }
    }
}