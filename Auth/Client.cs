using RestSharp;

namespace c_expRestSharp.Auth
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
