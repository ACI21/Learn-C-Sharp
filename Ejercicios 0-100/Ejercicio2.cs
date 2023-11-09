// Dado un polinomio de segundo grado
// y = ax^2+bx+c,
// crear un programa que pida los coeficientes a, b y c, así como el valor de x, y calcule el valor correspondiente de y.
namespace Ejercicios_0_100;

public class Ejercicio2
{
    public static void main(){
        //Declaracion de variables
        int a = 0;
        int b = 0;
        int c = 0;
        int x = 0;
        int y = 0;

        Console.Write("Introduce valor A:");
        a = int.Parse(Console.ReadLine()??"0");
        Console.Write("Introduce valor B:");
        b = int.Parse(Console.ReadLine()??"0");
        Console.Write("Introduce valor C:");
        c = int.Parse(Console.ReadLine()??"0");
        Console.Write("Introduce valor X:");
        x = int.Parse(Console.ReadLine()??"0");

        y = (int)((a*Math.Pow(x,2)) + (b*x) + c);

        Console.WriteLine("Resultado: {0}", y);
    }
}
