using System;

class Estudiante
{
    private readonly string nombre;

    public Estudiante(string nombre){
        this.nombre=nombre;
    }
    public string GetNombre(){
        return nombre;
    }

    public virtual string Responde(){
        string respuesta = "Estoy estudiando";
        return respuesta; //Mejor respuesta
    }
}