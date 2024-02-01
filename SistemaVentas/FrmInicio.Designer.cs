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
            this.pb_barra_progreso = new System.Windows.Forms.ProgressBar();
            this.lbl_presentacion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_porcentaje = new System.Windows.Forms.Label();
            this.tm_tiempo = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_barra_progreso
            // 
            this.pb_barra_progreso.BackColor = System.Drawing.Color.LimeGreen;
            this.pb_barra_progreso.Location = new System.Drawing.Point(28, 417);
            this.pb_barra_progreso.Name = "pb_barra_progreso";
            this.pb_barra_progreso.Size = new System.Drawing.Size(1021, 50);
            this.pb_barra_progreso.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pb_barra_progreso.TabIndex = 5;
            // 
            // lbl_presentacion
            // 
            this.lbl_presentacion.AutoSize = true;
            this.lbl_presentacion.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_presentacion.Font = new System.Drawing.Font("Impact", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_presentacion.ForeColor = System.Drawing.Color.Orange;
            this.lbl_presentacion.Location = new System.Drawing.Point(311, 9);
            this.lbl_presentacion.Name = "lbl_presentacion";
            this.lbl_presentacion.Size = new System.Drawing.Size(455, 68);
            this.lbl_presentacion.TabIndex = 4;
            this.lbl_presentacion.Text = "SISTEMA DE VENTAS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(407, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Size = new System.Drawing.Size(260, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_porcentaje
            // 
            this.lbl_porcentaje.AccessibleDescription = "porcentaje";
            this.lbl_porcentaje.AutoSize = true;
            this.lbl_porcentaje.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_porcentaje.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_porcentaje.ForeColor = System.Drawing.Color.Lime;
            this.lbl_porcentaje.Location = new System.Drawing.Point(399, 484);
            this.lbl_porcentaje.Name = "lbl_porcentaje";
            this.lbl_porcentaje.Size = new System.Drawing.Size(0, 48);
            this.lbl_porcentaje.TabIndex = 6;
            // 
            // tm_tiempo
            // 
            this.tm_tiempo.Tick += new System.EventHandler(this.tm_tiempo_Tick);
            // 
            // FrmPresentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1076, 541);
            this.Controls.Add(this.lbl_porcentaje);
            this.Controls.Add(this.pb_barra_progreso);
            this.Controls.Add(this.lbl_presentacion);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPresentacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido!!";
            this.Load += new System.EventHandler(this.FrmPresentacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pb_barra_progreso;
        private System.Windows.Forms.Label lbl_presentacion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_porcentaje;
        private System.Windows.Forms.Timer tm_tiempo;
    }
}