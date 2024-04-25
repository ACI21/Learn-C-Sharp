using System.Dynamic;

namespace Ejercicios_Genericos;


class Lista<T>
{
    private T[] items;

    public Lista()
    {
        items = new T[0];
    }

    public void Add(T item)
    {
        T[] newItems = new T[items.Length + 1];
        items.CopyTo(newItems, 0);
        newItems[items.Length] = item;
        items = newItems;
    }

    public T this[int index]
    {
        get
        {
            return items[index];
        }
        set
        {
            items[index] = value;
        }
    }
}