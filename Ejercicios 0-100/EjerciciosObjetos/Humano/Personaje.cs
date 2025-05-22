using System.ComponentModel.DataAnnotations.Schema;

namespace Ejercicios_0_100;

public class Personaje
{
    // Bloque atributos
    private string nombre;
    public int Edad { get; set; }
    public string Raza { get; set; }

    // Bloque métodos
    public void Saludar()
    {
        Console.WriteLine($"Hola, soy {nombre} y tengo {Edad} años.");
    }

    public virtual void Atacar()
    {
        Console.WriteLine($"Atacando a los enemigos.");
    }

    public Personaje(string nombre, int edad, string raza)
    {
        this.nombre = nombre;
        Edad = edad;
        Raza = raza;
    }

    public string getNombre()
    {
        return nombre;
    }

    public void setNombre(string nombre)
    {
        if (nombre == null)
        {
            Console.WriteLine("El nombre no puede ser nulo.");
        }
        else if (nombre.Equals("Swiper"))
        {
            Console.WriteLine("El nombre no puede ser del equipo de los malos.");
        }
        else
        {
            this.nombre = nombre;
        }
    }

    public bool Equals(Personaje obj)
    {   
        if (obj.Raza.Equals(Raza) && obj.Edad.Equals(Edad))   
        {
            return true;
        }
    
        return base.Equals (obj);
    }
}