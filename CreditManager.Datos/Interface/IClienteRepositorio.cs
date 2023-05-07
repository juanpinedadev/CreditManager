using CreditManager.Entidad;

namespace CreditManager.Datos.Interface
{
    /// <summary>
    /// Interfaz que define las operaciones para acceder a los datos de un cliente.
    /// </summary>
    public interface IClienteRepositorio : IRepositorioGenerico<Cliente>, IValidable
    {
    }
}
