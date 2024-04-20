using CapaDominio;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas
{
    public partial class FrmAgregarEditarTrabajador : Form
    {


        private Trabajador _Trabajador = null;
        private OpenFileDialog archivo = null;


        public FrmAgregarEditarTrabajador()
        {
            InitializeComponent();
            Text = "Cargar Trabajador";

        }

        public FrmAgregarEditarTrabajador(Trabajador trabajador)
        {
            InitializeComponent();

            this._Trabajador = trabajador;
            Text = "Editar Trabajador";
        }


        private void FrmAgregarEditarTrabajador_Load(object sender, EventArgs e)
        {
            MostrarDatos();
            CargarCboSexo();
            CargarCboAcceso();
        }






        private void CargarCboAcceso()
        {

            // Añade "Seleccionar sexo" como un elemento en el ComboBox
            cbo_acceso.Items.Add("SELECCIONAR ACCESO");

            // Añade los otros elementos (masculino, femenino, otro)
            cbo_acceso.Items.Add("ADMINISTRADOR");
            cbo_acceso.Items.Add("VENDEDOR");
            cbo_acceso.Items.Add("ALMACENERO");

            // Establece "Seleccionar sexo" como el elemento predeterminado
            cbo_acceso.SelectedIndex = 0;

            // Deshabilita la selección del elemento "Seleccionar sexo"
            cbo_acceso.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void CargarCboSexo()
        {



            // Añade "Seleccionar sexo" como un elemento en el ComboBox
            cbo_sexo.Items.Add("SELECCIONAR SEXO");

            // Añade los otros elementos (masculino, femenino, otro)
            cbo_sexo.Items.Add("MASCULINO");
            cbo_sexo.Items.Add("FEMENINO");
            cbo_sexo.Items.Add("OTRO");

            // Establece "Seleccionar sexo" como el elemento predeterminado
            cbo_sexo.SelectedIndex = 0;

            // Deshabilita la selección del elemento "Seleccionar sexo"
            cbo_sexo.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        private void MostrarDatos()
        {



            try
            {


                if (_Trabajador != null)
                {


                    txt_id_trabajador.Text = _Trabajador.Id_trabajador.ToString();
                    txt_nombre.Text = _Trabajador.Nombre;
                    txt_apellido.Text = _Trabajador.Apellido;
                    dtp_fecha_nacimiento.Value = _Trabajador.FechaNacimiento;
                    txt_url_imagen.Text = _Trabajador.UrlImagen;
                    txt_telefono.Text = _Trabajador.Telefono;
                    txt_direccion_trabajado.Text = _Trabajador.Direccion;
                    txt_email.Text = _Trabajador.Email;
                    cbo_acceso.SelectedValue = _Trabajador.Acceso;
                    cbo_sexo.SelectedValue = _Trabajador.Sexo;
                    txt_url_imagen.Text = _Trabajador.UrlImagen;
                    txt_numero_documento.Text = _Trabajador.NumeroDocumento;
                    txt_usuario.Text = _Trabajador.Usuario;
                    txt_clave.Text = _Trabajador.Clave;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
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

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            GuardarTrabajador();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_url_imagen_TextChanged(object sender, EventArgs e)
        {
            CN_Metodos _Metodos = new CN_Metodos();


            _Metodos.CargarImg(pbx_img, txt_url_imagen.Text);
        }


        private void GuardarTrabajador()
        {
            CN_Trabajador _CN_Trabajador = new CN_Trabajador();

            try
            {

                if (ValidarVacio())
                {
                    errorIcono.Clear();

                    if (_Trabajador == null)

                        _Trabajador = new Trabajador();

                    _Trabajador.Nombre = txt_nombre.Text.Trim().ToUpper();
                    _Trabajador.Apellido = txt_apellido.Text.Trim().ToUpper();
                    _Trabajador.Sexo = cbo_sexo.Text.ToString();
                    _Trabajador.FechaNacimiento = dtp_fecha_nacimiento.Value;
                    _Trabajador.NumeroDocumento = txt_numero_documento.Text.Trim();
                    _Trabajador.Direccion = txt_direccion_trabajado.Text.Trim().ToUpper();
                    _Trabajador.Telefono = txt_telefono.Text.Trim();
                    _Trabajador.Email = txt_email.Text.Trim();
                    _Trabajador.UrlImagen = txt_url_imagen.Text;
                    _Trabajador.Acceso = cbo_acceso.Text.ToString().Trim().ToUpper();
                    _Trabajador.Usuario = txt_usuario.Text.Trim();
                    _Trabajador.Clave = txt_clave.Text.Trim();



                    if (_Trabajador.Id_trabajador != 0)
                    {

                        _CN_Trabajador.EditarTrabajador(_Trabajador);
                        MessageBox.Show("El Trabajador Fue Modificado Exitosamente!!", "Modificado");
                        this.Close();
                    }
                    else
                    {
                        _CN_Trabajador.InsertarTrabajador(_Trabajador);
                        MessageBox.Show("El Trabajador Fue Agregado Exitosamente!!", "Agregado");
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

                // Maneja la excepción mostrando un mensaje al usuario y registrándola
                MessageBox.Show("Se produjo un error al guardar el cliente. Por favor, inténtelo de nuevo más tarde.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Registra el error en algún lugar (por ejemplo, un archivo de registro)
                Console.WriteLine("Error al guardar cliente: " + ex.Message);
            }


        }


        public static bool validarEmail(string pCorreo)
        {
            return pCorreo != null && Regex.IsMatch(pCorreo, @"^[^@\s]+@[^@\s]+\.(com)$");
        }

        private bool ValidarVacio()
        {
            bool error = true;

            if (cbo_sexo.SelectedIndex == 0)
            {
                MessageBox.Show("Por favor, seleccione el sexo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cbo_acceso.SelectedIndex == 0)
            {
                MessageBox.Show("Por favor, seleccione el Tipo de Acceso.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txt_nombre.Text == string.Empty)
            {
                errorIcono.SetError(txt_nombre, "El campo es obligatorio, ingrese el Nombre");
                error = false;
            }
            if (txt_apellido.Text == string.Empty)
            {
                errorIcono.SetError(txt_apellido, "El campo es obligatorio, ingrese el Apellido");
                error = false;
            }
            if (txt_numero_documento.Text == string.Empty)
            {
                errorIcono.SetError(txt_numero_documento, "El campo es obligatorio, ingrese el Numero de Documento");
                error = false;
            }
            if (dtp_fecha_nacimiento.Value == DateTime.MinValue)
            {
                errorIcono.SetError(dtp_fecha_nacimiento, "Debe completar el campo Fecha!!");
                error = false;
            }
            if (txt_direccion_trabajado.Text == string.Empty)
            {
                errorIcono.SetError(txt_direccion_trabajado, "El campo es obligatorio, ingrese la Direccion");
                error = false;
            }
            if (txt_telefono.Text == string.Empty)
            {
                errorIcono.SetError(txt_telefono, "El campo es obligatorio, ingrese el Telefono");
                error = false;
            }

            if (txt_email.Text == string.Empty)
            {
                errorIcono.SetError(txt_email, "El campo es obligatorio, ingrese el Email");
                error = false;
            }
            if (txt_url_imagen.Text == string.Empty)
            {
                errorIcono.SetError(txt_url_imagen, "El campo es obligatorio, ingrese la Url de la imagen");
                error = false;
            }
            if (txt_usuario.Text == string.Empty)
            {
                errorIcono.SetError(txt_nombre, "El campo es obligatorio, ingrese el Nombre de Usuario");
                error = false;
            }
            if (txt_clave.Text == string.Empty)
            {
                errorIcono.SetError(txt_apellido, "El campo es obligatorio, ingrese la Contraseña");
                error = false;
            }
            else
            {
                errorIcono.Clear();
            }

            return error;
        }

        private void txt_numero_documento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void dtp_fecha_nacimiento_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaNacimiento = dtp_fecha_nacimiento.Value;
            int edadMinimaRequerida = 18;

            // Calcular la edad actual
            int edad = DateTime.Today.Year - fechaNacimiento.Year;
            if (DateTime.Today < fechaNacimiento.AddYears(edad))
                edad--;

            // Validar la edad mínima requerida
            if (edad < edadMinimaRequerida)
            {
                MessageBox.Show("Debes tener al menos 18 años para registrarte.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }






        private void txt_email_TextChanged(object sender, EventArgs e)
        {
            if (!validarEmail(txt_email.Text))
            {
            
                errorIcono.SetError(txt_email, "El correo electrónico no es válido.");
            }
            else
            {
                errorIcono.Clear();
            }
        }

        private void txt_email_Leave(object sender, EventArgs e)
        {
            if (!validarEmail(txt_email.Text))
            {
                MessageBox.Show("Por favor, ingrese un correo electrónico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);   

            }

        }

        private void txt_numero_documento_TextChanged(object sender, EventArgs e)
        {
            CN_Trabajador _Trabajador = new CN_Trabajador();

            // Llama al método ValidarCliente para verificar si el cliente ya existe
            bool TrabajadorExistente = _Trabajador.ValidarTrabajador(txt_numero_documento.Text);

            // Si el cliente ya existe, muestra un mensaje de advertencia
            if (TrabajadorExistente)
            {
                DialogResult respuesta = MessageBox.Show("El Articulo ya existe. Si es una Modificacion Ignora el mensaje!!", "Si desea limpiar el campo presione SI ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    txt_numero_documento.Clear();
                }
            }

            
        }
    }
}
