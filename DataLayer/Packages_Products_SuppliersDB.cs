using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;

namespace DataLayer
{
    public static class Packages_Products_SuppliersDB
    {

        public static List<Package_Product_Supplier> GetPackage_Products_Suppliers(int PkgId = 1)
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();
            List<Package_Product_Supplier> results = new List<Package_Product_Supplier>();
            try
            {
                string sql = "select s.SupName, p.ProdName from Products p "+
                "join Products_Suppliers ps on ps.ProductId = p.ProductId "+
                "join Suppliers s on ps.SupplierId = s.SupplierId "+
                "join Packages_Products_Suppliers pps on pps.ProductSupplierId = ps.ProductSupplierId "+
                "join Packages on Packages.PackageId = pps.PackageId "+
                "where Packages.PackageId = " + PkgId;
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                while (reader.Read())

                {
                    Package_Product_Supplier s = new Package_Product_Supplier();

                    s.ProdSupText = reader["SupName"] + " - " + reader["ProdName"];

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

        public static void AddPackages_Products_Suppliers(int PackageId, int SupplierId)
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();
            try
            {
                string sql = "INSERT INTO Packages_Products_Suppliers (PackageId, ProductSupplierId) VALUES (@PackageId, @ProductSupplierId)";

                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@PackageId", PackageId);
                command.Parameters.AddWithValue("@ProductSupplierId", SupplierId);
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
