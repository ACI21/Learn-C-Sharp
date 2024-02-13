namespace Ejercicios_Examen;

using System;
using System.IO;
using System.Text.RegularExpressions;

public class FicheroHTML
{
    public static void main(string[] args)
    {
        if (args.Length != 1)
        {
            Console.WriteLine("Debes pasar como argumento el nombre del html a leer.");
            return;
        }

        string rutaHtml = args[0];
        try
        {
            string contenidoHtml = LeePagina(rutaHtml);
            MuestraCabecerasH2(contenidoHtml);
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Error al leer el fichero: {ex.Message}");
        }
    }

    static string LeePagina(string pagina)
    {
        StreamReader sr = new StreamReader(pagina);
        return sr.ReadToEnd();
    }

    static void MuestraCabecerasH2(string html)
    {
        Regex regex = new Regex(@"<h2>(?<contenido>.+)</h2>", RegexOptions.Singleline);
        MatchCollection matches = regex.Matches(html);
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Groups["contenido"].Value);
        }
    }
}