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
    public partial class FrmPersona : Form
    {
        private List<Persona> listaPersonas;
        public FrmPersona()
        {
            InitializeComponent();
        }

        private void FrmPersona_Load(object sender, EventArgs e)
        {
            CargarGrilla();

            ArregloDataGridView(dgv_personas);
        }

        private void CargarGrilla()
        {
            //logica del dataGridView
            CN_Persona _Persona = new CN_Persona();

            listaPersonas = _Persona.ListaPersona();

            dgv_personas.DataSource = listaPersonas;

            lbl_total.Text = "Total de Registros:  " + Convert.ToString(dgv_personas.Rows.Count);
            lbl_resultado.Text = "";

        }

        private void ArregloDataGridView(DataGridView dgv_personas)
        {

            //logica del dataGridView
            CN_Metodos _Metodos = new CN_Metodos();

            //UrlImagen
            dgv_personas.Columns["UrlImagen"].Visible = false;


            dgv_personas.Columns["Id_persona"].Width = 100;
            dgv_personas.Columns["Nombre"].Width = 350;// nombre_producto
            dgv_personas.Columns["Apellido"].Width = 350;
            dgv_personas.Columns["Sexo"].Width = 100;
            dgv_personas.Columns["FechaNacimiento"].Width = 350;
            dgv_personas.Columns["NumeroDocumento"].Width = 350;
            dgv_personas.Columns["Direccion"].Width = 350;
            dgv_personas.Columns["Telefono"].Width = 350;
            dgv_personas.Columns["Email"].Width = 350;

            dgv_personas.Columns["Id_persona"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_personas.Columns["Nombre"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_personas.Columns["Apellido"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_personas.Columns["Sexo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_personas.Columns["FechaNacimiento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_personas.Columns["NumeroDocumento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_personas.Columns["Direccion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_personas.Columns["Telefono"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_personas.Columns["Email"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dgv_personas.Columns["Id_persona"].DefaultCellStyle.Format = "#,##0,00";
            dgv_personas.Columns["Nombre"].DefaultCellStyle.Format = "#,##0,00";
            dgv_personas.Columns["Apellido"].DefaultCellStyle.Format = "#,##0,00";
            dgv_personas.Columns["Sexo"].DefaultCellStyle.Format = "#,##0,00";
            dgv_personas.Columns["FechaNacimiento"].DefaultCellStyle.Format = "#,##0,00";
            dgv_personas.Columns["NumeroDocumento"].DefaultCellStyle.Format = "#,##0,00";
            dgv_personas.Columns["Direccion"].DefaultCellStyle.Format = "#,##0,00";
            dgv_personas.Columns["Telefono"].DefaultCellStyle.Format = "#,##0,00";
            dgv_personas.Columns["Email"].DefaultCellStyle.Format = "#,##0,00";
            _Metodos.AlternarColor(dgv_personas);
        }

        private void dgv_personas_SelectionChanged(object sender, EventArgs e)
        {
            Persona seleccionado = (Persona)dgv_personas.CurrentRow.DataBoundItem;

            CN_Metodos _Metodos = new CN_Metodos();

            _Metodos.CargarImg(pbx_img, seleccionado.UrlImagen);

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
