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
    public partial class FrmAgregarEditarPresentacion : Form
    {

        private Presentacion _Presentacion;
        public FrmAgregarEditarPresentacion()
        {
            InitializeComponent();
            Text = "Agregar Presentación";
        }
        public FrmAgregarEditarPresentacion(Presentacion presentacion)
        {
            InitializeComponent();
            this._Presentacion = presentacion;
            Text = "Editar Presentación";
        }
        private void FrmAgregarEditarPresentacion_Load(object sender, EventArgs e)
        {
            if (_Presentacion != null)
            {
                MostrarDatos();
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            GuardarPresentacion(); 
        }

        private void GuardarPresentacion()
        {
            CN_Presentacion logicaPresentacion = new CN_Presentacion();

            try
            {

                if (ValidarVacio())
                {
                    errorIcono.Clear();

                    if (_Presentacion == null)
                        _Presentacion = new Presentacion();

                    _Presentacion.Nombre = txt_nombre_presentacion.Text.Trim().ToUpper();
                    _Presentacion.Descripcion = txt_descripcion_presentacion.Text.Trim();



                    if (_Presentacion.Id_presentacion != 0)
                    {
                        _Presentacion.Id_presentacion = int.Parse(lbl_id.Text.Trim());
                        logicaPresentacion.EditarCategoria(_Presentacion);
                        MessageBox.Show("La Presentacion Fue Modificada Exitosamente!!", "Modificado");
                        this.Close();
                    }
                    else
                    {
                        logicaPresentacion.InsertarCategoria(_Presentacion);
                        MessageBox.Show("La Presentacion Fue Agregada Exitosamente!!", "Agregado");
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

        private void MostrarDatos()
        {
            lbl_id.Text = _Presentacion.Id_presentacion.ToString();
            txt_nombre_presentacion.Text = _Presentacion.Nombre;
            txt_descripcion_presentacion.Text = _Presentacion.Descripcion;
        }
        private bool ValidarVacio()
        {

            bool error = true;

            if (txt_nombre_presentacion.Text == string.Empty)
            {
                errorIcono.SetError(txt_nombre_presentacion, "El campo  es obligatorio, ingrese el Nombre ");


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
