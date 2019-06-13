using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class TravelExpertsDB
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection();
            string ConnectionString = "Data Source=softdev; Initial Catalog=TravelExperts; Integrated Security=true;";
            //string ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=TravelExperts;Integrated Security=True";
            connection.ConnectionString = ConnectionString;
            connection.Open();

            return connection;
        }
    }
}
