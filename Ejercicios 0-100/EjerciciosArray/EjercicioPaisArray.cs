namespace Ejercicios_0_100;

public class EjercicioPaisArray
{
    public static void main()
    {
        char[][] paises = new char[20][]
        {
            "Argentina".ToCharArray(),
            "Brasil".ToCharArray(),
            "Chile".ToCharArray(),
            "Colombia".ToCharArray(),
            "Argentina".ToCharArray(),
            "Brasil".ToCharArray(),
            "Chile".ToCharArray(),
            "Colombia".ToCharArray(),
            "Argentina".ToCharArray(),
            "Brasil".ToCharArray(),
            "Chile".ToCharArray(),
            "Colombia".ToCharArray(),
            "Argentina".ToCharArray(),
            "Brasil".ToCharArray(),
            "Chile".ToCharArray(),
            "Colombia".ToCharArray(),
            "Argentina".ToCharArray(),
            "Brasil".ToCharArray(),
            "Chile".ToCharArray(),
            "Colombia".ToCharArray(),
        };
        // Inicializar la matriz paises con algunos valores iniciales para propósitos de prueba


        // ... Agrega más países según sea necesario



        while (true)
        {
            Console.WriteLine("1. Buscar un país");
            Console.WriteLine("2. Mostrar países");
            Console.WriteLine("3. Ordenar países");
            Console.WriteLine("4. Añadir prefijo a un país");
            Console.WriteLine("0. Salir");

            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    BuscarPais(paises);
                    break;

                case 2:
                    MostrarPaises(paises);
                    break;

                case 3:
                    OrdenarPaises(paises);
                    break;

                case 4:
                    AnadirPrefijo(paises);
                    break;

                case 0:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }
    }

    private static void AnadirPrefijo(char[][] paises)
    {
        // Solicitar al usuario que ingrese el país al que se le agregará el prefijo
        Console.Write("Ingrese el país al que agregar el prefijo: ");
        string pais = Console.ReadLine() ?? "";

        // Inicializar una variable para almacenar la posición del país encontrado
        // La empezamos en -1 para que, si no hay pais, no sirva
        int paisEncontrado = -1;

        // Buscar el país en la tabla dentada
        for (int i = 0; i < paises.Length; i++)
        {
            // Comparar el nombre del país en minúsculas
            string nombre = new string(paises[i]);
            if (nombre.Equals(pais)) // Lo mismo que decir nombre == pais
            {
                // Almacenar la posición del país encontrado
                paisEncontrado = i;
                // Salimos a lo grande
                break;
            }
        }

        // Verificar si se encontró el país (de ahí el -1)
        if (paisEncontrado != -1)
        {
            // Solicitar al usuario que ingrese el prefijo (2 caracteres)
            Console.Write("Ingrese el prefijo (2 caracteres): ");
            string prefijo = Console.ReadLine() ?? "";

            // Redimensionar la fila del país para agregar espacio
            // para el prefijo (3 caracteres adicionales ya que 2 son el caracter y 1 de espacio)
            /*
             * Cuando se usa ref con un parámetro, estás permitiendo que el método modifique 
             * el valor de la variable original que se pasa como argumento, en otras palabras,
             * se modifica al instante la variable
            */
            Array.Resize(ref paises[paisEncontrado], paises[paisEncontrado].Length + 3);

            // Agregar espacio en blanco entre el nombre y el prefijo
            paises[paisEncontrado][paises[paisEncontrado].Length - 3] = ' ';
            // Agregar los dos caracteres del prefijo a la fila del país
            paises[paisEncontrado][paises[paisEncontrado].Length - 2] = prefijo[0];
            paises[paisEncontrado][paises[paisEncontrado].Length - 1] = prefijo[1];

            // Imprimir un mensaje indicando que se agregó el prefijo al país
            Console.WriteLine($"Prefijo '{prefijo}' añadido al país '{pais}'.");
        }
        else
        {
            // Imprimir un mensaje si el país no se encontró
            Console.WriteLine("País no encontrado.");
        }
    }

    private static void OrdenarPaises(char[][] paises)
    {
        //Método burbuja indicada en los apuntes
        for (int i = 0; i < paises.Length - 1; i++)
        {
            for (int j = 0; j < paises.Length - 1 - i; j++)
            {
                if (new string(paises[j]).CompareTo(new string(paises[j + 1])) > 0)
                {
                    // Intercambiar filas si están fuera de orden
                    char[] temp = paises[j];
                    paises[j] = paises[j + 1];
                    paises[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Países ordenados alfabéticamente.");
    }

    private static void MostrarPaises(char[][] paises)
    {
        for (int i = 0; i < paises.Length; i++)
        {
            string nombre = new string(paises[i]);
            Console.WriteLine(nombre);
        }
    }

    private static void BuscarPais(char[][] paises)
    {
        // Solicitar al usuario que ingrese el país al que se le agregará el prefijo
        Console.Write("Ingrese el país a buscar: ");
        string pais = Console.ReadLine() ?? "";

        // Buscar el país en la tabla dentada
        for (int i = 0; i < paises.Length; i++)
        {
            // Comparar el nombre del país en minúsculas
            string nombre = new string(paises[i]);
            if (nombre.Equals(pais)) // Lo mismo que decir nombre == pais
            {
                Console.WriteLine($"Pais encontrado: {nombre}");
                break;
            }
        }
    }

}
