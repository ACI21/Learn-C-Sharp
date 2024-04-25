namespace Ejercicios_Genericos;
public class Fraccion<T>
{
    public T Numerador { get; }
    public T Denominador { get; }

    public Fraccion(T numerador, T denominador)
    {
        Numerador = numerador;
        Denominador = denominador;
    }
}