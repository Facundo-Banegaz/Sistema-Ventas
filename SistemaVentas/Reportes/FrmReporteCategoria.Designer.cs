namespace SistemaVentas.Reportes
{
    partial class FrmReporteCategoria
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
            this.spMostrarcategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPrincipal = new SistemaVentas.DsPrincipal();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spMostrar_categoriaTableAdapter = new SistemaVentas.DsPrincipalTableAdapters.SpMostrar_categoriaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spMostrarcategoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // spMostrarcategoriaBindingSource
            // 
            this.spMostrarcategoriaBindingSource.DataMember = "SpMostrar_categoria";
            this.spMostrarcategoriaBindingSource.DataSource = this.dsPrincipal;
            // 
            // dsPrincipal
            // 
            this.dsPrincipal.DataSetName = "DsPrincipal";
            this.dsPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spMostrarcategoriaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaVentas.Reportes.RptReporteCategoria.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1336, 829);
            this.reportViewer1.TabIndex = 0;
            // 
            // spMostrar_categoriaTableAdapter
            // 
            this.spMostrar_categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 829);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmReporteCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReporteCategoria";
            this.Load += new System.EventHandler(this.FrmReporteCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spMostrarcategoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DsPrincipal dsPrincipal;
        private System.Windows.Forms.BindingSource spMostrarcategoriaBindingSource;
        private DsPrincipalTableAdapters.SpMostrar_categoriaTableAdapter spMostrar_categoriaTableAdapter;
    }
}