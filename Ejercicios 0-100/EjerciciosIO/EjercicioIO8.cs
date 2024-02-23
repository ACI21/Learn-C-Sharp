namespace Ejercicios_IO;

public class EjercicioIO8
{
    public static void main(string[] args)
    {
        // Verificar que se haya proporcionado al menos dos argumentos (palabra y al menos un archivo)
        if (args.Length < 2)
        {
            Console.WriteLine("Uso: programa <palabra_a_buscar> <archivo1> [archivo2 ...]");
            return;
        }

        string palabra = args[0];

        // Iterar sobre los nombres de archivo proporcionados en los argumentos
        for (int i = 1; i < args.Length; i++)
        {
            string filePath = args[i];

            // Verificar si el archivo existe
            if (!File.Exists(filePath))
            {
                Console.WriteLine($"El archivo '{filePath}' no existe.");
                continue;
            }

            // Realizar la búsqueda de la palabra en el archivo
            bool encontrada = BuscaEnFichero(filePath, palabra);

            // Mostrar mensaje de resultado de la búsqueda
            if (encontrada)
            {
                Console.WriteLine($"La palabra '{palabra}' ha sido encontrada en el archivo '{filePath}'.");
            }
            else
            {
                Console.WriteLine($"La palabra '{palabra}' no ha sido encontrada en el archivo '{filePath}'.");
            }
        }
    }

    static bool BuscaEnFichero(string ruta, string palabra)
    {
        try
        {
            // Leer todas las líneas del archivo
            string[] lineas = File.ReadAllLines(ruta);

            // Iterar sobre las líneas y buscar la palabra
            foreach (string linea in lineas)
            {
                if (BuscaEnCadena(linea, palabra))
                {
                    return true;
                }
            }
            return false;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al buscar en el archivo '{ruta}': {ex.Message}");
            return false;
        }
    }

    static bool BuscaEnCadena(string cadena, string palabra)
    {
        // Buscar la palabra en la cadena, ignorando mayúsculas y minúsculas
        return cadena.IndexOf(palabra, StringComparison.OrdinalIgnoreCase) >= 0;
    }
}
