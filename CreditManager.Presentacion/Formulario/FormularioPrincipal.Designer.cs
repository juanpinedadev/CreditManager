namespace CreditManager.Presentacion.Formulario
{
    partial class FormularioPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioPrincipal));
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelLateral = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnPagos = new System.Windows.Forms.Button();
            this.btnPrestamos = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.panelInferior = new System.Windows.Forms.Panel();
            this.panelBase = new System.Windows.Forms.Panel();
            this.panelSuperior.SuspendLayout();
            this.panelLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelSuperior.Controls.Add(this.lblTitulo);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(834, 30);
            this.panelSuperior.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblTitulo.Location = new System.Drawing.Point(3, 6);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(121, 19);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Menú principal";
            // 
            // panelLateral
            // 
            this.panelLateral.AutoScroll = true;
            this.panelLateral.BackColor = System.Drawing.Color.White;
            this.panelLateral.Controls.Add(this.btnCerrarSesion);
            this.panelLateral.Controls.Add(this.btnReportes);
            this.panelLateral.Controls.Add(this.btnEmpleados);
            this.panelLateral.Controls.Add(this.btnClientes);
            this.panelLateral.Controls.Add(this.btnPagos);
            this.panelLateral.Controls.Add(this.btnPrestamos);
            this.panelLateral.Controls.Add(this.btnInicio);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 30);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(75, 526);
            this.panelLateral.TabIndex = 1;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Arial", 8F);
            this.btnCerrarSesion.Image = global::CreditManager.Presentacion.Properties.Resources.imgCerrarSesion;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 450);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(75, 75);
            this.btnCerrarSesion.TabIndex = 6;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Arial", 8F);
            this.btnReportes.Image = global::CreditManager.Presentacion.Properties.Resources.imgReporte;
            this.btnReportes.Location = new System.Drawing.Point(0, 375);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(75, 75);
            this.btnReportes.TabIndex = 5;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReportes.UseVisualStyleBackColor = false;
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Arial", 8F);
            this.btnEmpleados.Image = global::CreditManager.Presentacion.Properties.Resources.imgEmpleado;
            this.btnEmpleados.Location = new System.Drawing.Point(0, 300);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(75, 75);
            this.btnEmpleados.TabIndex = 4;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEmpleados.UseVisualStyleBackColor = false;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Arial", 8F);
            this.btnClientes.Image = global::CreditManager.Presentacion.Properties.Resources.imgCliente;
            this.btnClientes.Location = new System.Drawing.Point(0, 225);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(75, 75);
            this.btnClientes.TabIndex = 3;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnPagos
            // 
            this.btnPagos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPagos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPagos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPagos.FlatAppearance.BorderSize = 0;
            this.btnPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagos.Font = new System.Drawing.Font("Arial", 8F);
            this.btnPagos.Image = global::CreditManager.Presentacion.Properties.Resources.imgPago;
            this.btnPagos.Location = new System.Drawing.Point(0, 150);
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.Size = new System.Drawing.Size(75, 75);
            this.btnPagos.TabIndex = 2;
            this.btnPagos.Text = "Pagos";
            this.btnPagos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPagos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPagos.UseVisualStyleBackColor = false;
            this.btnPagos.Click += new System.EventHandler(this.btnPagos_Click);
            // 
            // btnPrestamos
            // 
            this.btnPrestamos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrestamos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrestamos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPrestamos.FlatAppearance.BorderSize = 0;
            this.btnPrestamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrestamos.Font = new System.Drawing.Font("Arial", 8F);
            this.btnPrestamos.Image = global::CreditManager.Presentacion.Properties.Resources.imgPrestamo;
            this.btnPrestamos.Location = new System.Drawing.Point(0, 75);
            this.btnPrestamos.Name = "btnPrestamos";
            this.btnPrestamos.Size = new System.Drawing.Size(75, 75);
            this.btnPrestamos.TabIndex = 1;
            this.btnPrestamos.Text = "Prestamos";
            this.btnPrestamos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrestamos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPrestamos.UseVisualStyleBackColor = false;
            this.btnPrestamos.Click += new System.EventHandler(this.btnPrestamos_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Arial", 8F);
            this.btnInicio.Image = global::CreditManager.Presentacion.Properties.Resources.imgInicio;
            this.btnInicio.Location = new System.Drawing.Point(0, 0);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(75, 75);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // panelInferior
            // 
            this.panelInferior.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferior.Location = new System.Drawing.Point(0, 556);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(834, 30);
            this.panelInferior.TabIndex = 2;
            // 
            // panelBase
            // 
            this.panelBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBase.Location = new System.Drawing.Point(75, 30);
            this.panelBase.Name = "panelBase";
            this.panelBase.Size = new System.Drawing.Size(759, 526);
            this.panelBase.TabIndex = 3;
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 586);
            this.Controls.Add(this.panelBase);
            this.Controls.Add(this.panelLateral);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.panelInferior);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(850, 625);
            this.Name = "FormularioPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Credit Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormularioPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FormularioPrincipal_Load);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panelLateral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnPagos;
        private System.Windows.Forms.Button btnPrestamos;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Panel panelBase;
        private System.Windows.Forms.Label lblTitulo;
    }
}