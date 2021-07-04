using Azure.Communication.Sms;
using RestSharp;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Mail;
using System.Threading.Tasks;
using Vonage;
using Vonage.Request;

namespace ConsoleAppSms1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            
            var client = new RestClient("https://clicksend.p.rapidapi.com/sms/send");
            var request = new RestRequest(Method.POST);
            request.AddHeader("content-type", "application/json");
            request.AddHeader("authorization", "Basic bXVoYW1tYWRz..............................");
            request.AddHeader("x-rapidapi-key", "cdb8026a9................................");
            request.AddHeader("x-rapidapi-host", "clicksend.p.rapidapi.com");
            request.AddParameter("application/json", "{" +
                "\"messages\": [" +
                "{" +
                "\"source\": \"mashape\"," +
                "\"from\": \"Test\"," +
                "\"body\": \"Your Message Body\"," +
                "\"to\": \"+92334.........\"," +
                "\"schedule\": \"1452244637\"," +
                "\"custom_string\": \"this is a test\"" +
                "}" +
                "]" +
                "}", 
                ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            Console.WriteLine("SMS Sent!");
            Console.ReadKey();
        }
    }
}
