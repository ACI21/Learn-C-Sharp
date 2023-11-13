namespace Ejercicios_0_100;

public class Ejercicio10
{
    public static void main(){
        string numero = "0";

        Console.Write("Introduce un numero: ");
        numero = Console.ReadLine()??"123";

        Console.WriteLine("Cantidad de digitos: " + numero.Length);
    }
}
