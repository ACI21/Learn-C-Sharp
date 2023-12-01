
namespace Ejercicios_0_100;

public class Ejercicio18
{
    public static void main()
    {
        int[,] multicine = new int[3, 3];
        const int aforoA = 200;
        const int aforoB = 150;
        const int aforoC = 125;

        while (true)
        {
            Console.WriteLine("1. Venta de entradas");
            Console.WriteLine("2. Estadisticas de aforo");
            int opcion = int.Parse(Console.ReadLine() ?? "0");

            switch (opcion)
            {
                case 1:
                    multicine = Ventas(multicine, aforoA, aforoB, aforoC);
                    break;
                case 2:
                    Estadisticas(multicine);
                    break;
                default:
                    break;
            }
        }

    }

    private static int[,] Ventas(int[,] multicine, int aforoA, int aforoB, int aforoC)
    {
        // La entrada equivaldría al valor de la matriz
        Console.WriteLine("¿Cuantas entradas quieres?");
        int entradas = int.Parse(Console.ReadLine() ?? "0");
        // La sala equivale a la fila
        Console.WriteLine("¿Qué sala? A-B-C");
        string sala = Console.ReadLine() ?? "a";
        sala = sala.ToUpper();
        // La sesion equivale a la columna
        Console.WriteLine("¿Qué sesión? 1-2-3");
        int sesion = int.Parse(Console.ReadLine() ?? "0");
        sesion -= 1;

        switch (sala)
        {
            // Comparamos si es la sala A, siempre y cuando la entrada 
            // del aforo es menor a 200 por sesión, igual para B y C
            case "A" when entradas <= aforoA:
                // Si la primera venta no supera el aforo 
                // y la sala + las nuevas entradas no superan el aforo
                if ((multicine[0, sesion] + entradas) <= aforoA)
                {
                    multicine[0, sesion] += entradas;
                }
                else
                {
                    // Si falla la suma de aforo, redirigimos directamente 
                    // al default
                    goto default;
                }
                break;
            case "B" when entradas <= aforoB:
                // Si la primera venta no supera el aforo 
                // y la sala + las nuevas entradas no superan el aforo
                if ((multicine[1, sesion] + entradas) <= aforoB)
                {
                    multicine[1, sesion] += entradas;
                }
                else
                {
                    // Si falla la suma de aforo, redirigimos directamente 
                    // al default
                    goto default;
                }
                break;
            case "C" when entradas <= aforoC:
                // Si la primera venta no supera el aforo 
                // y la sala + las nuevas entradas no superan el aforo
                if ((multicine[2, sesion] + entradas) <= aforoC)
                {
                    multicine[2, sesion] += entradas;
                }
                else
                {
                    // Si falla la suma de aforo, redirigimos directamente 
                    // al default
                    goto default;
                }
                break;
            default:
                Console.WriteLine("Error en entradas, compre de nuevo.");
                break;
        }
        // Independientemente del switch (si ha sumado o no) delvolvemos
        // el array bi-dimensional
        return multicine;
    }

    private static void Estadisticas(int[,] multicine)
    {
        // Definir las sesiones y las salas
        string[] sesiones = { "Sesión1", "Sesión2", "Sesión3" };
        string[] salas = { "SalaA", "SalaB", "SalaC" };

        // Mostrar encabezados de sesiones
        // La \t es una especie de espacio en blanco, 
        // similar al tabulador
        Console.WriteLine("\t" + string.Join("\t", sesiones));

        // Mostrar estadísticas por sala
        for (int i = 0; i < salas.Length; i++)
        {

            Console.Write(salas[i] + "\t");

            // Mostrar estadísticas por sesion
            for (int j = 0; j < sesiones.Length; j++)
            {
                Console.Write(multicine[i, j] + "\t");
            }

            Console.WriteLine(); // Nueva línea para la siguiente sala
        }
    }
}
