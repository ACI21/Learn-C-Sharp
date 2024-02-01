namespace Ejercicios_Ficheros;

using System;
using System.IO;

public class EjercicioFichero3
{
    public static void main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("1. listaCarpeta");
            Console.WriteLine("2. creaDirectorio");
            Console.WriteLine("3. eliminaDirectorio");
            Console.WriteLine("4. eliminaFichero");
            Console.WriteLine("5. copiaFicheros");
            Console.WriteLine("0. Salir (ESC)");
            Console.WriteLine("Ingrese el número del comando deseado:");

            ConsoleKeyInfo key = Console.ReadKey();
            Console.Clear();

            switch (key.Key)
            {
                case ConsoleKey.D1:
                    ListaCarpeta();
                    break;
                case ConsoleKey.D2:
                    CreaDirectorio();
                    break;
                case ConsoleKey.D3:
                    EliminaDirectorio();
                    break;
                case ConsoleKey.D4:
                    EliminaFichero();
                    break;
                case ConsoleKey.D5:
                    CopiaFicheros();
                    break;
                case ConsoleKey.Escape:
                    return;
                case ConsoleKey.D0:
                    return;
            }
        }
    }

    static void ListaCarpeta()
    {
        try
        {
            Console.WriteLine("Ingrese la ruta del directorio (deje en blanco para el directorio actual):");
            string ruta = Console.ReadLine()??"error";
            if (string.IsNullOrWhiteSpace(ruta))
                ruta = Directory.GetCurrentDirectory();

            ListarContenidoDirectorio(ruta);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static void ListarContenidoDirectorio(string ruta)
    {
        DirectoryInfo directorio = new DirectoryInfo(ruta);

        if (!directorio.Exists)
        {
            Console.WriteLine($"El directorio '{ruta}' no existe.");
            return;
        }

        Console.WriteLine($"Contenido del directorio '{ruta}':");

        foreach (FileSystemInfo elemento in directorio.EnumerateFileSystemInfos())
        {
            string tipo = (elemento.Attributes & FileAttributes.Directory) == FileAttributes.Directory ? "Directory" : "Archive";
            Console.WriteLine($"{elemento.Name,-20} {tipo,-10} {elemento.LastWriteTime,-20}");
        }
    }

    static void CreaDirectorio()
    {
        try
        {
            Console.WriteLine("Ingrese la ruta del directorio a crear:");
            string ruta = Console.ReadLine()??"error";
            CrearDirectorio(ruta);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static void CrearDirectorio(string ruta)
    {
        Directory.CreateDirectory(ruta);
        Console.WriteLine($"Directorio '{ruta}' creado con éxito.");
    }

    static void EliminaDirectorio()
    {
        try
        {
            Console.WriteLine("Ingrese la ruta del directorio a eliminar:");
            string ruta = Console.ReadLine()??"error";
            EliminarDirectorio(ruta);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static void EliminarDirectorio(string ruta)
    {
        if (Directory.Exists(ruta))
        {
            Directory.Delete(ruta, true);
            Console.WriteLine($"Directorio '{ruta}' eliminado con éxito.");
        }
        else
        {
            Console.WriteLine($"El directorio '{ruta}' no existe.");
        }
    }

    static void EliminaFichero()
    {
        try
        {
            Console.WriteLine("Ingrese la ruta del fichero a eliminar:");
            string ruta = Console.ReadLine()??"error";
            EliminarFichero(ruta);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static void EliminarFichero(string ruta)
    {
        if (File.Exists(ruta))
        {
            File.Delete(ruta);
            Console.WriteLine($"Fichero '{ruta}' eliminado con éxito.");
        }
        else
        {
            Console.WriteLine($"El fichero '{ruta}' no existe.");
        }
    }

    static void CopiaFicheros()
    {
        try
        {
            Console.WriteLine("Ingrese la ruta del directorio de origen:");
            string origen = Console.ReadLine()??"error";

            Console.WriteLine("Ingrese la ruta del directorio de destino:");
            string destino = Console.ReadLine()??"error";

            Console.WriteLine("Ingrese un filtro (opcional):");
            string filtro = Console.ReadLine()??"error";

            CopiarFicheros(origen, destino, filtro);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static void CopiarFicheros(string origen, string destino, string filtro)
    {
        if (!Directory.Exists(origen))
        {
            Console.WriteLine($"El directorio de origen '{origen}' no existe.");
            return;
        }

        if (!Directory.Exists(destino))
        {
            Directory.CreateDirectory(destino);
            Console.WriteLine($"Directorio de destino '{destino}' creado con éxito.");
        }

        var ficherosACopiar = new DirectoryInfo(origen).EnumerateFiles(filtro);

        foreach (FileInfo fichero in ficherosACopiar)
        {
            string destinoFichero = Path.Combine(destino, fichero.Name);
            fichero.CopyTo(destinoFichero, true);
            Console.WriteLine($"Fichero '{fichero.Name}' copiado a '{destino}'");
        }
    }
}
