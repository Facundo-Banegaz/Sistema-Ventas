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
    public partial class FrmReporteProveedor : Form
    {
        public FrmReporteProveedor()
        {
            InitializeComponent();
        }

        private void FrmReporteProveedor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.spMostrar_proveedor' Puede moverla o quitarla según sea necesario.
            this.spMostrar_proveedorTableAdapter.Fill(this.dsPrincipal.spMostrar_proveedor);

            this.reportViewer1.RefreshReport();
        }
    }
}
