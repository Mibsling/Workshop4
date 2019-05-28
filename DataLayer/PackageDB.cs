using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;

namespace DataLayer
{
    public static class PackageDB
    {
        public static Package GetPackage(int ID)
        {
            SqlConnection connection = TravelExpertsDB.GetConnection(); ;
            Package s = new Package();
            try
            {

                string sql = "SELECT PackageId, PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommision FROM Packages WHERE PackageId = " + ID;
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                while (reader.Read())

                {
                    s.PackageId = Convert.ToInt32(reader["PackageId"]);
                    s.PkgName = reader["PkgName"].ToString();
                    s.PkgStartDate = reader["Name"].ToString();
                    s.PkgEndDate = reader["Name"].ToString();
                    s.PkgDesc = reader["PkgDesc"].ToString();
                    s.PkgBasePrice = reader["Name"].ToString();
                    s.PkgAgencyCommision = reader["Name"].ToString();


                    //results.Add(s);
                }
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }


            return s;
        }

        public static void AddCustomer(string PkgName, string PkgStartDate, string PkgEndDate, string PkgDesc, string PkgBasePrice, string PkgAgencyCommision)
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();
            try
            {

                string sql = "INSERT INTO Packages (PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommision) VALUES (@PkgName, @PkgStartDate, @PkgEndDate, @PkgDesc, @PkgBasePrice, @PkgAgencyCommision)";

                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@PkgName", PkgName);
                command.Parameters.AddWithValue("@PkgStartDate", PkgStartDate);
                command.Parameters.AddWithValue("@PkgEndDate", PkgEndDate);
                command.Parameters.AddWithValue("@PkgDesc", PkgDesc);
                command.Parameters.AddWithValue("@PkgBasePrice", PkgBasePrice);
                command.Parameters.AddWithValue("@PkgAgencyCommision", PkgAgencyCommision);

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
