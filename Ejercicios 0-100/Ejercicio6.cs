namespace Ejercicios_0_100;

public class Ejercicio6
{
    public static void main(){
        int altura = 0;

        Console.WriteLine("Introduce altura del triangulo: ");
        altura = int.Parse(Console.ReadLine()??"0");

        /*
        *****
         ****
          ***
           **
            *
        */
        for (int i = 0; i < altura; i++)
        {
            for (int j = 0; j < altura; j++)
            {
                if(i <= j){
                    Console.Write("*");
                }else{
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }

        /*
            *    
            **   
            ***  
            **** 
            *****
        */
        for (int i = 0; i < altura; i++)
        {
            for (int j = 0; j < altura; j++)
            {
                if(i >= j){
                    Console.Write("*");
                }else{
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}
