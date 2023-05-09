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
            // TODO: esta línea de código carga datos en la tabla 'dataSetMaestro.ListarEmpleados' Puede moverla o quitarla según sea necesario.
            this.listarEmpleadosTableAdapter.Fill(this.dataSetMaestro.ListarEmpleados);
            NombrarFormulario("empleados");
            this.reportViewer1.RefreshReport();
        }
    }
}
