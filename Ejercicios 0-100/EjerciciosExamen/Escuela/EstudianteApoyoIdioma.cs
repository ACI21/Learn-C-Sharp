class EstudianteApoyoIdioma :Estudiante 
{
    public EstudianteApoyoIdioma( string nombre):base(nombre)
    {
    }

    public override string  Responde ()
    {
        string respuesta3 = "Estoy mejorando mis habilidades con el idioma";
        return respuesta3;
    }
}