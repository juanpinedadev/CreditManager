using System.Windows.Forms;

namespace CreditManager.Presentacion.Formulario
{
    public partial class FormularioLogin : Form
    {
        #region Constructor
        public FormularioLogin()
        {
            InitializeComponent();
        }
        #endregion

        #region Variables

        #endregion

        #region Eventos 
        private void FormularioLogin_Load(object sender, System.EventArgs e)
        {
            txtUsuario.Focus();
        }

        private void btnIngresar_Click(object sender, System.EventArgs e)
        {
            ValidarCredenciales();
        }

        private void FormularioLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall) { return; }

            DialogResult dialogResult = MessageBox.Show("¿Está seguro de que desea salir del sistema?",
                "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            e.Cancel = (dialogResult == DialogResult.No);

            if (!e.Cancel) { Application.Exit(); }
        }
        #endregion

        #region Funciones
        private void ValidarCredenciales()
        {
            if (txtUsuario.Text == "" && txtContraseña.Text == "")
            {
                MessageBox.Show("Los campos están vacíos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
            }

            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Proporcione un nombre de usuario.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return;
            }

            if (txtContraseña.Text == "")
            {
                MessageBox.Show("Proporcione una contraseña de usuario.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContraseña.Focus();
                return;
            }

            else
            {
                this.Hide();
                FormularioPrincipal principal = new FormularioPrincipal();
                principal.Show();
            }
        }
        #endregion
    }
}
