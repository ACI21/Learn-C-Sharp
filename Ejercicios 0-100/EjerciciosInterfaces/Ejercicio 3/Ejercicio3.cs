using System;

namespace Ejercicios_Interfaces;

class Ejercicio3
{
    public static void main()
    {
        string[] canciones = {
        "Wanna Be Startin' Somethin", "Baby Be Mine", "The Girl Is Mine", "Thriller", "Beat It",
        "Billie Jean", "Human Nature", "P.Y.T. (Pretty Young Thing)", "The Lady in My Life"};
        Disc thriller = new Disc("Thriller", "Michael Jackson", canciones);
        DABRadioCD radioCD = new DABRadioCD();
        ConsoleKeyInfo tecla = new ConsoleKeyInfo();
        do
        {
            try
            {
                Console.WriteLine(radioCD.MessageToDisplay);
                tecla = Console.ReadKey(true);
                Console.Clear();
                switch (tecla.Key) {
                    case ConsoleKey.D1:
                        radioCD.Play();
                        break;
                    case ConsoleKey.D2:
                        radioCD.Pause();
                        break;
                    case ConsoleKey.D3:
                        radioCD.Stop();
                        break;
                    case ConsoleKey.D4:
                        radioCD.Previous();
                        break;
                    case ConsoleKey.D5:
                        radioCD.Next();
                        break;
                    case ConsoleKey.D6:
                        radioCD.SwitchMode();
                        break;
                    case ConsoleKey.D7:
                        radioCD.InsertCD(thriller);
                        break;
                    case ConsoleKey.D8:
                        radioCD.ExtractCD();
                        break;
                    case ConsoleKey.Escape:
                        Console.WriteLine("Apagando...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }while (tecla.Key != ConsoleKey.Escape); 
    }
}