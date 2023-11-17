
using System.Text;

namespace Ejercicios_0_100;

public class TerrenosArea
{
    public static void main()
    {
        string terreno = "";
        double precio = 0.0D;
        double total = 0.0D;
        double area = 0.0D;

        ObtenerTerrenoArea(out terreno,out area);

        total = CalculoVivienda(terreno, area, precio, total);

        Console.WriteLine("Tu casa te va a costar: {0}€", total);
    }

    private static void ObtenerTerrenoArea(out string terreno,  out double area)
    {
        double largo = 0.0D;
        double ancho = 0.0D;
        do
        {
            Console.WriteLine("Tipo de terreno: ¿Urbano o rustico?");
            terreno = Console.ReadLine() ?? "Invalido";
            terreno = terreno.ToUpper();
            Console.WriteLine("¿Largo de la parcela?");
            largo = double.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Ancho de la parcela?");
            ancho = double.Parse(Console.ReadLine() ?? "0");

            if (terreno == "URBANO" && largo >= 0 && ancho >= 0)
            {
                break;
            }
            else if (terreno == "RUSTICO" && largo >= 0 && ancho >= 0)
            {
                break;
            }

        } while (true);

        area = largo * ancho;
    }

    private static double CalculoVivienda(string terreno, double area, double precio, double total)
    {
        switch (terreno)
        {
            case "URBANO" when area >= 400 && area < 500:
                precio = 150.00;
                total = (precio * area) * 10 / 100;
                break;
            case "URBANO" when area >= 500:
                precio = 150.00;
                total = (precio * area) * 17 / 100;
                break;
            case "RUSTICO" when area >= 400 && area < 500:
                precio = 20.00;
                total = (precio * area) * 10 / 100;
                break;
            case "RUSTICO" when area >= 500:
                precio = 20.00;
                total = (precio * area) * 17 / 100;
                break;
            case "URBANO" when area < 400:
                precio = 150.00;
                total = (precio * area);
                break;
            case "RUSTICO" when area < 400:
                precio = 20.00;
                total = (precio * area);
                break;
            default:
                Console.WriteLine("Datos erroneos");
                break;
        }
        return total;
    }
}
