using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CountryCityInfoManagementSystemApp.DLL.Model.ViewModel
{
    public class ViewCity
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        public string CityAbout { get; set; }
        public int NoOfDwellers { get; set; }
        public string Location { get; set; }
        public string Weather { get; set; }
        public string CountryName { get; set; }
        public string CountryAbout { get; set; }
    }
}