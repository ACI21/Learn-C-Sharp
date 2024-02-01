namespace Ejercicios_Examen;

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
                Ejercicios_Examen.TerrenosArea.main();
                break;
            case 2:
                Ejercicios_Examen.Ascensor.main();
                break;
            case 3:
                Ejercicios_Examen.GestionInventario.main();
                break;
            case 4:
                Ejercicios_Examen.ValorActualNeto.main();
                break;
            case 5:
                Ejercicios_Examen.CorreoOfuscado.main();
                break;
            case 6:
                Ejercicios_Examen.Alpinismo.main();
                break;
            default:
                Console.Error.WriteLine("El ejercicio no existe todavía.");
                break;
        }
    }
}

