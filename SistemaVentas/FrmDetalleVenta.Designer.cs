namespace SistemaVentas
{
    partial class FrmDetalleVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDetalleVenta));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.dgv_detalles = new System.Windows.Forms.DataGridView();
            this.lbl_total = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalles)).BeginInit();
            this.SuspendLayout();
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
            this.btn_cancelar.Location = new System.Drawing.Point(1637, 753);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(197, 66);
            this.btn_cancelar.TabIndex = 187;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // dgv_detalles
            // 
            this.dgv_detalles.AllowUserToAddRows = false;
            this.dgv_detalles.AllowUserToDeleteRows = false;
            this.dgv_detalles.AllowUserToOrderColumns = true;
            this.dgv_detalles.AllowUserToResizeRows = false;
            this.dgv_detalles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_detalles.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_detalles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_detalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_detalles.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_detalles.EnableHeadersVisualStyles = false;
            this.dgv_detalles.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgv_detalles.Location = new System.Drawing.Point(18, 12);
            this.dgv_detalles.Name = "dgv_detalles";
            this.dgv_detalles.ReadOnly = true;
            this.dgv_detalles.RowHeadersVisible = false;
            this.dgv_detalles.RowHeadersWidth = 62;
            this.dgv_detalles.RowTemplate.Height = 28;
            this.dgv_detalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_detalles.Size = new System.Drawing.Size(1816, 694);
            this.dgv_detalles.TabIndex = 186;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.BackColor = System.Drawing.SystemColors.ControlText;
            this.lbl_total.Font = new System.Drawing.Font("Impact", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.Color.LawnGreen;
            this.lbl_total.Location = new System.Drawing.Point(25, 753);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(107, 54);
            this.lbl_total.TabIndex = 188;
            this.lbl_total.Text = "ssss";
            // 
            // FrmDetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1852, 831);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.dgv_detalles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmDetalleVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDetalleVenta";
            this.Load += new System.EventHandler(this.FrmDetalleVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelar;
        public System.Windows.Forms.DataGridView dgv_detalles;
        private System.Windows.Forms.Label lbl_total;
    }
}