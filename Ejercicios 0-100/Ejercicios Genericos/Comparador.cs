namespace Ejercicios_Genericos;

public static class Comparador<T> where T : IComparable<T>
{
    public static bool Mayor(T a, T b)
    {
        return a.CompareTo(b) > 0;
    }

    public static bool Menor(T a, T b)
    {
        return a.CompareTo(b) < 0;
    }
}
