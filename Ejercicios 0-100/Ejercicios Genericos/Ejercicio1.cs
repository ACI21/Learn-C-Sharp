// Ejercicio 1: Implementación de una clase genérica para fracciones
// Crear una clase genérica llamada Fraccion<T> que permita representar fracciones matemáticas.
// La clase debe:
// 1. Permitir almacenar el numerador y denominador como valores de tipo genérico T
// 2. Proporcionar propiedades para acceder al numerador y denominador
// 3. Demostrar el uso de la clase con diferentes tipos numéricos (int, long)
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