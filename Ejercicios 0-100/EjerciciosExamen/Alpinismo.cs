
namespace Ejercicios_0_100;

public class Alpinismo
{
    public static void main()
    {
        int[] montanas = ObtenerMontanas();
        int cordilleraElegida = 0;

        MuestraCordilleras(montanas);
        ObtenerCordilleraElegida(out cordilleraElegida);
        Console.WriteLine("Cumbres a la que querrá llegar:");
        if (cordilleraElegida == montanas.Length - 1)
        {
            Console.WriteLine("No quedan cumbres a las que llegar");
        }
        else
        {
            EscalarCordilleras(montanas, cordilleraElegida);
        }
    }

    private static void EscalarCordilleras(int[] montanas, int cordilleraElegida)
    {
        for (int i = 0; i <= cordilleraElegida; i++)
        {
            montanas[i] = 0;
        }

        for (int i = cordilleraElegida; i < montanas.Length; i++)
        {
            int montanaAlta = montanas.Max();
            if (montanaAlta == montanas[i])
            {
                Console.WriteLine("{0} con {1} m", i, montanas[i]);
                montanas[i] = 0;
            }
            else
            {
                montanas[i] = 0;
            }
        }

    }

    private static void ObtenerCordilleraElegida(out int cordilleraElegida)
    {
        do
        {
            Console.Write("Montaña de comienzo (0-10): ");
            cordilleraElegida = int.Parse(Console.ReadLine() ?? "0");
            if (cordilleraElegida >= 0 && cordilleraElegida <= 10)
            {
                break;
            }
        } while (true);
    }

    private static void MuestraCordilleras(int[] montanas)
    {
        for (int i = 0; i < montanas.Length; i++)
        {
            Console.WriteLine("Cordillera {0}: {1}m", i, montanas[i]);
        }
    }

    private static int[] ObtenerMontanas()
    {
        int[] montanya = new int[11];
        for (int i = 0; i < montanya.Length; i++)
        {
            Random rnd = new Random();
            montanya[i] = rnd.Next(1500, 3001);
        }
        return montanya;
    }
}
