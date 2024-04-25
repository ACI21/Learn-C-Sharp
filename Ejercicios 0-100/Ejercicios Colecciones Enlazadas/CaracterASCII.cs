namespace Ejercicios_Colecciones_Enlazadas;

public class CaracterASCII
{
    private readonly char caracter;
    public char Caracter => caracter;
    public string CaracterDecimal => ((int)caracter).ToString();
    public string CaracterOctal => Convert.ToString(caracter, 8);
    public string CaracterHexadecimal => Convert.ToString(caracter, 16);

    public CaracterASCII(char caracter)
    {
        if (caracter < 0 || caracter > 255)
            throw new CaracterException("El caracter debe estar en el rango de 0 a 255.");
        this.caracter = caracter;
    }

    public CaracterASCII(short caracter)
    {
        if (caracter < 0 || caracter > 255)
            throw new CaracterException("El caracter debe estar en el rango de 0 a 255.");
        this.caracter = (char)caracter;
    }

    public override string ToString()
    {
        return $"{(int)caracter,3:D} {(int)caracter,3:X2} {Convert.ToString(caracter, 8),-3} {caracter,2}";
    }

    public override bool Equals(object obj)
    {
        if (obj is CaracterASCII)
        {
            return caracter == ((CaracterASCII)obj).caracter;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return caracter.GetHashCode();
    }
}