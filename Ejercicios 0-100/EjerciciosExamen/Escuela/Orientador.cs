abstract class Orientador
{
    private readonly string nombre;

    protected Orientador(string nombre)
    {
        this.nombre = nombre;
    }
    public string Getnombre()
    {
        return nombre;
    }
    public void Orienta(Estudiante estudiante)
    {
       Console.WriteLine($"Orientado a {estudiante.GetNombre()} por parte de {this.Getnombre()} ------");
       Console.WriteLine($"\n[{this.Getnombre()}]: Hola {estudiante.GetNombre()}, soy tu orientador/a {this.Getnombre()} ¿Cómo estás hoy?");
       Console.WriteLine($"[{this.Getnombre()}]: {this.GetPregunta()}");
       Console.WriteLine($"[{estudiante.GetNombre()}]: {estudiante.Responde()}");
       Console.WriteLine($"[{this.Getnombre()}]: {this.GetReplica()}");
       Console.WriteLine($"[{this.Getnombre()}]: Mi consejo para ti es {this.GetOrientacion(estudiante)}\n");
    }

    public abstract string GetOrientacion(Estudiante estudiante);
    protected abstract string GetPregunta();
    protected abstract string GetReplica();
}