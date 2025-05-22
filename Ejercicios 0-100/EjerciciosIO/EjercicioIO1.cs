// Ejercicio IO 1: Creación y Lectura de Archivos con FileStream
// Crear un programa que demuestre el uso básico de la clase FileStream para operaciones de E/S.
// El programa debe:
// 1. Solicitar al usuario la ruta completa donde crear un archivo
// 2. Verificar si el directorio existe, y crearlo si no existe
// 3. Pedir al usuario el contenido que desea escribir en el archivo
// 4. Crear el archivo y escribir los datos utilizando FileStream
// 5. Abrir el archivo para lectura y mostrar su contenido byte a byte
// 6. Implementar manejo de excepciones para gestionar posibles errores
namespace Ejercicios_IO;

using System;
using System.IO;

public class EjercicioIO1
{
    public static void main()
    {
        Console.WriteLine("Introduce la ruta completa del fichero (incluyendo el nombre del fichero):");
        string filePath = Console.ReadLine();

        // Verificar si el directorio donde se ubicará el archivo existe, si no existe, crearlo
        string directoryPath = Path.GetDirectoryName(filePath);
        if (!Directory.Exists(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);
        }

        try
        {
            // Crear el archivo
            using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
            {
                Console.WriteLine("Introduce la información que deseas escribir en el archivo:");
                string data = Console.ReadLine();

                // Convertir la cadena a bytes
                byte[] bytes = System.Text.Encoding.UTF8.GetBytes(data);

                // Escribir los bytes en el archivo
                fileStream.Write(bytes, 0, bytes.Length);

                Console.WriteLine("¡Archivo creado y escrito correctamente!");
            }

            // Abrir el archivo para lectura
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            {
                Console.WriteLine("\nLeyendo el archivo:");

                // Leer el archivo byte a byte
                int byteRead;
                while ((byteRead = fileStream.ReadByte()) != -1)
                {
                    Console.Write((char)byteRead);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
