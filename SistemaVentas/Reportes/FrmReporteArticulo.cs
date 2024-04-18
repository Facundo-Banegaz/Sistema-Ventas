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
    public partial class FrmReporteArticulo : Form
    {
        public FrmReporteArticulo()
        {
            InitializeComponent();
        }

        private void FrmReporteArticulo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.SpMostrar_articulo' Puede moverla o quitarla según sea necesario.
            this.spMostrar_articuloTableAdapter.Fill(this.dsPrincipal.SpMostrar_articulo);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
