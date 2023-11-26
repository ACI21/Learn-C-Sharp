namespace Ejercicios_0_100;

public class MenuExamenes
{
    public static void main()
    {
        int opciones = 0;

        do
        {
            Console.WriteLine("********* MENU DE EJERCICIOS **************");
            Console.WriteLine("*       1 -> Ejercicio Terrenos           *");
            Console.WriteLine("*       2 -> Ejercicio Ascensor           *");
            Console.WriteLine("*       3 -> Ejercicio Gestion Stock      *");
            Console.WriteLine("*       4 -> Ejercicio VAN                *");
            Console.WriteLine("*       5 -> Ejercicio Correos            *");
            Console.WriteLine("*       6 -> Ejercicio Alpinismo          *");
            Console.WriteLine("*       0 -> Volver al menú anterior      *");
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
                Ejercicios_0_100.TerrenosArea.main();
                break;
            case 2:
                Ejercicios_0_100.Ascensor.main();
                break;
            case 3:
                Ejercicios_0_100.GestionInventario.main();
                break;
            case 4:
                Ejercicios_0_100.ValorActualNeto.main();
                break;
            case 5:
                Ejercicios_0_100.CorreoOfuscado.main();
                break;
            case 6:
                Ejercicios_0_100.Alpinismo.main();
                break;
            default:
                Console.Error.WriteLine("El ejercicio no existe todavía.");
                break;
        }
    }
}

