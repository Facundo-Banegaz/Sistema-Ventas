using CapaDominio;
using CapaNegocio;
using System;
using System.Collections;
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
    public partial class FrmAgregarEditarVenta : Form
    {
        //private decimal precioCompra;
        //private decimal stock;
        private int cantidad;
        private decimal precioVenta;
        private decimal totalPagado = 0;
        public Trabajador _Trabajador;
        public FrmAgregarEditarVenta()
        {
            InitializeComponent();
            Text = "Agregar Venta";
        }
        public FrmAgregarEditarVenta( Trabajador trabajador)
        {
            InitializeComponent();
            this._Trabajador = trabajador;
        }
        private void FrmAgregarEditarVenta_Load(object sender, EventArgs e)
        {
            CargarCbo();
            CargarTextBox();
            CargarCboComprobante();
            MostrarTabla();
            ArregloDataGridView(dgv_detalles_ventas);
            // Deshabilitar un ComboBox
            dtp_fecha.Enabled = false;


        }

        private void CargarCbo()
        {
            CN_Cliente _Cliente = new CN_Cliente();
            CN_Categoria _Categoria = new CN_Categoria();
            try
            {
                cbo_cliente.DataSource = _Cliente.CargarCbo();
                cbo_cliente.ValueMember = "Id_cliente";
                cbo_cliente.DisplayMember = "Nombre";

                cbo_cat.DataSource = _Categoria.CargarCbo();
                cbo_cat.ValueMember = "Id_categoria";
                cbo_cat.DisplayMember = "Nombre";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }

        private void CargarTextBox()
        {
            CN_Metodos _Metodos = new CN_Metodos();
            try
            {
                txt_numero.Text = _Metodos.GenerarCodigo("Ingreso");
                txt_serie.Text = _Metodos.GenerarCodigo("Ingreso");
                txt_codigo.Text = _Metodos.GenerarCodigo("Ingreso");
            }
            catch (Exception)
            {
                throw;
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

            try
            {
                Categoria categoriaSeleccionada = (Categoria)cbo_cat.SelectedItem;
                int Id_categoria = categoriaSeleccionada.Id_categoria;

                cbo_articulo.DataSource = _Articulo.CargarCbo(Id_categoria);
                cbo_articulo.ValueMember = "Id_articulo";
                cbo_articulo.DisplayMember = "Nombre";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
        private void cbo_articulo_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                if (cbo_articulo.SelectedItem != null)
                {
                    // Obtener el artículo seleccionado del ComboBox
                    Articulo articuloSeleccionado = (Articulo)cbo_articulo.SelectedItem;
                    int Id_articulo = (int)articuloSeleccionado.Id_articulo;

                    // Mostrar la cantidad de stock en el TextBox
                    CargarStock(Id_articulo);
                }
                else
                {
                    txt_stock.Text = ""; // Limpiar el TextBox si no hay artículo seleccionado
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void CargarStock(int Id_articulo)
        {
            CN_Articulo _Articulo = new CN_Articulo();

            try
            {
                // Llamar a tu función para cargar el stock
                List<Articulo> listaArticulos = _Articulo.CargarCboPorCan(Id_articulo);

                // Verificar si se encontró algún artículo
                if (listaArticulos.Count > 0)
                {
                    // Obtener el primer artículo de la lista (debería haber solo uno)
                    Articulo articulo = listaArticulos[0];

                    // Mostrar el stock en el TextBox
                    txt_stock.Text = articulo.Stock.ToString();
                    txt_precio_compra.Text= articulo.Precio_Compra.ToString();
                    txt_precio_venta.Text = articulo.Precio_Venta.ToString();
                    dtp_fecha_vencimiento.Value = articulo.Fecha_Vencimiento;
                    lbl_id_detalle_ingreso.Text = articulo.Id_detalle_ingreso.ToString();
                }
                else
                {
                    // Si no se encontró el artículo, limpiar el TextBox
                    txt_stock.Text = "";
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción aquí
                MessageBox.Show("Error al cargar el stock: " + ex.Message);
            }
        }
        //Crea la tabla de Detalle 


        private void MostrarTabla()
        {

            // Agregar las columnas al DataGridView
            dgv_detalles_ventas.Columns.Add("Id_detalle_ingreso", "Id_detalle_ingreso");
            dgv_detalles_ventas.Columns.Add("Articulo", "Articulo");
            dgv_detalles_ventas.Columns.Add("cantidad", "cantidad");
            dgv_detalles_ventas.Columns.Add("Precio_venta", "Precio_venta");
            dgv_detalles_ventas.Columns.Add("Descuento", "Descuento");
            dgv_detalles_ventas.Columns.Add("Subtotal", "Subtotal");
        }

        private void ArregloDataGridView(DataGridView dgv_productos)
        {

            //logica del dataGridView
            CN_Metodos _Metodos = new CN_Metodos();


            dgv_productos.Columns["Id_detalle_ingreso"].Width = 250;
            dgv_productos.Columns["Articulo"].Width = 450;// nombre_producto
            dgv_productos.Columns["cantidad"].Width = 300;// nombre_producto
            dgv_productos.Columns["Precio_venta"].Width = 300;// nombre_producto
            dgv_productos.Columns["Descuento"].Width = 300;// descripcion_producto 
            dgv_productos.Columns["Subtotal"].Width = 300;// Categoria



            dgv_productos.Columns["Id_detalle_ingreso"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Articulo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Precio_venta"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Descuento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Subtotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Subtotal"].DefaultCellStyle.Format = "N0";

            _Metodos.AlternarColor(dgv_productos);
        }



        //Limpiar todos los controles del formulario
        private void Limpiar()
        {

            txt_stock.Clear();
            txt_precio_compra.Clear();
            txt_precio_venta.Clear();
            txt_cantidad.Clear();
            dtp_fecha_vencimiento.Value = DateTime.Today;
            txt_descuento.Clear();

        }
        private void AgregarFila()
        {
            try
            {

                if (ValidarVacioDetalle())
                {
                    // Obtener el artículo seleccionado
                    Articulo articuloSeleccionado = (Articulo)cbo_articulo.SelectedItem;

                    // Verificar si el artículo ya está presente en el DataGridView
                    bool articuloYaPresente = false;
                    foreach (DataGridViewRow row in dgv_detalles_ventas.Rows)
                    {
                        int idArticuloExistente = Convert.ToInt32(lbl_id_detalle_ingreso.Text);
                        if (idArticuloExistente == Convert.ToInt32(row.Cells[0].Value))
                        {
                            articuloYaPresente = true;

                            MessageBox.Show("¡El artículo ya se encuentra en el detalle!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Limpiar();
                            // Salir del método después de actualizar los valores
                            return;
                        }
                    }

                    // Verificar si la cantidad a agregar supera el stock disponible
                    cantidad = Convert.ToInt32(txt_cantidad.Text);
                    int  stock = Convert.ToInt32(txt_stock.Text);
                    if (cantidad > stock)
                    {
                        MessageBox.Show("La cantidad a comprar supera el stock disponible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        txt_cantidad.Clear();
                        return;
                    }

                    // Si el artículo no está presente, agregar una nueva fila al DataGridView
                    if (!articuloYaPresente)
                    {


                        // Si el artículo no está presente, agregar una nueva fila al DataGridView
                        DataGridViewRow fila = new DataGridViewRow();
                        fila.CreateCells(dgv_detalles_ventas);

                        // Convertir los valores de los TextBox a decimal
               
                        precioVenta = Convert.ToDecimal(txt_precio_venta.Text);
               
                        cantidad= Convert.ToInt32(txt_cantidad.Text);



                        // Asignar los valores de las celdas
                        fila.Cells[0].Value = Convert.ToInt32(lbl_id_detalle_ingreso.Text);
                        fila.Cells[1].Value = articuloSeleccionado.Nombre;
                        fila.Cells[2].Value = cantidad;
                        fila.Cells[3].Value = precioVenta;
                        fila.Cells[4].Value = Convert.ToDecimal(txt_descuento.Text);
                        decimal subtotal = precioVenta * cantidad;
                        fila.Cells[5].Value = subtotal;
                        totalPagado += subtotal;
                        lbl_total.Text = "Total a Pagar $: " + totalPagado.ToString("N2");

                        dgv_detalles_ventas.Rows.Add(fila);
                        // habilitar un ComboBox
                        cbo_articulo.Enabled = true;
                        cbo_cat.Enabled = true;
                        Limpiar();
                    }
                }
                else
                {
                    MessageBox.Show("Debe Completar Todos los Campos!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar fila: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void QuitarFila()
        {
            try
            {
                if (dgv_detalles_ventas.CurrentRow != null)
                {
                    DialogResult respuesta = MessageBox.Show("¿Quieres eliminar esta Venta?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (respuesta == DialogResult.Yes)
                    {
                        // Obtener la fila seleccionada
                        DataGridViewRow filaSeleccionada = dgv_detalles_ventas.CurrentRow;

                        // Restar el subtotal al totalPagado
                        decimal subtotal = Convert.ToDecimal(filaSeleccionada.Cells["Subtotal"].Value);
                        totalPagado -= subtotal;

                        // Quitar la fila seleccionada del DataGridView
                        dgv_detalles_ventas.Rows.Remove(filaSeleccionada);

                        // Actualizar el texto del total
                        lbl_total.Text = "Total a Pagar $: " + totalPagado.ToString("N2");
                        // habilitar un ComboBox
                        cbo_articulo.Enabled = true;
                        cbo_cat.Enabled = true;
                        btn_agregar.Enabled = true;
                        // Mostrar mensaje de éxito


                        Limpiar();
                    }
                }
                else
                {
                    MessageBox.Show("No hay una fila seleccionada para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al quitar fila: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void GuardarVenta()
        {
            CN_Venta _CN_Venta = new CN_Venta();
   


            try
            {
                // Verificar si el DataGridView está vacío
                if (dgv_detalles_ventas.Rows.Count == 0)
                {
                    MessageBox.Show("Debe agregar al menos un detalle de Venta.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (ValidarVacio())
                {
                    errorIcono.Clear();
                    Venta venta = new Venta();

                    List<Detalle_Venta> _Detalle_Venta = new List<Detalle_Venta>();



                    venta.Trabajador = new Trabajador();
                    venta.Trabajador.Id_trabajador = _Trabajador.Id_trabajador;
                    venta.Cliente = (Cliente)cbo_cliente.SelectedItem;
                    venta.Fecha = dtp_fecha.Value;
                    venta.Tipo_Comprobante = (string)cbo_comprobante.SelectedItem;
                    venta.Serie = txt_serie.Text;
                    venta.Correlativo = txt_numero.Text;
                    venta.Iva = decimal.Parse(txt_iva.Text);
                    venta.Estado = "EMITIDO";




                    foreach (DataGridViewRow fila in dgv_detalles_ventas.Rows)
                    {
                        Detalle_Venta detalle = new Detalle_Venta();


                        detalle.Venta = new Venta();

                        detalle.Detalle_Ingreso = new Detalle_Ingreso();


                        detalle.Detalle_Ingreso.Id_detalle_ingreso = (int)fila.Cells["Id_detalle_ingreso"].Value;
                        detalle.Cantidad = (int)fila.Cells["Cantidad"].Value;
                        detalle.Precio_Venta = (decimal)fila.Cells["Precio_venta"].Value;
                        detalle.Descuento = (decimal)fila.Cells["Descuento"].Value;

                        _Detalle_Venta.Add(detalle);

                        // Llamar a la función para disminuir el stock
                        _CN_Venta.DisminuirStock(detalle.Detalle_Ingreso.Id_detalle_ingreso, detalle.Cantidad);

                    }

                    _CN_Venta.InsertarVenta(venta, _Detalle_Venta);

                    MessageBox.Show("La venta   Fue Agregada Exitosamente!!", "Agregado");



                    this.Close();

                }
                else
                {
                    MessageBox.Show("Debe Completar Todos los Campos!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.ToString());
            }


        }

        private bool ValidarVacioDetalle()
        {
            bool error = true;

            if (txt_stock.Text == string.Empty)
            {
                errorIcono.SetError(txt_stock, "El campo es obligatorio, ingrese el Stock");
                error = false;
            }
            else if (txt_precio_compra.Text == string.Empty)
            {
                errorIcono.SetError(txt_precio_compra, "El campo es obligatorio, ingrese el Precio Inicial");
                error = false;
            }
            else if (txt_precio_venta.Text == string.Empty)
            {
                errorIcono.SetError(txt_precio_venta, "El campo es obligatorio, ingrese el Precio de Venta");
                error = false;
            }

            else if (dtp_fecha_vencimiento.Value == DateTime.MinValue)
            {
                errorIcono.SetError(dtp_fecha_vencimiento, "Debe completar el campo Fecha Vencimiento");
                error = false;
            }
            else if (cbo_articulo.SelectedItem == null)
            {
                errorIcono.SetError(cbo_articulo, "La categoria seleccionada no tiene Articulos");
                error = false;
            }
            else if (txt_cantidad.Text == string.Empty)
            {
                errorIcono.SetError(txt_cantidad, "El campo es obligatorio, ingrese la Cantidad ");
                error = false;
            }
            else if (txt_descuento.Text == string.Empty)
            {
                errorIcono.SetError(txt_descuento, "El campo es obligatorio, ingrese el Descuento ");
                error = false;
            }
            else
            {
                errorIcono.Clear();
            }

            return error;
        }
        private bool ValidarVacio()
        {
            bool error = true;

            if (cbo_comprobante.SelectedIndex == 0)
            {
                MessageBox.Show("Por favor, seleccione el Comprobante.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            else
            {
                errorIcono.Clear();
            }

            return error;
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            AgregarFila();
        }


        private void btn_quitar_Click(object sender, EventArgs e)
        {
            QuitarFila();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            GuardarVenta();
        }


        private void txt_precio_compra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_precio_venta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_iva_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter presionado no es un número, el carácter de retroceso, ni el carácter decimal
            if (!(char.IsDigit(e.KeyChar)) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == '.' || e.KeyChar == ','))
            {
                MessageBox.Show("Solo se permiten números y el carácter decimal.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_descuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter presionado no es un número, el carácter de retroceso, ni el carácter decimal
            if (!(char.IsDigit(e.KeyChar)) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == '.' || e.KeyChar == ','))
            {
                MessageBox.Show("Solo se permiten números y el carácter decimal.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
