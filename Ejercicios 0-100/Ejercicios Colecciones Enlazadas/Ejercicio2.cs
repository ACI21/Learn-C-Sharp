namespace Ejercicios_Colecciones_Enlazadas;

class Ejercicio2
{
    private static void GeneraElementos(LinkedList<CaracterASCII> listaAscii, int numeroElementos)
    {
        Random random = new Random();
        while (listaAscii.Count < numeroElementos)
        {
            short nuevoCaracter = (short)random.Next(16, 256);
            var nuevoElemento = new CaracterASCII(nuevoCaracter);
            if (!listaAscii.Contains(nuevoElemento))
            {
                if (listaAscii.Count == 0)
                {
                    listaAscii.AddFirst(nuevoElemento);
                }
                else
                {
                    var current = listaAscii.First;
                    while (current != null && nuevoCaracter > (short)current.Value.Caracter)
                    {
                        current = current.Next;
                    }
                    if (current == null)
                    {
                        listaAscii.AddLast(nuevoElemento);
                    }
                    else
                    {
                        listaAscii.AddBefore(current, nuevoElemento);
                    }
                }
            }
        }
    }

    static string Cabecera() => "DEC OCT HEX CAR";

    static void MuestraLista(LinkedList<CaracterASCII> lista)
    {
        modificarDimensionesPantalla();
        const short NUMERO_COLUMNAS = 8;
        Console.WriteLine(string.Concat(System.Linq.Enumerable.Repeat(Cabecera() + "   ", NUMERO_COLUMNAS)));

        int columnas = 0;
        foreach (var caracter in lista)
        {
            Console.Write($"{caracter}   ");
            columnas++;
            if (columnas % NUMERO_COLUMNAS == 0)
            {
                Console.WriteLine();
            }
        }
    }

    public static void main()
    {
        LinkedList<CaracterASCII> listaAscii = new LinkedList<CaracterASCII>();
        GeneraElementos(listaAscii, 240);
        MuestraLista(listaAscii);
        Console.ReadLine();
    }

    private static void modificarDimensionesPantalla()
    {
        Console.BufferWidth = 150;
        Console.WindowWidth = 150;
        Console.BufferHeight = 40;
        Console.WindowHeight = 40;
    }

}