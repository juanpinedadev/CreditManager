using CreditManager.Datos.Repositorio;
using CreditManager.Entidad;
using System.Collections.Generic;

namespace CreditManager.Negocio
{
    public class ClienteServicio
    {
        private readonly ClienteRepositorio clienteRepositorio = new ClienteRepositorio();

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
                mensaje = "El tipo de documento del cliente no puede ser nulo o vacío";
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

        public List<Cliente> ListarClientes()
        {
            return clienteRepositorio.Listar();
        }

        public bool ValidarCorreoElectronico(string correo)
        {
            return clienteRepositorio.ValidarCorreoElectronico(correo);
        }
    }
}
