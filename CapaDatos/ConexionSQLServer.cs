using CapaNegocio;
using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    public class ConexionSQLServer : FuenteDeDatos

    {
        private SqlConnection conexion;
        
        public ConexionSQLServer()
        {
            this.conexion = new SqlConnection("TrustServerCertificate=true;Password=migue3022;Persist Security Info=True;User ID=sa;Initial Catalog=CentralRiesgo;Data Source=MIGUE");
        }
        
        public int consultarPuntaje(int documento)
        {
            conexion.Open();

            string select = string.Format(
                "SELECT puntaje FROM personas WHERE documento = '{0}'",
                documento);

            SqlCommand comando = new SqlCommand(select, conexion);

            SqlDataReader dataReader = comando.ExecuteReader();
            int puntaje = 0;
            if (dataReader.Read())
            {
                puntaje = int.Parse(dataReader.GetValue(0).ToString());
            } else if (puntaje == 0) 
            {
                conexion.Close();
                return -1;
            }

            conexion.Close();

            return puntaje;
        }
    }
}
