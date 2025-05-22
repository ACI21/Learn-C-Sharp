// Ejercicio 3: Gestión de alimentación en una granja
// Un granjero necesita calcular si tiene suficiente comida para todos los animales de su granja.
// El programa debe:
// 1. Solicitar al usuario la cantidad total de comida comprada (en kg)
// 2. Solicitar el número de animales en la granja
// 3. Calcular los kg de comida por animal
// 4. Indicar si hay suficiente comida para todos o cuántos kg debe consumir cada animal diariamente
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