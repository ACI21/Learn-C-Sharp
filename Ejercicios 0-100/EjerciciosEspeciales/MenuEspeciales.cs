namespace Ejercicios_Especiales;

public class MenuEspeciales
{
    public static void main()
    {
        int opciones = 0;

        do
        {
            Console.WriteLine("********* MENU DE EJERCICIOS **************");
            Console.WriteLine("*       1 -> Ejercicio Especular          *");
            Console.WriteLine("*       2 -> Ejercicio Ahorcado           *");
            Console.WriteLine("*       3 -> Ejercicio Numero secreto     *");
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
                Ejercicios_Especiales.Especular.main();
                break;
            case 2:
                Ejercicios_Especiales.Ahorcado.main();
                break;
            case 3:
                Ejercicios_Especiales.NumeroSecreto.main();
                break;
            default:
                Console.Error.WriteLine("El ejercicio no existe todavía.");
                break;
        }
    }
}

