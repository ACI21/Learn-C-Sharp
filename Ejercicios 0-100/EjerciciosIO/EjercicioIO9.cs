namespace Ejercicios_IO;

using System;
using System.IO;
using System.Text.RegularExpressions;

public class EjercicioIO9
{
    public static void Main()
    {
        // Pedir al usuario la subcadena a buscar
        Console.WriteLine("Introduce la subcadena a buscar:");
        string subcadena = Console.ReadLine();

        // Pedir al usuario la ruta del archivo
        Console.WriteLine("Introduce la ruta del archivo:");
        string filePath = Console.ReadLine();

        // Verificar si el archivo existe
        if (!File.Exists(filePath))
        {
            Console.WriteLine($"El archivo '{filePath}' no existe.");
            return;
        }

        // Leer todas las líneas del archivo
        string[] lineas = File.ReadAllLines(filePath);

        // Crear una expresión regular para buscar la subcadena en cada línea
        Regex regex = new Regex(Regex.Escape(subcadena), RegexOptions.IgnoreCase);

        // Bandera para indicar si se encontró la subcadena en alguna línea
        bool encontrado = false;

        // Iterar sobre cada línea del archivo
        for (int i = 0; i < lineas.Length; i++)
        {
            // Buscar coincidencias de la subcadena en la línea
            MatchCollection matches = regex.Matches(lineas[i]);

            // Si se encontraron coincidencias, mostrar el número de línea y el número de apariciones
            if (matches.Count > 0)
            {
                encontrado = true;
                Console.WriteLine($"Línea {i + 1}: {matches.Count} aparicion(es)");
            }
        }

        // Si no se encontró la subcadena en ninguna línea, mostrar un mensaje
        if (!encontrado)
        {
            Console.WriteLine("CADENA NO ENCONTRADA");
        }
    }
}
