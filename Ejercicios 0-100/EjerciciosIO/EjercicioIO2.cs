// Ejercicio IO 2: Implementación de un Comando 'cp' para Copiar Archivos
// Crear un programa que simule el funcionamiento del comando 'cp' de sistemas Unix.
// El programa debe:
// 1. Recibir dos argumentos por línea de comandos: ruta del archivo origen y ruta del archivo destino
// 2. Verificar que el archivo de origen exista
// 3. Verificar que el archivo de destino no exista (para evitar sobrescrituras accidentales)
// 4. Copiar el contenido del archivo origen al destino utilizando FileStream
// 5. Implementar la copia mediante un buffer para optimizar el rendimiento
// 6. Mostrar mensajes apropiados en caso de éxito o error
namespace Ejercicios_IO;

public class EjercicioIO2
{
    public static void main(string[] args)
    {
        // Verificar que se hayan proporcionado dos argumentos (ruta de origen y destino)
        if (args.Length != 2)
        {
            Console.WriteLine("Uso: mycp <ruta_origen> <ruta_destino>");
            return;
        }

        string sourceFilePath = args[0];
        string destinationFilePath = args[1];

        // Verificar si el archivo de origen existe
        if (!File.Exists(sourceFilePath))
        {
            Console.WriteLine($"El archivo de origen '{sourceFilePath}' no existe.");
            return;
        }

        // Verificar si el archivo de destino ya existe
        if (File.Exists(destinationFilePath))
        {
            Console.WriteLine($"El archivo de destino '{destinationFilePath}' ya existe.");
            return;
        }

        try
        {
            // Crear un FileStream para el archivo de origen
            using (FileStream sourceStream = new FileStream(sourceFilePath, FileMode.Open))
            {
                // Crear un FileStream para el archivo de destino
                using (FileStream destinationStream = new FileStream(destinationFilePath, FileMode.Create))
                {
                    // Copiar el contenido byte a byte
                    byte[] buffer = new byte[1024];
                    int bytesRead;
                    while ((bytesRead = sourceStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        destinationStream.Write(buffer, 0, bytesRead);
                    }
                }
            }

            Console.WriteLine($"Archivo copiado de '{sourceFilePath}' a '{destinationFilePath}' correctamente.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
