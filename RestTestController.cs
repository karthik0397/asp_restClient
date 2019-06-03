using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TestApplication.Controllers
{
    public class RestTestController : ApiController
    {
        [HttpGet]
        public string RestSharpTest()
        {
            string TestString = string.Empty;

            RestClient client = new RestClient("http://localhost:64210/");

            //client.Authenticator = new HttpBasicAuthenticator();

            RestRequest request = new RestRequest("api/Values/ReadValues");
            request.Method = Method.POST;

            //quest.AddHeader("Content-Type", "applcation/json");

            //request.AddParameter();

            IRestResponse response = client.Execute(request);

            if(response.StatusCode == HttpStatusCode.OK)
            {
                TestString = response.Content;
            }
            else
            {
                TestString = "StatusCode: " + response.StatusCode;
            }

            return TestString;
        }
    }
}
