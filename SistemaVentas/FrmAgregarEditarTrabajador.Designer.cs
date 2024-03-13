namespace SistemaVentas
{
    partial class FrmAgregarEditarTrabajador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarEditarTrabajador));
            this.txt_numero_documento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_sexo = new System.Windows.Forms.ComboBox();
            this.dtp_fecha_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_id_trabajador = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_cargo = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_presentacion = new System.Windows.Forms.Label();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.lbl_sector = new System.Windows.Forms.Label();
            this.btn_subir_imagen = new System.Windows.Forms.Button();
            this.pbx_img = new System.Windows.Forms.PictureBox();
            this.lb_img = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.txt_url_imagen = new System.Windows.Forms.TextBox();
            this.txt_direccion_trabajado = new System.Windows.Forms.TextBox();
            this.cbo_acceso = new System.Windows.Forms.ComboBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_clave = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_numero_documento
            // 
            this.txt_numero_documento.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_numero_documento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numero_documento.Location = new System.Drawing.Point(487, 208);
            this.txt_numero_documento.Name = "txt_numero_documento";
            this.txt_numero_documento.Size = new System.Drawing.Size(394, 35);
            this.txt_numero_documento.TabIndex = 149;
            this.txt_numero_documento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_numero_documento_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(573, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(248, 35);
            this.label5.TabIndex = 148;
            this.label5.Text = "Numero Documento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(74, 584);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 35);
            this.label2.TabIndex = 147;
            this.label2.Text = "Direccion:";
            // 
            // cbo_sexo
            // 
            this.cbo_sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_sexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_sexo.FormattingEnabled = true;
            this.cbo_sexo.Location = new System.Drawing.Point(189, 78);
            this.cbo_sexo.Name = "cbo_sexo";
            this.cbo_sexo.Size = new System.Drawing.Size(269, 34);
            this.cbo_sexo.TabIndex = 146;
            // 
            // dtp_fecha_nacimiento
            // 
            this.dtp_fecha_nacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecha_nacimiento.Location = new System.Drawing.Point(10, 208);
            this.dtp_fecha_nacimiento.Name = "dtp_fecha_nacimiento";
            this.dtp_fecha_nacimiento.Size = new System.Drawing.Size(446, 30);
            this.dtp_fecha_nacimiento.TabIndex = 145;
            this.dtp_fecha_nacimiento.ValueChanged += new System.EventHandler(this.dtp_fecha_nacimiento_ValueChanged);
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(616, 333);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(500, 35);
            this.txt_email.TabIndex = 144;
            this.txt_email.TextChanged += new System.EventHandler(this.txt_email_TextChanged);
            this.txt_email.Leave += new System.EventHandler(this.txt_email_Leave);
            // 
            // txt_telefono
            // 
            this.txt_telefono.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono.Location = new System.Drawing.Point(926, 207);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(375, 35);
            this.txt_telefono.TabIndex = 143;
            this.txt_telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_telefono_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(839, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 35);
            this.label3.TabIndex = 142;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(1042, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 35);
            this.label4.TabIndex = 141;
            this.label4.Text = "Telefono:";
            // 
            // txt_id_trabajador
            // 
            this.txt_id_trabajador.BackColor = System.Drawing.Color.GhostWhite;
            this.txt_id_trabajador.Enabled = false;
            this.txt_id_trabajador.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_trabajador.ForeColor = System.Drawing.Color.DarkOrange;
            this.txt_id_trabajador.Location = new System.Drawing.Point(16, 70);
            this.txt_id_trabajador.Name = "txt_id_trabajador";
            this.txt_id_trabajador.ReadOnly = true;
            this.txt_id_trabajador.Size = new System.Drawing.Size(146, 42);
            this.txt_id_trabajador.TabIndex = 138;
            this.txt_id_trabajador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(504, 76);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(379, 35);
            this.txt_nombre.TabIndex = 137;
            // 
            // lbl_cargo
            // 
            this.lbl_cargo.AutoSize = true;
            this.lbl_cargo.BackColor = System.Drawing.Color.Black;
            this.lbl_cargo.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cargo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_cargo.Location = new System.Drawing.Point(126, 155);
            this.lbl_cargo.Name = "lbl_cargo";
            this.lbl_cargo.Size = new System.Drawing.Size(225, 35);
            this.lbl_cargo.TabIndex = 136;
            this.lbl_cargo.Text = "Fecha Nacimiento:";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.BackColor = System.Drawing.Color.Black;
            this.lbl_nombre.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_nombre.Location = new System.Drawing.Point(648, 20);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(111, 35);
            this.lbl_nombre.TabIndex = 135;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // lbl_presentacion
            // 
            this.lbl_presentacion.AutoSize = true;
            this.lbl_presentacion.BackColor = System.Drawing.Color.Black;
            this.lbl_presentacion.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_presentacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_presentacion.Location = new System.Drawing.Point(292, 20);
            this.lbl_presentacion.Name = "lbl_presentacion";
            this.lbl_presentacion.Size = new System.Drawing.Size(74, 35);
            this.lbl_presentacion.TabIndex = 134;
            this.lbl_presentacion.Text = "Sexo:";
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.BackColor = System.Drawing.Color.Black;
            this.lbl_Id.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Id.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Id.Location = new System.Drawing.Point(18, 20);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(144, 29);
            this.lbl_Id.TabIndex = 133;
            this.lbl_Id.Text = "Id del Cliente:";
            // 
            // txt_apellido
            // 
            this.txt_apellido.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellido.Location = new System.Drawing.Point(928, 78);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(375, 35);
            this.txt_apellido.TabIndex = 132;
            // 
            // lbl_sector
            // 
            this.lbl_sector.AutoSize = true;
            this.lbl_sector.BackColor = System.Drawing.Color.Black;
            this.lbl_sector.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sector.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_sector.Location = new System.Drawing.Point(1044, 20);
            this.lbl_sector.Name = "lbl_sector";
            this.lbl_sector.Size = new System.Drawing.Size(114, 35);
            this.lbl_sector.TabIndex = 131;
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
            this.btn_subir_imagen.Location = new System.Drawing.Point(1335, 622);
            this.btn_subir_imagen.Name = "btn_subir_imagen";
            this.btn_subir_imagen.Size = new System.Drawing.Size(468, 60);
            this.btn_subir_imagen.TabIndex = 130;
            this.btn_subir_imagen.Text = "Subir Una Imagen Local";
            this.btn_subir_imagen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_subir_imagen.UseVisualStyleBackColor = false;
            this.btn_subir_imagen.Click += new System.EventHandler(this.btn_subir_imagen_Click);
            // 
            // pbx_img
            // 
            this.pbx_img.Location = new System.Drawing.Point(1335, 38);
            this.pbx_img.Name = "pbx_img";
            this.pbx_img.Size = new System.Drawing.Size(468, 560);
            this.pbx_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_img.TabIndex = 129;
            this.pbx_img.TabStop = false;
            // 
            // lb_img
            // 
            this.lb_img.AutoSize = true;
            this.lb_img.BackColor = System.Drawing.Color.Black;
            this.lb_img.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_img.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_img.Location = new System.Drawing.Point(315, 276);
            this.lb_img.Name = "lb_img";
            this.lb_img.Size = new System.Drawing.Size(69, 35);
            this.lb_img.TabIndex = 153;
            this.lb_img.Text = "Foto:";
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
            this.btn_cancelar.Location = new System.Drawing.Point(1606, 755);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(197, 66);
            this.btn_cancelar.TabIndex = 152;
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
            this.btn_Agregar.Location = new System.Drawing.Point(1268, 755);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(180, 66);
            this.btn_Agregar.TabIndex = 151;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // txt_url_imagen
            // 
            this.txt_url_imagen.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_url_imagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_url_imagen.Location = new System.Drawing.Point(80, 335);
            this.txt_url_imagen.Name = "txt_url_imagen";
            this.txt_url_imagen.Size = new System.Drawing.Size(500, 32);
            this.txt_url_imagen.TabIndex = 150;
            this.txt_url_imagen.TextChanged += new System.EventHandler(this.txt_url_imagen_TextChanged);
            // 
            // txt_direccion_trabajado
            // 
            this.txt_direccion_trabajado.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_direccion_trabajado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_direccion_trabajado.Location = new System.Drawing.Point(80, 636);
            this.txt_direccion_trabajado.Multiline = true;
            this.txt_direccion_trabajado.Name = "txt_direccion_trabajado";
            this.txt_direccion_trabajado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_direccion_trabajado.Size = new System.Drawing.Size(1036, 191);
            this.txt_direccion_trabajado.TabIndex = 154;
            // 
            // cbo_acceso
            // 
            this.cbo_acceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_acceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_acceso.FormattingEnabled = true;
            this.cbo_acceso.Location = new System.Drawing.Point(44, 503);
            this.cbo_acceso.Name = "cbo_acceso";
            this.cbo_acceso.Size = new System.Drawing.Size(375, 34);
            this.cbo_acceso.TabIndex = 160;
            // 
            // txt_usuario
            // 
            this.txt_usuario.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.Location = new System.Drawing.Point(504, 501);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(379, 35);
            this.txt_usuario.TabIndex = 159;
            this.txt_usuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_usuario_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(630, 445);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 35);
            this.label1.TabIndex = 158;
            this.label1.Text = "Usuario:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(183, 445);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 35);
            this.label6.TabIndex = 157;
            this.label6.Text = "Acceso:";
            // 
            // txt_clave
            // 
            this.txt_clave.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_clave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_clave.Location = new System.Drawing.Point(926, 501);
            this.txt_clave.Name = "txt_clave";
            this.txt_clave.Size = new System.Drawing.Size(375, 35);
            this.txt_clave.TabIndex = 156;
            this.txt_clave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_clave_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(1042, 445);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 35);
            this.label7.TabIndex = 155;
            this.label7.Text = "Contraseña:";
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // FrmAgregarEditarTrabajador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1821, 852);
            this.Controls.Add(this.cbo_acceso);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_clave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_direccion_trabajado);
            this.Controls.Add(this.lb_img);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.txt_url_imagen);
            this.Controls.Add(this.txt_numero_documento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbo_sexo);
            this.Controls.Add(this.dtp_fecha_nacimiento);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_id_trabajador);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_cargo);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.lbl_presentacion);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.lbl_sector);
            this.Controls.Add(this.btn_subir_imagen);
            this.Controls.Add(this.pbx_img);
            this.Name = "FrmAgregarEditarTrabajador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgregarEditarTrabajador";
            this.Load += new System.EventHandler(this.FrmAgregarEditarTrabajador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_numero_documento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_sexo;
        private System.Windows.Forms.DateTimePicker dtp_fecha_nacimiento;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_id_trabajador;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_cargo;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_presentacion;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.Label lbl_sector;
        private System.Windows.Forms.Button btn_subir_imagen;
        private System.Windows.Forms.PictureBox pbx_img;
        private System.Windows.Forms.Label lb_img;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.TextBox txt_url_imagen;
        private System.Windows.Forms.TextBox txt_direccion_trabajado;
        private System.Windows.Forms.ComboBox cbo_acceso;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_clave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorIcono;
    }
}