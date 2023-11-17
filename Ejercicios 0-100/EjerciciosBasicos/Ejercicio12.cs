

namespace Ejercicios_0_100;

public class Ejercicio12
{
    public static void main()
    {
        float numero = 0.0F;
        
        ObtenerDatos(out numero);
        ComprobarPar(numero);
        ComprobarPositivo(numero);
        CalcularCuadrado(numero);
    }

    private static void ObtenerDatos(out float numero)
    {
        Console.Write("Introduce un numero: ");
        numero = float.Parse(Console.ReadLine() ?? "1.11");
    }

    private static void CalcularCuadrado(float numero)
    {
        float total  =  (float) Math.Pow(numero,2);
        Console.WriteLine("El cuadrado del numero es: {0}", total);

        Console.WriteLine("El cuadrado del numero es: {0}", Math.Pow(numero,2));
    }

    private static void ComprobarPositivo(float numero)
    {
        if (numero >= 0)
        {
            Console.WriteLine("El numero es positivo");
        }
        else
        {
            Console.WriteLine("El numero es negativo");
        }
    }

    private static void ComprobarPar(float numero)
    {
        if (numero % 2 == 0)
        {
            Console.WriteLine("El numero es par");
        }
        else
        {
            Console.WriteLine("El numero es impar");
        }
    }
}
