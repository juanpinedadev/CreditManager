namespace CreditManager.Presentacion.Reporte.Formularios
{
    partial class ReporteCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteCliente));
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetMaestro = new CreditManager.Presentacion.Reporte.DataSet.DataSetMaestro();
            this.listarClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listarClientesTableAdapter = new CreditManager.Presentacion.Reporte.DataSet.DataSetMaestroTableAdapters.ListarClientesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMaestro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarClientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer
            // 
            this.reportViewer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.listarClientesBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "CreditManager.Presentacion.Reporte.Diseño.InformeCliente.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(684, 561);
            this.reportViewer.TabIndex = 0;
            // 
            // dataSetMaestro
            // 
            this.dataSetMaestro.DataSetName = "DataSetMaestro";
            this.dataSetMaestro.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listarClientesBindingSource
            // 
            this.listarClientesBindingSource.DataMember = "ListarClientes";
            this.listarClientesBindingSource.DataSource = this.dataSetMaestro;
            // 
            // listarClientesTableAdapter
            // 
            this.listarClientesTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.reportViewer);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "ReporteCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ReporteCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMaestro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarClientesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private DataSet.DataSetMaestro dataSetMaestro;
        private System.Windows.Forms.BindingSource listarClientesBindingSource;
        private DataSet.DataSetMaestroTableAdapters.ListarClientesTableAdapter listarClientesTableAdapter;
    }
}