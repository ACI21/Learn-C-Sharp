namespace Ejercicios_Genericos;

public class A<T, U>
{
    private T clave;
    private U valor;

    public A(T clave, U valor)
    {
        this.clave = clave;
        this.valor = valor;
    }

    public T Clave
    {
        get { return clave; }
    }

    public U Valor
    {
        get { return valor; }
    }
}