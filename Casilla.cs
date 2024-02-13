namespace Ejercicios_Examen;

public class Casilla
{
    private Pieza? pieza;
    private readonly ColorAjedrez color;

    public Casilla(){
        this.pieza = null;
    }
    public Casilla(ColorAjedrez color){
        this.pieza = null;
        this.color = color;
    }
    public Casilla(Pieza pieza, ColorAjedrez color){
        this.pieza = pieza;
        this.color = color;
    }

    public Pieza? GetPieza(){
        return pieza;
    }

    public void SetPieza(Pieza pieza){
        this.pieza = pieza;
    }

    public ColorAjedrez GetColorAjedrez(){
        return color;
    }
}