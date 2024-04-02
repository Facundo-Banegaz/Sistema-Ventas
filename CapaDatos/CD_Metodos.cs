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
using CapaDominio;
using System.Globalization;

namespace CapaDatos
{
    public class CD_Metodos

    {
        private CD_Conexion Conexion;

        // Metodo para alternar los colores en las filas de un data grid
        public void AlternarColor(DataGridView Dgv)
        {
            Dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
            Dgv.DefaultCellStyle.BackColor = Color.White;
        }

        //Metodo para dar formato moneda a un texBox




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

        public string GenerarCodigo(string Tabla)
        {
            Conexion = new CD_Conexion();
            Conexion.SetConsutar("Select COUNT(*) as TotalRegistros from " + Tabla);
            Conexion.EjecutarLectura();

            long total = 0;
            if (Conexion.Lector.Read())
            {
                total = Convert.ToInt64(Conexion.Lector["TotalRegistros"]) + 1;
            }
            Conexion.CerrarConection();

            string codigo = total.ToString().PadLeft(10, '0'); // 8 es el ancho total del código

            return codigo;
        }



    }
}
