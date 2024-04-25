namespace Ejercicios_Genericos;

class Ejercicio4
{
    public static void main(string[] args)
    {
        Persona persona1 = new Persona { Nombre = "Juan", Edad = 30 };
        Persona persona2 = new Persona { Nombre = "Ana", Edad = 25 };

        Console.WriteLine($"¿Persona1 es mayor que Persona2? {Comparador<Persona>.Mayor(persona1, persona2)}");
        Console.WriteLine($"¿Persona1 es menor que Persona2? {Comparador<Persona>.Menor(persona1, persona2)}");

        Persona clon = (Persona)persona1.Clone();
        Console.WriteLine($"Clon de Persona1: {clon}");
        Console.WriteLine($"¿El clon es menor que Persona2? {Comparador<Persona>.Menor(clon, persona2)}");
    }
}