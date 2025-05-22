namespace Ejercicios_Examen;

public class Principal1
{
    public static void Main(){
        string[] ciudades = {"Alicante", "Valencia", "Castellon"};
        double[][] tablaMediciones = new double[ciudades.Length][];
        Random semilla = new Random();
        double umbral = 10.0;

        for (int f = 0; f < ciudades.Length; f++)
        {
            double[] mediciones = new double[0];
            for (int c = 0; c < 12; c++)
            {
                double medicion = MedicionNO2(semilla);
                mediciones = ControlNO2(mediciones, medicion, umbral);
            }

            tablaMediciones[f] = mediciones;
        }

        MostrarMediciones(ciudades, tablaMediciones);
    }

    private static void MostrarMediciones(string[] ciudades, double[][] tablaMediciones)
    {
        for (int i = 0; i < ciudades.Length; i++)
        {
            Console.WriteLine(ciudades[i]);
            Console.WriteLine(string.Join(" - ", tablaMediciones[i].Select(m => m.ToString("F2"))) );
        }
    }

    private static double[] ControlNO2(double[] mediciones, double nuevaMedicion, double umbral)
    {
        if(nuevaMedicion > umbral){ // ¿queremos añadir uno más?
            double[] mediciones2 = new double[mediciones.Length + 1]; // Creamos un doble con su capacidad actual + 1
            mediciones.CopyTo(mediciones2, 0); // Copiamos los datos anteriores en el nuevo para no perder datos
            mediciones2[mediciones2.Length - 1] = nuevaMedicion; // sacamos la ultima y nueva posicion agregada y añadimos el nuevo valor
            return mediciones2;
        }

        return mediciones;
    }

    private static double MedicionNO2(Random semilla)
    {
        Thread.Sleep(1000);
        double medicion = semilla.NextDouble() * 39.74 + 0.84;
        return Math.Round(medicion, 2); // -> 20,08 
    }
}