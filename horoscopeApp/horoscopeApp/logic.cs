using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Newtonsoft.Json.Linq;

namespace horoscopeApp
{
    public class logic
    {
        public static JObject GetData(string endpoint)
        {

            try
            {
                //make WebRequest object named request,
                //and set Method attribute as "GET"
                var url = endpoint;
                var request = WebRequest.Create(url);
                request.Method = "GET";

                //GetResponse() method returns a webResponse object
                //that contains the response from Internet resource;
                //GetResponseStream() method returns a webStream object
                //that has the body of the response;
                var webResponse = request.GetResponse();
                var webStream = webResponse.GetResponseStream();

                //make reader object object using the StreamReader class;
                //reader object reads the webstream and
                //saves data in data variable
                var reader = new StreamReader(webStream);
                var data = reader.ReadToEnd();

                //JObject object made named horoscope made with parsed data;
                JObject horoscope = JObject.Parse(data);

                return horoscope;
            }

            catch (UriFormatException)
            {

                JObject error = new JObject();
                error.Add("data", "(Invalid Zodiac Sign)");

                return error;
            }
        }

        public static string GetUrl(string day, string sign)
        {
            //url strings are used to build the correct url endpoint using String.Format()
            string daily = "https://horoscopeapiv1.azurewebsites.net/api/get-horoscope/daily?sign={0}&day={1}";
            string weekly = "https://horoscopeapiv1.azurewebsites.net/api/get-horoscope/weekly?sign={0}";
            string monthly = "https://horoscopeapiv1.azurewebsites.net/api/get-horoscope/monthly?sign={0}";

            //specific endpoint is mapped to user's selection and returned
            var dict = new Dictionary<(string, string), string>
            {
                {("Yesterday", "Aries"), String.Format(daily, sign, day)},
                {("Today", "Aries"), String.Format(daily, sign, day)},
                {("Tomorrow", "Aries"), String.Format(daily, sign, day)},
                {("Weekly", "Aries"), String.Format(weekly, sign, day)},
                {("Monthly", "Aries"), String.Format(monthly, sign, day)},

                {("Yesterday", "Taurus"), String.Format(daily, sign, day)},
                {("Today", "Taurus"), String.Format(daily, sign, day)},
                {("Tomorrow", "Taurus"), String.Format(daily, sign, day)},
                {("Weekly", "Taurus"), String.Format(weekly, sign, day)},
                {("Monthly", "Taurus"), String.Format(monthly, sign, day)},

                {("Yesterday", "Gemini"), String.Format(daily, sign, day)},
                {("Today", "Gemini"), String.Format(daily, sign, day)},
                {("Tomorrow", "Gemini"), String.Format(daily, sign, day)},
                {("Weekly", "Gemini"), String.Format(weekly, sign, day)},
                {("Monthly", "Gemini"), String.Format(monthly, sign, day)},

                {("Yesterday", "Cancer"), String.Format(daily, sign, day)},
                {("Today", "Cancer"), String.Format(daily, sign, day)},
                {("Tomorrow", "Cancer"), String.Format(daily, sign, day)},
                {("Weekly", "Cancer"), String.Format(weekly, sign, day)},
                {("Monthly", "Cancer"), String.Format(monthly, sign, day)},

                {("Yesterday", "Leo"), String.Format(daily, sign, day)},
                {("Today", "Leo"), String.Format(daily, sign, day)},
                {("Tomorrow", "Leo"), String.Format(daily, sign, day)},
                {("Weekly", "Leo"), String.Format(weekly, sign, day)},
                {("Monthly", "Leo"), String.Format(monthly, sign, day)},

                {("Yesterday", "Virgo"), String.Format(daily, sign, day)},
                {("Today", "Virgo"), String.Format(daily, sign, day)},
                {("Tomorrow", "Virgo"), String.Format(daily, sign, day)},
                {("Weekly", "Virgo"), String.Format(weekly, sign, day)},
                {("Monthly", "Virgo"), String.Format(monthly, sign, day)},

                {("Yesterday", "Libra"), String.Format(daily, sign, day)},
                {("Today", "Libra"), String.Format(daily, sign, day)},
                {("Tomorrow", "Libra"), String.Format(daily, sign, day)},
                {("Weekly", "Libra"), String.Format(weekly, sign, day)},
                {("Monthly", "Libra"), String.Format(monthly, sign, day)},

                {("Yesterday", "Scorpio"), String.Format(daily, sign, day)},
                {("Today", "Scorpio"), String.Format(daily, sign, day)},
                {("Tomorrow", "Scorpio"), String.Format(daily, sign, day)},
                {("Weekly", "Scorpio"), String.Format(weekly, sign, day)},
                {("Monthly", "Scorpio"), String.Format(monthly, sign, day)},

                {("Yesterday", "Sagittarius"), String.Format(daily, sign, day)},
                {("Today", "Sagittarius"), String.Format(daily, sign, day)},
                {("Tomorrow", "Sagittarius"), String.Format(daily, sign, day)},
                {("Weekly", "Sagittarius"), String.Format(weekly, sign, day)},
                {("Monthly", "Sagittarius"), String.Format(monthly, sign, day)},

                {("Yesterday", "Capricorn"), String.Format(daily, sign, day)},
                {("Today", "Capricorn"), String.Format(daily, sign, day)},
                {("Tomorrow", "Capricorn"), String.Format(daily, sign, day)},
                {("Weekly", "Capricorn"), String.Format(weekly, sign, day)},
                {("Monthly", "Capricorn"), String.Format(monthly, sign, day)},

                {("Yesterday", "Aquarius"), String.Format(daily, sign, day)},
                {("Today", "Aquarius"), String.Format(daily, sign, day)},
                {("Tomorrow", "Aquarius"), String.Format(daily, sign, day)},
                {("Weekly", "Aquarius"), String.Format(weekly, sign, day)},
                {("Monthly", "Aquarius"), String.Format(monthly, sign, day)},

                {("Yesterday", "Pisces"), String.Format(daily, sign, day)},
                {("Today", "Pisces"), String.Format(daily, sign, day)},
                {("Tomorrow", "Pisces"), String.Format(daily, sign, day)},
                {("Weekly", "Pisces"), String.Format(weekly, sign, day)},
                {("Monthly", "Pisces"), String.Format(monthly, sign, day)}
            };

            try
            {
                    return dict[(day, sign)];
            }

            catch(KeyNotFoundException)
            {
                return "Invalid";
            }


        }
    }
}