using CreditManager.Entidad;
using System.Collections.Generic;

namespace CreditManager.Datos.Interface
{
    public interface ITipoPlazoRepositorio
    {
        List<TipoPlazo> Listar();
    }
}
