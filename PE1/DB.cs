using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE1
{
    class DB
    {
        SqlConnection connection = new SqlConnection("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=ExampleDB;Integrated Security=SSPI;");
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        public SqlConnection getConnection()
        {
            return connection;
        }
    }
}
