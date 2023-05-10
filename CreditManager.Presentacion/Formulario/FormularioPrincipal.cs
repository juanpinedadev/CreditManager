using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CreditManager.Presentacion.Formulario
{
    public partial class FormularioPrincipal : Form
    {


        #region Constructores
        public FormularioPrincipal()
        {
            InitializeComponent();
        }
        #endregion

        #region Variables

        #endregion

        #region Eventos
        
        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {
            AbrirModulo(new FormularioInicio(), btnInicio);
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirModulo(new FormularioInicio(), btnInicio);
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            AbrirModulo(new FormularioPrestamo(), btnPrestamos);
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            AbrirModulo(new FormularioPago(), btnPagos);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Gestor de clientes";
            panelBase.Visible = true;
            AbrirModulo(new FormularioCliente(), btnClientes);
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            AbrirModulo(new FormularioEmpleado(), btnEmpleados);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("¿Desea cerrar el sesión?",
                "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogo == DialogResult.No) { }
            else
            {
                this.Hide();
                FormularioLogin Login = new FormularioLogin();
                Login.Show();
            }
        }

        private void FormularioPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall) { return; }

            DialogResult dialogResult = MessageBox.Show("¿Está seguro de que desea salir del sistema?",
                "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            e.Cancel = (dialogResult == DialogResult.No);

            if (!e.Cancel) { Application.Exit(); }
        }

        #endregion

        #region Funciones
        private void CambiarEstadoBotonesPrincipales(bool state, Button button)
        {
            List<Button> buttons = new List<Button>
            {
                btnInicio,
                btnPrestamos,
                btnPagos,
                btnClientes,
                btnEmpleados,
                btnReportes
            };

            if (buttons.Contains(button))
            {
                button.Enabled = !state;

                foreach (Button btn in buttons)
                {
                    if (btn != button) { btn.Enabled = state; }
                }
            }
        }

        private void AbrirNuevoFormulario(Form modulo)
        {
            panelBase.Controls.Clear();
            modulo.TopLevel = false;
            modulo.Dock = DockStyle.Fill;
            panelBase.Controls.Add(modulo);
            panelBase.Tag = modulo;
            modulo.Show();
            panelBase.BringToFront();
        }

        private void AbrirModulo(Form panel, Button botonModulo)
        {
            CambiarEstadoBotonesPrincipales(true, botonModulo);
            AbrirNuevoFormulario(panel);
        }


        #endregion
    }
}
