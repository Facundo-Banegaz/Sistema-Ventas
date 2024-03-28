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
    public partial class FrmAgregarEditarIngreso : Form
    {

        private Ingreso _Ingreso = null;

        public FrmAgregarEditarIngreso()
        {
            InitializeComponent();
            Text = "Agregar Ingreso";
        }
        public FrmAgregarEditarIngreso(Ingreso ingreso)
        {
            InitializeComponent();
            this._Ingreso = ingreso;
            Text = "Modificar Ingreso";
        }


        private void FrmAgregarEditarIngreso_Load(object sender, EventArgs e)
        {
            CargarCbo();
            CargarCboComprobante();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }


        private void CargarCbo()
        {
            CN_Proveedor _Proveedor = new CN_Proveedor();
            CN_Categoria _Categoria = new CN_Categoria();
            try
            {
                cbo_proveedor.DataSource = _Proveedor.CargarCbo();
                cbo_proveedor.ValueMember = "Id_proveedor";
                cbo_proveedor.DisplayMember = "RazonSocial";

                cbo_cat.DataSource = _Categoria.CargarCbo();
                cbo_cat.ValueMember = "Id_categoria";
                cbo_cat.DisplayMember = "Nombre";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }

        private void CargarCboComprobante()
        {



            cbo_comprobante.Items.Add("SELECCIONAR COMPROBANTE");

            cbo_comprobante.Items.Add("TICKET");
            cbo_comprobante.Items.Add("FACTURA");
            cbo_comprobante.Items.Add("BOLETA");
            cbo_comprobante.Items.Add("REMITO");

            cbo_comprobante.SelectedIndex = 0;

            cbo_comprobante.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void cbo_cat_SelectedIndexChanged(object sender, EventArgs e)
        {
            CN_Articulo _Articulo = new CN_Articulo();
            if (cbo_cat.SelectedItem != null)
            {
                Categoria categoriaSeleccionada = (Categoria)cbo_cat.SelectedItem;
                int Id_categoria = categoriaSeleccionada.Id_categoria;

                List<Articulo> articulos = _Articulo.CargarCbo(Id_categoria);

                if (articulos.Count > 0)
                {
                    cbo_articulo.DataSource = articulos;
                    cbo_articulo.ValueMember = "Id_articulo";
                    cbo_articulo.DisplayMember = "Nombre";
                }
                else
                {
                    // No se encontraron artículos asociados a la categoría seleccionada
                    List<Articulo> mensaje = new List<Articulo>();
                    mensaje.Add(new Articulo { Id_articulo = -1, Nombre = "No hay artículos asociados a esta categoría" });
                    cbo_articulo.DataSource = mensaje;
                    cbo_articulo.ValueMember = "Id_articulo";
                    cbo_articulo.DisplayMember = "Nombre";
                }
            }
        }



        private void CargarGrilla()
        {
            //logica del dataGridView
         


            Listaingresos = _Ingreso.ListaIngreso();

            dgv_ingresos.DataSource = Listaingresos;
            lbl_total.Text = "Total de Registros:  " + Convert.ToString(dgv_ingresos.Rows.Count);
            lbl_resultado.Text = "";

        }

        private void ArregloDataGridView(DataGridView dgv_ingresos)
        {
            // Lógica del dataGridView
            CN_Metodos _Metodos = new CN_Metodos();



            dgv_ingresos.Columns["Id_ingreso"].Width = 300;
            dgv_ingresos.Columns["Trabajador"].Width = 400; // nombre_producto
            dgv_ingresos.Columns["Proveedor"].Width = 400; // descripcion_producto 
            dgv_ingresos.Columns["Fecha"].Width = 350;
            dgv_ingresos.Columns["Tipo_comprobante"].Width = 400; // nombre_producto
            dgv_ingresos.Columns["Serie"].Width = 400; // descripcion_producto 
            dgv_ingresos.Columns["Correlativo"].Width = 400;
            dgv_ingresos.Columns["Iva"].Width = 250;
            dgv_ingresos.Columns["Estado"].Width = 400; // nombre_producto
            dgv_ingresos.Columns["Total"].Width = 500; // descripcion_producto 


            dgv_ingresos.Columns["Id_ingreso"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_ingresos.Columns["Trabajador"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_ingresos.Columns["Proveedor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_ingresos.Columns["Fecha"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_ingresos.Columns["Tipo_comprobante"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_ingresos.Columns["Serie"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_ingresos.Columns["Correlativo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_ingresos.Columns["Iva"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_ingresos.Columns["Estado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_ingresos.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            _Metodos.AlternarColor(dgv_ingresos);
        }

    }
}
