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
                Ejercicios_0_100.Ahorcado.main();
                break;
            default:
                Console.Error.WriteLine("El ejercicio no existe todavía.");
                break;
        }
    }
}

