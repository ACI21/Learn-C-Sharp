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
            Console.WriteLine("*       6 -> Ejercicios Ficheros          *");
            Console.WriteLine("*       7 -> Ejercicios Polimorfismos     *");
            Console.WriteLine("*       8 -> Ejercicios Redefinicion      *");
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
                Ejercicios_Especiales.MenuEspeciales.main();
                break;
            case 4:
                Ejercicios_Examen.MenuExamenes.main(args);
                break;
            case 5:
                Ejercicios_Excepciones.MenuExcepciones.main(args);
                break;
            case 6:
                Ejercicios_Ficheros.MenuFicheros.main(args);
                break;
            case 7:
                Ejercicios_Polimorfismos.MenuPolimorfismos.main(args);
                break;
            case 8:
                Ejercicios_Redefinicion_Operadores.MenuRedefinicion.main(args);
                break;
            default:
                Console.Error.WriteLine("El paquete no existe todavía.");
                break;
        }
    }
}
