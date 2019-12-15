using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CountryCityInfoManagementSystemApp.DLL.Gateway;
using CountryCityInfoManagementSystemApp.DLL.Model;
using CountryCityInfoManagementSystemApp.DLL.Model.ViewModel;

namespace CountryCityInfoManagementSystemApp.BLL
{
    public class ViewCityManager
    {
        ViewCityGateway aViewCityGateway=new ViewCityGateway();
        public List<ViewCity> GetAllCityAndCountry()
        {
            return aViewCityGateway.GetAllCityAndCountry();
        }
        public List<Country> GetCounties()
        {
            CountryGateway aCountryGateway = new CountryGateway();
            return aCountryGateway.GetCountries();
        }

        public List<ViewCity> GetViewCityByCity(string searchKey)
        {

            return aViewCityGateway.GetViewCityByCity(searchKey);
        }
        public List<ViewCity> GetViewCityByCountry(int searchCountryId)
        {

            return aViewCityGateway.GetViewCityByCountry(searchCountryId);
        }
    }
}