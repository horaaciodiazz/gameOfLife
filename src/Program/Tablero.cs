namespace Ucu.Poo.GameOfLife;

public class Tablero
{
    private bool[,] matriz;
    private int altura;
    private int ancho;

    public int Altura
    {
        get { return altura; }
        set { altura = value; }
    }

    public int Ancho
    {
        get { return ancho; }
        set { ancho = value; }
    }

    public bool EstadoDeCelula(int x, int y)
    {
        return matriz[x,y];
    }

    public void CambiarCelula(int x, int y, bool valor)
    {
        matriz[x,y] = valor;
    }

    public Tablero(int altura, int ancho)
    {
        this.altura = altura;
        this.ancho = ancho;
        this.matriz = new bool[altura, ancho];

    }
}