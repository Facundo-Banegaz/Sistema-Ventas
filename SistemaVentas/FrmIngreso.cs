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
    public partial class FrmIngreso : Form
    {

        private List<Ingreso> Listaingresos;
        public Trabajador _Trabajador;
        public FrmIngreso()
        {
            InitializeComponent();
            Text = "Gestion Ingreso";
        }
        public FrmIngreso(Trabajador trabajador)
        {
            InitializeComponent();
            this._Trabajador= trabajador;
        }
        private void FrmIngreso_Load(object sender, EventArgs e)
        {
            CargarGrilla();

            ArregloDataGridView(dgv_ingresos);
        }

        private void CargarGrilla()
        {
            //logica del dataGridView
            CN_Ingreso _Ingreso = new CN_Ingreso();

            Listaingresos = _Ingreso.ListaIngreso();

            dgv_ingresos.DataSource = Listaingresos;
            lbl_total.Text = "Total de Registros:  " + Convert.ToString(dgv_ingresos.Rows.Count);
            lbl_resultado.Text = "";

        }

        private void ArregloDataGridView(DataGridView dgv_ingresos)
        {
            // Lógica del dataGridView
            CN_Metodos _Metodos = new CN_Metodos();

  

            dgv_ingresos.Columns["Id_ingreso"].Width =300;
            dgv_ingresos.Columns["Trabajador"].Width =400; // nombre_producto
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
            dgv_ingresos.Columns["Total"].DefaultCellStyle.Format = "N0";

            _Metodos.AlternarColor(dgv_ingresos);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            FrmAgregarEditarIngreso frmAgregar = new FrmAgregarEditarIngreso(_Trabajador);
            frmAgregar.ShowDialog();
            CargarGrilla();
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
                dgv_ingresos.DataSource = _Ingreso.IngresoBuscarFecha(dtp_fecha_inicio.Value, dtp_fecha_fin.Value);

                lbl_total.Text = "Total de Registros Encontrados: " + dgv_ingresos.Rows.Count;
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

        }

        private void btn_anular_Click(object sender, EventArgs e)
        {
            CN_Ingreso _Ingreso = new CN_Ingreso();
            Ingreso seleccionado;


            try
            {
                DialogResult respuesta = MessageBox.Show("¿Quieres Anular este Ingreso?", "Anular", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Ingreso)dgv_ingresos.CurrentRow.DataBoundItem;
                    _Ingreso.AnularIngreso(seleccionado.Id_ingreso);

                    CargarGrilla();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_ver_detalle_Click(object sender, EventArgs e)
        {
            Ingreso seleccionado;
            DialogResult respuesta = MessageBox.Show("¿Quieres Ver el detalle este Ingreso?", "Detalle", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (respuesta == DialogResult.Yes)
            {
                seleccionado = (Ingreso)dgv_ingresos.CurrentRow.DataBoundItem;

                FrmDetalleIngreso frmDetalle = new FrmDetalleIngreso(seleccionado);
                frmDetalle.ShowDialog();
                CargarGrilla();
            }
        }
    }
}
