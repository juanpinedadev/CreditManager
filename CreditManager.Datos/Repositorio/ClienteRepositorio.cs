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
    public class ClienteRepositorio : IClienteRepositorio
    {
        /// <summary>
        /// Actualiza los datos de un cliente en la base de datos.
        /// </summary>
        /// <param name="cliente">Objeto Cliente con los datos del cliente a actualizar.</param>
        /// <param name="mensaje">Mensaje de respuesta de la operación.</param>
        /// <returns>True si la operación fue exitosa, de lo contrario false.</returns>
        public bool Actualizar(Cliente cliente, out string mensaje)
        {
            mensaje = string.Empty;
            bool resultado = false;

            using (SqlConnection connection = new SqlConnection(ConexionMaestra.CadenaConexion))
            {
                try
                {
                    SqlCommand command = new SqlCommand("ActualizarCliente", connection);
                    command.Parameters.AddWithValue("@IdCliente", cliente.IdCliente);
                    command.Parameters.AddWithValue("@NumeroDocumento", cliente.NumeroDocumento);
                    command.Parameters.AddWithValue("@IdTipoDocumento", cliente.TipoDocumento.IdTipoDocumento);
                    command.Parameters.AddWithValue("@PrimerNombre", cliente.PrimerNombre);
                    command.Parameters.AddWithValue("@SegundoNombre", cliente.SegundoNombre);
                    command.Parameters.AddWithValue("@PrimerApellido", cliente.PrimerApellido);
                    command.Parameters.AddWithValue("@SegundoApellido", cliente.SegundoApellido);
                    command.Parameters.AddWithValue("@NumeroTelefono", cliente.NumeroTelefono);
                    command.Parameters.AddWithValue("@NumeroCelular", cliente.NumeroCelular);
                    command.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                    command.Parameters.AddWithValue("@CorreoElectronico", cliente.CorreoElectronico);
                    command.Parameters.AddWithValue("@Estado", cliente.Estado);
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

        /// <summary>
        /// Crea un nuevo registro de cliente en la base de datos.
        /// </summary>
        /// <param name="cliente">Objeto Cliente con los datos del nuevo cliente.</param>
        /// <param name="mensaje">Mensaje de respuesta de la operación.</param>
        /// <returns>El Id del nuevo cliente si la operación fue exitosa, de lo contrario 0.</returns>
        public int Crear(Cliente cliente, out string mensaje)
        {
            mensaje = string.Empty;
            int resultado = 0;

            using (SqlConnection connection = new SqlConnection(ConexionMaestra.CadenaConexion))
            {
                try
                {
                    SqlCommand command = new SqlCommand("CrearCliente", connection);

                    command.Parameters.AddWithValue("@NumeroDocumento", cliente.NumeroDocumento);
                    command.Parameters.AddWithValue("@IdTipoDocumento", cliente.TipoDocumento.IdTipoDocumento);
                    command.Parameters.AddWithValue("@PrimerNombre", cliente.PrimerNombre);
                    command.Parameters.AddWithValue("@SegundoNombre", cliente.SegundoNombre);
                    command.Parameters.AddWithValue("@PrimerApellido", cliente.PrimerApellido);
                    command.Parameters.AddWithValue("@SegundoApellido", cliente.SegundoApellido);
                    command.Parameters.AddWithValue("@NumeroTelefono", cliente.NumeroTelefono);
                    command.Parameters.AddWithValue("@NumeroCelular", cliente.NumeroCelular);
                    command.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                    command.Parameters.AddWithValue("@CorreoElectronico", cliente.CorreoElectronico);
                    command.Parameters.AddWithValue("@Estado", cliente.Estado);
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

        /// <summary>
        /// Elimina un cliente existente de la base de datos.
        /// </summary>
        /// <param name="cliente">Objeto Cliente con los datos del cliente a eliminar.</param>
        /// <param name="mensaje">Mensaje de respuesta de la operación.</param>
        /// <returns>True si la operación fue exitosa, de lo contrario false.</returns>
        public bool Eliminar(Cliente cliente, out string mensaje)
        {
            mensaje = string.Empty;
            bool resultado = false;

            using (SqlConnection connection = new SqlConnection(ConexionMaestra.CadenaConexion))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM clientes WHERE IdCliente = @IdCliente;", connection);
                    cmd.Parameters.AddWithValue("@IdCliente", cliente.IdCliente);
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

        /// <summary>
        /// Obtiene una lista de todos los clientes almacenados en la base de datos.
        /// </summary>
        /// <returns>Una lista de objetos de tipo Cliente que contienen la información de cada cliente almacenado en la base de datos.</returns>
        /// <exception cref="System.Exception">Se produce cuando se produce un error al obtener los datos de la base de datos.</exception>
        public List<Cliente> Listar()
        {
            List<Cliente> clientes = new List<Cliente>();

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
                            clientes.Add(new Cliente()
                            {
                                IdCliente = Convert.ToInt32(reader["IdCliente"]),
                                NumeroDocumento = reader["NumeroDocumento"].ToString(),
                                TipoDocumento = new TipoDocumento()
                                {
                                    IdTipoDocumento = Convert.ToInt32(reader["IdTipoDocumento"]),
                                    Tipo = reader["TipoDocumento"].ToString()
                                },
                                PrimerNombre = reader["PrimerNombre"].ToString(),
                                SegundoNombre = reader["SegundoNombre"].ToString(),
                                PrimerApellido = reader["PrimerApellido"].ToString(),
                                SegundoApellido = reader["SegundoApellido"].ToString(),
                                CorreoElectronico = reader["CorreoElectronico"].ToString(),
                                NumeroTelefono = reader["NumeroTelefono"].ToString(),
                                Direccion = reader["Direccion"].ToString(),
                                NumeroCelular = reader["NumeroCelular"].ToString(),
                                FechaRegistro = Convert.ToDateTime(reader["FechaRegistro"]),
                                Estado = Convert.ToBoolean(reader["Estado"]),
                            });
                        }
                    }

                }
                catch (Exception ex)
                {
                    clientes = new List<Cliente>();
                    connection.Close();
                    throw ex;
                }
            }

            return clientes;
        }

        /// <summary>
        /// Valida si una dirección de correo electrónico es válida.
        /// </summary>
        /// <param name="correoElectronico">La dirección de correo electrónico a validar.</param>
        /// <returns>True si la dirección de correo electrónico es válida; de lo contrario, false.</returns>
        public bool ValidarCorreoElectronico(string correoElectronico)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(correoElectronico);
                return addr.Address == correoElectronico;
            }
            catch
            {
                return false;
            }
        }
    }
}
