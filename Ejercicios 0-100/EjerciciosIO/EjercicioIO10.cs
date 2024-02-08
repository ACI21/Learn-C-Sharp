namespace Ejercicios_IO;

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

public class EjercicioIO10
{
    public static void Main()
    {
        // Pedir al usuario la ruta del archivo
        Console.WriteLine("Introduce la ruta del archivo:");
        string filePath = Console.ReadLine();

        // Verificar si el archivo existe
        if (!File.Exists(filePath))
        {
            Console.WriteLine($"El archivo '{filePath}' no existe.");
            return;
        }

        // Leer todas las palabras del archivo
        string texto = File.ReadAllText(filePath);

        // Obtener todas las palabras con diptongo formado por dos vocales débiles
        List<string> diptongosDebiles = ObtenerDiptongosDebiles(texto);

        // Mostrar las palabras con diptongo formado por dos vocales débiles
        Console.WriteLine("Palabras con diptongo formado por dos vocales débiles:");
        foreach (string palabra in diptongosDebiles)
        {
            Console.WriteLine(palabra);
        }

        // Obtener todas las palabras con diptongo formado por una vocal débil seguida de 'a'
        List<string> diptongosConA = ObtenerDiptongosConA(texto);

        // Mostrar las palabras con diptongo formado por una vocal débil seguida de 'a'
        Console.WriteLine("\nPalabras con diptongo formado por una vocal débil seguida de 'a':");
        foreach (string palabra in diptongosConA)
        {
            Console.WriteLine(palabra);
        }

        // Buscar expresión regular mínima que muestre todos los diptongos
        string regexDiptongos = @"(?<debil>[iu])(?<fuerte>[aeo])|(?<fuerte>[aeo])(?<debil>[iu])";

        // Mostrar la expresión regular mínima para los diptongos
        Console.WriteLine("\nExpresión regular mínima para los diptongos:");
        Console.WriteLine(regexDiptongos);
    }

    static List<string> ObtenerDiptongosDebiles(string texto)
    {
        // Expresión regular para buscar diptongos formados por dos vocales débiles
        string regex = @"\b[aeiou]{2,}\b";

        // Obtener todas las coincidencias
        MatchCollection matches = Regex.Matches(texto, regex);

        // Crear una lista para almacenar las palabras encontradas
        List<string> palabras = new List<string>();

        // Agregar las palabras únicas encontradas a la lista
        foreach (Match match in matches)
        {
            string palabra = match.Value.ToLower(); // Convertir a minúsculas para evitar duplicados por diferencia de mayúsculas y minúsculas
            if (!palabras.Contains(palabra))
            {
                palabras.Add(palabra);
            }
        }

        // Ordenar la lista de palabras
        palabras.Sort();

        return palabras;
    }

    static List<string> ObtenerDiptongosConA(string texto)
    {
        // Expresión regular para buscar diptongos formados por una vocal débil seguida de 'a'
        string regex = @"\b[aeiou][iu][a]\b";

        // Obtener todas las coincidencias
        MatchCollection matches = Regex.Matches(texto, regex);

        // Crear una lista para almacenar las palabras encontradas
        List<string> palabras = new List<string>();

        // Agregar las palabras únicas encontradas a la lista
        foreach (Match match in matches)
        {
            string palabra = match.Value.ToLower(); // Convertir a minúsculas para evitar duplicados por diferencia de mayúsculas y minúsculas
            if (!palabras.Contains(palabra))
            {
                palabras.Add(palabra);
            }
        }

        // Ordenar la lista de palabras
        palabras.Sort();

        return palabras;
    }
}
