using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CountryCityInfoManagementSystemApp.BLL;
using CountryCityInfoManagementSystemApp.DLL.Model.ViewModel;

namespace CountryCityInfoManagementSystemApp.UI
{
    public partial class ViewCountrysUI : System.Web.UI.Page
    {
        private ViewCountryManager aViewCountryManager = new ViewCountryManager();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PopulateCountryGridView();
            }

        }

        public void PopulateCountryGridView()
        {
            List<ViewCountry> aList = aViewCountryManager.GetAllViewCountry();
            viewCountryGridView.DataSource = aList;
            viewCountryGridView.DataBind();
        }

        protected void viewCountryGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            viewCountryGridView.PageIndex = e.NewPageIndex;
            SearchKey();
        }

        public void SearchKey()
        {
            string search = countrySearchTextBox.Text;
            List<ViewCountry> aList = aViewCountryManager.GetViewCountryBySearch(search);
            viewCountryGridView.DataSource = aList;
            viewCountryGridView.DataBind();
        }
        protected void searchButton_Click(object sender, EventArgs e)
        {
            SearchKey();
        }
    }
}