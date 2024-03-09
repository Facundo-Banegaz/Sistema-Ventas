﻿namespace SistemaVentas
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
            this.menu_principal = new System.Windows.Forms.MenuStrip();
            this.menu_articulos = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_item_articulos = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_item_categorias = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_item_presentacion = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_item_proveedor = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_item_cliente = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_inventario = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_item_inventario = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_configuracion = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_persona = new System.Windows.Forms.ToolStripMenuItem();
            this.tn_tiempo = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.lbl_titulo_hora = new System.Windows.Forms.Label();
            this.lbl_titulo_fecha = new System.Windows.Forms.Label();
            this.menu_principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menu_principal
            // 
            this.menu_principal.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menu_principal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_principal.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menu_principal.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menu_principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_articulos,
            this.proveedoresToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.comprasToolStripMenuItem,
            this.menu_inventario,
            this.ventasToolStripMenuItem,
            this.menu_configuracion});
            this.menu_principal.Location = new System.Drawing.Point(0, 0);
            this.menu_principal.Name = "menu_principal";
            this.menu_principal.Padding = new System.Windows.Forms.Padding(9, 10, 0, 10);
            this.menu_principal.Size = new System.Drawing.Size(1924, 56);
            this.menu_principal.TabIndex = 9;
            this.menu_principal.Text = "Menu";
            // 
            // menu_articulos
            // 
            this.menu_articulos.BackColor = System.Drawing.Color.Black;
            this.menu_articulos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_item_articulos,
            this.menu_item_categorias,
            this.menu_item_presentacion});
            this.menu_articulos.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.menu_articulos.ForeColor = System.Drawing.Color.Orange;
            this.menu_articulos.Image = ((System.Drawing.Image)(resources.GetObject("menu_articulos.Image")));
            this.menu_articulos.Name = "menu_articulos";
            this.menu_articulos.Size = new System.Drawing.Size(262, 36);
            this.menu_articulos.Text = "Gestión de Articulos";
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
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.proveedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_item_proveedor});
            this.proveedoresToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.proveedoresToolStripMenuItem.ForeColor = System.Drawing.Color.Orange;
            this.proveedoresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("proveedoresToolStripMenuItem.Image")));
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(297, 36);
            this.proveedoresToolStripMenuItem.Text = "Gestión de Proveedores";
            // 
            // menu_item_proveedor
            // 
            this.menu_item_proveedor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menu_item_proveedor.ForeColor = System.Drawing.Color.Orange;
            this.menu_item_proveedor.Image = ((System.Drawing.Image)(resources.GetObject("menu_item_proveedor.Image")));
            this.menu_item_proveedor.Name = "menu_item_proveedor";
            this.menu_item_proveedor.Size = new System.Drawing.Size(239, 36);
            this.menu_item_proveedor.Text = "Proveedores";
            this.menu_item_proveedor.Click += new System.EventHandler(this.menu_item_proveedor_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_item_cliente});
            this.clientesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.clientesToolStripMenuItem.ForeColor = System.Drawing.Color.Orange;
            this.clientesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clientesToolStripMenuItem.Image")));
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(250, 36);
            this.clientesToolStripMenuItem.Text = "Gestión de Clientes";
            // 
            // menu_item_cliente
            // 
            this.menu_item_cliente.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menu_item_cliente.ForeColor = System.Drawing.Color.Orange;
            this.menu_item_cliente.Image = global::SistemaVentas.Properties.Resources.clasificacion;
            this.menu_item_cliente.Name = "menu_item_cliente";
            this.menu_item_cliente.Size = new System.Drawing.Size(192, 36);
            this.menu_item_cliente.Text = "Clientes";
            this.menu_item_cliente.Click += new System.EventHandler(this.menu_item_cliente_Click);
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.comprasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.comprasToolStripMenuItem.ForeColor = System.Drawing.Color.Orange;
            this.comprasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("comprasToolStripMenuItem.Image")));
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(260, 36);
            this.comprasToolStripMenuItem.Text = "Gestión de Compras";
            // 
            // menu_inventario
            // 
            this.menu_inventario.BackColor = System.Drawing.Color.Black;
            this.menu_inventario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_item_inventario});
            this.menu_inventario.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.menu_inventario.ForeColor = System.Drawing.Color.Orange;
            this.menu_inventario.Image = ((System.Drawing.Image)(resources.GetObject("menu_inventario.Image")));
            this.menu_inventario.Name = "menu_inventario";
            this.menu_inventario.Size = new System.Drawing.Size(163, 36);
            this.menu_inventario.Text = "Inventario";
            // 
            // menu_item_inventario
            // 
            this.menu_item_inventario.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menu_item_inventario.ForeColor = System.Drawing.Color.Orange;
            this.menu_item_inventario.Image = ((System.Drawing.Image)(resources.GetObject("menu_item_inventario.Image")));
            this.menu_item_inventario.Name = "menu_item_inventario";
            this.menu_item_inventario.Size = new System.Drawing.Size(357, 36);
            this.menu_item_inventario.Text = "Inventario De Productos";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.ventasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.ventasToolStripMenuItem.ForeColor = System.Drawing.Color.Orange;
            this.ventasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ventasToolStripMenuItem.Image")));
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(245, 36);
            this.ventasToolStripMenuItem.Text = "Gestión de  Ventas";
            // 
            // menu_configuracion
            // 
            this.menu_configuracion.BackColor = System.Drawing.Color.Black;
            this.menu_configuracion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_persona});
            this.menu_configuracion.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.menu_configuracion.ForeColor = System.Drawing.Color.Orange;
            this.menu_configuracion.Image = ((System.Drawing.Image)(resources.GetObject("menu_configuracion.Image")));
            this.menu_configuracion.Name = "menu_configuracion";
            this.menu_configuracion.Size = new System.Drawing.Size(202, 36);
            this.menu_configuracion.Text = "Configuración";
            // 
            // menu_persona
            // 
            this.menu_persona.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menu_persona.ForeColor = System.Drawing.Color.Orange;
            this.menu_persona.Image = ((System.Drawing.Image)(resources.GetObject("menu_persona.Image")));
            this.menu_persona.Name = "menu_persona";
            this.menu_persona.Size = new System.Drawing.Size(204, 36);
            this.menu_persona.Text = "Personas";
            this.menu_persona.Click += new System.EventHandler(this.menu_persona_Click);
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
            this.pictureBox1.Location = new System.Drawing.Point(0, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1924, 596);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.lbl_fecha.Click += new System.EventHandler(this.lbl_fecha_Click);
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
            this.lbl_hora.Click += new System.EventHandler(this.lbl_hora_Click);
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
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 652);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.lbl_hora);
            this.Controls.Add(this.lbl_titulo_hora);
            this.Controls.Add(this.lbl_titulo_fecha);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menu_principal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Ventas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menu_principal.ResumeLayout(false);
            this.menu_principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menu_principal;
        private System.Windows.Forms.ToolStripMenuItem menu_articulos;
        private System.Windows.Forms.ToolStripMenuItem menu_item_articulos;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_inventario;
        private System.Windows.Forms.ToolStripMenuItem menu_item_inventario;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_configuracion;
        private System.Windows.Forms.Timer tn_tiempo;
        private System.Windows.Forms.ToolStripMenuItem menu_item_categorias;
        private System.Windows.Forms.ToolStripMenuItem menu_item_presentacion;
        private System.Windows.Forms.ToolStripMenuItem menu_persona;
        private System.Windows.Forms.ToolStripMenuItem menu_item_proveedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.Label lbl_titulo_hora;
        private System.Windows.Forms.Label lbl_titulo_fecha;
        private System.Windows.Forms.ToolStripMenuItem menu_item_cliente;
    }
}