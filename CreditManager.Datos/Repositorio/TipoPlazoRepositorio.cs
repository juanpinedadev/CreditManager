using CreditManager.Datos.Conexion;
using CreditManager.Datos.Interface;
using CreditManager.Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace CreditManager.Datos.Repositorio
{
    public class TipoPlazoRepositorio : ITipoPlazoRepositorio
    {
        /// <summary>
        /// Obtiene una lista de los tipos de plazo disponibles en la base de datos.
        /// </summary>
        /// <returns>Una lista de objetos de tipo TipoPlazo.</returns>
        public List<TipoPlazo> Listar()
        {
            List<TipoPlazo> tiposPlazo = new List<TipoPlazo>();

            using (SqlConnection connection = new SqlConnection(ConexionMaestra.CadenaConexion))
            {
                try
                {
                    StringBuilder consulta = new StringBuilder();
                    consulta.Append("SELECT IdTipoPlazo, Nombre FROM TiposPlazo;");

                    SqlCommand command = new SqlCommand(consulta.ToString(), connection)
                    {
                        CommandType = CommandType.Text
                    };

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tiposPlazo.Add(new TipoPlazo()
                            {
                                IdTipoPlazo = Convert.ToInt32(reader["IdTipoPlazo"]),
                                Nombre = reader["Nombre"].ToString(),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    tiposPlazo = new List<TipoPlazo>();
                    connection.Close();
                    throw ex;
                }
            }

            return tiposPlazo;
        }
    }   
}
