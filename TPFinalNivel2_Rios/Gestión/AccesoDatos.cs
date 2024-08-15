using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión
{
    public class AccesoDatos
    {
        private SqlConnection conexionDB;
        private SqlCommand comando;
        private SqlDataReader lector;

        public SqlDataReader Lector
        {
            get { return lector; }
        }
        public AccesoDatos()
        {
            conexionDB = new SqlConnection("server=.\\SQLEXPRESS; database = CATALOGO_DB; integrated security = true");
            comando = new SqlCommand();
        }

        public void SetConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        public void EjecutarLectura()
        {
            comando.Connection = conexionDB;
            try
            {
                conexionDB.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void CerrarConexion()
        {
            if (lector != null) 
                lector.Close();
            conexionDB.Close();
            
        }
      
        public void Accion()
        {
            comando.Connection = conexionDB;
            try
            {
                conexionDB.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void SetParametero(string campo, object valor)
        {
            comando.Parameters.AddWithValue(campo, valor);
        }
    }
}
