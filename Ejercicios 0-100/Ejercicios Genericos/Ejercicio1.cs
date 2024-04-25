namespace Ejercicios_Genericos;

class Ejercicio1
{
    public static void main()
    {
        Fraccion<int> fraccionEnteros = new Fraccion<int>(4, 5);
        Console.WriteLine($"La fracción es: {fraccionEnteros.Numerador}/{fraccionEnteros.Denominador}");

        Fraccion<long> fraccionDecimales = new Fraccion<long>(4, 2);
        Console.WriteLine($"La fracción es: {fraccionDecimales.Numerador}/{fraccionDecimales.Denominador}");
    }
}