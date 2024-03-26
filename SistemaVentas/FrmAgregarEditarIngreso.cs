using CapaDominio;
using System;
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
    public partial class FrmAgregarEditarIngreso : Form
    {

        private Ingreso _Ingreso = null;

        public FrmAgregarEditarIngreso()
        {
            InitializeComponent();
            Text = "Agregar Ingreso";
        }
        public FrmAgregarEditarIngreso(Ingreso ingreso)
        {
            InitializeComponent();
            this._Ingreso = ingreso;
            Text = "Modificar Ingreso";
        }


        private void FrmAgregarEditarIngreso_Load(object sender, EventArgs e)
        {

        }
    }
}
