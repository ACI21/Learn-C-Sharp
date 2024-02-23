namespace Ejercicios_Examen;

class OrientadorMotivador : Orientador
{
    public OrientadorMotivador(string nombre) : base(nombre) 
    {
    }

    public override string GetOrientacion(Estudiante estudiante)
    {
        string orientacion = "";

        if (estudiante is EstudianteAltasCapacidades)
        {
            orientacion = "Explorar proyectos más desafiantes.";
        }
        else if (estudiante is EstudianteApoyoIdioma)
        {
            orientacion = "Sumergirte en prácticas diarias para mejorar tus habilidades lingüísticas.";
        }
        else if (estudiante is EstudianteDisruptivo)
        {
            orientacion = "Transformar tus deasfios en oportunidades de crecimiento personal.";
        }
        else if (estudiante is EstudianteNecesidadesEducativasEspeciales)
        {
            orientacion = "Superar cualquier obstáculo educativo que encuentres.";
        }
        else
        {
            throw new EscuelaException("Tipo de estudiante no válido");
        }

        return orientacion;
    }

    protected override String GetPregunta()
    {
        string pregunta = "Cuéntame, ¿qué te motiva a seguir aprendiendo?";
        return pregunta;
    }

    protected override String GetReplica()
    {
        string respuesta = $"Entiendo, es genial que tengas esa motivación.";
        return respuesta;
    }
}