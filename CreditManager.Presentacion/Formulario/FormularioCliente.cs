using CreditManager.Entidad;
using CreditManager.Negocio;
using CreditManager.Presentacion.Reporte.Formularios;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CreditManager.Presentacion.Formulario
{
    public partial class FormularioCliente : Form
    {


        #region Constructores
        public FormularioCliente()
        {
            InitializeComponent();
        }
        #endregion

        #region Variables
        //Servicio que nos permitirá interactuar con los clientes en la base de datos
        private ClienteServicio clienteServicio = new ClienteServicio();
        int idCliente = 0; //Se usa para captar el cliente que seleccione en la tabla
        string nombreCliente; //Se usa para acpturar el nombre del cliente que seleccione en la tabla
        #endregion

        #region Eventos
        private void FormularioCliente_Load(object sender, EventArgs e)
        {
            ListarClientes();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            tablaDatos.DataSource = null;
            CambiarEstadoBotonesCRUD(false);
            CambiarEstadoFormulario(true);
            tabControl.SelectedIndex = 1;
            btnRetornar.Visible = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            tablaDatos.DataSource = null;
            CambiarEstadoBotonesCRUD(false);
            CambiarEstadoFormulario(true);
            tabControl.SelectedIndex = 1;
            btnRetornar.Visible = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarCliente();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            if (tablaDatos.Rows.Count <= 0)
            {
                MessageBox.Show("No hay registros de clientes para generar un reporte.",
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                ReporteCliente reporteCliente = new ReporteCliente();
                reporteCliente.ShowDialog();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea cancelar este proceso?",
                "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                ListarClientes();
                LimpiarFormularioRegistro();
                CambiarEstadoBotonesCRUD(true);
                CambiarEstadoFormulario(false);
                tabControl.SelectedIndex = 0;
                btnRetornar.Visible = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormularioRegistro();
            MessageBox.Show("Campos limpiados con exito.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CrearCliente();
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            ListarClientes();
            LimpiarFormularioRegistro();
            CambiarEstadoBotonesCRUD(true);
            CambiarEstadoFormulario(false);
            tabControl.SelectedIndex = 0;
        }

        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            FiltrarDatos(txtFiltro, tablaDatos);
        }

        private void tablaDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarRegistroTabla();
        }

        private void tablaDatos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //Este codigo hace que la tabla de datos se vea como renglones de cuadernos :)

            if (e.RowIndex % 2 == 0) // filas pares
            {
                e.CellStyle.BackColor = Color.FromArgb(240, 240, 240);
            }
            else // filas impares
            {
                e.CellStyle.BackColor = Color.White;
            }

            //Si detecta que algún campo está vacío, le asigna un mensaje
            if (e.Value == null || string.IsNullOrEmpty(e.Value.ToString().Trim()))
            {
                e.Value = "no ingresado";
                e.CellStyle.ForeColor = Color.Gray;
            }
        }
        #endregion

        #region Funciones
        private void LimpiarFormularioRegistro()
        {
            txtPrimerNombre.Clear();
            txtSegundoNombre.Clear();
            txtPrimerApellido.Clear();
            txtSegundoApellido.Clear();
            txtNumeroDocumento.Clear();
            //boxTipoDocumento.
            //boxEstado.SelectedIndex = 0;
            txtNumeroTelefono.Clear();
            txtNumeroCelular.Clear();
            txtDireccion.Clear();
            txtCorreoElectronico.Clear();
        }

        private void CambiarEstadoBotonesCRUD(bool estado)
        {
            //Habilita o deshabilita los botones CRUD
            btnCrear.Enabled = estado;
            btnActualizar.Enabled = estado;
            btnEliminar.Enabled = estado;
            btnReporte.Enabled = estado;

            tablaDatos.Enabled = estado;
            txtFiltro.Enabled = estado;

            //Habilita o deshabilita los botones funcionales
            btnCancelar.Visible = !estado;
            btnLimpiar.Visible = !estado;
            btnGuardar.Visible = !estado;
        }

        private void CambiarEstadoFormulario(bool estado)
        {
            txtPrimerNombre.Enabled = estado;
            txtSegundoNombre.Enabled = estado;
            txtPrimerApellido.Enabled = estado;
            txtSegundoApellido.Enabled = estado;
            txtNumeroDocumento.Enabled = estado;
            boxTipoDocumento.Enabled = estado;
            boxEstado.Enabled = estado;
            txtNumeroTelefono.Enabled = estado;
            txtNumeroCelular.Enabled = estado;
            txtDireccion.Enabled = estado;
            txtCorreoElectronico.Enabled = estado;
        }

        private void SeleccionarRegistroTabla()
        {
            try
            {
                if (string.IsNullOrEmpty(Convert.ToString(tablaDatos.CurrentRow.Cells["IdCliente"].Value)))
                {
                    MessageBox.Show("Seleccione un registro.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    idCliente = Convert.ToInt32(tablaDatos.CurrentRow.Cells["IdCliente"].Value);

                    string primerNombre = tablaDatos.CurrentRow.Cells["PrimerNombre"].Value.ToString();
                    string primerApellido = tablaDatos.CurrentRow.Cells["PrimerApellido"].Value.ToString();
                    nombreCliente = $"{primerNombre} {primerApellido}";

                    txtIdCliente.Text = idCliente.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FiltrarDatos(TextBox cajaTexto, DataGridView datos)
        {
            try
            {
                string searchText = cajaTexto.Text.Trim();

                // Filtrar los datos en función de la cadena de búsqueda
                datos.CurrentCell = null;
                datos.Rows.Cast<DataGridViewRow>()
                    .ToList()
                    .ForEach(row => row.Visible = string.IsNullOrEmpty(searchText) ||
                        row.Cells.Cast<DataGridViewCell>()
                            .Any(cell => cell.Value != null && cell.Value.ToString().Contains(searchText)));
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarClientes()
        {
            try
            {
                //Cargamos los clientes a la tabla
                tablaDatos.DataSource = clienteServicio.ListarClientes();

                //Cargamos el contador (Númerod de clientes)
                contador.Text = clienteServicio.ListarClientes().Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CrearCliente()
        {
            try
            {
                //Inicializamos el mensaje de salida (vacio) para más adelante asignarle un valor
                string mensaje = string.Empty;

                //Creamos un objeto cliente y le asignamos los campos
                Cliente cliente = new Cliente()
                {
                    IdCliente = Convert.ToInt32(txtIdCliente.Text),
                    PrimerNombre = txtPrimerNombre.Text,
                    SegundoNombre = txtSegundoNombre.Text,
                    PrimerApellido = txtPrimerApellido.Text,
                    SegundoApellido = txtSegundoApellido.Text,
                    NumeroDocumento = txtNumeroDocumento.Text,
                    TipoDocumento = new TipoDocumento() { IdTipoDocumento = 1, Tipo = "Cedula" }, //Arreglar
                    NumeroTelefono = txtNumeroTelefono.Text,
                    NumeroCelular = txtNumeroCelular.Text,
                    Direccion = txtDireccion.Text,
                    CorreoElectronico = txtCorreoElectronico.Text
                };

                //Si el cliente tiene el id en 0, eso indica que se está creando por primera vez
                if (cliente.IdCliente == 0)
                {
                    DialogResult dialogo = MessageBox.Show("¿Desea agregar este nuevo cliente?",
                        "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogo == DialogResult.No) { }
                    else
                    {
                        //Creamos el cliente en la base de datos y devolvemos su id
                        int idClienteGenerado = clienteServicio.Crear(cliente, out mensaje);

                        //Si el cliente se registra correctamente, la variable idClienteGenerado tomará el valor del id del cliente registrado
                        if (idClienteGenerado != 0)
                        {
                            //Cargamos el registro en la tabla de datos ...

                            ListarClientes();

                            LimpiarFormularioRegistro();
                            CambiarEstadoBotonesCRUD(true);
                            CambiarEstadoFormulario(false);
                            tabControl.SelectedIndex = 0;

                            MessageBox.Show("Cliente creado exitosamente.", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            //Si algo sucede mal,mostramos el mensaje del posible error.
                            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void EliminarCliente()
        {
            try
            {

                if (tablaDatos.Rows.Count < 1)
                {
                    MessageBox.Show("No existen registros para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (Convert.ToInt32(txtIdCliente.Text) != 0)
                {
                    string mensaje = string.Empty;

                    SeleccionarRegistroTabla();
                    DialogResult dialogo = MessageBox.Show($"¿Desea eliminar el cliente {nombreCliente}?",
                        "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogo == DialogResult.No) { }
                    else
                    {
                        Cliente Cliente = new Cliente()
                        {
                            IdCliente = Convert.ToInt32(txtIdCliente.Text)
                        };

                        bool respuesta = clienteServicio.Eliminar(Cliente, out mensaje);

                        if (respuesta)
                        {
                            //tablaDatos.Rows.RemoveAt(Convert.ToInt32(txtIndice.Text));
                            ListarClientes();
                            MessageBox.Show("Cliente eliminado exitosamente.", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}
