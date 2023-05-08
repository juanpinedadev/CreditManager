namespace CreditManager.Presentacion.Formulario
{
    partial class FormularioInicio
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_01 = new System.Windows.Forms.Panel();
            this.contadorPrestamos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.contadorClientes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.contadorPagos = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.contadorEmpleados = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ControlFechaHora = new System.Windows.Forms.Timer(this.components);
            this.txtHora = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pnl_01);
            this.panel1.Controls.Add(this.contadorPrestamos);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(11, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 93);
            this.panel1.TabIndex = 0;
            // 
            // pnl_01
            // 
            this.pnl_01.BackColor = System.Drawing.Color.SeaGreen;
            this.pnl_01.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_01.Location = new System.Drawing.Point(0, 76);
            this.pnl_01.Name = "pnl_01";
            this.pnl_01.Size = new System.Drawing.Size(178, 15);
            this.pnl_01.TabIndex = 4;
            // 
            // contadorPrestamos
            // 
            this.contadorPrestamos.AutoSize = true;
            this.contadorPrestamos.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.contadorPrestamos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.contadorPrestamos.Location = new System.Drawing.Point(5, 23);
            this.contadorPrestamos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contadorPrestamos.Name = "contadorPrestamos";
            this.contadorPrestamos.Size = new System.Drawing.Size(29, 32);
            this.contadorPrestamos.TabIndex = 6;
            this.contadorPrestamos.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(7, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prestamos registrados:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.contadorClientes);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(197, 11);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(179, 93);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 76);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(177, 15);
            this.panel5.TabIndex = 8;
            // 
            // contadorClientes
            // 
            this.contadorClientes.AutoSize = true;
            this.contadorClientes.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.contadorClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.contadorClientes.Location = new System.Drawing.Point(5, 23);
            this.contadorClientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contadorClientes.Name = "contadorClientes";
            this.contadorClientes.Size = new System.Drawing.Size(29, 32);
            this.contadorClientes.TabIndex = 7;
            this.contadorClientes.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Clientes registrados:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.contadorPagos);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(382, 11);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 93);
            this.panel3.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Orange;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 76);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(178, 15);
            this.panel6.TabIndex = 9;
            // 
            // contadorPagos
            // 
            this.contadorPagos.AutoSize = true;
            this.contadorPagos.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.contadorPagos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.contadorPagos.Location = new System.Drawing.Point(5, 23);
            this.contadorPagos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contadorPagos.Name = "contadorPagos";
            this.contadorPagos.Size = new System.Drawing.Size(29, 32);
            this.contadorPagos.TabIndex = 8;
            this.contadorPagos.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(7, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pagos registrados:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.contadorEmpleados);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(568, 11);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(180, 93);
            this.panel4.TabIndex = 3;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Brown;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 76);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(178, 15);
            this.panel7.TabIndex = 10;
            // 
            // contadorEmpleados
            // 
            this.contadorEmpleados.AutoSize = true;
            this.contadorEmpleados.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.contadorEmpleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.contadorEmpleados.Location = new System.Drawing.Point(4, 23);
            this.contadorEmpleados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contadorEmpleados.Name = "contadorEmpleados";
            this.contadorEmpleados.Size = new System.Drawing.Size(29, 32);
            this.contadorEmpleados.TabIndex = 9;
            this.contadorEmpleados.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(4, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Empleados registrados:";
            // 
            // ControlFechaHora
            // 
            this.ControlFechaHora.Enabled = true;
            this.ControlFechaHora.Tick += new System.EventHandler(this.ControlFechaHora_Tick);
            // 
            // txtHora
            // 
            this.txtHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHora.AutoSize = true;
            this.txtHora.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtHora.Location = new System.Drawing.Point(644, 498);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(103, 19);
            this.txtHora.TabIndex = 18;
            this.txtHora.Text = "00:00:00 PM";
            // 
            // txtFecha
            // 
            this.txtFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFecha.AutoSize = true;
            this.txtFecha.Font = new System.Drawing.Font("Arial", 12F);
            this.txtFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtFecha.Location = new System.Drawing.Point(8, 499);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(90, 18);
            this.txtFecha.TabIndex = 19;
            this.txtFecha.Text = "Cargando...";
            // 
            // FormularioInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 526);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormularioInicio";
            this.Text = "FormularioInicio";
            this.Load += new System.EventHandler(this.FormularioInicio_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label contadorPrestamos;
        private System.Windows.Forms.Label contadorClientes;
        private System.Windows.Forms.Label contadorPagos;
        private System.Windows.Forms.Label contadorEmpleados;
        private System.Windows.Forms.Panel pnl_01;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Timer ControlFechaHora;
        private System.Windows.Forms.Label txtHora;
        private System.Windows.Forms.Label txtFecha;
    }
}