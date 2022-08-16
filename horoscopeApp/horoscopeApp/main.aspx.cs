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
        logic horoscope = new logic();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedItem.Value == "Aries" && RadioButtonList1.SelectedValue == "Daily")
            {
                string url = "https://horoscopeapi.justintruong.studio/api/get-horoscope/daily?sign=aries&day=today";
                var api = horoscope.getData(url);
                paragraph.InnerText = api["data"].ToString();
            }

            else if (DropDownList1.SelectedItem.Value == "Taurus")
            {
                string url = "https://horoscopeapi.justintruong.studio/api/get-horoscope/daily?sign=taurus&day=today";
                var api = horoscope.getData(url);
                paragraph.InnerText = api["data"].ToString();
            }
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}