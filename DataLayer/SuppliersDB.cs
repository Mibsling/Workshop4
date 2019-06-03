using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using System.Data.SqlClient;

namespace DataLayer
{
    class SuppliersDB
    {
        public static List<Suppliers> GetPackages()
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();
            List<Suppliers> results = new List<Suppliers>();
            try
            {
                string sql = "SELECT SupplierID, SupName FROM Suppliers";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                while (reader.Read())

                {
                    Suppliers s = new Suppliers();

                    s.SupplierID = Convert.ToInt32(reader["SuppliersID"]);
                    s.SupName = reader["SupName"].ToString();
                    
                    results.Add(s);
                }
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }


            return results;
        }

        public static void AddPackage(string SupName)
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();
            try
            {

                string sql = "INSERT INTO Suppliers (SupName) VALUES (@SupName)";

                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@SupName", SupName);
                
                command.ExecuteNonQuery();


            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }
        }
    }
} 
}
