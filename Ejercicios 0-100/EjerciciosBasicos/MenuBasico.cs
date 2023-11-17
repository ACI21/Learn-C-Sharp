namespace Ejercicios_0_100;

public class MenuBasico
{
    public static void main()
    {
        int opciones = 0;

        do
        {
            Console.WriteLine("********* MENU DE EJERCICIOS **************");
            Console.WriteLine("*       1 -> Ejercicio Biologo            *");
            Console.WriteLine("*       2 -> Ejercicio Ecuacion           *");
            Console.WriteLine("*       3 -> Ejercicio Granja             *");
            Console.WriteLine("*       4 -> Ejercicio Guarismo           *");
            Console.WriteLine("*       5 -> Ejercicio Reloj++            *");
            Console.WriteLine("*       6 -> Ejercicio Triangulo          *");
            Console.WriteLine("*       7 -> Ejercicio Ordenar <          *");
            Console.WriteLine("*       8 -> Ejercicio Ordenar >          *");
            Console.WriteLine("*       9 -> Ejercicio Cantidad digitos   *");
            Console.WriteLine("*       10 -> Ejercicio Capicua           *");
            Console.WriteLine("*       11 -> Ejercicio Dia semana        *");
            Console.WriteLine("*       12 -> Ejercicio Par, +, ^2        *");
            Console.WriteLine("*       13 -> Ejercicio Suma, media, >18  *");
            Console.WriteLine("*       14 -> Ejercicio 1 --> X           *");
            Console.WriteLine("*       15 -> Ejercicio Tabla multiplicar *");
            Console.WriteLine("*       16 -> Ejercicio Tablas 1-10       *");
            Console.WriteLine("*       0 -> Volver al menu anterior      *");
            Console.WriteLine("*******************************************");

            try
            {
                opciones = int.Parse(Console.ReadLine() ?? "0");
                AbrirEjercicio(opciones);
            }
            catch (Exception err)
            {
                Console.Error.WriteLine(err);
            }

        } while (opciones != 0);
    }

    private static void AbrirEjercicio(int opciones)
    {
        switch (opciones)
        {
            case 0:
                Console.WriteLine("Hasta luego y suerte 😂.");
                break;
            case 1:
                Ejercicios_0_100.Ejercicio1.main();
                break;
            case 2:
                Ejercicios_0_100.Ejercicio2.main();
                break;
            case 3:
                Ejercicios_0_100.Ejercicio3.main();
                break;
            case 4:
                Ejercicios_0_100.Ejercicio4.main();
                break;
            case 5:
                Ejercicios_0_100.Ejercicio5.main();
                break;
            case 6:
                Ejercicios_0_100.Ejercicio6.main();
                break;
            case 7:
                Ejercicios_0_100.Ejercicio7.main();
                break;
            case 8:
                Ejercicios_0_100.Ejercicio8.main();
                break;
            case 9:
                Ejercicios_0_100.Ejercicio9.main();
                break;
            case 10:
                Ejercicios_0_100.Ejercicio10.main();
                break;
            case 11:
                Ejercicios_0_100.Ejercicio11.main();
                break;
            case 12:
                Ejercicios_0_100.Ejercicio12.main();
                break;
            case 13:
                Ejercicios_0_100.Ejercicio13.main();
                break;
            case 14:
                Ejercicios_0_100.Ejercicio6.main();
                break;
            case 15:
                Ejercicios_0_100.Ejercicio6.main();
                break;
            case 16:
                Ejercicios_0_100.Ejercicio6.main();
                break;
            default:
                Console.Error.WriteLine("El ejercicio no existe todavía.");
                break;
        }
    }
}