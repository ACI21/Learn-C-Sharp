namespace Ejercicios_Genericos;
public class ObtenMaxima : IObtenTemperatura
{
    public float ObtenerTemperatura(Temperaturas_x_Provincias provincia)
    {
        return provincia.TemperaturaMaxima;
    }
}