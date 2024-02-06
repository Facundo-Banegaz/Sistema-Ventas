using CapaDominio;
using CapaNegocio;
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
    public partial class FrmDetalleArticulo : Form
    {
        private Articulo _Articulo;
        public FrmDetalleArticulo()
        {
            InitializeComponent();
        }
        public FrmDetalleArticulo(Articulo articulo)
        {
            InitializeComponent();
            Text = "Detalle del Producto";
            this._Articulo = articulo;
        }

        private void FrmDetalleArticulo_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void MostrarDatos()
        {
            txt_id_articulo.Text = _Articulo.Id_articulo.ToString();
            txt_codigo_producto.Text = _Articulo.Codigo.ToString();
            txt_nombre_producto.Text = _Articulo.Nombre;
             txt_codigo_producto.Text = _Articulo.Codigo;
            txt_url_imagen.Text = _Articulo.UrlImagen;
            txt_descripcion_producto.Text = _Articulo.Descripcion;
            txt_presentacion.Text = _Articulo.Presentacion.Nombre.ToString();
            txt_categoria.Text = _Articulo.Categoria.Nombre.ToString();
        }

        private void txt_url_imagen_TextChanged(object sender, EventArgs e)
        {
            CN_Metodos _Metodos = new CN_Metodos();

            _Metodos.CargarImg(pbx_img,txt_url_imagen.Text);

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
