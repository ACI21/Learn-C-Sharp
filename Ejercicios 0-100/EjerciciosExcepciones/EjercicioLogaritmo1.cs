// Ejercicio Logaritmo 1: Manejo Básico de Excepciones
// Crear un programa que calcule el logaritmo en base 10 de un número proporcionado como argumento.
// El programa debe:
// 1. Verificar si se ha proporcionado al menos un argumento en la línea de comandos
// 2. Comprobar que el argumento sea un número válido utilizando TryParse
// 3. Validar que el número sea positivo (requisito para calcular logaritmos)
// 4. Capturar y manejar posibles excepciones:
//    - ArgumentException: cuando el número es negativo o cero
//    - Otras excepciones que puedan surgir durante el proceso
// 5. Mostrar mensajes de error adecuados cuando se produzcan excepciones
namespace Ejercicios_Excepciones;

using System;

public class EjercicioLogaritmo1
{
    public static void main(string[] args)
    {
        try
        {
            // Sin parámetros en la línea de comandos
            if (args.Length == 0)
            {
                Console.WriteLine("Debe proporcionar un número como parámetro.");
            }
            else
            {
                double numero;
                // Poniendo un parámetro no numérico
                if (double.TryParse(args[0],out numero))
                {
                    numero = double.Parse(args[0]);
                }else{
                    throw new ArgumentException("El número debe ser positivo para calcular el logaritmo.");
                }

                // Llamada al método para calcular el logaritmo
                double resultado = CalculaLogaritmo(numero);

                // Mostrar el resultado
                Console.WriteLine($"El logaritmo en base diez de {numero} es: {resultado}");
            }
        }
        catch (Exception ex)
        {
            // Capturar y mostrar las excepciones
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    // Método para calcular el logaritmo en base diez
    static double CalculaLogaritmo(double numero)
    {
        // Verificar que el número sea positivo antes de calcular el logaritmo
        if (numero <= 0)
        {
            throw new ArgumentException("El número debe ser positivo para calcular el logaritmo.");
        }

        // Calcular y devolver el logaritmo en base diez
        return Math.Log10(numero);
    }
}
