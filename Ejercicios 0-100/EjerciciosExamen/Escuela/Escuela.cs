namespace Ejercicios_Examen;
class Escuela
{
    List<Estudiante> estudiantes;
    List<Orientador> orientadores;

    public Escuela()
    {
        this.estudiantes = new List<Estudiante>();
        this.orientadores = new List<Orientador>();
    }

    public Escuela Contrata(Orientador orientador)
    {
        if (orientador == null)
        {
            throw new EscuelaException("El orientador no puede ser nulo.");
        }

        this.orientadores.Add(orientador);
        return this;
    }

    public Escuela Matricula(Estudiante estudiante)
    {
        if (estudiante == null)
        {
            throw new EscuelaException("El estudiante no puede ser nulo.");
        }

        this.estudiantes.Add(estudiante);
        return this;
    }

    private Orientador ObtenerOrientadorAleatorio()
    {
        if (orientadores.Count == 0)
        {
            throw new EscuelaException("No hay orientadores disponibles. Contrata orientadores antes de orientar estudiantes.");
        }
        else
        {
            var orientadorSeleccionado = orientadores[new Random().Next(orientadores.Count)];
            return orientadorSeleccionado;
        }
    }

    public void OrientarEstudiantes()
    {
        for (int i = 0; i < estudiantes.Count; i++)
        {
            var orientadorRandom = ObtenerOrientadorAleatorio();
            orientadorRandom.Orienta(estudiantes[i]);
        }
    }
}