using System;

namespace Ucu.Poo.GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            Lectura leer = new Lectura();
            Tablero tablero = leer.Leer("board.txt");
            Impresor impresora = new Impresor();
            
            while (true)
            {
                impresora.ImprimirTablero(tablero);
            }

        }
    }
}
