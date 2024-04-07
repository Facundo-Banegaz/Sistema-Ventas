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
    public partial class FrmVenta : Form
    {
        private List<Venta> ListaVentas;
        public Trabajador _Trabajador;
        public FrmVenta()
        {
            InitializeComponent();
            Text = "Gestion Venta:";
        }
        public FrmVenta(Trabajador trabajador)
        {
            InitializeComponent();
             this._Trabajador= trabajador;
        }
        private void FrmVenta_Load(object sender, EventArgs e)
        {
            CargarGrilla();

            ArregloDataGridView(dgv_ventas);
        }

        private void CargarGrilla()
        {
            //logica del dataGridView
            CN_Venta _Venta = new CN_Venta();

            ListaVentas = _Venta.ListaVenta();

            dgv_ventas.DataSource = ListaVentas;
            lbl_total.Text = "Total de Registros:  " + Convert.ToString(dgv_ventas.Rows.Count);
            lbl_resultado.Text = "";

        }

        private void ArregloDataGridView(DataGridView dgv_ingresos)
        {
            // Lógica del dataGridView
            CN_Metodos _Metodos = new CN_Metodos();



            dgv_ingresos.Columns["Id_venta"].Width = 300;
            dgv_ingresos.Columns["Trabajador"].Width = 400; // nombre_producto
            dgv_ingresos.Columns["Cliente"].Width = 400; // descripcion_producto 
            dgv_ingresos.Columns["Fecha"].Width = 350;
            dgv_ingresos.Columns["Tipo_comprobante"].Width = 400; // nombre_producto
            dgv_ingresos.Columns["Serie"].Width = 400; // descripcion_producto 
            dgv_ingresos.Columns["Correlativo"].Width = 400;
            dgv_ingresos.Columns["Iva"].Width = 250;
            dgv_ingresos.Columns["Estado"].Width = 400; // nombre_producto
            dgv_ingresos.Columns["Total"].Width = 500; // descripcion_producto 


            dgv_ingresos.Columns["Id_venta"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_ingresos.Columns["Trabajador"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_ingresos.Columns["Cliente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_ingresos.Columns["Fecha"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_ingresos.Columns["Tipo_comprobante"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_ingresos.Columns["Serie"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_ingresos.Columns["Correlativo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_ingresos.Columns["Iva"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_ingresos.Columns["Estado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_ingresos.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_ingresos.Columns["Total"].DefaultCellStyle.Format = "N0";

            _Metodos.AlternarColor(dgv_ingresos);
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            FrmAgregarEditarVenta frmAgregar = new FrmAgregarEditarVenta(_Trabajador);
            frmAgregar.ShowDialog();
            CargarGrilla();
        }

        private void btn_ver_detalle_Click(object sender, EventArgs e)
        {
            Venta seleccionado = null;

            if (dgv_ventas.CurrentRow != null)
            {
                DialogResult respuesta = MessageBox.Show("¿Quieres Ver el detalle de esta Venta?", "Detalle", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Venta)dgv_ventas.CurrentRow.DataBoundItem;

                    FrmDetalleVenta frmDetalle = new FrmDetalleVenta(seleccionado);
                    frmDetalle.ShowDialog();
                    CargarGrilla();
                }
            }
            else
            {
                MessageBox.Show("No hay ninguna fila seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            BuscarFechas();
        }
        private void BuscarFechas()
        {
            CN_Ingreso _Ingreso = new CN_Ingreso();

            if (dtp_fecha_inicio.Value == DateTime.MinValue || dtp_fecha_fin.Value == DateTime.MinValue)
            {
                MessageBox.Show("Ambas fechas deben ser seleccionadas.", "ADVERTENCIA");
                lbl_resultado.Text = "No ha seleccionado ambas fechas.";
            }
            else if (dtp_fecha_inicio.Value >= dtp_fecha_fin.Value)
            {
                MessageBox.Show("La fecha de 'Inicio' no puede ser mayor o igual que la fecha de 'Fin'.", "ADVERTENCIA");
                lbl_resultado.Text = "La fecha de 'Inicio' no puede ser mayor o igual que la fecha de 'Fin'.";
            }
            else
            {
                dgv_ventas.DataSource = _Ingreso.IngresoBuscarFecha(dtp_fecha_inicio.Value, dtp_fecha_fin.Value);

                lbl_total.Text = "Total de Registros Encontrados: " + dgv_ventas.Rows.Count;
                lbl_resultado.Text = "Para volver a ver el listado completo, 'Limpiar' el campo.";
            }
        }
        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            // Establecer la fecha actual como valor por defecto
            dtp_fecha_inicio.Value = DateTime.Today;
            dtp_fecha_fin.Value = DateTime.Today;



            CargarGrilla();
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {

            Venta seleccionado = null;

            if (dgv_ventas.CurrentRow != null)
            {
                DialogResult respuesta = MessageBox.Show("¿Quieres Imprimir esta Venta?", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Venta)dgv_ventas.CurrentRow.DataBoundItem;

                    FrmReporteFactura frmReporte = new FrmReporteFactura(seleccionado);

                    frmReporte.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("No hay ninguna fila seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            CN_Venta _Venta = new CN_Venta();
            Venta seleccionado = null;

            try
            {
                if (dgv_ventas.CurrentRow != null)
                {
                    DialogResult respuesta = MessageBox.Show("¿Quieres Eliminar esta Venta?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (respuesta == DialogResult.Yes)
                    {
                        seleccionado = (Venta)dgv_ventas.CurrentRow.DataBoundItem;
                        _Venta.EliminarVenta(seleccionado.Id_venta);

                        CargarGrilla();
                    }
                }
                else
                {
                    MessageBox.Show("No hay ninguna fila seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
