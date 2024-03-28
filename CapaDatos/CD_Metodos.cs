using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Input;
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

                picture.Load("https://tse3.mm.bing.net/th?id=OIP.-CiVIfCy46VrgitiIjfahwAAAA&pid=Api&P=0&h=180");
            }
        }


        // Metodo para generar un código para un nuevo registro en esa tabla

        //public string GenerarCodigo(string Tabla)
        //{
        //    string codigo = string.Empty;
        //    int total = 0;

        //       ("Select COUNT(*) as TotalRegistros from");


        //    if (Reader.Read())
        //    {
        //        total = Convert.ToInt32(Reader["TotalRegistros"]) + 1;
        //    }
        //    Reader.Close();
        //    if (total < 10)
        //    {
        //        codigo = "0000000" + total;
        //    }
        //    else if (total < 100)
        //    {
        //        codigo = "000000" + total;
        //    }
        //    else if (total < 1000)
        //    {
        //        codigo = "00000" + total;
        //    }
        //    else if (total < 10000)
        //    {
        //        codigo = "0000" + total;
        //    }
        //    else if (total < 100000)
        //    {
        //        codigo = "000" + total;
        //    }
        //    else if (total < 1000000)
        //    {
        //        codigo = "00" + total;
        //    }
        //    else if (total < 10000000)
        //    {
        //        codigo = "0" + total;
        //    }
        //    Conexion.CerrarConexion();
        //    return codigo;
        //}

    }
}
