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

namespace SistemaVentas
{
    public partial class FrmReporteFactura : Form
    {
        public int Id_venta { get; set; }

        public FrmReporteFactura()
        {
            InitializeComponent();
        }
        public FrmReporteFactura(Venta venta)
        {
            InitializeComponent();
            this.Id_venta = venta.Id_venta;
        }



        private void FrmReporteFactura_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.SpReporte_factura' Puede moverla o quitarla según sea necesario.
                this.spReporte_facturaTableAdapter.Fill(this.dsPrincipal.SpReporte_factura, Id_venta);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {

                this.reportViewer1.RefreshReport();
            }

        }
    }
}
