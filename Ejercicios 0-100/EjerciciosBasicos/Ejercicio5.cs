/*
Escribir un programa que incremente la hora de un reloj. 
Se pedirán por teclado la hora, los minutos y segundos, así como cuántos segundos se desea incrementar la hora introducida. 
La aplicación mostrará la nueva hora. 
Por ejemplo, si las 13:59:51 se incrementan en 10 segundos resultan las 14:00:01.
*/
namespace Ejercicios_0_100;

public class Ejercicio5
{
    public static void main()
    {
        int hora = 0;
        int minutos = 0;
        int segundos = 0;
        int segExtra = 0;

        Console.Write("Introduzca la hora actual: ");
        hora = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Introduzca los minutos actuales: ");
        minutos = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Introduzca los segundos actuales: ");
        segundos = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Ahora, introduzca los segundos a incrementar: ");
        segExtra = int.Parse(Console.ReadLine() ?? "0");

        segundos += segExtra;
        while (segundos > 60)
        {
            if (segundos >= 60)
            {
                segundos -= 60;
                minutos++;
                if (minutos >= 60)
                {
                    minutos -= 60;
                    hora++;
                    if (hora >= 24)
                    {
                        hora -= 24;
                    }
                }
            }
        }


        Console.Write("Resultado final: ");
        Console.WriteLine("{0}:{1}:{2} \n", hora, minutos, segundos);
        Console.WriteLine();
    }
}
