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
    public partial class FrmReporteTrabajador : Form
    {
        public FrmReporteTrabajador()
        {
            InitializeComponent();
        }

        private void FrmReporteTrabajador_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.SpMostrar_trabajador' Puede moverla o quitarla según sea necesario.
            this.spMostrar_trabajadorTableAdapter.Fill(this.dsPrincipal.SpMostrar_trabajador);

            this.reportViewer1.RefreshReport();
        }
    }
}
