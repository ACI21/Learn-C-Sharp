namespace Ejercicios_Excepciones;

using System;

public class NumeroCuenta
{
    private string entidad { get; set; }
    private string sucursal { get; set; }
    private string dcEntSuc { get; set; }
    private string dcNumero { get; set; }
    private string cuenta { get; set; }

    public NumeroCuenta(in string numero)
    {
        int[] ponderacionEntidad = { 4, 8, 5, 10, 9, 7, 3, 6 };
        int[] ponderacionCuenta = { 1, 2, 4, 8, 5, 10, 9, 7, 3, 6 };

        if (!FormatoCorrecto(numero)
        || !DcCorrecto(numero[8].ToString(), numero, ponderacionEntidad)
        || !DcCorrecto(numero[9].ToString(), numero, ponderacionCuenta))
        {
            throw new NumeroCuentaIncorrectoException("Número  de Cuenta Incorrecto");
        }
        else
        {
            this.cuenta = numero;
            this.entidad = numero.Substring(0, 4);
            this.sucursal = numero.Substring(4, 4);
            this.dcEntSuc = CalcularDCEntidadSucursal(numero.Substring(0, 8)).ToString();
            this.dcNumero = CalcularDCNumeroCuenta(numero.Substring(10)).ToString();
        }
    }

    private static bool FormatoCorrecto(in string numero)
    {

        try
        {
            if (int.TryParse(numero, out int resultado) && numero.Length == 20)
            {
                return System.Text.RegularExpressions.Regex.IsMatch(numero, "^\\d{20}$");
            }
        }
        catch (NumeroCuentaIncorrectoException)
        {
            throw new NumeroCuentaIncorrectoException("El formato de la cuenta no cumple las condiciones necesarias.");
        }

        return false;

    }

    private int CalcularDCEntidadSucursal(string entidadSucursal)
    {
        int[] ponderaciones = { 4, 8, 5, 10, 9, 7, 3, 6 };
        int resultado = 0;

        for (int i = 0; i < entidadSucursal.Length; i++)
        {
            resultado += int.Parse(entidadSucursal[i].ToString()) * ponderaciones[i];
        }

        int dc = 11 - (resultado % 11);
        return (dc == 10) ? 1 : (dc == 11) ? 0 : dc;
    }

    private int CalcularDCNumeroCuenta(string numeroCuenta)
    {
        int[] ponderaciones = { 1, 2, 4, 8, 5, 10, 9, 7, 3, 6 };
        int resultado = 0;

        for (int i = 0; i < numeroCuenta.Length; i++)
        {
            resultado += int.Parse(numeroCuenta[i].ToString()) * ponderaciones[i];
        }

        int dc = 11 - (resultado % 11);
        return (dc == 10) ? 1 : (dc == 11) ? 0 : dc;
    }

    private static bool DcCorrecto(in string dc, in string digitos, in int[] ponderaciones)
    {
        int resultado = 0;

        for (int i = 0; i < digitos.Length; i++)
        {
            resultado += int.Parse(digitos[i].ToString()) * ponderaciones[i];
        }

        int calculatedDC = 11 - (resultado % 11);
        return calculatedDC == int.Parse(dc);
    }

    public override string ToString()
    {
        return $"Entidad: {entidad}, Sucursal: {sucursal}, DC Entidad/Sucursal: {dcEntSuc}, DC Numero: {dcNumero}, Cuenta: {cuenta}";
    }
}