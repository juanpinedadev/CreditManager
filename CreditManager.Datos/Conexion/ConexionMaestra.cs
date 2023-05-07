using System.Configuration;

namespace CreditManager.Datos.Conexion
{
    /// <summary>
    /// Clase que contiene la cadena de conexión a la base de datos maestra.
    /// </summary>
    public class ConexionMaestra
    {
        /// <summary>
        /// Cadena de conexión a la base de datos maestra.
        /// </summary>
        /// <remarks>
        /// Esta cadena de conexión es necesaria para establecer una conexión con la base de datos maestra.
        /// </remarks>
        public static string CadenaConexion = ConfigurationManager.ConnectionStrings["CadenaConexion"].ToString();
    }
}
