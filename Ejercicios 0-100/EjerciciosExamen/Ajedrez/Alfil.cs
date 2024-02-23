namespace Ejercicios_Examen;

public class Alfil: Pieza
{
    public Alfil(ColorAjedrez color) : base(color)
    {
    }

    public override double Valor()
    {
        return 3.5;
    }

    public override string Nombre()
    {
        return "Alfil";
    }
}