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