using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace horoscopeApp
{
    public class logic
    {
        public JObject getData(string endpoint)
        {
            //make WebRequest object named request,
            //and set Method attribute as "GET"
            var url = endpoint;
            var request = WebRequest.Create(url);
            request.Method = "GET";

            //GetResponse() method returns a WebResponse
            //that contains the response from Internet resource;
            //GetResponseStream() method returns the body of the response
            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();

            //make StreamReader object using the webstream
            //named reader;
            //reader object reads the webstream and
            //saves data in data variable
            var reader = new StreamReader(webStream);
            var data = reader.ReadToEnd();

            //JObject object made named api made with parsed data;
            //
            JObject horoscope = JObject.Parse(data);

            return horoscope;
        }
    }
}