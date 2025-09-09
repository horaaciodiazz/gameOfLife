namespace Ucu.Poo.GameOfLife;

public class Tablero
{
    private bool[,] matriz;
    public int altura;
    public int ancho;
            
    private int Altura
    {
        get { return altura; }
        set { altura = value; }
    }

    private int Ancho
    {
        get { return ancho; }
        set { ancho = value; }
    }
    
    public bool EstadoDeCelula(int x, int y)
    {
        return matriz[y, x];
    }
    public void CambiarCelula(int x, int y, bool valor)
    {
        matriz[y, x] = valor;
    }
}