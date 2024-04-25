namespace Ejercicios_Genericos;

class Ejercicio2
{
    public static void main()
    {
        A<int, string> miObjeto = new A<int, string>(123, "Hola mundo");

        Console.WriteLine($"Clave: {miObjeto.Clave}, Valor: {miObjeto.Valor}");
    
    }
}