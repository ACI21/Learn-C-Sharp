namespace Ejercicios_0_100;

public class Ejercicio19
{
    public static void main()
    {
        // Crear un array de dos tablas dentadas de enteros
        int[][][] arrayDeArrays = new int[2][][];

        // Pedir al usuario las dimensiones de las tablas dentadas
        for (int i = 0; i < 2; i++)
        {
            Console.Write($"Ingrese el número de filas para la tabla {i + 1}: ");
            int filas = int.Parse(Console.ReadLine()??"0");

            // Crear una nueva tabla dentada con el número de filas especificado
            arrayDeArrays[i] = new int[filas][];

            for (int j = 0; j < filas; j++)
            {
                Console.Write($"Ingrese el número de elementos para la fila {j + 1}: ");
                int elementos = int.Parse(Console.ReadLine()??"0");

                // Crear una nueva fila con el número de elementos especificado
                arrayDeArrays[i][j] = new int[elementos];

                // Rellenar la fila con elementos generados aleatoriamente
                Random random = new Random();
                for (int k = 0; k < elementos; k++)
                {
                    arrayDeArrays[i][j][k] = random.Next(1, 100); // Números aleatorios entre 1 y 99
                }
            }
        }

        // Mostrar el array de dos matrices dentadas
        MostrarArrayDeArrays(arrayDeArrays);
    }

    static void MostrarArrayDeArrays(int[][][] arrayDeArrays)
    {
        // Iterar a través de las tablas dentadas
        for (int i = 0; i < arrayDeArrays.Length; i++)
        {
            Console.WriteLine($"Tabla {i + 1}:");

            // Iterar a través de las filas de la tabla actual
            for (int j = 0; j < arrayDeArrays[i].Length; j++)
            {
                // Mostrar los elementos de la fila actual
                Console.WriteLine(string.Join(",", arrayDeArrays[i][j]));
            }

            Console.WriteLine(); // Separador entre tablas
        }
    }
}