using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CountryCityInfoManagementSystemApp.DLL.Model.ViewModel
{
    public class ViewCountry
    {
        public int Id { get; set; }
        public string CountryName { get; set; }
        public string CountryAbout { get; set; }
        public int NoOfCities { get; set; }
        public long NoOfCityDwellers { get; set; }

    }
}