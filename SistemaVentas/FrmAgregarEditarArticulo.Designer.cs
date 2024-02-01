namespace SistemaVentas
{
    partial class FrmAgregarEditarArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarEditarArticulo));
            this.btn_subir_imagen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pbx_img = new System.Windows.Forms.PictureBox();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.cbo_presentacion_producto = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_descripcion_producto = new System.Windows.Forms.TextBox();
            this.txt_url_imagen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_tipo_categoria = new System.Windows.Forms.ComboBox();
            this.txt_id_articulo = new System.Windows.Forms.TextBox();
            this.txt_nombre_producto = new System.Windows.Forms.TextBox();
            this.lbl_cargo = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_presentacion = new System.Windows.Forms.Label();
            this.lbl_costo = new System.Windows.Forms.Label();
            this.txt_codigo_producto = new System.Windows.Forms.TextBox();
            this.lbl_codigo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_img)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_subir_imagen
            // 
            this.btn_subir_imagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_subir_imagen.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_subir_imagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_subir_imagen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_subir_imagen.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_subir_imagen.ForeColor = System.Drawing.Color.Ivory;
            this.btn_subir_imagen.Image = ((System.Drawing.Image)(resources.GetObject("btn_subir_imagen.Image")));
            this.btn_subir_imagen.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_subir_imagen.Location = new System.Drawing.Point(1271, 668);
            this.btn_subir_imagen.Name = "btn_subir_imagen";
            this.btn_subir_imagen.Size = new System.Drawing.Size(512, 60);
            this.btn_subir_imagen.TabIndex = 54;
            this.btn_subir_imagen.Text = "Subir Una Imagen Local";
            this.btn_subir_imagen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_subir_imagen.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(1414, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 35);
            this.label2.TabIndex = 53;
            this.label2.Text = "Imagen Del Producto:";
            // 
            // pbx_img
            // 
            this.pbx_img.Location = new System.Drawing.Point(1271, 82);
            this.pbx_img.Name = "pbx_img";
            this.pbx_img.Size = new System.Drawing.Size(512, 560);
            this.pbx_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_img.TabIndex = 52;
            this.pbx_img.TabStop = false;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Agregar.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_Agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Agregar.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_Agregar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Agregar.Image")));
            this.btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Agregar.Location = new System.Drawing.Point(1271, 768);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(180, 66);
            this.btn_Agregar.TabIndex = 49;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Agregar.UseVisualStyleBackColor = false;
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
            this.btn_cancelar.Location = new System.Drawing.Point(1586, 768);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(197, 66);
            this.btn_cancelar.TabIndex = 55;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            // 
            // cbo_presentacion_producto
            // 
            this.cbo_presentacion_producto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_presentacion_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_presentacion_producto.FormattingEnabled = true;
            this.cbo_presentacion_producto.Location = new System.Drawing.Point(22, 394);
            this.cbo_presentacion_producto.Name = "cbo_presentacion_producto";
            this.cbo_presentacion_producto.Size = new System.Drawing.Size(555, 37);
            this.cbo_presentacion_producto.TabIndex = 80;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.txt_descripcion_producto);
            this.groupBox1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 490);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1196, 344);
            this.groupBox1.TabIndex = 79;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Desccripcion del Producto:";
            // 
            // txt_descripcion_producto
            // 
            this.txt_descripcion_producto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_descripcion_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion_producto.Location = new System.Drawing.Point(38, 47);
            this.txt_descripcion_producto.Multiline = true;
            this.txt_descripcion_producto.Name = "txt_descripcion_producto";
            this.txt_descripcion_producto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_descripcion_producto.Size = new System.Drawing.Size(1122, 270);
            this.txt_descripcion_producto.TabIndex = 23;
            // 
            // txt_url_imagen
            // 
            this.txt_url_imagen.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_url_imagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_url_imagen.Location = new System.Drawing.Point(663, 230);
            this.txt_url_imagen.Name = "txt_url_imagen";
            this.txt_url_imagen.Size = new System.Drawing.Size(555, 35);
            this.txt_url_imagen.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(811, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 35);
            this.label1.TabIndex = 77;
            this.label1.Text = "Url De La Imagen :";
            // 
            // cbo_tipo_categoria
            // 
            this.cbo_tipo_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_tipo_categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_tipo_categoria.FormattingEnabled = true;
            this.cbo_tipo_categoria.Location = new System.Drawing.Point(663, 394);
            this.cbo_tipo_categoria.Name = "cbo_tipo_categoria";
            this.cbo_tipo_categoria.Size = new System.Drawing.Size(555, 37);
            this.cbo_tipo_categoria.TabIndex = 76;
            // 
            // txt_id_articulo
            // 
            this.txt_id_articulo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_id_articulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_articulo.Location = new System.Drawing.Point(22, 82);
            this.txt_id_articulo.Name = "txt_id_articulo";
            this.txt_id_articulo.Size = new System.Drawing.Size(555, 35);
            this.txt_id_articulo.TabIndex = 75;
            // 
            // txt_nombre_producto
            // 
            this.txt_nombre_producto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_nombre_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_producto.Location = new System.Drawing.Point(663, 82);
            this.txt_nombre_producto.Name = "txt_nombre_producto";
            this.txt_nombre_producto.Size = new System.Drawing.Size(555, 35);
            this.txt_nombre_producto.TabIndex = 74;
            // 
            // lbl_cargo
            // 
            this.lbl_cargo.AutoSize = true;
            this.lbl_cargo.BackColor = System.Drawing.Color.Black;
            this.lbl_cargo.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cargo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_cargo.Location = new System.Drawing.Point(811, 313);
            this.lbl_cargo.Name = "lbl_cargo";
            this.lbl_cargo.Size = new System.Drawing.Size(222, 35);
            this.lbl_cargo.TabIndex = 73;
            this.lbl_cargo.Text = "Tipo De Categoria:";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.BackColor = System.Drawing.Color.Black;
            this.lbl_nombre.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_nombre.Location = new System.Drawing.Point(811, 9);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(221, 35);
            this.lbl_nombre.TabIndex = 72;
            this.lbl_nombre.Text = "Nombre Producto:";
            // 
            // lbl_presentacion
            // 
            this.lbl_presentacion.AutoSize = true;
            this.lbl_presentacion.BackColor = System.Drawing.Color.Black;
            this.lbl_presentacion.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_presentacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_presentacion.Location = new System.Drawing.Point(128, 313);
            this.lbl_presentacion.Name = "lbl_presentacion";
            this.lbl_presentacion.Size = new System.Drawing.Size(284, 35);
            this.lbl_presentacion.TabIndex = 71;
            this.lbl_presentacion.Text = "Presentación Producto:";
            // 
            // lbl_costo
            // 
            this.lbl_costo.AutoSize = true;
            this.lbl_costo.BackColor = System.Drawing.Color.Black;
            this.lbl_costo.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_costo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_costo.Location = new System.Drawing.Point(184, 9);
            this.lbl_costo.Name = "lbl_costo";
            this.lbl_costo.Size = new System.Drawing.Size(181, 35);
            this.lbl_costo.TabIndex = 70;
            this.lbl_costo.Text = "Id Del Articulo:";
            // 
            // txt_codigo_producto
            // 
            this.txt_codigo_producto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_codigo_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo_producto.Location = new System.Drawing.Point(22, 230);
            this.txt_codigo_producto.Name = "txt_codigo_producto";
            this.txt_codigo_producto.Size = new System.Drawing.Size(555, 35);
            this.txt_codigo_producto.TabIndex = 69;
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.BackColor = System.Drawing.Color.Black;
            this.lbl_codigo.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_codigo.Location = new System.Drawing.Point(166, 155);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(212, 35);
            this.lbl_codigo.TabIndex = 68;
            this.lbl_codigo.Text = "Código Producto:";
            // 
            // FrmAgregarEditarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1817, 855);
            this.Controls.Add(this.cbo_presentacion_producto);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_url_imagen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_tipo_categoria);
            this.Controls.Add(this.txt_id_articulo);
            this.Controls.Add(this.txt_nombre_producto);
            this.Controls.Add(this.lbl_cargo);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.lbl_presentacion);
            this.Controls.Add(this.lbl_costo);
            this.Controls.Add(this.txt_codigo_producto);
            this.Controls.Add(this.lbl_codigo);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_subir_imagen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbx_img);
            this.Controls.Add(this.btn_Agregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAgregarEditarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulo";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_img)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_subir_imagen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbx_img;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.ComboBox cbo_presentacion_producto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_descripcion_producto;
        private System.Windows.Forms.TextBox txt_url_imagen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_tipo_categoria;
        private System.Windows.Forms.TextBox txt_id_articulo;
        private System.Windows.Forms.TextBox txt_nombre_producto;
        private System.Windows.Forms.Label lbl_cargo;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_presentacion;
        private System.Windows.Forms.Label lbl_costo;
        private System.Windows.Forms.TextBox txt_codigo_producto;
        private System.Windows.Forms.Label lbl_codigo;
    }
}