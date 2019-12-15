using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using CountryCityInfoManagementSystemApp.DLL.Model;

namespace CountryCityInfoManagementSystemApp.DLL.Gateway
{
    public class CountryGateway:CommonGateway
    {
        public int SaveCountry(Country aCountry)
        {
            Query = "INSERT INTO Country VALUES ('" + aCountry.CountryName + "','" + aCountry.CountryAbout + "')";

            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }
        public Country IsCountryNameExists(string countryName)
        {
            Query = "SELECT * FROM Country WHERE CountryName='" + countryName + "'";

            Command = new SqlCommand(Query, Connection);

            Connection.Open();
            Reader = Command.ExecuteReader();

            Country aCountry = null;
            if (Reader.HasRows)
            {
                Reader.Read();
                aCountry = new Country();
                
                aCountry.CountryName = Reader["CountryName"].ToString();
                aCountry.CountryAbout = Reader["CountryAbout"].ToString();
             
            }
            
            Reader.Close();
            Connection.Close();
            return aCountry;
        }
        public List<Country> GetAllCountry()
        {
            Query = "SELECT * FROM Country ORDER BY CountryName ASC";
            Command = new SqlCommand(Query, Connection);

            Connection.Open();
            Reader = Command.ExecuteReader();

            List<Country> aList = new List<Country>();
            while (Reader.Read())
            {
                Country aCountry = new Country();

                
                aCountry.CountryName = Reader["CountryName"].ToString();
                aCountry.CountryAbout = Reader["CountryAbout"].ToString();
                aList.Add(aCountry);
            }
            Reader.Close();
            Connection.Close();

            return aList;
        }

        public List<Country> GetCountries()
        {
            Query = "SELECT * FROM Country ORDER BY CountryName ASC";
            Command = new SqlCommand(Query, Connection);

            Connection.Open();
            Reader = Command.ExecuteReader();

            List<Country> aList = new List<Country>();
            while (Reader.Read())
            {
                Country aCountry = new Country();

                aCountry.Id = Convert.ToInt32(Reader["Id"]);
                aCountry.CountryName = Reader["CountryName"].ToString();
                aList.Add(aCountry);
            }
            Reader.Close();
            Connection.Close();

            return aList;
        }

    }
}