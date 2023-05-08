using System;

namespace CreditManager.Entidad
{
    public class Pago
    {
        public int IdPago { get; set; }
        public Prestamo Prestamo { get; set; }
        public decimal MontoAbonado { get; set; }
        public DateTime FechaPago { get; set; }
    }
}
