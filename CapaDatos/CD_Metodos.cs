using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CapaDatos
{
    public class CD_Metodos
    {
        // Metodo para alternar los colores en las filas de un data grid
        public void AlternarColor(DataGridView Dgv)
        {
            Dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
            Dgv.DefaultCellStyle.BackColor = Color.White;
        }

        //Metodo para dar formato moneda a un texBox 

        public void FormatoMoneda(TextBox xTextBox)
        {

            if (xTextBox.Text == string.Empty)
            {
                return;
            }
            else
            {
                decimal monto = decimal.Parse(xTextBox.Text);
                xTextBox.Text = monto.ToString("N2");

            }

        }


        public void CargarImg(PictureBox picture, string img)
        {
            try
            {
                picture.Load(img);
            }
            catch (Exception)
            {

                picture.Load("https://tse1.mm.bing.net/th?id=OIP.DSvrEGChdMh67YH0GPo4TQHaHa&pid=Api&P=0&h=180");
            }
        }
    }
}
