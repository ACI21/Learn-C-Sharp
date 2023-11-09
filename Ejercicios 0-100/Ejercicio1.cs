// Un biólogo está realizando un estudio de dis;ntas especies de invertebrados y necesita una aplicación que le ayude a contabilizar el número de patas que 
// tienen en total todos los animales capturados durante una jornada de trabajo. 
// Para ello, nos ha solicitado que escribamos una aplicación a la que hay que proporcionar:
// • el número de hormigas capturadas (6 patas),
// • el número de arañas capturadas (8 patas),
// • el número de cochinillas capturadas (14 patas).
// La aplicación debe mostrar el número total de patas que poseen todos los animales.
namespace Ejercicios_0_100;

public class Ejercicio1
{
    public static void main()
    {
        //Declaracion de variables
        const int patasHormigas = 6;
        const int patasAranyas = 8;
        const int patasCochinillas = 14;
        int hormigas = 0;
        int aranyas = 0;
        int cochinillas = 0;
        int patasTotales = 0;

        //DESARROLLO DEL PROGRAMA
        Console.Write("Hormigas obtenidas: ");
        hormigas = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Aranyas obtenidas: ");
        aranyas = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Cochinillas obtenidas: ");
        cochinillas = int.Parse(Console.ReadLine() ?? "0");

        patasTotales = (hormigas * patasHormigas) + (aranyas * patasAranyas) + (cochinillas * patasCochinillas);

        //FIN DE PROGRAMA
        Console.WriteLine("Patas obtenidas: " + patasTotales);
    }
}