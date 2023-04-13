using System;

namespace PII_Game_Of_Life
{
    //Esta clase va a tener la responsabilidad de contener un tablero
    public class Tablero
    {
      public Tablero()
      {
        this.tablero = TraerTablero.CargarTablero(); 
      }

      ~Tablero()
      {
        Console.WriteLine("Se me rompió un tablero.");
      }

      private bool[,] tablero {get; set;}

      public void copiarTablero(Tablero nuevoTablero)
      {
        this.tablero = nuevoTablero.tablero;
      }

      public int getHeight()
      {
        return this.tablero.GetLength(1);
      }

      public int getWidth()
      {
        return this.tablero.GetLength(0);
      }

      public bool getCell(int x, int y) 
      {
        return tablero[x,y];
      }

      public void setCell(int x,int y,bool alive)
      {
        tablero[x,y] = alive;
      }
    };
}