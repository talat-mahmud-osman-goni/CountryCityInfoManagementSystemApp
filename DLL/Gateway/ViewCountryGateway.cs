using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using CountryCityInfoManagementSystemApp.DLL.Model.ViewModel;

namespace CountryCityInfoManagementSystemApp.DLL.Gateway
{
    public class ViewCountryGateway:CommonGateway
    {
        public List<ViewCountry> GetAllViewCountry()
        {
            Query = "SELECT * FROM ViewCountry ORDER BY CountryName ASC";

            Command = new SqlCommand(Query, Connection);

            List<ViewCountry> aList = new List<ViewCountry>();

            Connection.Open();
            Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                ViewCountry aViewCountry = new ViewCountry();

                aViewCountry.CountryName = Reader["CountryName"].ToString();
                aViewCountry.CountryAbout = Reader["CountryAbout"].ToString();
                aViewCountry.NoOfCities = Convert.ToInt32(Reader["TotalCity"]);
                aViewCountry.NoOfCityDwellers = Convert.ToInt64(Reader["NoOfCityDwellers"]);
                
                aList.Add(aViewCountry);
            }

            Reader.Close();
            Connection.Close();

            return aList;

        }
        public List<ViewCountry> GetViewCountryBySearch(string searchkey)
        {
            Query = "SELECT * FROM ViewCountry WHERE CountryName LIKE '%" + searchkey + "%' ORDER BY CountryName ASC";
            Command = new SqlCommand(Query, Connection);

            List<ViewCountry> aList = new List<ViewCountry>();

            Connection.Open();
            Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                ViewCountry aViewCountry = new ViewCountry();

                aViewCountry.CountryName = Reader["CountryName"].ToString();
                aViewCountry.CountryAbout = Reader["CountryAbout"].ToString();
                aViewCountry.NoOfCities = Convert.ToInt32(Reader["TotalCity"]);
                aViewCountry.NoOfCityDwellers = Convert.ToInt64(Reader["NoOfCityDwellers"]);

                aList.Add(aViewCountry);
            }

            Reader.Close();
            Connection.Close();

            return aList;
        }
    }
}