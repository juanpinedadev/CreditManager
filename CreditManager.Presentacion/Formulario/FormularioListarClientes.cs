using CreditManager.Entidad;
using CreditManager.Negocio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CreditManager.Presentacion.Formulario
{
    /// <summary>
    /// 
    /// </summary>
    public partial class FormularioListarClientes : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public Cliente cliente { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public FormularioListarClientes()
        {
            InitializeComponent();
        }

        private void FormularioListarClientes_Load(object sender, EventArgs e)
        {
            LLenarDatos();
        }

        private void LLenarDatos()
        {
            ClienteServicio clienteServicio = new ClienteServicio();

            List<Cliente> clientes = clienteServicio.ListarClientes();

            foreach (var item in clientes)
            {
                var nombre = $"{item.PrimerNombre} {item.SegundoNombre} {item.PrimerApellido} {item.SegundoApellido}";

                if (item.Estado == true)
                {
                    tablaDatos.Rows.Add(new object[] { item.NumeroDocumento, nombre });
                }
            }
        }

        private void tablaDatos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex % 2 == 0) // filas pares
            {
                e.CellStyle.BackColor = Color.FromArgb(240, 240, 240);
            }
            else // filas impares
            {
                e.CellStyle.BackColor = Color.White;
            }
        }

        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            FiltrarDatos(txtFiltro, tablaDatos);
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

        private void tablaDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index_row = e.RowIndex;
            int index_colum = e.ColumnIndex;

            if (index_row >= 0 && index_colum >= 0)
            {
                cliente = new Cliente()
                {
                    NumeroDocumento = tablaDatos.Rows[index_row].Cells["NumeroDocumento"].Value.ToString(),
                    //PrimerApellido = tablaDatos .Rows[index_row].Cells["PrimerApellido"].Value.ToString()
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
