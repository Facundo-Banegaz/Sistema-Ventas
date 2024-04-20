namespace SistemaVentas
{
    partial class FrmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tm_tiempo = new System.Windows.Forms.Timer(this.components);
            this.lbl_mensaje = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pb_barra_progreso = new CircularProgressBar.CircularProgressBar();
            this.lbl_presentacion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Orange;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Size = new System.Drawing.Size(677, 556);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // tm_tiempo
            // 
            this.tm_tiempo.Tick += new System.EventHandler(this.tm_tiempo_Tick);
            // 
            // lbl_mensaje
            // 
            this.lbl_mensaje.AutoSize = true;
            this.lbl_mensaje.BackColor = System.Drawing.SystemColors.InfoText;
            this.lbl_mensaje.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mensaje.ForeColor = System.Drawing.Color.White;
            this.lbl_mensaje.Location = new System.Drawing.Point(911, 530);
            this.lbl_mensaje.Name = "lbl_mensaje";
            this.lbl_mensaje.Size = new System.Drawing.Size(258, 35);
            this.lbl_mensaje.TabIndex = 8;
            this.lbl_mensaje.Text = "Espere un momento...";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(781, 488);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 64);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pb_barra_progreso
            // 
            this.pb_barra_progreso.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.pb_barra_progreso.AnimationSpeed = 500;
            this.pb_barra_progreso.BackColor = System.Drawing.Color.Transparent;
            this.pb_barra_progreso.Font = new System.Drawing.Font("Impact", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pb_barra_progreso.ForeColor = System.Drawing.Color.White;
            this.pb_barra_progreso.InnerColor = System.Drawing.Color.Black;
            this.pb_barra_progreso.InnerMargin = 2;
            this.pb_barra_progreso.InnerWidth = -1;
            this.pb_barra_progreso.Location = new System.Drawing.Point(831, 183);
            this.pb_barra_progreso.MarqueeAnimationSpeed = 2000;
            this.pb_barra_progreso.Name = "pb_barra_progreso";
            this.pb_barra_progreso.OuterColor = System.Drawing.SystemColors.ButtonShadow;
            this.pb_barra_progreso.OuterMargin = -25;
            this.pb_barra_progreso.OuterWidth = 26;
            this.pb_barra_progreso.ProgressColor = System.Drawing.Color.Lime;
            this.pb_barra_progreso.ProgressWidth = 20;
            this.pb_barra_progreso.SecondaryFont = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pb_barra_progreso.Size = new System.Drawing.Size(290, 270);
            this.pb_barra_progreso.StartAngle = 270;
            this.pb_barra_progreso.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pb_barra_progreso.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.pb_barra_progreso.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.pb_barra_progreso.SubscriptText = "";
            this.pb_barra_progreso.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.pb_barra_progreso.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.pb_barra_progreso.SuperscriptText = "";
            this.pb_barra_progreso.TabIndex = 5;
            this.pb_barra_progreso.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.pb_barra_progreso.Value = 1;
            // 
            // lbl_presentacion
            // 
            this.lbl_presentacion.AutoSize = true;
            this.lbl_presentacion.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_presentacion.Font = new System.Drawing.Font("Impact", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_presentacion.ForeColor = System.Drawing.Color.Orange;
            this.lbl_presentacion.Location = new System.Drawing.Point(725, 9);
            this.lbl_presentacion.Name = "lbl_presentacion";
            this.lbl_presentacion.Size = new System.Drawing.Size(455, 68);
            this.lbl_presentacion.TabIndex = 9;
            this.lbl_presentacion.Text = "SISTEMA DE VENTAS";
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1224, 600);
            this.Controls.Add(this.lbl_presentacion);
            this.Controls.Add(this.lbl_mensaje);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pb_barra_progreso);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido!!";
            this.Load += new System.EventHandler(this.FrmPresentacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer tm_tiempo;
        private System.Windows.Forms.Label lbl_mensaje;
        private System.Windows.Forms.PictureBox pictureBox3;
        private CircularProgressBar.CircularProgressBar pb_barra_progreso;
        private System.Windows.Forms.Label lbl_presentacion;
    }
}