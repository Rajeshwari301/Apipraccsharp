using System.Net;
using TechTalk.SpecFlow.Infrastructure;
using System.Net.Http;
using static Apiprac.Utils.Settings;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Apiprac.Support;

namespace Apiprac.Utils
{


    public class Baseapi

    {
        public  HttpClient httpClient;
        public  HttpResponseMessage response;
        public  HttpStatusCode statusCode;
        private readonly ISpecFlowOutputHelper _OutputHelper;
        Settings url = new Settings();
        

        public Baseapi(ISpecFlowOutputHelper OutputHelper)
        {
            httpClient = new HttpClient();
            _OutputHelper = OutputHelper;
        }
        
        public  void sendinggetrequest()

        {
            url.geturl = "https://reqres.in/api/users/2";
            //httpClient = new HttpClient();
            Uri uri = new Uri(url.geturl);
            Task<HttpResponseMessage> httpResponse = httpClient.GetAsync(url.geturl);
            response = httpResponse.Result;
            Console.WriteLine(response.ToString());
            //Status code
            statusCode = response.StatusCode;
            _OutputHelper.WriteLine("Statuscode" + statusCode);
            _OutputHelper.WriteLine("Statuscode" + (int)statusCode);
            //Content 
            HttpContent content = response.Content;
            Task<String> responsebody = content.ReadAsStringAsync();
            String body = responsebody.Result;
            _OutputHelper.WriteLine(body);
            var des = JsonConvert.DeserializeObject<getdatamodel>(body);
            _OutputHelper.WriteLine(des.data.email.ToString());
            
            
        }

        public  void assertgetstatuscode(int status)
        {
            Assert.True((int)statusCode == status);
            _OutputHelper.WriteLine(url.geturl);

        }


    }
}

