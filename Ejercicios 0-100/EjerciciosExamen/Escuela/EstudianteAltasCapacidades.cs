class EstudianteAltasCapacidades :Estudiante
{
    public EstudianteAltasCapacidades( string nombre):base(nombre)
    {
    }

    public override string  Responde ()
    {
        string respuesta1="Estoy participando activamente en actividades avanzadas";
        return respuesta1;   
    }
}