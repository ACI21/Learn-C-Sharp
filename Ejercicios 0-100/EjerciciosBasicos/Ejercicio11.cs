namespace Ejercicios_0_100;

public class Ejercicio11
{
    public static void main()
    {
        int diaSemana = 1;
        
        Console.Write("Introduce dia de la semana(1-7): ");
        diaSemana = int.Parse(Console.ReadLine() ?? "1");

        switch (diaSemana)
        {
            case 1 when diaSemana > 0 && diaSemana < 8:
                Console.WriteLine("Hoy es Lunes.");
            break;
            case 2 when diaSemana > 0 && diaSemana < 8:
                Console.WriteLine("Hoy es Martes.");
            break;
            case 3 when diaSemana > 0 && diaSemana < 8:
                Console.WriteLine("Hoy es Miércoles.");
            break;
            case 4 when diaSemana > 0 && diaSemana < 8:
                Console.WriteLine("Hoy es Jueves.");
            break;
            case 5 when diaSemana > 0 && diaSemana < 8:
                Console.WriteLine("Hoy es Viernes.");
            break;
            case 6 when diaSemana > 0 && diaSemana < 8:
                Console.WriteLine("Hoy es Sábado.");
            break;
            case 7 when diaSemana > 0 && diaSemana < 8:
                Console.WriteLine("Hoy es Domingo.");
            break;
            default:
                Console.WriteLine("Dia secreto desbloqueado. Has creado un nuevo dia.");
            break;
        }
    }
}
