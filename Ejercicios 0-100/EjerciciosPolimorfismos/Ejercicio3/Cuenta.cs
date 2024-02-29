using System;

public class Cuenta
{
    public string NumeroCuenta { get; }
    public string Titular { get; }
    public double Saldo { get; set; }

    public Cuenta(string numeroCuenta, string titular)
    {
        NumeroCuenta = numeroCuenta;
        Titular = titular;
        Saldo = 0;
    }

    public void Ingreso(double cantidad)
    {
        Saldo += cantidad;
    }

    public virtual double Reintegro(double cantidad)
    {
        if (Saldo < cantidad)
            throw new SaldoInsuficException($"Saldo insuficiente para retirar {cantidad:C}.");

        Saldo -= cantidad;
        return cantidad;
    }

    public override string ToString()
    {
        return $"....en Cuenta Genérica\nNumero de cuenta: {NumeroCuenta}\nTitular: {Titular}\nSaldo: {Saldo:C}.\n";
    }

    public class SaldoInsuficException : Exception
    {
        public SaldoInsuficException(string message) : base(message)
        {
        }
    }
}

public class CuentaAhorro : Cuenta
{
    private double TasaInteres { get; }

    public CuentaAhorro(string numeroCuenta, string titular, double tasaInteres) : base(numeroCuenta, titular)
    {
        TasaInteres = tasaInteres;
    }

    public void SumaInteres()
    {
        Saldo += Saldo * TasaInteres;
    }

    public override string ToString()
    {
        return $"....en Cuenta Ahorro\n{base.ToString()}";
    }
}

public class CuentaDeposito : CuentaAhorro
{
    private double RecargoReintegro { get; }

    public bool Vencimiento { get; set; }

    public CuentaDeposito(string numeroCuenta, string titular, double tasaInteres, double recargoReintegro)
        : base(numeroCuenta, titular, tasaInteres)
    {
        RecargoReintegro = recargoReintegro;
    }

    public override double Reintegro(double cantidad)
    {
        double cantidadReintegro = cantidad;
        if (!Vencimiento)
            cantidadReintegro -= cantidadReintegro * RecargoReintegro;

        return base.Reintegro(cantidadReintegro);
    }

    public override string ToString()
    {
        return $"....en Cuenta Depósito\n{base.ToString()}";
    }
}

public class CuentaCorriente : Cuenta
{
    private int MaximoTransaccionesGratuitas { get; }
    private double RecargoPorTransaccionAdicional { get; }
    private int NumeroTransaccionesMesActual { get; set; }

    public CuentaCorriente(string numeroCuenta, string titular, int maximoTransaccionesGratuitas, double recargoPorTransaccionAdicional)
        : base(numeroCuenta, titular)
    {
        MaximoTransaccionesGratuitas = maximoTransaccionesGratuitas;
        RecargoPorTransaccionAdicional = recargoPorTransaccionAdicional;
    }

    public override double Reintegro(double cantidad)
    {
        NumeroTransaccionesMesActual++;
        if (NumeroTransaccionesMesActual > MaximoTransaccionesGratuitas)
            Saldo -= (NumeroTransaccionesMesActual - MaximoTransaccionesGratuitas) * RecargoPorTransaccionAdicional;

        return base.Reintegro(cantidad);
    }

    public void AplicaRecargosMes()
    {
        Saldo -= (NumeroTransaccionesMesActual - MaximoTransaccionesGratuitas) * RecargoPorTransaccionAdicional;
        NumeroTransaccionesMesActual = 0;
    }

    public override string ToString()
    {
        return $"....en Cuenta Corriente\n{base.ToString()}";
    }
}

public class CuentaCredito : Cuenta
{
    private double TasaInteres { get; }

    public CuentaCredito(string numeroCuenta, string titular, double tasaInteres, double limiteCredito)
        : base(numeroCuenta, titular)
    {
        TasaInteres = tasaInteres;
        LimiteCredito = limiteCredito;
    }

    public double LimiteCredito { get; }

    public override double Reintegro(double cantidad)
    {
        if (Saldo + LimiteCredito < cantidad)
            throw new CreditoMaximoExcedidoException($"No se puede retirar {cantidad:C}. Límite de crédito excedido.", cantidad, Saldo, LimiteCredito);

        Saldo -= cantidad;
        return cantidad;
    }

    public double CargaInteresesMes()
    {
        double cargo = (Saldo < 0) ? Math.Abs(Saldo) * TasaInteres : 0;
        Saldo -= cargo;
        return cargo;
    }

    public override string ToString()
    {
        return $"....en Cuenta Crédito\n{base.ToString()}";
    }

    public class CreditoMaximoExcedidoException : Exception
    {
        public CreditoMaximoExcedidoException(string message, double reintegroSolicitado, double saldo, double limiteCredito)
            : base($"{message} Reintegro solicitado: {reintegroSolicitado:C}, Saldo actual: {saldo:C}, Límite de crédito: {limiteCredito:C}.")
        {
        }
    }
}

