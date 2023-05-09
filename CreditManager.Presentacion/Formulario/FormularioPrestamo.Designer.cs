namespace CreditManager.Presentacion.Formulario
{
    partial class FormularioPrestamo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabConsulta = new System.Windows.Forms.TabPage();
            this.contador = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.tablaDatos = new System.Windows.Forms.DataGridView();
            this.tabMantenimiento = new System.Windows.Forms.TabPage();
            this.txtIndice = new System.Windows.Forms.TextBox();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.boxEstado = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNumeroCelular = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNumeroTelefono = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxTiposDocumento = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSegundoApellido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSegundoNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrimerNombre = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnRetornar = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).BeginInit();
            this.tabMantenimiento.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            this.btnCrear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrear.Image = global::CreditManager.Presentacion.Properties.Resources.imgAgregar;
            this.btnCrear.Location = new System.Drawing.Point(353, 484);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(88, 30);
            this.btnCrear.TabIndex = 7;
            this.btnCrear.Text = "Crear";
            this.btnCrear.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCrear.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.Image = global::CreditManager.Presentacion.Properties.Resources.imgActualizar;
            this.btnActualizar.Location = new System.Drawing.Point(447, 484);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(96, 30);
            this.btnActualizar.TabIndex = 6;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Image = global::CreditManager.Presentacion.Properties.Resources.imgEliminar;
            this.btnEliminar.Location = new System.Drawing.Point(549, 484);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(96, 30);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnReporte
            // 
            this.btnReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporte.Image = global::CreditManager.Presentacion.Properties.Resources.imgReportePequeño;
            this.btnReporte.Location = new System.Drawing.Point(651, 484);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(96, 30);
            this.btnReporte.TabIndex = 4;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnReporte.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabConsulta);
            this.tabControl.Controls.Add(this.tabMantenimiento);
            this.tabControl.Location = new System.Drawing.Point(13, 12);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(734, 466);
            this.tabControl.TabIndex = 38;
            // 
            // tabConsulta
            // 
            this.tabConsulta.Controls.Add(this.contador);
            this.tabConsulta.Controls.Add(this.label17);
            this.tabConsulta.Controls.Add(this.label1);
            this.tabConsulta.Controls.Add(this.txtFiltro);
            this.tabConsulta.Controls.Add(this.tablaDatos);
            this.tabConsulta.Location = new System.Drawing.Point(4, 25);
            this.tabConsulta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabConsulta.Name = "tabConsulta";
            this.tabConsulta.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabConsulta.Size = new System.Drawing.Size(726, 437);
            this.tabConsulta.TabIndex = 0;
            this.tabConsulta.Text = "Consulta";
            this.tabConsulta.UseVisualStyleBackColor = true;
            // 
            // contador
            // 
            this.contador.AutoSize = true;
            this.contador.Font = new System.Drawing.Font("Arial", 10F);
            this.contador.Location = new System.Drawing.Point(156, 19);
            this.contador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contador.Name = "contador";
            this.contador.Size = new System.Drawing.Size(82, 16);
            this.contador.TabIndex = 38;
            this.contador.Text = "Cargando...";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label17.Location = new System.Drawing.Point(4, 18);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(156, 16);
            this.label17.TabIndex = 39;
            this.label17.Text = "Número de registros:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(496, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filtrar:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiltro.Location = new System.Drawing.Point(544, 13);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(174, 23);
            this.txtFiltro.TabIndex = 3;
            // 
            // tablaDatos
            // 
            this.tablaDatos.AllowUserToAddRows = false;
            this.tablaDatos.AllowUserToDeleteRows = false;
            this.tablaDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tablaDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaDatos.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.tablaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaDatos.Location = new System.Drawing.Point(7, 40);
            this.tablaDatos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tablaDatos.Name = "tablaDatos";
            this.tablaDatos.ReadOnly = true;
            this.tablaDatos.RowHeadersWidth = 30;
            this.tablaDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaDatos.Size = new System.Drawing.Size(711, 383);
            this.tablaDatos.TabIndex = 1;
            // 
            // tabMantenimiento
            // 
            this.tabMantenimiento.Controls.Add(this.txtIndice);
            this.tabMantenimiento.Controls.Add(this.txtIdCliente);
            this.tabMantenimiento.Controls.Add(this.lblTitulo);
            this.tabMantenimiento.Controls.Add(this.label16);
            this.tabMantenimiento.Controls.Add(this.boxEstado);
            this.tabMantenimiento.Controls.Add(this.label15);
            this.tabMantenimiento.Controls.Add(this.txtCorreoElectronico);
            this.tabMantenimiento.Controls.Add(this.label14);
            this.tabMantenimiento.Controls.Add(this.txtDireccion);
            this.tabMantenimiento.Controls.Add(this.label13);
            this.tabMantenimiento.Controls.Add(this.label12);
            this.tabMantenimiento.Controls.Add(this.txtNumeroCelular);
            this.tabMantenimiento.Controls.Add(this.label11);
            this.tabMantenimiento.Controls.Add(this.txtNumeroTelefono);
            this.tabMantenimiento.Controls.Add(this.label10);
            this.tabMantenimiento.Controls.Add(this.comboBoxTiposDocumento);
            this.tabMantenimiento.Controls.Add(this.label9);
            this.tabMantenimiento.Controls.Add(this.txtNumeroDocumento);
            this.tabMantenimiento.Controls.Add(this.label8);
            this.tabMantenimiento.Controls.Add(this.label7);
            this.tabMantenimiento.Controls.Add(this.label6);
            this.tabMantenimiento.Controls.Add(this.txtSegundoApellido);
            this.tabMantenimiento.Controls.Add(this.label5);
            this.tabMantenimiento.Controls.Add(this.txtPrimerApellido);
            this.tabMantenimiento.Controls.Add(this.label4);
            this.tabMantenimiento.Controls.Add(this.txtSegundoNombre);
            this.tabMantenimiento.Controls.Add(this.label3);
            this.tabMantenimiento.Controls.Add(this.txtPrimerNombre);
            this.tabMantenimiento.Controls.Add(this.btnLimpiar);
            this.tabMantenimiento.Controls.Add(this.btnCancelar);
            this.tabMantenimiento.Controls.Add(this.btnGuardar);
            this.tabMantenimiento.Controls.Add(this.btnRetornar);
            this.tabMantenimiento.Location = new System.Drawing.Point(4, 25);
            this.tabMantenimiento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabMantenimiento.Name = "tabMantenimiento";
            this.tabMantenimiento.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabMantenimiento.Size = new System.Drawing.Size(726, 437);
            this.tabMantenimiento.TabIndex = 1;
            this.tabMantenimiento.Text = "Mantenimiento";
            this.tabMantenimiento.UseVisualStyleBackColor = true;
            // 
            // txtIndice
            // 
            this.txtIndice.BackColor = System.Drawing.Color.DarkGray;
            this.txtIndice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIndice.ForeColor = System.Drawing.Color.Black;
            this.txtIndice.Location = new System.Drawing.Point(7, 6);
            this.txtIndice.Name = "txtIndice";
            this.txtIndice.Size = new System.Drawing.Size(22, 23);
            this.txtIndice.TabIndex = 37;
            this.txtIndice.Text = "-1";
            this.txtIndice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIndice.Visible = false;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.BackColor = System.Drawing.Color.DarkGray;
            this.txtIdCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdCliente.ForeColor = System.Drawing.Color.Black;
            this.txtIdCliente.Location = new System.Drawing.Point(35, 6);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(22, 23);
            this.txtIdCliente.TabIndex = 36;
            this.txtIdCliente.Text = "0";
            this.txtIdCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIdCliente.Visible = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblTitulo.Location = new System.Drawing.Point(176, 25);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(165, 24);
            this.lblTitulo.TabIndex = 35;
            this.lblTitulo.Text = "Registrar cliente";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label16.Location = new System.Drawing.Point(450, 330);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 15);
            this.label16.TabIndex = 28;
            this.label16.Text = "Estado:";
            // 
            // boxEstado
            // 
            this.boxEstado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.boxEstado.BackColor = System.Drawing.Color.White;
            this.boxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxEstado.Enabled = false;
            this.boxEstado.FormattingEnabled = true;
            this.boxEstado.Location = new System.Drawing.Point(453, 348);
            this.boxEstado.Name = "boxEstado";
            this.boxEstado.Size = new System.Drawing.Size(97, 24);
            this.boxEstado.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label15.Location = new System.Drawing.Point(176, 330);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(116, 15);
            this.label15.TabIndex = 26;
            this.label15.Text = "Correo electrónico:";
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCorreoElectronico.BackColor = System.Drawing.Color.White;
            this.txtCorreoElectronico.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCorreoElectronico.Enabled = false;
            this.txtCorreoElectronico.Location = new System.Drawing.Point(179, 348);
            this.txtCorreoElectronico.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(258, 23);
            this.txtCorreoElectronico.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label14.Location = new System.Drawing.Point(176, 277);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 15);
            this.label14.TabIndex = 24;
            this.label14.Text = "Dirección del cliente:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDireccion.BackColor = System.Drawing.Color.White;
            this.txtDireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Location = new System.Drawing.Point(179, 295);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(371, 23);
            this.txtDireccion.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 7F);
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label13.Location = new System.Drawing.Point(297, 228);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "(Opcional)";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label12.Location = new System.Drawing.Point(373, 226);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 15);
            this.label12.TabIndex = 21;
            this.label12.Text = "Número de celular:";
            // 
            // txtNumeroCelular
            // 
            this.txtNumeroCelular.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNumeroCelular.BackColor = System.Drawing.Color.White;
            this.txtNumeroCelular.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumeroCelular.Enabled = false;
            this.txtNumeroCelular.Location = new System.Drawing.Point(376, 244);
            this.txtNumeroCelular.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNumeroCelular.MaxLength = 10;
            this.txtNumeroCelular.Name = "txtNumeroCelular";
            this.txtNumeroCelular.Size = new System.Drawing.Size(174, 23);
            this.txtNumeroCelular.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label11.Location = new System.Drawing.Point(176, 226);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 15);
            this.label11.TabIndex = 19;
            this.label11.Text = "Número de teléfono:";
            // 
            // txtNumeroTelefono
            // 
            this.txtNumeroTelefono.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNumeroTelefono.BackColor = System.Drawing.Color.White;
            this.txtNumeroTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumeroTelefono.Enabled = false;
            this.txtNumeroTelefono.Location = new System.Drawing.Point(179, 244);
            this.txtNumeroTelefono.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNumeroTelefono.MaxLength = 10;
            this.txtNumeroTelefono.Name = "txtNumeroTelefono";
            this.txtNumeroTelefono.Size = new System.Drawing.Size(174, 23);
            this.txtNumeroTelefono.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label10.Location = new System.Drawing.Point(373, 170);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "Tipo de documento:";
            // 
            // comboBoxTiposDocumento
            // 
            this.comboBoxTiposDocumento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxTiposDocumento.BackColor = System.Drawing.Color.White;
            this.comboBoxTiposDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTiposDocumento.Enabled = false;
            this.comboBoxTiposDocumento.FormattingEnabled = true;
            this.comboBoxTiposDocumento.Location = new System.Drawing.Point(375, 188);
            this.comboBoxTiposDocumento.Name = "comboBoxTiposDocumento";
            this.comboBoxTiposDocumento.Size = new System.Drawing.Size(175, 24);
            this.comboBoxTiposDocumento.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label9.Location = new System.Drawing.Point(176, 172);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "Número de documento:";
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNumeroDocumento.BackColor = System.Drawing.Color.White;
            this.txtNumeroDocumento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumeroDocumento.Enabled = false;
            this.txtNumeroDocumento.Location = new System.Drawing.Point(179, 190);
            this.txtNumeroDocumento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNumeroDocumento.MaxLength = 20;
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Size = new System.Drawing.Size(174, 23);
            this.txtNumeroDocumento.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 7F);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label8.Location = new System.Drawing.Point(494, 117);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "(Opcional)";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 7F);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label7.Location = new System.Drawing.Point(494, 61);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "(Opcional)";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label6.Location = new System.Drawing.Point(373, 116);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Segundo apellido:";
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSegundoApellido.BackColor = System.Drawing.Color.White;
            this.txtSegundoApellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSegundoApellido.Enabled = false;
            this.txtSegundoApellido.Location = new System.Drawing.Point(376, 134);
            this.txtSegundoApellido.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSegundoApellido.MaxLength = 15;
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Size = new System.Drawing.Size(174, 23);
            this.txtSegundoApellido.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label5.Location = new System.Drawing.Point(176, 116);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Primer apellido:";
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPrimerApellido.BackColor = System.Drawing.Color.White;
            this.txtPrimerApellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrimerApellido.Enabled = false;
            this.txtPrimerApellido.Location = new System.Drawing.Point(179, 134);
            this.txtPrimerApellido.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPrimerApellido.MaxLength = 15;
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(174, 23);
            this.txtPrimerApellido.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label4.Location = new System.Drawing.Point(373, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Segundo nombre:";
            // 
            // txtSegundoNombre
            // 
            this.txtSegundoNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSegundoNombre.BackColor = System.Drawing.Color.White;
            this.txtSegundoNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSegundoNombre.Enabled = false;
            this.txtSegundoNombre.Location = new System.Drawing.Point(376, 77);
            this.txtSegundoNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSegundoNombre.MaxLength = 15;
            this.txtSegundoNombre.Name = "txtSegundoNombre";
            this.txtSegundoNombre.Size = new System.Drawing.Size(174, 23);
            this.txtSegundoNombre.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label3.Location = new System.Drawing.Point(176, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Primer nombre:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPrimerNombre.BackColor = System.Drawing.Color.White;
            this.txtPrimerNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrimerNombre.Enabled = false;
            this.txtPrimerNombre.Location = new System.Drawing.Point(179, 77);
            this.txtPrimerNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPrimerNombre.MaxLength = 15;
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.Size = new System.Drawing.Size(174, 23);
            this.txtPrimerNombre.TabIndex = 4;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.Image = global::CreditManager.Presentacion.Properties.Resources.imgLimpiar;
            this.btnLimpiar.Location = new System.Drawing.Point(284, 382);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(96, 30);
            this.btnLimpiar.TabIndex = 34;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Image = global::CreditManager.Presentacion.Properties.Resources.imgEliminar;
            this.btnCancelar.Location = new System.Drawing.Point(180, 382);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(96, 30);
            this.btnCancelar.TabIndex = 33;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Image = global::CreditManager.Presentacion.Properties.Resources.imgGuardar;
            this.btnGuardar.Location = new System.Drawing.Point(388, 382);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(96, 30);
            this.btnGuardar.TabIndex = 32;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Visible = false;
            // 
            // btnRetornar
            // 
            this.btnRetornar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRetornar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRetornar.Image = global::CreditManager.Presentacion.Properties.Resources.imgRetornar;
            this.btnRetornar.Location = new System.Drawing.Point(621, 6);
            this.btnRetornar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(97, 30);
            this.btnRetornar.TabIndex = 31;
            this.btnRetornar.Text = "Retornar";
            this.btnRetornar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRetornar.UseVisualStyleBackColor = true;
            // 
            // FormularioPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 526);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnReporte);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormularioPrestamo";
            this.Text = "FormularioPrestamo";
            this.tabControl.ResumeLayout(false);
            this.tabConsulta.ResumeLayout(false);
            this.tabConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).EndInit();
            this.tabMantenimiento.ResumeLayout(false);
            this.tabMantenimiento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabConsulta;
        private System.Windows.Forms.Label contador;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.DataGridView tablaDatos;
        private System.Windows.Forms.TabPage tabMantenimiento;
        private System.Windows.Forms.TextBox txtIndice;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox boxEstado;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNumeroCelular;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNumeroTelefono;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxTiposDocumento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNumeroDocumento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSegundoApellido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSegundoNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrimerNombre;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnRetornar;
    }
}