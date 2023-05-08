using CreditManager.Datos.Repositorio;
using CreditManager.Entidad;
using System.Collections.Generic;

namespace CreditManager.Negocio
{
    public class EmpleadoServicio
    {
        private readonly EmpleadoRepositorio empleadoRepositorio = new EmpleadoRepositorio();

        /// <summary>
        /// Actualiza un empleado en la base de datos.
        /// </summary>
        /// <param name="empleado">El empleado que se va a actualizar.</param>
        /// <param name="mensaje">El mensaje que devuelve el procedimiento almacenado.</param>
        /// <returns>True si la operación se realizó con éxito, false en caso contrario.</returns>
        public bool Actualizar(Empleado empleado, out string mensaje)
        {
            mensaje = string.Empty;

            if (empleado == null)
            {
                mensaje = "El empleado no puede ser nulo";
                return false;
            }

            if (string.IsNullOrEmpty(empleado.InformacionPersonal.PrimerNombre))
            {
                mensaje = "El primer nombre del empleado no puede ser nulo o vacío";
                return false;
            }

            if (string.IsNullOrEmpty(empleado.InformacionPersonal.PrimerApellido))
            {
                mensaje = "El primer apellido del empleado no puede ser nulo o vacío";
                return false;
            }

            if (string.IsNullOrEmpty(empleado.InformacionPersonal.NumeroDocumento))
            {
                mensaje = "El número de documento del empleado no puede ser nulo o vacío";
                return false;
            }

            if (string.IsNullOrEmpty(empleado.InformacionPersonal.TipoDocumento.Tipo))
            {
                mensaje = "El tipo de documento del empleado no puede ser nulo o vacío";
                return false;
            }

            if (string.IsNullOrEmpty(empleado.InformacionContacto.NumeroTelefono))
            {
                mensaje = "El número de teléfono del empleado no puede ser nulo o vacío";
                return false;
            }

            if (string.IsNullOrEmpty(empleado.InformacionContacto.Direccion))
            {
                mensaje = "La dirección del empleado no puede ser nula o vacía";
                return false;
            }

            if (string.IsNullOrEmpty(empleado.InformacionContacto.NumeroCelular))
            {
                mensaje = "El número de celular del empleado no puede ser nulo o vacío";
                return false;
            }

            if (string.IsNullOrEmpty(empleado.InformacionContacto.CorreoElectronico))
            {
                mensaje = "El correo electrónico del empleado no puede ser nulo o vacío";
                return false;
            }

            if (empleado.IdEmpleado <= 0)
            {
                mensaje = "El ID del empleado debe ser mayor que cero";
                return false;
            }

            if (mensaje != string.Empty) { return false; }

            else
            {
                return empleadoRepositorio.Actualizar(empleado, out mensaje);
            }
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

            if (empleado == null)
            {
                mensaje = "El empleado no puede ser nulo";
                return 0;
            }

            if (string.IsNullOrEmpty(empleado.InformacionPersonal.PrimerNombre))
            {
                mensaje = "El primer nombre del empleado no puede ser nulo o vacío";
                return 0;
            }

            if (string.IsNullOrEmpty(empleado.InformacionPersonal.PrimerApellido))
            {
                mensaje = "El primer apellido del empleado no puede ser nulo o vacío";
                return 0;
            }

            if (string.IsNullOrEmpty(empleado.InformacionPersonal.NumeroDocumento))
            {
                mensaje = "El número de documento del empleado no puede ser nulo o vacío";
                return 0;
            }

            if (empleado.InformacionPersonal.TipoDocumento.IdTipoDocumento <= 0)
            {
                mensaje = "Por favor seleccione un tipo de documento válido.";
                return 0;
            }

            if (string.IsNullOrEmpty(empleado.InformacionContacto.NumeroCelular))
            {
                mensaje = "El número de celular del empleado no puede ser nulo o vacío";
                return 0;
            }

            if (string.IsNullOrEmpty(empleado.InformacionContacto.Direccion))
            {
                mensaje = "La dirección del empleado no puede ser nula o vacía";
                return 0;
            }

            if (string.IsNullOrEmpty(empleado.InformacionContacto.CorreoElectronico))
            {
                mensaje = "El correo electrónico del empleado no puede ser nulo o vacío";
                return 0;
            }

            if (!ValidarCorreoElectronico(empleado.InformacionContacto.CorreoElectronico))
            {
                mensaje = "El correo electrónico ingresado no es valido";
                return 0;
            }

            if (mensaje != string.Empty) { return 0; }

            else
            {
                return empleadoRepositorio.Crear(empleado, out mensaje);
            }
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

            if (empleado == null)
            {
                mensaje = "El empleado no puede ser nulo";
                return false;
            }

            if (empleado.IdEmpleado <= 0)
            {
                mensaje = "El ID del empleado debe ser mayor que cero";
                return false;
            }

            if (mensaje != string.Empty) { return false; }

            else
            {
                return empleadoRepositorio.Eliminar(empleado, out mensaje);
            }
        }

        /// <summary>
        /// Obtiene una lista de todos los empleados.
        /// </summary>
        /// <returns>Una lista de objetos Empleado.</returns>
        public List<Empleado> Listar()
        {
            return empleadoRepositorio.Listar();
        }

        /// <summary>
        /// Valida un correo electrónico.
        /// </summary>
        /// <param name="correo">El correo electrónico a validar.</param>
        /// <returns>True si el correo electrónico es válido, false si no lo es.</returns>
        public bool ValidarCorreoElectronico(string correoElectronico)
        {
            return empleadoRepositorio.ValidarCorreoElectronico(correoElectronico);
        }
    }
}
