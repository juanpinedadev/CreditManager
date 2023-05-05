using System.Configuration;

namespace CreditManager.Datos.Conexion
{
    public class ConexionMaestra
    {
        public static string CadenaConexion = ConfigurationManager.ConnectionStrings["CadenaConexion"].ToString();
    }
}
