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
    public partial class FrmCliente : Form
    {
        private List<Cliente> listaClientes;

        public FrmCliente()
        {
            InitializeComponent();
            Text = "Gestion Cliente:";
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            ArregloDataGridView(dgv_clientes);
        }
        private void CargarGrilla()
        {
            //logica del dataGridView
            CN_Cliente _Cliente = new CN_Cliente();

            listaClientes = _Cliente.ListaCliente();

            dgv_clientes.DataSource = listaClientes;
            lbl_total.Text = "Total de Registros:  " + Convert.ToString(dgv_clientes.Rows.Count);
            lbl_resultado.Text = "";

        }
        private void ArregloDataGridView(DataGridView dgv_clientes)
        {

            //logica del dataGridView
            CN_Metodos _Metodos = new CN_Metodos();
            //UrlImagen
            dgv_clientes.Columns["UrlImagen"].Visible = false;

            dgv_clientes.Columns["Id_cliente"].Width = 200;// nombre_producto
            dgv_clientes.Columns["Nombre"].Width = 200;// nombre_producto
            dgv_clientes.Columns["Apellido"].Width = 200;// nombre_producto
            dgv_clientes.Columns["Sexo"].Width = 200;// descripcion_producto 
            dgv_clientes.Columns["FechaNacimiento"].Width = 300;// Categoria
            dgv_clientes.Columns["NumeroDocumento"].Width = 300;// Presentacion
            dgv_clientes.Columns["Direccion"].Width = 300;// Presentacion
            dgv_clientes.Columns["Telefono"].Width = 250;// Presentacion
            dgv_clientes.Columns["Email"].Width = 400;// Presentacion


            dgv_clientes.Columns["Id_cliente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_clientes.Columns["Nombre"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_clientes.Columns["Apellido"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_clientes.Columns["Sexo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_clientes.Columns["FechaNacimiento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_clientes.Columns["NumeroDocumento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_clientes.Columns["Direccion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_clientes.Columns["Telefono"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_clientes.Columns["Email"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            _Metodos.AlternarColor(dgv_clientes);
        }


         private void BuscarCliente()
        {
            CN_Cliente _Cliente = new CN_Cliente();

            if (txt_buscar.Text == string.Empty)
            {
                MessageBox.Show("El CAMPO NO PUEDE QUEDAR VACIO!!", "ADVERTENCIA");

                lbl_resultado.Text = "No escribio nada en el campo  'Buscador'.";
            }
            else
            {
                dgv_clientes.DataSource = _Cliente.ClienteBuscar(txt_buscar.Text);

                lbl_total.Text = "Total de Registros Encontrados:" + " " + Convert.ToString(dgv_clientes.Rows.Count);
                lbl_resultado.Text = "Para volver a ver el listado completo 'Limpiar' el campo!!.";
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            BuscarCliente();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_buscar.Clear();
            CargarGrilla();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            CN_Cliente _Cliente = new CN_Cliente();
            Cliente seleccionado;


            try
            {
                DialogResult respuesta = MessageBox.Show("¿Quieres Eliminar este Cliente?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Cliente)dgv_clientes.CurrentRow.DataBoundItem;
                    _Cliente.EliminarCliente(seleccionado.Id_cliente);

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
            Cliente seleccionado;
            DialogResult respuesta = MessageBox.Show("¿Quieres Editar este Cliente?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (respuesta == DialogResult.Yes)
            {
                seleccionado = (Cliente)dgv_clientes.CurrentRow.DataBoundItem;
                FrmArgregarEditarCliente frmEditar = new FrmArgregarEditarCliente(seleccionado);
                frmEditar.ShowDialog();
                CargarGrilla();
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            FrmArgregarEditarCliente frmCliente = new FrmArgregarEditarCliente();
            frmCliente.ShowDialog();
            CargarGrilla();
        }

        private void dgv_clientes_SelectionChanged(object sender, EventArgs e)
        {
            Cliente seleccionado = (Cliente)dgv_clientes.CurrentRow.DataBoundItem;

            CN_Metodos _Metodos = new CN_Metodos();

            _Metodos.CargarImg(pbx_img, seleccionado.UrlImagen);
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            FrmRepoteCliente frmRepote = new FrmRepoteCliente();
            frmRepote.ShowDialog();

        }
    }
}
