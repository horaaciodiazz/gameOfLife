namespace Ucu.Poo.GameOfLife;

public class Lector
{
    public void Leer(Tablero Lector)
    {
    bool[,] Tablero    //variable que representa el tablero
    int Ancho  //variabe que representa el ancho del tablero
    int Altura    //variabe que representa altura del tablero
    while (true)
    {
        Console.Clear();
        StringBuilder s = new StringBuilder();
        for (int y = 0; y < Altura; y++)
        {
            for (int x = 0; x < Ancho; x++)
            {
                if (Tablero[x, y])
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
        //=================================================
        //Invocar método para calcular siguiente generación
        //=================================================
        Thread.Sleep(300);
    }
    }
}