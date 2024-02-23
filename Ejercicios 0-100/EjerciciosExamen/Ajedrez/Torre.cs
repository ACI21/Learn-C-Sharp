namespace Ejercicios_Examen;

public class Torre: Pieza
{
    public Torre(ColorAjedrez color) : base(color)
    {
    }

    public override double Valor()
    {
        return 5.5;
    }

    public override string Nombre()
    {
        return "Torre";
    }
}