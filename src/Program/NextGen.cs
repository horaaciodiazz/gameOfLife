namespace Ucu.Poo.GameOfLife;

public class NextGen
{
   public void CalcularGeneracion(Tablero nextgen) 
   {
      int boardWidth = nextgen.Ancho;
      int boardHeight = nextgen.Altura;

      Tablero cloneboard = new Tablero(boardWidth, boardHeight);
      for (int x = 0; x < boardWidth; x++)
      {
         for (int y = 0; y < boardHeight; y++)
         {
            int aliveNeighbors = 0;
            for (int i = x-1; i<=x+1;i++)
            {
               for (int j = y-1;j<=y+1;j++)
               {
                  if(i>=0 && i<boardWidth && j>=0 && j < boardHeight && nextgen.EstadoDeCelula(i,j))
                  {
                     aliveNeighbors++;
                  }
               }
            }
            if(nextget.EstadoDeCelula(x,y))
            {
               aliveNeighbors--;
            }
            if (nextget.EstadoDeCelula(x,y) && aliveNeighbors < 2)
            {
               //Celula muere por baja población
               cloneboard[x,y] = false;
            }
            else if (nextget.EstadoDeCelula(x,y) && aliveNeighbors > 3)
            {
               //Celula muere por sobrepoblación
               cloneboard[x,y] = false;
            }
            else if (!nextget.EstadoDeCelula(x,y) && aliveNeighbors == 3)
            {
               //Celula nace por reproducción
               cloneboard[x,y] = true;
            }
            else
            {
               //Celula mantiene el estado que tenía
               cloneboard[x,y] = nextget.EstadoDeCelula(x,y);
            }
         }
      }
      nextgen = cloneboard;
   }
}