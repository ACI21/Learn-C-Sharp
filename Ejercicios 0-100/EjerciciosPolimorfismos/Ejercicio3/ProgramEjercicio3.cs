namespace Ejercicios_Polimorfismos;

public class ProgramEjercicio3
{
    static CuentaAhorro ca = new CuentaAhorro("2085 0103 92 0300731702", "Nicolas", .02d);
    static CuentaDeposito cd = new CuentaDeposito("2100 1162 43 0200084482", "Juan", .06d, .05d);
    static CuentaCorriente cc = new CuentaCorriente("2100 0721 09 0200601249", "Jhon", 2, 3d);
    static CuentaCredito cr = new CuentaCredito("0049 0345 31 2710611698", "Jose", .18d, 2000);

    static void SaldoActual(Cuenta cuenta)
    {
        Console.WriteLine($"Saldo tras operación {cuenta.Saldo:C}\n");
    }

    static void Ingresa(Cuenta cuenta, double[] cantidades)
    {
        foreach (double cantidad in cantidades)
        {
            Console.WriteLine($"Ingresando {cantidad:C} en {cuenta}.");
            cuenta.Ingreso(cantidad);
            SaldoActual(cuenta);
        }
    }

    static void Retira(Cuenta cuenta, double[] cantidades)
    {
        foreach (double cantidad in cantidades)
        {
            try
            {
                Console.WriteLine($"Retirando {cantidad:C} en {cuenta}.");
                Console.WriteLine($"La cantidad recibida es: {cuenta.Reintegro(cantidad):C}");
            }
            catch (Cuenta.SaldoInsuficException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (CuentaCredito.CreditoMaximoExcedidoException e)
            {
                Console.WriteLine(e.Message);
            }
            SaldoActual(cuenta);
        }
    }

    static void FinalizaMes()
    {
        Console.WriteLine("Finalizando mes actual ...");
        Console.WriteLine($"Aplicando intereses en {ca}...");
        ca.SumaInteres();
        SaldoActual(ca);
        Console.WriteLine($"Aplicando intereses en {cd}...");
        cd.SumaInteres();
        SaldoActual(cd);
        Console.WriteLine($"Aplicando recargos en {cc}...");
        cc.AplicaRecargosMes();
        SaldoActual(cc);
        Console.WriteLine($"Revisando cargo sobre saldo negativo en {cr}...");
        double cargo = cr.CargaInteresesMes();
        if (cargo > 0d)
            Console.WriteLine($"Has tenido un cargo de {cargo:C} por saldo negativo.");
        SaldoActual(cr);
    }

    public static void main()
    {
        Ingresa(ca, new double[] { 1000, 1000 });
        Ingresa(cd, new double[] { 10000 });
        Retira(ca, new double[] { 10000000, 500 });
        Ingresa(cc, new double[] { 1000, 2000 });
        Ingresa(cc, new double[] { 2000 });
        Retira(cc, new double[] { 500, 10000000, 500 });
        Ingresa(cr, new double[] { 1000 });
        Retira(cr, new double[] { 500 });
        Retira(cd, new double[] { 10000000, 1000 });
        FinalizaMes();
        cd.Vencimiento = true;
        Ingresa(ca, new double[] { 1000, 1000 });
        Retira(ca, new double[] { 500 });
        Ingresa(cc, new double[] { 1000 });
        Retira(cc, new double[] { 100, 200, 100, 100, 100 });
        Retira(cr, new double[] { 1000 });
        Retira(cd, new double[] { 1000 });
        FinalizaMes();
        Retira(cr, new double[] { 11000 });
    }
}