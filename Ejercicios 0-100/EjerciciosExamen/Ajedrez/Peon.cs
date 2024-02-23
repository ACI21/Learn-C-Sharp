namespace Ejercicios_Examen;

public class Peon: Pieza
{
    public Peon(ColorAjedrez color) : base(color)
    {
    }

    public override double Valor()
    {
        return 1;
    }

    public override string Nombre()
    {
        return "Peón";
    }
}