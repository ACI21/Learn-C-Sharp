using System.ComponentModel.DataAnnotations.Schema;

namespace Ejercicios_0_100;

public class Program
{
    public static void Main(string[] args)
    {
        int opciones = 0;
        do
        {
            try
            {
                imprimirMenu();
                opciones = int.Parse(Console.ReadLine() ?? "0");
                AbrirEjercicio(opciones, args);
            }
            catch (Exception err)
            {
                Console.Error.WriteLine(err);
            }

        } while (opciones != 0);
    }

    private static void imprimirMenu()
    {
        Console.WriteLine("************** MENU DE EJERCICIOS **************************");
        Console.WriteLine("*       1 -> Ejercicios Básicos                            *");
        Console.WriteLine("*       2 -> Ejercicios Arrays                             *");
        Console.WriteLine("*       3 -> Ejercicios Especiales                         *");
        Console.WriteLine("*       4 -> Ejercicios Examen                             *");
        Console.WriteLine("*       5 -> Ejercicios Excepciones                        *");
        Console.WriteLine("*       6 -> Ejercicios Ficheros                           *");
        Console.WriteLine("*       7 -> Ejercicios Polimorfismos                      *");
        Console.WriteLine("*       8 -> Ejercicios Redefinicion                       *");
        Console.WriteLine("*       9 -> Ejercicios Interfaces                         *");
        Console.WriteLine("*       10 -> Ejercicios Colecciones BCL                   *");
        Console.WriteLine("*       11 -> Ejercicios Genericos                         *");
        Console.WriteLine("*       12 -> Ejercicios Colecciones Enlazadas             *");
        Console.WriteLine("*       13 -> Ejercicios Colecciones SOLID y Patrones      *");
        Console.WriteLine("*       0 -> Salir del programa                            *");
        Console.WriteLine("************************************************************");
    }

    private static void AbrirEjercicio(int opciones, string[] args)
    {
        switch (opciones)
        {
            case 0:
                Console.WriteLine("Hasta luego y suerte 😂.");
                break;
            case 1:
                Ejercicios_0_100.MenuBasico.main();
                break;
            case 2:
                Ejercicios_Array.MenuArrays.main();
                break;
            case 3:
                Ejercicios_Especiales.MenuEspeciales.main();
                break;
            case 4:
                Ejercicios_Examen.MenuExamenes.main(args);
                break;
            case 5:
                Ejercicios_Excepciones.MenuExcepciones.main(args);
                break;
            case 6:
                Ejercicios_Ficheros.MenuFicheros.main(args);
                break;
            case 7:
                Ejercicios_Polimorfismos.MenuPolimorfismos.main(args);
                break;
            case 8:
                Ejercicios_Redefinicion_Operadores.MenuRedefinicion.main(args);
                break;
            case 9:
                Ejercicios_Interfaces.MenuInterfaces.main(args);
                break;
            case 10:
                Ejercicios_BCL.MenuBcl.main();
                break;
            case 11:
                Ejercicios_Genericos.MenuGenericos.main();
                break;
            case 12:
                Ejercicios_Colecciones_Enlazadas.MenuColeccionesEnlazadas.main();
                break;
            case 13:
                Ejercicios_SOLID_Patrones.MenuSolidPatrones.main();
                break;
            case 14:
                ejercicio1Main();
                break;
            case 15:
                ejercicio2Main();
                break;
            case 16:
                ejercicio3Main();
                break;
            case 17:
                ejercicio4Main();
                break;
            case 18:
                ejercicio5Main();
                break;
            case 19:
                ejercicio6Main();
                break;
            case 20:
                ejercicio7Main();
                break;
            default:
                Console.Error.WriteLine("El paquete no existe todavía.");
                break;
        }
    }

    private static void ejercicio1Main()
    {
        /*
            Escribe un programa en C# que ayude a un granjero a calcular la cantidad de comida disponible para sus animales.
            El programa debe:
                1.	Solicitar al usuario la cantidad total de comida comprada (en kilogramos).
                2.	Solicitar la cantidad de animales en la granja.
                3.	Calcular cuántos kilogramos de comida puede recibir cada animal dividiendo la cantidad total de comida entre el número de animales.
                4.	Si la cantidad de comida por animal es mayor que el número total de animales, mostrar el mensaje: “Hay suficiente comida para todos.”
                5.	En caso contrario, mostrar el mensaje: “Cada animal debe consumir X kg diariamente.”, donde X es el resultado del cálculo.
            Nota: Asegúrate de que el usuario ingrese valores válidos y que no haya divisiones por cero.
        */

        Console.WriteLine("Calculadora de comida de animales");
        Console.WriteLine("Ingresar operacion");
        Console.WriteLine("Numero de animales");
        int animales = int.Parse(Console.ReadLine());
        Console.WriteLine("Numero de comida en kg");
        double comida = double.Parse(Console.ReadLine());

        if (animales <= 0)
        {
            Console.WriteLine("Error en cantidad de animales. No puede ser 0 o negativo.");
        }

        if (comida <= 0)
        {
            Console.WriteLine("Error en cantidad de comida. No puede ser negativo.");
        }

        double resultado = comida / animales;

        if (resultado > animales)
        {
            Console.WriteLine($"Hay suficiente comida para todos.");
        }
        else
        {
            Console.WriteLine($"Cada animal debe consumir {resultado} kg diariamente.");
        }


    }

    private static void ejercicio2Main()
    {
        Console.WriteLine("Reproductor de sonidos de animales");
        Console.Write("Ingresar animal (Gallina, Perro, Gato, Vaca): ");
        string animal = Console.ReadLine() ?? "Gallina";

        if (animal == null)
        {
            Console.WriteLine("Error en la clasificaicion de aniamels");
        }
        else if (animal == "Gallina")
        {
            Console.WriteLine("Cocoroco");
        }
        else if (animal == "Perro")
        {
            Console.WriteLine("Guau guau");
        }
        else if (animal == "Gato")
        {
            Console.WriteLine("Miau miau");
        }
        else if (animal == "Vaca")
        {
            Console.WriteLine("Muuuuuu");
        }
        else
        {
            Console.WriteLine("Animal no reconocido");
        }

        switch (animal)
        {
            case "Gallina":
                Console.WriteLine("Cocoroco");
                break;
            case "Vaca":
                Console.WriteLine("Muuuuuu");
                break;
            case "Gato":
                Console.WriteLine("Miau miau");
                break;
            case "Perro":
                Console.WriteLine("Guau guau");
                break;
            default:
                Console.WriteLine("Animal no reconocido");
                break;
        }
    }

    private static void ejercicio3Main()
    {
        Console.WriteLine("Contar del 1 al 10");
        for (int i = 1; i < 11; i++)
        {
            Console.WriteLine($"Vuelta del bucle for: {i}");
        }
        int j = 0;
        for (; ; )
        {
            Console.WriteLine($"Bucle infinito en marcha: {j++}");
            if (j == 2)
            {
                break;
            }
        }
    }

    private static void ejercicio4Main()
    {
        string[] nombres = new string[5];
        for (int i = 0; i < nombres.Length; i++)
        {
            Console.WriteLine("Introduce un nombre:");
            nombres[0] = Console.ReadLine();
        }
        foreach (string name in nombres)
        {
            Console.WriteLine($"Me llamo: {name}");
        }
    }

    private static void ejercicio5Main()
    {
        Console.WriteLine("Introduce un nombre: ");
        string nombre = Console.ReadLine() ?? "Vacio";

        foreach (char letra in nombre)
        {
            Console.Write($"{letra}-");
        }

        int veces = 0;
        for (int i = 0; i < nombre.Length; i++)
        {
            if (nombre[i].Equals('a') || nombre[i].Equals('A'))
            {
                veces++;
            }
        }
        Console.WriteLine($"La letra A se repite: {veces} veces");
    }

    private static void ejercicio6Main()
    {
        int i = 0;

        while (i > 0)
        {
            Console.WriteLine($"Ejecutado desde el while: El valor de i es: {i}");
        }

        do
        {
            Console.WriteLine($"Ejecutado desde el do-while: El valor de i es: {i}");
        } while (i > 0);
    }

    private static void ejercicio7Main()
    {
        /*
        Dado un tablero de ajedrez, 
        el usuario introduce unas coordenadas para el caballo 
        y el programa debe mostrar sus posibles movimientos con una X
        */

        string[,] tablero = new string[8, 8];

        for (int i = 0; i < 8; i++) // pintar filas
        {
            for (int j = 0; j < 8; j++)
            {
                switch (j)
                {
                    case 0:
                        tablero[i, j] = "A" + i;
                        break;
                    case 1:
                        tablero[i, j] = "B" + i;
                        break;
                    case 2:
                        tablero[i, j] = "C" + i;
                        break;
                    case 3:
                        tablero[i, j] = "D" + i;
                        break;
                    case 4:
                        tablero[i, j] = "E" + i;
                        break;
                    case 5:
                        tablero[i, j] = "F" + i;
                        break;
                    case 6:
                        tablero[i, j] = "G" + i;
                        break;
                    case 7:
                        tablero[i, j] = "H" + i;
                        break;
                }
            }
        }

        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                Console.Write(tablero[i, j]);
            }
            Console.WriteLine();
        }

        Console.WriteLine("Introduce la fila del caballo: ");
        int fila = int.Parse(Console.ReadLine() ?? "0"); // 0
        Console.WriteLine("Introduce la columna del caballo: ");
        int columna = int.Parse(Console.ReadLine() ?? "0");

        tablero[fila, columna] = "CA";

        if (fila - 2 >= 0)
        { //compruebo que puedo bajar el caballo
            if (columna - 1 >= 0)
            { //compruebo que puedo girar a la izquierda el caballo
                tablero[fila - 2, columna - 1] = "XX";
            }
            if (columna + 1 <= 7)
            { //compruebo que puedo girar a la derecha el caballo
                tablero[fila - 2, columna + 1] = "XX";
            }
        }
        if (columna - 2 >= 0)
        {//compruebo que puedo girar a la izquierda el caballo
            if (fila - 1 >= 0)
            { //compruebo que puedo bajar el caballo
                tablero[fila - 1, columna - 2] = "XX";
            }
            if (fila + 1 <= 7)
            { //compruebo que puedo subir el caballo
                tablero[fila + 1, columna - 2] = "XX";
            }
        }
        if (fila + 2 <= 7)
        {//compruebo que puedo subir el caballo
            if (columna - 1 >= 0)
            { //compruebo que puedo girar a la izquierda el caballo
                tablero[fila + 2, columna - 1] = "XX";
            }
            if (columna + 1 <= 7)
            { //compruebo que puedo girar a la derecha el caballo
                tablero[fila + 2, columna + 1] = "XX";
            }
        }
        if (columna + 2 <= 7)
        {//compruebo que puedo girar a la derecha el caballo
            if (fila - 1 >= 0)
            { //compruebo que puedo bajar el caballo
                tablero[fila - 1, columna + 2] = "XX";
            }
            if (fila + 1 <= 7)
            { //compruebo que puedo subir el caballo
                tablero[fila + 1, columna + 2] = "XX";
            }
        }


        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                Console.Write(tablero[i, j]);
            }
            Console.WriteLine();
        }
    }



}
