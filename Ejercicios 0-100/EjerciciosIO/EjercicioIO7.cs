namespace Ejercicios_IO;

using System;
using System.IO;
using System.Text;

public class EjercicioIO7
{
    public static void main(string[] args)
    {
        // Verificar que se haya proporcionado un argumento (ruta del archivo)
        if (args.Length != 1)
        {
            Console.WriteLine("Uso: programa <ruta_del_archivo>");
            return;
        }

        string filePath = args[0];

        // Verificar si el archivo existe
        if (!File.Exists(filePath))
        {
            Console.WriteLine($"El archivo '{filePath}' no existe.");
            return;
        }

        try
        {
            // Contador de caracteres
            int characterCount = 0;

            // Crear un StreamReader para leer el archivo con codificación Unicode
            using (StreamReader reader = new StreamReader(filePath, Encoding.Unicode))
            {
                // Leer el archivo línea por línea
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Incrementar el contador de caracteres con la longitud de la línea
                    characterCount += line.Length;
                }
            }

            Console.WriteLine($"El número de caracteres en el archivo '{filePath}' es: {characterCount}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
