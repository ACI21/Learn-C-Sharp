namespace Ejercicios_Interfaces;

public class MenuInterfaces
{
    public static void main(String[] args)
    {
        int opciones = 0;

        do
        {
            Console.WriteLine("*********** MENU DE EJERCICIOS ************");
            Console.WriteLine("*       1 -> Ejercicio Ejemplo            *");
            Console.WriteLine("*       2 -> Ejercicio                    *");
            Console.WriteLine("*       3 -> Ejercicio RadioCD            *");
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
                Ejercicios_Interfaces.Ejercicio1.main();
                break;
            case 2:
                Ejercicios_Interfaces.Ejercicio2.main();
                break;
            case 3:
                Ejercicios_Interfaces.Ejercicio3.main();
                break;
            default:
                Console.Error.WriteLine("El ejercicio no existe todavía.");
                break;
        }
    }
}

