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
using CapaDominio;
using CapaNegocio;

namespace SistemaVentas
{
    public partial class FrmCategoria : Form
    {
        private List<Categoria> listaCategorias; 
        public FrmCategoria()
        {
            InitializeComponent();
            Text = "Gestion Categoria:";
        }
        private void FrmCategoria_Load(object sender, EventArgs e)
        {
           
            CargarGrilla();

            ArregloDataGridView(dgv_categorias);
        }
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            FrmAgregarEditarCategoria frmAgregar = new FrmAgregarEditarCategoria();
            frmAgregar.ShowDialog();
            CargarGrilla();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {

            Categoria seleccionado;
            DialogResult respuesta = MessageBox.Show("¿Quieres Editar esta Cateforia?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (respuesta == DialogResult.Yes)
            {
                seleccionado = (Categoria)dgv_categorias.CurrentRow.DataBoundItem;
                FrmAgregarEditarCategoria frmEditar = new FrmAgregarEditarCategoria(seleccionado);
                frmEditar.ShowDialog();
                CargarGrilla();
            }
            
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            CN_Categoria _Categoria = new CN_Categoria();
            Categoria seleccionado;


            try
            {
                DialogResult respuesta = MessageBox.Show("¿Quieres Eliminar esta Categoria?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Categoria)dgv_categorias.CurrentRow.DataBoundItem;
                    _Categoria.EliminarCategoria(seleccionado.Id_categoria);

                    CargarGrilla();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarGrilla()
        {
            //logica del dataGridView
            CN_Categoria _Categoria = new CN_Categoria();

            listaCategorias = _Categoria.ListaCategoria();

            dgv_categorias.DataSource = listaCategorias;
            lbl_total.Text = "Total de Registros:  " + Convert.ToString(dgv_categorias.Rows.Count);
            lbl_resultado.Text = "";

        }

        private void ArregloDataGridView(DataGridView dgv_productos)
        {

            //logica del dataGridView
            CN_Metodos _Metodos = new CN_Metodos();
            //UrlImagen
            dgv_productos.Columns["UrlImagen"].Visible=false;


            dgv_productos.Columns["Id_categoria"].Width= 200;
            dgv_productos.Columns["Nombre"].Width = 400;// nombre_producto
            dgv_productos.Columns["Descripcion"].Width = 1600;// descripcion_producto 


            dgv_productos.Columns["Id_categoria"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Nombre"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Descripcion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;



            _Metodos.AlternarColor(dgv_productos);
        }

        private void dgv_categorias_SelectionChanged(object sender, EventArgs e)
        {
            Categoria seleccionado = (Categoria)dgv_categorias.CurrentRow.DataBoundItem;

            CN_Metodos _Metodos = new CN_Metodos();

            _Metodos.CargarImg(pbx_img,seleccionado.UrlImagen);

        }
        private void Buscarcategoria()
        {
            CN_Categoria categoria = new CN_Categoria();

            if (txt_buscar.Text == string.Empty)
            {
                MessageBox.Show("El CAMPO NO PUEDE QUEDAR VACIO!!","ADVERTENCIA");

                lbl_resultado.Text = "No escribio nada en el campo  'Buscador'.";
            }
            else
            {
                dgv_categorias.DataSource = categoria.CategoriaBuscar(txt_buscar.Text);

                lbl_total.Text = "Total de Registros Encontrados:" + " " + Convert.ToString(dgv_categorias.Rows.Count);
                lbl_resultado.Text = "Para volver a ver el listado completo 'Limpiar' el campo!!.";
            }
        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Buscarcategoria();
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
    }
}
