using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CountryCityInfoManagementSystemApp.DLL.Model
{
    public class CityWithCountry
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        public long NoOfDwellers { get; set; }
        public string CountryName { get; set; }

    }
}