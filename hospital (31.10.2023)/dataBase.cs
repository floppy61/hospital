using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace hospital
{
    internal class dataBase
    {
        static readonly SqlConnection con = new SqlConnection($"Data Source={Environment.MachineName};" +
            $"Initial Catalog=medinst;Integrated Security=True;MultipleActiveResultSets=true;");

        public void openConnection()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            { con.Open(); }
        }
        public void closeConnection()
        {
            if (con.State == System.Data.ConnectionState.Open)
            { con.Close(); }
        }

        public SqlConnection GetConnection()
        {
            return con;
        }
    }
}
