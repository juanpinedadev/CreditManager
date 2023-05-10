using System;
using System.Windows.Forms;

namespace CreditManager.Presentacion.Formulario
{
    public partial class FormularioPago : Form
    {
        public FormularioPago()
        {
            InitializeComponent();
        }

        private void ConsultarCliente()
        {
            FormularioListarClientes listarClientes = new FormularioListarClientes();

            var result = listarClientes.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtNumeroDocumento.Text = listarClientes.cliente.NumeroDocumento.ToString();
            }
            else
            {
                //txtDocumento.Select();
            }
        }

        private void btnConsultarCliente_Click(object sender, EventArgs e)
        {
            ConsultarCliente();
        }
    }
}
