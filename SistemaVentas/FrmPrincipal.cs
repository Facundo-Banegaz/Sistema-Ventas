using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }



        private void tn_tiempo_Tick(object sender, EventArgs e)
        {
            lbl_hora.Text = DateTime.Now.ToString("HH:mm:ss tt", CultureInfo.InvariantCulture);
            lbl_fecha.Text = DateTime.Now.ToLongDateString();
        }

        private void menu_item_categorias_Click(object sender, EventArgs e)
        {
            FrmCategoria frmCategoria = new FrmCategoria(); 
            frmCategoria.ShowDialog();
        }

        private void menu_item_articulos_Click(object sender, EventArgs e)
        {
            FrmArticulo frmArticulo = new FrmArticulo();
            frmArticulo.ShowDialog();
        }



        private void menu_item_presentacion_Click(object sender, EventArgs e)
        {
            FrmPresentacion frmPresentacion = new FrmPresentacion();
            frmPresentacion.ShowDialog();
        }



        

        private void menu_persona_Click(object sender, EventArgs e)
        {
            FrmTrabajador frmPersona = new FrmTrabajador();   
            frmPersona.ShowDialog();
        }

        private void menu_item_proveedor_Click(object sender, EventArgs e)
        {
            FrmProveedor frmProveedor = new FrmProveedor();
            frmProveedor.ShowDialog();
        }

        private void menu_item_cliente_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new FrmCliente();

            frmCliente.ShowDialog();
        }





        private void lbl_hora_Click(object sender, EventArgs e)
        {

        }

        private void lbl_fecha_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
