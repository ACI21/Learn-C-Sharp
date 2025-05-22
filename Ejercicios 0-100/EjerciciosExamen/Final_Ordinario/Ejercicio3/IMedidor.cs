namespace Ejercicios_Examen;

public interface IMedidor
{
    Dictionary<DateTime, double> Mediciones { get;}
    string UnidadesMedicion {get;} // sus valores serán "l/m2" o "µgr/m3"
    string Tipo {get;} // nombre del dispositivo "MedidiorNo2" o el "Pluviometro98"

}