namespace  Ejercicios_IO;

public class Microprocesador
{
    private string modelo;
    private int nucleos;
    private double frecuencia;

    public Microprocesador(string modelo, int nucleos, double frecuencia)
    {
        this.modelo = modelo;
        this.nucleos = nucleos;
        this.frecuencia = frecuencia;
    }

    public override string ToString()
    {
        return $"Modelo: {modelo}\nNucleos: {nucleos}\nFrecuencia: {frecuencia}";
    }

    public string ACSV()
    {
        return $"{modelo};{nucleos};{frecuencia}";
    }

    public static Microprocesador AMicroprocesador(string datos)
    {
        string[] partes = datos.Split(';');
        string modelo = partes[0];
        int nucleos = int.Parse(partes[1]);
        double frecuencia = double.Parse(partes[2]);
        return new Microprocesador(modelo, nucleos, frecuencia);
    }
}