namespace Ejercicios_IO;

public class MenuIO
{
    public static void main(String[] args)
    {
        int opciones = 0;

        do
        {
            Console.WriteLine("*********** MENU DE EJERCICIOS ************");
            Console.WriteLine("*       1 -> Ejercicio Logaritmo 1        *");
            Console.WriteLine("*       2 -> Ejercicio Logaritmo 2        *");
            Console.WriteLine("*       3 -> Ejercicio Logaritmo 3        *");
            Console.WriteLine("*       3 -> Ejercicio Cuenta del banco   *");
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
                Ejercicios_IO.EjercicioIO1.main();
                break;
            case 2:
                Ejercicios_IO.EjercicioIO2.main(args);
                break;
            case 3:
                //Ejercicios_IO.EjercicioIO3.main();
                break;
            case 4:
                //Ejercicios_IO.EjercicioIO4.main();
                break;
            default:
                Console.Error.WriteLine("El ejercicio no existe todavía.");
                break;
        }
    }
}

