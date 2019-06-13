using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;

namespace DataLayer
{
    public class PackageDB
    {
        public static List<Package> GetPackages()
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();
            List<Package> results = new List<Package>();
            try
            {
                string sql = "SELECT PackageId, PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission FROM Packages";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                while (reader.Read())

                {
                    Package s = new Package();

                    s.PackageId = Convert.ToInt32(reader["PackageId"]);
                    s.PkgName = reader["PkgName"].ToString();
                    s.PkgStartDate = reader["PkgStartDate"].ToString();
                    s.PkgEndDate = reader["PkgEndDate"].ToString();
                    s.PkgDesc = reader["PkgDesc"].ToString();
                    s.PkgBasePrice = reader["PkgBasePrice"].ToString();
                    s.PkgAgencyCommission = reader["PkgAgencyCommission"].ToString();


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

        public static void AddPackage(string PkgName, string PkgStartDate, string PkgEndDate, string PkgDesc, string PkgBasePrice, string PkgAgencyCommission)
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();
            try
            {

                string sql = "INSERT INTO Packages (PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission) VALUES (@PkgName, @PkgStartDate, @PkgEndDate, @PkgDesc, @PkgBasePrice, @PkgAgencyCommission)";

                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@PkgName", PkgName);
                command.Parameters.AddWithValue("@PkgStartDate", PkgStartDate);
                command.Parameters.AddWithValue("@PkgEndDate", PkgEndDate);
                command.Parameters.AddWithValue("@PkgDesc", PkgDesc);
                command.Parameters.AddWithValue("@PkgBasePrice", PkgBasePrice);
                command.Parameters.AddWithValue("@PkgAgencyCommission", PkgAgencyCommission);

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

        public static void EditPackage(string PkgId, string PkgName, string PkgStartDate, string PkgEndDate, string PkgDesc, string PkgBasePrice, string PkgAgencyCommission)
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();
            try
            {
                string sql = "UPDATE Packages SET PkgName = @PkgName, PkgStartDate = @PkgStartDate, PkgEndDate= @PkgEndDate, PkgDesc = @PkgDesc, PkgBasePrice = @PkgBasePrice, PkgAgencyCommission = @PkgAgencyCommission where PackageId = @PkgId";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@PkgId", PkgId);
                command.Parameters.AddWithValue("@PkgName", PkgName);
                command.Parameters.AddWithValue("@PkgStartDate", PkgStartDate);
                command.Parameters.AddWithValue("@PkgEndDate", PkgEndDate);
                command.Parameters.AddWithValue("@PkgDesc", PkgDesc);
                command.Parameters.AddWithValue("@PkgBasePrice", PkgBasePrice);
                command.Parameters.AddWithValue("@PkgAgencyCommission", PkgAgencyCommission);
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

        public static void AddProductSupplier(string SupplierName, string ProductName)
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string prodId;
            try
            {
                string sql = "select ProductId from products where ProdName = @ProdName";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                while (reader.Read())

                {
                    prodId = reader["ProductId"].ToString();
                }
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }

            try
            {
                string sql = "select ProductId from products where ProdName = @ProdName";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                while (reader.Read())

                {
                    prodId = reader["ProductId"].ToString();
                }
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }



            //SqlConnection connection = TravelExpertsDB.GetConnection();
            //try
            //{
            //    string sql = "select ProductId from products where ProdName = @ProdName";
            //    string sql2 = "INSERT INTO Products_Suppliers (PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission) VALUES (@PkgName, @PkgStartDate, @PkgEndDate, @PkgDesc, @PkgBasePrice, @PkgAgencyCommission)";

            //    SqlCommand command = new SqlCommand(sql, connection);
            //    command.Parameters.AddWithValue("@PkgName", ProductName);
            //    command.Parameters.AddWithValue("@PkgStartDate", PkgStartDate);

            //    command.ExecuteNonQuery();
            //}
            //catch
            //{

            //}
            //finally
            //{
            //    connection.Close();
            //}
            //            select* from Products_Suppliers ps
            //join Products p on ps.ProductId = p.ProductId
            //join Suppliers s on ps.SupplierId = s.SupplierId
            //where p.ProdName = 'Travel Insurance' and s.SupName = 'ALIOTOURS'
        }
    }
}
