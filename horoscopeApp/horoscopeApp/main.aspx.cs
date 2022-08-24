using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


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