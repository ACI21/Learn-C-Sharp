namespace Ejercicios_0_100;

public class Ejercicio8
{
    public static void main()
    {
        int numero1 = 0;
        int numero2 = 0;
        int numero3 = 0;

        Console.Write("Introduce el numero 1: ");
        numero1 = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Introduce el numero 2: ");
        numero2 = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Introduce el numero 3: ");
        numero3 = int.Parse(Console.ReadLine() ?? "0");

        if (numero1 > numero2 && numero1 > numero3)
        {
            //el numero 1 es el más grande
            if (numero2 > numero3)
            {
                //El numero 2 es el segundo más grande
                Console.WriteLine("Orden de menor a mayor: {0} > {1} > {2}", numero1, numero2, numero3);
            }
            else
            {
                //El numero 3 es el segundo más grande
                Console.WriteLine("Orden de menor a mayor: {0} > {1} > {2}", numero1, numero3, numero2);
            }
        }
        else if (numero2 > numero1 && numero2 > numero3)
        {
            //el numero 2 es el más grande
            if (numero1 > numero3)
            {
                //El numero 1 es el segundo más grande
                Console.WriteLine("Orden de menor a mayor: {0} > {1} > {2}", numero2, numero1, numero3);
            }
            else
            {
                //El numero 3 es el segundo más grande
                Console.WriteLine("Orden de menor a mayor: {0} > {1} > {2}", numero2, numero3, numero1);
            }
        }
        else if (numero3 > numero2 && numero3 > numero1)
        {
            //el numero 3 es el más grande
            if (numero1 > numero2)
            {
                //El numero 1 es el segundo más grande
                Console.WriteLine("Orden de menor a mayor: {0} > {1} > {2}", numero3, numero1, numero2);
            }
            else
            {
                //El numero 2 es el segundo más grande
                Console.WriteLine("Orden de menor a mayor: {0} > {1} > {2}", numero3, numero2, numero1);
            }
        }
    }
}
