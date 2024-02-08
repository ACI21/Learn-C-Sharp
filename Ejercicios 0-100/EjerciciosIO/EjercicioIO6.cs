namespace Ejercicios_IO;

public class EjercicioIO6
{
    public static void Main()
    {
        // Recoger microprocesadores por teclado
        Microprocesador[] microprocesadores = RecogerMicroprocesadores();

        // Guardar microprocesadores en el archivo
        GuardarEnArchivo(microprocesadores);

        // Leer microprocesadores del archivo
        Microprocesador[] microprocesadoresLeidos = LeerArchivo();

        // Mostrar microprocesadores leídos
        Console.WriteLine("Microprocesadores leídos del archivo:");
        foreach (Microprocesador microprocesador in microprocesadoresLeidos)
        {
            Console.WriteLine(microprocesador);
            Console.WriteLine();
        }
    }

    static Microprocesador[] RecogerMicroprocesadores()
    {
        Console.WriteLine("Introduce la cantidad de microprocesadores:");
        int cantidad = int.Parse(Console.ReadLine());

        Microprocesador[] microprocesadores = new Microprocesador[cantidad];
        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine($"Introduce los datos del microprocesador {i + 1} (modelo;nucleos;frecuencia):");
            string datos = Console.ReadLine();
            string[] partes = datos.Split(';');
            string modelo = partes[0];
            int nucleos = int.Parse(partes[1]);
            double frecuencia = double.Parse(partes[2]);
            microprocesadores[i] = new Microprocesador(modelo, nucleos, frecuencia);
        }
        return microprocesadores;
    }

    static void GuardarEnArchivo(Microprocesador[] microprocesadores)
    {
        string filePath = "microprocesadores.csv";
        try
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (Microprocesador microprocesador in microprocesadores)
                {
                    writer.WriteLine(microprocesador.ACSV());
                }
            }
            Console.WriteLine($"Los microprocesadores han sido guardados en el archivo '{filePath}'.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al guardar en el archivo: {ex.Message}");
        }
    }

    static Microprocesador[] LeerArchivo()
    {
        string filePath = "microprocesadores.csv";
        try
        {
            string[] lineas = File.ReadAllLines(filePath);
            Microprocesador[] microprocesadores = new Microprocesador[lineas.Length];
            for (int i = 0; i < lineas.Length; i++)
            {
                microprocesadores[i] = Microprocesador.AMicroprocesador(lineas[i]);
            }
            return microprocesadores;
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"No se encontró el archivo '{filePath}'. Se devolverá un arreglo vacío.");
            return new Microprocesador[0];
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al leer el archivo: {ex.Message}");
            return new Microprocesador[0];
        }
    }
}
