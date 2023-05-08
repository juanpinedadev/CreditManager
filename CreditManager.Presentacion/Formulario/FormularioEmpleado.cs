using CreditManager.Entidad;
using CreditManager.Negocio;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace CreditManager.Presentacion.Formulario
{
    public partial class FormularioEmpleado : Form
    {

        #region Constructores
        /// <summary>
        /// Constructor de la clase FormularioEmpleado.
        /// </summary>
        public FormularioEmpleado()
        {
            InitializeComponent();
        }
        #endregion

        #region Variables
        //Servicio que nos permitirá interactuar con los empleados en la base de datos
        private EmpleadoServicio empleadoServicio = new EmpleadoServicio();

        //Servicio que nos permitirá interactuar con los tipos de empleados en la base de datos
        private TipoDocumentoServicio tipoDocumentoServicio = new TipoDocumentoServicio();

        int idEmpleado = 0; //Se usa para captar el empleado que seleccione en la tabla
        string nombreEmpleado; //Se usa para acpturar el nombre del empleado que seleccione en la tabla
        #endregion

        #region Eventos

        private void FormularioEmpleado_Load(object sender, EventArgs e)
        {
            ListarEmpleados();
            ListarTiposDocumento();
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
            EliminarEmpleado();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea cancelar este proceso?",
                 "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                ListarEmpleados();
                ListarTiposDocumento();
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
            CrearEmpleado();
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            ListarEmpleados();
            ListarTiposDocumento();
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

        private void txtNumeroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Este campo solo admite números.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void txtNumeroTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Este campo solo admite números.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void txtNumeroCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Este campo solo admite números.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
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
            comboBoxTiposDocumento.Enabled = estado;
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
                if (string.IsNullOrEmpty(Convert.ToString(tablaDatos.CurrentRow.Cells["IdEmpleado"].Value)))
                {
                    MessageBox.Show("Seleccione un registro.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    idEmpleado = Convert.ToInt32(tablaDatos.CurrentRow.Cells["IdEmpleado"].Value);

                    string primerNombre = tablaDatos.CurrentRow.Cells["PrimerNombre"].Value.ToString();
                    string primerApellido = tablaDatos.CurrentRow.Cells["PrimerApellido"].Value.ToString();
                    nombreEmpleado = $"{primerNombre} {primerApellido}";

                    txtIdEmpleado.Text = idEmpleado.ToString();
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

        private void ListarEmpleados()
        {
            try
            {
                //Cargamos los Empleados a la tabla
                tablaDatos.DataSource = empleadoServicio.Listar();

                //Cargamos el contador (Númerod de Empleados)
                contador.Text = empleadoServicio.Listar().Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ListarTiposDocumento()
        {
            try
            {
                List<TipoDocumento> tiposDocumento = tipoDocumentoServicio.Listar();

                // Agrega la opción "Seleccionar"
                tiposDocumento.Insert(0, new TipoDocumento { IdTipoDocumento = 0, Tipo = "Seleccionar" });

                // Asigna la lista al ComboBox
                comboBoxTiposDocumento.DataSource = tiposDocumento;
                comboBoxTiposDocumento.DisplayMember = "Tipo";
                comboBoxTiposDocumento.ValueMember = "IdTipoDocumento";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CrearEmpleado()
        {
            try
            {
                //Inicializamos el mensaje de salida (vacio) para más adelante asignarle un valor
                string mensaje = string.Empty;

                //Cremos el tipo de documento que será seleccionado
                TipoDocumento tipoDocumentoSeleccionado = (TipoDocumento)comboBoxTiposDocumento.SelectedItem;

                InformacionPersonal informacionPersonal = new InformacionPersonal()
                {
                    PrimerNombre = txtPrimerNombre.Text,
                    SegundoNombre = txtSegundoNombre.Text,
                    PrimerApellido = txtPrimerApellido.Text,
                    SegundoApellido = txtSegundoApellido.Text,
                    NumeroDocumento = txtNumeroDocumento.Text,
                    TipoDocumento = tipoDocumentoSeleccionado,
                };

                InformacionContacto informacionContacto = new InformacionContacto()
                {
                    NumeroTelefono = txtNumeroTelefono.Text,
                    NumeroCelular = txtNumeroCelular.Text,
                    Direccion = txtDireccion.Text,
                    CorreoElectronico = txtCorreoElectronico.Text
                };

                //Creamos un objeto Empleado y le asignamos los campos
                Empleado Empleado = new Empleado()
                {
                    IdEmpleado = Convert.ToInt32(txtIdEmpleado.Text),
                    InformacionPersonal = informacionPersonal,
                    InformacionContacto = informacionContacto,
                    Estado = true //Arreglar

                };

                //Si el Empleado tiene el id en 0, eso indica que se está creando por primera vez
                if (Empleado.IdEmpleado == 0)
                {
                    DialogResult dialogo = MessageBox.Show("¿Desea agregar este nuevo empleado?",
                        "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogo == DialogResult.No) { }
                    else
                    {
                        //Creamos el Empleado en la base de datos y devolvemos su id
                        int idEmpleadoGenerado = empleadoServicio.Crear(Empleado, out mensaje);

                        //Si el Empleado se registra correctamente, la variable idEmpleadoGenerado tomará el valor del id del Empleado registrado
                        if (idEmpleadoGenerado != 0)
                        {
                            //Cargamos el registro en la tabla de datos ...

                            ListarEmpleados();

                            LimpiarFormularioRegistro();
                            CambiarEstadoBotonesCRUD(true);
                            CambiarEstadoFormulario(false);
                            tabControl.SelectedIndex = 0;

                            MessageBox.Show("Empleado creado exitosamente.", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void EliminarEmpleado()
        {
            try
            {

                if (tablaDatos.Rows.Count < 1)
                {
                    MessageBox.Show("No existen registros para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (Convert.ToInt32(txtIdEmpleado.Text) != 0)
                {
                    string mensaje = string.Empty;

                    SeleccionarRegistroTabla();
                    DialogResult dialogo = MessageBox.Show($"¿Desea eliminar el empleado {nombreEmpleado}?",
                        "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogo == DialogResult.No) { }
                    else
                    {
                        Empleado Empleado = new Empleado()
                        {
                            IdEmpleado = Convert.ToInt32(txtIdEmpleado.Text)
                        };

                        bool respuesta = empleadoServicio.Eliminar(Empleado, out mensaje);

                        if (respuesta)
                        {
                            //tablaDatos.Rows.RemoveAt(Convert.ToInt32(txtIndice.Text));
                            ListarEmpleados();
                            MessageBox.Show("Empleado eliminado exitosamente.", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
