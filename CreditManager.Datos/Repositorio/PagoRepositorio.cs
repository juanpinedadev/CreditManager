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
    public class PagoRepositorio : IPagoRepositorio
    {
        public bool Actualizar(Pago pago, out string mensaje)
        {
            mensaje = string.Empty;
            bool resultado = false;

            using (SqlConnection connection = new SqlConnection(ConexionMaestra.CadenaConexion))
            {
                try
                {
                    SqlCommand command = new SqlCommand("ActualizarPago", connection);
                    command.Parameters.AddWithValue("@Idpago", pago.IdPago);
                    command.Parameters.AddWithValue("@IdPrestamo", pago.Prestamo.IdPrestamo);
                    command.Parameters.AddWithValue("@MontoAbonado", pago.MontoAbonado);

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

        public int Crear(Pago pago, out string mensaje)
        {
            mensaje = string.Empty;
            int resultado = 0;

            using (SqlConnection connection = new SqlConnection(ConexionMaestra.CadenaConexion))
            {
                try
                {
                    SqlCommand command = new SqlCommand("CrearPago", connection);

                    command.Parameters.AddWithValue("@IdPrestamo", pago.Prestamo.IdPrestamo);
                    command.Parameters.AddWithValue("@IdPrestamo", pago.Prestamo.IdPrestamo);
                    command.Parameters.AddWithValue("@MontoAbonado", pago.MontoAbonado);

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

        public bool Eliminar(Pago pago, out string mensaje)
        {
            mensaje = string.Empty;
            bool resultado = false;

            using (SqlConnection connection = new SqlConnection(ConexionMaestra.CadenaConexion))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM pagos WHERE IdPago = @IdPago;", connection);
                    cmd.Parameters.AddWithValue("@IdPago", pago.IdPago);
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

        public List<Pago> Listar()
        {
            List<Pago> pagos = new List<Pago>();

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
                            Prestamo prestamo = new Prestamo()
                            {
                                IdPrestamo = Convert.ToInt32(reader["IdPrestamo"]),
                            };

                            Pago pago = new Pago()
                            {
                                IdPago = Convert.ToInt32(reader["IdPago"]),
                                MontoAbonado = Convert.ToDecimal(reader["MontoAbonado"].ToString()),
                                Prestamo = prestamo,
                                FechaPago = Convert.ToDateTime(reader["FechaPago"].ToString())
                            };

                            pagos.Add(pago);
                        }
                    }

                }
                catch (Exception ex)
                {
                    pagos = new List<Pago>();
                    connection.Close();
                    throw ex;
                }
            }

            return pagos;
        }
    }
}
