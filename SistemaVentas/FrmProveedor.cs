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
    public partial class FrmProveedor : Form
    {
        private List<Proveedor> listaProveedor;
        public FrmProveedor()
        {
            InitializeComponent();
            Text = "Gestion Proveedor:";
        }

        private void FrmPersona_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            ArregloDataGridView(dgv_proveedores);
        }

        private void CargarGrilla()
        {
            //logica del dataGridView
            CN_Proveedor proveedor = new CN_Proveedor();

            listaProveedor = proveedor.ListarProveedores();

            dgv_proveedores.DataSource = listaProveedor;

            lbl_total.Text = "Total de Registros:  " + Convert.ToString(dgv_proveedores.Rows.Count);
            lbl_resultado.Text = "";

        }

        private void ArregloDataGridView(DataGridView dgv_proveedor)
        {

            //logica del dataGridView
            CN_Metodos _Metodos = new CN_Metodos();

            //UrlImagen
            dgv_proveedor.Columns["UrlImagen"].Visible = false;


            dgv_proveedor.Columns["Id_proveedor"].Width = 100;
            dgv_proveedor.Columns["RazonSocial"].Width = 350;
            dgv_proveedor.Columns["Sectorcomercial"].Width = 350;
            dgv_proveedor.Columns["PaginaWeb"].Width = 350;
            dgv_proveedor.Columns["Direccion"].Width = 350;
            dgv_proveedor.Columns["Telefono"].Width = 350;
            dgv_proveedor.Columns["Email"].Width = 350;

            dgv_proveedor.Columns["Id_proveedor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_proveedor.Columns["RazonSocial"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_proveedor.Columns["SectorComercial"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_proveedor.Columns["PaginaWeb"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_proveedor.Columns["Direccion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_proveedor.Columns["Telefono"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_proveedor.Columns["Email"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            _Metodos.AlternarColor(dgv_proveedor);
        }


        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_proveedor_SelectionChanged(object sender, EventArgs e)
        {
            Proveedor seleccionado = (Proveedor)dgv_proveedores.CurrentRow.DataBoundItem;

            CN_Metodos _Metodos = new CN_Metodos();

            _Metodos.CargarImg(pbx_img, seleccionado.UrlImagen);
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

            CN_Proveedor _Proveedor = new CN_Proveedor();
            Proveedor seleccionado;


            try
            {
                DialogResult respuesta = MessageBox.Show("¿Quieres Eliminar este Proveedor?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Proveedor)dgv_proveedores.CurrentRow.DataBoundItem;
                    _Proveedor.EliminarProveedor(seleccionado.Id_proveedor);

                    CargarGrilla();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Proveedor seleccionado;
            DialogResult respuesta = MessageBox.Show("¿Quieres Editar este Proveedor?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (respuesta == DialogResult.Yes)
            {
                seleccionado = (Proveedor)dgv_proveedores.CurrentRow.DataBoundItem;
                FrmAgregarEditarProveedor frmEditar = new FrmAgregarEditarProveedor(seleccionado);
                frmEditar.ShowDialog();
                CargarGrilla();
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            FrmAgregarEditarProveedor frmProveedor = new FrmAgregarEditarProveedor();
            frmProveedor.ShowDialog();
            CargarGrilla();
        }
        private void BuscarProveedor()
        {
            CN_Proveedor _Proveedor = new CN_Proveedor();

            if (txt_buscar.Text == string.Empty)
            {
                MessageBox.Show("El CAMPO NO PUEDE QUEDAR VACIO!!", "ADVERTENCIA");

                lbl_resultado.Text = "No escribio nada en el campo  'Buscador'.";
            }
            else
            {
                dgv_proveedores.DataSource = _Proveedor.ProveedorBuscar(txt_buscar.Text);

                lbl_total.Text = "Total de Registros Encontrados:" + " " + Convert.ToString(dgv_proveedores.Rows.Count);
                lbl_resultado.Text = "Para volver a ver el listado completo 'Limpiar' el campo!!.";
            }
        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            BuscarProveedor();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_buscar.Clear();
            CargarGrilla();
        }
    }
}
