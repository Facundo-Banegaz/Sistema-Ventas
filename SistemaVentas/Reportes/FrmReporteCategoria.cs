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
    public partial class FrmReporteCategoria : Form
    {
        public FrmReporteCategoria()
        {
            InitializeComponent();
        }

        private void FrmReporteCategoria_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.SpMostrar_categoria' Puede moverla o quitarla según sea necesario.
            this.spMostrar_categoriaTableAdapter.Fill(this.dsPrincipal.SpMostrar_categoria);

            this.reportViewer1.RefreshReport();
        }
    }
}
