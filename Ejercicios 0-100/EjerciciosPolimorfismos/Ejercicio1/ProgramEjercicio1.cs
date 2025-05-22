// Ejercicio 1: Polimorfismo con Sobrecarga de Métodos
// Implementar un sistema para calcular el coste de carreras de taxi usando sobrecarga de métodos.
// El sistema debe:
// 1. Utilizar una clase estática Taxi con el método CosteCarrera sobrecargado
// 2. Permitir calcular el coste básico (kilómetros y tiempo de espera)
// 3. Permitir aplicar recargos por:
//    - Servicio nocturno (incremento porcentual)
//    - Día festivo (porcentaje variable según el festivo)
//    - Ocupación extra (mascotas u otros elementos que ocupen espacio)
// 4. Realizar los cálculos respetando una tarifa mínima y teniendo en cuenta la bajada de bandera
// 5. Demostrar la funcionalidad con diferentes escenarios de uso
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