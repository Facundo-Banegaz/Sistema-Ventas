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
    public partial class FrmAgregarEditarArticulo : Form
    {
        private Articulo _Articulo = null;
        public FrmAgregarEditarArticulo()
        {
            InitializeComponent();
            Text = "Agregar Articulo";
        }
        public FrmAgregarEditarArticulo(Articulo articulo)
        {
            InitializeComponent();
            Text = "Agregar Articulo";
            this._Articulo = new Articulo();
        }
        private void FrmAgregarEditarArticulo_Load(object sender, EventArgs e)
        {
            if (_Articulo != null)
            {
                //MostrarDatos();
            }
        }



        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            //GuardarArticulo();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {

        }

        private void btn_subir_imagen_Click(object sender, EventArgs e)
        {

        }

        private void txt_url_imagen_TextChanged(object sender, EventArgs e)
        {
            CN_Metodos _Metodos = new CN_Metodos();

            _Metodos.CargarImg(pbx_img, txt_url_imagen.Text);
        }


        //private void MostrarDatos()
        //{

        //    txt_id_articulo.Text = _Articulo.Id_articulo.ToString();
        //    txt_codigo_producto.Text = _Articulo.Codigo;
        //    txt_nombre_producto.Text = _Articulo.Nombre;
        //    txt_url_imagen.Text = _Articulo.UrlImagen;
        //    txt_descripcion_producto.Text = _Articulo.Descripcion;
        //}

        //private void GuardarArticulo()
        //{
        //    CN_Articulo _CN_Articulo = new CN_Articulo();

        //    try
        //    {

        //        if (ValidarVacio())
        //        {
        //            errorIcono.Clear();

        //            if (_Categoria == null)
        //                _Categoria = new Categoria();

        //            _Categoria.Nombre = txt_nombre_categoria.Text.Trim().ToUpper();
        //            _Categoria.Descripcion = txt_descripcion_categoria.Text.Trim();
        //            _Categoria.UrlImagen = txt_imagen.Text.Trim();


        //            if (_Categoria.Id_categoria != 0)
        //            {
        //                _Categoria.Id_categoria = int.Parse(lbl_categoria.Text.Trim());
        //                logicaCategoria.EditarCategoria(_Categoria);
        //                MessageBox.Show("La Categoria Fue Modificada Exitosamente!!", "Modificado");
        //                this.Close();
        //            }
        //            else
        //            {
        //                logicaCategoria.InsertarCategoria(_Categoria);
        //                MessageBox.Show("La Categoria Fue Agregada Exitosamente!!", "Agregado");
        //                this.Close();
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Debe Completar Todos los Campos!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }


        //}

        //private bool ValidarVacio()
        //{

        //    bool error = true;

        //    if (txt_nombre_producto.Text == string.Empty)
        //    {
        //        errorIcono.SetError(txt_nombre_categoria, "El campo  es obligatorio, ingrese el Nombre ");


        //        error = false;
        //    }
        //    else
        //    {
        //        errorIcono.Clear();
        //    }

        //    return error;
        //}

    }
}
