using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using CountryCityInfoManagementSystemApp.DLL.Model;
using CountryCityInfoManagementSystemApp.DLL.Model.ViewModel;

namespace CountryCityInfoManagementSystemApp.DLL.Gateway
{
    public class ViewCityGateway:CommonGateway
    {
        public List<ViewCity> GetAllCityAndCountry()
        {
            Query = "SELECT * FROM ViewCity ORDER BY CityName ASC";

            Command = new SqlCommand(Query, Connection);

            List<ViewCity> aList = new List<ViewCity>();

            Connection.Open();
            Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                ViewCity aViewCity = new ViewCity();

                aViewCity.CityName = Reader["CityName"].ToString();
                aViewCity.CityAbout = Reader["CityAbout"].ToString();
                aViewCity.NoOfDwellers = Convert.ToInt32(Reader["NoOfDwellers"]);
                aViewCity.Location = Reader["Location"].ToString();
                aViewCity.Weather = Reader["Weather"].ToString();
                aViewCity.CountryName = Reader["CountryName"].ToString();
                aViewCity.CountryAbout = Reader["CountryAbout"].ToString();

                aList.Add(aViewCity);
            }

            Reader.Close();
            Connection.Close();

            return aList;

        }

        public List<ViewCity> GetViewCityByCity(string searchkey)
        {
            Query = "SELECT * FROM ViewCity WHERE CityName LIKE '%" + searchkey + "%' ORDER BY CityName ASC";
            Command = new SqlCommand(Query, Connection);

            List<ViewCity> aList = new List<ViewCity>();

            Connection.Open();
            Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                ViewCity aViewCity = new ViewCity();

                aViewCity.CityName = Reader["CityName"].ToString();
                aViewCity.CityAbout = Reader["CityAbout"].ToString();
                aViewCity.NoOfDwellers = Convert.ToInt32(Reader["NoOfDwellers"]);
                aViewCity.Location = Reader["Location"].ToString();
                aViewCity.Weather = Reader["Weather"].ToString();
                aViewCity.CountryName = Reader["CountryName"].ToString();
                aViewCity.CountryAbout = Reader["CountryAbout"].ToString();

                aList.Add(aViewCity);
            }

            Reader.Close();
            Connection.Close();

            return aList;
        }
        public List<ViewCity> GetViewCityByCountry(int searchCountryId)
        {
            Query = "SELECT * FROM ViewCity WHERE CountryId = '" + searchCountryId + "' ORDER BY CityName ASC";
            Command = new SqlCommand(Query, Connection);

            List<ViewCity> aList = new List<ViewCity>();

            Connection.Open();
            Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                ViewCity aViewCity = new ViewCity();

                aViewCity.CityName = Reader["CityName"].ToString();
                aViewCity.CityAbout = Reader["CityAbout"].ToString();
                aViewCity.NoOfDwellers = Convert.ToInt32(Reader["NoOfDwellers"]);
                aViewCity.Location = Reader["Location"].ToString();
                aViewCity.Weather = Reader["Weather"].ToString();
                aViewCity.CountryName = Reader["CountryName"].ToString();
                aViewCity.CountryAbout = Reader["CountryAbout"].ToString();

                aList.Add(aViewCity);
            }

            Reader.Close();
            Connection.Close();

            return aList;
        }
    }
}