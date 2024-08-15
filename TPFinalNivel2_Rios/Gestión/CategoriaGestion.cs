using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión
{
    public class CategoriaGestion
    {
        public List<Categoria> Listar() { 
            List<Categoria> categorias = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetConsulta("SELECT Id, Descripcion FROM CATEGORIAS");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Categoria categoriaX = new Categoria();
                    categoriaX.Id = (int)datos.Lector["Id"];
                    categoriaX.Descripcion = (string)datos.Lector["Descripcion"];
                    categorias.Add(categoriaX);
                }
                return categorias;
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
    }
}
