using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;
using System.Diagnostics.Eventing.Reader;

namespace Gestión
{
    public class ListaGestion
    {
        public List<Articulo> Listar()
        {
            List<Articulo> listaArticulos = new List<Articulo>();
            SqlConnection conexionDB = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            try
            {
                conexionDB.ConnectionString = "server=.\\SQLEXPRESS; database = CATALOGO_DB; integrated security = true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select A.Id, Codigo, Nombre, A.Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio, C.Descripcion, M.Descripcion, M.Id, C.Id from ARTICULOS A, CATEGORIAS C, MARCAS M Where IdMarca = M.Id and IdCategoria = C.Id";
                comando.Connection = conexionDB;
                conexionDB.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {   
                    Articulo artAuxiliar = new Articulo(); //Diferentes formas de guardar los datos en las propiedades de Articulo.
                    artAuxiliar.Id = lector.GetInt32(0);
                    artAuxiliar.Codigo = lector.GetString(1);
                    artAuxiliar.Nombre = (string)lector["Nombre"];
                    artAuxiliar.Descripcion = lector.GetString(3);
                    artAuxiliar.Marca.Id = (int)lector["IdMarca"];
                    artAuxiliar.Marca.Descripcion = (string)lector.GetString(9);
                    artAuxiliar.Categoria.Id = (int)lector["IdCategoria"];
                    artAuxiliar.Categoria.Descripcion = (string)lector.GetString(8);
                    if (!(lector["ImagenUrl"] is DBNull))
                        artAuxiliar.UrlImagen = (string)lector["ImagenUrl"];
                    artAuxiliar.Precio = Math.Round(lector.GetDecimal(lector.GetOrdinal("Precio")),2); //Se toma el precio con dos decimales.
                    artAuxiliar.PrecioString = "$" + artAuxiliar.Precio.ToString(); //Para que aparezca el símbolo "$" en el Data Grid View.

                    listaArticulos.Add(artAuxiliar);

                }

                conexionDB.Close();
                return listaArticulos;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void Agregar(Articulo nuevoArticulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetConsulta($"INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, ImagenUrl, Precio, IdMarca, IdCategoria) values ('{nuevoArticulo.Codigo}', '{nuevoArticulo.Nombre}', '{nuevoArticulo.Descripcion}','{nuevoArticulo.UrlImagen}', '{nuevoArticulo.Precio}', @IdMarca, @IdCategoria)");
                datos.SetParametero("@IdMarca", nuevoArticulo.Marca.Id);
                datos.SetParametero("@IdCategoria", nuevoArticulo.Categoria.Id);
                datos.Accion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
        public void Modificar(Articulo modificado)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetConsulta($"UPDATE ARTICULOS SET Codigo = '{modificado.Codigo}', Nombre = '{modificado.Nombre}', Descripcion = '{modificado.Descripcion}', IdMarca = {modificado.Marca.Id}, IdCategoria = {modificado.Categoria.Id}, ImagenUrl = '{modificado.UrlImagen}', Precio = {modificado.Precio} WHERE Id = {modificado.Id}");
                datos.Accion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
           
        }
        public void Eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetConsulta($"DELETE FROM ARTICULOS WHERE Id = {id}");
                datos.Accion();
            }
            catch (Exception ex)
            {
             
                throw;
            }
        }
        public void Eliminar(List<Articulo> lista_a_Eliminar)
        {
            AccesoDatos datos = new AccesoDatos();
            string consulta = "DELETE FROM ARTICULOS WHERE Id = ";
            int contador = 0;
            try
            {
                foreach(Articulo articulo in lista_a_Eliminar)
                {
                    if(lista_a_Eliminar.Count - 1 > contador)
                        consulta += $"{articulo.Id} or Id = ";
                    else
                        consulta += $"{articulo.Id}";

                    contador++;
                }
                datos.SetConsulta(consulta);
                datos.Accion();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public List<Articulo> Filtrar(string campo, string condicion, string filtro)
        {
            List<Articulo> listaFiltrada = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "Select A.Id, Codigo, Nombre, A.Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio, C.Descripcion, M.Descripcion, M.Id, C.Id from ARTICULOS A, CATEGORIAS C, MARCAS M Where IdMarca = M.Id and IdCategoria = C.Id and ";

                if (campo.ToUpper() == "PRECIO")
                {
                    if (filtro != "")
                        consulta += filtrosSql("Precio", condicion, filtro);
                    else
                        consulta = "Select A.Id, Codigo, Nombre, A.Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio, C.Descripcion, M.Descripcion, M.Id, C.Id from ARTICULOS A, CATEGORIAS C, MARCAS M Where IdMarca = M.Id and IdCategoria = C.Id";
                }

                else if (campo.ToUpper() == "CÓDIGO" || campo.ToUpper() == "CÓDIGO DE ARTÍCULO")
                    consulta += filtrosSql("Codigo", condicion, filtro);

                else if (campo.ToUpper() == "NOMBRE")
                    consulta += filtrosSql("Nombre", condicion, filtro);

                else if (campo.ToUpper() == "DESCRIPCIÓN")
                    consulta += filtrosSql("A.Descripcion", condicion, filtro);

                else if (campo.ToUpper() == "MARCA")
                    consulta += filtrosSql("M.Descripcion", condicion, filtro);

                else if (campo.ToUpper() == "CATEGORÍA")
                    consulta += filtrosSql("C.Descripcion", condicion, filtro);

                if (filtro == "")
                    consulta = "Select A.Id, Codigo, Nombre, A.Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio, C.Descripcion, M.Descripcion, M.Id, C.Id from ARTICULOS A, CATEGORIAS C, MARCAS M Where IdMarca = M.Id and IdCategoria = C.Id";
                
                datos.SetConsulta(consulta);
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo artAuxiliar = new Articulo(); //Diferentes formas de guardar los datos en las propiedades de Articulo.
                    artAuxiliar.Id = datos.Lector.GetInt32(0);
                    artAuxiliar.Codigo = datos.Lector.GetString(1);
                    artAuxiliar.Nombre = (string)datos.Lector["Nombre"];
                    artAuxiliar.Descripcion = datos.Lector.GetString(3);
                    artAuxiliar.Marca.Id = (int)datos.Lector["IdMarca"];
                    artAuxiliar.Marca.Descripcion = (string)datos.Lector.GetString(9);
                    artAuxiliar.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    artAuxiliar.Categoria.Descripcion = (string)datos.Lector.GetString(8);
                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                        artAuxiliar.UrlImagen = (string)datos.Lector["ImagenUrl"];
                    artAuxiliar.Precio = Math.Round(datos.Lector.GetDecimal(datos.Lector.GetOrdinal("Precio")), 2); //Se toma el precio con dos decimales.
                    artAuxiliar.PrecioString = "$" + artAuxiliar.Precio.ToString(); //Para que aparezca el símbolo "$" en el Data Grid View.

                    listaFiltrada.Add(artAuxiliar);
                }
                return listaFiltrada;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private string filtrosSql(string campoSeleccionado, string condicion, string filtro)
        {
            string consulta = "";
            if(campoSeleccionado.ToUpper() != "PRECIO")
            {
                
                    switch (condicion)
                    {
                        case "Empieza con":
                            consulta = $"{campoSeleccionado} LIKE '{filtro}%'";
                            break;
                        case "Termina con":
                            consulta = $"{campoSeleccionado} LIKE '%{filtro}'";
                            break;
                        case "Contiene":
                            consulta = $"{campoSeleccionado} LIKE '%{filtro}%'";
                            break;
                        case "No Contiene":
                            consulta = $"{campoSeleccionado} NOT LIKE '%{filtro}%'";
                            break;
                    }
                
            }
            else
            {
               
                    switch (condicion)
                    {
                        case "Menor que":
                            consulta = $"{campoSeleccionado} < {filtro}";
                            break;
                        case "Mayor que":
                            consulta = $"{campoSeleccionado} > {filtro}";
                            break;
                        case "Igual a":
                            consulta = $"{campoSeleccionado} = {filtro}";
                            break;
                        case "Menor o igual que":
                            consulta = $"{campoSeleccionado} <= {filtro}";
                            break;
                        case "Mayor o igual que":
                            consulta = $"{campoSeleccionado} >= {filtro}";
                            break;
                    }
            }
            return consulta;
        }
       
    }
}
