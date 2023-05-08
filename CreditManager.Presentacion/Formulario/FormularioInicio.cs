using CreditManager.Entidad;
using CreditManager.Negocio;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace CreditManager.Presentacion.Formulario
{
    public partial class FormularioInicio : Form
    {
        /// <summary>
        /// Constructor de la clase FormularioInicio.
        /// </summary>
        public FormularioInicio()
        {
            InitializeComponent();
        }

        #region Eventos
        private void FormularioInicio_Load(object sender, EventArgs e)
        {
            CargarContadores();
        }
        #endregion

        #region Variables
        //Servicios
        private ClienteServicio clienteServicio = new ClienteServicio();
        #endregion

        #region Funciones
        private void CargarContadores()
        {

            //Listas
            List<Cliente> clientes = clienteServicio.ListarClientes();

            //Contadores
            contadorClientes.Text = clientes.Count.ToString();
        }
        #endregion

        private void ControlFechaHora_Tick(object sender, EventArgs e)
        {
            txtHora.Text = DateTime.Now.ToString("hh:mm:ss tt", CultureInfo.InvariantCulture);
            txtFecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}
