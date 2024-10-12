using System.Configuration;

namespace CapaDato
{
    public class Conexion
    {

        public static string cadena = ConfigurationManager.ConnectionStrings["cadena_conexion"].ToString();
    }

}
