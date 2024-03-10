using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Conexion
    {

        private SqlConnection conection;
        private SqlCommand comand;
        private SqlDataReader lector;

        public SqlDataReader Lector
        {
            get { return lector; }
        }
        public CD_Conexion()
        {

            conection = new SqlConnection("server=.\\SQLEXPRESS; database=DB-VENTAS;  integrated security=true");
            comand = new SqlCommand();
        }
        public void SetConsutar(string consulta)
        {
            comand.CommandType = System.Data.CommandType.Text;
            comand.CommandText = consulta;
        }
        public void SetConsutarProcedure(string consulta)
        {
            comand.CommandType = System.Data.CommandType.StoredProcedure;
            comand.CommandText = consulta;
        }



        public void EjecutarLectura()
        {
            comand.Connection = conection;
            try
            {
                conection.Open();

                lector = comand.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void EjecutarAccion()
        {
            comand.Connection = conection;

            try
            {
                conection.Open();
                comand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public void SetearParametro(string nombre, object valor)
        {
            comand.Parameters.AddWithValue(nombre, valor);
        }
        public void CerrarConection()
        {
            if (lector != null)
            {
                lector.Close();
                conection.Close();
            }

        }
    }
}
