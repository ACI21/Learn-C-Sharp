namespace Ejercicios_IO;

public class EjercicioIO5
{
    public static void main()
    {
        // Ruta del archivo datos.txt en la carpeta datos del directorio raíz de la unidad C:
        string filePath = @"C:\pruebasCSharp\datos.txt";

        // Verificar si la carpeta datos existe, si no existe, crearla
        string directoryPath = Path.GetDirectoryName(filePath);
        if (!Directory.Exists(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);
        }

        try
        {
            // Crear un FileStream en modo de creación o apertura del archivo
            using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
            {
                using (BinaryWriter writer = new BinaryWriter(fileStream))
                {
                    Console.WriteLine("Introduce caracteres. Presiona ESC para finalizar.");

                    // Leer caracteres de la consola y escribirlos en el archivo hasta que se presione ESC
                    ConsoleKeyInfo key;
                    do
                    {
                        key = Console.ReadKey();
                        if (key.Key != ConsoleKey.Escape)
                        {
                            // Escribir el carácter en el archivo
                            writer.Write(key.KeyChar);
                        }
                    } while (key.Key != ConsoleKey.Escape);
                }
            }

            Console.WriteLine($"Los caracteres han sido guardados en el archivo '{filePath}'.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
