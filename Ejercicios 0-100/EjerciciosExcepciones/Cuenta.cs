namespace Ejercicios_Excepciones;

using System;

public class Cuenta
{
    private string numero {get; set;}
    private string titular {get; set;}
    private double saldo {get; set;}

    public Cuenta(string numero, string titular)
    {
        this.numero = numero;
        this.titular = titular;
        this.saldo = 0;
    }

    public void Ingreso(double cantidad)
    {
        saldo += cantidad;
    }

    public void Reintegro(double cantidad)
    {
        if (cantidad > saldo)
        {
            throw new SaldoInsuficienteException("Saldo insuficiente");
        }

        saldo -= cantidad;
    }

    public override string ToString()
    {
        return $"Número de cuenta: {numero}, Titular: {titular}, Saldo: {saldo}";
    }
}