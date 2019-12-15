using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CountryCityInfoManagementSystemApp.BLL;
using CountryCityInfoManagementSystemApp.DLL.Model;
using CountryCityInfoManagementSystemApp.DLL.Model.ViewModel;

namespace CountryCityInfoManagementSystemApp.UI
{
    public partial class ViewCities : System.Web.UI.Page
    {
        ViewCityManager aViewCityManager=new ViewCityManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCountryDropDownList();
            }
            PopulateCityGridView();
        }
        public void LoadCountryDropDownList()
        {
            List<Country> aList = aViewCityManager.GetCounties();
            countryDropDownList.DataSource = aList;
            countryDropDownList.DataTextField = "CountryName";
            countryDropDownList.DataValueField = "Id";
            countryDropDownList.DataBind();

        }

        public void PopulateCityGridView()
        {
            List<ViewCity> aList = aViewCityManager.GetAllCityAndCountry();
            viewCitiesGridView.DataSource = aList;
            viewCitiesGridView.DataBind();

        }
        protected void viewCitiesGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            viewCitiesGridView.PageIndex = e.NewPageIndex;
            if (searchRadioButtonList.SelectedValue == "CityName")
            {
                GetViewCityByCity();


            }
            else if (searchRadioButtonList.SelectedValue == "CountryName")
            {
                GetViewCityByCountry();
            }

            else
            {
                PopulateCityGridView();
            }

        }

        public void GetViewCityByCity()
        {
            string searchKey = citySearchTextBox.Text;
            List<ViewCity> aList = aViewCityManager.GetViewCityByCity(searchKey);
            viewCitiesGridView.DataSource = aList;
            viewCitiesGridView.DataBind();
        }

        public void GetViewCityByCountry()
        {
            int searchCountryId = Convert.ToInt32(countryDropDownList.SelectedValue);
            List<ViewCity> aList = aViewCityManager.GetViewCityByCountry(searchCountryId);
            viewCitiesGridView.DataSource = aList;
            viewCitiesGridView.DataBind();
        }
        protected void searchButton_Click(object sender, EventArgs e)
        {
            if (searchRadioButtonList.SelectedValue == "CityName")
            {
                GetViewCityByCity();
            }
            else if (searchRadioButtonList.SelectedValue == "CountryName")
            {
                GetViewCityByCountry();
            }
            else
            {
                messageLabel.Text = "Please Select a button";
            }

            
        }
    }
}