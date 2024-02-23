namespace Ejercicios_Examen;
class Program 
{
    public static void main()
    {
        Escuela cole = new Escuela();

        Orientador profe1 = new OrientadorDesalentador("Juan");
        cole.Contrata(profe1);
        Orientador profe2 = new OrientadorMotivador("Guillermo");
        cole.Contrata(profe2);
        Orientador profe3 = new OrientadorDesalentador("Arnold");
        cole.Contrata(profe3);
        Orientador profe4 = new OrientadorMotivador("Jose");
        cole.Contrata(profe4);
        Orientador profe5 = new OrientadorDesalentador("Donald");
        cole.Contrata(profe5);
        Orientador profe6 = new OrientadorMotivador("Donald");
        cole.Contrata(profe6);

        Estudiante alumno1 = new EstudianteAltasCapacidades("Alumno1");
        Estudiante alumno2 = new EstudianteApoyoIdioma("Alumno2");
        Estudiante alumno3 = new EstudianteDisruptivo("Alumno3");
        Estudiante alumno4 = new EstudianteNecesidadesEducativasEspeciales("Alumno4");
        cole.Matricula(alumno1);
        cole.Matricula(alumno2);
        cole.Matricula(alumno3);
        cole.Matricula(alumno4);

        Estudiante alumno5 = new EstudianteAltasCapacidades("Alumno5");
        Estudiante alumno6 = new EstudianteApoyoIdioma("Alumno6");
        Estudiante alumno7 = new EstudianteDisruptivo("Alumno7");
        Estudiante alumno8 = new EstudianteNecesidadesEducativasEspeciales("Alumno8");
        cole.Matricula(alumno5);
        cole.Matricula(alumno6);
        cole.Matricula(alumno7);
        cole.Matricula(alumno8);

        Estudiante alumno9 = new EstudianteAltasCapacidades("Alumno9");
        Estudiante alumno10 = new EstudianteApoyoIdioma("Alumno10");
        Estudiante alumno11 = new EstudianteDisruptivo("Alumno11");
        Estudiante alumno12 = new EstudianteNecesidadesEducativasEspeciales("Alumno12");
        cole.Matricula(alumno9);
        cole.Matricula(alumno10);
        cole.Matricula(alumno11);
        cole.Matricula(alumno12);

        cole.OrientarEstudiantes();
    }
}