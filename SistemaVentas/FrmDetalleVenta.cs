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
        }
        private void FrmDetalleVenta_Load(object sender, EventArgs e)
        {
            MostrarDetalles();
            ArregloDataGridView(dgv_detalles);
            lbl_total.Text = "Total de Registros:  " + Convert.ToString(dgv_detalles.Rows.Count);

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
            dgv_productos.Columns["Venta"].Visible = false;
            dgv_productos.Columns["Detalle_ingreso"].Visible = false;



            dgv_productos.Columns["Articulo"].Width = 450;// nombre_producto
            dgv_productos.Columns["Cantidad"].Width = 300;// descripcion_producto 
            dgv_productos.Columns["Precio_venta"].Width = 300;// Categoria
            dgv_productos.Columns["Descuento"].Width = 350;// Presentacion
            dgv_productos.Columns["Subtotal"].Width = 300;// Presentacion



            dgv_productos.Columns["Articulo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Precio_venta"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Descuento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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
