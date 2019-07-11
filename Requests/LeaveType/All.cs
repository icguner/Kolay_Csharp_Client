using RestSharp;
using KolayCsharp_Client.Auth;

namespace KolayCsharp_Client.Requests.LeaveType
{
    public class All:GetAuth
    {
        public void all()
        {
            (new KolayClient(client)).GET("/leave-type/all");
        }
    }
}