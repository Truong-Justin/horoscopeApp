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
            if (DropDownList1.SelectedIndex != 0)
            {
                string url = logic.GetUrl(RadioButtonList1.SelectedValue, DropDownList1.SelectedValue);
                paragraph.InnerText = url;
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