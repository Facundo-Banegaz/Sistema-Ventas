using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas.Reportes
{
    public partial class FrmReportePresentacion : Form
    {
        public FrmReportePresentacion()
        {
            InitializeComponent();
        }

        private void FrmReportePresentacion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.SpMostrar_presentacion' Puede moverla o quitarla según sea necesario.
            this.spMostrar_presentacionTableAdapter.Fill(this.dsPrincipal.SpMostrar_presentacion);

            this.reportViewer1.RefreshReport();
        }
    }
}
