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
    public class PrestamoRepositorio : IPrestamoRepositorio
    {
        public bool Actualizar(Prestamo prestamo, out string mensaje)
        {
            mensaje = string.Empty;
            bool resultado = false;

            using (SqlConnection connection = new SqlConnection(ConexionMaestra.CadenaConexion))
            {
                try
                {
                    SqlCommand command = new SqlCommand("ActualizarPrestamo", connection);
                    command.Parameters.AddWithValue("@IdPrestamo", prestamo.IdPrestamo);
                    command.Parameters.AddWithValue("@IdCliente", prestamo.Solicitante.IdCliente);
                    command.Parameters.AddWithValue("@MontoSolicitado", prestamo.MontoSolicitado);
                    command.Parameters.AddWithValue("@MontoTotalAPagar", prestamo.MontoTotalAPagar);
                    command.Parameters.AddWithValue("@NumeroCuotas", prestamo.NumeroCuotas);
                    command.Parameters.AddWithValue("@TasaInteres", prestamo.TasaInteres);
                    command.Parameters.AddWithValue("@Pagado", prestamo.Pagado);

                    command.Parameters.AddWithValue("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    command.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    command.CommandType = CommandType.StoredProcedure;
                    
                    connection.Open();
                    command.ExecuteNonQuery();

                    resultado = Convert.ToBoolean(command.Parameters["Respuesta"].Value);
                    mensaje = command.Parameters["Mensaje"].Value.ToString();
                }
                catch (Exception excepcion)
                {
                    connection.Close();
                    resultado = false;
                    mensaje = excepcion.Message;
                }
            }

            return resultado;
        }

        public int Crear(Prestamo prestamo, out string mensaje)
        {
            mensaje = string.Empty;
            int resultado = 0;

            using (SqlConnection connection = new SqlConnection(ConexionMaestra.CadenaConexion))
            {
                try
                {
                    SqlCommand command = new SqlCommand("CrearPrestamo", connection);

                    command.Parameters.AddWithValue("@IdCliente", prestamo.Solicitante.IdCliente);
                    command.Parameters.AddWithValue("@MontoSolicitado", prestamo.MontoSolicitado);
                    command.Parameters.AddWithValue("@MontoTotalAPagar", prestamo.MontoTotalAPagar);
                    command.Parameters.AddWithValue("@NumeroCuotas", prestamo.NumeroCuotas);
                    command.Parameters.AddWithValue("@TasaInteres", prestamo.TasaInteres);
                    command.Parameters.AddWithValue("@Pagado", prestamo.Pagado);

                    command.Parameters.AddWithValue("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    command.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    command.ExecuteNonQuery();

                    resultado = Convert.ToInt32(command.Parameters["Resultado"].Value);
                    mensaje = command.Parameters["Mensaje"].Value.ToString();
                }
                catch (Exception excepcion)
                {
                    resultado = 0;
                    mensaje = excepcion.Message;
                }
            }

            return resultado;
        }

        public bool Eliminar(Prestamo prestamo, out string mensaje)
        {
            mensaje = string.Empty;
            bool resultado = false;

            using (SqlConnection connection = new SqlConnection(ConexionMaestra.CadenaConexion))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM prestamos WHERE IdPrestamo = @IdPrestamo;", connection);
                    cmd.Parameters.AddWithValue("@IdPrestamo", prestamo.IdPrestamo);
                    cmd.CommandType = CommandType.Text;
                    connection.Open();
                    resultado = cmd.ExecuteNonQuery() > 0 ? true : false;
                }
                catch (Exception excepcion)
                {
                    resultado = false;
                    mensaje = excepcion.Message;
                }
            }

            return resultado;
        }

        public List<Prestamo> Listar()
        {
            List<Prestamo> prestamo = new List<Prestamo>();

            using (SqlConnection connection = new SqlConnection(ConexionMaestra.CadenaConexion))
            {
                try
                {
                    StringBuilder consulta = new StringBuilder();
                    consulta.Append("SELECT c.IdCliente, c.PrimerNombre, c.SegundoNombre, ");
                    consulta.Append("c.PrimerApellido, c.SegundoApellido, c.NumeroDocumento, td.IdTipoDocumento,");
                    consulta.Append("td.Tipo AS TipoDocumento, c.NumeroTelefono, c.Direccion, ");
                    consulta.Append("c.NumeroCelular, c.CorreoElectronico, c.FechaRegistro, c.Estado ");
                    consulta.Append("FROM Clientes c ");
                    consulta.Append("INNER JOIN TiposDocumento td ON c.IdTipoDocumento = td.IdTipoDocumento;");

                    SqlCommand command = new SqlCommand(consulta.ToString(), connection)
                    {
                        CommandType = CommandType.Text
                    };

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            prestamo.Add(new Prestamo()
                            {
                                //IdPrestamo = Convert.ToInt32(reader["IdPrestamo"]),
                                //NumeroDocumento = reader["NumeroDocumento"].ToString(),
                                //TipoDocumento = new TipoDocumento()
                                //{
                                //    IdTipoDocumento = Convert.ToInt32(reader["IdTipoDocumento"]),
                                //    Tipo = reader["TipoDocumento"].ToString()
                                //},
                                //PrimerNombre = reader["PrimerNombre"].ToString(),
                                //SegundoNombre = reader["SegundoNombre"].ToString(),
                                //PrimerApellido = reader["PrimerApellido"].ToString(),
                                //SegundoApellido = reader["SegundoApellido"].ToString(),
                                //CorreoElectronico = reader["CorreoElectronico"].ToString(),
                                //NumeroTelefono = reader["NumeroTelefono"].ToString(),
                                //Direccion = reader["Direccion"].ToString(),
                                //NumeroCelular = reader["NumeroCelular"].ToString(),
                                //FechaRegistro = Convert.ToDateTime(reader["FechaRegistro"]),
                                //Estado = Convert.ToBoolean(reader["Estado"]),
                            });
                        }
                    }

                }
                catch (Exception ex)
                {
                    prestamo = new List<Prestamo>();
                    connection.Close();
                    throw ex;
                }
            }

            return prestamo;
        }
    }
}
