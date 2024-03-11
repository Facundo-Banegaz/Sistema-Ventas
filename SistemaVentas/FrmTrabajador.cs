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
    }
}
