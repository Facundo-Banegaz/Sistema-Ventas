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
    public partial class FrmReporteStock : Form
    {
        public FrmReporteStock()
        {
            InitializeComponent();
        }

        private void FrmReporteStock_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.SpReporte_stock' Puede moverla o quitarla según sea necesario.
            this.spReporte_stockTableAdapter.Fill(this.dsPrincipal.SpReporte_stock);

            this.reportViewer1.RefreshReport();
        }
    }
}
