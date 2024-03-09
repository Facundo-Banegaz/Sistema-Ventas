namespace SistemaVentas
{
    partial class FrmArgregarEditarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArgregarEditarCliente));
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txt_url_imagen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id_cliente = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_cargo = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_presentacion = new System.Windows.Forms.Label();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.lbl_sector = new System.Windows.Forms.Label();
            this.btn_subir_imagen = new System.Windows.Forms.Button();
            this.pbx_img = new System.Windows.Forms.PictureBox();
            this.dtp_fecha_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.cbo_sexo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_numero_documento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.lb_img = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(670, 655);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(555, 35);
            this.txt_email.TabIndex = 122;
            this.txt_email.Validating += new System.ComponentModel.CancelEventHandler(this.txt_email_Validating);
            // 
            // txt_telefono
            // 
            this.txt_telefono.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono.Location = new System.Drawing.Point(29, 655);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(555, 35);
            this.txt_telefono.TabIndex = 121;
            this.txt_telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_telefono_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(905, 585);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 35);
            this.label3.TabIndex = 120;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(220, 585);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 35);
            this.label4.TabIndex = 119;
            this.label4.Text = "Telefono:";
            // 
            // txt_direccion
            // 
            this.txt_direccion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_direccion.Location = new System.Drawing.Point(21, 467);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(555, 35);
            this.txt_direccion.TabIndex = 118;
            // 
            // txt_url_imagen
            // 
            this.txt_url_imagen.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_url_imagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_url_imagen.Location = new System.Drawing.Point(326, 789);
            this.txt_url_imagen.Name = "txt_url_imagen";
            this.txt_url_imagen.Size = new System.Drawing.Size(555, 35);
            this.txt_url_imagen.TabIndex = 116;
            this.txt_url_imagen.TextChanged += new System.EventHandler(this.txt_url_imagen_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(207, 655);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 35);
            this.label1.TabIndex = 115;
            this.label1.Text = "Foto :";
            // 
            // txt_id_cliente
            // 
            this.txt_id_cliente.BackColor = System.Drawing.Color.GhostWhite;
            this.txt_id_cliente.Enabled = false;
            this.txt_id_cliente.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_cliente.ForeColor = System.Drawing.Color.DarkOrange;
            this.txt_id_cliente.Location = new System.Drawing.Point(21, 121);
            this.txt_id_cliente.Name = "txt_id_cliente";
            this.txt_id_cliente.ReadOnly = true;
            this.txt_id_cliente.Size = new System.Drawing.Size(192, 47);
            this.txt_id_cliente.TabIndex = 114;
            this.txt_id_cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(662, 133);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(555, 35);
            this.txt_nombre.TabIndex = 113;
            // 
            // lbl_cargo
            // 
            this.lbl_cargo.AutoSize = true;
            this.lbl_cargo.BackColor = System.Drawing.Color.Black;
            this.lbl_cargo.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cargo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_cargo.Location = new System.Drawing.Point(833, 405);
            this.lbl_cargo.Name = "lbl_cargo";
            this.lbl_cargo.Size = new System.Drawing.Size(225, 35);
            this.lbl_cargo.TabIndex = 112;
            this.lbl_cargo.Text = "Fecha Nacimiento:";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.BackColor = System.Drawing.Color.Black;
            this.lbl_nombre.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_nombre.Location = new System.Drawing.Point(877, 60);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(111, 35);
            this.lbl_nombre.TabIndex = 111;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // lbl_presentacion
            // 
            this.lbl_presentacion.AutoSize = true;
            this.lbl_presentacion.BackColor = System.Drawing.Color.Black;
            this.lbl_presentacion.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_presentacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_presentacion.Location = new System.Drawing.Point(379, 60);
            this.lbl_presentacion.Name = "lbl_presentacion";
            this.lbl_presentacion.Size = new System.Drawing.Size(74, 35);
            this.lbl_presentacion.TabIndex = 110;
            this.lbl_presentacion.Text = "Sexo:";
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.BackColor = System.Drawing.Color.Black;
            this.lbl_Id.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Id.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Id.Location = new System.Drawing.Point(32, 60);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(172, 35);
            this.lbl_Id.TabIndex = 109;
            this.lbl_Id.Text = "Id del Cliente:";
            // 
            // txt_apellido
            // 
            this.txt_apellido.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellido.Location = new System.Drawing.Point(21, 294);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(555, 35);
            this.txt_apellido.TabIndex = 108;
            // 
            // lbl_sector
            // 
            this.lbl_sector.AutoSize = true;
            this.lbl_sector.BackColor = System.Drawing.Color.Black;
            this.lbl_sector.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sector.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_sector.Location = new System.Drawing.Point(181, 219);
            this.lbl_sector.Name = "lbl_sector";
            this.lbl_sector.Size = new System.Drawing.Size(114, 35);
            this.lbl_sector.TabIndex = 107;
            this.lbl_sector.Text = "Apellido:";
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
            this.btn_subir_imagen.Location = new System.Drawing.Point(1266, 658);
            this.btn_subir_imagen.Name = "btn_subir_imagen";
            this.btn_subir_imagen.Size = new System.Drawing.Size(512, 60);
            this.btn_subir_imagen.TabIndex = 106;
            this.btn_subir_imagen.Text = "Subir Una Imagen Local";
            this.btn_subir_imagen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_subir_imagen.UseVisualStyleBackColor = false;
            this.btn_subir_imagen.Click += new System.EventHandler(this.btn_subir_imagen_Click_1);
            // 
            // pbx_img
            // 
            this.pbx_img.Location = new System.Drawing.Point(1266, 60);
            this.pbx_img.Name = "pbx_img";
            this.pbx_img.Size = new System.Drawing.Size(512, 560);
            this.pbx_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_img.TabIndex = 105;
            this.pbx_img.TabStop = false;
            // 
            // dtp_fecha_nacimiento
            // 
            this.dtp_fecha_nacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecha_nacimiento.Location = new System.Drawing.Point(678, 467);
            this.dtp_fecha_nacimiento.Name = "dtp_fecha_nacimiento";
            this.dtp_fecha_nacimiento.Size = new System.Drawing.Size(539, 35);
            this.dtp_fecha_nacimiento.TabIndex = 124;
            this.dtp_fecha_nacimiento.Validating += new System.ComponentModel.CancelEventHandler(this.dtp_fecha_nacimiento_Validating);
            // 
            // cbo_sexo
            // 
            this.cbo_sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_sexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_sexo.FormattingEnabled = true;
            this.cbo_sexo.Location = new System.Drawing.Point(238, 133);
            this.cbo_sexo.Name = "cbo_sexo";
            this.cbo_sexo.Size = new System.Drawing.Size(346, 34);
            this.cbo_sexo.TabIndex = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(181, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 35);
            this.label2.TabIndex = 126;
            this.label2.Text = "Direccion:";
            // 
            // txt_numero_documento
            // 
            this.txt_numero_documento.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_numero_documento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numero_documento.Location = new System.Drawing.Point(662, 294);
            this.txt_numero_documento.Name = "txt_numero_documento";
            this.txt_numero_documento.Size = new System.Drawing.Size(555, 35);
            this.txt_numero_documento.TabIndex = 128;
            this.txt_numero_documento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_numero_documento_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(812, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(248, 35);
            this.label5.TabIndex = 127;
            this.label5.Text = "Numero Documento:";
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
            this.btn_cancelar.Location = new System.Drawing.Point(1581, 770);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(197, 66);
            this.btn_cancelar.TabIndex = 130;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
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
            this.btn_Agregar.Location = new System.Drawing.Point(1266, 770);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(180, 66);
            this.btn_Agregar.TabIndex = 129;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // lb_img
            // 
            this.lb_img.AutoSize = true;
            this.lb_img.BackColor = System.Drawing.Color.Black;
            this.lb_img.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_img.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_img.Location = new System.Drawing.Point(583, 734);
            this.lb_img.Name = "lb_img";
            this.lb_img.Size = new System.Drawing.Size(69, 35);
            this.lb_img.TabIndex = 131;
            this.lb_img.Text = "Foto:";
            // 
            // FrmArgregarEditarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1798, 852);
            this.Controls.Add(this.lb_img);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.txt_numero_documento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbo_sexo);
            this.Controls.Add(this.dtp_fecha_nacimiento);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.txt_url_imagen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_id_cliente);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_cargo);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.lbl_presentacion);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.lbl_sector);
            this.Controls.Add(this.btn_subir_imagen);
            this.Controls.Add(this.pbx_img);
            this.Name = "FrmArgregarEditarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmArgregarEditarCliente";
            this.Load += new System.EventHandler(this.FrmArgregarEditarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.TextBox txt_url_imagen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id_cliente;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_cargo;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_presentacion;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.Label lbl_sector;
        private System.Windows.Forms.Button btn_subir_imagen;
        private System.Windows.Forms.PictureBox pbx_img;
        private System.Windows.Forms.DateTimePicker dtp_fecha_nacimiento;
        private System.Windows.Forms.ComboBox cbo_sexo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_numero_documento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.Label lb_img;
    }
}