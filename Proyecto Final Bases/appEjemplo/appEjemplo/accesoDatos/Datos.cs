using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace appEjemplo.accesoDatos
{
    internal class Datos
    {
        string cadenaConexion = "Data Source=localhost;User ID = torricelli; Password=oracle";

        public int ejecutarDML(string consulta)
        {

            try
            {

                int filasAfectadas;
                OracleConnection miConexion = new OracleConnection(cadenaConexion);
                OracleCommand comando = new OracleCommand(consulta, miConexion);
                miConexion.Open();

                filasAfectadas = comando.ExecuteNonQuery();

                miConexion.Close();

                return filasAfectadas;

            }
            catch (Oracle.ManagedDataAccess.Client.OracleException)
            {
                MessageBox.Show("No existen esos datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            return 0;

        }
        
        public DataSet ejecutarSELECT(string consulta)
        {
            DataSet ds = new DataSet();
            OracleDataAdapter adaptador = new OracleDataAdapter(consulta,cadenaConexion);
            adaptador.Fill(ds, "ResultadoDatos");
            return ds;  

        }


    }
}
 