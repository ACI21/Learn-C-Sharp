namespace Ejercicios_BCL;

class Program
{
    // Método para añadir un automóvil a una lista
    public static void AñadeAutomovil(List<Automovil> lista, Automovil automovil)
    {
        lista.Add(automovil);
    }

    // Método para eliminar un automóvil de una lista dado su índice
    public static void EliminaAutomovil(List<Automovil> lista, int indice)
    {
        if (indice >= 0 && indice < lista.Count)
        {
            lista.RemoveAt(indice);
        }
        else
        {
            Console.WriteLine("El índice está fuera de rango.");
        }
    }

    // Método para encontrar automóviles por año de fabricación
    public static List<Automovil> AutomovilesPorAñoFabricacion(List<Automovil> lista, int año)
    {
        return lista.Where(auto => auto.AñoFabricacion == año).ToList();
    }

    // Método para encontrar automóviles por año de fabricación y color
    public static List<Automovil> AutomovilesPorAñoFabricacionYColor(List<Automovil> lista, int año, string color)
    {
        return lista.Where(auto => auto.AñoFabricacion == año && auto.Color == color).ToList();
    }

    // Método para mostrar el contenido de la lista de automóviles
    public static void MostrarLista(List<Automovil> lista)
    {
        Console.WriteLine("Contenido de la lista de automóviles:");
        foreach (var automovil in lista)
        {
            Console.WriteLine($"Marca: {automovil.Marca}, Modelo: {automovil.Modelo}, Cilindrada: {automovil.Cilindrada}, Año de fabricación: {automovil.AñoFabricacion}, Color: {automovil.Color}");
        }
    }
}