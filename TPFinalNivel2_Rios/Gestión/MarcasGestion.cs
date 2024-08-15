using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Gestión
{
    public class MarcasGestion
    {
        public List<Marca> Listar()
        {
            List<Marca> marcas = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetConsulta("SELECT Id, Descripcion FROM MARCAS");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Marca marcaX = new Marca();
                    marcaX.Id = (int)datos.Lector["Id"];
                    marcaX.Descripcion = (string)datos.Lector["Descripcion"];
                    marcas.Add(marcaX);
                }
                return marcas;
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
