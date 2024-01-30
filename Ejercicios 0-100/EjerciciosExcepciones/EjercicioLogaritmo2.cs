namespace Ejercicios_Excepciones;
using System;

public class EjercicioLogaritmo2
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
                // Poniendo un parámetro no numérico
                if (!double.TryParse(args[0], out double numero))
                {
                    throw new ArgumentException("El parámetro debe ser un número.");
                }

                // Llamada al método para calcular el logaritmo
                try
                {
                    double resultado = CalculaLogaritmo(numero);

                    // Mostrar el resultado
                    Console.WriteLine($"El logaritmo en base diez de {numero} es: {resultado}");
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    // Capturar y mostrar la excepción específica para valores incorrectos
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
        catch (Exception ex)
        {
            // Capturar y mostrar otras excepciones
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    // Método para calcular el logaritmo en base diez
    static double CalculaLogaritmo(double numero)
    {
        // Verificar que el número sea positivo antes de calcular el logaritmo
        if (numero <= 0)
        {
            // Lanzar la excepción si el valor es incorrecto
            throw new ArgumentOutOfRangeException(nameof(numero), "El número debe ser positivo para calcular el logaritmo.");
        }

        // Calcular y devolver el logaritmo en base diez
        return Math.Log10(numero);
    }
}
