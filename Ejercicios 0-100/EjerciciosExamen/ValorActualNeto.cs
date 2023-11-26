



namespace Ejercicios_0_100;

public class ValorActualNeto
{
    public static void main(){
        int a = 0;
        int n = 0;
        double k = 0.0;
        double van = 0.00;
        Console.WriteLine("Cálculo del Valor Neto (VAN)");

        ObtenerValores(out a, out n, out k);
        ObtenerVan(out van, a, k, n);

        Console.WriteLine("El Valor Actual Neto (VAN) de la inversión es: {0}", van);
    }

    private static void ObtenerVan(out double van, int a, double k, int n)
    {
        van = -a;
        Console.WriteLine(van);
        for (int t = 0; t < n; t++)
        {
            van += ObtenerFlujoEfectivo(t, k);
            Console.WriteLine(van);
        }
    }

    private static double ObtenerFlujoEfectivo(int t, double k)
    {
        Console.Write($"Ingrese el flujo de efectivo neto para el período {t+1}: ");
        double Qt = double.Parse(Console.ReadLine()??"0.0");

        return Qt / Math.Pow(1 + (double)k, t+1);
    }

    private static void ObtenerValores(out int a, out int n, out double k)
    {
        Console.Write("Ingrese el desembolso inicial (A): ");
        a = int.Parse(Console.ReadLine()??"5000");
        Console.Write("Ingrese la tasa de descuento anual (K) como un decimal (por ejemplo, 0.1 para 10%): ");
        k = float.Parse(Console.ReadLine()??"0.1");
        Console.Write("Ingrese el número de períodos (n):");
        n = int.Parse(Console.ReadLine()??"5000");
    }
}
