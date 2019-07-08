using System;
using RestSharp;
using RestSharp.Authenticators;
using Newtonsoft.Json;

namespace c_expRestSharp
{
    public class GetAuth
    {
        private AuthTokens authTokens = new AuthTokens();
        private AuthCredentials authCredentials = new AuthCredentials();

        public RestClient client;

        public GetAuth()
        {
            getAuth();
        }

        public void getAuth()
        {   
            client = new RestClient(authCredentials.baseUrl + authCredentials.apiVersion + "/");
            client.Authenticator = new SimpleAuthenticator("username", authCredentials.username, "password", authCredentials.password);
            var request = new RestRequest("public/authenticate", Method.GET);
            IRestResponse response = client.Execute(request);
            AuthTokens authTokens = JsonConvert.DeserializeObject<AuthTokens>(response.Content);
            client.AddDefaultHeader("Authorization", string.Format("Bearer {0}", authTokens.data.auth_token));
        }
    }
}