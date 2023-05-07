namespace CreditManager.Datos.Interface
{

    /// <summary>
    /// Interfaz que define la operaciónes de validación.
    /// </summary>
    public interface IValidable
    {
        /// <summary>
        /// Valida un correo electrónico.
        /// </summary>
        /// <param name="correoElectronico">El correo electrónico que se desea validar.</param>
        /// <returns>Verdadero si el correo electrónico es válido, de lo contrario falso.</returns>
        bool ValidarCorreoElectronico(string correoElectronico);
    }
}
