namespace Ejercicios_Examen;

public class GestionInventario
{
    public static void main(){
        string nombreProducto = "";
        string categoria = "";
        double precio = 0.0;
        int stock = 0;
        
        Console.WriteLine("Sistema de Gestión de Inventario");
        Console.WriteLine("Introduce los datos del producto:");

        Console.Write("Nombre del producto: ");
        nombreProducto = Console.ReadLine()??"";
        Console.Write("Precio: ");
        precio = double.Parse(Console.ReadLine()??"0.0");
        Console.Write("Stock: ");
        stock = int.Parse(Console.ReadLine()??"0");

        ClasificaProducto(out categoria, precio, stock);
        Console.WriteLine("El producto '{0}' se clasifica como '{1}'",nombreProducto, categoria);
    }

    private static void ClasificaProducto(out string categoria, double precio, int stock)
    {
        /*
         * igualamos catgoria al resultado de clasificar
         * precio y stock mediante un switch, 
         * 
        */
        categoria = (precio, stock) switch
        {
            var (p, s) when p >= 100 && s >= 10 => "Alta Demanda",
            var (p, s) when p < 100 && s >= 20 => "Precio Accesible",
            var (p, s) when p >= 200 && s < 5 => "Alta Gama",
            _ => "Categoría Regular"
        };
    }
}
