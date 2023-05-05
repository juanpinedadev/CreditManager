using System;

namespace CreditManager.Entidad
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string NumeroDocumento { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
        public string NumeroTelefono { get; set; }
        public string Direccion { get; set; }
        public string NumeroCelular { get; set; }
        public string CorreoElectronico { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool Estado { get; set; }
    }
}
