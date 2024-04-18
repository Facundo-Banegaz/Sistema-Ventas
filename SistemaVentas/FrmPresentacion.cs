using CapaDominio;
using CapaNegocio;
using SistemaVentas.Reportes;
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
    public partial class FrmPresentacion : Form
    {

        private List<Presentacion> presentacionList;
        public FrmPresentacion()
        {
            InitializeComponent();
            Text = "Gestion Presentacion:";
        }
        private void FrmPresentacion_Load(object sender, EventArgs e)
        {
            CargarGrilla();

            ArregloDataGridView(dgv_presentacion);
        }

        private void CargarGrilla()
        {
            //logica del dataGridView
            CN_Presentacion _Presentacion = new CN_Presentacion();

            presentacionList = _Presentacion.ListarPresentacion();

            dgv_presentacion.DataSource = presentacionList;
            lbl_total.Text = "Total de Registros:  " + Convert.ToString(dgv_presentacion.Rows.Count);
            lbl_resultado.Text = "";

        }

        private void BuscarPresentacion()
        {
            CN_Presentacion presentacion = new CN_Presentacion();

            if (txt_buscar.Text == string.Empty)
            {
                MessageBox.Show("El CAMPO NO PUEDE QUEDAR VACIO!!", "ADVERTENCIA");

                lbl_resultado.Text = "No escribio nada en el campo  'Buscador'.";
            }
            else
            {
                dgv_presentacion.DataSource = presentacion.PresentacionBuscar(txt_buscar.Text);

                lbl_total.Text = "Total de Registros Encontrados:" + " " + Convert.ToString(dgv_presentacion.Rows.Count);
                lbl_resultado.Text = "Para volver a ver el listado completo 'Limpiar' el campo!!.";
            }
        }
        private void ArregloDataGridView(DataGridView dgv_productos)
        {

            //logica del dataGridView
            CN_Metodos _Metodos = new CN_Metodos();
            //UrlImagen


            dgv_productos.Columns["Id_presentacion"].Width = 200;
            dgv_productos.Columns["Nombre"].Width = 400;// nombre_producto
            dgv_productos.Columns["Descripcion"].Width = 1600;// descripcion_producto 


            dgv_productos.Columns["Id_presentacion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Nombre"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Descripcion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;



            _Metodos.AlternarColor(dgv_productos);
        }
        private void dgv_presentacion_SelectionChanged(object sender, EventArgs e)
        {
            Presentacion seleccionado = (Presentacion)dgv_presentacion.CurrentRow.DataBoundItem;
        }




        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            FrmAgregarEditarPresentacion frmAgregar = new FrmAgregarEditarPresentacion();
            frmAgregar.ShowDialog();
            CargarGrilla();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Presentacion seleccionado;
            DialogResult respuesta = MessageBox.Show("¿Quieres Editar esta Presentacion?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (respuesta == DialogResult.Yes)
            {
                seleccionado = (Presentacion)dgv_presentacion.CurrentRow.DataBoundItem;

                FrmAgregarEditarPresentacion frmEditar = new FrmAgregarEditarPresentacion(seleccionado);
                frmEditar.ShowDialog();
                CargarGrilla();
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

            CN_Presentacion _Presentacion = new CN_Presentacion();  
            Presentacion seleccionado;


            try
            {
                DialogResult respuesta = MessageBox.Show("¿Quieres Eliminar esta Presentacion?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Presentacion)dgv_presentacion.CurrentRow.DataBoundItem;
                    _Presentacion.EliminarCategoria(seleccionado.Id_presentacion);

                    CargarGrilla();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            BuscarPresentacion();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_buscar.Clear();
            CargarGrilla();
        }

        private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            FrmReportePresentacion frmReporte = new  FrmReportePresentacion();

            frmReporte.ShowDialog();
        }
    }
}
