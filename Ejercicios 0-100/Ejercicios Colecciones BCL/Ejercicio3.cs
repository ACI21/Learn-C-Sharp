namespace Ejercicios_BCL;

public class Ejercicio3
{
    public static void main()
    {
        Dictionary<string, int> nombresContador = new Dictionary<string, int>();

        // Ciclo para ingresar nombres hasta que se ingrese "fin"
        while (true)
        {
            Console.Write("Ingresa un nombre (o escribe 'fin' para terminar): ");
            string nombre = Console.ReadLine()??"";

            // Verificar si se ha ingresado "fin" para terminar el ciclo
            if (nombre.ToLower() == "fin")
            {
                break;
            }

            // Verificar si el nombre ya está en el diccionario
            if (nombresContador.ContainsKey(nombre))
            {
                // Si ya está, incrementar el contador
                nombresContador[nombre]++;
            }
            else
            {
                // Si no está, agregarlo al diccionario con contador 1
                nombresContador[nombre] = 1;
            }
        }

        // Mostrar los nombres y el número de veces que se han introducido
        Console.WriteLine("\nNombres introducidos y su frecuencia:");
        Console.WriteLine("Nombres:");
        foreach (string nombre in nombresContador.Keys)
        {
            Console.WriteLine(nombre);
        }
        Console.WriteLine("\nFrecuencia:");
        foreach (KeyValuePair<string, int> kvp in nombresContador)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}
