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
    public partial class FrmArticulo : Form
    {
        private List<Articulo> listaArticulos;
        public FrmArticulo()
        {
            InitializeComponent();
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            ArregloDataGridView(dgv_productos);
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            FrmAgregarEditarArticulo frmAgregar = new FrmAgregarEditarArticulo();
            frmAgregar.ShowDialog();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            DialogResult respuesta = MessageBox.Show("¿Quieres Editar este Articulo?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (respuesta == DialogResult.Yes)
            {
                seleccionado = (Articulo)dgv_productos.CurrentRow.DataBoundItem;
                FrmAgregarEditarCategoria frmEditar = new FrmAgregarEditarArticulo(seleccionado);
                frmEditar.ShowDialog();
                CargarGrilla();
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btn_ver_detalle_Click(object sender, EventArgs e)
        {

        }
        private void CargarGrilla()
        {
            //logica del dataGridView
             CN_Articulo _CN_Articulo = new CN_Articulo();

            listaArticulos = _CN_Articulo.ListaArticulos();

            dgv_productos.DataSource = listaArticulos;
            lbl_total.Text = "Total de Registros:  " + Convert.ToString(dgv_productos.Rows.Count);
            lbl_resultado.Text = "";

        }
        private void ArregloDataGridView(DataGridView dgv_productos)
        {

            //logica del dataGridView
            CN_Metodos _Metodos = new CN_Metodos();
            //UrlImagen
            dgv_productos.Columns["UrlImagen"].Visible = false;


            dgv_productos.Columns["Id_articulo"].Width = 200;
            dgv_productos.Columns["Nombre"].Width = 400;// nombre_producto
            dgv_productos.Columns["Codigo"].Width = 400;// nombre_producto
            dgv_productos.Columns["Descripcion"].Width = 1600;// descripcion_producto 
            dgv_productos.Columns["Categoria"].Width = 200;// Categoria
            dgv_productos.Columns["Presentacion"].Width = 200;// Presentacion

            dgv_productos.Columns["Id_articulo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Nombre"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Codigo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Descripcion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Categoria"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Presentacion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;



            _Metodos.AlternarColor(dgv_productos);
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

            CN_Articulo _Articulo = new CN_Articulo();
            Articulo seleccionado;


            try
            {
                DialogResult respuesta = MessageBox.Show("¿Quieres Eliminar este Articulo?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgv_productos.CurrentRow.DataBoundItem;
                    _Articulo.EliminarArticulo(seleccionado.Id_articulo);

                    CargarGrilla();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void BuscarArticulo()
        {
            CN_Articulo _Articulo = new CN_Articulo();

            if (txt_buscar.Text == string.Empty)
            {
                MessageBox.Show("El CAMPO NO PUEDE QUEDAR VACIO!!", "ADVERTENCIA");

                lbl_resultado.Text = "No escribio nada en el campo  'Buscador'.";
            }
            else
            {
                dgv_productos.DataSource = _Articulo.ArticuloBuscar(txt_buscar.Text);

                lbl_total.Text = "Total de Registros Encontrados:" + " " + Convert.ToString(dgv_productos.Rows.Count);
                lbl_resultado.Text = "Para volver a ver el listado completo 'Limpiar' el campo!!.";
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            BuscarArticulo();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_buscar.Clear();
            CargarGrilla();
        }
    }
}
