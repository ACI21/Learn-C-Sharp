namespace Ejercicios_Redefinicion_Operadores;

using System;

public class Program
{
    public static void main()
    {
        // Ejemplo de uso
        NumeroCurioso num1 = new NumeroCurioso(0.5, 0.5, Math.Sqrt(0.5));
        NumeroCurioso num2 = new NumeroCurioso(0.5, -0.5, -Math.Sqrt(0.5));

        Console.WriteLine("Número 1: " + num1.ToString());
        Console.WriteLine("Número 2: " + num2.ToString());

        NumeroCurioso suma = num1 + num2;
        Console.WriteLine("Suma: " + suma.ToString());

        NumeroCurioso resta = num1 - num2;
        Console.WriteLine("Resta: " + resta.ToString());

        Console.ReadLine();
    }
}
