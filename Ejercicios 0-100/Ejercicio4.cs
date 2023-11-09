namespace Ejercicios_0_100;

public class Ejercicio4
{
    public static void main(){
        Console.WriteLine("Introduce text alfanumerico: ");
        string palabra = Console.ReadLine()??"123";

        for (int i = 0; i < palabra.Length; i++)
        {
            Console.WriteLine("Caracter {0}: {1}",i,palabra[i]);
        }
    }
}
