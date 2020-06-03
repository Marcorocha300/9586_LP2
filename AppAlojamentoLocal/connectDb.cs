using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAlojamentoLocal
{
    class ConnectDb
    {
        SqlConnection con = new SqlConnection();
        //construtor
        public ConnectDb()
        {
            con.ConnectionString = @"Data Source=localhost\MSSQLSERVER01;Initial Catalog=AlojamentoDb;Integrated Security=True";
        }
        //Metodo conectar
        public SqlConnection Connect()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        //Metodo desconectar
        public void Disconnect()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
