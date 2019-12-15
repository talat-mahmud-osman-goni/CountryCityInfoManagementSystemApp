using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using CountryCityInfoManagementSystemApp.DLL.Model;

namespace CountryCityInfoManagementSystemApp.DLL.Gateway
{
    public class CityGateway :CommonGateway
    {
        public int SaveCity(City aCity)
        {
            Query = "INSERT INTO City VALUES ('" + aCity.CityName + "','" + aCity.CityAbout+ "','"+aCity.NoOfDwellers+"','"+aCity.Location+"','"+aCity.Weather+"','"+aCity.CountryId+"')";

            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }
        public City IsCityNameExists(string cityName)
        {
            Query = "SELECT * FROM City WHERE CityName='" + cityName + "'";

            Command = new SqlCommand(Query, Connection);

            Connection.Open();
            Reader = Command.ExecuteReader();

            City aCity = null;
            if (Reader.HasRows)
            {
                Reader.Read();
                aCity = new City();

                aCity.CityName = Reader["CityName"].ToString();
                //aCity.CityAbout = Reader["CityAbout"].ToString();
                //aCity.NoOfDwellers = Convert.ToInt32(Reader["NoOfDwellers"]);
                //aCity.Location = Reader["Location"].ToString();
                //aCity.Weather = Reader["Weather"].ToString();
                //aCity.CountryId = Convert.ToInt32(Reader["CountryId"]);



            }

            Reader.Close();
            Connection.Close();
            return aCity;
        }
        public List<CityWithCountry> GetAllCityWithCountry()
        {
            Query = "SELECT * FROM CityWithCountry ORDER BY CityName ASC";

            Command = new SqlCommand(Query, Connection);

            List<CityWithCountry> aList = new List<CityWithCountry>();

            Connection.Open();
            Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                CityWithCountry aCityWithCountry = new CityWithCountry();

                aCityWithCountry.CityName = Reader["CityName"].ToString();
                aCityWithCountry.NoOfDwellers = Convert.ToInt32(Reader["NoOfDwellers"]);
                aCityWithCountry.CountryName = Reader["CountryName"].ToString();

                aList.Add(aCityWithCountry);
            }

            Reader.Close();
            Connection.Close();

            return aList;

        }

    }
}