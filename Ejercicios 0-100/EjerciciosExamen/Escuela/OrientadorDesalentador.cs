namespace Ejercicios_Examen;

class OrientadorDesalentador : Orientador
{
    public OrientadorDesalentador(string nombre) : base(nombre) 
    { 
    }

    public override string GetOrientacion(Estudiante estudiante)
    {
        string orientacion = "";

        if (estudiante is EstudianteAltasCapacidades)
        {
            orientacion = "No te exijas demasiado, podrías agobiarte";
        }
        else if (estudiante is EstudianteApoyoIdioma)
        {
            orientacion = "No te esfuerces tanto en mejorar el idioma, quizás no lo necesitas tanto.";
        }
        else if (estudiante is EstudianteDisruptivo)
        {
            orientacion = "No te preocupes demasiado por tu comportamiento, es probable que no cambie mucho.";
        }
        else if (estudiante is EstudianteNecesidadesEducativasEspeciales)
        {
            orientacion = "Evitar retos académicos, podrían ser abrumadores.";
        }
        else
        {
            throw new EscuelaException("Tipo de estudiante no válido");
        }

        return orientacion;
    }

    protected override String GetPregunta()
    {
        string pregunta = "¿Hay algo que te esté preocupando en la escuela?";
        return pregunta;
    }

    protected override String GetReplica()
    {
        string respuesta = $"Entiendo, a veces las cosas pueden parecer dificiles.";
        return respuesta;
    }
}