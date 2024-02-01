namespace Ejercicios_Ficheros;

public class MenuFicheros
{
    public static void main(String[] args)
    {
        int opciones = 0;

        do
        {
            Console.WriteLine("*********** MENU DE EJERCICIOS ************");
            Console.WriteLine("*       1 -> Ejercicio Fichero 1          *");
            Console.WriteLine("*       2 -> Ejercicio Fichero 2          *");
            Console.WriteLine("*       3 -> Ejercicio Fichero 3          *");
            Console.WriteLine("*       0 -> Volver al menu anterior      *");
            Console.WriteLine("*******************************************");

            try
            {
                opciones = int.Parse(Console.ReadLine() ?? "0");
                AbrirEjercicio(opciones, args);
            }
            catch (Exception err)
            {
                Console.Error.WriteLine(err);
            }

        } while (opciones != 0);
    }

    private static void AbrirEjercicio(int opciones, string[] args)
    {
        switch (opciones)
        {
            case 0:
                Console.WriteLine("Hasta luego y suerte 😂.");
                break;
            case 1:
                Ejercicios_Ficheros.EjercicioFichero1.main(args);
                break;
            case 2:
                Ejercicios_Ficheros.EjercicioFichero2.main(args);
                break;
            case 3:
                Ejercicios_Ficheros.EjercicioFichero3.main(args);
                break;
            default:
                Console.Error.WriteLine("El ejercicio no existe todavía.");
                break;
        }
    }
}

