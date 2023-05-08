using CreditManager.Entidad;
using System.Collections.Generic;

namespace CreditManager.Datos.Interface
{
    /// <summary>
    /// Interfaz que define las operaciones que se pueden realizar con el repositorio de tipos de documento.
    /// </summary>
    public interface ITipoDocumentoRepositorio
    {
        /// <summary>
        /// Obtiene una lista de los tipos de documento disponibles.
        /// </summary>
        /// <returns>Una lista de objetos de tipo TipoDocumento.</returns>
        List<TipoDocumento> Listar();
    }
}
