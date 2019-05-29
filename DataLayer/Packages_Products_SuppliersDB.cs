using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    class Packages_Products_SuppliersDB
    {
        /*
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
        */
    }
}
