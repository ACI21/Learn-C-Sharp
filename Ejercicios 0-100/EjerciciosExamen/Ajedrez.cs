namespace Ejercicios_Examen;

public class Ajedrez
{
    public static void main()
    {
        Tablero tablero = new Tablero();

        // Inicialización del tablero
        tablero.PonPieza("A1", new Torre(ColorAjedrez.Blanco));
        tablero.PonPieza("C8", new Alfil(ColorAjedrez.Negro));
        tablero.PonPieza("B6", new Peon(ColorAjedrez.Negro));
        tablero.PonPieza("B3", new Caballo(ColorAjedrez.Blanco));

        Console.WriteLine(tablero); // Salida:
        // Alfil Blanco en C8 Negro
        // Peon Negro en B6 Blanco
        // Caballo Negro en B3 Blanco
        // Torre Blanco en A1 Blanco
        // Valor total blancas = 9
        // Valor total negras = 4

        // Movimientos
        tablero.QuitaPieza("B3");
        tablero.PonPieza("B7", new Peon(ColorAjedrez.Negro));
        tablero.PonPieza("H3", new Alfil(ColorAjedrez.Blanco));

        Console.WriteLine(tablero); // Salida:
        // Peon Negro en B7 Blanco
        // Alfil Blanco en H3 Blanco
        // Torre Blanco en A1 Blanco
        // Valor total blancas = 9
        // Valor total negras = 1
    }
}