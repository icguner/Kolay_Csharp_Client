using KolayCsharp_Client.Requests.Models;
namespace KolayCsharp_Client.Requests.Person
{
    public class GetList: GetAuth
    {
        public void getList()
        {
            var Query = new GetListModel.ListModel
            {
                page = 1,
                q = "",
                status = true,
                units = "" // not working
            };
            (new KolayClient(client)).POST("/person/search", Query);
        }
    }
}