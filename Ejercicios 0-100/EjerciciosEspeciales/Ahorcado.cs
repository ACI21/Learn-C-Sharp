namespace Ejercicios_Especiales;

using System.Data.Common;
using System.Text;

public class Ahorcado
{
    public static void main()
    {
        //bucle para volver a jugar
        string bucle = "SI";
        do
        {
            //guardamos la palabra del juego
            string palabra = PalabraAdivinar().ToUpper();
            //Se asigna entre 1 y 25 vidas
            int vidas = MaximoFallos();
            //Se limpia la terminal
            Console.Clear();
            //Comienza la partida con los datos anteriores
            Jugar(palabra, vidas);

            //Preguntamos si quiere volver a jugar
            Console.WriteLine("¿Quieres volver a jugar: SI / NO?");
            bucle = Console.ReadLine() ?? "NO";
            //pasamos la respuesta a mayusculas
            bucle = bucle.ToUpper();
        } while (bucle == "SI");

        Console.WriteLine("Gracias por jugar!!");
    }

    private static string PalabraAdivinar()
    {
        string[] palabras = { "bucle", "programacion", "java", "funciones" };
        Random rndm = new Random();
        return palabras[rndm.Next(0, palabras.Length)];
    }

    private static int MaximoFallos()
    {
        Random rndm = new Random();
        return rndm.Next(1, 25);
    }

    private static void Jugar(string palabra, int vidas)
    {
        Console.WriteLine("¡Que comience el juego!");
        bool finJuego = false;
        StringBuilder palabraParcial = new StringBuilder();
        int guiones = 0;
        palabraParcial = PalabraGuiones(palabra, out guiones);
        do
        {
            EstadoJugador(vidas, palabraParcial);
            palabraParcial = PideLetra(palabra, palabraParcial, out vidas, vidas);
            ComprobarFinJuego(out finJuego, guiones, palabraParcial);
            if (vidas <= 0) break;

        } while (!finJuego);
        FinDelJuego(palabra, vidas); ;
    }

    private static StringBuilder PalabraGuiones(string palabra, out int guiones)
    {
        StringBuilder palabraParcial = new StringBuilder();
        palabraParcial.Append(palabra);
        for (char i = 'A'; i <= 'Z'; i++)
        {
            palabraParcial.Replace(i, '_');
        }
        guiones = palabraParcial.Length;
        return palabraParcial;
    }

    private static void EstadoJugador(int vidas, StringBuilder palabraParcial)
    {
        ComprobarVidas(vidas);
        ComprobarPalabra(palabraParcial);
    }

    private static StringBuilder PideLetra(string palabra, StringBuilder palabraParcial, out int vidas, int copyVidas)
    {
        Console.Write("Introduce una letra: ");
        string letraString = Console.ReadLine() ?? " ";
        Console.WriteLine();
        letraString = letraString.ToUpper();
        char letra = letraString[0];
        palabraParcial = ComprobarLetra(palabra, letra, palabraParcial, out vidas, copyVidas);
        return palabraParcial;
    }

    private static void ComprobarPalabra(StringBuilder palabraParcial)
    {
        Console.WriteLine("Palabra: {0}", palabraParcial.ToString());
    }

    private static void ComprobarVidas(int vidas)
    {
        Console.WriteLine("Tienes {0} vidas disponibles", vidas);
    }

    private static StringBuilder ComprobarLetra(string palabra, char letra, StringBuilder palabraParcial, out int vidas, int copyVidas)
    {
        bool existe = false;
        for (int i = 0; i < palabraParcial.Length; i++)
        {
            if (palabra[i] == letra)
            {
                palabraParcial[i] = letra;
                existe = true;
            }
        }

        if (!existe)
        {
            copyVidas -= 1;
        }

        vidas = copyVidas;

        return palabraParcial;
    }

    private static void ComprobarFinJuego(out bool finJuego, int guiones, StringBuilder palabraParcial)
    {
        for (int i = 0; i < palabraParcial.Length; i++)
        {
            if (palabraParcial[i] != '_')
            {
                guiones--;
            }
        }

        if (guiones == 0)
        {
            finJuego = true;
        }
        else
        {
            finJuego = false;
        }
    }

    private static void FinDelJuego(string palabra, int vidas)
    {
        StringBuilder palabrita = new StringBuilder();
        palabrita.Append(palabra);
        if (vidas <= 0)
        {
            EstadoJugador(vidas, palabrita);
            Console.WriteLine("Suerte la próxima vez");
        }
        else
        {
            EstadoJugador(vidas, palabrita);
            Console.WriteLine("¡Enhorabuena lo has conseguido!");
        }
    }
}