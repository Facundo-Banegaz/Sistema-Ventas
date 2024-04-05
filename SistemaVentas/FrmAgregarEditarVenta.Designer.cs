namespace SistemaVentas
{
    partial class FrmAgregarEditarVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarEditarVenta));
            this.dgv_detalle_ingreso = new System.Windows.Forms.GroupBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.dgv_detalles_ventas = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_iva = new System.Windows.Forms.TextBox();
            this.cbo_cliente = new System.Windows.Forms.ComboBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.cbo_comprobante = new System.Windows.Forms.ComboBox();
            this.lbl_comprobante = new System.Windows.Forms.Label();
            this.pl_art = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_editar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbo_cat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_articulo = new System.Windows.Forms.ComboBox();
            this.btn_quitar = new System.Windows.Forms.Button();
            this.dtp_fecha_vencimiento = new System.Windows.Forms.DateTimePicker();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_img = new System.Windows.Forms.Label();
            this.txt_precio_compra = new System.Windows.Forms.TextBox();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.txt_precio_venta = new System.Windows.Forms.TextBox();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_stock = new System.Windows.Forms.Label();
            this.lbl_cat = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.lbl_sector = new System.Windows.Forms.Label();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.lbl_iva = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_serie = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgv_detalle_ingreso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalles_ventas)).BeginInit();
            this.pl_art.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_detalle_ingreso
            // 
            this.dgv_detalle_ingreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_detalle_ingreso.Controls.Add(this.txt_codigo);
            this.dgv_detalle_ingreso.Controls.Add(this.dgv_detalles_ventas);
            this.dgv_detalle_ingreso.Controls.Add(this.label6);
            this.dgv_detalle_ingreso.Controls.Add(this.txt_iva);
            this.dgv_detalle_ingreso.Controls.Add(this.cbo_cliente);
            this.dgv_detalle_ingreso.Controls.Add(this.lbl_total);
            this.dgv_detalle_ingreso.Controls.Add(this.btn_cancelar);
            this.dgv_detalle_ingreso.Controls.Add(this.btn_guardar);
            this.dgv_detalle_ingreso.Controls.Add(this.cbo_comprobante);
            this.dgv_detalle_ingreso.Controls.Add(this.lbl_comprobante);
            this.dgv_detalle_ingreso.Controls.Add(this.pl_art);
            this.dgv_detalle_ingreso.Controls.Add(this.txt_numero);
            this.dgv_detalle_ingreso.Controls.Add(this.lbl_sector);
            this.dgv_detalle_ingreso.Controls.Add(this.dtp_fecha);
            this.dgv_detalle_ingreso.Controls.Add(this.lbl_iva);
            this.dgv_detalle_ingreso.Controls.Add(this.label5);
            this.dgv_detalle_ingreso.Controls.Add(this.lbl_fecha);
            this.dgv_detalle_ingreso.Controls.Add(this.lbl_nombre);
            this.dgv_detalle_ingreso.Controls.Add(this.txt_serie);
            this.dgv_detalle_ingreso.Controls.Add(this.label4);
            this.dgv_detalle_ingreso.Location = new System.Drawing.Point(7, 12);
            this.dgv_detalle_ingreso.Name = "dgv_detalle_ingreso";
            this.dgv_detalle_ingreso.Size = new System.Drawing.Size(1833, 920);
            this.dgv_detalle_ingreso.TabIndex = 173;
            this.dgv_detalle_ingreso.TabStop = false;
            this.dgv_detalle_ingreso.Text = "Ingresos Almacén";
            // 
            // txt_codigo
            // 
            this.txt_codigo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_codigo.Enabled = false;
            this.txt_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo.Location = new System.Drawing.Point(164, 86);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.ReadOnly = true;
            this.txt_codigo.Size = new System.Drawing.Size(379, 35);
            this.txt_codigo.TabIndex = 184;
            this.txt_codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgv_detalles_ventas
            // 
            this.dgv_detalles_ventas.AllowUserToAddRows = false;
            this.dgv_detalles_ventas.AllowUserToDeleteRows = false;
            this.dgv_detalles_ventas.AllowUserToOrderColumns = true;
            this.dgv_detalles_ventas.AllowUserToResizeRows = false;
            this.dgv_detalles_ventas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_detalles_ventas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_detalles_ventas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_detalles_ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_detalles_ventas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_detalles_ventas.EnableHeadersVisualStyles = false;
            this.dgv_detalles_ventas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgv_detalles_ventas.Location = new System.Drawing.Point(6, 525);
            this.dgv_detalles_ventas.Name = "dgv_detalles_ventas";
            this.dgv_detalles_ventas.ReadOnly = true;
            this.dgv_detalles_ventas.RowHeadersVisible = false;
            this.dgv_detalles_ventas.RowHeadersWidth = 62;
            this.dgv_detalles_ventas.RowTemplate.Height = 28;
            this.dgv_detalles_ventas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_detalles_ventas.Size = new System.Drawing.Size(1816, 316);
            this.dgv_detalles_ventas.TabIndex = 183;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(1738, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 35);
            this.label6.TabIndex = 182;
            this.label6.Text = "%";
            // 
            // txt_iva
            // 
            this.txt_iva.BackColor = System.Drawing.Color.GhostWhite;
            this.txt_iva.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_iva.ForeColor = System.Drawing.Color.OrangeRed;
            this.txt_iva.Location = new System.Drawing.Point(1613, 222);
            this.txt_iva.Name = "txt_iva";
            this.txt_iva.ReadOnly = true;
            this.txt_iva.Size = new System.Drawing.Size(119, 42);
            this.txt_iva.TabIndex = 181;
            this.txt_iva.Text = "21";
            this.txt_iva.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_iva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_iva_KeyPress);
            // 
            // cbo_cliente
            // 
            this.cbo_cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_cliente.FormattingEnabled = true;
            this.cbo_cliente.Location = new System.Drawing.Point(656, 88);
            this.cbo_cliente.Name = "cbo_cliente";
            this.cbo_cliente.Size = new System.Drawing.Size(425, 34);
            this.cbo_cliente.TabIndex = 180;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.BackColor = System.Drawing.SystemColors.ControlText;
            this.lbl_total.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.Color.LawnGreen;
            this.lbl_total.Location = new System.Drawing.Point(10, 847);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(0, 35);
            this.lbl_total.TabIndex = 179;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancelar.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancelar.Image")));
            this.btn_cancelar.Location = new System.Drawing.Point(1625, 847);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(197, 66);
            this.btn_cancelar.TabIndex = 178;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_guardar.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_guardar.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guardar.Location = new System.Drawing.Point(1359, 847);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(180, 66);
            this.btn_guardar.TabIndex = 177;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // cbo_comprobante
            // 
            this.cbo_comprobante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_comprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_comprobante.FormattingEnabled = true;
            this.cbo_comprobante.Location = new System.Drawing.Point(34, 231);
            this.cbo_comprobante.Name = "cbo_comprobante";
            this.cbo_comprobante.Size = new System.Drawing.Size(425, 34);
            this.cbo_comprobante.TabIndex = 175;
            // 
            // lbl_comprobante
            // 
            this.lbl_comprobante.AutoSize = true;
            this.lbl_comprobante.BackColor = System.Drawing.Color.Black;
            this.lbl_comprobante.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_comprobante.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_comprobante.Location = new System.Drawing.Point(153, 168);
            this.lbl_comprobante.Name = "lbl_comprobante";
            this.lbl_comprobante.Size = new System.Drawing.Size(179, 35);
            this.lbl_comprobante.TabIndex = 174;
            this.lbl_comprobante.Text = "Comprobante:";
            // 
            // pl_art
            // 
            this.pl_art.BackColor = System.Drawing.Color.DodgerBlue;
            this.pl_art.Controls.Add(this.textBox2);
            this.pl_art.Controls.Add(this.label8);
            this.pl_art.Controls.Add(this.label7);
            this.pl_art.Controls.Add(this.btn_editar);
            this.pl_art.Controls.Add(this.textBox1);
            this.pl_art.Controls.Add(this.cbo_cat);
            this.pl_art.Controls.Add(this.label3);
            this.pl_art.Controls.Add(this.cbo_articulo);
            this.pl_art.Controls.Add(this.btn_quitar);
            this.pl_art.Controls.Add(this.dtp_fecha_vencimiento);
            this.pl_art.Controls.Add(this.btn_agregar);
            this.pl_art.Controls.Add(this.label2);
            this.pl_art.Controls.Add(this.lb_img);
            this.pl_art.Controls.Add(this.txt_precio_compra);
            this.pl_art.Controls.Add(this.lbl_precio);
            this.pl_art.Controls.Add(this.txt_precio_venta);
            this.pl_art.Controls.Add(this.txt_stock);
            this.pl_art.Controls.Add(this.label1);
            this.pl_art.Controls.Add(this.lbl_stock);
            this.pl_art.Controls.Add(this.lbl_cat);
            this.pl_art.Location = new System.Drawing.Point(6, 290);
            this.pl_art.Name = "pl_art";
            this.pl_art.Size = new System.Drawing.Size(1816, 229);
            this.pl_art.TabIndex = 173;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(606, 175);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(299, 35);
            this.textBox2.TabIndex = 187;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Impact", 13F);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(680, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 33);
            this.label8.TabIndex = 188;
            this.label8.Text = "Cantidad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(1597, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 35);
            this.label7.TabIndex = 186;
            this.label7.Text = "%";
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.Orange;
            this.btn_editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editar.Image = ((System.Drawing.Image)(resources.GetObject("btn_editar.Image")));
            this.btn_editar.Location = new System.Drawing.Point(1714, 85);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(86, 60);
            this.btn_editar.TabIndex = 184;
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox1.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.OrangeRed;
            this.textBox1.Location = new System.Drawing.Point(1472, 160);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(119, 42);
            this.textBox1.TabIndex = 185;
            this.textBox1.Text = "5";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbo_cat
            // 
            this.cbo_cat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_cat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_cat.FormattingEnabled = true;
            this.cbo_cat.Location = new System.Drawing.Point(10, 66);
            this.cbo_cat.Name = "cbo_cat";
            this.cbo_cat.Size = new System.Drawing.Size(537, 34);
            this.cbo_cat.TabIndex = 183;
            this.cbo_cat.SelectedIndexChanged += new System.EventHandler(this.cbo_cat_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(130, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 35);
            this.label3.TabIndex = 182;
            this.label3.Text = "Seleccionar  Artículo:";
            // 
            // cbo_articulo
            // 
            this.cbo_articulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_articulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_articulo.FormattingEnabled = true;
            this.cbo_articulo.Location = new System.Drawing.Point(10, 176);
            this.cbo_articulo.Name = "cbo_articulo";
            this.cbo_articulo.Size = new System.Drawing.Size(537, 34);
            this.cbo_articulo.TabIndex = 181;
            // 
            // btn_quitar
            // 
            this.btn_quitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(192)))));
            this.btn_quitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_quitar.Image = ((System.Drawing.Image)(resources.GetObject("btn_quitar.Image")));
            this.btn_quitar.Location = new System.Drawing.Point(1714, 160);
            this.btn_quitar.Name = "btn_quitar";
            this.btn_quitar.Size = new System.Drawing.Size(86, 60);
            this.btn_quitar.TabIndex = 175;
            this.btn_quitar.UseVisualStyleBackColor = false;
            this.btn_quitar.Click += new System.EventHandler(this.btn_quitar_Click);
            // 
            // dtp_fecha_vencimiento
            // 
            this.dtp_fecha_vencimiento.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtp_fecha_vencimiento.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecha_vencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_vencimiento.Location = new System.Drawing.Point(1322, 66);
            this.dtp_fecha_vencimiento.Name = "dtp_fecha_vencimiento";
            this.dtp_fecha_vencimiento.Size = new System.Drawing.Size(319, 37);
            this.dtp_fecha_vencimiento.TabIndex = 180;
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.Green;
            this.btn_agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregar.Image = ((System.Drawing.Image)(resources.GetObject("btn_agregar.Image")));
            this.btn_agregar.Location = new System.Drawing.Point(1714, 10);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(86, 60);
            this.btn_agregar.TabIndex = 174;
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Impact", 13F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(1367, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 33);
            this.label2.TabIndex = 173;
            this.label2.Text = "Fecha Vencimiento:";
            // 
            // lb_img
            // 
            this.lb_img.AutoSize = true;
            this.lb_img.BackColor = System.Drawing.Color.Black;
            this.lb_img.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_img.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_img.Location = new System.Drawing.Point(1316, 166);
            this.lb_img.Name = "lb_img";
            this.lb_img.Size = new System.Drawing.Size(144, 35);
            this.lb_img.TabIndex = 171;
            this.lb_img.Text = "Descuento:";
            // 
            // txt_precio_compra
            // 
            this.txt_precio_compra.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_precio_compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio_compra.Location = new System.Drawing.Point(948, 65);
            this.txt_precio_compra.Name = "txt_precio_compra";
            this.txt_precio_compra.Size = new System.Drawing.Size(319, 35);
            this.txt_precio_compra.TabIndex = 178;
            this.txt_precio_compra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_precio_compra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precio_compra_KeyPress);
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.BackColor = System.Drawing.Color.Black;
            this.lbl_precio.Font = new System.Drawing.Font("Impact", 13F);
            this.lbl_precio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_precio.Location = new System.Drawing.Point(1024, 18);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(175, 33);
            this.lbl_precio.TabIndex = 177;
            this.lbl_precio.Text = "Precio Compra:";
            // 
            // txt_precio_venta
            // 
            this.txt_precio_venta.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_precio_venta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio_venta.Location = new System.Drawing.Point(948, 170);
            this.txt_precio_venta.Name = "txt_precio_venta";
            this.txt_precio_venta.Size = new System.Drawing.Size(319, 35);
            this.txt_precio_venta.TabIndex = 176;
            this.txt_precio_venta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_precio_venta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precio_venta_KeyPress);
            // 
            // txt_stock
            // 
            this.txt_stock.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_stock.Enabled = false;
            this.txt_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stock.Location = new System.Drawing.Point(606, 64);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.ReadOnly = true;
            this.txt_stock.Size = new System.Drawing.Size(299, 35);
            this.txt_stock.TabIndex = 155;
            this.txt_stock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(1024, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 35);
            this.label1.TabIndex = 175;
            this.label1.Text = "Precio Venta:";
            // 
            // lbl_stock
            // 
            this.lbl_stock.AutoSize = true;
            this.lbl_stock.BackColor = System.Drawing.Color.Black;
            this.lbl_stock.Font = new System.Drawing.Font("Impact", 13F);
            this.lbl_stock.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_stock.Location = new System.Drawing.Point(657, 10);
            this.lbl_stock.Name = "lbl_stock";
            this.lbl_stock.Size = new System.Drawing.Size(198, 33);
            this.lbl_stock.TabIndex = 173;
            this.lbl_stock.Text = "Stock Disponible:";
            // 
            // lbl_cat
            // 
            this.lbl_cat.AutoSize = true;
            this.lbl_cat.BackColor = System.Drawing.Color.Black;
            this.lbl_cat.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_cat.Location = new System.Drawing.Point(130, 17);
            this.lbl_cat.Name = "lbl_cat";
            this.lbl_cat.Size = new System.Drawing.Size(271, 35);
            this.lbl_cat.TabIndex = 157;
            this.lbl_cat.Text = "Categoria Del Artículo:";
            // 
            // txt_numero
            // 
            this.txt_numero.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_numero.Enabled = false;
            this.txt_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numero.Location = new System.Drawing.Point(710, 226);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.ReadOnly = true;
            this.txt_numero.Size = new System.Drawing.Size(319, 35);
            this.txt_numero.TabIndex = 169;
            this.txt_numero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_sector
            // 
            this.lbl_sector.AutoSize = true;
            this.lbl_sector.BackColor = System.Drawing.Color.Black;
            this.lbl_sector.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sector.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_sector.Location = new System.Drawing.Point(818, 22);
            this.lbl_sector.Name = "lbl_sector";
            this.lbl_sector.Size = new System.Drawing.Size(103, 35);
            this.lbl_sector.TabIndex = 154;
            this.lbl_sector.Text = "Cliente:";
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.CalendarFont = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecha.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecha.Location = new System.Drawing.Point(1252, 86);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(446, 37);
            this.dtp_fecha.TabIndex = 166;
            // 
            // lbl_iva
            // 
            this.lbl_iva.AutoSize = true;
            this.lbl_iva.BackColor = System.Drawing.Color.Black;
            this.lbl_iva.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_iva.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_iva.Location = new System.Drawing.Point(1544, 225);
            this.lbl_iva.Name = "lbl_iva";
            this.lbl_iva.Size = new System.Drawing.Size(56, 35);
            this.lbl_iva.TabIndex = 163;
            this.lbl_iva.Text = "Iva:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(583, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 35);
            this.label5.TabIndex = 168;
            this.label5.Text = "Número:";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.BackColor = System.Drawing.Color.Black;
            this.lbl_fecha.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_fecha.Location = new System.Drawing.Point(1363, 21);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(219, 35);
            this.lbl_fecha.TabIndex = 159;
            this.lbl_fecha.Text = "FechaDel Ingreso:";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.BackColor = System.Drawing.Color.Black;
            this.lbl_nombre.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_nombre.Location = new System.Drawing.Point(293, 22);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(102, 35);
            this.lbl_nombre.TabIndex = 158;
            this.lbl_nombre.Text = "Codigo:";
            // 
            // txt_serie
            // 
            this.txt_serie.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_serie.Enabled = false;
            this.txt_serie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_serie.Location = new System.Drawing.Point(1156, 228);
            this.txt_serie.Name = "txt_serie";
            this.txt_serie.ReadOnly = true;
            this.txt_serie.Size = new System.Drawing.Size(343, 35);
            this.txt_serie.TabIndex = 164;
            this.txt_serie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(1057, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 35);
            this.label4.TabIndex = 162;
            this.label4.Text = "Serie:";
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // FrmAgregarEditarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1852, 944);
            this.Controls.Add(this.dgv_detalle_ingreso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAgregarEditarVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Venta:";
            this.Load += new System.EventHandler(this.FrmAgregarEditarVenta_Load);
            this.dgv_detalle_ingreso.ResumeLayout(false);
            this.dgv_detalle_ingreso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalles_ventas)).EndInit();
            this.pl_art.ResumeLayout(false);
            this.pl_art.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox dgv_detalle_ingreso;
        private System.Windows.Forms.TextBox txt_codigo;
        public System.Windows.Forms.DataGridView dgv_detalles_ventas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_iva;
        private System.Windows.Forms.ComboBox cbo_cliente;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.ComboBox cbo_comprobante;
        private System.Windows.Forms.Label lbl_comprobante;
        private System.Windows.Forms.Panel pl_art;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.ComboBox cbo_cat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_articulo;
        private System.Windows.Forms.Button btn_quitar;
        private System.Windows.Forms.DateTimePicker dtp_fecha_vencimiento;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_img;
        private System.Windows.Forms.TextBox txt_precio_compra;
        private System.Windows.Forms.Label lbl_precio;
        private System.Windows.Forms.TextBox txt_precio_venta;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_stock;
        private System.Windows.Forms.Label lbl_cat;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Label lbl_sector;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.Label lbl_iva;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_serie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ErrorProvider errorIcono;
    }
}