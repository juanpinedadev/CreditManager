using CreditManager.Entidad;

namespace CreditManager.Datos.Interface
{
    /// <summary>
    /// Interfaz que extiende de IRepositorioGenerico para definir las operaciones específicas que puede realizar un repositorio de Empleado,
    /// además de implementar IValidable para permitir la validación de la entidad.
    /// </summary>
    public interface IEmpleadoRepositorio : IRepositorioGenerico<Empleado>, IValidable 
    {
    }
}
