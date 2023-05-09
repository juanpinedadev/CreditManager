namespace CreditManager.Presentacion.Reporte.Formularios
{
    partial class ReporteEmpleado
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetMaestro = new CreditManager.Presentacion.Reporte.DataSet.DataSetMaestro();
            this.listarEmpleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listarEmpleadosTableAdapter = new CreditManager.Presentacion.Reporte.DataSet.DataSetMaestroTableAdapters.ListarEmpleadosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMaestro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarEmpleadosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.listarEmpleadosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CreditManager.Presentacion.Reporte.Diseño.InformeEmpleado.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(684, 567);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSetMaestro
            // 
            this.dataSetMaestro.DataSetName = "DataSetMaestro";
            this.dataSetMaestro.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listarEmpleadosBindingSource
            // 
            this.listarEmpleadosBindingSource.DataMember = "ListarEmpleados";
            this.listarEmpleadosBindingSource.DataSource = this.dataSetMaestro;
            // 
            // listarEmpleadosTableAdapter
            // 
            this.listarEmpleadosTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 567);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "ReporteEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteEmpleado";
            this.Load += new System.EventHandler(this.ReporteEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMaestro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarEmpleadosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSet.DataSetMaestro dataSetMaestro;
        private System.Windows.Forms.BindingSource listarEmpleadosBindingSource;
        private DataSet.DataSetMaestroTableAdapters.ListarEmpleadosTableAdapter listarEmpleadosTableAdapter;
    }
}