namespace Ejercicios_0_100;

public class Program
{
    static void Main(string[] args)
    {
        int opciones = 0;

        do
        {
            Console.WriteLine("********* MENU DE EJERCICIOS **************");
            Console.WriteLine("*       1 -> Ejercicios Básicos           *");
            Console.WriteLine("*       2 -> Ejercicios Arrays            *");
            Console.WriteLine("*       3 -> Ejercicios Especiales        *");
            Console.WriteLine("*       4 -> Ejercicios Examen            *");
            Console.WriteLine("*       5 -> Ejercicios Excepciones       *");
            Console.WriteLine("*       0 -> Salir del programa           *");
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
                Ejercicios_0_100.MenuBasico.main();
                break;
            case 2: 
                Ejercicios_0_100.MenuArrays.main();
                break;
            case 3:
                Ejercicios_0_100.MenuEspeciales.main();
                break;
            case 4:
                Ejercicios_0_100.MenuExamenes.main();
                break;
            case 5:
                Ejercicios_Excepciones.MenuExcepciones.main(args);
                break;
            default:
                Console.Error.WriteLine("El ejercicio no existe todavía.");
                break;
        }
    }
}
