


using System.Text.RegularExpressions;

namespace Ejercicios_Examen;

public class Principal2{
    public static void Main(){
        string ruta = "Ejercicios 0-100/EjerciciosExamen/Final_Ordinario/Ejercicio2/registros.xml";
        string contenido = LeerArchivo(ruta);
        if(contenido != null){
            string limpia = LimpiarTexto(contenido);
            AnalizarRegistros(limpia);
        }
    }

    private static void AnalizarRegistros(string limpia)
    {
        string[] ciudades = {"Alicante", "Valencia", "Castellon"};
        foreach (var ciudad in ciudades)
        {
            string patron = $@"<registro ciudad=""{ciudad}"" valor""([\d]+,[\d]+)"" hora=""([\d:])+"">" ; 
            /*
            * $ sirve para formatear el texto
            * @ permite evitar carecteres de escape como el \\, \, etc...
            * [\d]+ capturar uno o más digitos
            * , una coma para decimales, pero es una coma literalmente
            * () es para grupar 
            * ([\d:]+) captura horas en formato HH:MM:SS
            */
           MatchCollection match = Regex.Matches(limpia, patron);
           double maxValor = -1; // guardar la medicion más alta encontrada para la ciudad
           string mejorHora = ""; // guardamos su hora

           foreach (Match m in match)
           {
                // m -> <registro ciudad="Alicante" valor= "32.95" hora="12:02:23">
                // m.Groups[0].Value -> Alicante
                // m.Groups[1].Value -> 32.95
                // m.Groups[2].Value -> 12:02:23
                double valor = double.Parse(m.Groups[1].Value);
                string hora = m.Groups[2].Value;

                if (valor > maxValor){
                    maxValor = valor;
                    mejorHora = hora;
                }
           }

           if(maxValor != -1){
            Console.WriteLine($"La ciudad {ciudad} de con una medición de {maxValor} ha alcanzado el nivel más alto de contaminación a las {mejorHora}");
           }
        }


    }

    private static string LimpiarTexto(string contenido)
    {
        return contenido.Replace("\r", "").Replace("\n", "").Trim(); // quitar los saltos de linea ( \n y \r ) y espacios en blanco ( trim() )
    }

    private static string LeerArchivo(string ruta)
    {
        try
        {
            return File.ReadAllText(ruta); // leemos el fichero de esta ruta
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("El fichero no está en la ruta proporcionada.");
            return null;
        }catch (IOException)
        {
            Console.WriteLine("El fichero está siendo usado por otro programa.");
            return null;
        }
    }
}