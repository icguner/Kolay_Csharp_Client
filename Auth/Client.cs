using RestSharp;

namespace KolayCsharp_Client.Auth
{
    public class Client
    {
        protected RestClient client;

        public Client(RestClient restClient)
        {
            client = restClient;
        }
    }
}
