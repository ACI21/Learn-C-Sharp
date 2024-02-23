using System.Drawing;

namespace Ejercicios_Examen;

public abstract class Pieza
{
    private readonly ColorAjedrez color;

    public Pieza(ColorAjedrez color){
        this.color = color;
    }

    public ColorAjedrez GetColor(){
        return color;
    }

    public abstract double Valor();

    public abstract string Nombre();

    public override string ToString()
    {
        return $"{Nombre()} {color}";
    }
}