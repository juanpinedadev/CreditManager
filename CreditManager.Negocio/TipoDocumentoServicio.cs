using CreditManager.Datos.Repositorio;
using CreditManager.Entidad;
using System.Collections.Generic;

namespace CreditManager.Negocio
{
    /// <summary>
    /// Clase que proporciona servicios para trabajar con los tipos de documento.
    /// </summary>
    public class TipoDocumentoServicio
    {
        private readonly TipoDocumentoRepositorio tipoDocumentoRepositorio = new TipoDocumentoRepositorio();

        /// <summary>
        /// Obtiene una lista de los tipos de documento disponibles en la base de datos.
        /// </summary>
        /// <returns>Una lista de objetos de tipo TipoDocumento.</returns>
        public List<TipoDocumento> Listar()
        {
            return tipoDocumentoRepositorio.Listar();
        }
    }
}
