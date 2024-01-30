namespace Ejercicios_Excepciones;
using System;

// Definición de la excepción personalizada
class ParametroNoValidoException : Exception
{
    public ParametroNoValidoException() : base()
    {
    }

    public ParametroNoValidoException(string message) : base(message)
    {
    }
}

public class EjercicioLogaritmo3
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
                    // Lanzar la excepción personalizada en lugar de la excepción estándar
                    throw new ParametroNoValidoException("El parámetro debe ser un número.");
                }

                // Llamada al método para calcular el logaritmo
                try
                {
                    double resultado = CalculaLogaritmo(numero);

                    // Mostrar el resultado
                    Console.WriteLine($"El logaritmo en base diez de {numero} es: {resultado}");
                }
                catch (ParametroNoValidoException ex)
                {
                    // Capturar y mostrar la excepción personalizada
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
            // Lanzar la excepción personalizada en lugar de la excepción estándar
            throw new ParametroNoValidoException("El número debe ser positivo para calcular el logaritmo.");
        }

        // Calcular y devolver el logaritmo en base diez
        return Math.Log10(numero);
    }
}