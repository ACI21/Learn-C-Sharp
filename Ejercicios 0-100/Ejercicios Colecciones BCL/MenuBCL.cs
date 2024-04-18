namespace Ejercicios_BCL;

public class MenuBcl
{
    public static void main()
    {
        int opciones = 0;

        do
        {
            Console.WriteLine("********* MENU DE EJERCICIOS **************");
            Console.WriteLine("*       1 -> Ejercicio Paises             *");
            Console.WriteLine("*       2 -> Ejercicio Multicine          *");
            Console.WriteLine("*       3 -> Ejercicio Dentado            *");
            Console.WriteLine("*       4 -> Ejercicio Dentado            *");
            Console.WriteLine("*       5 -> Ejercicio Dentado            *");
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
                Ejercicios_BCL.Ejercicio1.main();
                break;
            case 2:
                Ejercicios_BCL.Ejercicio2.main();
                break;
            case 3:
                Ejercicios_BCL.Ejercicio3.main();
                break;
            case 4:
                Ejercicios_BCL.Ejercicio4.main();
                break;
            case 5:
                Ejercicios_BCL.Ejercicio5.main();
                break;
            default:
                Console.Error.WriteLine("El ejercicio no existe todavía.");
                break;
        }
    }
}