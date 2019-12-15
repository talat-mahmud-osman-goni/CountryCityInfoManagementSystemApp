using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CountryCityInfoManagementSystemApp.DLL.Gateway;
using CountryCityInfoManagementSystemApp.DLL.Model;

namespace CountryCityInfoManagementSystemApp.BLL
{
    public class CountryManager
    {
        CountryGateway aCountryGateway=new CountryGateway();
        public string SaveCountry(Country aCountry)
        {
            if (aCountry.CountryName == "" || aCountry.CountryAbout == "")
            {
                return "Please Enter All Field";
            }
            else
            {
                if (aCountryGateway.IsCountryNameExists(aCountry.CountryName) != null)
                {
                    return "Country name already exists";
                }
                else
                {
                    if (aCountryGateway.SaveCountry(aCountry) > 0)
                    {
                        return "Country Saved Successfully";
                    }
                    else
                    {
                        return "Save Failed";
                    }
                }
                
            }
            
        }
        public List<Country> GetAllCountry()
        {
            return aCountryGateway.GetAllCountry();
        }
    }
}