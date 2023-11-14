namespace Ejercicios_0_100;

public class Ejercicio10
{
    public static void main()
    {
        string numero = "";
        string numeroCapicua = "";

        Console.Write("Introduce un numero: ");
        numero = Console.ReadLine() ?? "323";

        if (numero.Length <= 1)
        {
            Console.WriteLine("Cantidad de digitos: " + numero.Length);
            Console.WriteLine("¿Capicua?: Sí");
        }
        else
        {
            for (int i = 1; i <= numero.Length; i++)
            {
                numeroCapicua += numero[numero.Length - i];
            }
            Console.WriteLine("Cantidad de digitos: " + numero.Length);

            if (numero == numeroCapicua)
            {
                Console.WriteLine("¿Capicua?: Sí");
            }
            else
            {
                Console.WriteLine("¿Capicua?: No");
            }
        }
    }
}
