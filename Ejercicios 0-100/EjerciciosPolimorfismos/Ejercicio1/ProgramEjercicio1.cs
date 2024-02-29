namespace Ejercicios_Polimorfismos;
public class ProgramEjercicio1
{
    public static void main()
    {
        Console.WriteLine($"Coste carrera lunes mañana -> "
                          + $"{Taxi.CosteCarrera(20, 5):f2}");
        Console.WriteLine($"Coste carrera lunes noche -> "
                          + $"{Taxi.CosteCarrera(20, 5, true):f2}");
        Console.WriteLine($"Coste carrera lunes con mi mascota Dogo -> "
                          + $"{Taxi.CosteCarrera(20, 5, false, 0, 1):f2}");
        Console.WriteLine($"Coste carrera Domingo de Ramos -> "
                          + $"{Taxi.CosteCarrera(20, 5, false, 40):f2}");
        Console.WriteLine($"Coste carrera Domingo noche -> "
                          + $"{Taxi.CosteCarrera(20, 5, true, 20):f2}");
        Console.WriteLine($"Coste carrera Domingo de Ramos noche con Dogo y Minina -> "
                          + $"{Taxi.CosteCarrera(20, 5, true, 40, 2):f2}");
    }
}