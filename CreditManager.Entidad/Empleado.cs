using System;

namespace CreditManager.Entidad
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public InformacionPersonal InformacionPersonal { get; set; }
        public InformacionContacto InformacionContacto { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool Estado { get; set; }
    }
}
