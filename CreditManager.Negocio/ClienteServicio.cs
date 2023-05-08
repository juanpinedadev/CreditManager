using CreditManager.Datos.Repositorio;
using CreditManager.Entidad;
using System.Collections.Generic;

namespace CreditManager.Negocio
{
    /// <summary>
    /// Clase que implementa la lógica de negocio para los clientes.
    /// </summary>
    public class ClienteServicio
    {
        private readonly ClienteRepositorio clienteRepositorio = new ClienteRepositorio();

        /// <summary>
        /// Crea un nuevo cliente.
        /// </summary>
        /// <param name="cliente">El cliente a crear.</param>
        /// <param name="mensaje">Un mensaje de salida que indica el resultado de la operación.</param>
        /// <returns>El ID del cliente creado.</returns>
        public int Crear(Cliente cliente, out string mensaje)
        {
            mensaje = string.Empty;

            if (cliente == null)
            {
                mensaje = "El cliente no puede ser nulo";
                return 0;
            }

            if (string.IsNullOrEmpty(cliente.PrimerNombre))
            {
                mensaje = "El primer nombre del cliente no puede ser nulo o vacío";
                return 0;
            }

            if (string.IsNullOrEmpty(cliente.PrimerApellido))
            {
                mensaje = "El primer apellido del cliente no puede ser nulo o vacío";
                return 0;
            }

            if (string.IsNullOrEmpty(cliente.NumeroDocumento))
            {
                mensaje = "El número de documento del cliente no puede ser nulo o vacío";
                return 0;
            }

            if (cliente.TipoDocumento.IdTipoDocumento <= 0)
            {
                mensaje = "Por favor seleccione un tipo de documento válido.";
                return 0;
            }

            if (string.IsNullOrEmpty(cliente.NumeroCelular))
            {
                mensaje = "El número de celular del cliente no puede ser nulo o vacío";
                return 0;
            }

            if (string.IsNullOrEmpty(cliente.Direccion))
            {
                mensaje = "La dirección del cliente no puede ser nula o vacía";
                return 0;
            }

            if (string.IsNullOrEmpty(cliente.CorreoElectronico))
            {
                mensaje = "El correo electrónico del cliente no puede ser nulo o vacío";
                return 0;
            }

            if (!ValidarCorreoElectronico(cliente.CorreoElectronico))
            {
                mensaje = "El correo electrónico ingresado no es valido";
                return 0;
            }

            if (mensaje != string.Empty) { return 0; }

            else
            {
                return clienteRepositorio.Crear(cliente, out mensaje);
            }
        }

        /// <summary>
        /// Actualiza un cliente existente.
        /// </summary>
        /// <param name="cliente">El cliente a actualizar.</param>
        /// <param name="mensaje">Un mensaje de salida que indica el resultado de la operación.</param>
        /// <returns>True si la actualización fue exitosa, false si no lo fue.</returns>
        public bool Actualizar(Cliente cliente, out string mensaje)
        {
            mensaje = string.Empty;

            if (cliente == null)
            {
                mensaje = "El cliente no puede ser nulo";
                return false;
            }

            if (string.IsNullOrEmpty(cliente.PrimerNombre))
            {
                mensaje = "El primer nombre del cliente no puede ser nulo o vacío";
                return false;
            }

            if (string.IsNullOrEmpty(cliente.PrimerApellido))
            {
                mensaje = "El primer apellido del cliente no puede ser nulo o vacío";
                return false;
            }

            if (string.IsNullOrEmpty(cliente.NumeroDocumento))
            {
                mensaje = "El número de documento del cliente no puede ser nulo o vacío";
                return false;
            }

            if (string.IsNullOrEmpty(cliente.TipoDocumento.Tipo))
            {
                mensaje = "El tipo de documento del cliente no puede ser nulo o vacío";
                return false;
            }

            if (string.IsNullOrEmpty(cliente.NumeroTelefono))
            {
                mensaje = "El número de teléfono del cliente no puede ser nulo o vacío";
                return false;
            }

            if (string.IsNullOrEmpty(cliente.Direccion))
            {
                mensaje = "La dirección del cliente no puede ser nula o vacía";
                return false;
            }

            if (string.IsNullOrEmpty(cliente.NumeroCelular))
            {
                mensaje = "El número de celular del cliente no puede ser nulo o vacío";
                return false;
            }

            if (string.IsNullOrEmpty(cliente.CorreoElectronico))
            {
                mensaje = "El correo electrónico del cliente no puede ser nulo o vacío";
                return false;
            }

            if (cliente.IdCliente <= 0)
            {
                mensaje = "El ID del cliente debe ser mayor que cero";
                return false;
            }

            if (mensaje != string.Empty) { return false; }

            else
            {
                return clienteRepositorio.Actualizar(cliente, out mensaje);
            }
        }

        /// <summary>
        /// Elimina un cliente existente.
        /// </summary>
        /// <param name="cliente">El cliente a eliminar.</param>
        /// <param name="mensaje">Un mensaje de salida que indica el resultado de la operación.</param>
        /// <returns>True si la eliminación fue exitosa, false si no lo fue.</returns>
        public bool Eliminar(Cliente cliente, out string mensaje)
        {
            mensaje = string.Empty;

            if (cliente == null)
            {
                mensaje = "El cliente no puede ser nulo";
                return false;
            }

            if (cliente.IdCliente <= 0)
            {
                mensaje = "El ID del cliente debe ser mayor que cero";
                return false;
            }

            if (mensaje != string.Empty) { return false; }

            else
            {
                return clienteRepositorio.Eliminar(cliente, out mensaje);
            }
        }

        /// <summary>
        /// Obtiene una lista de todos los clientes.
        /// </summary>
        /// <returns>Una lista de objetos Cliente.</returns>
        public List<Cliente> ListarClientes()
        {
            return clienteRepositorio.Listar();
        }

        /// <summary>
        /// Valida un correo electrónico.
        /// </summary>
        /// <param name="correo">El correo electrónico a validar.</param>
        /// <returns>True si el correo electrónico es válido, false si no lo es.</returns>
        public bool ValidarCorreoElectronico(string correo)
        {
            return clienteRepositorio.ValidarCorreoElectronico(correo);
        }
    }
}
