using System;

namespace CreditManager.Entidad
{
    public class Prestamo
    {
        public int IdPrestamo { get; set; }
        public Cliente Solicitante { get; set; }
        public decimal MontoSolicitado { get; set; }
        public decimal MontoTotalAPagar { get; set; } 
        public int NumeroCuotas { get; set; } 
        public decimal TasaInteres { get; set; } 
        public DateTime FechaSolicitud { get; set; } 
        public bool Pagado { get; set; }
    }
}
