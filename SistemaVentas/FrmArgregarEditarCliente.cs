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
    public partial class FrmArgregarEditarCliente : Form
    {
        private Cliente _Cliente = null;
        private OpenFileDialog archivo = null;
        public FrmArgregarEditarCliente()
        {
            InitializeComponent();
            Text = "Cargar Cliente";
        }
        public FrmArgregarEditarCliente(Cliente cliente)
        {
            InitializeComponent();
            this._Cliente = cliente;
            Text = "Editar Cliente";
        }
        private void FrmArgregarEditarCliente_Load(object sender, EventArgs e)
        {
            MostrarDatos();
            CargarCbo();
        }


        private void CargarCbo()
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

        private void txt_url_imagen_TextChanged(object sender, EventArgs e)
        {
            CN_Metodos _Metodos = new CN_Metodos();


            _Metodos.CargarImg(pbx_img, txt_url_imagen.Text);
        }

        private void MostrarDatos()
        {

            try
            {

                if (_Cliente != null)
                {

                    txt_id_cliente.Text = _Cliente.Id_cliente.ToString();
                    txt_nombre.Text = _Cliente.Nombre;
                    txt_apellido.Text = _Cliente.Apellido;
                    //cbo_sexo.SelectedValue = _Cliente.Sexo;
                    cbo_sexo.Text = _Cliente.Sexo;  
                    dtp_fecha_nacimiento.Text = _Cliente.FechaNacimiento.ToString();
                    txt_numero_documento.Text = _Cliente.NumeroDocumento;
                    txt_url_imagen.Text = _Cliente.UrlImagen;
                    txt_telefono.Text = _Cliente.Telefono;
                    txt_direccion.Text = _Cliente.Direccion;
                    txt_email.Text = _Cliente.Email;



                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void GuardarCliente()
        {
            CN_Cliente _CN_cliente = new CN_Cliente();

            try
            {

                if (ValidarVacio())
                {
                    errorIcono.Clear();

                    if (_Cliente == null)
                        _Cliente = new Cliente();

                        _Cliente.Nombre = txt_nombre.Text.Trim().ToUpper();
                        _Cliente.Apellido = txt_apellido.Text.Trim().ToUpper();
                    //_Cliente.Sexo = (string)cbo_sexo.SelectedItem;
                    _Cliente.Sexo = cbo_sexo.Text;
                    _Cliente.FechaNacimiento = dtp_fecha_nacimiento.Value;
                        _Cliente.NumeroDocumento = txt_numero_documento.Text.Trim();
                        _Cliente.Direccion = txt_direccion.Text.Trim().ToUpper();
                        _Cliente.Telefono = txt_telefono.Text.Trim();
                        _Cliente.Email = txt_email.Text.Trim();
                        _Cliente.UrlImagen = txt_url_imagen.Text.Trim();
                    

                    if (_Cliente.Id_cliente != 0)
                    {

                        _CN_cliente.EditarCliente(_Cliente);
                        MessageBox.Show("El Cliente Fue Modificado Exitosamente!!", "Modificado");
                        this.Close();
                    }
                    else
                    {
                        _CN_cliente.InsertarCliente(_Cliente); 
                        MessageBox.Show("El Cliente Fue Agregado Exitosamente!!", "Agregado");
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

        private bool ValidarVacio()
        {
            bool error = true;

            if (cbo_sexo.SelectedIndex == 0)
            {
                MessageBox.Show("Por favor, seleccione el sexo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (txt_direccion.Text == string.Empty)
            {
                errorIcono.SetError(txt_direccion, "El campo es obligatorio, ingrese la Direccion");
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
            else
            {
                errorIcono.Clear();
            }

            return error;
        }


        public static bool validarEmail(string pCorreo)
        {
            return pCorreo != null && Regex.IsMatch(pCorreo, @"^[^@\s]+@[^@\s]+\.(com)$");
        }



        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            GuardarCliente();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

   

        private void btn_subir_imagen_Click_1(object sender, EventArgs e)
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



        private void dtp_fecha_nacimiento_Validating(object sender, CancelEventArgs e)
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

        private void txt_email_Validating(object sender, CancelEventArgs e)
        {
            validarEmail(txt_email.Text);
        }

        private void txt_numero_documento_TextChanged(object sender, EventArgs e)
        {
            CN_Cliente _Cliente = new CN_Cliente();

            // Llama al método ValidarCliente para verificar si el cliente ya existe
            bool clienteExistente = _Cliente.ValidarCliente(txt_numero_documento.Text);

            // Si el cliente ya existe, muestra un mensaje de advertencia
            if (clienteExistente)
            {
                MessageBox.Show("El cliente ya existe en la base de datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_numero_documento.Clear();

            }
        }


     
    }
}
