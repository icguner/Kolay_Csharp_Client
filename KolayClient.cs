using RestSharp;
using System;
using System.Collections.Generic;
using RestSharp.Authenticators;
using Newtonsoft.Json;
using KolayCsharp_Client.Requests.Models;
namespace KolayCsharp_Client
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
        public void POST(string endpoint, Request requestData)
        {
            var request = new RestRequest(endpoint, Method.POST);
            request.AddJsonBody(requestData);
            IRestResponse response = client.Execute(request);
            var jsonedResponse = JsonConvert.DeserializeObject(response.Content);
            Console.WriteLine(requestData);
            Console.WriteLine(jsonedResponse);
        }
    }
}