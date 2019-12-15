using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CountryCityInfoManagementSystemApp.DLL.Gateway;
using CountryCityInfoManagementSystemApp.DLL.Model;

namespace CountryCityInfoManagementSystemApp.BLL
{
    public class CityManager
    {
        
        CityGateway aCityGateway=new CityGateway();

        public string SaveCity(City aCity)
        {
            if (aCity.CityName == "" || aCity.CityAbout == "" || aCity.NoOfDwellers == null || aCity.Location == "" || aCity.Weather == "")
            {
                return "Please Enter All Field";
            }
            else if (aCity.NoOfDwellers < 0)
            {
                return "No. of dwellers can not be zero or negative value";
            }
            else
            {
                if (aCityGateway.IsCityNameExists(aCity.CityName) != null)
                {
                    return "City name already exists";
                }
               
                else
                {
                    if (aCityGateway.SaveCity(aCity) > 0)
                    {
                        return "City Saved Successfully";
                    }
                    else
                    {
                        return "Save Failed";
                    }
                }
            }
        }
        public List<CityWithCountry> GetAllCityWithCountry()
        {
            return aCityGateway.GetAllCityWithCountry();
        }
        public List<Country> GetCounties()
        {
            CountryGateway aCountryGateway=new CountryGateway();
            return aCountryGateway.GetCountries();
        }
    }
}