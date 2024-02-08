namespace Ejercicios_IO;

public class EjercicioIO3
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
                    // Crear un BufferedStream con capacidad de 100 KB
                    using (BufferedStream bufferedStream = new BufferedStream(destinationStream, 100000))
                    {
                        // Copiar el contenido bloque por bloque (100 KB)
                        byte[] buffer = new byte[100000];
                        int bytesRead;
                        while ((bytesRead = sourceStream.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            bufferedStream.Write(buffer, 0, bytesRead);
                        }
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
