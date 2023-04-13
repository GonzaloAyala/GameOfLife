using System;
using System.Text;
using System.Threading;

namespace PII_Game_Of_Life
{
    //Esta clase tiene la responsabilidad de imprimir el tablero
    public class ImprimirTablero
    {
        public static void printTablero(Tablero tab)
        {
            Console.Clear();
            StringBuilder s = new StringBuilder();
            for (int y = 0; y<tab.getHeight();y++)
            {
                for (int x = 0; x<tab.getWidth(); x++)
                {
                    if(tab.getCell(x,y))
                    {
                        s.Append("|X|");
                    }
                    else
                    {
                        s.Append("___");
                    }
                }
                s.Append("\n");
            }
            Console.WriteLine(s.ToString());
        }
    }
}