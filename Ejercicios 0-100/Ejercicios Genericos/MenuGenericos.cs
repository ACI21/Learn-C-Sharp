namespace Ejercicios_Genericos;

public class MenuGenericos
{
    public static void main()
    {
        int opciones = 0;

        do
        {
            Console.WriteLine("********* MENU DE EJERCICIOS **************");
            Console.WriteLine("*       1 -> Ejercicio 1                  *");
            Console.WriteLine("*       2 -> Ejercicio 2                  *");
            Console.WriteLine("*       3 -> Ejercicio 3                  *");
            Console.WriteLine("*       4 -> Ejercicio 4                  *");
            Console.WriteLine("*       5 -> Ejercicio 5                  *");
            Console.WriteLine("*       6 -> Ejercicio 6                  *");
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
                Ejercicios_Genericos.Ejercicio1.main();
                break;
            case 2:
                Ejercicios_Genericos.Ejercicio2.main();
                break;
            case 3:
                Ejercicios_Genericos.Ejercicio3.main();
                break;
            case 4:
                Ejercicios_Genericos.Ejercicio4.main();
                break;
            case 5:
                Ejercicios_Genericos.Ejercicio5.main();
                break;
            case 6:
                Ejercicios_Genericos.Ejercicio6.main();
                break;
            default:
                Console.Error.WriteLine("El ejercicio no existe todavía.");
                break;
        }
    }
}