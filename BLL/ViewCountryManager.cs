using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CountryCityInfoManagementSystemApp.DLL.Gateway;
using CountryCityInfoManagementSystemApp.DLL.Model.ViewModel;

namespace CountryCityInfoManagementSystemApp.BLL
{
    
    public class ViewCountryManager
    {
        ViewCountryGateway aViewCountryGateway=new ViewCountryGateway();
        public List<ViewCountry> GetAllViewCountry()
        {
            return aViewCountryGateway.GetAllViewCountry();
        }
        public List<ViewCountry> GetViewCountryBySearch(string search)
        {
            return aViewCountryGateway.GetViewCountryBySearch(search);
        }
    }
}