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
    public partial class FrmDetalleVenta : Form
    {
        private Venta _Venta;
        public FrmDetalleVenta()
        {
            InitializeComponent();
            Text = "Agregar Venta:";
        }
        public FrmDetalleVenta(Venta venta)
        {
            InitializeComponent();
            this._Venta = venta;
            lbl_total.Text = "Total de Registros:  " + Convert.ToString(dgv_detalles.Rows.Count);
        }
        private void FrmDetalleVenta_Load(object sender, EventArgs e)
        {
            MostrarDetalles();
            ArregloDataGridView(dgv_detalles);
        }


        private void MostrarDetalles()
        {

            CN_Detalle_Venta _Detalle_Venta = new CN_Detalle_Venta();

            dgv_detalles.DataSource = _Detalle_Venta.ListaDetalleVenta(_Venta.Id_venta);

        }
        private void ArregloDataGridView(DataGridView dgv_productos)
        {

            //logica del dataGridView
            CN_Metodos _Metodos = new CN_Metodos();
            dgv_productos.Columns["Id_detalle_venta"].Visible = false;
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

    }
}
