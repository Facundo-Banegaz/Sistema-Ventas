namespace SistemaVentas
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.Menu_principal = new System.Windows.Forms.MenuStrip();
            this.Menu_almacen = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_item_articulos = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_item_categorias = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_item_presentacion = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_gestion_compras = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_item_ingresos = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_item_proveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_gestion_ventas = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_item_ventas = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_item_clientes = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_consultas = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_item_stock = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_item_informe_ventas = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_item_informe_compras = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_mantenimiento = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_item_trabajador = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_herramientas = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_item_db = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_item_salir = new System.Windows.Forms.ToolStripMenuItem();
            this.tn_tiempo = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.lbl_titulo_hora = new System.Windows.Forms.Label();
            this.lbl_titulo_fecha = new System.Windows.Forms.Label();
            this.Menu_secundario = new System.Windows.Forms.MenuStrip();
            this.Menu_secundario_compras = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_secundario_ventas = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_trabajador = new System.Windows.Forms.Label();
            this.pbx_img = new System.Windows.Forms.PictureBox();
            this.Menu_principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Menu_secundario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_img)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu_principal
            // 
            this.Menu_principal.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Menu_principal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_principal.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.Menu_principal.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.Menu_principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_almacen,
            this.Menu_gestion_compras,
            this.Menu_gestion_ventas,
            this.Menu_consultas,
            this.Menu_mantenimiento,
            this.Menu_herramientas,
            this.Menu_item_salir});
            this.Menu_principal.Location = new System.Drawing.Point(0, 0);
            this.Menu_principal.Name = "Menu_principal";
            this.Menu_principal.Padding = new System.Windows.Forms.Padding(9, 10, 0, 10);
            this.Menu_principal.Size = new System.Drawing.Size(1924, 66);
            this.Menu_principal.TabIndex = 9;
            this.Menu_principal.Text = "Menu";
            // 
            // Menu_almacen
            // 
            this.Menu_almacen.BackColor = System.Drawing.Color.Black;
            this.Menu_almacen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_item_articulos,
            this.menu_item_categorias,
            this.menu_item_presentacion});
            this.Menu_almacen.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.Menu_almacen.ForeColor = System.Drawing.Color.Orange;
            this.Menu_almacen.Image = ((System.Drawing.Image)(resources.GetObject("Menu_almacen.Image")));
            this.Menu_almacen.Name = "Menu_almacen";
            this.Menu_almacen.Size = new System.Drawing.Size(145, 46);
            this.Menu_almacen.Text = "Almacén";
            // 
            // menu_item_articulos
            // 
            this.menu_item_articulos.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menu_item_articulos.ForeColor = System.Drawing.Color.Orange;
            this.menu_item_articulos.Image = ((System.Drawing.Image)(resources.GetObject("menu_item_articulos.Image")));
            this.menu_item_articulos.Name = "menu_item_articulos";
            this.menu_item_articulos.Size = new System.Drawing.Size(242, 36);
            this.menu_item_articulos.Text = "Articulos";
            this.menu_item_articulos.Click += new System.EventHandler(this.menu_item_articulos_Click);
            // 
            // menu_item_categorias
            // 
            this.menu_item_categorias.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menu_item_categorias.ForeColor = System.Drawing.Color.Orange;
            this.menu_item_categorias.Image = ((System.Drawing.Image)(resources.GetObject("menu_item_categorias.Image")));
            this.menu_item_categorias.Name = "menu_item_categorias";
            this.menu_item_categorias.Size = new System.Drawing.Size(242, 36);
            this.menu_item_categorias.Text = "Categorias";
            this.menu_item_categorias.Click += new System.EventHandler(this.menu_item_categorias_Click);
            // 
            // menu_item_presentacion
            // 
            this.menu_item_presentacion.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menu_item_presentacion.ForeColor = System.Drawing.Color.Orange;
            this.menu_item_presentacion.Image = ((System.Drawing.Image)(resources.GetObject("menu_item_presentacion.Image")));
            this.menu_item_presentacion.Name = "menu_item_presentacion";
            this.menu_item_presentacion.Size = new System.Drawing.Size(242, 36);
            this.menu_item_presentacion.Text = "Presentación";
            this.menu_item_presentacion.Click += new System.EventHandler(this.menu_item_presentacion_Click);
            // 
            // Menu_gestion_compras
            // 
            this.Menu_gestion_compras.BackColor = System.Drawing.Color.Black;
            this.Menu_gestion_compras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_item_ingresos,
            this.Menu_item_proveedores});
            this.Menu_gestion_compras.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.Menu_gestion_compras.ForeColor = System.Drawing.Color.Orange;
            this.Menu_gestion_compras.Image = ((System.Drawing.Image)(resources.GetObject("Menu_gestion_compras.Image")));
            this.Menu_gestion_compras.Name = "Menu_gestion_compras";
            this.Menu_gestion_compras.Size = new System.Drawing.Size(262, 46);
            this.Menu_gestion_compras.Text = "Gestion De Compras";
            // 
            // Menu_item_ingresos
            // 
            this.Menu_item_ingresos.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Menu_item_ingresos.ForeColor = System.Drawing.Color.Orange;
            this.Menu_item_ingresos.Image = ((System.Drawing.Image)(resources.GetObject("Menu_item_ingresos.Image")));
            this.Menu_item_ingresos.Name = "Menu_item_ingresos";
            this.Menu_item_ingresos.Size = new System.Drawing.Size(239, 36);
            this.Menu_item_ingresos.Text = "Ingresos";
            this.Menu_item_ingresos.Click += new System.EventHandler(this.Menu_item_ingresos_Click);
            // 
            // Menu_item_proveedores
            // 
            this.Menu_item_proveedores.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Menu_item_proveedores.Checked = true;
            this.Menu_item_proveedores.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Menu_item_proveedores.ForeColor = System.Drawing.Color.Orange;
            this.Menu_item_proveedores.Image = ((System.Drawing.Image)(resources.GetObject("Menu_item_proveedores.Image")));
            this.Menu_item_proveedores.Name = "Menu_item_proveedores";
            this.Menu_item_proveedores.Size = new System.Drawing.Size(239, 36);
            this.Menu_item_proveedores.Text = "Proveedores";
            this.Menu_item_proveedores.Click += new System.EventHandler(this.Menu_item_proveedores_Click);
            // 
            // Menu_gestion_ventas
            // 
            this.Menu_gestion_ventas.BackColor = System.Drawing.Color.Black;
            this.Menu_gestion_ventas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_item_ventas,
            this.Menu_item_clientes});
            this.Menu_gestion_ventas.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.Menu_gestion_ventas.ForeColor = System.Drawing.Color.Orange;
            this.Menu_gestion_ventas.Image = ((System.Drawing.Image)(resources.GetObject("Menu_gestion_ventas.Image")));
            this.Menu_gestion_ventas.Name = "Menu_gestion_ventas";
            this.Menu_gestion_ventas.Size = new System.Drawing.Size(253, 46);
            this.Menu_gestion_ventas.Text = "  Gestion De Ventas";
            // 
            // Menu_item_ventas
            // 
            this.Menu_item_ventas.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Menu_item_ventas.ForeColor = System.Drawing.Color.Orange;
            this.Menu_item_ventas.Image = ((System.Drawing.Image)(resources.GetObject("Menu_item_ventas.Image")));
            this.Menu_item_ventas.Name = "Menu_item_ventas";
            this.Menu_item_ventas.Size = new System.Drawing.Size(192, 36);
            this.Menu_item_ventas.Text = "Ventas";
            // 
            // Menu_item_clientes
            // 
            this.Menu_item_clientes.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Menu_item_clientes.ForeColor = System.Drawing.Color.Orange;
            this.Menu_item_clientes.Image = ((System.Drawing.Image)(resources.GetObject("Menu_item_clientes.Image")));
            this.Menu_item_clientes.Name = "Menu_item_clientes";
            this.Menu_item_clientes.Size = new System.Drawing.Size(192, 36);
            this.Menu_item_clientes.Text = "Clientes";
            this.Menu_item_clientes.Click += new System.EventHandler(this.Menu_item_clientes_Click);
            // 
            // Menu_consultas
            // 
            this.Menu_consultas.BackColor = System.Drawing.Color.Black;
            this.Menu_consultas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_item_stock,
            this.Menu_item_informe_ventas,
            this.Menu_item_informe_compras});
            this.Menu_consultas.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.Menu_consultas.ForeColor = System.Drawing.Color.Orange;
            this.Menu_consultas.Image = ((System.Drawing.Image)(resources.GetObject("Menu_consultas.Image")));
            this.Menu_consultas.Name = "Menu_consultas";
            this.Menu_consultas.Size = new System.Drawing.Size(157, 46);
            this.Menu_consultas.Text = "Consultas";
            // 
            // menu_item_stock
            // 
            this.menu_item_stock.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menu_item_stock.ForeColor = System.Drawing.Color.Orange;
            this.menu_item_stock.Image = ((System.Drawing.Image)(resources.GetObject("menu_item_stock.Image")));
            this.menu_item_stock.Name = "menu_item_stock";
            this.menu_item_stock.Size = new System.Drawing.Size(329, 36);
            this.menu_item_stock.Text = "Stock de Articulos";
            // 
            // Menu_item_informe_ventas
            // 
            this.Menu_item_informe_ventas.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Menu_item_informe_ventas.ForeColor = System.Drawing.Color.Orange;
            this.Menu_item_informe_ventas.Image = ((System.Drawing.Image)(resources.GetObject("Menu_item_informe_ventas.Image")));
            this.Menu_item_informe_ventas.Name = "Menu_item_informe_ventas";
            this.Menu_item_informe_ventas.Size = new System.Drawing.Size(329, 36);
            this.Menu_item_informe_ventas.Text = "Informes de Ventas";
            // 
            // Menu_item_informe_compras
            // 
            this.Menu_item_informe_compras.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Menu_item_informe_compras.ForeColor = System.Drawing.Color.Orange;
            this.Menu_item_informe_compras.Image = ((System.Drawing.Image)(resources.GetObject("Menu_item_informe_compras.Image")));
            this.Menu_item_informe_compras.Name = "Menu_item_informe_compras";
            this.Menu_item_informe_compras.Size = new System.Drawing.Size(329, 36);
            this.Menu_item_informe_compras.Text = "Informes de Compras";
            // 
            // Menu_mantenimiento
            // 
            this.Menu_mantenimiento.BackColor = System.Drawing.Color.Black;
            this.Menu_mantenimiento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_item_trabajador});
            this.Menu_mantenimiento.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.Menu_mantenimiento.ForeColor = System.Drawing.Color.Orange;
            this.Menu_mantenimiento.Image = ((System.Drawing.Image)(resources.GetObject("Menu_mantenimiento.Image")));
            this.Menu_mantenimiento.Name = "Menu_mantenimiento";
            this.Menu_mantenimiento.Size = new System.Drawing.Size(212, 46);
            this.Menu_mantenimiento.Text = "Mantenimiento";
            // 
            // menu_item_trabajador
            // 
            this.menu_item_trabajador.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menu_item_trabajador.ForeColor = System.Drawing.Color.Orange;
            this.menu_item_trabajador.Image = ((System.Drawing.Image)(resources.GetObject("menu_item_trabajador.Image")));
            this.menu_item_trabajador.Name = "menu_item_trabajador";
            this.menu_item_trabajador.Size = new System.Drawing.Size(223, 36);
            this.menu_item_trabajador.Text = "Trabajador";
            this.menu_item_trabajador.Click += new System.EventHandler(this.menu_item_trabajador_Click);
            // 
            // Menu_herramientas
            // 
            this.Menu_herramientas.BackColor = System.Drawing.Color.Black;
            this.Menu_herramientas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_item_db});
            this.Menu_herramientas.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.Menu_herramientas.ForeColor = System.Drawing.Color.Orange;
            this.Menu_herramientas.Image = ((System.Drawing.Image)(resources.GetObject("Menu_herramientas.Image")));
            this.Menu_herramientas.Name = "Menu_herramientas";
            this.Menu_herramientas.Size = new System.Drawing.Size(194, 46);
            this.Menu_herramientas.Text = "Herramientas";
            // 
            // Menu_item_db
            // 
            this.Menu_item_db.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Menu_item_db.ForeColor = System.Drawing.Color.Orange;
            this.Menu_item_db.Image = ((System.Drawing.Image)(resources.GetObject("Menu_item_db.Image")));
            this.Menu_item_db.Name = "Menu_item_db";
            this.Menu_item_db.Size = new System.Drawing.Size(230, 36);
            this.Menu_item_db.Text = "Back Up DB";
            // 
            // Menu_item_salir
            // 
            this.Menu_item_salir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Menu_item_salir.BackColor = System.Drawing.Color.Crimson;
            this.Menu_item_salir.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_item_salir.ForeColor = System.Drawing.Color.AliceBlue;
            this.Menu_item_salir.Image = ((System.Drawing.Image)(resources.GetObject("Menu_item_salir.Image")));
            this.Menu_item_salir.Name = "Menu_item_salir";
            this.Menu_item_salir.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.Menu_item_salir.Size = new System.Drawing.Size(330, 46);
            this.Menu_item_salir.Text = "Salir del Sistema de Ventas";
            this.Menu_item_salir.Click += new System.EventHandler(this.Menu_item_salir_Click);
            // 
            // tn_tiempo
            // 
            this.tn_tiempo.Enabled = true;
            this.tn_tiempo.Tick += new System.EventHandler(this.tn_tiempo_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::SistemaVentas.Properties.Resources.foto_portada_tienda;
            this.pictureBox1.Location = new System.Drawing.Point(0, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1924, 586);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.BackColor = System.Drawing.Color.White;
            this.lbl_fecha.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_fecha.Location = new System.Drawing.Point(489, 606);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(0, 44);
            this.lbl_fecha.TabIndex = 14;
            this.lbl_fecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_hora
            // 
            this.lbl_hora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_hora.AutoSize = true;
            this.lbl_hora.BackColor = System.Drawing.Color.White;
            this.lbl_hora.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora.ForeColor = System.Drawing.Color.Orange;
            this.lbl_hora.Location = new System.Drawing.Point(1168, 606);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(0, 44);
            this.lbl_hora.TabIndex = 13;
            this.lbl_hora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_titulo_hora
            // 
            this.lbl_titulo_hora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_titulo_hora.AutoSize = true;
            this.lbl_titulo_hora.BackColor = System.Drawing.Color.White;
            this.lbl_titulo_hora.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo_hora.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbl_titulo_hora.Location = new System.Drawing.Point(1036, 602);
            this.lbl_titulo_hora.Name = "lbl_titulo_hora";
            this.lbl_titulo_hora.Size = new System.Drawing.Size(109, 48);
            this.lbl_titulo_hora.TabIndex = 12;
            this.lbl_titulo_hora.Text = "Hora:";
            this.lbl_titulo_hora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_titulo_fecha
            // 
            this.lbl_titulo_fecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_titulo_fecha.AutoSize = true;
            this.lbl_titulo_fecha.BackColor = System.Drawing.Color.White;
            this.lbl_titulo_fecha.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo_fecha.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_titulo_fecha.Location = new System.Drawing.Point(343, 602);
            this.lbl_titulo_fecha.Name = "lbl_titulo_fecha";
            this.lbl_titulo_fecha.Size = new System.Drawing.Size(131, 48);
            this.lbl_titulo_fecha.TabIndex = 11;
            this.lbl_titulo_fecha.Text = "Fecha:";
            this.lbl_titulo_fecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_titulo_fecha.Click += new System.EventHandler(this.tn_tiempo_Tick);
            // 
            // Menu_secundario
            // 
            this.Menu_secundario.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Menu_secundario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_secundario.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.Menu_secundario.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.Menu_secundario.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_secundario_compras,
            this.Menu_secundario_ventas});
            this.Menu_secundario.Location = new System.Drawing.Point(0, 66);
            this.Menu_secundario.Name = "Menu_secundario";
            this.Menu_secundario.Padding = new System.Windows.Forms.Padding(9, 10, 0, 10);
            this.Menu_secundario.Size = new System.Drawing.Size(1924, 56);
            this.Menu_secundario.TabIndex = 15;
            this.Menu_secundario.Text = "Menu";
            // 
            // Menu_secundario_compras
            // 
            this.Menu_secundario_compras.BackColor = System.Drawing.Color.Black;
            this.Menu_secundario_compras.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.Menu_secundario_compras.ForeColor = System.Drawing.Color.Orange;
            this.Menu_secundario_compras.Image = ((System.Drawing.Image)(resources.GetObject("Menu_secundario_compras.Image")));
            this.Menu_secundario_compras.Name = "Menu_secundario_compras";
            this.Menu_secundario_compras.Size = new System.Drawing.Size(211, 36);
            this.Menu_secundario_compras.Text = "Hacer Compras";
            // 
            // Menu_secundario_ventas
            // 
            this.Menu_secundario_ventas.BackColor = System.Drawing.Color.Black;
            this.Menu_secundario_ventas.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.Menu_secundario_ventas.ForeColor = System.Drawing.Color.Orange;
            this.Menu_secundario_ventas.Image = ((System.Drawing.Image)(resources.GetObject("Menu_secundario_ventas.Image")));
            this.Menu_secundario_ventas.Name = "Menu_secundario_ventas";
            this.Menu_secundario_ventas.Size = new System.Drawing.Size(196, 36);
            this.Menu_secundario_ventas.Text = "Hacer  Ventas";
            // 
            // lbl_trabajador
            // 
            this.lbl_trabajador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_trabajador.AutoSize = true;
            this.lbl_trabajador.BackColor = System.Drawing.Color.White;
            this.lbl_trabajador.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_trabajador.ForeColor = System.Drawing.Color.Orange;
            this.lbl_trabajador.Location = new System.Drawing.Point(99, 526);
            this.lbl_trabajador.Name = "lbl_trabajador";
            this.lbl_trabajador.Size = new System.Drawing.Size(234, 48);
            this.lbl_trabajador.TabIndex = 16;
            this.lbl_trabajador.Text = "Trabajador:  ";
            this.lbl_trabajador.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbx_img
            // 
            this.pbx_img.Location = new System.Drawing.Point(190, 139);
            this.pbx_img.Name = "pbx_img";
            this.pbx_img.Size = new System.Drawing.Size(309, 335);
            this.pbx_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_img.TabIndex = 17;
            this.pbx_img.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 652);
            this.Controls.Add(this.pbx_img);
            this.Controls.Add(this.lbl_trabajador);
            this.Controls.Add(this.Menu_secundario);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.lbl_hora);
            this.Controls.Add(this.lbl_titulo_hora);
            this.Controls.Add(this.lbl_titulo_fecha);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Menu_principal);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Ventas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.Menu_principal.ResumeLayout(false);
            this.Menu_principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Menu_secundario.ResumeLayout(false);
            this.Menu_secundario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip Menu_principal;
        private System.Windows.Forms.ToolStripMenuItem Menu_almacen;
        private System.Windows.Forms.ToolStripMenuItem menu_item_articulos;
        private System.Windows.Forms.ToolStripMenuItem Menu_gestion_compras;
        private System.Windows.Forms.ToolStripMenuItem Menu_consultas;
        private System.Windows.Forms.ToolStripMenuItem menu_item_stock;
        private System.Windows.Forms.ToolStripMenuItem Menu_gestion_ventas;
        private System.Windows.Forms.ToolStripMenuItem Menu_mantenimiento;
        private System.Windows.Forms.Timer tn_tiempo;
        private System.Windows.Forms.ToolStripMenuItem menu_item_categorias;
        private System.Windows.Forms.ToolStripMenuItem menu_item_presentacion;
        private System.Windows.Forms.ToolStripMenuItem menu_item_trabajador;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.Label lbl_titulo_hora;
        private System.Windows.Forms.Label lbl_titulo_fecha;
        private System.Windows.Forms.ToolStripMenuItem Menu_item_ingresos;
        private System.Windows.Forms.ToolStripMenuItem Menu_item_proveedores;
        private System.Windows.Forms.ToolStripMenuItem Menu_item_ventas;
        private System.Windows.Forms.ToolStripMenuItem Menu_item_clientes;
        private System.Windows.Forms.ToolStripMenuItem Menu_herramientas;
        private System.Windows.Forms.ToolStripMenuItem Menu_item_db;
        private System.Windows.Forms.ToolStripMenuItem Menu_item_informe_ventas;
        private System.Windows.Forms.ToolStripMenuItem Menu_item_informe_compras;
        private System.Windows.Forms.ToolStripMenuItem Menu_item_salir;
        private System.Windows.Forms.MenuStrip Menu_secundario;
        private System.Windows.Forms.ToolStripMenuItem Menu_secundario_compras;
        private System.Windows.Forms.ToolStripMenuItem Menu_secundario_ventas;
        private System.Windows.Forms.Label lbl_trabajador;
        private System.Windows.Forms.PictureBox pbx_img;
    }
}