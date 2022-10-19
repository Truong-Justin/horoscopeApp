using System;



namespace horoscopeApp
{
    public partial class main : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            //If this is the first time the webpage is rendered, do nothing;
            //Otherwise, return the horoscope data
            if (IsPostBack)
            {
                string url = logic.GetUrl(RadioButtonList1.SelectedValue, DropDownList1.SelectedValue);
                var api = logic.GetData(url);
                paragraph.InnerText = (string)api["data"];
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}