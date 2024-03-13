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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
        private void tn_tiempo_Tick(object sender, EventArgs e)
        {
            lbl_hora.Text = DateTime.Now.ToString();
        }

        private void btn_acceder_Click(object sender, EventArgs e)
        {
            CN_Trabajador _Trabajador = new CN_Trabajador();
            Trabajador  trabajador = _Trabajador.Login(txt_usuario.Text, txt_clave.Text);

            if (trabajador != null)
            {

                CN_Metodos _Metodos = new CN_Metodos();
                _Metodos.CargarImg(pbx_img, trabajador.UrlImagen);
                //para que me muestre un mensaje en la ventana 
                Text = $"Inicio de sesión exitoso. ¡Bienvenido al Sistema de Ventas {trabajador.Nombre}  {trabajador.Apellido}!";

                // Usuario válido, realizar acciones correspondientes (por ejemplo, mostrar el formulario principal)
                string mensaje = $"Inicio de sesión exitoso. ¡Bienvenido al Sistema de Ventas, {trabajador.Nombre}  {trabajador.Apellido} | Nombre de Usuario: {txt_usuario.Text} | Accediste como: {trabajador.Acceso}!";
                MessageBox.Show(mensaje, "¡Bienvenido!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FrmPrincipal principal = new FrmPrincipal(trabajador);
                
                this.Close();
                principal.Show();
            }
            else
            {
                // Usuario no válido, mostrar mensaje de error
                MessageBox.Show("Usuario o contraseña incorrectos, intentar de nuevo."," No tiene Acceso al Sistema de Ventas",MessageBoxButtons.OK, MessageBoxIcon.Error);
              
                txt_clave.Clear();
                txt_usuario.Clear();

            }

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {

            DialogResult respuesta = MessageBox.Show("¿Quieres Salir del Sistema de Ventas?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
