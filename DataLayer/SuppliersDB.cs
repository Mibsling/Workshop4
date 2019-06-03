using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public static class SuppliersDB
    {
        public static int maxSupplierId=0;
        public static List<Suppliers> GetSuppliers()
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();
            List<Suppliers> results = new List<Suppliers>();
            try
            {
                string sql = "SELECT SupplierId, SupName FROM Suppliers ";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Suppliers t = new Suppliers();
                    t.SupplierId = Convert.ToInt32(reader["SupplierId"]);
                    t.SupName = reader["SupName"].ToString();
                    results.Add(t);
                    if (t.SupplierId > maxSupplierId)
                    {
                        maxSupplierId = t.SupplierId;
                    }
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
        /*
        public static int getMaxSupplierId()
        {

        }*/


        public static void AddSuppliers(int SupplierId, string SupName)
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();
            try
            {
                string sql = "INSERT INTO Suppliers(SupplierId, SupName) VALUES(@SuplierId, @SupName)";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@SuplierId", SupplierId);
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

        public static void EditSuppliers(string SupplierId, string SupName)
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();
            try
            {
                string sql = "UPDATE Suppliers SET SupName = (@SupName) where SupplierId = @SupplierId";
                //UPDATE Suppliers SET SupName = ('test') where SupplierId = 69
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@SupplierId", SupplierId);
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

