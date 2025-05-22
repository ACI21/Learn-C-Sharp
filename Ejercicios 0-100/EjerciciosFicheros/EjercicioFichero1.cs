// Ejercicio 1: Manejo de rutas de archivos con la clase Path
// Crear un programa que demuestre el uso de los principales métodos de la clase Path para manipular rutas de archivos.
// El programa debe:
// 1. Ofrecer al usuario la opción de trabajar con rutas absolutas o relativas
// 2. Mostrar el resultado de aplicar diferentes métodos de la clase Path:
//    - GetExtension: obtener la extensión del archivo
//    - GetFileName: obtener el nombre del archivo con extensión
//    - GetFileNameWithoutExtension: obtener el nombre sin extensión
//    - GetDirectoryName: obtener el nombre del directorio
//    - GetPathRoot: obtener la raíz de la ruta
//    - ChangeExtension: cambiar la extensión del archivo
//    - GetFullPath: obtener la ruta completa a partir de una relativa
//    - Combine: combinar dos rutas en una sola
using Microsoft.VisualBasic;

namespace Ejercicios_Ficheros;

public class EjercicioFichero1
{
    public static void main(String[] args)
     {
        while (true)
        {
            Console.WriteLine("1. Ruta de acceso absoluta");
            Console.WriteLine("2. Ruta de acceso relativa");
            Console.WriteLine("0. Salir (ESC)");
            Console.WriteLine("Ingrese la opción deseada:");

            ConsoleKeyInfo key = Console.ReadKey();
            Console.Clear();

            switch (key.Key)
            {
                case ConsoleKey.D1:
                    string rutaEjemplo = @"/Users/ruthyal/Documents/Documentos - MacBook Air de CIA/GitHub/Learn C#/Ejercicios 0-100/EjerciciosFicheros/EjercicioFichero1.cs";
                    RutaEjemplo(rutaEjemplo);
                    break;
                case ConsoleKey.D2:
                    string rutaEjemplo2 = @"Ejercicios 0-100/EjerciciosFicheros/EjercicioFichero1.cs";
                    RutaEjemplo(rutaEjemplo2);
                    break;
                case ConsoleKey.Escape:
                    return;
                case ConsoleKey.D0:
                    return;
            }
        }

    }

    private static void RutaEjemplo(string rutaEjemplo)
    {
        // Método GetExtension: Obtiene la extensión del archivo
        string extension = Path.GetExtension(rutaEjemplo);
        Console.WriteLine($"GetExtension: {extension}");

        // Método GetFileName: Obtiene el nombre del archivo con extensión
        string fileName = Path.GetFileName(rutaEjemplo);
        Console.WriteLine($"GetFileName: {fileName}");

        // Método GetFileNameWithoutExtension: Obtiene el nombre del archivo sin extensión
        string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(rutaEjemplo);
        Console.WriteLine($"GetFileNameWithoutExtension: {fileNameWithoutExtension}");

        // Método GetDirectoryName: Obtiene el nombre del directorio
        var directoryName = Path.GetDirectoryName(rutaEjemplo);
        Console.WriteLine($"GetDirectoryName: {directoryName}");

        // Método GetPathRoot: Obtiene la raíz de la ruta
        string? pathRoot = Path.GetPathRoot(rutaEjemplo);
        Console.WriteLine($"GetPathRoot: {pathRoot}");

        // Método ChangeExtension: Cambia la extensión del archivo
        string nuevaRuta = Path.ChangeExtension(rutaEjemplo, ".doc");
        Console.WriteLine($"ChangeExtension: {nuevaRuta}");

        // Método GetFullPath: Obtiene la ruta completa a partir de una ruta relativa
        string rutaRelativa = @"..\otroDirectorio\archivo.txt";
        string fullPath = Path.GetFullPath(rutaRelativa);
        Console.WriteLine($"GetFullPath: {fullPath}");

        // Método Combine: Combina dos rutas en una sola
        string ruta1 = @"C:\carpeta";
        string ruta2 = "archivo.txt";
        string combinedPath = Path.Combine(ruta1, ruta2);
        Console.WriteLine($"Combine: {combinedPath}");
    }
}