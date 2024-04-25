namespace Ejercicios_Genericos;

class Persona: IComparable<Persona>, ICloneable
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    public int CompareTo(Persona other)
    {
        if (other == null) return 1;

        int result = this.Edad.CompareTo(other.Edad);
        if (result != 0) return result;

        return this.Nombre.CompareTo(other.Nombre);
    }

    public object Clone()
    {
        return new Persona { Nombre = this.Nombre, Edad = this.Edad };
    }

    public override string ToString()
    {
        return $"{Nombre}, {Edad} años";
    }
}