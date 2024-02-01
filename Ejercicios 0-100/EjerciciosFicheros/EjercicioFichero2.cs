namespace Ejercicios_Ficheros;

using System;
using System.IO;
public class EjercicioFichero2
{
    public static void main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("1. Crear Árbol de Directorios");
            Console.WriteLine("2. Eliminar Directorio");
            Console.WriteLine("3. Eliminar Fichero");
            Console.WriteLine("4. Mostrar Información de Directorio");
            Console.WriteLine("5. Mostrar Atributos de Fichero");
            Console.WriteLine("0. Salir (ESC)");
            Console.WriteLine("Ingrese la opción deseada:");

            ConsoleKeyInfo key = Console.ReadKey();
            Console.Clear();

            switch (key.Key)
            {
                case ConsoleKey.D1:
                    CrearArbolDeDirectorios();
                    break;
                case ConsoleKey.D2:
                    EliminaDirectorio();
                    break;
                case ConsoleKey.D3:
                    EliminaFichero();
                    break;
                case ConsoleKey.D4:
                    MuestraInformacion();
                    break;
                case ConsoleKey.D5:
                    MuestraAtributos();
                    break;
                case ConsoleKey.Escape:
                    return;
                case ConsoleKey.D0:
                    return;
            }
        }
    }

    static void CrearArbolDeDirectorios()
    {
        string directorioBase = @"/Users/ruthyal/Documents/Documentos - MacBook Air de CIA/GitHub/Learn C#/Ejercicios 0-100/EjerciciosFicheros/nombres";
        string pepePath = Path.Combine(directorioBase, "pepe");
        string juanPath = Path.Combine(directorioBase, "juan");
        string datosPath = Path.Combine(pepePath, "datos");
        string documentoPath = Path.Combine(pepePath, "documento.txt");

        try
        {
            Directory.CreateDirectory(pepePath);
            Directory.CreateDirectory(juanPath);
            Directory.CreateDirectory(datosPath);

            File.WriteAllText(documentoPath, "Contenido del documento");

            Console.WriteLine("Árbol de directorios y ficheros creado con éxito.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al crear el árbol: {ex.Message}");
        }
    }

    static void EliminaDirectorio()
    {
        Console.WriteLine("Ingrese la ruta del directorio a eliminar:");
        string directorioAEliminar = Console.ReadLine()??"error";

        try
        {
            if (Directory.Exists(directorioAEliminar))
            {
                Directory.Delete(directorioAEliminar, true);
                Console.WriteLine("Directorio eliminado con éxito.");
            }
            else
            {
                Console.WriteLine("El directorio no existe.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al eliminar el directorio: {ex.Message}");
        }
    }

    static void EliminaFichero()
    {
        Console.WriteLine("Ingrese la ruta del fichero a eliminar:");
        string ficheroAEliminar = Console.ReadLine()??"error";

        try
        {
            if (File.Exists(ficheroAEliminar))
            {
                File.Delete(ficheroAEliminar);
                Console.WriteLine("Fichero eliminado con éxito.");
            }
            else
            {
                Console.WriteLine("El fichero no existe.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al eliminar el fichero: {ex.Message}");
        }
    }

    static void MuestraInformacion()
    {
        Console.WriteLine("Ingrese la ruta del directorio para mostrar información:");
        string directorioAMostrar = Console.ReadLine()??"error";

        try
        {
            if (Directory.Exists(directorioAMostrar))
            {
                string[] contenidos = Directory.GetFileSystemEntries(directorioAMostrar);

                Console.WriteLine($"Contenidos del directorio {directorioAMostrar}:");
                foreach (string contenido in contenidos)
                {
                    Console.WriteLine(contenido);
                }
            }
            else
            {
                Console.WriteLine("El directorio no existe.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al mostrar información del directorio: {ex.Message}");
        }
    }

    static void MuestraAtributos()
    {
        Console.WriteLine("Ingrese la ruta del fichero para mostrar atributos:");
        string ficheroAMostrar = Console.ReadLine()??"error";

        try
        {
            if (File.Exists(ficheroAMostrar))
            {
                FileAttributes atributos = File.GetAttributes(ficheroAMostrar);

                Console.WriteLine($"Atributos del fichero {ficheroAMostrar}:");
                Console.WriteLine(atributos);
            }
            else
            {
                Console.WriteLine("El fichero no existe.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al mostrar atributos del fichero: {ex.Message}");
        }
    }
}
