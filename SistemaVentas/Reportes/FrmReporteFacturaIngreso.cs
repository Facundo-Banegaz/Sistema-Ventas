using CapaDominio;
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
    public partial class FrmReporteFacturaIngreso : Form
    {
        public int Id_ingreso { get; set; }
        public FrmReporteFacturaIngreso()
        {
            InitializeComponent();
        }
        public FrmReporteFacturaIngreso(Ingreso ingreso)
        {
            InitializeComponent();
            this.Id_ingreso = ingreso.Id_ingreso;
        }
        private void FrmReporteFacturaIngreso_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.SpReporte_factura' Puede moverla o quitarla según sea necesario.
                this.spReporte_factura_ingresoTableAdapter.Fill(this.dsPrincipal.SpReporte_factura_ingreso, Id_ingreso);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {

                this.reportViewer1.RefreshReport();
            }

        }
    }
}
