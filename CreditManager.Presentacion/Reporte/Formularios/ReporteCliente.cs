using Microsoft.Reporting.WinForms;
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
            try
            {
                // Cargar los datos en el control de informe
                this.listarClientesTableAdapter.Fill(this.dataSetMaestro.ListarClientes);

                // Nombrar el formulario
                NombrarFormulario("clientes");

                // Actualizar y mostrar el informe en formato de impresión
                reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al cargar los datos en el informe: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
