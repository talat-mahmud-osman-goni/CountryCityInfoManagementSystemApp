using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CountryCityInfoManagementSystemApp.BLL;
using CountryCityInfoManagementSystemApp.DLL.Model;

namespace CountryCityInfoManagementSystemApp.UI
{
    public partial class CityEntry : System.Web.UI.Page
    {
        CityManager aCityManager=new CityManager();
        City aCity=new City();
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
            List<Country> aList = aCityManager.GetCounties();
            countryDropDownList.DataSource = aList;
            countryDropDownList.DataTextField = "CountryName";
            countryDropDownList.DataValueField = "Id";
            countryDropDownList.DataBind();

        }
        public void PopulateCityGridView()
        {
            List<CityWithCountry> aList = aCityManager.GetAllCityWithCountry();
            cityGridView.DataSource = aList;
            cityGridView.DataBind();

        }
        public void resetField()
        {

            citynameTextBox.Text = string.Empty;
            cityAboutEditor.Content = string.Empty;
            noOfDwellersTextBox.Text = string.Empty;
            locationTextBo.Text = string.Empty;
            weatherTextBox.Text = string.Empty;

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            aCity.CityName = citynameTextBox.Text;
            aCity.CityAbout = cityAboutEditor.Content;
            aCity.NoOfDwellers = Convert.ToInt32(noOfDwellersTextBox.Text);
            aCity.Location = locationTextBo.Text;
            aCity.Weather = weatherTextBox.Text;
            aCity.CountryId = Convert.ToInt32(countryDropDownList.SelectedValue);
            messageLabel.Text = aCityManager.SaveCity(aCity);

            PopulateCityGridView();
            resetField();
        }

        protected void cancelButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomeUI.aspx");
        }
    }
}