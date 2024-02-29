using System;

public static class Taxi
{
    const float BAJADA_BANDERA = 1.82F;
    const float CARRERA_MINIMA = 3.63F;
    const float COSTE_KM = 0.9F;
    const float ESPERA_POR_HORA = 18.77F;
    const short PORCENTAJE_NOCTURNO = 30;

    public static double CosteCarrera(float kilometrosRecorridos, float minutosEspera)
    {
        return CalcularCoste(kilometrosRecorridos, minutosEspera, false, 0, 0);
    }

    public static double CosteCarrera(float kilometrosRecorridos, float minutosEspera, bool nocturno)
    {
        return CalcularCoste(kilometrosRecorridos, minutosEspera, nocturno, 0, 0);
    }

    public static double CosteCarrera(float kilometrosRecorridos, float minutosEspera, bool nocturno, int porcentajeFestivo)
    {
        return CalcularCoste(kilometrosRecorridos, minutosEspera, nocturno, porcentajeFestivo, 0);
    }

    public static double CosteCarrera(float kilometrosRecorridos, float minutosEspera, bool nocturno, int porcentajeFestivo, uint ocupacionExtra)
    {
        return CalcularCoste(kilometrosRecorridos, minutosEspera, nocturno, porcentajeFestivo, ocupacionExtra);
    }

    private static double CalcularCoste(float kilometrosRecorridos, float minutosEspera, bool nocturno, int porcentajeFestivo, uint ocupacionExtra)
    {
        float costeCarrera = BAJADA_BANDERA + kilometrosRecorridos * COSTE_KM
                                    + minutosEspera * (ESPERA_POR_HORA / 60);
        costeCarrera = costeCarrera < CARRERA_MINIMA
                                    ? CARRERA_MINIMA
                                    : costeCarrera;
        float incrementoNocturno = nocturno
                                    ? costeCarrera / PORCENTAJE_NOCTURNO
                                    : 0;
        float incrementoFestivo = porcentajeFestivo != 0
                                    ? costeCarrera * porcentajeFestivo / 100f
                                    : 0;
        costeCarrera += incrementoFestivo >= incrementoNocturno
                                    ? incrementoFestivo
                                    : incrementoNocturno;
        costeCarrera += ocupacionExtra;
        return costeCarrera;
    }
}