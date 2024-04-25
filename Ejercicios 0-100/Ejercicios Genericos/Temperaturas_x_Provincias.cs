namespace Ejercicios_Genericos;

public class Temperaturas_x_Provincias
{
    public string Provincia { get; }
    public float TemperaturaMaxima { get; }
    public float TemperaturaMinima { get; }

    public Temperaturas_x_Provincias(string provincia, float temperaturaMaxima, float temperaturaMinima)
    {
        Provincia = provincia;
        TemperaturaMaxima = temperaturaMaxima;
        TemperaturaMinima = temperaturaMinima;
    }
}
