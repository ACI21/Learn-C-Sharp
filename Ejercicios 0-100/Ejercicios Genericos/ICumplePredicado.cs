namespace Ejercicios_Genericos;

public interface ICumplePredicado<T>
{
    bool Predicado(T o1, T o2);
}