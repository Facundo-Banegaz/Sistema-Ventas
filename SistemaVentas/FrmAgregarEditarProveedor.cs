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
    public partial class FrmAgregarEditarProveedor : Form
    {

        private Proveedor _Proveedor = null;
        private OpenFileDialog archivo = null;
        public FrmAgregarEditarProveedor()
        {
            InitializeComponent();
        }
        public FrmAgregarEditarProveedor(Proveedor proveedor)
        {
            InitializeComponent();
            this._Proveedor = proveedor;
        }

        private void FrmAgregarEditarProveedor_Load(object sender, EventArgs e)
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



            try
            {


                if (_Proveedor != null)
                {


                    txt_id_proveedor.Text = _Proveedor.Id_proveedor.ToString();
                    txt_razon_social.Text = _Proveedor.RazonSocial;
                    txt_pagina_web.Text = _Proveedor.PaginaWeb;
                    txt_sector_comercial.Text = _Proveedor.SectorComercial;
                    txt_url_imagen.Text = _Proveedor.UrlImagen;
                    txt_telefono.Text = _Proveedor.Telefono;
                    txt_direccion.Text = _Proveedor.Direccion;
                    txt_email.Text = _Proveedor.Email;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void GuardarArticulo()
        {
            CN_Proveedor _CN_Proveedor = new CN_Proveedor();

            try
            {

                if (ValidarVacio())
                {
                    errorIcono.Clear();

                    if (_Proveedor == null)

                        _Proveedor = new Proveedor();
                    //_Proveedor.Id_proveedor = int.Parse(txt_id_proveedor.Text.Trim());
                    _Proveedor.RazonSocial = txt_razon_social.Text.Trim().ToUpper();
                    _Proveedor.PaginaWeb = txt_pagina_web.Text.Trim().ToLower();
                    _Proveedor.SectorComercial = txt_sector_comercial.Text.Trim().ToUpper();
                    _Proveedor.UrlImagen = txt_url_imagen.Text.Trim().ToLower();
                    _Proveedor.Telefono = txt_telefono.Text.Trim().ToUpper();
                    _Proveedor.Direccion = txt_direccion.Text.Trim().ToUpper();
                    _Proveedor.Email = txt_email.Text.Trim().ToUpper();

                    if (_Proveedor.Id_proveedor != 0)
                    {
                        
                        _CN_Proveedor.EditarProveedor(_Proveedor);
                        MessageBox.Show("El Proveedor Fue Modificada Exitosamente!!", "Modificado");
                        this.Close();
                    }
                    else
                    {
                        _CN_Proveedor.InsertarProveedor(_Proveedor);
                        MessageBox.Show("El Proveedor Fue Agregada Exitosamente!!", "Agregado");
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

            if (txt_razon_social.Text == string.Empty)
            {
                errorIcono.SetError(txt_razon_social, "El campo  es obligatorio, ingrese el Razon Social ");


                error = false;
            }
            else if (txt_sector_comercial.Text == string.Empty)
            {
                errorIcono.SetError(txt_sector_comercial, "El campo  es obligatorio, ingrese el Sector Comercial ");


                error = false;
            }
            else if (txt_url_imagen.Text == string.Empty)
            {
                errorIcono.SetError(txt_url_imagen, "El campo  es obligatorio, ingrese la Url de la imagen ");


                error = false;
            }
            else if (txt_pagina_web.Text == string.Empty)
            {
                errorIcono.SetError(txt_pagina_web, "El campo  es obligatorio, ingrese el Numero de Documento ");


                error = false;
            }

            else if (txt_direccion.Text == string.Empty)
            {
                errorIcono.SetError(txt_direccion, "El campo  es obligatorio, ingrese la Direccion");


                error = false;
            }

            else if (txt_telefono.Text == string.Empty)
            {
                errorIcono.SetError(txt_telefono, "El campo  es obligatorio, ingrese el Telefono ");


                error = false;

            }

            
            else if (txt_email.Text == string.Empty)
            {
                errorIcono.SetError(txt_email, "El campo  es obligatorio, ingrese el Email");


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
