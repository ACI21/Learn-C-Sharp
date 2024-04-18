namespace Ejercicios_BCL;

using System.Text.RegularExpressions;

public class Polinomio
{
    private SortedDictionary<int, int> Monomios { get; set; }

    // Constructor que recibe una cadena con el polinomio
    public Polinomio(string cadenaPolinomio)
    {
        Monomios = new SortedDictionary<int, int>();
        string patronMonomio = @"(?<coeficiente>[+-]?\d*)(?<incognita>[xX]?)(?<exponente>[1-9]|\d*)";
        MatchCollection matches = Regex.Matches(cadenaPolinomio, patronMonomio);

        foreach (Match match in matches)
        {
            int coeficiente = string.IsNullOrEmpty(match.Groups["coeficiente"].Value) ? 1 : int.Parse(match.Groups["coeficiente"].Value);
            int exponente = string.IsNullOrEmpty(match.Groups["exponente"].Value) ? 0 : int.Parse(match.Groups["exponente"].Value);
            if (match.Groups["incognita"].Value.ToLower() == "x")
            {
                Monomios[exponente] = coeficiente;
            }
            else
            {
                Monomios[0] = coeficiente;
            }
        }
    }

    // Método ToString para mostrar el polinomio
    public override string ToString()
    {
        List<string> monomios = new List<string>();
        foreach (var kvp in Monomios)
        {
            if (kvp.Value != 0)
            {
                string monomio = kvp.Value == 1 ? "" : kvp.Value == -1 ? "-" : kvp.Value.ToString();
                monomio += kvp.Key == 0 ? "" : kvp.Key == 1 ? "x" : "x^" + kvp.Key;
                monomios.Add(monomio);
            }
        }
        return string.Join("+", monomios);
    }

    // Método estático para la suma de dos polinomios
    public static Polinomio Suma(Polinomio p1, Polinomio p2)
    {
        Polinomio suma = new Polinomio("");

        foreach (var kvp in p1.Monomios)
        {
            suma.Monomios[kvp.Key] = kvp.Value;
        }

        foreach (var kvp in p2.Monomios)
        {
            if (suma.Monomios.ContainsKey(kvp.Key))
            {
                suma.Monomios[kvp.Key] += kvp.Value;
            }
            else
            {
                suma.Monomios[kvp.Key] = kvp.Value;
            }
        }

        return suma;
    }
}