using CreditManager.Entidad;

namespace CreditManager.Datos.Interface
{
    public interface IClienteRepositorio : IRepositorioGenerico<Cliente>
    {
        bool ValidarCorreoElectronico(string correoElectronico);
    }
}
