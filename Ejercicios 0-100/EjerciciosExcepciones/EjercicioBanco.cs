// Ejercicio Banco: Sistema Bancario con Manejo de Excepciones Personalizadas
// Crear un sistema bancario simple que utilice excepciones personalizadas para validar operaciones.
// El sistema debe:
// 1. Implementar la clase NumeroCuenta para validar números de cuenta bancaria
// 2. Implementar la clase Cuenta que permita operaciones de ingreso y reintegro (retiro)
// 3. Crear excepciones personalizadas:
//    - NumeroCuentaIncorrectoException: cuando el formato del número de cuenta es inválido
//    - SaldoInsuficienteException: cuando se intenta retirar más dinero del disponible
// 4. Demostrar el manejo de excepciones mediante bloques try-catch
// 5. Mostrar mensajes de error apropiados cuando se capturen las excepciones
namespace Ejercicios_Excepciones;

using System;

public class EjercicioBanco
{
    public static void main(string[] args)
    {
        try
        {
            NumeroCuenta cuenta1 = new NumeroCuenta("20850103920300731702");
            Console.WriteLine($"Datos del número de cuenta: {cuenta1.ToString()}");

            Cuenta cuenta2 = new Cuenta("00490345312710611698", "Titular3");
            cuenta2.Ingreso(1000);
            Console.WriteLine(cuenta2.ToString());
            cuenta2.Reintegro(1500);
        }
        catch (NumeroCuentaIncorrectoException error)
        {
            Console.WriteLine("Error: " + error.Message);
        }
        catch (SaldoInsuficienteException error)
        {
            Console.WriteLine("Error: " + error.Message);
        }
    }
}