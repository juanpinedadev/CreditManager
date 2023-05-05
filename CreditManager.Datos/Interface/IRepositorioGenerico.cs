using System.Collections.Generic;

namespace CreditManager.Datos.Interface
{
    public interface IRepositorioGenerico<T> where T : class
    {
        int Crear(T entidad, out string mensaje);
        bool Actualizar(T entidad, out string mensaje);
        bool Eliminar(T entidad, out string mensaje);
        List<T> Listar();
    }
}
