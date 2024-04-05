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
    public partial class FrmDetalleIngreso : Form
    {

        private Ingreso _Ingreso;
        public FrmDetalleIngreso()
        {
            InitializeComponent();
            Text = "Agregar Ingreso:";
        }
        public FrmDetalleIngreso(Ingreso ingreso)
        {
            InitializeComponent();
            this._Ingreso = ingreso;
        }
        private void FrmDetalleIngreso_Load(object sender, EventArgs e)
        {
            MostrarDetalles();
            ArregloDataGridView(dgv_detalles);
            lbl_total.Text = "Total de Registros:  " + Convert.ToString(dgv_detalles.Rows.Count);
        }



        private void MostrarDetalles()
        {

            CN_Detalle_Ingreso _Detalle_Ingreso = new CN_Detalle_Ingreso();

            dgv_detalles.DataSource = _Detalle_Ingreso.ListaDetalleIngreso(_Ingreso.Id_ingreso);

        }
        private void ArregloDataGridView(DataGridView dgv_productos)
        {

            //logica del dataGridView
            CN_Metodos _Metodos = new CN_Metodos();
            dgv_productos.Columns["Id_detalle_ingreso"].Visible = false;
            dgv_productos.Columns["Ingreso"].Visible = false;
            dgv_productos.Columns["Stock_Actual"].Visible = false;


  
            dgv_productos.Columns["Articulo"].Width = 450;// nombre_producto
            dgv_productos.Columns["Precio_compra"].Width = 300;// nombre_producto
            dgv_productos.Columns["Precio_venta"].Width = 300;// descripcion_producto 
            dgv_productos.Columns["Stock_inicial"].Width = 300;// Categoria
            dgv_productos.Columns["Fecha_produccion"].Width = 350;// Presentacion
            dgv_productos.Columns["Fecha_vencimiento"].Width = 350;// Categoria
            dgv_productos.Columns["Subtotal"].Width = 300;// Presentacion



            dgv_productos.Columns["Articulo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Precio_compra"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Precio_venta"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Stock_inicial"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Fecha_produccion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Fecha_vencimiento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Subtotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Subtotal"].DefaultCellStyle.Format = "N0";

            _Metodos.AlternarColor(dgv_productos);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
