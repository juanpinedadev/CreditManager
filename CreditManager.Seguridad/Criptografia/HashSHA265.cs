using System.Security.Cryptography;
using System.Text;

namespace CreditManager.Seguridad
{
    /// <summary>
    /// Clase que proporciona un método para generar el hash SHA256 de una cadena de texto.
    /// </summary>
    public class HashSHA265
    {
        /// <summary>
        /// Obtiene el hash SHA-256 de una cadena de texto.
        /// </summary>
        /// <param name="str">La cadena de texto a la que se le aplicará el hash.</param>
        /// <returns>El hash SHA-256 de la cadena de texto.</returns>
        public static string GetSHA256(string str)
        {
            // Crea una instancia del algoritmo SHA-256
            SHA256 sha256 = SHA256Managed.Create();

            // Codifica la cadena de texto como bytes ASCII
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;

            // Calcula el hash de los bytes de la cadena de texto
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(str));

            // Convierte los bytes del hash en una cadena hexadecimal
            for (int i = 0; i < stream.Length; i++)
                sb.AppendFormat("{0:x2}", stream[i]);

            // Retorna el hash en formato hexadecimal
            return sb.ToString();
        }
    }
}
