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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaVentas
{
    public partial class FrmAgregarEditarArticulo : Form
    {
        private Articulo _Articulo = null;
        private OpenFileDialog archivo = null;
        public FrmAgregarEditarArticulo()
        {
            InitializeComponent();
            Text = "Agregar Articulo";
        }
        public FrmAgregarEditarArticulo(Articulo articulo)
        {
            InitializeComponent();
            Text = "Modificar Articulo";
            this._Articulo= articulo;

        }
        private void FrmAgregarEditarArticulo_Load(object sender, EventArgs e)
        {
            MostrarDatos();
            
        }



        private void btn_cancelar_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            GuardarArticulo();
        }

        private void btn_subir_imagen_Click(object sender, EventArgs e)
        {
            CN_Metodos _Metodos = new CN_Metodos();
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txt_url_imagen.Text = archivo.FileName;


                _Metodos.CargarImg(pbx_img, archivo.FileName);

            }
        }

        private void txt_url_imagen_TextChanged(object sender, EventArgs e)
        {
            CN_Metodos _Metodos = new CN_Metodos();

            _Metodos.CargarImg(pbx_img, txt_url_imagen.Text);
        }


        private void MostrarDatos()
        {

            CN_Categoria categoria = new CN_Categoria();
            CN_Presentacion presentacion = new CN_Presentacion();   


            try
            {
                cbo_presentacion_producto.DataSource = presentacion.CargarCbo();
                cbo_presentacion_producto.ValueMember = "Id_presentacion";
                cbo_presentacion_producto.DisplayMember = "Nombre";

                cbo_tipo_categoria.DataSource = categoria.CargarCbo();
                cbo_tipo_categoria.ValueMember = "Id_categoria";
                cbo_tipo_categoria.DisplayMember = "Nombre";

                if (_Articulo != null)
                {


                    txt_id_articulo.Text = _Articulo.Id_articulo.ToString();
                    txt_codigo_producto.Text = _Articulo.Codigo;
                    txt_nombre_producto.Text = _Articulo.Nombre;
                    txt_url_imagen.Text = _Articulo.UrlImagen;
                    txt_descripcion_producto.Text = _Articulo.Descripcion;

                    cbo_tipo_categoria.SelectedValue = _Articulo.Categoria.Id_categoria;
                    cbo_presentacion_producto.SelectedValue = _Articulo.Presentacion.Id_presentacion;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void GuardarArticulo()
        {
            CN_Articulo _CN_Articulo = new CN_Articulo();

            try
            {

                if (ValidarVacio())
                {
                    errorIcono.Clear();

                    if (_Articulo == null)

                        _Articulo = new Articulo();

                    _Articulo.Codigo = txt_codigo_producto.Text.Trim().ToUpper();
                    _Articulo.Nombre = txt_nombre_producto.Text.Trim().ToUpper();
                    _Articulo.Descripcion = txt_descripcion_producto.Text.Trim();
                    _Articulo.UrlImagen = txt_url_imagen.Text.Trim();

                    _Articulo.Categoria = (Categoria)cbo_tipo_categoria.SelectedItem;
                    _Articulo.Presentacion = (Presentacion)cbo_presentacion_producto.SelectedItem;


                    if (_Articulo.Id_articulo != 0)
                    {
                        _CN_Articulo.EditarArticulo(_Articulo);
                        MessageBox.Show("La Categoria Fue Modificada Exitosamente!!", "Modificado");
                        this.Close();
                    }
                    else
                    {
                        _CN_Articulo.InsertarArticulo(_Articulo);
                        MessageBox.Show("La Categoria Fue Agregada Exitosamente!!", "Agregado");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Debe Completar Todos los Campos!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        private bool ValidarVacio()
        {

            bool error = true;

            if (txt_nombre_producto.Text == string.Empty)
            {
                errorIcono.SetError(txt_nombre_producto, "El campo  es obligatorio, ingrese el Nombre ");


                error = false;
            }
            else if (txt_codigo_producto.Text == string.Empty)
            {
                errorIcono.SetError(txt_codigo_producto, "El campo  es obligatorio, ingrese el Codigo ");


                error = false;
            }
            else if (txt_url_imagen.Text == string.Empty)
            {
                errorIcono.SetError(txt_codigo_producto, "El campo  es obligatorio, ingrese la Url de la imagen ");


                error = false;
            }
            else
            {
                errorIcono.Clear();
            }

            return error;
        }

    }
}
