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
            
            if (DropDownList1.SelectedItem.Value == "Aries")
            {
                if (RadioButtonList1.SelectedValue == "Yesterday")
                {
                    string url = "https://horoscopeapi.justintruong.studio/api/get-horoscope/daily?sign=aries&day=yesterday";
                    var api = horoscope.getData(url);
                    paragraph.InnerText = api["data"].ToString();
                }

                else if(RadioButtonList1.SelectedValue == "Today")
                {
                    string url = "https://horoscopeapi.justintruong.studio/api/get-horoscope/daily?sign=aries&day=today";
                    var api = horoscope.getData(url);
                    paragraph.InnerText = api["data"].ToString();
                }

                else if(RadioButtonList1.SelectedValue == "Tomorrow")
                {
                    string url = "https://horoscopeapi.justintruong.studio/api/get-horoscope/daily?sign=aries&day=tomorrow";
                    var api = horoscope.getData(url);
                    paragraph.InnerText = api["data"].ToString();
                }

                else if(RadioButtonList1.SelectedValue == "Weekly")
                {
                    string url = "https://horoscopeapi.justintruong.studio/api/get-horoscope/weekly?sign=aries";
                    var api = horoscope.getData(url);
                    paragraph.InnerText = api["data"].ToString();
                }

                else if(RadioButtonList1.SelectedValue == "Monthly")
                {
                    string url = "https://horoscopeapi.justintruong.studio/api/get-horoscope/monthly?sign=aries";
                    var api = horoscope.getData(url);
                    paragraph.InnerText = api["data"].ToString();
                }
            }

            else if (DropDownList1.SelectedItem.Value == "Taurus")
            {
                if (RadioButtonList1.SelectedValue == "Yesterday")
                {
                    string url = "https://horoscopeapi.justintruong.studio/api/get-horoscope/daily?sign=taurus&day=yesterday";
                    var api = horoscope.getData(url);
                    paragraph.InnerText = api["data"].ToString();
                }

                else if (RadioButtonList1.SelectedValue == "Today")
                {
                    string url = "https://horoscopeapi.justintruong.studio/api/get-horoscope/daily?sign=taurus&day=today";
                    var api = horoscope.getData(url);
                    paragraph.InnerText = api["data"].ToString();
                }

                else if(RadioButtonList1.SelectedValue == "Tomorrow")
                {
                    string url = "https://horoscopeapi.justintruong.studio/api/get-horoscope/daily?sign=taurus&day=tomorrow";
                    var api = horoscope.getData(url);
                    paragraph.InnerText = api["data"].ToString();
                }

                else if(RadioButtonList1.SelectedValue == "Weekly")
                {
                    string url = "https://horoscopeapi.justintruong.studio/api/get-horoscope/weekly?sign=taurus";
                    var api = horoscope.getData(url);
                    paragraph.InnerText = api["data"].ToString();
                }

                else if(RadioButtonList1.SelectedValue == "Monthly")
                {
                    string url = "https://horoscopeapi.justintruong.studio/api/get-horoscope/monthly?sign=taurus";
                    var api = horoscope.getData(url);
                    paragraph.InnerText = api["data"].ToString();
                }
            }

            else if(DropDownList1.SelectedValue == "Gemini")
            {
                if(RadioButtonList1.SelectedValue == "Yesterday")
                {
                    string url = "https://horoscopeapi.justintruong.studio/api/get-horoscope/daily?sign=gemini&day=yesterday";
                    var api = horoscope.getData(url);
                    paragraph.InnerText = api["data"].ToString();
                }

                else if(RadioButtonList1.SelectedValue == "Today")
                {
                    string url = "https://horoscopeapi.justintruong.studio/api/get-horoscope/daily?sign=gemini&day=today";
                    var api = horoscope.getData(url);
                    paragraph.InnerText = api["data"].ToString();
                }

                else if(RadioButtonList1.SelectedValue == "Tomorrow")
                {
                    string url = "https://horoscopeapi.justintruong.studio/api/get-horoscope/daily?sign=gemini&day=today";
                    var api = horoscope.getData(url);
                    paragraph.InnerText = api["data"].ToString();
                }

                else if(RadioButtonList1.SelectedValue == "Weekly")
                {
                    string url = "https://horoscopeapi.justintruong.studio/api/get-horoscope/weekly?sign=gemini";
                    var api = horoscope.getData(url);
                    paragraph.InnerText = api["data"].ToString();
                }

                else if(RadioButtonList1.SelectedValue == "Monthly")
                {
                    string url = "https://horoscopeapi.justintruong.studio/api/get-horoscope/monthly?sign=gemini";
                    var api = horoscope.getData(url);
                    paragraph.InnerText = api["data"].ToString();
                }

            }

            else if (DropDownList1.SelectedValue == "Cancer")
            {
                if(RadioButtonList1.SelectedValue == "Yesterday")
                {
                    string url = "https://horoscopeapi.justintruong.studio/api/get-horoscope/daily?sign=cancer&day=yesterday";
                    var api = horoscope.getData(url);
                    paragraph.InnerText = api["data"].ToString();
                }

                else if(RadioButtonList1.SelectedValue == "Today")
                {
                    string url = "https://horoscopeapi.justintruong.studio/api/get-horoscope/daily?sign=cancer&day=today";
                    var api = horoscope.getData(url);
                    paragraph.InnerText = api["data"].ToString();
                }

                else if(RadioButtonList1.SelectedValue == "Tomorrow")
                {
                    string url = "https://horoscopeapi.justintruong.studio/api/get-horoscope/daily?sign=cancer&day=tomorrow";
                    var api = horoscope.getData(url);
                    paragraph.InnerText = api["data"].ToString();
                }

                else if(RadioButtonList1.SelectedValue == "Weekly")
                {
                    string url = "https://horoscopeapi.justintruong.studio/api/get-horoscope/weekly?sign=cancer";
                    var api = horoscope.getData(url);
                    paragraph.InnerText = api["data"].ToString();
                }

                else if(RadioButtonList1.SelectedValue == "Monthly")
                {
                    string url = "https://horoscopeapi.justintruong.studio/api/get-horoscope/monthly?sign=cancer";
                    var api = horoscope.getData(url);
                    paragraph.InnerText = api["data"].ToString();
                }
            }

            if(DropDownList1.SelectedValue == "Leo")
            {
                if(RadioButtonList1.SelectedValue == "Yesterday")
                {
                    string url = "https://horoscopeapi.justintruong.studio/api/get-horoscope/daily?sign=leo&day=yesterday";
                    var api = horoscope.getData(url);
                    paragraph.InnerText = api["data"].ToString();
                }

                else if(RadioButtonList1.SelectedValue == "Today")
                {
                    string url = "https://horoscopeapi.justintruong.studio/api/get-horoscope/daily?sign=leo&day=today";
                    var api = horoscope.getData(url);
                    paragraph.InnerText = api["data"].ToString();
                }

                else if(RadioButtonList1.SelectedValue == "Tomorrow")
                {
                    string url = "https://horoscopeapi.justintruong.studio/api/get-horoscope/daily?sign=leo&day=tomorrow";
                    var api = horoscope.getData(url);
                    paragraph.InnerText = api["data"].ToString();
                }

                else if(RadioButtonList1.SelectedValue == "Weekly")
                {
                    string url = "https://horoscopeapi.justintruong.studio/api/get-horoscope/weekly?sign=leo";
                    var api = horoscope.getData(url);
                    paragraph.InnerText = api["data"].ToString();
                }

                else if(RadioButtonList1.SelectedValue == "Monthly")
                {
                    string url = "https://horoscopeapi.justintruong.studio/api/get-horoscope/monthly?sign=leo";
                    var api = horoscope.getData(url);
                    paragraph.InnerText = api["data"].ToString();
                }
            }

            if(DropDownList1.SelectedValue == "Virgo")
            {
                if(RadioButtonList1.SelectedValue == "Yesterday")
                {
                    string url = "https://horoscopeapi.justintruong.studio/api/get-horoscope/daily?sign=virgo&day=yesterday";
                    var api = horoscope.getData(url);
                    paragraph.InnerText = api["data"].ToString();
                }

                else if(RadioButtonList1.SelectedValue == "Today")
                {
                    string url = "https://horoscopeapi.justintruong.studio/api/get-horoscope/daily?sign=virgo&day=today";
                    var api = horoscope.getData(url);
                    paragraph.InnerText = api["data"].ToString();
                }

                else if(RadioButtonList1.SelectedValue == "Tomorrow")
                {
                    string url = "https://horoscopeapi.justintruong.studio/api/get-horoscope/daily?sign=virgo&day=tomorrow";
                    var api = horoscope.getData(url);
                    paragraph.InnerText = api["data"].ToString();
                }

                else if(RadioButtonList1.SelectedValue == "Weekly")
                {
                    string url = "https://horoscopeapi.justintruong.studio/api/get-horoscope/weekly?sign=virgo";
                    var api = horoscope.getData(url);
                    paragraph.InnerText = api["data"].ToString();
                }

                else if(RadioButtonList1.SelectedValue == "Monthly")
                {
                    string url = "https://horoscopeapi.justintruong.studio/api/get-horoscope/monthly?sign=virgo";
                    var api = horoscope.getData(url);
                    paragraph.InnerText = api["data"].ToString();
                }
            }

            if(DropDownList1.SelectedValue == "Libra")
            {
                if(RadioButtonList1.SelectedValue == "Yesterday")
                {
                    string url = "https://horoscopeapi.justintruong.studio/api/get-horoscope/daily?sign=libra&day=yesterday";
                    var api = horoscope.getData(url);
                    paragraph.InnerText = api["data"].ToString();
                }

                else if(RadioButtonList1.SelectedValue == "Today")
                {
                    string url = "https://horoscopeapi.justintruong.studio/api/get-horoscope/daily?sign=libra&day=today";
                    var api = horoscope.getData(url);
                    paragraph.InnerText = api["data"].ToString();
                }

                else if(RadioButtonList1.SelectedValue == "Tomorrow")
                {
                    string url = "https://horoscopeapi.justintruong.studio/api/get-horoscope/daily?sign=libra&day=tomorrow";
                    var api = horoscope.getData(url);
                    paragraph.InnerText = api["data"].ToString();
                }

                else if(RadioButtonList1.SelectedValue == "Weekly")
                {
                    string url = "https://horoscopeapi.justintruong.studio/api/get-horoscope/weekly?sign=libra";
                    var api = horoscope.getData(url);
                    paragraph.InnerText = api["data"].ToString();
                }

                else if (RadioButtonList1.SelectedValue == "Monthly")
                {
                    string url = "https://horoscopeapi.justintruong.studio/api/get-horoscope/monthly?sign=libra";
                    var api = horoscope.getData(url);
                    paragraph.InnerText = api["data"].ToString();
                }
            }
           
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}