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
    public partial class FrmAgregarEditarCategoria : Form
    {
        private Categoria _Categoria = null;
        public FrmAgregarEditarCategoria()
        {
            InitializeComponent();
            Text = "Agregar Categoria";
        }

        public FrmAgregarEditarCategoria(Categoria categoria)
        {
            InitializeComponent();
            this._Categoria = categoria;
            Text = "Editar Categoria";
        }

        private void FrmAgregarEditarCategoria_Load(object sender, EventArgs e)
        {
            if (_Categoria != null)
            {
                MostrarDatos();
            }
        }
        private void GuardarCategoria()
        {
            CN_Categoria logicaCategoria = new CN_Categoria();

            try
            {

                if (ValidarVacio())
                {
                    errorIcono.Clear();

                    if (_Categoria == null)
                        _Categoria = new Categoria();

                    _Categoria.Nombre = txt_nombre_categoria.Text.Trim().ToUpper();
                    _Categoria.Descripcion = txt_descripcion_categoria.Text.Trim();
                    _Categoria.UrlImagen = txt_imagen.Text.Trim();


                    if (_Categoria.Id_categoria != 0)
                    {
                        _Categoria.Id_categoria = int.Parse(lbl_categoria.Text.Trim());
                        logicaCategoria.EditarCategoria(_Categoria);
                        MessageBox.Show("La Categoria Fue Modificada Exitosamente!!", "Modificado");
                        this.Close();
                    }
                    else
                    {
                        logicaCategoria.InsertarCategoria(_Categoria);
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

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            GuardarCategoria();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MostrarDatos()
        {          
                lbl_categoria.Text =  _Categoria.Id_categoria.ToString();
                txt_nombre_categoria.Text = _Categoria.Nombre;
                txt_imagen.Text = _Categoria.UrlImagen;
                txt_descripcion_categoria.Text = _Categoria.Descripcion;   
        }
        private void txt_imagen_TextChanged(object sender, EventArgs e)
        {
            CN_Metodos _Metodos = new CN_Metodos();

            _Metodos.CargarImg(pbx_img, txt_imagen.Text);
        }

        private bool ValidarVacio()
        {

            bool error = true;

            if (txt_nombre_categoria.Text == string.Empty)
            {
                errorIcono.SetError(txt_nombre_categoria, "El campo  es obligatorio, ingrese el Nombre ");


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
