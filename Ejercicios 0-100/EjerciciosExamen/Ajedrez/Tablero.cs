using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;

namespace Ejercicios_Examen;

public class Tablero
{
    private const int DIMENSION_TABLERO = 8;
    private readonly Casilla[,] casillas;

    public Tablero()
    {
        casillas = new Casilla[DIMENSION_TABLERO, DIMENSION_TABLERO];

        for (int i = 0; i < DIMENSION_TABLERO; i++)
        {
            for (int j = 0; j < DIMENSION_TABLERO; j++)
            {
                casillas[i, j] = new Casilla((i + j) % 2 == 0 ? ColorAjedrez.Blanco : ColorAjedrez.Negro);
            }
        }
    }


    /* 
     * Hacemos un regex para comprobar que las coordenadas no son distintas a:
     * -Letras del abc: A-B-C-D-E-F-G-H
     * -Numero max: 1-2-3-4-5-6-7-8
    */
    private static readonly Regex CoordenadaValidaRegex = new Regex(@"^[A-H][1-8]$");

    private (int fila, int columna) CoordenadaToFilaColumna(string coordenada)
    {
        if (!CoordenadaValidaRegex.IsMatch(coordenada))
        {
            throw new AjedrezException($"{coordenada} no es válida");
        }
        int fila = int.Parse(coordenada[1].ToString()) - 1; //Le restamos 1 para saber la posicion fila correcta en el array
        int columna = coordenada[0] - 'A'; //Le restamos A para saber la posicion columna correcta en el array
        return (fila, columna); //Devolvemos 2 variables a la vez
    }

    public bool HayPieza(string coordenada) //esperamos algo como "B3","H5", ....
    {
        var (fila, columna) = CoordenadaToFilaColumna(coordenada);

        if (casillas[fila, columna].GetPieza() != null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public Pieza? VerPieza(string coordenada)
    {
        if (!HayPieza(coordenada))
        {
            throw new AjedrezException($"No hay pieza en {coordenada}");
        }
        var (fila, columna) = CoordenadaToFilaColumna(coordenada);
        return casillas[fila, columna].GetPieza();
    }

    public Pieza? QuitaPieza(string coordenada)
    {
        if (!HayPieza(coordenada))
        {
            throw new AjedrezException($"No hay pieza en {coordenada}");
        }
        var (fila, columna) = CoordenadaToFilaColumna(coordenada);
        var pieza = casillas[fila, columna].GetPieza();
        casillas[fila, columna].SetPieza(null);
        return pieza;
    }

    public void PonPieza(string coordenada, Pieza pieza)
    {
        if (pieza == null)
        {
            throw new ArgumentNullException("La pieza no puede ser null");
        }

        var (fila, columna) = CoordenadaToFilaColumna(coordenada);
        if (HayPieza(coordenada))
        {
            throw new AjedrezException($"Ya hay una pieza en {coordenada}");
        }
        casillas[fila, columna].SetPieza(pieza);
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        string mensaje = "";
        double valorTotalBlancas = 0.0;
        double valorTotalNegras = 0.0;

        for (int fila = 0; fila < DIMENSION_TABLERO; fila++)
        {
            for (int columna = 0; columna < DIMENSION_TABLERO; columna++)
            {
                Casilla casillaActual = casillas[fila, columna];
                if (casillaActual.GetPieza() != null)
                {
                    mensaje = $"{casillaActual.GetPieza()} en {(char)('A' + columna)}{fila + 1} {casillaActual.GetPieza()?.GetColor()}";
                    sb.AppendLine(mensaje);

                    if (casillaActual.GetPieza()?.GetColor() == ColorAjedrez.Blanco)
                        valorTotalBlancas += casillaActual.GetPieza().Valor();
                    else
                        valorTotalNegras += casillaActual.GetPieza().Valor();
                }
            }
        }

        sb.AppendLine($"Valor total blancas: {valorTotalBlancas}");
        sb.AppendLine($"Valor total negras: {valorTotalNegras}");
        return sb.ToString();
    }
}