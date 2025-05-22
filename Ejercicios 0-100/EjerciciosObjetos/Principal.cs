// Ejercicio: Creación y Manipulación de Objetos en C#
// Implementar un sistema básico de personajes para demostrar los conceptos de POO.
// El ejercicio debe:
// 1. Crear una clase Personaje con atributos (nombre, edad, raza) y métodos (saludar, atacar)
// 2. Implementar diferentes tipos de encapsulamiento:
//    - Atributos privados con getters/setters personalizados (nombre)
//    - Propiedades autoimplementadas (Edad, Raza)
// 3. Implementar validación en los setters (nombre no puede ser nulo ni "Swiper")
// 4. Sobrescribir el método Equals para comparar personajes por raza y edad
// 5. Demostrar la creación y manipulación de objetos en la clase Principal
using System.ComponentModel.DataAnnotations.Schema;

namespace Ejercicios_0_100;

public class Principal
{
    public static void Main(string[] args)
    {
        Personaje personaje1 = new Personaje("Dora", 1000, "Mago");
        personaje1.Saludar();
        personaje1.Atacar();

        string nombre = personaje1.getNombre(); // getter
        personaje1.setNombre("Swiper"); // setter

        Personaje personaje2 = new Personaje("Dora", 1000, "Mago");

        personaje1.Equals(personaje2); // true, son iguales
    }
}