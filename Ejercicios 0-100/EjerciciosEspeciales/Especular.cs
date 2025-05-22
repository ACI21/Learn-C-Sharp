// Ejercicio: Codificación Especular de Texto
// Crear un programa que transforme un texto aplicando varias técnicas de codificación.
// El programa debe:
// 1. Permitir al usuario introducir un texto (terminando con un punto)
// 2. Aplicar las siguientes transformaciones al texto:
//    - Codificación especular: invertir cada palabra del texto, manteniendo el orden de las palabras
//    - Codificación de puntuación: reemplazar los caracteres de puntuación (.,;:!¿?¡) con caracteres
//      aleatorios del rango ASCII extendido (224-239)
// 3. Mostrar el texto resultante después de aplicar ambas codificaciones
// 4. Incluir también un método para eliminar espacios (aunque no se use en la implementación principal)
namespace Ejercicios_Especiales;

using System.Text;

public class Especular
{
    public static void main(){
        StringBuilder texto = new StringBuilder();
        texto.Append(CrearTexto());
        texto = CodificacionEspecular(texto);
        texto = CodificacionPuntuacion(texto);
        Console.WriteLine(texto.ToString());
    }

    private static string CrearTexto()
    {
        Console.WriteLine("Escribe cuanto quieras, para finalizar escribe .");
        string textito = " ";
        string texto = "";
        do
        {
            textito = Console.ReadLine()??"";
            texto += textito;
        } while (!texto.Contains('.'));

        return texto;
    }

    private static StringBuilder CodificacionEspecular(StringBuilder frase)
    {
        StringBuilder resultado = new StringBuilder();
        int inicioPalabra = 0;

        for (int i = 0; i <= frase.Length; i++)
        {
            if (i == frase.Length || frase[i] == ' ')
            {
                for (int j = i - 1; j >= inicioPalabra; j--)
                {
                    resultado.Append(frase[j]);
                }

                if (i != frase.Length)
                {
                    resultado.Append(' ');
                }

                inicioPalabra = i + 1;
            }
        }

        return resultado;
    }

    private static StringBuilder CodificacionPuntuacion(StringBuilder frase)
    {
        StringBuilder resultado = new StringBuilder();
        string caracteresEspeciales = ",:.:;?!¿!¡";

        Random random = new Random();

        for(int i = 0; i < frase.Length; i++)
        {
            if (caracteresEspeciales.Contains(frase[i].ToString()))
            {
                char caracterOfuscado = (char)random.Next(224, 239);
                resultado.Append(caracterOfuscado);
            }
            else
            {
                resultado.Append(frase[i]);
            }
        }

        return resultado;
    }

    private static StringBuilder CodificacionSinEspacios(StringBuilder frase)
    {
        StringBuilder resultado = new StringBuilder();

        for(int i = 0; i < frase.Length; i++)
        {
            char c = frase[i];
            if (c != ' ')
            {
                resultado.Append(c);
            }
        }

        return resultado;
    }
   
}
