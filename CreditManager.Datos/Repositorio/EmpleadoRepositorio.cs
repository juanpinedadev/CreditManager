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
    public class EmpleadoRepositorio : IEmpleadoRepositorio
    {
        /// <summary>
        /// Actualiza un empleado en la base de datos.
        /// </summary>
        /// <param name="empleado">El empleado que se va a actualizar.</param>
        /// <param name="mensaje">El mensaje que devuelve el procedimiento almacenado.</param>
        /// <returns>True si la operación se realizó con éxito, false en caso contrario.</returns>
        public bool Actualizar(Empleado empleado, out string mensaje)
        {
            mensaje = string.Empty;
            bool resultado = false;

            using (SqlConnection connection = new SqlConnection(ConexionMaestra.CadenaConexion))
            {
                try
                {
                    SqlCommand command = new SqlCommand("ActualizarEmpleado", connection);

                    command.Parameters.AddWithValue("@IdEmpleado", empleado.IdEmpleado);
                    command.Parameters.AddWithValue("@NumeroDocumento", empleado.InformacionPersonal.NumeroDocumento);
                    command.Parameters.AddWithValue("@IdTipoDocumento", empleado.InformacionPersonal.TipoDocumento.IdTipoDocumento);
                    command.Parameters.AddWithValue("@PrimerNombre", empleado.InformacionPersonal.PrimerNombre);
                    command.Parameters.AddWithValue("@SegundoNombre", empleado.InformacionPersonal.SegundoNombre);
                    command.Parameters.AddWithValue("@PrimerApellido", empleado.InformacionPersonal.PrimerApellido);
                    command.Parameters.AddWithValue("@SegundoApellido", empleado.InformacionPersonal.SegundoApellido);
                    command.Parameters.AddWithValue("@NumeroTelefono", empleado.InformacionContacto.NumeroTelefono);
                    command.Parameters.AddWithValue("@NumeroCelular", empleado.InformacionContacto.NumeroCelular);
                    command.Parameters.AddWithValue("@Direccion", empleado.InformacionContacto.Direccion);
                    command.Parameters.AddWithValue("@CorreoElectronico", empleado.InformacionContacto.CorreoElectronico);
                    command.Parameters.AddWithValue("@FechaRegistro", empleado.FechaRegistro);
                    command.Parameters.AddWithValue("@Estado", empleado.Estado);
                    command.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
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
        /// Crea un nuevo empleado.
        /// </summary>
        /// <param name="empleado">El empleado a crear.</param>
        /// <param name="mensaje">Un mensaje de salida que indica el resultado de la operación.</param>
        /// <returns>El ID del empleado creado.</returns>
        public int Crear(Empleado empleado, out string mensaje)
        {
            mensaje = string.Empty;
            int resultado = 0;

            using (SqlConnection connection = new SqlConnection(ConexionMaestra.CadenaConexion))
            {
                try
                {
                    SqlCommand command = new SqlCommand("CrearEmpleado", connection);

                    command.Parameters.AddWithValue("@NumeroDocumento", empleado.InformacionPersonal.NumeroDocumento);
                    command.Parameters.AddWithValue("@IdTipoDocumento", empleado.InformacionPersonal.TipoDocumento.IdTipoDocumento);
                    command.Parameters.AddWithValue("@PrimerNombre", empleado.InformacionPersonal.PrimerNombre);
                    command.Parameters.AddWithValue("@SegundoNombre", empleado.InformacionPersonal.SegundoNombre);
                    command.Parameters.AddWithValue("@PrimerApellido", empleado.InformacionPersonal.PrimerApellido);
                    command.Parameters.AddWithValue("@SegundoApellido", empleado.InformacionPersonal.SegundoApellido);
                    command.Parameters.AddWithValue("@NumeroTelefono", empleado.InformacionContacto.NumeroTelefono);
                    command.Parameters.AddWithValue("@NumeroCelular", empleado.InformacionContacto.NumeroCelular);
                    command.Parameters.AddWithValue("@Direccion", empleado.InformacionContacto.Direccion);
                    command.Parameters.AddWithValue("@CorreoElectronico", empleado.InformacionContacto.CorreoElectronico);
                    command.Parameters.AddWithValue("@FechaRegistro", empleado.FechaRegistro);
                    command.Parameters.AddWithValue("@Estado", empleado.Estado);
                    command.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
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
        /// Elimina un empleado existente.
        /// </summary>
        /// <param name="empleado">El empleado a eliminar.</param>
        /// <param name="mensaje">Un mensaje de salida que indica el resultado de la operación.</param>
        /// <returns>True si la eliminación fue exitosa, false si no lo fue.</returns>
        public bool Eliminar(Empleado empleado, out string mensaje)
        {
            mensaje = string.Empty;
            bool resultado = false;

            using (SqlConnection connection = new SqlConnection(ConexionMaestra.CadenaConexion))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM empleados WHERE IdEmpleado = @IdEmpleado;", connection);
                    cmd.Parameters.AddWithValue("@IdEmpleado", empleado.IdEmpleado);
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
        /// Obtiene una lista de todos los empleados.
        /// </summary>
        /// <returns>Una lista de objetos Empleado.</returns>
        public List<Empleado> Listar()
        {
            List<Empleado> empleados = new List<Empleado>();

            using (SqlConnection connection = new SqlConnection(ConexionMaestra.CadenaConexion))
            {
                try
                {
                    StringBuilder consulta = new StringBuilder();
                    consulta.Append("SELECT e.IdCliente, e.PrimerNombre, e.SegundoNombre, ");
                    consulta.Append("e.PrimerApellido, e.SegundoApellido, e.NumeroDocumento, td.IdTipoDocumento,");
                    consulta.Append("td.Tipo AS TipoDocumento, e.NumeroTelefono, e.Direccion, ");
                    consulta.Append("e.NumeroCelular, e.CorreoElectronico, e.FechaRegistro, e.Estado ");
                    consulta.Append("FROM Clientes e ");
                    consulta.Append("INNER JOIN TiposDocumento td ON e.IdTipoDocumento = td.IdTipoDocumento;");

                    SqlCommand command = new SqlCommand(consulta.ToString(), connection)
                    {
                        CommandType = CommandType.Text
                    };

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var informacionPersonal = new InformacionPersonal()
                            {
                                PrimerNombre = reader["PrimerNombre"].ToString(),
                                SegundoNombre = reader["SegundoNombre"].ToString(),
                                PrimerApellido = reader["PrimerApellido"].ToString(),
                                SegundoApellido = reader["SegundoApellido"].ToString(),
                                NumeroDocumento = reader["NumeroDocumento"].ToString(),
                                TipoDocumento = new TipoDocumento()
                                {
                                    IdTipoDocumento = Convert.ToInt32(reader["IdTipoDocumento"]),
                                    Tipo = reader["TipoDocumento"].ToString()
                                }
                            };

                            var informacionContacto = new InformacionContacto()
                            {
                                NumeroTelefono = reader["NumeroTelefono"].ToString(),
                                Direccion = reader["Direccion"].ToString(),
                                NumeroCelular = reader["NumeroCelular"].ToString(),
                                CorreoElectronico = reader["CorreoElectronico"].ToString()
                            };

                            var empleado = new Empleado()
                            {
                                IdEmpleado = Convert.ToInt32(reader["IdEmpleado"]),
                                InformacionPersonal = informacionPersonal,
                                InformacionContacto = informacionContacto,
                                FechaRegistro = Convert.ToDateTime(reader["FechaRegistro"]),
                                Estado = Convert.ToBoolean(reader["Estado"])
                            };

                            empleados.Add(empleado);
                        }
                    }
                }
                catch (Exception ex)
                {
                    empleados = new List<Empleado>();
                    connection.Close();
                    throw ex;
                }
            }

            return empleados;
        }

        /// <summary>
        /// Valida un correo electrónico.
        /// </summary>
        /// <param name="correo">El correo electrónico a validar.</param>
        /// <returns>True si el correo electrónico es válido, false si no lo es.</returns>
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
