namespace Ucu.Poo.GameOfLife;

using System.IO;

public class Lectura
{
    public Tablero Leer(string url)
    {
        string content = File.ReadAllText(url);
        string[] contentLines = content.Split('\n');
        
        Tablero tablero = new Tablero(contentLines.Length, contentLines[0].Length); //contentLines.Length, contentLines[0].Length
        for (int y = 0; y < contentLines.Length; y++)
        {
            for (int x = 0; x < contentLines[y].Length; x++)
            {
                if (contentLines[y][x] == '1')
                {
                    tablero.CambiarCelula(x, y, true);
                }
            }
        }

        return tablero;
    }
}