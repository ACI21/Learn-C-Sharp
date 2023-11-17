namespace Ejercicios_0_100;

public class Ascensor
{
    const short NUMEROPLANTAS = 7;
    const short NUMEROLOCALESPLANTA = 6;
    const short EMPLEADOSPORLOCAL = 5;
    const short VISITASMAXIMAS = 10;
    const short VISITASMINIMAS = 5;
    const short PORCENTAJEUSOASCENSOR = 2;
    public static void Main(string[] args)
    {
        int plantaActual = 0;
        int plantaAscensor = 0;
        int hora = ObtenerHora();
        if (hora >= 8 && hora <= 22)
        {
            PedirAscensor(out plantaActual);
            EsperarAlAscensor(out plantaAscensor, hora);
            LlegaAscensor(plantaActual, plantaAscensor);
        }
        else
        {
            Console.WriteLine("El ascensor no está disponible.");
        }
    }
    private static int ObtenerHora()
    {
        Random rnd = new Random();
        return rnd.Next(0, 24);
    }
    private static void PedirAscensor(out int plantaActual)
    {
        do
        {
            Console.Write("¿En qué planta estás?: ");
            plantaActual = int.Parse(Console.ReadLine() ?? "0");
            if (plantaActual >= 0 && plantaActual <= NUMEROPLANTAS)
            {
                break;
            }
        } while (true);
    }
    private static void EsperarAlAscensor(out int plantaAscensor, int hora)
    {
        Random rnd = new Random();
        int personas = 0;
        if (hora >= 10 && hora <= 13)
        {
            Console.WriteLine("Es hora punta...");
            personas = rnd.Next(VISITASMINIMAS, VISITASMAXIMAS + 1);
        }
        else if (hora >= 15 && hora <= 17)
        {
            Console.WriteLine("Es hora punta...");
            personas = rnd.Next(VISITASMINIMAS, VISITASMAXIMAS + 1);
        }
        else
        {
            personas = rnd.Next(0, VISITASMAXIMAS + 1);
        }
        do
        {
            Console.WriteLine("El ascensor está llegando...");
            System.Threading.Thread.Sleep(500); //equivalente a una páusa de medio segundo
            personas--;
            Console.WriteLine("El ascensor ha dejado a una persona, restantes: {0}", personas);
        } while (personas > 0);
        AscensorLiberado(out plantaAscensor);
    }
    private static void AscensorLiberado(out int plantaAscensor)
    {
        plantaAscensor = PlantaParado();
    }
    private static int PlantaParado()
    {
        Random rnd = new Random();
        int plantaAscensor = rnd.Next(0, NUMEROPLANTAS + 1);
        Console.WriteLine("El ascensor está vacio y en la planta {0}", plantaAscensor);
        return plantaAscensor;
    }
    private static void LlegaAscensor(int plantaActual, int plantaAscensor)
    {
        do
        {
            if (plantaActual < plantaAscensor)
            {
                System.Threading.Thread.Sleep(1000);
                plantaAscensor--;
                Console.WriteLine("Planta: {0}", plantaAscensor);
            }else if (plantaActual > plantaAscensor)
            {
                System.Threading.Thread.Sleep(1500);
                plantaAscensor++;
                Console.WriteLine("Planta: {0}", plantaAscensor);
            }else if (plantaActual == plantaAscensor)
            {
                Console.WriteLine("El ascensor ha llegado.");
                break;
            }
        } while (true);
    }
}
