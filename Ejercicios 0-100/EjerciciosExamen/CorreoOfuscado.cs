namespace Ejercicios_Examen;

using System.Text;

public class CorreoOfuscado
{
    public static void main()
    {
        string[] correos = {"alumno@alu.edu.gva.es",
        "profesor@edu.gva.es", "novalidochange.org",
        "direccion@change.org", "ben.allman@openai.com",
        "decano@edu.ua.info", "novalidochange@org",
        "coseller@gva.es" };

        string[] correosOfuscados = OfuscaCorreos(correos);
        Console.WriteLine($"Correos ofuscados:\n\t{string.Join("\n\t"
        , correosOfuscados)}");
    }

    private static string[] OfuscaCorreos(string[] correos)
    {

        for (int i = 0; i < correos.Length; i++)
        {
            StringBuilder correoOfuscadoDef = new StringBuilder();
            string correo = correos[i], usuario = "", dominio = "", resto = "";
            bool validacion = ObtenerPartesCorreo(correo, out usuario, out dominio, out resto);
            if (validacion)
            {
                Console.WriteLine("Ofuscando ...");
                Console.WriteLine("Correo: {0}", correos[i]);
                Console.WriteLine("Usuario: {0}", usuario);
                Console.WriteLine("Dominio: {0}", dominio);
                Console.WriteLine("Resto dominio: {0}", resto);
                correoOfuscadoDef.Append(usuario);
                correoOfuscadoDef.Append("[AT]");
                correoOfuscadoDef.Append(dominio); 
                correoOfuscadoDef.Append("[DOT]");                              
                correoOfuscadoDef.Append(resto);
                correos[i] = correoOfuscadoDef.ToString();
            }else{
                correoOfuscadoDef.Append("Correo "+correos[i].ToString()+" no válido");
                correos[i] = correoOfuscadoDef.ToString();
            }
        }
        return correos;
    }

    private static bool ObtenerPartesCorreo(string correo, out string usuario, out string dominio, out string resto)
    {
        if (correo.Contains('@') && correo.Contains('.'))
        {
            string[] superUsuario = correo.Split('@');
            usuario = superUsuario[0];
            string[] superDominio = superUsuario[1].Split('.');
            dominio = superDominio[0];
            for (int i = 1; i < superDominio.Length - 1; i++)
            {
                dominio += "." + superDominio[i];
            }
            resto = superDominio[superDominio.Length - 1];
            return true;
        }else{
            usuario = "";
            dominio = "";
            resto = "";
            return false;
        }

    }
}
