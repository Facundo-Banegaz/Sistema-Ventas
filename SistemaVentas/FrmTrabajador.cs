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
    public partial class FrmTrabajador : Form
    {
        private List<Trabajador> listaTrabajador;
        public FrmTrabajador()
        {
            InitializeComponent();
        }

        private void FrmPersona_Load(object sender, EventArgs e)
        {
            CargarGrilla();

            ArregloDataGridView(dgv_trabajador);
        }

        private void CargarGrilla()
        {
            //logica del dataGridView
            CN_Trabajador _Trabajador = new CN_Trabajador();

            listaTrabajador = _Trabajador.ListaTrabajador();

            dgv_trabajador.DataSource = listaTrabajador;

            lbl_total.Text = "Total de Registros:  " + Convert.ToString(dgv_trabajador.Rows.Count);
            lbl_resultado.Text = "";

        }

        private void ArregloDataGridView(DataGridView dgv_personas)
        {

            //logica del dataGridView
            CN_Metodos _Metodos = new CN_Metodos();

            //UrlImagen
            dgv_trabajador.Columns["UrlImagen"].Visible = false;


            dgv_trabajador.Columns["Id_trabajador"].Width = 250;
            dgv_trabajador.Columns["Nombre"].Width = 350;// nombre_producto
            dgv_trabajador.Columns["Apellido"].Width = 350;
            dgv_trabajador.Columns["Sexo"].Width = 250;
            dgv_trabajador.Columns["FechaNacimiento"].Width = 350;
            dgv_trabajador.Columns["NumeroDocumento"].Width = 350;
            dgv_trabajador.Columns["Direccion"].Width = 450;
            dgv_trabajador.Columns["Telefono"].Width = 350;
            dgv_trabajador.Columns["Email"].Width = 350;
            dgv_trabajador.Columns["Acceso"].Width = 350;
            dgv_trabajador.Columns["Usuario"].Width = 350;
            dgv_trabajador.Columns["Clave"].Width = 350;

            dgv_trabajador.Columns["Id_trabajador"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_trabajador.Columns["Nombre"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_trabajador.Columns["Apellido"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_trabajador.Columns["Sexo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_trabajador.Columns["FechaNacimiento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_trabajador.Columns["NumeroDocumento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_trabajador.Columns["Direccion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_trabajador.Columns["Telefono"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_trabajador.Columns["Email"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_trabajador.Columns["Acceso"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_trabajador.Columns["Usuario"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_trabajador.Columns["Clave"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            _Metodos.AlternarColor(dgv_trabajador);

        }



        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_trabajador_SelectionChanged(object sender, EventArgs e)
        {
            Trabajador seleccionado = (Trabajador)dgv_trabajador.CurrentRow.DataBoundItem;

            CN_Metodos _Metodos = new CN_Metodos();

            _Metodos.CargarImg(pbx_img, seleccionado.UrlImagen);
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            FrmAgregarEditarTrabajador frmAgregar = new FrmAgregarEditarTrabajador();
            frmAgregar.ShowDialog();
            this.Close();   
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            BuscarTrabajador();
        }
        private void BuscarTrabajador()
        {
           CN_Trabajador _Trabajador = new CN_Trabajador();


            if (txt_buscar.Text == string.Empty)
            {
                MessageBox.Show("El CAMPO NO PUEDE QUEDAR VACIO!!", "ADVERTENCIA");

                lbl_resultado.Text = "No escribio nada en el campo  'Buscador'.";
            }
            else
            {
                dgv_trabajador.DataSource = _Trabajador.TrabajadorBuscar(txt_buscar.Text);

                lbl_total.Text = "Total de Registros Encontrados:" + " " + Convert.ToString(dgv_trabajador.Rows.Count);
                lbl_resultado.Text = "Para volver a ver el listado completo 'Limpiar' el campo!!.";
            }
        }
        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_buscar.Clear();
            CargarGrilla();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Trabajador seleccionado;
            DialogResult respuesta = MessageBox.Show("¿Quieres Editar este Trabajador?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (respuesta == DialogResult.Yes)
            {
                seleccionado = (Trabajador)dgv_trabajador.CurrentRow.DataBoundItem;
                FrmAgregarEditarTrabajador frmEditar = new FrmAgregarEditarTrabajador(seleccionado);
                frmEditar.ShowDialog();
                CargarGrilla();
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            CN_Trabajador _Trabajador  = new CN_Trabajador();   

            Trabajador seleccionado;


            try
            {
                DialogResult respuesta = MessageBox.Show("¿Quieres Eliminar este Trabajador?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Trabajador)dgv_trabajador.CurrentRow.DataBoundItem;
                    _Trabajador.EliminarTrabajador(seleccionado.Id_trabajador);

                    CargarGrilla();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
