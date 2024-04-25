namespace Ejercicios_Genericos;

class Ejercicio6
{
    public static void main()
    {
        Lista<int> lista = new Lista<int>();
        lista.Add(5);
        Console.WriteLine(lista[0]);
        lista.Add(8);
        Console.WriteLine(lista[1]);
        lista[1] = 10;
        Console.WriteLine(lista[1]);

        //Prueba la lista con string
        Lista<string> listaStrings = new Lista<string>();
        listaStrings.Add("Hello");
        Console.WriteLine(listaStrings[0]);  // Imprime "Hello"
        listaStrings.Add("World");
        Console.WriteLine(listaStrings[1]);  // Imprime "World"
        listaStrings[1] = "Everyone";
        Console.WriteLine(listaStrings[1]);  // Imprime "Everyone"
    }
}