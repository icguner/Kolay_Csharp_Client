using RestSharp;
using KolayCsharp_Client.Auth;

namespace KolayCsharp_Client.Requests.CustomField
{
    public class GetCustomFields:GetAuth
    {
        public void getCustomFields()
        {
            (new KolayClient(client)).GET("/company/custom-fields");
        }
    }
}