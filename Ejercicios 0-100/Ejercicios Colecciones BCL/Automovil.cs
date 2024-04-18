namespace Ejercicios_BCL;

class Automovil
{
    // Propiedades del automóvil
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Cilindrada { get; set; }
    public int AñoFabricacion { get; set; }
    public string Color { get; set; }

    // Constructor
    public Automovil(string marca, string modelo, int cilindrada, int añoFabricacion, string color)
    {
        Marca = marca;
        Modelo = modelo;
        Cilindrada = cilindrada;
        AñoFabricacion = añoFabricacion;
        Color = color;
    }
}