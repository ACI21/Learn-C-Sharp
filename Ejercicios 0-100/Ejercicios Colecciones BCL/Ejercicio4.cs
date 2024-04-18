namespace Ejercicios_BCL;

public class Ejercicio4
{
    public static void main()
    {
        Polinomio suma = Polinomio.Suma(new Polinomio("9x7-3x3-7x+5"), new Polinomio("4x2-1"));
        Console.WriteLine(suma);
    }
}
