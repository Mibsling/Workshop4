using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BusinessLayer;

namespace DataLayer
{
    public static class ProductsDB
    {
        public static List<Products> GetProducts()
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();
            List<Products> results = new List<Products>();
            try
            {
                string sql = "SELECT ProductId, ProdName FROM Products ";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Products d = new Products();
                    d.ProductId = Convert.ToInt32(reader["ProductId"]);
                    d.ProdName = reader["ProdName"].ToString();
                    results.Add(d);
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

        public static void AddProducts(string ProdName)
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();
            try
            {

                string sql = "INSERT INTO Products (ProdName) VALUES (@ProdName)";

                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@ProdName", ProdName);                
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

        public static void EditProducts(string ProdName, string ProdID)
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();
            try
            {
                string sql = "UPDATE Products SET ProdName = (@ProdName) where ProductId = @ProdID";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@ProdName", ProdName);
                command.Parameters.AddWithValue("@ProdID", ProdID);
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

