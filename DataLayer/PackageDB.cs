using System;
using System.Collections.Generic;
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

        public static void AddCustomer(string PkgName, string PkgStartDate, string PkgEndDate, string PkgDesc, string PkgBasePrice, string PkgAgencyCommission)
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
    }
}
