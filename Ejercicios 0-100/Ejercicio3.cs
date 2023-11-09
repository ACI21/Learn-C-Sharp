//
namespace Ejercicios_0_100;

public class Ejercicio3
{
    public static void main()
    {
        int cantidadComida = 0;
        int numAnimales = 0;
        int kilosPorAnimal = 0;

        Console.Write("Introduzca cantidad de comida comprada: ");
        cantidadComida = int.Parse(Console.ReadLine()??"0");
        Console.Write("Introduzca cantidad de animales en granja: ");
        numAnimales = int.Parse(Console.ReadLine()??"0");

        kilosPorAnimal = cantidadComida/numAnimales;
        if(kilosPorAnimal > numAnimales){
            Console.WriteLine("Hay suficiente comida para todos.");
        }else{
            Console.WriteLine("Cada animal debe consumir {0}kg diariamente.", kilosPorAnimal);
        }
    }
} 