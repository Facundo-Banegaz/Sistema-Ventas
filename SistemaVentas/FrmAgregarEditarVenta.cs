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
            //ArregloDataGridView(dgv_detalles_ingresos);
            //// Deshabilitar un ComboBox
            //btn_editar.Enabled = false;
            //dtp_fecha.Enabled = false;
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
                // Obtener el artículo seleccionado del ComboBox
                Articulo articuloSeleccionado = (Articulo)cbo_articulo.SelectedItem;

                // Mostrar la cantidad de stock en el TextBox
                txt_stock.Text = articuloSeleccionado.Stock.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }


        //Crea la tabla de Detalle 


        private void MostrarTabla()
        {

            // Agregar las columnas al DataGridView
            dgv_detalles_ventas.Columns.Add("Id_detalle_ingreso", "Id_detalle_ingreso");
            dgv_detalles_ventas.Columns.Add("Articulo", "Articulo");
            dgv_detalles_ventas.Columns.Add("cantidad", "cantidad");
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
            dgv_productos.Columns["Descuento"].Width = 300;// descripcion_producto 
            dgv_productos.Columns["Subtotal"].Width = 300;// Categoria



            dgv_productos.Columns["Id_detalle_ingreso"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Articulo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Descuento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Subtotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
     

            _Metodos.AlternarColor(dgv_productos);
        }



        //Limpiar todos los controles del formulario
        private void Limpiar()
        {
        //    dtp_fecha.Value = DateTime.Today;
        //    cbo_comprobante.SelectedIndex = 0;
            txt_stock.Clear();
            txt_precio_compra.Clear();
            txt_precio_venta.Clear();
            dtp_fecha_vencimiento.Value = DateTime.Today;

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
                        int idArticuloExistente = Convert.ToInt32(row.Cells[0].Value);
                        if (idArticuloExistente == articuloSeleccionado.Id_articulo)
                        {
                            articuloYaPresente = true;

                            MessageBox.Show("¡El artículo ya se encuentra en el detalle!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Limpiar();
                            // Salir del método después de actualizar los valores
                            return;
                        }
                    }
                    // Si el artículo no está presente, agregar una nueva fila al DataGridView
                    if (!articuloYaPresente)
                    {


                        // Si el artículo no está presente, agregar una nueva fila al DataGridView
                        DataGridViewRow fila = new DataGridViewRow();
                        fila.CreateCells(dgv_detalles_ventas);

                        // Convertir los valores de los TextBox a decimal
                        precioCompra = Convert.ToDecimal(txt_precio_compra.Text);
                        precioVenta = Convert.ToDecimal(txt_precio_venta.Text);
                        stock = Convert.ToDecimal(txt_stock.Text);

                        // Asignar los valores de las celdas
                        fila.Cells[0].Value = articuloSeleccionado.Id_articulo;
                        fila.Cells[1].Value = articuloSeleccionado.Nombre;
                        fila.Cells[2].Value = precioCompra;
                        fila.Cells[3].Value = precioVenta;
                        fila.Cells[4].Value = stock;
                        fila.Cells[5].Value = dtp_fecha_produccion.Value.ToString("yyyy-MM-dd");
                        fila.Cells[6].Value = dtp_fecha_vencimiento.Value.ToString("yyyy-MM-dd");

                        decimal subtotal = precioCompra * stock;
                        fila.Cells[7].Value = subtotal;
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


        private void VerFila()
        {
            try
            {
                // Verificar si hay alguna fila seleccionada
                if (dgv_detalles_ventas.CurrentRow != null)
                {
                    DialogResult respuesta = MessageBox.Show("¿Quieres Modificar este Ingreso?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (respuesta == DialogResult.Yes)
                    {
                        // Obtener la fila seleccionada
                        DataGridViewRow filaSeleccionada = dgv_detalles_ventas.CurrentRow;

                        // Obtener los valores de las celdas de la fila seleccionada

                        precioCompra = Convert.ToDecimal(filaSeleccionada.Cells[2].Value);
                        precioVenta = Convert.ToDecimal(filaSeleccionada.Cells[3].Value);
                        stock = Convert.ToInt32(filaSeleccionada.Cells[4].Value);
                        DateTime fechaProduccion = Convert.ToDateTime(filaSeleccionada.Cells[5].Value);
                        DateTime fechaVencimiento = Convert.ToDateTime(filaSeleccionada.Cells[6].Value);


                        // Asignar los valores a tus campos
                        // Supongamos que tienes campos llamados txtIdArticulo, txtNombreArticulo, etc.

                        txt_precio_compra.Text = precioCompra.ToString();
                        txt_precio_venta.Text = precioVenta.ToString();
                        txt_stock.Text = stock.ToString();
                        dtp_fecha_produccion.Value = fechaProduccion;
                        dtp_fecha_vencimiento.Value = fechaVencimiento;



                        // Deshabilitar un ComboBox
                        cbo_articulo.Enabled = false;
                        cbo_cat.Enabled = false;
                        btn_agregar.Enabled = false;
                        // Habilitar un btn
                        btn_editar.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("No hay una fila seleccionada para Modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar fila: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ModificarFila()
        {
            try
            {
                if (ValidarVacioDetalle())
                {
                    // Obtener el artículo seleccionado
                    Articulo articuloSeleccionado = (Articulo)cbo_articulo.SelectedItem;

                    // Verificar si el artículo ya está presente en el DataGridView
                    foreach (DataGridViewRow row in dgv_detalles_ventas.Rows)
                    {
                        int idArticuloExistente = Convert.ToInt32(row.Cells[0].Value);
                        if (idArticuloExistente == articuloSeleccionado.Id_articulo)
                        {


                            // Si el artículo está presente, actualizar los valores de las celdas en la fila correspondiente
                            row.Cells[2].Value = txt_precio_compra.Text;
                            row.Cells[3].Value = txt_precio_venta.Text;
                            row.Cells[4].Value = txt_stock.Text;
                            row.Cells[5].Value = dtp_fecha_produccion.Value.ToString("yyyy-MM-dd");
                            row.Cells[6].Value = dtp_fecha_vencimiento.Value.ToString("yyyy-MM-dd");

                            precioCompra = Convert.ToDecimal(txt_precio_compra.Text);
                            precioVenta = Convert.ToDecimal(txt_precio_venta.Text);
                            stock = Convert.ToDecimal(txt_stock.Text);
                            subtotal = precioCompra * stock;
                            row.Cells[7].Value = subtotal;

                            totalPagado += subtotal;
                            lbl_total.Text = "Total a Pagar $: " + totalPagado.ToString("N2");

                            // Limpiar los controles después de actualizar la fila

                            Limpiar();
                            // Habilitar un ComboBox
                            cbo_articulo.Enabled = true;
                            cbo_cat.Enabled = true;
                            btn_agregar.Enabled = true;
                            btn_editar.Enabled = false;

                            // Salir del método después de actualizar los valores
                            return;
                        }
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
                    DialogResult respuesta = MessageBox.Show("¿Quieres eliminar este Ingreso?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

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



        private void GuardarIngreso()
        {
            CN_Ingreso _CN_Ingreso = new CN_Ingreso();
            CN_Detalle_Ingreso _CN_Detalle_Ingreso = new CN_Detalle_Ingreso();


            try
            {

                if (ValidarVacio())
                {
                    errorIcono.Clear();
                    Ingreso _Ingreso = new Ingreso();
                    List<Detalle_Ingreso> _Detalle_Ingreso = new List<Detalle_Ingreso>();



                    _Ingreso.Trabajador = new Trabajador();
                    _Ingreso.Trabajador.Id_trabajador = _Trabajador.Id_trabajador;
                    _Ingreso.Proveedor = (Proveedor)cbo_cliente.SelectedItem;
                    _Ingreso.Fecha = dtp_fecha.Value;
                    _Ingreso.Tipo_Comprobante = (string)cbo_comprobante.SelectedItem;
                    _Ingreso.Serie = txt_serie.Text;
                    _Ingreso.Correlativo = txt_numero.Text;
                    _Ingreso.Iva = decimal.Parse(txt_iva.Text);
                    _Ingreso.Estado = "EMITIDO";




                    foreach (DataGridViewRow fila in dgv_detalles_ventas.Rows)
                    {
                        Detalle_Ingreso detalle = new Detalle_Ingreso();


                        detalle.Ingreso = new Ingreso();

                        detalle.Articulo = new Articulo();

                        detalle.Articulo.Id_articulo = (int)fila.Cells["Id_articulo"].Value;
                        detalle.Articulo.Nombre = (string)fila.Cells["Articulo"].Value;
                        detalle.Precio_Compra = (decimal)fila.Cells["Precio_compra"].Value;
                        detalle.Precio_Venta = (decimal)fila.Cells["Precio_venta"].Value;
                        detalle.Stock_Inicial = Convert.ToInt32(fila.Cells["Stock_inicial"].Value);
                        detalle.Fecha_Produccion = Convert.ToDateTime(fila.Cells["Fecha_produccion"].Value);
                        detalle.Fecha_Vencimiento = Convert.ToDateTime(fila.Cells["Fecha_vencimiento"].Value);
                        detalle.SubTotal = (decimal)fila.Cells["Subtotal"].Value;

                        _Detalle_Ingreso.Add(detalle);
                    }

                    _CN_Ingreso.InsertarIngreso(_Ingreso, _Detalle_Ingreso);

                    MessageBox.Show("El Ingreso  Fue Agregada Exitosamente!!", "Agregado");
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
            else if (dtp_fecha_produccion.Value == DateTime.MinValue)
            {
                errorIcono.SetError(dtp_fecha_produccion, "Debe completar el campo Fecha Produccion");
                error = false;
            }
            else if (dtp_fecha_vencimiento.Value == DateTime.MinValue)
            {
                errorIcono.SetError(dtp_fecha_vencimiento, "Debe completar el campo Fecha Vencimiento");
                error = false;
            }
            // Validación de fechas de producción y vencimiento
            else if (dtp_fecha_produccion.Value >= dtp_fecha_vencimiento.Value)
            {
                errorIcono.SetError(dtp_fecha_produccion, "La fecha de producción debe ser anterior a la fecha de vencimiento");
                errorIcono.SetError(dtp_fecha_vencimiento, "La fecha de vencimiento debe ser posterior a la fecha de producción");
                error = false;
            }
            else if (cbo_articulo.SelectedItem == null)
            {
                errorIcono.SetError(cbo_articulo, "La categoria seleccionada no tiene Articulos");
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

        private void btn_editar_Click(object sender, EventArgs e)
        {
            ModificarFila();
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
            GuardarIngreso();
        }

        private void txt_stock_KeyPress(object sender, KeyPressEventArgs e)
        {

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
    }
}
