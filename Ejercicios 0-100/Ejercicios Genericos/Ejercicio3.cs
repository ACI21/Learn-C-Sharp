namespace Ejercicios_Genericos;

class Ejercicio3
{
    public static void main(string[] args)
    {
        Console.WriteLine($"Mayor (5, 3): {Comparador<int>.Mayor(5, 3)}");
        Console.WriteLine($"Menor (3, 5): {Comparador<int>.Menor(3, 5)}");

        Console.WriteLine($"Mayor ('gato', 'perro'): {Comparador<string>.Mayor("gato", "perro")}");
        Console.WriteLine($"Menor ('gato', 'perro'): {Comparador<string>.Menor("gato", "perro")}");

        Console.WriteLine($"Mayor (5.5f, 3.3f): {Comparador<float>.Mayor(5.5f, 3.3f)}");
        Console.WriteLine($"Menor (3.3f, 5.5f): {Comparador<float>.Menor(3.3f, 5.5f)}");
    
    }
}