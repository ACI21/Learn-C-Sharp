// Ejercicio 2: Implementación de una clase con múltiples tipos genéricos
// Crear una clase genérica A<TKey, TValue> que implemente un par clave-valor con tipos genéricos.
// La clase debe:
// 1. Permitir definir dos tipos genéricos diferentes: uno para la clave y otro para el valor
// 2. Proporcionar propiedades para acceder a la clave y al valor
// 3. Demostrar el uso de la clase combinando diferentes tipos (ej: int, string)
namespace Ejercicios_Genericos;

class Ejercicio2
{
    public static void main()
    {
        A<int, string> miObjeto = new A<int, string>(123, "Hola mundo");

        Console.WriteLine($"Clave: {miObjeto.Clave}, Valor: {miObjeto.Valor}");
    
    }
}