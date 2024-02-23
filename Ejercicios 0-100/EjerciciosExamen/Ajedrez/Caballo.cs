namespace Ejercicios_Examen;

public class Caballo: Pieza
{
    public Caballo(ColorAjedrez color) : base(color)
    {
    }

    public override double Valor()
    {
        return 3;
    }

    public override string Nombre()
    {
        return "Caballo";
    }
}