class EstudianteNecesidadesEducativasEspeciales :Estudiante
{
    public  EstudianteNecesidadesEducativasEspeciales( string nombre):base(nombre)
    {
    }

    public override string  Responde ()
    {
        string respuesta2="Estoy trabajando con el apoyo de un educador especial";
        return respuesta2;
        
    }
}