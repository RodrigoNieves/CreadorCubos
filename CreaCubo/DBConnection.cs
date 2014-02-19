using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CreaCubo
{
    class DBConnection
    {
        private SqlConnection myConnection;
        public DBConnection(String StringConexion) {
             myConnection = new SqlConnection(StringConexion);
        }
        public void connect() {
            try
            {
                myConnection.Open();
            }
            catch(Exception e) {
                Console.WriteLine(e.ToString());
            }
        }
        public void ejecutaComando(String comando) {
            SqlCommand myCommand = new SqlCommand(comando, myConnection);
            myCommand.ExecuteNonQuery();
        }
        public DataTable ejecutaQuery(String query)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand myCommand = new SqlCommand(query,myConnection);
                SqlDataAdapter da = new SqlDataAdapter(myCommand);
                da.Fill(dt);
                da.Dispose();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return dt;
        }
        ~DBConnection() { 
            try
            {
                //myConnection.Close();
            }
            finally
            {
            }
        }
    }
}
