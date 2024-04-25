using System.Security.Cryptography.X509Certificates;

namespace Ejercicios_Genericos;

class Ejercicio5
{
    public static void main()
    {
        var provincias = RecogeTemperaturasPorProvincia();
        var estrategiaMaxima = new ObtenMaxima();
        var estrategiaMinima = new ObtenMinimo();
        float mediaMaximas = MediaTemperaturas(provincias, estrategiaMaxima);
        float mediaMinimas = MediaTemperaturas(provincias, estrategiaMinima);

        Console.WriteLine("Provincias cuya máxima sea mayor a la media de las máximas:");
        MuestraProvincias(provincias, mediaMaximas, estrategiaMaxima, new MayorQue());

        Console.WriteLine("Provincias cuya mínima sea menor a la media de las mínimas:");
        MuestraProvincias(provincias, mediaMinimas, estrategiaMinima, new MenorQue());

        Console.WriteLine("Provincias cuya mínima sea igual a la media de las mínimas:");
        MuestraProvincias(provincias, mediaMinimas, estrategiaMinima, new IgualQue());
    }


    static float MediaTemperaturas(Temperaturas_x_Provincias[] provincias, IObtenTemperatura estrategia)
    {
        float suma = 0;
        foreach (var provincia in provincias)
        {
            suma += estrategia.ObtenerTemperatura(provincia);
        }
        return suma / provincias.Length;
    }

    static void MuestraProvincias(Temperaturas_x_Provincias[] provincias, float valor, IObtenTemperatura estrategia, ICumplePredicado<float> predicado)
    {
        foreach (var provincia in provincias)
        {
            if (predicado.Predicado(estrategia.ObtenerTemperatura(provincia), valor))
            {
                Console.WriteLine(provincia.Provincia);
            }
        }
    }

    static Temperaturas_x_Provincias[] RecogeTemperaturasPorProvincia()
    {
        Console.Write("De cuantas provincias quieres recoger la temperatura: ");
        var temperaturasPorProvincia = new Temperaturas_x_Provincias[int.Parse(Console.ReadLine() ?? "")];
        Random seed = new Random();
        for (int i = 0; i < temperaturasPorProvincia.Length; i++)
        {
            Console.Write($"Introduce la provincia nº{i + 1}:  ");
            string provincia = Console.ReadLine() ?? "";
            float temperaturaMaxima = seed.Next(17, 25);
            float temperaturaMinima = seed.Next(-5, 17);
            Console.Write("\n\n");
            temperaturasPorProvincia[i] = new Temperaturas_x_Provincias(
                                            provincia,
                                            temperaturaMaxima,
                                            temperaturaMinima);
        }
        return temperaturasPorProvincia;
    }
}