// Ejercicio 1: Operaciones Básicas con Listas en C#
// Implementar diferentes operaciones con la clase List<T> de la BCL para manipular colecciones.
// El programa debe incluir las siguientes funciones:
// 1. BorraEnteros: eliminar todas las ocurrencias de un número específico de una lista de enteros
// 2. Mezcla: combinar dos listas ordenadas de enteros en una sola lista ordenada (merge)
// 3. ImprimeInverso: mostrar los elementos de una lista de strings en orden inverso desde una posición dada
// 4. OrdenaCadenas: ordenar alfabéticamente una lista de cadenas
// 5. Demostrar el uso de todas estas funciones con ejemplos concretos
namespace Ejercicios_BCL;

public class Ejercicio1
{
    public static void main()
    {
        List<int> listaEnteros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int numeroABorrar = 5;
        BorraEnteros(listaEnteros, numeroABorrar);
        Console.WriteLine("Lista después de borrar el número " + numeroABorrar + ":");
        foreach (int num in listaEnteros)
        {
            Console.WriteLine(num);
        }

        List<int> lista1 = new List<int> { 1, 3, 5, 7, 9 };
        List<int> lista2 = new List<int> { 2, 4, 6, 8, 10 };
        List<int> listaMezclada = Mezcla(lista1, lista2);
        Console.WriteLine("\nLista mezclada:");
        foreach (int num in listaMezclada)
        {
            Console.WriteLine(num);
        }

        List<string> nombres = new List<string> { "Juan", "María", "Pedro", "Luisa", "Carlos" };
        int posicion = 2; 
        Console.WriteLine("\nNombres en orden inverso desde la posición " + posicion + ":");
        ImprimeInverso(nombres, posicion);

        List<string> cadenas = new List<string> { "banana", "manzana", "pera", "uva", "naranja" };
        OrdenaCadenas(cadenas);
        Console.WriteLine("\nCadenas ordenadas alfabéticamente:");
        foreach (string cadena in cadenas)
        {
            Console.WriteLine(cadena);
        }
    }

    public static void BorraEnteros(List<int> lista, int numero)
    {
        lista.RemoveAll(item => item == numero);
    }

    public static List<int> Mezcla(List<int> lista1, List<int> lista2)
    {
        List<int> listaMezclada = new List<int>();
        int i = 0, j = 0;

        while (i < lista1.Count && j < lista2.Count)
        {
            if (lista1[i] < lista2[j])
            {
                listaMezclada.Add(lista1[i]);
                i++;
            }
            else
            {
                listaMezclada.Add(lista2[j]);
                j++;
            }
        }

        while (i < lista1.Count)
        {
            listaMezclada.Add(lista1[i]);
            i++;
        }

        while (j < lista2.Count)
        {
            listaMezclada.Add(lista2[j]);
            j++;
        }

        return listaMezclada;
    }

    public static void ImprimeInverso(List<string> nombres, int posicion)
    {
        for (int i = posicion; i >= 0; i--)
        {
            Console.WriteLine(nombres[i]);
        }
    }

    public static void OrdenaCadenas(List<string> cadenas)
    {
        cadenas.Sort(); // Utiliza el método Sort de la clase List para ordenar alfabéticamente
    }
}