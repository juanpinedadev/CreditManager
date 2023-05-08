using CreditManager.Datos.Conexion;
using CreditManager.Datos.Interface;
using CreditManager.Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CreditManager.Datos.Repositorio
{
    /// Clase que implementa la interfaz <see cref="ITipoDocumentoRepositorio"/> y proporciona acceso a los tipos de documento en una base de datos.
    /// </summary>
    public class TipoDocumentoRepositorio : ITipoDocumentoRepositorio
    {
        /// <summary>
        /// Obtiene una lista de los tipos de documento disponibles en la base de datos.
        /// </summary>
        /// <returns>Una lista de objetos de tipo TipoDocumento.</returns>
        public List<TipoDocumento> Listar()
        {
            List<TipoDocumento> tipoDocumentos = new List<TipoDocumento>();

            using (SqlConnection connection = new SqlConnection(ConexionMaestra.CadenaConexion))
            {
                try
                {
                    StringBuilder consulta = new StringBuilder();
                    consulta.Append("SELECT IdTipoDocumento, Tipo FROM TiposDocumento;");

                    SqlCommand command = new SqlCommand(consulta.ToString(), connection)
                    {
                        CommandType = CommandType.Text
                    };

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tipoDocumentos.Add(new TipoDocumento()
                            {
                                IdTipoDocumento = Convert.ToInt32(reader["IdTipoDocumento"]),
                                Tipo = reader["Tipo"].ToString(),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    tipoDocumentos = new List<TipoDocumento>();
                    connection.Close();
                    throw ex;
                }
            }

            return tipoDocumentos;
        }
    }
}
