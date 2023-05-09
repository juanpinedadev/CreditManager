using CreditManager.Datos.Repositorio;
using CreditManager.Entidad;
using System.Collections.Generic;

namespace CreditManager.Negocio
{
    public class TipoPlazoServicio
    {
        private readonly TipoPlazoRepositorio tipoPlazoRepositorio = new TipoPlazoRepositorio();

        public List<TipoPlazo> Listar()
        {
            return tipoPlazoRepositorio.Listar();    
        }
    }
}
