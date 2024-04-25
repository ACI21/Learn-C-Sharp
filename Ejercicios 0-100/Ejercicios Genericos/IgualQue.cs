namespace Ejercicios_Genericos;

public class IgualQue : ICumplePredicado<float>
{
    public bool Predicado(float o1, float o2)
    {
        return o1 > o2;
    }
}