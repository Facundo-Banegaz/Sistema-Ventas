﻿using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace CapaNegocio
{
    public class CN_Metodos
    {
        CD_Metodos objMetodos = new CD_Metodos();


        // Metodo para alternar los colores en las filas de un data grid
        public void AlternarColor(DataGridView Dgv)
        {
            objMetodos.AlternarColor(Dgv);
        }


        //Metodo para dar formato moneda a un texBox 

        public void FormatoMoneda(TextBox xTextBox)
        {
            objMetodos.FormatoMoneda((TextBox)xTextBox);
        }



        public void CargarImg(PictureBox picture, string img)
        {
            objMetodos.CargarImg(picture, img);
        }
    }
}
