using RestSharp;
using System;
using System.Collections.Generic;
using RestSharp.Authenticators;
using Newtonsoft.Json;
namespace c_expRestSharp
{
    public class KolayClient
    {   
        public static AuthCredentials authCredentials = new AuthCredentials();
        public RestClient client;
        
        public KolayClient(RestClient restClient)
        {
            client = restClient;
        }

        public void GET(string endpoint)
        {
            var request = new RestRequest(endpoint, Method.GET);
            IRestResponse response = client.Execute(request);
            var jsonedResponse = JsonConvert.DeserializeObject(response.Content);
            Console.WriteLine(jsonedResponse);
        }
        public void POST(string endpoint , params (string Parameter, object Value)[] pairs)
        {
            var request = new RestRequest(endpoint, Method.POST);
            foreach (var pair in pairs)
            {
                Console.WriteLine($"{pair.Parameter} = {pair.Value}");
                request.AddParameter(pair.Parameter, pair.Value);
            }
            IRestResponse response = client.Execute(request);
            var jsonedResponse = JsonConvert.DeserializeObject(response.Content);
            Console.WriteLine(jsonedResponse);
        }
    }
}