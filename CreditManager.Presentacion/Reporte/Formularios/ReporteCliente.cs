using System;
using System.Windows.Forms;

namespace CreditManager.Presentacion.Reporte.Formularios
{
    public partial class ReporteCliente : Form
    {
        public ReporteCliente()
        {
            InitializeComponent();
        }

        private void ReporteCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetMaestro.ListarClientes' Puede moverla o quitarla según sea necesario.
            this.listarClientesTableAdapter.Fill(this.dataSetMaestro.ListarClientes);
            NombrarFormulario("clientes");
            this.reportViewer.RefreshReport();
        }

        #region Funciones

        private void NombrarFormulario(string nombreReporte)
        {
            // Obtener la fecha actual
            DateTime fechaActual = DateTime.Now;

            // Asignar el título con la fecha actual al control Label
            this.Text = $"Reporte de {nombreReporte}: " + fechaActual.ToString("dd/MM/yyyy");
        }

        #endregion
    }
}
