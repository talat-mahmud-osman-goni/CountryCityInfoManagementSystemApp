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
    public partial class CountryEntryUI : System.Web.UI.Page
    {
        CountryManager aCountryManager = new CountryManager();
        Country aCountry = new Country();
        protected void Page_Load(object sender, EventArgs e)
        {
            PopulateCountryGridView();
        }
        
        public void PopulateCountryGridView()
        {
            List<Country> aList = aCountryManager.GetAllCountry();
            countryGridView.DataSource = aList;
            countryGridView.DataBind();

        }
        public void resetField()
        {
            countryNameTextBox.Text = string.Empty;
            CountryAboutEditor.Content = string.Empty;

        }
        protected void saveButton_Click(object sender, EventArgs e)
        {
            
            aCountry.CountryName = countryNameTextBox.Text;
            aCountry.CountryAbout = CountryAboutEditor.Content;
            showLabel.Text=aCountryManager.SaveCountry(aCountry);
            resetField();
            PopulateCountryGridView();
        }

        protected void cancelButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomeUI.aspx");
        }
    }
}