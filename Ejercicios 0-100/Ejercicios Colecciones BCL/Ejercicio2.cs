namespace Ejercicios_BCL;

public class Ejercicio2
{
    public static void main()
    {
        // Ejemplo de uso de la clase Program
        List<Automovil> listaAutomoviles = new List<Automovil>();

        // Añadir automóviles a la lista
        Program.AñadeAutomovil(listaAutomoviles, new Automovil("Toyota", "Corolla", 2000, 2018, "Rojo"));
        Program.AñadeAutomovil(listaAutomoviles, new Automovil("Honda", "Civic", 1800, 2020, "Azul"));
        Program.AñadeAutomovil(listaAutomoviles, new Automovil("Ford", "Focus", 1600, 2019, "Negro"));

        // Mostrar la lista de automóviles
        Program.MostrarLista(listaAutomoviles);

        // Eliminar un automóvil de la lista
        Program.EliminaAutomovil(listaAutomoviles, 1);

        // Mostrar la lista actualizada
        Console.WriteLine("\nDespués de eliminar un automóvil:");
        Program.MostrarLista(listaAutomoviles);

        // Encontrar automóviles por año de fabricación
        int añoBuscado = 2019;
        List<Automovil> autosPorAño = Program.AutomovilesPorAñoFabricacion(listaAutomoviles, añoBuscado);
        Console.WriteLine($"\nAutomóviles fabricados en {añoBuscado}:");
        Program.MostrarLista(autosPorAño);

        // Encontrar automóviles por año de fabricación y color
        int añoBuscado2 = 2018;
        string colorBuscado = "Rojo";
        List<Automovil> autosPorAñoYColor = Program.AutomovilesPorAñoFabricacionYColor(listaAutomoviles, añoBuscado2, colorBuscado);
        Console.WriteLine($"\nAutomóviles fabricados en {añoBuscado2} y de color {colorBuscado}:");
        Program.MostrarLista(autosPorAñoYColor);
    }
}
