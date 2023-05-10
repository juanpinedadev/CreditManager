using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace CreditManager.Presentacion.Reporte.Formularios
{
    /// <summary>
    /// Representa un ReporteEmpleado.
    /// </summary>
    public partial class ReporteEmpleado : Form
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public ReporteEmpleado()
        {
            InitializeComponent();
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

        private void ReporteEmpleado_Load(object sender, EventArgs e)
        {
            try
            {
                // Cargar los datos en el control de informe
                this.listarEmpleadosTableAdapter.Fill(this.dataSetMaestro.ListarEmpleados);

                // Nombrar el formulario
                NombrarFormulario("clientes");

                // Actualizar y mostrar el informe en formato de impresión
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al cargar los datos en el informe: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
