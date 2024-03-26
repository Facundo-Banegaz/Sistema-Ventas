using CapaDominio;
using CapaNegocio;
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


        private Trabajador _Trabajador;

        public FrmPrincipal()
        {
            InitializeComponent();
            
        }
        public FrmPrincipal( Trabajador trabajador)
        {
            InitializeComponent();
            this._Trabajador = trabajador;
            Text = $"¡¡Bienvenido al Sistema de Ventas {_Trabajador.Nombre} {_Trabajador.Apellido}!! Nombre de  Usuario: ''{_Trabajador.Usuario}'' | Acceso: ''{_Trabajador.Acceso}''.";

            CN_Metodos _Metodos = new CN_Metodos();
            _Metodos.CargarImg(pbx_img, trabajador.UrlImagen);
            pbx_img.Anchor = AnchorStyles.None; // Desanclar el PictureBox
            pbx_img.Location = new Point((this.Width - pbx_img.Width) / 2, (this.Height - pbx_img.Height) / 2);

        }




        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            GestionUsuario();

            lbl_trabajador.Text =  $"¡¡Bienvenido  {_Trabajador.Nombre} {_Trabajador.Apellido}!! Nombre de  Usuario: ''{_Trabajador.Usuario}'' | Acceso: ''{_Trabajador.Acceso}''.";

        }

        private void GestionUsuario()
        {
            if (_Trabajador.Acceso == "ADMINISTRADOR")
            {
                this.Menu_almacen.Enabled = true;
                this.Menu_gestion_compras.Enabled = true;
                this.Menu_gestion_ventas.Enabled = true;
                this.Menu_consultas.Enabled = true;
                this.Menu_mantenimiento.Enabled = true;
                this.Menu_herramientas.Enabled = true;
                this.Menu_secundario_compras.Enabled=true;
                this.Menu_secundario_ventas.Enabled=true;
            }

            else if(_Trabajador.Acceso == "VENDEDOR")
            {
                this.Menu_almacen.Enabled = false;
                this.Menu_gestion_compras.Enabled = false;
                this.Menu_gestion_ventas.Enabled = true;
                this.Menu_consultas.Enabled = true;
                this.Menu_mantenimiento.Enabled = false;
                this.Menu_herramientas.Enabled = true;
                this.Menu_secundario_compras.Enabled = false;
                this.Menu_secundario_ventas.Enabled = true;
            }
            else if (_Trabajador.Acceso == "ALMACENERO")
            {
                this.Menu_almacen.Enabled = true;
                this.Menu_gestion_compras.Enabled = true;
                this.Menu_gestion_ventas.Enabled = false;
                this.Menu_consultas.Enabled = true;
                this.Menu_mantenimiento.Enabled = false;
                this.Menu_herramientas.Enabled = true;
                this.Menu_secundario_compras.Enabled = true;
                this.Menu_secundario_ventas.Enabled = false;
            }

            else
            {
                this.Menu_almacen.Enabled = false;
                this.Menu_gestion_compras.Enabled = false;
                this.Menu_gestion_ventas.Enabled = false;
                this.Menu_consultas.Enabled = false;
                this.Menu_mantenimiento.Enabled = false;
                this.Menu_herramientas.Enabled = false;
                this.Menu_secundario_compras.Enabled = false;
                this.Menu_secundario_ventas.Enabled = false;

            }
        }
        private void tn_tiempo_Tick(object sender, EventArgs e)
        {
            lbl_hora.Text = DateTime.Now.ToString("HH:mm:ss tt", CultureInfo.InvariantCulture);
            lbl_fecha.Text = DateTime.Now.ToLongDateString();
        }

        //menu almacen
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


        // Menu compras

        private void Menu_item_ingresos_Click(object sender, EventArgs e)
        {
            FrmIngreso frmIngreso = new FrmIngreso();   
            frmIngreso.ShowDialog();
        }

        private void Menu_item_proveedores_Click(object sender, EventArgs e)
        {
            FrmProveedor frmProveedor = new FrmProveedor();
            frmProveedor.ShowDialog();
        }

        //menu ventas



        private void Menu_item_clientes_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new FrmCliente();

            frmCliente.ShowDialog();
        }
        private void Menu_item_ventas_Click(object sender, EventArgs e)
        {

        }

        //menu mantenimiento


        private void menu_item_trabajador_Click(object sender, EventArgs e)
        {
            FrmTrabajador frmTrabajador = new FrmTrabajador();
            frmTrabajador.ShowDialog();

        }

        private void Menu_item_salir_Click(object sender, EventArgs e)
        {

            DialogResult respuesta = MessageBox.Show($"¿Estás seguro de que deseas salir del sistema {_Trabajador.Nombre} {_Trabajador.Apellido}? Nombre de  Usuario: ''{_Trabajador.Usuario}'' | Acceso: ''{_Trabajador.Acceso}''.", "Salir del Sistema de Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            } 

        }
    }
}
