class EstudianteDisruptivo : Estudiante
{
    public EstudianteDisruptivo(string nombre) : base(nombre)
    {
    }

    public override string Responde()
    {
        string respuesta4 = "Estoy trabajando en mejorar mi conversacion en clase ";
        return respuesta4;
    }
}