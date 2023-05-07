using System.Collections.Generic;

namespace CreditManager.Datos.Interface
{
    /// <summary>
    /// Interfaz genérica que define las operaciones básicas para acceder a los datos de una entidad.
    /// </summary>
    /// <typeparam name="T">El tipo de entidad para la que se define el repositorio.</typeparam>
    public interface IRepositorioGenerico<T> where T : class
    {
        /// <summary>
        /// Crea una nueva entidad en el repositorio.
        /// </summary>
        /// <param name="entidad">La entidad que se desea crear.</param>
        /// <param name="mensaje">Un mensaje de texto con información adicional acerca del resultado de la operación.</param>
        /// <returns>El número de filas afectadas en el repositorio como resultado de la operación.</returns>
        int Crear(T entidad, out string mensaje);

        /// <summary>
        /// Actualiza una entidad existente en el repositorio.
        /// </summary>
        /// <param name="entidad">La entidad que se desea actualizar.</param>
        /// <param name="mensaje">Un mensaje de texto con información adicional acerca del resultado de la operación.</param>
        /// <returns>Verdadero si la operación se completó con éxito, de lo contrario falso.</returns>
        bool Actualizar(T entidad, out string mensaje);

        /// <summary>
        /// Elimina una entidad existente en el repositorio.
        /// </summary>
        /// <param name="entidad">La entidad que se desea eliminar.</param>
        /// <param name="mensaje">Un mensaje de texto con información adicional acerca del resultado de la operación.</param>
        /// <returns>Verdadero si la operación se completó con éxito, de lo contrario falso.</returns>
        bool Eliminar(T entidad, out string mensaje);

        /// <summary>
        /// Lista todas las entidades del repositorio.
        /// </summary>
        /// <returns>Una lista de todas las entidades del repositorio.</returns>
        List<T> Listar();
    }
}
