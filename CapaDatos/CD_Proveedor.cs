using CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Proveedor
    {
        private CD_Conexion Conexion;
        private Proveedor Proveedor;

        private List<Proveedor> listaProveedor;

        public List<Proveedor> ListarProveedores()
        {

            Conexion = new CD_Conexion();
            listaProveedor = new List<Proveedor>();


            try
            {
                Conexion.SetConsutarProcedure("SpMostrar_Proveedor");

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    Proveedor = new Proveedor();

                    Proveedor.Id_proveedor = (int)Conexion.Lector["Id_proveedor"];
                    Proveedor.RazonSocial = (string)Conexion.Lector["Razon_social"];
                    Proveedor.SectorComercial = (string)Conexion.Lector["Sector_comercial"];
                    Proveedor.PaginaWeb = (string)Conexion.Lector["Pagina_web"];
                    Proveedor.Direccion = (string)Conexion.Lector["Direccion"];
                    Proveedor.Telefono = (string)Conexion.Lector["Telefono"];
                    Proveedor.Email = (string)Conexion.Lector["Email"];

                    if (!(Conexion.Lector["UrlImagen"] is DBNull))
                        Proveedor.UrlImagen = (string)Conexion.Lector["UrlImagen"];




                    listaProveedor.Add(Proveedor);


                }

                return listaProveedor;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                Conexion.CerrarConection();
            }

        }



        //metodo insertar

        public void InsertarProveedor (Proveedor Nuevo)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsutarProcedure("SpInsertar_proveedor");

                Conexion.SetearParametro("@Razon_social", Nuevo.RazonSocial);
                Conexion.SetearParametro("@Sector_comercial", Nuevo.SectorComercial);
                Conexion.SetearParametro("@Pagina_web", Nuevo.PaginaWeb);
                Conexion.SetearParametro("@Direccion", Nuevo.Direccion); 
                Conexion.SetearParametro("@Telefono", Nuevo.Telefono); 
                Conexion.SetearParametro("@Email", Nuevo.Email);
                Conexion.SetearParametro("@UrlImagen", Nuevo.UrlImagen);


                Conexion.EjecutarAccion();


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                Conexion.CerrarConection();
            }
        }


        //metodo editar

        public void EditarProveedor(Proveedor proveedor)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsutarProcedure("SpEditar_proveedor");

                Conexion.SetearParametro("@Id_proveedor", proveedor.Id_proveedor);
                Conexion.SetearParametro("@Razon_social", proveedor.RazonSocial);
                Conexion.SetearParametro("@Sector_comercial", proveedor.SectorComercial);
                Conexion.SetearParametro("@Pagina_web", proveedor.PaginaWeb);
                Conexion.SetearParametro("@Direccion", proveedor.Direccion);
                Conexion.SetearParametro("@Telefono", proveedor.Telefono);
                Conexion.SetearParametro("@Email", proveedor.Email);
                Conexion.SetearParametro("@UrlImagen", proveedor.UrlImagen);

                Conexion.EjecutarAccion();


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                Conexion.CerrarConection();
            }

        }

        //Metodo eliminar
        public void EliminarProveedor(int Id_proveedor)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsutarProcedure("SpEliminar_proveedor");

                Conexion.SetearParametro("@Id_proveedor", Id_proveedor);


                Conexion.EjecutarAccion();


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                Conexion.CerrarConection();
            }
        }

        //Metodo Buscar

        public List<Proveedor> ProveedorBuscar(string buscar)
        {
            Conexion = new CD_Conexion();
            listaProveedor = new List<Proveedor>();

            try
            {
                Conexion.SetConsutarProcedure("spBuscar_proveedor_razon_social");


                Conexion.SetearParametro("@txt_buscar", buscar);


                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {

                    Proveedor = new Proveedor();

                    Proveedor.Id_proveedor = (int)Conexion.Lector["Id_proveedor"];
                    Proveedor.RazonSocial = (string)Conexion.Lector["RazonSocial"];
                    Proveedor.SectorComercial = (string)Conexion.Lector["SectorComercial"];
                    Proveedor.PaginaWeb = (string)Conexion.Lector["Pagina_web"];
                    Proveedor.Direccion = (string)Conexion.Lector["Direccion"];
                    Proveedor.Telefono = (string)Conexion.Lector["Telefono"];
                    Proveedor.Email = (string)Conexion.Lector["Email"];

                    if (!(Conexion.Lector["UrlImagen"] is DBNull))
                        Proveedor.UrlImagen = (string)Conexion.Lector["UrlImagen"];

                    listaProveedor.Add(Proveedor);
                }


                return listaProveedor;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                Conexion.CerrarConection();
            }
        }



    }
}
