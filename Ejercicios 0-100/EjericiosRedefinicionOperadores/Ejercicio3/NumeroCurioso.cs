namespace Ejercicios_Redefinicion_Operadores;

using System;

public class NumeroCurioso
{
    // Atributos
    private double _a;
    private double _b;
    private double _c;

    // Propiedades
    public double A
    {
        get { return _a; }
        private set { _a = value; }
    }

    public double B
    {
        get { return _b; }
        set { _b = value; }
    }

    public double C
    {
        get { return _c; }
        set { _c = value; }
    }

    // Constructor
    public NumeroCurioso(double a, double b, double c)
    {
        _a = a;
        _b = b;
        _c = c;
    }

    // Método para verificar si es un número curioso
    public bool EsNumeroCurioso()
    {
        return Math.Abs(_a * _a + _b * _b + _c * _c - 1) < 0.0001;
    }

    // Redefinición del operador de suma
    public static NumeroCurioso operator +(NumeroCurioso num1, NumeroCurioso num2)
    {
        double newA = num1.A + num2.A;
        double newB = num1.B + num2.B;
        double newC = num1.C + num2.C;
        return new NumeroCurioso(newA, newB, newC);
    }

    // Redefinición del operador de resta
    public static NumeroCurioso operator -(NumeroCurioso num1, NumeroCurioso num2)
    {
        double newA = num1.A - num2.A;
        double newB = num1.B - num2.B;
        double newC = num1.C - num2.C;
        return new NumeroCurioso(newA, newB, newC);
    }

    // Método para imprimir las coordenadas del número curioso
    public override string ToString()
    {
        return $"({A}, {B}, {C})";
    }
}