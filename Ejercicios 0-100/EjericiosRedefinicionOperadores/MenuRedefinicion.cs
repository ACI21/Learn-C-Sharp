namespace Ejercicios_Redefinicion_Operadores;

public class MenuRedefinicion
{
    public static void main(string [] args)
    {
        int opciones = 0;

        do
        {
            Console.WriteLine("********* MENU DE EJERCICIOS **************");
            Console.WriteLine("*       1 -> Ejercicio                    *");
            Console.WriteLine("*       2 -> Ejercicio                    *");
            Console.WriteLine("*       3 -> Ejercicio Numero Curioso     *");
            Console.WriteLine("*       4 -> Ejercicio                    *");
            Console.WriteLine("*       0 -> Volver al menú anterior      *");
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
                break;
            case 2:
                break;
            case 3:
                Ejercicios_Redefinicion_Operadores.Program.main();
                break;
            case 4:
                break;
            default:
                Console.Error.WriteLine("El ejercicio no existe todavía.");
                break;
        }
    }
}

