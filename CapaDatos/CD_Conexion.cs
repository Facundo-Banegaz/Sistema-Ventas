using System;
using System.Data;
using System.Data.SqlClient;

public class CD_Conexion
{
    private SqlConnection conection;
    private SqlCommand comand;
    private SqlDataReader lector;
    private SqlTransaction transaccion;

    public SqlDataReader Lector
    {
        get { return lector; }
    }

    public CD_Conexion()
    {
        conection = new SqlConnection("server=.\\SQLEXPRESS; database=DB-VENTAS; integrated security=true");
        comand = new SqlCommand();
    }

    public void SetConsutar(string consulta)
    {
        comand.CommandType = CommandType.Text;
        comand.CommandText = consulta;
    }

    public void SetConsutarProcedure(string consulta)
    {
        comand.CommandType = CommandType.StoredProcedure;
        comand.CommandText = consulta;
    }

    public void IniciarTransaccion()
    {
        conection.Open();
        transaccion = conection.BeginTransaction();
        comand.Transaction = transaccion;
    }

    public void ConfirmarTransaccion()
    {
        transaccion.Commit();
        CerrarConection();
    }

    public void AnularTransaccion()
    {
        transaccion.Rollback();
        CerrarConection();
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

    public int ObtenerValorParametroSalida(string nombre)
    {
        if (comand.Parameters.Contains(nombre))
        {
            return Convert.ToInt32(comand.Parameters[nombre].Value);
        }
        else
        {
            throw new ArgumentException("El parámetro de salida no existe en el comando.");
        }
    }

    //public void SetearParametroSalida(string nombre, SqlDbType tipoDato)
    //{
    //    SqlParameter parametro = new SqlParameter(nombre, tipoDato);
    //    parametro.Direction = ParameterDirection.Output;
    //    comand.Parameters.Add(parametro);
    //}

    public void CerrarConection()
    {
        if (lector != null)
        {
            lector.Close();
        }
        if (conection.State == ConnectionState.Open)
        {
            conection.Close();
        }
    }
}
