using System.Text;

namespace Ejercicios_IO;

public class EjercicioIO4
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
            // Abrir el archivo en modo lectura y escritura
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite))
            {
                // Leer el contenido del archivo como una cadena
                string content;
                using (StreamReader reader = new StreamReader(fileStream, Encoding.UTF8))
                {
                    content = reader.ReadToEnd();
                }

                // Convertir el contenido del archivo
                content = ConvertirMayusculasMinusculas(content);

                // Posicionar el cursor al principio del archivo
                fileStream.Seek(0, SeekOrigin.Begin);

                // Escribir el contenido modificado en el archivo
                using (StreamWriter writer = new StreamWriter(fileStream, Encoding.UTF8))
                {
                    writer.Write(content);
                }
            }

            Console.WriteLine($"La conversión se ha realizado con éxito en el archivo '{filePath}'.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine($"Error: No tienes permiso para modificar el archivo '{filePath}'.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    // Método para convertir mayúsculas a minúsculas y viceversa en una cadena
    static string ConvertirMayusculasMinusculas(string input)
    {
        char[] chars = input.ToCharArray();
        for (int i = 0; i < chars.Length; i++)
        {
            if (char.IsUpper(chars[i]))
            {
                chars[i] = char.ToLower(chars[i]);
            }
            else if (char.IsLower(chars[i]))
            {
                chars[i] = char.ToUpper(chars[i]);
            }
        }
        return new string(chars);
    }
}