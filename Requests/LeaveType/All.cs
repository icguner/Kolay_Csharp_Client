using RestSharp;
using c_expRestSharp.Auth;

namespace c_expRestSharp.Requests.LeaveType
{
    public class All:GetAuth
    {
        public void all()
        {
            (new KolayClient(client)).GET("/leave-type/all");
        }
    }
}