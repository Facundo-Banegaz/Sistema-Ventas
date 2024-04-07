namespace SistemaVentas
{
    partial class FrmReporteFactura
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
            this.SpReporte_facturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPrincipal = new SistemaVentas.DsPrincipal();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spReporte_facturaTableAdapter = new SistemaVentas.DsPrincipalTableAdapters.SpReporte_facturaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SpReporte_facturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // SpReporte_facturaBindingSource
            // 
            this.SpReporte_facturaBindingSource.DataMember = "SpReporte_factura";
            this.SpReporte_facturaBindingSource.DataSource = this.dsPrincipal;
            // 
            // dsPrincipal
            // 
            this.dsPrincipal.DataSetName = "DsPrincipal";
            this.dsPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Factura";
            reportDataSource1.Value = this.SpReporte_facturaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaVentas.Reportes.RptComprobanteFactura.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1657, 829);
            this.reportViewer1.TabIndex = 0;
            // 
            // spReporte_facturaTableAdapter
            // 
            this.spReporte_facturaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1657, 829);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporteFactura";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.FrmReporteFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SpReporte_facturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DsPrincipal dsPrincipal;
        private DsPrincipalTableAdapters.SpReporte_facturaTableAdapter spReporte_facturaTableAdapter;
        private System.Windows.Forms.BindingSource SpReporte_facturaBindingSource;
    }
}