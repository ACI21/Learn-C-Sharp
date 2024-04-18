namespace Ejercicios_BCL;

public class Ejercicio5
{
    static Dictionary<string, DatosContacto> agendaContactos = new Dictionary<string, DatosContacto>();

    public static Dictionary<string, DatosContacto> CreaContactos()
    {
        while (true)
        {
            Console.WriteLine("Introduce los datos del contacto (o presiona Enter en DNI para salir):");
            Console.Write("DNI: ");
            string dni = Console.ReadLine()??"";
            if (string.IsNullOrWhiteSpace(dni)) break;

            Console.Write("Nombre completo: ");
            string nombre = Console.ReadLine()??"";

            Console.Write("Dirección: ");
            string direccion = Console.ReadLine()??"";

            Console.Write("Teléfono: ");
            string telefono = Console.ReadLine()??"";

            DatosContacto contacto = new DatosContacto
            {
                DNI = dni,
                NombreCompleto = nombre,
                Direccion = direccion,
                Telefono = telefono
            };

            agendaContactos.Add(dni, contacto);
        }

        return agendaContactos;
    }

    public static void BorraContacto(string dni, Dictionary<string, DatosContacto> agenda)
    {
        if (agenda.ContainsKey(dni))
        {
            agenda.Remove(dni);
            Console.WriteLine("Contacto borrado exitosamente.");
        }
        else
        {
            Console.WriteLine("El contacto con ese DNI no existe en la agenda.");
        }
    }

    public static void AñadeContacto(DatosContacto contacto, Dictionary<string, DatosContacto> agenda)
    {
        agenda.Add(contacto.DNI??"", contacto);
    }

    public static void MuestraAgenda(Dictionary<string, DatosContacto> agenda)
    {
        Console.WriteLine("Agenda de contactos:");
        foreach (var kvp in agenda)
        {
            Console.WriteLine($"DNI: {kvp.Value.DNI}, Nombre: {kvp.Value.NombreCompleto}, Dirección: {kvp.Value.Direccion}, Teléfono: {kvp.Value.Telefono}");
        }
    }

    public static void main()
    {
        Console.WriteLine("Crea tu agenda de contactos:");
        Dictionary<string, DatosContacto> agenda = CreaContactos();

        Console.WriteLine("\n*** Agenda creada ***");
        MuestraAgenda(agenda);

        Console.WriteLine("\nBorrar un contacto. Introduce el DNI:");
        string dniBorrar = Console.ReadLine()??"";
        BorraContacto(dniBorrar, agenda);

        Console.WriteLine("\nAñadir un nuevo contacto:");
        DatosContacto nuevoContacto = new DatosContacto();
        Console.Write("DNI: ");
        nuevoContacto.DNI = Console.ReadLine();
        Console.Write("Nombre completo: ");
        nuevoContacto.NombreCompleto = Console.ReadLine();
        Console.Write("Dirección: ");
        nuevoContacto.Direccion = Console.ReadLine();
        Console.Write("Teléfono: ");
        nuevoContacto.Telefono = Console.ReadLine();

        AñadeContacto(nuevoContacto, agenda);

        Console.WriteLine("\n*** Agenda actualizada ***");
        MuestraAgenda(agenda);
    }
}
