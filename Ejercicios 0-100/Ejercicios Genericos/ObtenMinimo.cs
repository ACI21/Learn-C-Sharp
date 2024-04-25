namespace Ejercicios_Genericos;
public class ObtenMinimo : IObtenTemperatura
{
    public float ObtenerTemperatura(Temperaturas_x_Provincias provincia)
    {
        return provincia.TemperaturaMinima;
    }
}