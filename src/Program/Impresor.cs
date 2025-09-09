using System;
using System.Text;
using System.Threading;

namespace Ucu.Poo.GameOfLife
{

    public class Impresor
    {
        public void ImprimirTablero(Tablero Impresor)
        {
            bool[,] Tablero; //variable que representa el tablero
            int Ancho= Impresor.Ancho; //variabe que representa el ancho del tablero
            int Altura= Impresor.Altura; //variabe que representa altura del tablero
            while (true)
            {
                Console.Clear();
                StringBuilder s = new StringBuilder();
                for (int y = 0; y < Altura; y++)
                {
                    for (int x = 0; x < Ancho; x++)
                    {
                        if (Impresor.EstadoDeCelula(x, y))
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
                NextGen.CalcularGeneracion(Impresor);
                Thread.Sleep(300);
            }
        }
    }
}